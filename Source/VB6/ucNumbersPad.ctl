VERSION 5.00
Begin VB.UserControl ucNumbersPad 
   BackColor       =   &H00FFFFFF&
   ClientHeight    =   6180
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   5010
   ScaleHeight     =   6180
   ScaleWidth      =   5010
   Begin VB.TextBox txtAmount 
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
      IMEMode         =   3  'DISABLE
      Left            =   120
      PasswordChar    =   "*"
      TabIndex        =   15
      Top             =   120
      Width           =   4695
   End
   Begin VB.CommandButton cb_Period 
      BackColor       =   &H00FFFFFF&
      Caption         =   "."
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2520
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   4920
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number00 
      BackColor       =   &H00FFFFFF&
      Caption         =   "00"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1320
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   4920
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number0 
      BackColor       =   &H00FFFFFF&
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   4920
      Width           =   1095
   End
   Begin VB.CommandButton cb_Enter 
      BackColor       =   &H00FFFFFF&
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   27.75
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2295
      Left            =   3720
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3720
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number3 
      BackColor       =   &H00FFFFFF&
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2520
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   3720
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1320
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   3720
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   3720
      Width           =   1095
   End
   Begin VB.CommandButton cb_Clear 
      BackColor       =   &H00FFFFFF&
      Caption         =   "C"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3720
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   2520
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number6 
      BackColor       =   &H00FFFFFF&
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2520
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   2520
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number5 
      BackColor       =   &H00FFFFFF&
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1320
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   2520
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number4 
      BackColor       =   &H00FFFFFF&
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   2520
      Width           =   1095
   End
   Begin VB.CommandButton cb_Back 
      BackColor       =   &H00FFFFFF&
      Caption         =   "<-"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   27.75
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3720
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1320
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number9 
      BackColor       =   &H00FFFFFF&
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   2520
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   1320
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number8 
      BackColor       =   &H00FFFFFF&
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   1320
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   1320
      Width           =   1095
   End
   Begin VB.CommandButton cb_Number7 
      BackColor       =   &H00FFFFFF&
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   24
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   1320
      Width           =   1095
   End
End
Attribute VB_Name = "ucNumbersPad"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Public Event OnNumber(ByVal Number As String)

Public Event OnBack()


Public Event OnEnter(ByVal Text As String)

Private m_ShowChars As Boolean

Property Get ShowChars() As Boolean
Attribute ShowChars.VB_UserMemId = 1745027072
    ShowChars = m_ShowChars
End Property

Property Let ShowChars(ByVal newValue As Boolean)
    m_ShowChars = newValue
    If newValue Then
        txtAmount.PasswordChar = ""
    Else
        txtAmount.PasswordChar = "*"
    End If
End Property

Property Get ShowEnter() As Boolean
Attribute ShowEnter.VB_UserMemId = 1745027075
    ShowEnter = cb_Enter.Visible
End Property

Property Let ShowEnter(newValue As Boolean)
    cb_Enter.Visible = newValue
End Property

Property Get ShowValue() As Boolean
Attribute ShowValue.VB_UserMemId = 1745027074
    ShowValue = txtAmount.Visible
End Property

Property Let ShowValue(newValue As Boolean)
    txtAmount.Visible = newValue
End Property

Property Get Value() As String
Attribute Value.VB_UserMemId = 1745027073
    Value = txtAmount.Text
End Property

Property Let Value(newValue As String)
    txtAmount.Text = newValue
End Property

Private Sub cb_Back_Click()
    If Len(txtAmount.Text) > 0 Then
        txtAmount.Text = Left$(txtAmount.Text, Len(txtAmount.Text) - 1)
    End If
    RaiseEvent OnBack
End Sub

Private Sub cb_Clear_Click()
    txtAmount.Text = ""
    RaiseEvent OnNumber("")
End Sub

Private Sub cb_Enter_Click()
    RaiseEvent OnEnter(txtAmount.Text)
End Sub

Private Sub cb_Number00_Click()
    txtAmount.Text = txtAmount.Text & "00"
    RaiseEvent OnNumber("00")
End Sub

Private Sub cb_Number0_Click()
    txtAmount.Text = txtAmount.Text & "0"
    RaiseEvent OnNumber("0")
End Sub

Private Sub cb_Number1_Click()
    txtAmount.Text = txtAmount.Text & "1"
    RaiseEvent OnNumber("1")
End Sub

Private Sub cb_Number2_Click()
    txtAmount.Text = txtAmount.Text & "2"
    RaiseEvent OnNumber("2")
End Sub

Private Sub cb_Number3_Click()
    txtAmount.Text = txtAmount.Text & "3"
    RaiseEvent OnNumber("3")
End Sub

Private Sub cb_Number4_Click()
    txtAmount.Text = txtAmount.Text & "4"
    RaiseEvent OnNumber("4")
End Sub

Private Sub cb_Number5_Click()
    txtAmount.Text = txtAmount.Text & "5"
    RaiseEvent OnNumber("5")
End Sub

Private Sub cb_Number6_Click()
    txtAmount.Text = txtAmount.Text & "6"
    RaiseEvent OnNumber("6")
End Sub

Private Sub cb_Number7_Click()
    txtAmount.Text = txtAmount.Text & "7"
    RaiseEvent OnNumber("7")
End Sub

Private Sub cb_Number8_Click()
    txtAmount.Text = txtAmount.Text & "8"
    RaiseEvent OnNumber("8")
End Sub

Private Sub cb_Number9_Click()
    txtAmount.Text = txtAmount.Text & "9"
    RaiseEvent OnNumber("9")
End Sub

Private Sub cb_Period_Click()
    txtAmount.Text = txtAmount.Text & "."
    RaiseEvent OnNumber(".")
End Sub

Sub HighlightValueOff()
Attribute HighlightValueOff.VB_UserMemId = 1610809349
    txtAmount.BackColor = vbWhite
End Sub

Sub HighlightValueOn()
Attribute HighlightValueOn.VB_UserMemId = 1610809348
    txtAmount.BackColor = vbYellow
End Sub

Private Sub txtAmount_KeyPress(KeyAscii As Integer)
    ' When Enter is pressed
    If KeyAscii = 13 Then
        RaiseEvent OnEnter(txtAmount.Text)
    End If
End Sub
