using Microsoft.VisualBasic;
using System;
using System.Runtime.InteropServices;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOS
{

   [Observable]
   internal static class Config
   {


   	//UPGRADE_NOTE: (2041) The following line was commented. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2041
   	//[DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
   	//extern public static int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, System.IntPtr lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);


   	// Reads configuration settings from INI file
   	internal static string ReadConfigSetting(ref string sSection, string sKeyName, ref string sINIFileName)
   	{

		var parser = new IniParser.FileIniDataParser();
		var data = parser.ReadFile(sINIFileName);
		return data[sSection][sKeyName];
   	}

   }
}