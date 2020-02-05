using System;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOS
{

   [Observable]
   internal class POSSystems
   {

      [Intercepted]

      public int POSID { get; set; } = 0;

      [Intercepted]
      public string POSName { get; set; } = "";

      [Intercepted]
      public string Branch { get; set; } = "";

      [Intercepted]
      public string Location { get; set; } = "";

      [Intercepted]
      public string Phone { get; set; } = "";

   }
}