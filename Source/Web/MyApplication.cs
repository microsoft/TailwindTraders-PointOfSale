// *************************************************************************************
//  <copyright file="Startup.cs" company="Mobilize.Net">
//       Copyright (c) 2018 Mobilize, Inc. All Rights Reserved,
//       All classes are provided for customer use only,
//       all other use is prohibited without prior written consent from Mobilize.Net,
//       no warranty express or implied,
//       use at own risk.
//  </copyright>
//  <summary></summary>
// *************************************************************************************

namespace WebSite
{
    /// <summary>
    /// POS Application
    /// </summary>
    public class MyApplication : Mobilize.Web.Application
    {
        public MyApplication() 
        {
            this.EntryPoint = (args) => TailwindPOS.MainModule.Main();
        }
    }
}
