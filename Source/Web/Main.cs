using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Globalization;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;
using System.Net.Http;

namespace TailwindPOS
{

   [Observable]
   internal static class MainModule
   {

      [Intercepted]

      // Products Information is accessed thru a WebAPI
      // The URL for accessing that API is read from an INI file
      static
      string URL_PRODUCT_API { get; set; } = "";

      [Intercepted]

      // The Cash Drawer must have a minimum amount in order to start a Shift
      static
      int MINIMUM_CASH { get; set; } = 0;

      [Intercepted]

      // The Connection String to use to open the Database
      static
      string ConnectionString { get; set; } = "";

      [Intercepted]

      // The default POS user used to skip the log in process, to change the default POS user,
      // modify the POSTerminal value in the TailwindPOS.ini file
      public static int PRESET_TERMINALID { get; set; } = 0;

      [Intercepted]

      // The Collection of POS users ID used to skip the log in process
      private static OrderedDictionary _POSSystems { get; set; } = null;

      [Intercepted]
      internal static OrderedDictionary POSSystems
      {
      	get
      	{
      		if (_POSSystems == null)
      		{
      			_POSSystems = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
      		}
      		return _POSSystems;
      	}
      	set
      	{
      		_POSSystems = value;
      	}
      }

      [Intercepted]



      private static POSSystems _CurrentPOS { get; set; } = null;

      [Intercepted]
      internal static POSSystems CurrentPOS
      {
      	get
      	{
      		if (_CurrentPOS == null)
      		{
      			_CurrentPOS = new POSSystems();
      		}
      		return _CurrentPOS;
      	}
      	set
      	{
      		_CurrentPOS = value;
      	}
      }

      [Intercepted]

      private static ShiftInfo _CurrentShift { get; set; } = null;

      [Intercepted]
      internal static ShiftInfo CurrentShift
      {
      	get
      	{
      		if (_CurrentShift == null)
      		{
      			_CurrentShift = new ShiftInfo();
      		}
      		return _CurrentShift;
      	}
      	set
      	{
      		_CurrentShift = value;
      	}
      }

      [Intercepted]

      public static int CurrentTicketID { get; set; } = 0;

      internal static int CreateTicket(int CustomerID, int POSID, int UserID)
      {
      	DbConnection conn = OpenConnection();
      	DbCommand command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Insert into Tickets(Ticket_Datetime, Total, Taxes, CustomerID,UserID,POSID, Status) " +
      	                      " values (@TicketDateTime, 0, 0, @CustomerID, @UserID, @POSID, 1)";
      	DbParameter TempParameter = null;
      	TempParameter = command.CreateParameter();
      	TempParameter.ParameterName = "@TicketDateTime";
      	TempParameter.DbType = DbType.Date;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = DateTime.Now;
      	command.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = command.CreateParameter();
      	TempParameter_2.ParameterName = "@CustomerID";
      	TempParameter_2.DbType = DbType.String;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 100;
      	TempParameter_2.Value = CustomerID;
      	command.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = command.CreateParameter();
      	TempParameter_3.ParameterName = "@UserID";
      	TempParameter_3.DbType = DbType.String;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 100;
      	TempParameter_3.Value = UserID;
      	command.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = command.CreateParameter();
      	TempParameter_4.ParameterName = "@POSID";
      	TempParameter_4.DbType = DbType.String;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 100;
      	TempParameter_4.Value = POSID;
      	command.Parameters.Add(TempParameter_4);

      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	command.ExecuteNonQuery();


      	ADORecordSetHelper rs = ADORecordSetHelper.Open("select @@identity", conn, "");
      	return Convert.ToInt32(rs[0]);
      }

      internal static void CompleteTicket(DbConnection conn, decimal Total, decimal taxes, int POSID, int UserID)
      {
      	DbCommand command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Update Tickets set Total = @Total, Taxes = @Taxes, Status = 0 " +
      	                      " Where POSID = @POSID and TicketID = @TicketID";
      	DbParameter TempParameter = null;
      	TempParameter = command.CreateParameter();
      	TempParameter.ParameterName = "@Total";
      	TempParameter.DbType = DbType.Currency;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = Total;
      	command.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = command.CreateParameter();
      	TempParameter_2.ParameterName = "@Taxes";
      	TempParameter_2.DbType = DbType.Currency;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = taxes;
      	command.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = command.CreateParameter();
      	TempParameter_3.ParameterName = "@POSID";
      	TempParameter_3.DbType = DbType.Int32;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = POSID;
      	command.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = command.CreateParameter();
      	TempParameter_4.ParameterName = "@TicketID";
      	TempParameter_4.DbType = DbType.Int32;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 0;
      	TempParameter_4.Value = UserID;
      	command.Parameters.Add(TempParameter_4);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	command.ExecuteNonQuery();

      }

