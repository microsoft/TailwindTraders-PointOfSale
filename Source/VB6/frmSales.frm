VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmSales 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Sales"
   ClientHeight    =   13635
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   18030
   ControlBox      =   0   'False
   FillColor       =   &H000000FF&
   BeginProperty Font 
      Name            =   "Brandon Grotesque Light"
      Size            =   21.75
      Charset         =   0
      Weight          =   330
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4453.666
   ScaleMode       =   0  'User
   ScaleWidth      =   1202
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cbRePrint 
      BackColor       =   &H00FFFFFF&
      Caption         =   "PRINT LAST TICKET"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   12000
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   5760
      Width           =   2775
   End
   Begin TailwindPOS.ucNumbersPad ucNumericKeyPad 
      Height          =   6255
      Left            =   120
      TabIndex        =   9
      Top             =   6960
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   9340
   End
   Begin VB.CommandButton cbQuantity 
      BackColor       =   &H00FFFFFF&
      Caption         =   "CHANGE QUANTITY"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   12000
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   3960
      Width           =   2775
   End
   Begin MSFlexGridLib.MSFlexGrid fgItems 
      Height          =   6735
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   11655
      _ExtentX        =   20558
      _ExtentY        =   11880
      _Version        =   393216
      Rows            =   1
      Cols            =   6
      FixedCols       =   0
      BackColorBkg    =   16777215
      FocusRect       =   0
      SelectionMode   =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Brandon Grotesque Light"
         Size            =   8.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Frame gbCustomerInfo 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Customer Info"
      BeginProperty Font 
         Name            =   "Gin"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00664B2F&
      Height          =   1696
      Left            =   12000
      TabIndex        =   3
      Top             =   2040
      Width           =   5895
      Begin VB.Label lblCustomerInfo 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Brandon Grotesque Light"
            Size            =   12
            Charset         =   0
            Weight          =   330
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00664B2F&
         Height          =   735
         Left            =   360
         TabIndex        =   4
         Top             =   600
         Width           =   5055
      End
   End
   Begin VB.CommandButton cbBreak 
      BackColor       =   &H00FFFFFF&
      Caption         =   "PAUSE"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   12000
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   7560
      Width           =   2775
   End
   Begin VB.CommandButton cbLogOff 
      BackColor       =   &H00FFFFFF&
      Caption         =   "LOG OFF"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   15120
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   7560
      Width           =   2775
   End
   Begin VB.CommandButton cbVoidTransaction 
      BackColor       =   &H00FFFFFF&
      Caption         =   "VOID TRANSACTION"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   15120
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   5760
      Width           =   2775
   End
   Begin VB.CommandButton cbVoidItem 
      BackColor       =   &H00FFFFFF&
      Caption         =   "VOID ITEM"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   15120
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   3960
      Width           =   2775
   End
   Begin VB.CommandButton cbAddCustomer 
      BackColor       =   &H00FFFFFF&
      Caption         =   "ADD CUSTOMER"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   12000
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   2775
   End
   Begin VB.CommandButton cbCustomerSearch 
      BackColor       =   &H00FFFFFF&
      Caption         =   "CUSTOMER SEARCH"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1696
      Left            =   15120
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   120
      Width           =   2775
   End
   Begin VB.CommandButton cbPayment 
      BackColor       =   &H0000C000&
      Caption         =   "PAY"
      Height          =   1095
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   10320
      Width           =   5295
   End
   Begin VB.Frame frSubTotals 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00664B2F&
      Height          =   3255
      Left            =   5400
      TabIndex        =   10
      Top             =   6960
      Width           =   5295
      Begin VB.Label lblTotal 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         Caption         =   "0.00"
         BeginProperty Font 
            Name            =   "Brandon Grotesque Medium"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00664B2F&
         Height          =   495
         Left            =   2520
         TabIndex        =   16
         Top             =   1920
         Width           =   1935
      End
      Begin VB.Label lblTax 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         Caption         =   "0.00"
         ForeColor       =   &H00664B2F&
         Height          =   495
         Left            =   2520
         TabIndex        =   14
         Top             =   1200
         Width           =   1935
      End
      Begin VB.Label lblSubTotal 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         Caption         =   "0.00"
         ForeColor       =   &H00664B2F&
         Height          =   495
         Left            =   2520
         TabIndex        =   12
         Top             =   480
         Width           =   1935
      End
      Begin VB.Label lblTotalTitle 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Total:"
         BeginProperty Font 
            Name            =   "Gin"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00664B2F&
         Height          =   615
         Left            =   240
         TabIndex        =   15
         Top             =   1920
         Width           =   1455
      End
      Begin VB.Label lblTaxTitle 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Tax:"
         BeginProperty Font 
            Name            =   "Gin"
            Size            =   21.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00664B2F&
         Height          =   615
         Left            =   240
         TabIndex        =   13
         Top             =   1200
         Width           =   1215
      End
      Begin VB.Label lblSubTotalTitle 
         BackColor       =   &H00FFFFFF&
         Caption         =   "SubTotal:"
         BeginProperty Font 
            Name            =   "Gin"
            Size            =   21.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00664B2F&
         Height          =   495
         Left            =   240
         TabIndex        =   11
         Top             =   480
         Width           =   1935
      End
   End
   Begin VB.PictureBox picLogo 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   12
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   3090
      Left            =   14400
      Picture         =   "frmSales.frx":0000
      ScaleHeight     =   3060
      ScaleWidth      =   3420
      TabIndex        =   24
      Top             =   10440
      Width           =   3450
   End
   Begin VB.Label lblPOS 
      BackColor       =   &H00FFFFFF&
      Caption         =   "POSName"
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   11280
      TabIndex        =   23
      Top             =   11520
      Width           =   2295
   End
   Begin VB.Label lblPOSTitle 
      BackColor       =   &H00FFFFFF&
      Caption         =   "POS:"
      BeginProperty Font 
         Name            =   "Gin"
         Size            =   21.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00664B2F&
      Height          =   855
      Left            =   11280
      TabIndex        =   22
      Top             =   10560
      Width           =   1575
   End
   Begin VB.Label lblCashier 
      BackColor       =   &H00FFFFFF&
      Caption         =   "CashierID"
      ForeColor       =   &H00664B2F&
      Height          =   855
      Left            =   14400
      TabIndex        =   20
      Top             =   9480
      Width           =   2775
   End
   Begin VB.Label lblCashierTitle 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Cashier:"
      BeginProperty Font 
         Name            =   "Gin"
         Size            =   21.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   11280
      TabIndex        =   19
      Top             =   9480
      Width           =   2175
   End
