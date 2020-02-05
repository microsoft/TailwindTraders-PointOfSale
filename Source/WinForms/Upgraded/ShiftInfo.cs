using System;

namespace TailwindPOS
{
	internal class ShiftInfo
	{

		public System.DateTime StartTime = DateTime.FromOADate(0);
		public System.DateTime EndTime = DateTime.FromOADate(0);
		public int UserID = 0;
		public int ShiftID = 0;
	}
}