      internal static void EndShiftWithAmount(int POSID, int UserID, System.DateTime ShiftID, decimal StartCash)
      {
      	object EndCash = null;
      	object Endshift = null;
      	object StartShift = null;
      	DbConnection conn = OpenConnection();
      	// We need to insert the shift information
      	DbCommand command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Update Shifts set EndShift = @EndShift, EndCash = @EndCash) " +
      	                      " where POSID = @POSID and UserID = @UserID and ShiftID = @ShiftID";
      	DbParameter TempParameter = null;
      	TempParameter = command.CreateParameter();
      	TempParameter.ParameterName = "@POSID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = POSID;
      	command.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = command.CreateParameter();
      	TempParameter_2.ParameterName = "@UserID";
      	TempParameter_2.DbType = DbType.Decimal;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = UserID;
      	command.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = command.CreateParameter();
      	TempParameter_3.ParameterName = "@ShiftID";
      	TempParameter_3.DbType = DbType.Decimal;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = StartShift;
      	command.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = command.CreateParameter();
      	TempParameter_4.ParameterName = "@EndShift";
      	TempParameter_4.DbType = DbType.Date;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 0;
      	TempParameter_4.Value = Endshift;
      	command.Parameters.Add(TempParameter_4);
      	DbParameter TempParameter_5 = null;
      	TempParameter_5 = command.CreateParameter();
      	TempParameter_5.ParameterName = "@EndCash";
      	TempParameter_5.DbType = DbType.Decimal;
      	TempParameter_5.Direction = ParameterDirection.Input;
      	TempParameter_5.Size = 0;
      	TempParameter_5.Value = EndCash;
      	command.Parameters.Add(TempParameter_5);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	command.ExecuteNonQuery();

      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      }

      internal static string ExtractData(string property, string json, bool isnumber)
      {
      	string result = "";
      	int endindex = 0;
      	// we search inside the json string for "property": "value"
      	int startindex = (json.IndexOf("\"" + property + "\":") + 1);
      	if (startindex > -1)
      	{
      		startindex = startindex + property.Length + 3;
      		if (isnumber)
      		{
      			endindex =  json.IndexOf(",",startindex);
      		}
      		else
      		{
      			endindex = json.IndexOf("\",",startindex);
      			// this is to skip the double quote
      			startindex++;
      		}
      		if (endindex > -1)
      		{
      			result = json.Substring(startindex - 1, Math.Min(endindex - startindex, json.Length - (startindex - 1)));
      		}
      	}
      	return result;
      }

      internal static ADORecordSetHelper FindCustomers(string customerInfo)
      {
      	string query = "select * from Customers where LastName = @keyword " +
      	               "Union  " +
      	               "Select * from Customers where FirstName = @keyword  " +
      	               "Union " +
      	               "Select * from Customers where email = @keyword  ";

      	DbConnection conn = OpenConnection();
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = query;
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@keyword";
      	TempParameter.DbType = DbType.String;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 100;
      	TempParameter.Value = customerInfo;
      	objcommand.Parameters.Add(TempParameter);

      	ADORecordSetHelper rs = new ADORecordSetHelper("");
      	rs.CursorLocation = CursorLocationEnum.adUseClient;
      	rs.Open(objcommand);
      	rs.ActiveConnection = null;
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      	return rs;
      }

      internal static bool FindProductByCode(string productCode, ref string ProductDescription, ref decimal ProductPrice)
      {
      	bool result = false;

		using (var httpClient = new HttpClient())
    	{
			using (var apiresponse = httpClient.GetAsync(URL_PRODUCT_API + productCode).GetAwaiter().GetResult())
			{

				string response = "";
				// was the response ok
				if ((int)apiresponse.StatusCode == 200)
				{


					response = apiresponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
					ProductDescription = ExtractData("name", response, false);
					ProductPrice = Decimal.Parse(ExtractData("price", response, true), NumberStyles.Currency | NumberStyles.AllowExponent);
					result = true;
				}
				else
				{
					result = false;
					Mobilize.Web.MessageBox.Show("Product not found", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName);
				}

				return result;

			}
    	}
      }