End
Attribute VB_Name = "frmSales"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim m_Toggle_Quantity As Boolean
Dim m_CurrentCustomer As Integer
Dim m_CurrentDescription As String

Dim m_Taxes As Currency
Dim m_SubTotal As Currency
Dim m_total As Currency
Dim m_lastReceipt As String

Public Property Get LastReceipt() As String
    LastReceipt = m_lastReceipt
End Property

Sub AddLine(Code As String, Description As String, price As Currency)
Attribute AddLine.VB_UserMemId = 1610809364
        fgItems.Rows = fgItems.Rows + 1
        Dim lastRow
        lastRow = fgItems.Rows - 1
        ' Quantity
        fgItems.TextMatrix(lastRow, 0) = 1
        ' Item ID
        fgItems.TextMatrix(lastRow, 1) = Code
        ' Description
        fgItems.TextMatrix(lastRow, 2) = Description
        ' Price
        fgItems.TextMatrix(lastRow, 3) = price
        ' Total
        fgItems.TextMatrix(lastRow, 4) = price
        UpdateTotals
End Sub

Private Sub cbAddCustomer_Click()
    Dim custAdd As frmCustAdd
    Set custAdd = New frmCustAdd
    custAdd.Show vbModal
    If custAdd.SavedCustomer Then
        ' Saves the current customer ID and updates its info on the sales screen
        m_CurrentCustomer = custAdd.SavedCustomerID
        LoadCustomerInfo m_CurrentCustomer
    End If
End Sub

Private Sub cbBreak_Click()
    Pause
End Sub

Private Sub cbCustomerSearch_Click()
    Dim custSearch As frmSearchCust
    Set custSearch = New frmSearchCust
    custSearch.Show vbModal
    If custSearch.ChosenCustomer > 0 Then
        ' Saves the current customer ID and updates its info on the sales screen
        m_CurrentCustomer = custSearch.ChosenCustomer
        LoadCustomerInfo m_CurrentCustomer
    End If
End Sub

