using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;

namespace TailwindPOS
{
	internal partial class frmSearchCust
		: System.Windows.Forms.Form
	{

		public frmSearchCust()
			: base()
		{
			if (m_vb6FormDefInstance == null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}



		public int ChosenCustomer
		{
			get;
			private set;
		}


		private void cbClose_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Hide();
		}

		private void fgCustomers_DoubleClick(Object eventSender, EventArgs eventArgs)
		{
			// If a customer was chosen
			object customerNo = null;
			if (fgCustomers.CurrentRowIndex >= 1)
			{
				ChosenCustomer = Convert.ToInt32(Double.Parse(Convert.ToString(fgCustomers[fgCustomers.CurrentRowIndex, 0].Value)));
				this.Hide();
			}
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			ucLettersPad.ShowChars = true;
			fgCustomers.RowsCount = 1;
			AddHeadersToGrid();
			ChosenCustomer = -1;
		}

		public void AddHeadersToGrid()
		{
			//Cust No
			fgCustomers[0, 0].Value = "Custo No";
			//First Name
			fgCustomers[0, 1].Value = "First Name";
			//Last Name
			fgCustomers[0, 2].Value = "Last Name";
			//Email
			fgCustomers[0, 3].Value = "Email";
			//Street1
			fgCustomers[0, 4].Value = "Street 1";

		}

		public void SearchCustomer(string customerInfo)
		{
			ADORecordSetHelper rs = MainModule.FindCustomers(customerInfo);
			fgCustomers.RowsCount = rs.RecordCount + 1;
			int index = 1;
			while (!rs.EOF)
			{
				//Custo No
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
				fgCustomers[index, 0].Value = (Convert.IsDBNull(rs["CustomerID"])) ? "" : Convert.ToString(rs["CustomerID"]);
				//First Name
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
				fgCustomers[index, 1].Value = (Convert.IsDBNull(rs["FirstName"])) ? "" : Convert.ToString(rs["FirstName"]);
				//Last Name
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
				fgCustomers[index, 2].Value = (Convert.IsDBNull(rs["LastName"])) ? "" : Convert.ToString(rs["LastName"]);
				//Email
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
				fgCustomers[index, 3].Value = (Convert.IsDBNull(rs["Email"])) ? "" : Convert.ToString(rs["Email"]);
				//Street1
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
				fgCustomers[index, 4].Value = (Convert.IsDBNull(rs["StreetAddress1"])) ? "" : Convert.ToString(rs["StreetAddress1"]);
				index++;
				rs.MoveNext();
			}

		}

		private void ucLettersPad_OnEnterEvent(Object Sender, ucLettersPad.OnEnterEventEventArgs e)
		{
			string Text_Renamed = e.Text_Renamed;
			SearchCustomer(ucLettersPad.Value);
			ucLettersPad.Value = "";
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}