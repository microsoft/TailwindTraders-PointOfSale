Attribute VB_Name = "Config"
Option Explicit

Private Declare Function GetPrivateProfileString Lib "kernel32" _
Alias "GetPrivateProfileStringA" _
                        (ByVal lpApplicationName As String, _
                        ByVal lpKeyName As Any, _
                        ByVal lpDefault As String, _
                        ByVal lpReturnedString As String, _
                        ByVal nSize As Long, _
                        ByVal lpFileName As String) As Long
                        

' Reads configuration settings from INI file
Public Function ReadConfigSetting(sSection As String, sKeyName As String, sINIFileName As String) As String
Dim sRet As String
Dim ProfileString As String

  sRet = String(255, Chr(0))
  ProfileString = GetPrivateProfileString(sSection, ByVal sKeyName, "", sRet, Len(sRet), sINIFileName)
  ReadConfigSetting = Left(sRet, ProfileString)
End Function

