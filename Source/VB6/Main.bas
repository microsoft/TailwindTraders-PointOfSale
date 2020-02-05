Attribute VB_Name = "MainModule"
' Products Information is accessed thru a WebAPI
' The URL for accessing that API is read from an INI file
Dim URL_PRODUCT_API As String

' The Cash Drawer must have a minimum amount in order to start a Shift
Dim MINIMUM_CASH As Integer

' The Connection String to use to open the Database
Dim ConnectionString As String

' The default POS user used to skip the log in process, to change the default POS user,
' modify the POSTerminal value in the TailwindPOS.ini file
Public PRESET_TERMINALID As Integer

' The Collection of POS users ID used to skip the log in process
Dim POSSystems As New Collection


Public CurrentPOS As New POSSystems
Public CurrentShift As New ShiftInfo
Public CurrentTicketID As Integer

Function CreateTicket(CustomerID As Integer, POSID As Integer, UserID As Integer) As Integer
Attribute CreateTicket.VB_UserMemId = 1610612751
    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    Dim command As New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Insert into Tickets(Ticket_Datetime, Total, Taxes, CustomerID,UserID,POSID, Status) " & _
    " values (@TicketDateTime, 0, 0, @CustomerID, @UserID, @POSID, 1)"
    command.Parameters.Append command.CreateParameter("@TicketDateTime", adDate, adParamInput, , Now())
    command.Parameters.Append command.CreateParameter("@CustomerID", adVarChar, adParamInput, 100, CustomerID)
    command.Parameters.Append command.CreateParameter("@UserID", adVarChar, adParamInput, 100, UserID)
    command.Parameters.Append command.CreateParameter("@POSID", adVarChar, adParamInput, 100, POSID)

    command.Execute
    
    
    Dim rs As ADODB.Recordset
    Set rs = conn.Execute("select @@identity")
    CreateTicket = rs(0)
End Function

Sub CompleteTicket(conn As ADODB.Connection, Total As Currency, taxes As Currency, POSID As Integer, UserID As Integer)
    Dim command As New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Update Tickets set Total = @Total, Taxes = @Taxes, Status = 0 " & _
    " Where POSID = @POSID and TicketID = @TicketID"
    command.Parameters.Append command.CreateParameter("@Total", adCurrency, adParamInput, , Total)
    command.Parameters.Append command.CreateParameter("@Taxes", adCurrency, adParamInput, , taxes)
    command.Parameters.Append command.CreateParameter("@POSID", adInteger, adParamInput, , POSID)
    command.Parameters.Append command.CreateParameter("@TicketID", adInteger, adParamInput, , UserID)
    command.Execute

End Sub

Sub EndShiftWithAmount(POSID As Integer, UserID As Integer, ShiftID As Date, StartCash As Currency)
Attribute EndShiftWithAmount.VB_UserMemId = 1610612741
    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    ' We need to insert the shift information
    Dim command As New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Update Shifts set EndShift = @EndShift, EndCash = @EndCash) " & _
    " where POSID = @POSID and UserID = @UserID and ShiftID = @ShiftID"
    command.Parameters.Append command.CreateParameter("@POSID", adNumeric, adParamInput, , POSID)
    command.Parameters.Append command.CreateParameter("@UserID", adNumeric, adParamInput, , UserID)
    command.Parameters.Append command.CreateParameter("@ShiftID", adNumeric, adParamInput, , StartShift)
    command.Parameters.Append command.CreateParameter("@EndShift", adDate, adParamInput, , Endshift)
    command.Parameters.Append command.CreateParameter("@EndCash", adNumeric, adParamInput, , EndCash)
    command.Execute
   
    conn.Close
End Sub

