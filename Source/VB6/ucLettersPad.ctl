VERSION 5.00
Begin VB.UserControl ucLettersPad 
   BackColor       =   &H00FFFFFF&
   ClientHeight    =   8565
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   9630
   ScaleHeight     =   8565
   ScaleWidth      =   9630
   Begin VB.CommandButton cbAllCaps 
      BackColor       =   &H00FFFFFF&
      Caption         =   "ALL CAPS"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   20.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   44
      Top             =   2400
      Width           =   2295
   End
   Begin VB.CommandButton cbUnderscore 
      BackColor       =   &H00FFFFFF&
      Caption         =   "_"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   43
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton cbMinus 
      BackColor       =   &H00FFFFFF&
      Caption         =   "-"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3600
      Style           =   1  'Graphical
      TabIndex        =   42
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton cbAt 
      BackColor       =   &H00FFFFFF&
      Caption         =   "@"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   41
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton cbDelete 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Delete"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   40
      Top             =   7200
      Width           =   2295
   End
   Begin VB.CommandButton cbSpace 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Space"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   39
      Top             =   7200
      Width           =   2295
   End
   Begin VB.CommandButton cbLetterY 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Y"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   38
      Top             =   7200
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterZ 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Z"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   7200
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterV 
      BackColor       =   &H00FFFFFF&
      Caption         =   "V"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   36
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterW 
      BackColor       =   &H00FFFFFF&
      Caption         =   "W"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   35
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterX 
      BackColor       =   &H00FFFFFF&
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   34
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterS 
      BackColor       =   &H00FFFFFF&
      Caption         =   "S"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   33
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterT 
      BackColor       =   &H00FFFFFF&
      Caption         =   "T"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3600
      Style           =   1  'Graphical
      TabIndex        =   32
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterU 
      BackColor       =   &H00FFFFFF&
      Caption         =   "U"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   31
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterP 
      BackColor       =   &H00FFFFFF&
      Caption         =   "P"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterQ 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Q"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterR 
      BackColor       =   &H00FFFFFF&
      Caption         =   "R"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterM 
      BackColor       =   &H00FFFFFF&
      Caption         =   "M"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterN 
      BackColor       =   &H00FFFFFF&
      Caption         =   "N"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterO 
      BackColor       =   &H00FFFFFF&
      Caption         =   "O"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterJ 
      BackColor       =   &H00FFFFFF&
      Caption         =   "J"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterK 
      BackColor       =   &H00FFFFFF&
      Caption         =   "K"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterL 
      BackColor       =   &H00FFFFFF&
      Caption         =   "L"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3600
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterG 
      BackColor       =   &H00FFFFFF&
      Caption         =   "G"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterH 
      BackColor       =   &H00FFFFFF&
      Caption         =   "H"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterI 
      BackColor       =   &H00FFFFFF&
      Caption         =   "I"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   4800
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterD 
      BackColor       =   &H00FFFFFF&
      Caption         =   "D"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3600
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterE 
      BackColor       =   &H00FFFFFF&
      Caption         =   "E"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterF 
      BackColor       =   &H00FFFFFF&
      Caption         =   "F"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterA 
      BackColor       =   &H00FFFFFF&
      Caption         =   "A"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterB 
      BackColor       =   &H00FFFFFF&
      Caption         =   "B"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cbLetterC 
      BackColor       =   &H00FFFFFF&
      Caption         =   "C"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   3600
      Width           =   1095
   End
   Begin VB.TextBox txtValue 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   36
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00664B2F&
      Height          =   1095
      Left            =   0
      TabIndex        =   12
      Top             =   0
      Width           =   9495
   End
   Begin VB.CommandButton cb_Number7 
      BackColor       =   &H00FFFFFF&
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number8 
      BackColor       =   &H00FFFFFF&
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number9 
      BackColor       =   &H00FFFFFF&
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number4 
      BackColor       =   &H00FFFFFF&
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3600
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number5 
      BackColor       =   &H00FFFFFF&
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number6 
      BackColor       =   &H00FFFFFF&
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number3 
      BackColor       =   &H00FFFFFF&
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cb_Enter 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Enter"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   7200
      Width           =   2295
   End
   Begin VB.CommandButton cb_Number0 
      BackColor       =   &H00FFFFFF&
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton cb_Period 
      BackColor       =   &H00FFFFFF&
      Caption         =   "."
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   32.25
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   2400
      Width           =   1095
   End
