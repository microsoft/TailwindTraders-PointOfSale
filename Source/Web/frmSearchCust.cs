using System;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   [Observable]
   internal partial class frmSearchCust
      : Mobilize.Web.Form
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

      [Intercepted]



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
      	fgCustomers
            .SetCellValue( 0, 0, "Custo No");
         //First Name
         fgCustomers
            .SetCellValue( 1, 0, "First Name");
         //Last Name
         fgCustomers
            .SetCellValue( 2, 0, "Last Name");
         //Email
         fgCustomers
            .SetCellValue( 3, 0, "Email");
         //Street1
         fgCustomers
            .SetCellValue( 4, 0, "Street 1");

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
      		fgCustomers
               .SetCellValue( 0, index, (Convert.IsDBNull(rs["CustomerID"])) ? "" : Convert.ToString(rs["CustomerID"]));
            //First Name
            //UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
            fgCustomers
               .SetCellValue( 1, index, (Convert.IsDBNull(rs["FirstName"])) ? "" : Convert.ToString(rs["FirstName"]));
            //Last Name
            //UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
            fgCustomers
               .SetCellValue( 2, index, (Convert.IsDBNull(rs["LastName"])) ? "" : Convert.ToString(rs["LastName"]));
            //Email
            //UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
            fgCustomers
               .SetCellValue( 3, index, (Convert.IsDBNull(rs["Email"])) ? "" : Convert.ToString(rs["Email"]));
            //Street1
            //UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
            fgCustomers
               .SetCellValue( 4, index, (Convert.IsDBNull(rs["StreetAddress1"])) ? "" : Convert.ToString(rs["StreetAddress1"]));
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