      // Gets a Customer Description to show when a customer is chosen

      internal static string GetCustomerInfo(int CustomerID)
      {
      	string query = "select * from Customers where CustomerID = @CustomerID";
      	DbConnection conn = OpenConnection();
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = query;
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@CustomerID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = CustomerID;
      	objcommand.Parameters.Add(TempParameter);

      	ADORecordSetHelper rs = new ADORecordSetHelper("");
      	rs.CursorLocation = CursorLocationEnum.adUseClient;
      	rs.Open(objcommand);
      	rs.ActiveConnection = null;
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      	if (rs.RecordCount > 0)
      	{
      		return Convert.ToString(rs["FirstName"]) + " " + Convert.ToString(rs["LastName"]) + Environment.NewLine + Convert.ToString(rs["Email"]);
      	}
      	else
      	{
      		return "Customer Info could not be loaded";
      	}
      }

      internal static OrderedDictionary GetPOSSystems()
      {
      	DbConnection conn = OpenConnection();

      	DbCommand command = null;
      	command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Select * from POS";
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	ADORecordSetHelper rs = ADORecordSetHelper.Open(command, "");
      	OrderedDictionary coll = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
      	POSSystems POS = null;
      	if (rs.RecordCount > 0)
      	{
      		while (!rs.EOF)
      		{
      			POS = new POSSystems();
      			POS.POSID = Convert.ToInt32(rs["POSID"]);
      			POS.Branch = Convert.ToString(rs["Branch"]);
      			POS.Location = Convert.ToString(rs["Location"]);
      			POS.Phone = Convert.ToString(rs["Phone"]);
      			POS.POSName = Convert.ToString(rs["POSName"]);
      			coll.Add(Guid.NewGuid().ToString(), POS);
      			rs.MoveNext();
      		}
      	}
      	return coll;
      }

      internal static bool IsShiftStarted()
      {
      	return CurrentShift.ShiftID != 0;
      }


      internal static string RunCreditCardPayment(string invoice, string amount)
      {
      	string strOut = "SUCCESS";
      	return strOut;
      }

      //UPGRADE_WARNING: (1047) Application will terminate when Sub Main() finishes. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1047

      [STAThread]
      public static void Main()
      {

      	ReadConfig();

      	POSSystems = GetPOSSystems();
      	if (PRESET_TERMINALID != 0)
      	{
      		foreach (POSSystems POS in POSSystems.Values)
      		{
      			if (POS.POSID == PRESET_TERMINALID)
      			{
      				CurrentPOS = POS;
      				break;
      			}
      		}
      	}

      	// If a POS was not selected we cannot continue
      	if (CurrentPOS.POSName != "")
      	{
      		frmSales.DefInstance.ShowDialog();
      	}
      }

      // Open the Database Connection

      internal static DbConnection OpenConnection()
      {
      	DbConnection conn = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
      	conn.ConnectionString = ConnectionString;
      	//UPGRADE_ISSUE: (2064) ADODB.Connection property conn.CursorLocation was not upgraded. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2064
      	//conn.setCursorLocation(CursorLocationEnum.adUseClient);
      	//UPGRADE_TODO: (7010) The connection string must be verified to fullfill the .NET data provider connection string requirements. More Information: https://www.mobilize.net/vbtonet/ewis/ewi7010
      	conn.Open();
      	return conn;
      }

      internal static string PadAmount(decimal amount)
      {
      	return (new String(' ', 50) + amount.ToString("C")).Substring(Math.Max((new String(' ', 50) + amount.ToString("C")).Length - 15, 0));
      }

      internal static int PaymentStringToID(string paymentType)
      {
      	int result = 0;
      	if (paymentType == "Cash")
      	{
      		result = 1;
      	}
      	else if (paymentType == "Check")
      	{
      		result = 2;
      	}
      	else if (paymentType == "Credit")
      	{
      		result = 3;
      	}
      	else if (paymentType == "Gift Card")
      	{
      		result = 4;
      	}

      	return result;
      }

