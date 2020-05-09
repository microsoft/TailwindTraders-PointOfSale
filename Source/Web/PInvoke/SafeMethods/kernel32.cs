using System.Runtime.InteropServices;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace WinFormsSupport.PInvoke.SafeNative
{

   [Observable]
   public static class kernel32
   {

   	public static int GetPrivateProfileString(ref string lpApplicationName, string lpKeyName, ref string lpDefault, ref string lpReturnedString, int nSize, ref string lpFileName)
   	{
   		int result = 0;
   		IntPtr tmpPtr = Marshal.StringToHGlobalAnsi(lpKeyName);
   		try
   		{
   			result = WinFormsSupport.PInvoke.UnsafeNative.kernel32.GetPrivateProfileString(ref lpApplicationName, tmpPtr, ref lpDefault, ref lpReturnedString, nSize, ref lpFileName);
   			lpKeyName = Marshal.PtrToStringAnsi(tmpPtr);
   		}
   		finally
   		{
   			Marshal.FreeHGlobal(tmpPtr);
   		}
   		return result;
   	}

   }
}