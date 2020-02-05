VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmSearchCust 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Customer Search"
   ClientHeight    =   11055
   ClientLeft      =   165
   ClientTop       =   510
   ClientWidth     =   22440
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
   ScaleHeight     =   11055
   ScaleWidth      =   22440
   StartUpPosition =   2  'CenterScreen
   Begin TailwindPOS.ucLettersPad ucLettersPad 
      Height          =   8535
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   9495
      _ExtentX        =   16748
      _ExtentY        =   15055
   End
   Begin VB.CommandButton cbClose 
      BackColor       =   &H00432C61&
      Caption         =   "Close"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   18720
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   9600
      Width           =   3615
   End
   Begin MSFlexGridLib.MSFlexGrid fgCustomers 
      Height          =   8655
      Left            =   9720
      TabIndex        =   1
      Top             =   360
      Width           =   12735
      _ExtentX        =   22463
      _ExtentY        =   15266
      _Version        =   393216
      Cols            =   5
      FixedCols       =   0
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
End
Attribute VB_Name = "frmSearchCust"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private m_ChosenCustomer As Integer

Property Get ChosenCustomer() As Integer
    ChosenCustomer = m_ChosenCustomer
End Property

Private Sub cbClose_Click()
    Me.Hide
End Sub

Private Sub fgCustomers_DblClick()
    ' If a customer was chosen
    If (fgCustomers.Row >= 1) Then
        Dim customerNo
        m_ChosenCustomer = CInt(fgCustomers.TextMatrix(fgCustomers.Row, 0))
        Me.Hide
    End If
End Sub

Private Sub Form_Load()
    ucLettersPad.ShowChars = True
    fgCustomers.Rows = 1
    AddHeadersToGrid
    m_ChosenCustomer = -1
End Sub

Sub AddHeadersToGrid()
    'Cust No
    fgCustomers.TextMatrix(0, 0) = "Custo No"
    'First Name
    fgCustomers.TextMatrix(0, 1) = "First Name"
    'Last Name
    fgCustomers.TextMatrix(0, 2) = "Last Name"
    'Email
    fgCustomers.TextMatrix(0, 3) = "Email"
    'Street1
    fgCustomers.TextMatrix(0, 4) = "Street 1"
    
End Sub

Sub SearchCustomer(customerInfo As String)
    Dim rs As ADODB.Recordset
    Set rs = FindCustomers(customerInfo)
    fgCustomers.Rows = rs.RecordCount + 1
    Dim index As Integer
    index = 1
    While Not rs.EOF
        'Custo No
        fgCustomers.TextMatrix(index, 0) = IIf(IsNull(rs("CustomerID")), "", rs("CustomerID"))
        'First Name
        fgCustomers.TextMatrix(index, 1) = IIf(IsNull(rs("FirstName")), "", rs("FirstName"))
        'Last Name
        fgCustomers.TextMatrix(index, 2) = IIf(IsNull(rs("LastName")), "", rs("LastName"))
        'Email
        fgCustomers.TextMatrix(index, 3) = IIf(IsNull(rs("Email")), "", rs("Email"))
        'Street1
        fgCustomers.TextMatrix(index, 4) = IIf(IsNull(rs("StreetAddress1")), "", rs("StreetAddress1"))
        index = index + 1
        rs.MoveNext
    Wend
    
End Sub

Private Sub ucLettersPad_OnEnter(ByVal Text As String)
   SearchCustomer ucLettersPad.Value
    ucLettersPad.Value = ""
End Sub