      internal static void ReadConfig()
      {
      	string tempRefParam = "Connection String";
      	string tempRefParam2 = "TailwindPOS.ini";
      	ConnectionString = Config.ReadConfigSetting(ref tempRefParam, "DatabaseConnectionString", ref tempRefParam2);
      	string tempRefParam3 = "Products";
      	string tempRefParam4 = "TailwindPOS.ini";
      	URL_PRODUCT_API = Config.ReadConfigSetting(ref tempRefParam3, "ProductsWebAPIURL", ref tempRefParam4);
      	string tempRefParam5 = "CashDrawer";
      	string tempRefParam6 = "TailwindPOS.ini";
      	MINIMUM_CASH = Convert.ToInt32(Double.Parse(Config.ReadConfigSetting(ref tempRefParam5, "MinimumCash", ref tempRefParam6)));
      	string tempRefParam7 = "POS";
      	string tempRefParam8 = "TailwindPOS.ini";
      	PRESET_TERMINALID = Convert.ToInt32(Double.Parse(Config.ReadConfigSetting(ref tempRefParam7, "POSTerminal", ref tempRefParam8)));
      }

      internal static void RegisterBreakEnd(int POSID, int ShiftID, int BreakId, System.DateTime EndTime)
      {
      	object FirstName = null;

      	DbConnection conn = null;
      	conn.ConnectionString = OpenConnection().ConnectionString;
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = "UPDATE Breaks Set EndTime = @EndTime where" +
      	                         " POSID = @POSID, ShiftID = @ShiftID, BreakID = @BreakID";
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@POSID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = FirstName;
      	objcommand.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = objcommand.CreateParameter();
      	TempParameter_2.ParameterName = "@ShiftID";
      	TempParameter_2.DbType = DbType.Decimal;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = ShiftID;
      	objcommand.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = objcommand.CreateParameter();
      	TempParameter_3.ParameterName = "@BreakID";
      	TempParameter_3.DbType = DbType.Decimal;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = BreakId;
      	objcommand.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = objcommand.CreateParameter();
      	TempParameter_4.ParameterName = "@EndTime";
      	TempParameter_4.DbType = DbType.Date;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 0;
      	TempParameter_4.Value = EndTime;
      	objcommand.Parameters.Add(TempParameter_4);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(objcommand);
      	objcommand.ExecuteNonQuery();
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();

      }

      internal static int RegisterBreakStart(int POSID, int ShiftID, System.DateTime StartTime)
      {

      	int result = 0;
      	DbConnection conn = OpenConnection();
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = "Insert into Breaks(POSID,ShiftID, StartTime) " +
      	                         " values (@POSID, @ShiftID, @StartTime)";
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@POSID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = POSID;
      	objcommand.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = objcommand.CreateParameter();
      	TempParameter_2.ParameterName = "@ShiftID";
      	TempParameter_2.DbType = DbType.Decimal;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = ShiftID;
      	objcommand.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = objcommand.CreateParameter();
      	TempParameter_3.ParameterName = "@StartTime";
      	TempParameter_3.DbType = DbType.Date;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = StartTime;
      	objcommand.Parameters.Add(TempParameter_3);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(objcommand);
      	objcommand.ExecuteNonQuery();

      	ADORecordSetHelper rs = ADORecordSetHelper.Open("select @@identity", conn, "");
      	result = Convert.ToInt32(rs[0]);

      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();

      	return result;
      }

      internal static void SaveItem(DbConnection conn, int ticketID, int POSID, TicketItem item)
      {
      	DbCommand command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Insert into TicketLines(POSID, TicketID, Line, Price, Units, Code) Values (@POSID, @TicketID, @Line, @Price, @Units, @Code)";
      	DbParameter TempParameter = null;
      	TempParameter = command.CreateParameter();
      	TempParameter.ParameterName = "@POSID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = POSID;
      	command.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = command.CreateParameter();
      	TempParameter_2.ParameterName = "@TicketID";
      	TempParameter_2.DbType = DbType.Decimal;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = ticketID;
      	command.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = command.CreateParameter();
      	TempParameter_3.ParameterName = "@Line";
      	TempParameter_3.DbType = DbType.Decimal;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = item.Line;
      	command.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = command.CreateParameter();
      	TempParameter_4.ParameterName = "@Price";
      	TempParameter_4.DbType = DbType.Decimal;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 0;
      	TempParameter_4.Value = item.price;
      	command.Parameters.Add(TempParameter_4);
      	DbParameter TempParameter_5 = null;
      	TempParameter_5 = command.CreateParameter();
      	TempParameter_5.ParameterName = "@Units";
      	TempParameter_5.DbType = DbType.Decimal;
      	TempParameter_5.Direction = ParameterDirection.Input;
      	TempParameter_5.Size = 0;
      	TempParameter_5.Value = item.Units;
      	command.Parameters.Add(TempParameter_5);
      	DbParameter TempParameter_6 = null;
      	TempParameter_6 = command.CreateParameter();
      	TempParameter_6.ParameterName = "@Code";
      	TempParameter_6.DbType = DbType.Decimal;
      	TempParameter_6.Direction = ParameterDirection.Input;
      	TempParameter_6.Size = 0;
      	TempParameter_6.Value = item.Code;
      	command.Parameters.Add(TempParameter_6);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	command.ExecuteNonQuery();
      }

