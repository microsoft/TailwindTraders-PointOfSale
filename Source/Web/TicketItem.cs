using System;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOS
{

   [Observable]
   internal class TicketItem
   {

      [Intercepted]


      public int Line { get; set; } = 0;

      [Intercepted]
      public decimal price { get; set; } = 0;

      [Intercepted]
      public int Units { get; set; } = 0;

      [Intercepted]
      public int Code { get; set; } = 0;

      [Intercepted]
      public string Description { get; set; } = "";

   }
}