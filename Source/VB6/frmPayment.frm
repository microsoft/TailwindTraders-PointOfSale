VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmPayment 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Pay"
   ClientHeight    =   9885
   ClientLeft      =   60
   ClientTop       =   405
   ClientWidth     =   18285
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
   ScaleHeight     =   9885
   ScaleWidth      =   18285
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame gbPayments 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Payments"
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
      Height          =   7935
      Left            =   240
      TabIndex        =   1
      Top             =   360
      Width           =   10935
      Begin VB.CommandButton cbCash 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "Cash"
         Height          =   1215
         Left            =   5520
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   840
         Width           =   4695
      End
      Begin VB.CommandButton cbCreditCard 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "Credit Card"
         Height          =   1215
         Left            =   5520
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   2160
         Width           =   4695
      End
      Begin VB.CommandButton cbCheck 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "Check"
         Height          =   1215
         Left            =   5520
         Style           =   1  'Graphical
         TabIndex        =   5
         Top             =   3480
         Width           =   4695
      End
      Begin VB.CommandButton cbGiftCard 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "Gift Card"
         Height          =   1215
         Left            =   5520
         Style           =   1  'Graphical
         TabIndex        =   6
         Top             =   4800
         Width           =   4695
      End
      Begin TailwindPOS.ucNumbersPad ucNumbers 
         Height          =   6855
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   5415
         _ExtentX        =   9551
         _ExtentY        =   12091
      End
   End
   Begin VB.CommandButton cbFinishPayment 
      BackColor       =   &H00432C61&
      Caption         =   "Continue"
      Height          =   1215
      Left            =   9360
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   8520
      Width           =   4335
   End
   Begin MSFlexGridLib.MSFlexGrid fgPayments 
      Height          =   4215
      Left            =   12240
      TabIndex        =   12
      Top             =   3840
      Width           =   5775
      _ExtentX        =   10186
      _ExtentY        =   7435
      _Version        =   393216
      Rows            =   1
      Cols            =   3
      ForeColor       =   6703919
      BackColorBkg    =   16777215
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Brandon Grotesque Light"
         Size            =   14.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.CommandButton cb_Cancel 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Cancel"
      Height          =   1215
      Left            =   13920
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   8520
      Width           =   3975
   End
   Begin VB.Label lblPaymentReady 
      Caption         =   "Payment Ready. Press Continue to Print the Receipt"
      BeginProperty Font 
         Name            =   "Gin"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2895
      Left            =   720
      TabIndex        =   10
      Top             =   2760
      Visible         =   0   'False
      Width           =   6015
   End
   Begin VB.Label lblChange 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "$0.00"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   12480
      TabIndex        =   9
      Top             =   2280
      Width           =   5415
   End
   Begin VB.Label lblChangeTitle 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "Change Due"
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
      Left            =   12960
      TabIndex        =   8
      Top             =   1560
      Width           =   4935
   End
   Begin VB.Label lblPaidSoFarTitle 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "Paid So Far"
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
      Left            =   12960
      TabIndex        =   11
      Top             =   3000
      Width           =   4935
   End
   Begin VB.Label lblRemaining 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "$0.00"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   12480
      TabIndex        =   7
      Top             =   840
      Width           =   5415
   End
   Begin VB.Label lblRemaingTitle 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "Amount Remaining"
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
      Left            =   12960
      TabIndex        =   0
      Top             =   120
      Width           =   4935
   End
End
Attribute VB_Name = "frmPayment"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim m_transactionAmount As Currency
Dim resultString As String
Dim m_paidSoFar As Currency
Dim m_paymentDone As Boolean

Property Get PaymentDone() As Boolean
    PaymentDone = m_paymentDone
End Property

Property Get TransactionAmount() As Currency
    TransactionAmount = m_transactionAmount
End Property

Property Let TransactionAmount(amount As Currency)
    m_transactionAmount = amount
End Property