      internal static double SaveNewCustomer(string FirstName, string LastName, string Email, string Company, string Phone, string StreetAddress1, string StreetAddress2, string State, string City, string ZipCode, string County)
      {
      	double result = 0;
      	DbConnection conn = OpenConnection();
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = "Insert into Customers(FirstName, LastName, Email, Company, Phone, StreetAddress1, StreetAddress2, State, City, ZipCode, County) " +
      	                         " values (@FirstName, @LastName, @Email, @Company, @Phone, @StreetAddress1, @StreetAddress2, @State, @City, @ZipCode, @County)";
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@FirstName";
      	TempParameter.DbType = DbType.String;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 100;
      	TempParameter.Value = FirstName;
      	objcommand.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = objcommand.CreateParameter();
      	TempParameter_2.ParameterName = "@LastName";
      	TempParameter_2.DbType = DbType.String;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 100;
      	TempParameter_2.Value = LastName;
      	objcommand.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = objcommand.CreateParameter();
      	TempParameter_3.ParameterName = "@Email";
      	TempParameter_3.DbType = DbType.String;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 100;
      	TempParameter_3.Value = Email;
      	objcommand.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = objcommand.CreateParameter();
      	TempParameter_4.ParameterName = "@Company";
      	TempParameter_4.DbType = DbType.String;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 100;
      	TempParameter_4.Value = Company;
      	objcommand.Parameters.Add(TempParameter_4);
      	DbParameter TempParameter_5 = null;
      	TempParameter_5 = objcommand.CreateParameter();
      	TempParameter_5.ParameterName = "@Phone";
      	TempParameter_5.DbType = DbType.String;
      	TempParameter_5.Direction = ParameterDirection.Input;
      	TempParameter_5.Size = 100;
      	TempParameter_5.Value = Phone;
      	objcommand.Parameters.Add(TempParameter_5);
      	DbParameter TempParameter_6 = null;
      	TempParameter_6 = objcommand.CreateParameter();
      	TempParameter_6.ParameterName = "@StreetAddress1";
      	TempParameter_6.DbType = DbType.String;
      	TempParameter_6.Direction = ParameterDirection.Input;
      	TempParameter_6.Size = 100;
      	TempParameter_6.Value = StreetAddress1;
      	objcommand.Parameters.Add(TempParameter_6);
      	DbParameter TempParameter_7 = null;
      	TempParameter_7 = objcommand.CreateParameter();
      	TempParameter_7.ParameterName = "@StreetAddress2";
      	TempParameter_7.DbType = DbType.String;
      	TempParameter_7.Direction = ParameterDirection.Input;
      	TempParameter_7.Size = 100;
      	TempParameter_7.Value = StreetAddress1;
      	objcommand.Parameters.Add(TempParameter_7);
      	DbParameter TempParameter_8 = null;
      	TempParameter_8 = objcommand.CreateParameter();
      	TempParameter_8.ParameterName = "@State";
      	TempParameter_8.DbType = DbType.String;
      	TempParameter_8.Direction = ParameterDirection.Input;
      	TempParameter_8.Size = 100;
      	TempParameter_8.Value = State;
      	objcommand.Parameters.Add(TempParameter_8);
      	DbParameter TempParameter_9 = null;
      	TempParameter_9 = objcommand.CreateParameter();
      	TempParameter_9.ParameterName = "@City";
      	TempParameter_9.DbType = DbType.String;
      	TempParameter_9.Direction = ParameterDirection.Input;
      	TempParameter_9.Size = 100;
      	TempParameter_9.Value = City;
      	objcommand.Parameters.Add(TempParameter_9);
      	DbParameter TempParameter_10 = null;
      	TempParameter_10 = objcommand.CreateParameter();
      	TempParameter_10.ParameterName = "@ZipCode";
      	TempParameter_10.DbType = DbType.String;
      	TempParameter_10.Direction = ParameterDirection.Input;
      	TempParameter_10.Size = 100;
      	TempParameter_10.Value = ZipCode;
      	objcommand.Parameters.Add(TempParameter_10);
      	DbParameter TempParameter_11 = null;
      	TempParameter_11 = objcommand.CreateParameter();
      	TempParameter_11.ParameterName = "@County";
      	TempParameter_11.DbType = DbType.String;
      	TempParameter_11.Direction = ParameterDirection.Input;
      	TempParameter_11.Size = 100;
      	TempParameter_11.Value = County;
      	objcommand.Parameters.Add(TempParameter_11);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(objcommand);
      	objcommand.ExecuteNonQuery();
      	ADORecordSetHelper rs = ADORecordSetHelper.Open("select @@identity", conn, "");
      	result = Convert.ToDouble(rs[0]);
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      	return result;
      }