End
Attribute VB_Name = "ucLettersPad"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Dim m_capstate As Boolean
Dim m_capsstate As Boolean
Public Event OnEnter(ByVal Text As String)

Private m_ShowChars As Boolean

Property Get Value() As String
    Value = txtValue.Text
End Property


Property Let Value(newValue As String)
    txtValue.Text = newValue
End Property


Property Get ShowChars() As Boolean
    ShowChars = m_ShowChars
End Property

Property Let ShowChars(ByVal newValue As Boolean)
    m_ShowChars = newValue
    If newValue Then
        txtValue.PasswordChar = ""
    Else
        txtValue.PasswordChar = "*"
    End If
End Property


Private Sub cb_Enter_Click()
    RaiseEvent OnEnter(txtValue.Text)
End Sub

Private Sub cb_Number1_Click()
    txtValue.Text = txtValue.Text & "1"
End Sub

Private Sub cb_Number2_Click()
    txtValue.Text = txtValue.Text & "2"
End Sub

Private Sub cb_Number3_Click()
    txtValue.Text = txtValue.Text & "3"

End Sub

Private Sub cb_Number4_Click()
    txtValue.Text = txtValue.Text & "4"

End Sub

Private Sub cb_Number5_Click()
    txtValue.Text = txtValue.Text & "5"

End Sub

Private Sub cb_Number6_Click()
    txtValue.Text = txtValue.Text & "6"

End Sub

Private Sub cb_Number7_Click()
    txtValue.Text = txtValue.Text & "7"

End Sub

Private Sub cb_Number8_Click()
    txtValue.Text = txtValue.Text & "8"

End Sub

Private Sub cb_Number9_Click()
    txtValue.Text = txtValue.Text & "9"

End Sub

Private Sub cb_Period_Click()
    txtValue.Text = txtValue.Text & "."

End Sub



Private Sub ChangeCase()
    cbLetterA.Caption = GetLetter("A")
    cbLetterB.Caption = GetLetter("B")
    cbLetterC.Caption = GetLetter("C")
    cbLetterD.Caption = GetLetter("D")
    cbLetterE.Caption = GetLetter("E")
    cbLetterF.Caption = GetLetter("F")
    cbLetterG.Caption = GetLetter("G")
    cbLetterH.Caption = GetLetter("H")
    cbLetterI.Caption = GetLetter("I")
    cbLetterJ.Caption = GetLetter("J")
    cbLetterK.Caption = GetLetter("K")
    cbLetterL.Caption = GetLetter("L")
    cbLetterM.Caption = GetLetter("M")
    cbLetterN.Caption = GetLetter("N")
    cbLetterO.Caption = GetLetter("O")
    cbLetterP.Caption = GetLetter("P")
    cbLetterQ.Caption = GetLetter("Q")
    cbLetterR.Caption = GetLetter("R")
    cbLetterS.Caption = GetLetter("S")
    cbLetterT.Caption = GetLetter("T")
    cbLetterU.Caption = GetLetter("U")
    cbLetterV.Caption = GetLetter("V")
    cbLetterW.Caption = GetLetter("W")
    cbLetterX.Caption = GetLetter("X")
    cbLetterY.Caption = GetLetter("Y")
    cbLetterZ.Caption = GetLetter("Z")
End Sub

Private Function GetLetter(X As String)
    GetLetter = IIf(m_capstate, UCase(X), LCase(X))
End Function

Private Sub cbAllCaps_Click()
    ' toggle caps state
    If Not m_capstate Then
        m_capstate = True
        cbAllCaps.BackColor = vbYellow
        cbAllCaps.Caption = "ALL CAPS"
    Else
        m_capstate = False
        cbAllCaps.BackColor = vbWindowBackground
        cbAllCaps.Caption = "NO CAPS"
    End If
    ChangeCase