Function ExtractData(property As String, json As String, isnumber As Boolean)
Attribute ExtractData.VB_UserMemId = 1610612742
    Dim startindex As Integer
    ' we search inside the json string for "property": "value"
    startindex = InStr(1, json, """" & property & """:")
    If startindex > -1 Then
        startindex = startindex + Len(property) + 3
        If isnumber Then
            endindex = InStr(startindex, json, ",")
        Else
            endindex = InStr(startindex, json, """,")
            ' this is to skip the double quote
            startindex = startindex + 1
        End If
        If endindex > -1 Then
            ExtractData = Mid(json, startindex, endindex - startindex)
        End If
    End If
End Function

Function FindCustomers(customerInfo As String) As ADODB.Recordset
Attribute FindCustomers.VB_UserMemId = 1610612753
    Dim query As String
    query = "select * from Customers where LastName = @keyword " & _
    "Union  " & _
    "Select * from Customers where FirstName = @keyword  " & _
    "Union " & _
    "Select * from Customers where email = @keyword  "
    
    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    Dim objcommand As ADODB.command
    Set objcommand = New ADODB.command
    objcommand.ActiveConnection = conn
    objcommand.CommandText = query
    objcommand.Parameters.Append objcommand.CreateParameter("@keyword", adVarChar, adParamInput, 100, customerInfo)
    
    Dim rs As New ADODB.Recordset
    rs.CursorLocation = adUseClient
    rs.Open objcommand, , adOpenStatic
    rs.ActiveConnection = Nothing
    conn.Close
    Set FindCustomers = rs
End Function

Function FindProductByCode(productCode As String, ByRef ProductDescription As String, ByRef ProductPrice As Currency) As Boolean
Attribute FindProductByCode.VB_UserMemId = 1610612743
    Dim xmlhttp As New MSXML2.ServerXMLHTTP60
    xmlhttp.Open "GET", URL_PRODUCT_API & productCode, False
    xmlhttp.send
    Dim response As String
    ' was the response ok
    If xmlhttp.Status = 200 Then
    
        
        response = xmlhttp.responseText
        ProductDescription = ExtractData("name", xmlhttp.responseText, False)
        ProductPrice = ExtractData("price", xmlhttp.responseText, True)
        FindProductByCode = True
    Else
    FindProductByCode = False
        MsgBox "Product not found"
    End If
    
End Function


' Gets a Customer Description to show when a customer is chosen
Function GetCustomerInfo(CustomerID As Integer) As String
Attribute GetCustomerInfo.VB_UserMemId = 1610612754
    Dim query As String
    query = "select * from Customers where CustomerID = @CustomerID"
    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    Dim objcommand As ADODB.command
    Set objcommand = New ADODB.command
    objcommand.ActiveConnection = conn
    objcommand.CommandText = query
    objcommand.Parameters.Append objcommand.CreateParameter("@CustomerID", adNumeric, adParamInput, , CustomerID)
    
    Dim rs As New ADODB.Recordset
    rs.CursorLocation = adUseClient
    rs.Open objcommand, , adOpenStatic
    rs.ActiveConnection = Nothing
    conn.Close
    If rs.RecordCount > 0 Then
        Dim customerInfo As String
        GetCustomerInfo = rs("FirstName") & " " & rs("LastName") & vbCrLf & rs("Email")
    Else
        GetCustomerInfo = "Customer Info could not be loaded"
    End If
End Function

Function GetPOSSystems() As Collection
Attribute GetPOSSystems.VB_UserMemId = 1610612755
    Dim conn As ADODB.Connection
    Set conn = OpenConnection

    Dim command As ADODB.command
    Set command = New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Select * from POS"
    Dim rs As ADODB.Recordset
    Set rs = command.Execute
    Dim coll As Collection
    Set coll = New Collection
    If rs.RecordCount > 0 Then
        While Not rs.EOF
            Dim POS As POSSystems
            Set POS = New POSSystems
            POS.POSID = rs("POSID")
            POS.Branch = rs("Branch")
            POS.Location = rs("Location")
            POS.Phone = rs("Phone")
            POS.POSName = rs("POSName")
            coll.Add POS
            rs.MoveNext
        Wend
    End If
    Set GetPOSSystems = coll
End Function

Function IsShiftStarted() As Boolean
Attribute IsShiftStarted.VB_UserMemId = 1610612739
  IsShiftStarted = CurrentShift.ShiftID <> 0
End Function


Function RunCreditCardPayment(invoice As String, amount As String)
    strOut = "SUCCESS"
    RunCreditCardPayment = strOut
End Function

Sub Main()

    ReadConfig
    
    Set POSSystems = GetPOSSystems
    If PRESET_TERMINALID <> 0 Then
        For Each POS In POSSystems
            If POS.POSID = PRESET_TERMINALID Then
                Set CurrentPOS = POS
                Exit For
            End If
        Next
    End If
    
    ' If a POS was not selected we cannot continue
    If CurrentPOS.POSName <> "" Then
         frmSales.Show vbModal
    End If
End Sub

' Open the Database Connection
Function OpenConnection() As ADODB.Connection
Attribute OpenConnection.VB_UserMemId = 1610612752
    Dim conn As New ADODB.Connection
    conn.ConnectionString = ConnectionString
    conn.CursorLocation = adUseClient
    conn.Open
    Set OpenConnection = conn
End Function

Function PadAmount(amount As Currency) As String
Attribute PadAmount.VB_UserMemId = 1610612745
    PadAmount = Right(Space(50) & FormatCurrency(amount, 2), 15)
End Function

Function PaymentStringToID(paymentType As String)
Attribute PaymentStringToID.VB_UserMemId = 1610612748
    If paymentType = "Cash" Then
        PaymentStringToID = 1
    ElseIf paymentType = "Check" Then
        PaymentStringToID = 2
    ElseIf paymentType = "Credit" Then
        PaymentStringToID = 3
    ElseIf paymentType = "Gift Card" Then
        PaymentStringToID = 4
    End If
    
End Function

Sub ReadConfig()
    ConnectionString = ReadConfigSetting("Connection String", "DatabaseConnectionString", ".\TailwindPOS.ini")
    URL_PRODUCT_API = ReadConfigSetting("Products", "ProductsWebAPIURL", ".\TailwindPOS.ini")
    MINIMUM_CASH = ReadConfigSetting("CashDrawer", "MinimumCash", ".\TailwindPOS.ini")
    PRESET_TERMINALID = ReadConfigSetting("Pos", "POSTerminal", ".\TailwindPOS.ini")
End Sub

Sub RegisterBreakEnd(POSID As Integer, ShiftID As Integer, BreakId As Integer, EndTime As Date)
Attribute RegisterBreakEnd.VB_UserMemId = 1610612757

    Dim conn As ADODB.Connection
    conn = OpenConnection
    Dim objcommand As ADODB.command
    Set objcommand = New ADODB.command
    objcommand.ActiveConnection = conn
    objcommand.CommandText = "UPDATE Breaks Set EndTime = @EndTime where" & _
    " POSID = @POSID, ShiftID = @ShiftID, BreakID = @BreakID"
    objcommand.Parameters.Append objcommand.CreateParameter("@POSID", adNumeric, adParamInput, , FirstName)
    objcommand.Parameters.Append objcommand.CreateParameter("@ShiftID", adNumeric, adParamInput, , ShiftID)
    objcommand.Parameters.Append objcommand.CreateParameter("@BreakID", adNumeric, adParamInput, , BreakId)
    objcommand.Parameters.Append objcommand.CreateParameter("@EndTime", adDate, adParamInput, , EndTime)
    objcommand.Execute
    conn.Close

End Sub

Function RegisterBreakStart(POSID As Integer, ShiftID As Integer, StartTime As Date) As Integer
Attribute RegisterBreakStart.VB_UserMemId = 1610612756

    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    Dim objcommand As ADODB.command
    Set objcommand = New ADODB.command
    objcommand.ActiveConnection = conn
    objcommand.CommandText = "Insert into Breaks(POSID,ShiftID, StartTime) " & _
    " values (@POSID, @ShiftID, @StartTime)"
    objcommand.Parameters.Append objcommand.CreateParameter("@POSID", adNumeric, adParamInput, , POSID)
    objcommand.Parameters.Append objcommand.CreateParameter("@ShiftID", adNumeric, adParamInput, , ShiftID)
    objcommand.Parameters.Append objcommand.CreateParameter("@StartTime", adDate, adParamInput, , StartTime)
    objcommand.Execute
    
    Dim rs As ADODB.Recordset
    Set rs = conn.Execute("select @@identity")
    RegisterBreakStart = rs(0)
       
    conn.Close
    
End Function

Sub SaveItem(conn As ADODB.Connection, ticketID As Integer, POSID As Integer, item As TicketItem)
Attribute SaveItem.VB_UserMemId = 1610612749
    Dim command As New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Insert into TicketLines(POSID, TicketID, Line, Price, Units, Code) Values (@POSID, @TicketID, @Line, @Price, @Units, @Code)"
    command.Parameters.Append command.CreateParameter("@POSID", adNumeric, adParamInput, , POSID)
    command.Parameters.Append command.CreateParameter("@TicketID", adNumeric, adParamInput, , ticketID)
    command.Parameters.Append command.CreateParameter("@Line", adNumeric, adParamInput, , item.Line)
    command.Parameters.Append command.CreateParameter("@Price", adNumeric, adParamInput, , item.price)
    command.Parameters.Append command.CreateParameter("@Units", adNumeric, adParamInput, , item.Units)
    command.Parameters.Append command.CreateParameter("@Code", adNumeric, adParamInput, , item.Code)
    command.Execute
End Sub

Function SaveNewCustomer(FirstName As String, LastName As String, Email As String, Company As String, Phone As String, StreetAddress1 As String, StreetAddress2 As String, State As String, City As String, ZipCode As String, County As String) As Double
Attribute SaveNewCustomer.VB_UserMemId = 1610612744
    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    Dim objcommand As ADODB.command
    Set objcommand = New ADODB.command
    objcommand.ActiveConnection = conn
    objcommand.CommandText = "Insert into Customers(FirstName, LastName, Email, Company, Phone, StreetAddress1, StreetAddress2, State, City, ZipCode, County) " & _
    " values (@FirstName, @LastName, @Email, @Company, @Phone, @StreetAddress1, @StreetAddress2, @State, @City, @ZipCode, @County)"
    objcommand.Parameters.Append objcommand.CreateParameter("@FirstName", adVarChar, adParamInput, 100, FirstName)
    objcommand.Parameters.Append objcommand.CreateParameter("@LastName", adVarChar, adParamInput, 100, LastName)
    objcommand.Parameters.Append objcommand.CreateParameter("@Email", adVarChar, adParamInput, 100, Email)
    objcommand.Parameters.Append objcommand.CreateParameter("@Company", adVarChar, adParamInput, 100, Company)
    objcommand.Parameters.Append objcommand.CreateParameter("@Phone", adVarChar, adParamInput, 100, Phone)
    objcommand.Parameters.Append objcommand.CreateParameter("@StreetAddress1", adVarChar, adParamInput, 100, StreetAddress1)
    objcommand.Parameters.Append objcommand.CreateParameter("@StreetAddress2", adVarChar, adParamInput, 100, StreetAddress1)
    objcommand.Parameters.Append objcommand.CreateParameter("@State", adVarChar, adParamInput, 100, State)
    objcommand.Parameters.Append objcommand.CreateParameter("@City", adVarChar, adParamInput, 100, City)
    objcommand.Parameters.Append objcommand.CreateParameter("@ZipCode", adVarChar, adParamInput, 100, ZipCode)
    objcommand.Parameters.Append objcommand.CreateParameter("@County", adVarChar, adParamInput, 100, County)
    objcommand.Execute
    Dim rs As ADODB.Recordset
    Set rs = conn.Execute("select @@identity")
    SaveNewCustomer = rs(0)
    conn.Close
End Function

Sub SavePayment(conn As ADODB.Connection, ticketID As Integer, POSID As Integer, pay As Payment)
Attribute SavePayment.VB_UserMemId = 1610612750
    Dim command As New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Insert into Payments(TicketID, POSID, Amount, PaymentTypeID, PaymentInfo) Values (@TicketID, @POSID, @Amount, @PaymentTypeID, @PaymentInfo)"
    command.Parameters.Append command.CreateParameter("@TicketID", adNumeric, adParamInput, , ticketID)
    command.Parameters.Append command.CreateParameter("@POSID", adNumeric, adParamInput, , POSID)
    command.Parameters.Append command.CreateParameter("@Amount", adNumeric, adParamInput, , pay.PaymentAmount)
    command.Parameters.Append command.CreateParameter("@PaymentTypeID", adNumeric, adParamInput, , PaymentStringToID(pay.paymentType))
    command.Parameters.Append command.CreateParameter("@PaymentInfo", adVarChar, adParamInput, 150, pay.PaymentInfo)
    command.Execute
End Sub

' Stores the sale in the database
Function SaveSale(m_SubTotal As Currency, taxes As Currency, Total As Currency, payments As Collection, items As Collection, currentCustomer As Integer, POSID As Integer, UserID As Integer) As Boolean
Attribute SaveSale.VB_UserMemId = 1610612747
    On Error GoTo ErrorDB
    Dim conn As New ADODB.Connection
    Set conn = OpenConnection()
    ' Start Transaction
    conn.BeginTrans

    
    ' Register payment
    
    For Each pay In payments
        Dim currentPayment As Payment
        Set currentPayment = pay
        SavePayment conn, CurrentTicketID, POSID, currentPayment
    Next
    
    ' Register items
    
    For Each item In items
        Dim currentItem As TicketItem
        Set currentItem = item
        SaveItem conn, CurrentTicketID, POSID, currentItem
    Next
    
    CompleteTicket conn, Total, taxes, POSID, UserID
    
    conn.CommitTrans
    conn.Close
    SaveSale = True
    Exit Function
ErrorDB:
    conn.RollbackTrans
    conn.Close
    SaveSale = False
End Function

Function StartShiftWithAmount(POSID As Integer, UserID As Integer, StartShift As Date, StartCash As Currency) As Integer
Attribute StartShiftWithAmount.VB_UserMemId = 1610612740
    Dim conn As ADODB.Connection
    Set conn = OpenConnection
    ' We need to insert the shift information
    Dim command As New ADODB.command
    command.ActiveConnection = conn
    command.CommandText = "Insert into Shifts(POSID, UserID, StartShift, StartCash) " & _
    " values (@POSID, @UserID, @StartShift, @StartCash)"
    command.Parameters.Append command.CreateParameter("@POSID", adNumeric, adParamInput, , POSID)
    command.Parameters.Append command.CreateParameter("@UserID", adNumeric, adParamInput, , UserID)
    command.Parameters.Append command.CreateParameter("@StartShift", adDate, adParamInput, , StartShift)
    command.Parameters.Append command.CreateParameter("@StartCash", adNumeric, adParamInput, , StartCash)
    command.Execute
    
    Dim rs As ADODB.Recordset
    Set rs = conn.Execute("select @@identity")
    StartShiftWithAmount = rs(0)
    conn.Close
End Function

Function ValidateUserPassword(UserID As String, password As String) As Boolean
  Dim conn As ADODB.Connection
  Set conn = OpenConnection
  Dim objcommand As New ADODB.command
  
  objcommand.ActiveConnection = conn
  objcommand.CommandText = "Select 1 from users where UserId = @UserId and Password = @Password"
  objcommand.CommandType = adCmdText
  objcommand.Parameters.Append objcommand.CreateParameter("@UserId", adNumeric, adParamInput, 50, CInt(UserID))
  objcommand.Parameters.Append objcommand.CreateParameter("@Password", adVarChar, adParamInput, 50, password)
  
  Dim rs As ADODB.Recordset
  Set rs = objcommand.Execute
  If rs.RecordCount > 0 Then
    ValidateUserPassword = True
  Else
   ValidateUserPassword = False
  End If
  conn.Close
End Function

Function ValidateUserPasswordAdmin(UserID As String, password As String)
  Dim conn As ADODB.Connection
  Set conn = OpenConnection
  Dim objcommand As New ADODB.command
  
  objcommand.ActiveConnection = conn
  objcommand.CommandText = "Select 1 from users where UserId = @UserId and Password = @Password and UserRoleID = 1"
  objcommand.CommandType = adCmdText
  objcommand.Parameters.Append objcommand.CreateParameter("@UserId", adNumeric, adParamInput, 50, CInt(UserID))
  objcommand.Parameters.Append objcommand.CreateParameter("@Password", adVarChar, adParamInput, 50, password)
  
  Dim rs As ADODB.Recordset
  Set rs = objcommand.Execute
  If rs.RecordCount > 0 Then
    ValidateUserPasswordAdmin = True
  Else
   ValidateUserPasswordAdmin = False
  End If
  conn.Close
End Function