      internal static void SavePayment(DbConnection conn, int ticketID, int POSID, Payment pay)
      {
      	DbCommand command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Insert into Payments(TicketID, POSID, Amount, PaymentTypeID, PaymentInfo) Values (@TicketID, @POSID, @Amount, @PaymentTypeID, @PaymentInfo)";
      	DbParameter TempParameter = null;
      	TempParameter = command.CreateParameter();
      	TempParameter.ParameterName = "@TicketID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = ticketID;
      	command.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = command.CreateParameter();
      	TempParameter_2.ParameterName = "@POSID";
      	TempParameter_2.DbType = DbType.Decimal;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = POSID;
      	command.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = command.CreateParameter();
      	TempParameter_3.ParameterName = "@Amount";
      	TempParameter_3.DbType = DbType.Decimal;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = pay.PaymentAmount;
      	command.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = command.CreateParameter();
      	TempParameter_4.ParameterName = "@PaymentTypeID";
      	TempParameter_4.DbType = DbType.Decimal;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 0;
      	TempParameter_4.Value = PaymentStringToID(pay.PaymentType);
      	command.Parameters.Add(TempParameter_4);
      	DbParameter TempParameter_5 = null;
      	TempParameter_5 = command.CreateParameter();
      	TempParameter_5.ParameterName = "@PaymentInfo";
      	TempParameter_5.DbType = DbType.String;
      	TempParameter_5.Direction = ParameterDirection.Input;
      	TempParameter_5.Size = 150;
      	TempParameter_5.Value = pay.PaymentInfo;
      	command.Parameters.Add(TempParameter_5);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	command.ExecuteNonQuery();
      }

      // Stores the sale in the database

      internal static bool SaveSale(decimal m_SubTotal, decimal taxes, decimal Total, OrderedDictionary payments, OrderedDictionary items, int currentCustomer, int POSID, int UserID)
      {
      	bool result = false;
      	DbConnection conn = default(DbConnection);
      	try
      	{
      		conn = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
      		conn = OpenConnection();
      		// Start Transaction
      		UpgradeHelpers.DB.TransactionManager.Enlist(conn.BeginTransaction());


      		// Register payment

      		Payment currentPayment = null;
      		foreach (Payment pay in payments.Values)
      		{
      			currentPayment = pay;
      			SavePayment(conn, CurrentTicketID, POSID, currentPayment);
      		}

      		// Register items

      		TicketItem currentItem = null;
      		foreach (TicketItem item in items.Values)
      		{
      			currentItem = item;
      			SaveItem(conn, CurrentTicketID, POSID, currentItem);
      		}

      		CompleteTicket(conn, Total, taxes, POSID, UserID);

      		UpgradeHelpers.DB.TransactionManager.Commit(conn);
      		UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      		conn.Close();
      		return true;
      	}
      	catch
      	{
      		UpgradeHelpers.DB.TransactionManager.Rollback(conn);
      		UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      		conn.Close();
      		result = false;
      	}
      	return result;
      }

