VERSION 5.00
Begin VB.Form frmCustAdd 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Register New Customer"
   ClientHeight    =   10395
   ClientLeft      =   60
   ClientTop       =   405
   ClientWidth     =   19470
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
   ScaleHeight     =   10395
   ScaleWidth      =   19470
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cbClose 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Close"
      Height          =   975
      Left            =   7320
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   9360
      Width           =   6255
   End
   Begin VB.CommandButton cbSave 
      BackColor       =   &H00432C61&
      Caption         =   "Save"
      Height          =   975
      Left            =   960
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   9360
      Width           =   6015
   End
   Begin VB.TextBox txtPhone 
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   2760
      TabIndex        =   9
      Top             =   3240
      Width           =   4575
   End
   Begin VB.TextBox txtCounty 
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   2640
      TabIndex        =   21
      Top             =   7800
      Width           =   5295
   End
   Begin VB.TextBox txtZipCode 
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   12840
      TabIndex        =   19
      Top             =   6480
      Width           =   3375
   End
   Begin VB.TextBox txtState 
      BackColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   1800
      TabIndex        =   15
      Top             =   6480
      Width           =   3135
   End
   Begin VB.TextBox txtCity 
      BackColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   6360
      TabIndex        =   17
      Top             =   6480
      Width           =   4335
   End
   Begin VB.TextBox txtStreetAddress2 
      BackColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   3840
      TabIndex        =   13
      Top             =   5400
      Width           =   14055
   End
   Begin VB.TextBox txtStreetAddress1 
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   3840
      TabIndex        =   11
      Top             =   4320
      Width           =   14055
   End
   Begin VB.TextBox txtCompany 
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   2760
      TabIndex        =   7
      Top             =   2160
      Width           =   12855
   End
   Begin VB.TextBox txtEmail 
      BackColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   2760
      TabIndex        =   5
      Top             =   1200
      Width           =   12855
   End
   Begin VB.TextBox txtLastName 
      BackColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   10920
      TabIndex        =   3
      Top             =   240
      Width           =   5415
   End
   Begin VB.TextBox txtFirstName 
      BackColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   2760
      TabIndex        =   1
      Top             =   240
      Width           =   5055
   End
   Begin VB.Label lblCompany 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Company"
      Height          =   975
      Left            =   600
      TabIndex        =   6
      Top             =   2040
      Width           =   2175
   End
   Begin VB.Label lblCounty 
      BackColor       =   &H00FFFFFF&
      Caption         =   "County"
      Height          =   975
      Left            =   600
      TabIndex        =   20
      Top             =   7800
      Width           =   3255
   End
   Begin VB.Label lblCity 
      BackColor       =   &H00FFFFFF&
      Caption         =   "City"
      Height          =   975
      Left            =   5160
      TabIndex        =   16
      Top             =   6480
      Width           =   3255
   End
   Begin VB.Label lblState 
      BackColor       =   &H00FFFFFF&
      Caption         =   "State"
      Height          =   1215
      Left            =   600
      TabIndex        =   14
      Top             =   6480
      Width           =   3375
   End
   Begin VB.Label lblZipCode 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Zip Code"
      Height          =   1095
      Left            =   11040
      TabIndex        =   18
      Top             =   6480
      Width           =   3495
   End
   Begin VB.Label lblStreetAdress2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Street Address 2:"
      Height          =   1095
      Left            =   600
      TabIndex        =   12
      Top             =   5280
      Width           =   3495
   End
   Begin VB.Label lblStreetAddress1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Street Address:"
      Height          =   855
      Left            =   600
      TabIndex        =   10
      Top             =   4320
      Width           =   3495
   End
   Begin VB.Label lblPhone 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Phone"
      Height          =   855
      Left            =   600
      TabIndex        =   8
      Top             =   3120
      Width           =   2775
   End
   Begin VB.Label lblEmail 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Email"
      Height          =   855
      Left            =   600
      TabIndex        =   4
      Top             =   1200
      Width           =   2775
   End
   Begin VB.Label lblLastName 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Last Name:"
      Height          =   855
      Left            =   8640
      TabIndex        =   2
      Top             =   240
      Width           =   2775
   End
   Begin VB.Label lblFirstName 
      BackColor       =   &H00FFFFFF&
      Caption         =   "First Name:"
      Height          =   735
      Left            =   600
      TabIndex        =   0
      Top             =   240
      Width           =   3015
   End
End
Attribute VB_Name = "frmCustAdd"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim m_savedCustomer As Boolean
Dim m_savedCustomerID As Integer

Property Get SavedCustomerID() As Boolean
    SaveCustomerID = m_savedCustomerID
End Property

Property Get SavedCustomer() As Boolean
    SaveCustomer = m_savedCustomer
End Property

Private Sub cbClose_Click()
    Me.Hide
End Sub

Private Sub cbSave_Click()
On Error GoTo ErrorSaving
    m_savedCustomerID = SaveNewCustomer(txtFirstName, txtLastName, txtEmail, txtCompany, txtPhone, txtStreetAddress1, txtStreetAddress2, _
    txtState, txtCity, txtZipCode, txtCounty)
    ClearFields
    m_savedCustomer = True
    Me.Hide
ErrorSaving:
    m_savedCustomer = False
End Sub

Private Sub ClearFields()
    txtFirstName.Text = ""
    txtLastName.Text = ""
    txtEmail.Text = ""
    txtCompany.Text = ""
    txtPhone.Text = ""
    txtStreetAddress1.Text = ""
    txtStreetAddress2.Text = ""
    txtState.Text = ""
    txtCity.Text = ""
    txtZipCode.Text = ""
    txtCounty.Text = ""
    m_savecustomer = False
End Sub