End Sub

Private Sub cbAt_Click()
    txtValue.Text = txtValue.Text & GetLetter("@")

End Sub

Private Sub cbDelete_Click()
   If txtValue.Text <> "" Then
    txtValue.Text = Left$(txtValue.Text, Len(txtValue.Text) - 1)
   End If
End Sub

Private Sub cbLetterA_Click()
    txtValue.Text = txtValue.Text & GetLetter("A")

End Sub

Private Sub cbLetterB_Click()
    txtValue.Text = txtValue.Text & GetLetter("B")

End Sub

Private Sub cbLetterC_Click()
    txtValue.Text = txtValue.Text & GetLetter("C")

End Sub

Private Sub cbLetterD_Click()
    txtValue.Text = txtValue.Text & GetLetter("D")

End Sub

Private Sub cbLetterE_Click()
    txtValue.Text = txtValue.Text & GetLetter("E")

End Sub

Private Sub cbLetterF_Click()
    txtValue.Text = txtValue.Text & GetLetter("F")

End Sub

Private Sub cbLetterG_Click()
    txtValue.Text = txtValue.Text & GetLetter("G")

End Sub

Private Sub cbLetterH_Click()
    txtValue.Text = txtValue.Text & GetLetter("H")

End Sub

Private Sub cbLetterI_Click()
    txtValue.Text = txtValue.Text & GetLetter("I")
End Sub

Private Sub cbLetterJ_Click()
    txtValue.Text = txtValue.Text & GetLetter("J")
End Sub

Private Sub cbLetterK_Click()
    txtValue.Text = txtValue.Text & GetLetter("K")
End Sub

Private Sub cbLetterL_Click()
    txtValue.Text = txtValue.Text & GetLetter("L")
End Sub

Private Sub cbLetterM_Click()
    txtValue.Text = txtValue.Text & GetLetter("M")
End Sub

Private Sub cbLetterN_Click()
    txtValue.Text = txtValue.Text & GetLetter("N")
End Sub

Private Sub cbLetterO_Click()
    txtValue.Text = txtValue.Text & GetLetter("O")
End Sub

Private Sub cbLetterP_Click()
    txtValue.Text = txtValue.Text & GetLetter("P")
End Sub

Private Sub cbLetterQ_Click()
    txtValue.Text = txtValue.Text & GetLetter("Q")
End Sub

Private Sub cbLetterR_Click()
    txtValue.Text = txtValue.Text & GetLetter("R")
End Sub

Private Sub cbLetterS_Click()
    txtValue.Text = txtValue.Text & GetLetter("S")
End Sub

Private Sub cbLetterT_Click()
    txtValue.Text = txtValue.Text & GetLetter("T")
End Sub

Private Sub cbLetterU_Click()
    txtValue.Text = txtValue.Text & GetLetter("U")
End Sub

Private Sub cbLetterV_Click()
    txtValue.Text = txtValue.Text & GetLetter("V")
End Sub

Private Sub cbLetterW_Click()
    txtValue.Text = txtValue.Text & GetLetter("W")
End Sub

Private Sub cbLetterX_Click()
    txtValue.Text = txtValue.Text & GetLetter("X")
End Sub

Private Sub cbLetterY_Click()
    txtValue.Text = txtValue.Text & GetLetter("Y")
End Sub

Private Sub cbLetterZ_Click()
    txtValue.Text = txtValue.Text & GetLetter("Z")
End Sub

Private Sub cbMinus_Click()
    txtValue.Text = txtValue.Text & "-"
End Sub

Private Sub cbSpace_Click()
    txtValue.Text = txtValue.Text & " "
End Sub

Private Sub cbUnderscore_Click()
    txtValue.Text = txtValue.Text & "_"
End Sub

Private Sub Command1_Click()

End Sub

Private Sub UserControl_Initialize()
m_capstate = True
End Sub