Private Sub cbLogOff_Click()
    If IsShiftStarted Then
        Dim result As VbMsgBoxResult
        result = MsgBox("Are you ready to end your shift", vbYesNo)
        If result = vbYes Then
            Dim cash As frmCashCount
            Set cash = New frmCashCount
            cash.Show vbModal
            Me.Hide
        End If
    End If
End Sub

Private Sub cbPayment_Click()
    Dim payments As Collection
    Dim items As Collection
    Dim pay As New frmPayment
    pay.TransactionAmount = m_total
    pay.UpdateTotals
    ' We need a ticket number
    ' Because it will be needed when sending it to
    ' credit card processor
    If CurrentTicketID = 0 Then
        CurrentTicketID = CreateTicket(m_CurrentCustomer, CurrentPOS.POSID, CurrentShift.UserID)
    End If
    Set items = GetItems()
    If items.Count > 0 Then
        pay.Show vbModal
        If pay.PaymentDone Then
    
            Set payments = pay.GetPayments()
            If SaveSale(m_SubTotal, m_Taxes, m_total, payments, items, m_CurrentCustomer, CurrentPOS.POSID, CurrentShift.UserID) Then
                Reset
                UpdateTotals
            Else
                MsgBox "Error saving sale"
            End If
        
        End If
    Else
        MsgBox "Error no items registered"
    End If
End Sub

Private Sub cbQuantity_Click()
    ToggleQuantity
End Sub

Private Sub cbRePrint_Click()
    MsgBox "Printing Last Receipt"
End Sub

Private Sub cbVoidItem_Click()
    ' If we are not positioned on the header
    If fgItems.RowSel >= 1 Then
        TryToVoidItem fgItems.Row
    End If
End Sub

Private Sub cbVoidTransaction_Click()
    If ConfirmVoidSale Then
        VoidSale
    End If
End Sub

Function ConfirmVoidItem(itemRow As Integer) As Boolean
Attribute ConfirmVoidItem.VB_UserMemId = 1610809368
    Dim itemName As String
    Dim items As Collection
    Set items = GetItems()
    If items.Count > 0 Then
        itemName = fgItems.TextMatrix(itemRow, 2)
        Dim res As Boolean
        res = MsgBox("Are you sure you want remove line for " & itemName & "?", vbYesNo)
        If res = vbYes Then
         ConfirmVoidItem = True
        Else
         ConfirmVoidItem = False
        End If
    End If
End Function

Function ConfirmVoidSale() As Boolean
Attribute ConfirmVoidSale.VB_UserMemId = 1610809357
    Dim result
    result = MsgBox("Are you sure you want to cancel this sale?", vbYesNo)
    If result = vbYes Then
     ConfirmVoidSale = True
    Else
     ConfirmVoidSale = False
    End If
End Function



Private Function GetItems() As Collection
  Dim coll As New Collection
  Dim i As Integer
  Dim Total As Currency
  Total = 0
  ' Read info from grid
  For i = 1 To fgItems.Rows - 1
    Dim qty As Double
    Dim price As Currency
    Dim Code As Integer
    Dim Desc As String
    ' Quantity
    qty = CInt(fgItems.TextMatrix(i, 0))
    ' Price
    price = CCur(fgItems.TextMatrix(i, 3))
    ' Code
    Code = CCur(fgItems.TextMatrix(i, 1))
    ' Description
    Desc = Me.fgItems.TextMatrix(i, 2)
    
    ' Create item info
    ' and insert it into collection
    Dim item As TicketItem
    Set item = New TicketItem
    item.Code = Code
    item.Line = i
    item.price = price
    item.Units = qty
    item.Description = Desc
    coll.Add item
  Next
  Set GetItems = coll
End Function

Sub LoadCustomerInfo(customerInfo As Integer)
Attribute LoadCustomerInfo.VB_UserMemId = 1610809366
    Dim customer As String
    customer = GetCustomerInfo(customerInfo)
    lblCustomerInfo.Caption = customer
End Sub

Private Sub Pause()
    Dim Pause As frmPause
    Set Pause = New frmPause
    Pause.Show vbModal
End Sub


