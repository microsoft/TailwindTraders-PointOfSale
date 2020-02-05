using System.Data.Common;
using UpgradeHelpers.DB.ADO;

namespace UpgradeStubs
{
	public static class System_Data_Common_DbConnection
	{

		public static void setCursorLocation(this DbConnection instance, CursorLocationEnum CursorLocation)
		{
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("ADODB.Connection.CursorLocation");
		}
	}
}