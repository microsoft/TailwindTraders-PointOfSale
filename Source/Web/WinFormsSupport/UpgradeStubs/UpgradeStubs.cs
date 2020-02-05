using System.Data.Common;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace UpgradeStubs
{

   [Observable]
   public static class System_Data_Common_DbConnection
   {

   	public static void setCursorLocation(this DbConnection instance, CursorLocationEnum CursorLocation)
   	{
         Stub._UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("ADODB.Connection.CursorLocation");
      }

   }
}