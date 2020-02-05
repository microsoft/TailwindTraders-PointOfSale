using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   [Observable]
   internal partial class frmSales
      : Mobilize.Web.Form
   {

      [Intercepted]

      bool m_Toggle_Quantity { get; set; } = false;

      [Intercepted]
      int m_CurrentCustomer { get; set; } = 0;

      [Intercepted]
      string m_CurrentDescription { get; set; } = "";

      [Intercepted]

      decimal m_Taxes { get; set; } = 0;

      [Intercepted]
      decimal m_SubTotal { get; set; } = 0;

      [Intercepted]
      decimal m_total { get; set; } = 0;

      [Intercepted]
      string m_lastReceipt { get; set; } = "";


      public frmSales()
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



      public string LastReceipt
      {
      	get
      	{
      		return m_lastReceipt;
      	}
      }


      public void AddLine(string Code, string Description, decimal price)
      {
         (
         fgItems.RowsCount)++;
         int lastRow = fgItems.RowsCount - 1;
         // Quantity
         fgItems
            .SetCellValue( 0, lastRow, "1");
         // Item ID
         fgItems
            .SetCellValue( 1, lastRow, Code);
         // Description
         fgItems
            .SetCellValue( 2, lastRow, Description);
         // Price
         fgItems
            .SetCellValue( 3, lastRow, price.ToString());
         // Total
         fgItems
            .SetCellValue( 4, lastRow, price.ToString());
         UpdateTotals();
      }

      private void cbAddCustomer_Click(Object eventSender, EventArgs eventArgs)
      {
      	frmCustAdd custAdd = frmCustAdd.CreateInstance();
      	custAdd.ShowDialog();
      	if (custAdd.SavedCustomer)
      	{
      		// Saves the current customer ID and updates its info on the sales screen
      		m_CurrentCustomer = (custAdd.SavedCustomerID) ? -1 : 0;
      		LoadCustomerInfo(m_CurrentCustomer);
      	}
      }

      private void cbBreak_Click(Object eventSender, EventArgs eventArgs)
      {
      	Pause();
      }

      private void cbCustomerSearch_Click(Object eventSender, EventArgs eventArgs)
      {
      	frmSearchCust custSearch = frmSearchCust.CreateInstance();
      	custSearch.ShowDialog();
      	if (custSearch.ChosenCustomer > 0)
      	{
      		// Saves the current customer ID and updates its info on the sales screen
      		m_CurrentCustomer = custSearch.ChosenCustomer;
      		LoadCustomerInfo(m_CurrentCustomer);
      	}
      }

      private void cbLogOff_Click(Object eventSender, EventArgs eventArgs)
      {
         Mobilize.Web.DialogResult result = (Mobilize.Web.DialogResult) 0;
         frmCashCount cash = null;
         if (MainModule.IsShiftStarted())
         {
         	result = Mobilize.Web.MessageBox.Show("Are you ready to end your shift", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.YesNo);
            if (result == Mobilize.Web.DialogResult.Yes)
            {
            	cash = frmCashCount.CreateInstance();
            	cash.ShowDialog();
            	this.Hide();
            }
         }
      }

      private void cbPayment_Click(Object eventSender, EventArgs eventArgs)
      {
      	OrderedDictionary payments = null;
      	frmPayment pay = frmPayment.CreateInstance();
      	pay.TransactionAmount = m_total;
      	pay.UpdateTotals();
      	// We need a ticket number
      	// Because it will be needed when sending it to
      	// credit card processor
      	if (MainModule.CurrentTicketID == 0)
      	{
      		MainModule.CurrentTicketID = MainModule.CreateTicket(m_CurrentCustomer, MainModule.CurrentPOS.POSID, MainModule.CurrentShift.UserID);
      	}
      	OrderedDictionary items = GetItems();
      	if (items.Count > 0)
      	{
      		pay.ShowDialog();
      		if (pay.PaymentDone)
      		{

      			payments = pay.GetPayments();
      			if (MainModule.SaveSale(m_SubTotal, m_Taxes, m_total, payments, items, m_CurrentCustomer, MainModule.CurrentPOS.POSID, MainModule.CurrentShift.UserID))
      			{
      				Reset();
      				UpdateTotals();
      			}
      			else
      			{
                  Mobilize.Web.MessageBox.Show("Error saving sale", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName);
               }

            }
         }
         else
         {
            Mobilize.Web.MessageBox.Show("Error no items registered", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName);
         }
      }

      private void cbQuantity_Click(Object eventSender, EventArgs eventArgs)
      {
      	ToggleQuantity();
      }

      private void cbRePrint_Click(Object eventSender, EventArgs eventArgs)
      {
         Mobilize.Web.MessageBox.Show("Printing Last Receipt", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName);
      }

      private void cbVoidItem_Click(Object eventSender, EventArgs eventArgs)
      {
      	// If we are not positioned on the header
      	if (fgItems.RowSel >= 1)
      	{
      		TryToVoidItem(fgItems.CurrentRowIndex);
      	}
      }

      private void cbVoidTransaction_Click(Object eventSender, EventArgs eventArgs)
      {
      	if (ConfirmVoidSale())
      	{
      		VoidSale();
      	}
      }

      public bool ConfirmVoidItem(int itemRow)
      {
      	bool result = false;
      	string itemName = "";
      	OrderedDictionary items = GetItems();
      	bool res = false;
      	if (items.Count > 0)
      	{
      		itemName = Convert.ToString(fgItems[itemRow, 2].Value);
      		res = ((int)Mobilize.Web.MessageBox.Show("Are you sure you want remove line for " + itemName + "?", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.YesNo)) != 0;
            result = res == (((int)Mobilize.Web.DialogResult.Yes) != 0);
         }
         return result;
      }

      public bool ConfirmVoidSale()
      {
         Mobilize.Web.DialogResult result = Mobilize.Web.MessageBox.Show("Are you sure you want to cancel this sale?", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.YesNo);
         return result == Mobilize.Web.DialogResult.Yes;
      }



      private OrderedDictionary GetItems()
      {
      	OrderedDictionary coll = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
      	// Read info from grid
      	int tempForEndVar = fgItems.RowsCount - 1;
      	double qty = 0;
      	decimal price = 0;
      	int Code = 0;
      	string Desc = "";
      	TicketItem item = null;
      	for (int i = 1; i <= tempForEndVar; i++)
      	{
      		// Quantity
      		qty = Convert.ToInt32(Double.Parse(Convert.ToString(fgItems[i, 0].Value)));
      		// Price
      		price = Decimal.Parse(Convert.ToString(fgItems[i, 3].Value), NumberStyles.Currency | NumberStyles.AllowExponent);
      		// Code
      		Code = Convert.ToInt32(Decimal.Parse(Convert.ToString(fgItems[i, 1].Value), NumberStyles.Currency | NumberStyles.AllowExponent));
      		// Description
      		Desc = Convert.ToString(this.fgItems[i, 2].Value);

      		// Create item info
      		// and insert it into collection
      		item = new TicketItem();
      		item.Code = Code;
      		item.Line = i;
      		item.price = price;
      		item.Units = Convert.ToInt32(qty);
      		item.Description = Desc;
      		coll.Add(Guid.NewGuid().ToString(), item);
      	}
      	return coll;
      }

      public void LoadCustomerInfo(int customerInfo)
      {
      	string customer = MainModule.GetCustomerInfo(customerInfo);
      	lblCustomerInfo.Text = customer;
      }

      private void Pause()
      {
      	frmPause Pause = frmPause.CreateInstance();
      	Pause.ShowDialog();
      }


      // Cleans up for a new sale

      public void Reset()
      {
      	// Reset customer
      	m_CurrentCustomer = -1;
      	lblCustomerInfo.Text = "";
      	// Clean TicketID
      	MainModule.CurrentTicketID = 0;
      	// Update POS Name
      	lblPOS.Text = MainModule.CurrentPOS.POSName;
      	// Update Cashier ID
      	lblCashier.Text = MainModule.CurrentShift.UserID.ToString();
      	// Reset KeyPas
      	ucNumericKeyPad.ShowChars = true;
      	ucNumericKeyPad.Value = "";

      	// Reset Quantity Button
      	m_Toggle_Quantity = false;
      	cbQuantity.BackColor = Color.White;
      	// Reset Items Grid
      	this.fgItems.RowsCount = 1;
      	this.fgItems.SetCellValue( 0, 0, " Qty");
         this.fgItems.SetCellValue( 1, 0, " Item ID ");
         this.fgItems.SetCellValue( 2, 0, " Description ");
         this.fgItems.SetCellValue( 3, 0, " Price ");
         this.fgItems.SetCellValue( 4, 0, " Total ");
      }

      //UPGRADE_NOTE: (7001) The following declaration (ReturnFromPause) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      //private void ReturnFromPause()
      //{
      	//Reset();
      //}

      public void SearchAndAddProduct(string productCode)
      {
      	string ProductDescription = "";
      	decimal ProductPrice = 0;
      	if (productCode != "")
      	{
      		if (MainModule.FindProductByCode(productCode, ref ProductDescription, ref ProductPrice))
      		{
      			// If product was found add line
      			AddLine(productCode, ProductDescription, ProductPrice);
      		}
      	}
      	// Clear keypad
      	ucNumericKeyPad.Value = "";
      }

      // Switches between quantity modification mode and
      // normal mode

      public void ToggleQuantity()
      {
      	if (m_Toggle_Quantity)
      	{
      		m_Toggle_Quantity = false;
      		cbQuantity.BackColor = Color.White;
      		ucNumericKeyPad.HighlightValueOff();
      		ucNumericKeyPad.Value = "";
      		ucNumericKeyPad.Focus();
      	}
      	else
      	{
      		m_Toggle_Quantity = true;
      		cbQuantity.BackColor = Color.Yellow;
      		ucNumericKeyPad.HighlightValueOn();
      		ucNumericKeyPad.Focus();
      	}
      }

      public void TryToVoidItem(int itemRow)
      {
      	if (ConfirmVoidItem(itemRow))
      	{
      		VoidItem(itemRow);
      	}
      }


      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	Pause();
      	MainModule.CurrentShift.UserID = MainModule.PRESET_TERMINALID;
      	Reset();
      }

      private void ucNumericKeyPad_OnEnterEvent(Object Sender, ucNumbersPad.OnEnterEventEventArgs e)
      {
      	string Text_Renamed = e.Text_Renamed;
      	// If we are on quantity mode
      	// we will update only the qty for the current item
      	int newqty = 0;
      	decimal price = 0;
      	decimal Total = 0;
      	int qty = 0;
      	if (m_Toggle_Quantity)
      	{
      		newqty = Convert.ToInt32(Double.Parse(Text_Renamed));
      		if (fgItems.CurrentRowIndex >= 1)
      		{
      			// Update quantity
      			this.fgItems.SetCellValue( 0, fgItems.CurrentRowIndex, newqty.ToString());
               // Price
               price = Decimal.Parse(Convert.ToString(fgItems[fgItems.CurrentRowIndex, 3].Value), NumberStyles.Currency | NumberStyles.AllowExponent);
               Total += (qty * price);
               UpdateTotals();
            }
         }
         else
         {
            SearchAndAddProduct(Text_Renamed);

         }
      }

      public void UpdateTotals()
      {
      	decimal Total = 0;
      	int tempForEndVar = fgItems.RowsCount - 1;
      	double qty = 0;
      	decimal price = 0;
      	for (int i = 1; i <= tempForEndVar; i++)
      	{
      		// Quantity
      		qty = Convert.ToInt32(Double.Parse(Convert.ToString(fgItems[i, 0].Value)));
      		// Price
      		price = Decimal.Parse(Convert.ToString(fgItems[i, 3].Value), NumberStyles.Currency | NumberStyles.AllowExponent);
      		Total += ((decimal) (qty * ((double) price)));
      		// Total
      		fgItems
               .SetCellValue( 4, i, Total.ToString());
         }

         m_SubTotal = Total;
         m_Taxes = (decimal) (((double) Total) * 0.65d);
         m_total = (decimal) (((double) Total) * 1.65d);
         lblSubTotal.Text = m_SubTotal.ToString("C");
         lblTax.Text = m_Taxes.ToString("C");
         lblTotal.Text = m_total.ToString("C");
      }

      public void VoidItem(int itemRow)
      {
      	// A flex grid does not allow removing the last non fixed row
      	if (fgItems.RowsCount == 2)
      	{
      		fgItems.RowsCount = 1;
      	}
      	else
      	{
      		fgItems.RemoveItem(itemRow);
      	}
      	UpdateTotals();
      }

      // Reset the sale

      public object VoidSale()
      {
      	Reset();
      	UpdateTotals();
      	return null;
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }
}