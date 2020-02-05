VERSION 5.00
Begin VB.Form frmGiftCardCode 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Enter Gift Card Code"
   ClientHeight    =   3195
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   10320
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
   ForeColor       =   &H00664B2F&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3195
   ScaleWidth      =   10320
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cbCancel 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Cancel"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   21.75
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1920
      Width           =   3975
   End
   Begin VB.CommandButton cbOK 
      BackColor       =   &H00432C61&
      Caption         =   "OK"
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   21.75
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   1080
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   1920
      Width           =   3975
   End
   Begin VB.TextBox txtCode 
      BeginProperty Font 
         Name            =   "Brandon Grotesque Light"
         Size            =   21.75
         Charset         =   0
         Weight          =   330
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   360
      TabIndex        =   1
      Top             =   1080
      Width           =   9495
   End
   Begin VB.Label lblMessage 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Enter GIFT CARD CODE"
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
      Left            =   600
      TabIndex        =   0
      Top             =   360
      Width           =   4695
   End
End
Attribute VB_Name = "frmGiftCardCode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

Public Property Get Code() As String
    Code = txtCode.Text
End Property


Private Sub cbCancel_Click()
    ' Clean code
    txtCode.Text = ""
    Me.Hide
End Sub

Private Sub cbOK_Click()
    Me.Hide
End Sub
