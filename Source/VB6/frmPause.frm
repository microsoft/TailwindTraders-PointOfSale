VERSION 5.00
Begin VB.Form frmPause 
   BackColor       =   &H80000005&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Tailwind Point of Sale Paused"
   ClientHeight    =   5010
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   12660
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Brandon Grotesque Light"
      Size            =   24
      Charset         =   0
      Weight          =   330
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5010
   ScaleWidth      =   12660
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cbReturn 
      Appearance      =   0  'Flat
      BackColor       =   &H00432C61&
      Caption         =   "Return"
      Height          =   1215
      Left            =   3360
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   2400
      Width           =   6255
   End
   Begin VB.Label lblPauseMessage 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      Caption         =   "POS Paused"
      Height          =   1095
      Left            =   840
      TabIndex        =   0
      Top             =   480
      Width           =   10695
   End
End
Attribute VB_Name = "frmPause"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim m_BreakId As Integer
Private Sub cbReturn_Click()
    If CurrentShift.UserID = 0 Then
        ' And we need a shift
        MsgBox "You are starting your shift, please count cash on drawer"
        Dim Total As Currency
        Total = 0
        While Total < 300
            Dim cash As frmCashCount
            Set cash = New frmCashCount
            cash.Show vbModal
            Total = cash.Total
            ' Validate that the POS has enough cash on Drawer to
            ' Begin shift
            If (Total > MINIMUM_CASH) Then
                ' Start a shift and register it into database
                Dim ShiftID As Integer
                ShiftID = StartShiftWithAmount(CurrentPOS.POSID, CurrentShift.UserID, Now(), Total)
                If ShiftID > 0 Then
                    Me.Hide
                    CurrentShift.ShiftID = ShiftID
                End If
            Else
                MsgBox "You need to have a minimum of " & MINIMUM_CASH & " to Start a Shift"
            End If
         Wend
    Else
          Me.Hide
    End If
End Sub

Private Sub Form_Load()
    m_BreakId = 0
    ' There is a Current Shift Then Register a Break
    If CurrentShift.ShiftID <> 0 Then
        m_BreakId = RegisterBreakStart(CurrentPOS.POSID, CurrentShift.ShiftID, Now)
    Else
        If CurrentUserID = 0 Then
            lblPauseMessage.Caption = "No user Logged In"
        End If
    
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If m_BreakId <> 0 Then
        RegisterBreakEnd CurrentPOS.POSID, CurrentShift.ShiftID, m_BreakId, Now
    End If
End Sub
