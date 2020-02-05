VERSION 5.00
Begin VB.Form frmCashCount 
   BackColor       =   &H00FFFFFF&
   Caption         =   "  Count Cash Drawer"
   ClientHeight    =   9600
   ClientLeft      =   60
   ClientTop       =   405
   ClientWidth     =   15570
   ControlBox      =   0   'False
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
   ScaleHeight     =   9600
   ScaleWidth      =   15570
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtHalfDollars 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   2400
      TabIndex        =   12
      Text            =   "0"
      Top             =   4440
      Width           =   1695
   End
   Begin VB.TextBox txtPennies 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   2400
      TabIndex        =   11
      Text            =   "0"
      Top             =   1080
      Width           =   1695
   End
   Begin VB.TextBox txtNickels 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   2400
      TabIndex        =   10
      Text            =   "0"
      Top             =   1920
      Width           =   1695
   End
   Begin VB.TextBox txtDimes 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   2400
      TabIndex        =   9
      Text            =   "0"
      Top             =   2760
      Width           =   1695
   End
   Begin VB.TextBox txtQuarters 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   2400
      TabIndex        =   8
      Text            =   "0"
      Top             =   3600
      Width           =   1695
   End
   Begin VB.TextBox txtOnes 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   6240
      TabIndex        =   7
      Text            =   "0"
      Top             =   1080
      Width           =   1695
   End
   Begin VB.TextBox txtFives 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   6240
      TabIndex        =   6
      Text            =   "0"
      Top             =   1920
      Width           =   1695
   End
   Begin VB.TextBox txtTens 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   6240
      TabIndex        =   5
      Text            =   "0"
      Top             =   2760
      Width           =   1695
   End
   Begin VB.TextBox txtHundreds 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   6240
      TabIndex        =   4
      Text            =   "0"
      Top             =   5280
      Width           =   1695
   End
   Begin VB.TextBox txtTwenties 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   6240
      TabIndex        =   3
      Text            =   "0"
      Top             =   3600
      Width           =   1695
   End
   Begin VB.TextBox txtFifties 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   6240
      TabIndex        =   2
      Text            =   "0"
      Top             =   4440
      Width           =   1695
   End
   Begin VB.CommandButton cbOK 
      Appearance      =   0  'Flat
      BackColor       =   &H00432C61&
      Caption         =   "OK"
      Height          =   855
      Left            =   8520
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   2040
      Width           =   6135
   End
   Begin VB.CommandButton cbClear 
      Appearance      =   0  'Flat
      BackColor       =   &H00FFFFFF&
      Caption         =   "Clear"
      Height          =   855
      Left            =   8520
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   1080
      Width           =   6135
   End
   Begin TailwindPOS.ucNumbersPad ucNumbers 
      Height          =   6375
      Left            =   8520
      TabIndex        =   13
      Top             =   3000
      Width           =   5655
      _ExtentX        =   9975
      _ExtentY        =   11245
   End
   Begin VB.Label lblMessage 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Enter Cash Amount"
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
      Left            =   120
      TabIndex        =   27
      Top             =   120
      Width           =   4455
   End
   Begin VB.Label lblPennies 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Pennies"
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   120
      TabIndex        =   26
      Top             =   1080
      Width           =   2175
   End
   Begin VB.Label lblNickels 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Nickels"
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   120
      TabIndex        =   25
      Top             =   1920
      Width           =   2175
   End
   Begin VB.Label lblDimes 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Dimes"
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   120
      TabIndex        =   24
      Top             =   2760
      Width           =   2175
   End
   Begin VB.Label lblQuarters 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Quarters"
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   120
      TabIndex        =   23
      Top             =   3600
      Width           =   2175
   End
   Begin VB.Label lblHalfDollars 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Half Dollars"
      ForeColor       =   &H00664B2F&
      Height          =   735
      Left            =   120
      TabIndex        =   22
      Top             =   4440
      Width           =   2175
   End
   Begin VB.Label lblOnes 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Ones"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   4440
      TabIndex        =   21
      Top             =   1080
      Width           =   2775
   End
   Begin VB.Label lblFives 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Fives"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   4440
      TabIndex        =   20
      Top             =   1920
      Width           =   2775
   End
   Begin VB.Label lblTens 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Tens"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   4440
      TabIndex        =   19
      Top             =   2760
      Width           =   2775
   End
   Begin VB.Label lblTwenties 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Twenties"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   4440
      TabIndex        =   18
      Top             =   3600
      Width           =   2775
   End
   Begin VB.Label lblFifties 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Fifties"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   4440
      TabIndex        =   17
      Top             =   4320
      Width           =   2775
   End
   Begin VB.Label lblHundreds 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Hundreds"
      ForeColor       =   &H00664B2F&
      Height          =   615
      Left            =   4440
      TabIndex        =   16
      Top             =   5160
      Width           =   2775
   End
   Begin VB.Label lblTotalTitle 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Total"
      ForeColor       =   &H00664B2F&
      Height          =   855
      Left            =   8520
      TabIndex        =   15
      Top             =   120
      Width           =   1695
   End
   Begin VB.Label lblTotal 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      Caption         =   "$0"
      ForeColor       =   &H00664B2F&
      Height          =   975
      Left            =   10920
      TabIndex        =   14
      Top             =   120
      Width           =   3735
   End
End
Attribute VB_Name = "frmCashCount"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim m_LastTextBox As TextBox
Dim m_total As Currency

Public Property Get Total() As Currency
    Total = m_total
End Property