' Adds a payment to the payments grid
Sub AddPayment(amount As String, paymentType As String, PaymentInfo As String)
Attribute AddPayment.VB_UserMemId = 1610809353

    If CCur(amount) <= 0 Then
        Exit Sub
    End If

    Dim money
    money = CCur(amount)
    Dim lastRow As Integer
    lastRow = fgPayments.Rows
    fgPayments.Rows = fgPayments.Rows + 1
    fgPayments.TextMatrix(lastRow, 0) = paymentType
    fgPayments.TextMatrix(lastRow, 1) = amount
    fgPayments.TextMatrix(lastRow, 2) = PaymentInfo
    UpdateTotals
End Sub

Private Sub cbCash_Click()
    AddPayment ucNumbers.Value, "Cash", ""
End Sub

Private Sub cbCheck_Click()
        AddPayment ucNumbers.Value, "Check", ""
End Sub

Private Sub cbCreditCard_Click()
    Dim amount As String
    amount = ucNumbers.Value
    Dim invoice As String
    invoice = CurrentTicketID
    resultString = ""
    resultString = RunCreditCardPayment(invoice, amount)
    Dim results() As String
    
    results = Split(resultString, ",")
    If results(0) = "SUCCESS" Then
        AddPayment amount, "Credit", resultString
    Else
        MsgBox resultString
    End If
End Sub

Private Sub cbFinishPayment_Click()
    If m_paidSoFar >= m_transactionAmount Then
        m_paymentDone = True
        Me.Hide
    Else
        MsgBox "Payment is not complete. Press Cancel to Abort"
    End If
End Sub

Private Sub cbGiftCard_Click()
    Dim giftCard As frmGiftCardCode
    Set giftCard = New frmGiftCardCode
    giftCard.Show vbModal
    If giftCard.Code <> "" Then
        AddPayment ucNumbers.Value, "Gift Card", giftCard.Code
    End If
End Sub

Private Sub cb_Cancel_Click()
    m_paymentDone = False
    Me.Hide
End Sub

Private Sub Form_Load()
    gbPayments.Visible = True
    ucNumbers.ShowChars = True
    ucNumbers.ShowEnter = False
    ' Setup grid titles
    fgPayments.TextMatrix(0, 0) = "Type"
    fgPayments.TextMatrix(0, 1) = "Amount"
    ' Updates the totals and amounts due
    UpdateTotals
End Sub

' Returns a Collection of Payment info objects with
' all the information about the payments so far
Function GetPayments() As Collection
Attribute GetPayments.VB_UserMemId = 1610809356
    Dim payments As Collection
    Set payments = New Collection
    Dim totalRows As Integer
    Dim index As Integer
    ' Remove the header from the rows count
    totalRows = fgPayments.Rows - 1
    index = 1
    For index = 1 To totalRows
        Dim pay As New Payment
        pay.paymentType = fgPayments.TextMatrix(index, 0)
        pay.PaymentAmount = fgPayments.TextMatrix(index, 1)
        pay.PaymentInfo = fgPayments.TextMatrix(index, 2)
        
        payments.Add pay
    Next
    Set GetPayments = payments
End Function

' Sums up all the payments
Function SumPayments() As Currency
Attribute SumPayments.VB_UserMemId = 1610809355
    Dim totalRows As Integer
    Dim result As Currency
    ' Remove the header from the rows count
    totalRows = fgPayments.Rows - 1
    Dim index As Integer
    index = 1
    For index = 1 To totalRows
        result = result + CCur(fgPayments.TextMatrix(index, 1))
    Next
    SumPayments = result
End Function

' Sums up all the payments
' And updates the paid so far amount
Sub UpdateTotals()
Attribute UpdateTotals.VB_UserMemId = 1610809354
    ucNumbers.Value = ""
    m_paidSoFar = SumPayments
    lblRemaining.Caption = FormatCurrency(m_transactionAmount - m_paidSoFar, 2)
    If m_paidSoFar > m_transactionAmount Then
        gbPayments.Visible = False
        lblPaymentReady.Visible = True
        lblChange.Caption = FormatCurrency(m_paidSoFar - m_transactionAmount, 2)
    Else
        lblChange.Caption = FormatCurrency(0, 2)
    End If
End Sub

