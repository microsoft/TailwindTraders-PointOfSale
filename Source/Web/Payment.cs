using System;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOS
{

   [Observable]
   internal class Payment
   {

      [Intercepted]


      public string PaymentType { get; set; } = "";

      [Intercepted]
      public decimal PaymentAmount { get; set; } = 0;

      [Intercepted]
      public string PaymentInfo { get; set; } = "";

   }
}