Private Sub cbClear_Click()
    ucNumbers.Value = "0"
    txtPennies.Text = "0"
    txtNickels.Text = "0"
    txtDimes.Text = "0"
    txtQuarters.Text = "0"
    txtHalfDollars.Text = "0"
    
    txtOnes.Text = "0"
    txtFifties.Text = "0"
    txtFives.Text = "0"
    txtTens.Text = "0"
    
    txtTwenties.Text = "0"
    txtFifties.Text = "0"
    txtHundreds.Text = "0"
    UpdateTotals
End Sub

Private Sub cbOK_Click()
    m_total = CCur(lblTotal.Caption)
    Me.Hide
End Sub

Private Sub ClearHighlight()
    txtPennies.BackColor = vbWindowBackground
    txtNickels.BackColor = vbWindowBackground
    txtDimes.BackColor = vbWindowBackground
    txtQuarters.BackColor = vbWindowBackground
    txtHalfDollars.BackColor = vbWindowBackground
    
    txtOnes.BackColor = vbWindowBackground
    txtFifties.BackColor = vbWindowBackground
    txtFives.BackColor = vbWindowBackground
    txtTens.BackColor = vbWindowBackground
    
    txtTwenties.BackColor = vbWindowBackground
    txtFifties.BackColor = vbWindowBackground
    txtHundreds.BackColor = vbWindowBackground
End Sub

Private Sub Form_Load()
    ucNumbers.ShowValue = False
End Sub

Private Sub Highlight(X As TextBox)
    ClearHighlight
    X.BackColor = vbYellow
    Set m_LastTextBox = X
End Sub

Private Sub txtDimes_GotFocus()
    Highlight txtDimes
End Sub

Private Sub txtDimes_LostFocus()
    ExitTextBox txtDimes
End Sub

Private Sub txtFifties_GotFocus()
    Highlight txtFifties
End Sub

Private Sub txtFifties_LostFocus()
    ExitTextBox txtFifties
End Sub

Private Sub txtFives_GotFocus()
    Highlight txtFives
End Sub

Private Sub txtFives_LostFocus()
    ExitTextBox txtFives
End Sub

Private Sub txtHalfDollars_GotFocus()
    Highlight txtHalfDollars
End Sub

Private Sub txtHalfDollars_LostFocus()
    ExitTextBox txtHalfDollars
End Sub

Private Sub txtHundreds_GotFocus()
    Highlight txtHundreds
End Sub

Private Sub txtHundreds_LostFocus()
    ExitTextBox txtHundreds
End Sub

Private Sub txtNickels_GotFocus()
   Highlight txtNickels
End Sub

Private Sub txtNickels_LostFocus()
    ExitTextBox txtNickels
    
End Sub

Private Sub txtOnes_GotFocus()
    Highlight txtOnes
End Sub

Private Sub txtOnes_LostFocus()
    ExitTextBox txtOnes
End Sub

Private Sub txtPennies_GotFocus()
    Highlight txtPennies
End Sub

Private Sub txtPennies_LostFocus()
    ExitTextBox txtPennies
End Sub

Private Sub txtQuarters_GotFocus()
    Highlight txtQuarters
End Sub

Private Sub txtQuarters_LostFocus()
    ExitTextBox txtQuarters
End Sub

Private Sub txtTens_GotFocus()
    Highlight txtTens
End Sub

Private Sub txtTens_LostFocus()
    ExitTextBox txtTens
End Sub

Private Sub txtTwenties_GotFocus()
    Highlight txtTwenties
End Sub

Private Sub txtTwenties_LostFocus()
    Highlight txtTwenties
End Sub

Private Sub ucNumbers_OnBack()
 If Not m_LastTextBox Is Nothing Then
        Dim val As String
        val = Trim(m_LastTextBox)
        If val = "0" Then
            m_LastTextBox.Text = "0"
        Else
            m_LastTextBox.Text = Left$(m_LastTextBox.Text, Len(m_LastTextBox.Text) - 1)
        End If
    End If
    UpdateTotals
End Sub

Private Sub ucNumbers_OnNumber(ByVal Number As String)
    If Not m_LastTextBox Is Nothing Then
        Dim val As String
        val = Trim(m_LastTextBox)
        If val = "0" Then
            m_LastTextBox.Text = Number
        ElseIf val = "00" And m_LastTextBox = "" Then
            m_LastTextBox.Text = "0"
        ElseIf val = "" Then
            m_LastTextBox.Text = "0"
        ElseIf val = "." Then
            'Ignore
        Else
            m_LastTextBox.Text = m_LastTextBox.Text & Number
        End If
    End If
    UpdateTotals
End Sub

Sub ExitTextBox(txt As TextBox)
Attribute ExitTextBox.VB_UserMemId = 1610809356
    Dim contents As String
    contents = txt.Text
    Dim newValue As Integer
On Error GoTo WrongNumber
    newValue = CInt(contents)
    txt.Text = newValue
    UpdateTotals
    Exit Sub
WrongNumber:
    txt.Text = "0"
    UpdateTotals
End Sub

Sub UpdateTotals()
Attribute UpdateTotals.VB_UserMemId = 1610809371
    Dim Total As Currency
    Total = Total + CCur(txtPennies) * 0.01
    Total = Total + CCur(txtNickels) * 0.05
    Total = Total + CCur(txtDimes) * 0.1
    Total = Total + CCur(txtQuarters) * 0.25
    Total = Total + CCur(txtHalfDollars) * 0.5
    Total = Total + CCur(txtOnes) * 1
    Total = Total + CCur(txtFives) * 5
    Total = Total + CCur(txtTens) * 10
    Total = Total + CCur(txtTwenties) * 20
    Total = Total + CCur(txtFifties) * 50
    Total = Total + CCur(txtHundreds) * 100
    
    lblTotal = Total
End Sub