' Cleans up for a new sale
Public Sub Reset()
Attribute Reset.VB_UserMemId = 1610809361
    ' Reset customer
    m_CurrentCustomer = -1
    lblCustomerInfo.Caption = ""
    ' Clean TicketID
    CurrentTicketID = 0
    ' Update POS Name
    lblPOS.Caption = CurrentPOS.POSName
    ' Update Cashier ID
    lblCashier.Caption = CurrentShift.UserID
    ' Reset KeyPas
    ucNumericKeyPad.ShowChars = True
    ucNumericKeyPad.Value = ""
    
    ' Reset Quantity Button
    m_Toggle_Quantity = False
    cbQuantity.BackColor = vbWhite
    ' Reset Items Grid
    Me.fgItems.Rows = 1
    Me.fgItems.TextMatrix(0, 0) = " Qty"
    Me.fgItems.TextMatrix(0, 1) = " Item ID "
    Me.fgItems.TextMatrix(0, 2) = " Description "
    Me.fgItems.TextMatrix(0, 3) = " Price "
    Me.fgItems.TextMatrix(0, 4) = " Total "
End Sub

Private Sub ReturnFromPause()
    Reset
End Sub

Sub SearchAndAddProduct(productCode As String)
Attribute SearchAndAddProduct.VB_UserMemId = 1610809363
    Dim ProductDescription As String
    Dim ProductPrice As Currency
    If productCode <> "" Then
        If FindProductByCode(productCode, ProductDescription, ProductPrice) Then
            ' If product was found add line
            AddLine productCode, ProductDescription, ProductPrice
        End If
    End If
    ' Clear keypad
    ucNumericKeyPad.Value = ""
End Sub

' Switches between quantity modification mode and
' normal mode
Sub ToggleQuantity()
Attribute ToggleQuantity.VB_UserMemId = 1610809353
    If m_Toggle_Quantity Then
        m_Toggle_Quantity = False
        cbQuantity.BackColor = vbWhite
        ucNumericKeyPad.HighlightValueOff
        ucNumericKeyPad.Value = ""
        ucNumericKeyPad.SetFocus
    Else
        m_Toggle_Quantity = True
        cbQuantity.BackColor = vbYellow
        ucNumericKeyPad.HighlightValueOn
        ucNumericKeyPad.SetFocus
    End If
End Sub

Sub TryToVoidItem(itemRow As Integer)
Attribute TryToVoidItem.VB_UserMemId = 1610809367
    If ConfirmVoidItem(itemRow) Then
        VoidItem itemRow
    End If
End Sub


Private Sub Form_Load()
    Pause
    CurrentShift.UserID = PRESET_TERMINALID
    Reset
End Sub

Private Sub ucNumericKeyPad_OnEnter(ByVal Text As String)
    ' If we are on quantity mode
    ' we will update only the qty for the current item
    If m_Toggle_Quantity Then
        Dim newqty As Integer
        Dim price As Currency
        Dim Total As Currency
        Dim qty As Integer
        newqty = CInt(Text)
        If fgItems.Row >= 1 Then
            ' Update quantity
            Me.fgItems.TextMatrix(fgItems.Row, 0) = newqty
            ' Price
            price = CCur(fgItems.TextMatrix(fgItems.Row, 3))
            Total = Total + (qty * price)
            UpdateTotals
        End If
    Else
        SearchAndAddProduct Text

    End If
End Sub

Sub UpdateTotals()
Attribute UpdateTotals.VB_UserMemId = 1610809365
  Dim i As Integer
  Dim Total As Currency
  Total = 0
  For i = 1 To fgItems.Rows - 1
    Dim qty As Double
    Dim price As Currency
    ' Quantity
    qty = CInt(fgItems.TextMatrix(i, 0))
   ' Price
    price = CCur(fgItems.TextMatrix(i, 3))
    Total = Total + (qty * price)
    ' Total
    fgItems.TextMatrix(i, 4) = Total
  Next
  
  m_SubTotal = Total
  m_Taxes = Total * 0.65
  m_total = Total * 1.65
  lblSubTotal.Caption = FormatCurrency(m_SubTotal, 2)
  lblTax.Caption = FormatCurrency(m_Taxes, 2)
  lblTotal.Caption = FormatCurrency(m_total, 2)
End Sub

Sub VoidItem(itemRow As Integer)
Attribute VoidItem.VB_UserMemId = 1610809369
    ' A flex grid does not allow removing the last non fixed row
    If fgItems.Rows = 2 Then
        fgItems.Rows = 1
    Else
        fgItems.RemoveItem (itemRow)
    End If
    UpdateTotals
End Sub

' Reset the sale
Function VoidSale()
Attribute VoidSale.VB_UserMemId = 1610809356
    Reset
    UpdateTotals
End Function