      internal static int StartShiftWithAmount(int POSID, int UserID, System.DateTime StartShift, decimal StartCash)
      {
      	int result = 0;
      	DbConnection conn = OpenConnection();
      	// We need to insert the shift information
      	DbCommand command = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();
      	command.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(command);
      	command.CommandText = "Insert into Shifts(POSID, UserID, StartShift, StartCash) " +
      	                      " values (@POSID, @UserID, @StartShift, @StartCash)";
      	DbParameter TempParameter = null;
      	TempParameter = command.CreateParameter();
      	TempParameter.ParameterName = "@POSID";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 0;
      	TempParameter.Value = POSID;
      	command.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = command.CreateParameter();
      	TempParameter_2.ParameterName = "@UserID";
      	TempParameter_2.DbType = DbType.Decimal;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 0;
      	TempParameter_2.Value = UserID;
      	command.Parameters.Add(TempParameter_2);
      	DbParameter TempParameter_3 = null;
      	TempParameter_3 = command.CreateParameter();
      	TempParameter_3.ParameterName = "@StartShift";
      	TempParameter_3.DbType = DbType.Date;
      	TempParameter_3.Direction = ParameterDirection.Input;
      	TempParameter_3.Size = 0;
      	TempParameter_3.Value = StartShift;
      	command.Parameters.Add(TempParameter_3);
      	DbParameter TempParameter_4 = null;
      	TempParameter_4 = command.CreateParameter();
      	TempParameter_4.ParameterName = "@StartCash";
      	TempParameter_4.DbType = DbType.Decimal;
      	TempParameter_4.Direction = ParameterDirection.Input;
      	TempParameter_4.Size = 0;
      	TempParameter_4.Value = StartCash;
      	command.Parameters.Add(TempParameter_4);
      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(command);
      	command.ExecuteNonQuery();

      	ADORecordSetHelper rs = ADORecordSetHelper.Open("select @@identity", conn, "");
      	result = Convert.ToInt32(rs[0]);
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      	return result;
      }

      internal static bool ValidateUserPassword(string UserID, string password)
      {
      	bool result = false;
      	DbConnection conn = OpenConnection();
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();

      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = "Select 1 from users where UserId = @UserId and Password = @Password";
      	objcommand.CommandType = CommandType.Text;
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@UserId";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 50;
      	TempParameter.Value = Convert.ToInt32(Double.Parse(UserID));
      	objcommand.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = objcommand.CreateParameter();
      	TempParameter_2.ParameterName = "@Password";
      	TempParameter_2.DbType = DbType.String;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 50;
      	TempParameter_2.Value = password;
      	objcommand.Parameters.Add(TempParameter_2);

      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(objcommand);
      	ADORecordSetHelper rs = ADORecordSetHelper.Open(objcommand, "");
      	result = rs.RecordCount > 0;
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      	return result;
      }

      internal static bool ValidateUserPasswordAdmin(string UserID, string password)
      {
      	bool result = false;
      	DbConnection conn = OpenConnection();
      	DbCommand objcommand = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateCommand();

      	objcommand.Connection = conn;
      	UpgradeHelpers.DB.DbConnectionHelper.ResetCommandTimeOut(objcommand);
      	objcommand.CommandText = "Select 1 from users where UserId = @UserId and Password = @Password and UserRoleID = 1";
      	objcommand.CommandType = CommandType.Text;
      	DbParameter TempParameter = null;
      	TempParameter = objcommand.CreateParameter();
      	TempParameter.ParameterName = "@UserId";
      	TempParameter.DbType = DbType.Decimal;
      	TempParameter.Direction = ParameterDirection.Input;
      	TempParameter.Size = 50;
      	TempParameter.Value = Convert.ToInt32(Double.Parse(UserID));
      	objcommand.Parameters.Add(TempParameter);
      	DbParameter TempParameter_2 = null;
      	TempParameter_2 = objcommand.CreateParameter();
      	TempParameter_2.ParameterName = "@Password";
      	TempParameter_2.DbType = DbType.String;
      	TempParameter_2.Direction = ParameterDirection.Input;
      	TempParameter_2.Size = 50;
      	TempParameter_2.Value = password;
      	objcommand.Parameters.Add(TempParameter_2);

      	UpgradeHelpers.DB.TransactionManager.SetCommandTransaction(objcommand);
      	ADORecordSetHelper rs = ADORecordSetHelper.Open(objcommand, "");
      	result = rs.RecordCount > 0;
      	UpgradeHelpers.DB.TransactionManager.DeEnlist(conn);
      	conn.Close();
      	return result;
      }

   }
}