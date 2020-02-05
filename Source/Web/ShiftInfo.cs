using System;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOS
{

   [Observable]
   internal class ShiftInfo
   {

      [Intercepted]

      public System.DateTime StartTime { get; set; } = DateTime.FromOADate(0);

      [Intercepted]
      public System.DateTime EndTime { get; set; } = DateTime.FromOADate(0);

      [Intercepted]
      public int UserID { get; set; } = 0;

      [Intercepted]
      public int ShiftID { get; set; } = 0;

   }
}