using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Windows.Forms;

namespace TailwindPOS
{
	internal partial class frmPayment
		: System.Windows.Forms.Form
	{

		decimal m_transactionAmount = 0;
		string resultString = "";
		decimal m_paidSoFar = 0;
		bool m_paymentDone = false;
		public frmPayment()
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



		public bool PaymentDone
		{
			get
			{
				return m_paymentDone;
			}
		}



		public decimal TransactionAmount
		{
			get
			{
				return m_transactionAmount;
			}
			set
			{
				m_transactionAmount = value;
			}
		}


		// Adds a payment to the payments grid
		public void AddPayment(string amount, string paymentType, string PaymentInfo)
		{

			if (Decimal.Parse(amount, NumberStyles.Currency | NumberStyles.AllowExponent) <= 0)
			{
				return;
			}

			decimal money = Decimal.Parse(amount, NumberStyles.Currency | NumberStyles.AllowExponent);
			int lastRow = fgPayments.RowsCount;
			fgPayments.RowsCount++;
			fgPayments[lastRow, 0].Value = paymentType;
			fgPayments[lastRow, 1].Value = amount;
			fgPayments[lastRow, 2].Value = PaymentInfo;
			UpdateTotals();
		}

		private void cbCash_Click(Object eventSender, EventArgs eventArgs)
		{
			AddPayment(ucNumbers.Value, "Cash", "");
		}

		private void cbCheck_Click(Object eventSender, EventArgs eventArgs)
		{
			AddPayment(ucNumbers.Value, "Check", "");
		}

		private void cbCreditCard_Click(Object eventSender, EventArgs eventArgs)
		{
			string amount = ucNumbers.Value;
			string invoice = MainModule.CurrentTicketID.ToString();
			resultString = "";
			resultString = MainModule.RunCreditCardPayment(invoice, amount);

			string[] results = (string[]) resultString.Split(',');
			if (results[0] == "SUCCESS")
			{
				AddPayment(amount, "Credit", resultString);
			}
			else
			{
				MessageBox.Show(resultString, Application.ProductName);
			}
		}

		private void cbFinishPayment_Click(Object eventSender, EventArgs eventArgs)
		{
			if (m_paidSoFar >= m_transactionAmount)
			{
				m_paymentDone = true;
				this.Hide();
			}
			else
			{
				MessageBox.Show("Payment is not complete. Press Cancel to Abort", Application.ProductName);
			}
		}

		private void cbGiftCard_Click(Object eventSender, EventArgs eventArgs)
		{
			frmGiftCardCode giftCard = frmGiftCardCode.CreateInstance();
			giftCard.ShowDialog();
			if (giftCard.Code != "")
			{
				AddPayment(ucNumbers.Value, "Gift Card", giftCard.Code);
			}
		}

		private void cb_Cancel_Click(Object eventSender, EventArgs eventArgs)
		{
			m_paymentDone = false;
			this.Hide();
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			gbPayments.Visible = true;
			ucNumbers.ShowChars = true;
			ucNumbers.ShowEnter = false;
			// Setup grid titles
			fgPayments[0, 0].Value = "Type";
			fgPayments[0, 1].Value = "Amount";
			// Updates the totals and amounts due
			UpdateTotals();
		}

		// Returns a Collection of Payment info objects with
		// all the information about the payments so far
		public OrderedDictionary GetPayments()
		{
			OrderedDictionary payments = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
			// Remove the header from the rows count
			int totalRows = fgPayments.RowsCount - 1;
			int tempForEndVar = totalRows;
			Payment pay = null;
			for (int index = 1; index <= tempForEndVar; index++)
			{
				pay = new Payment();
				pay.PaymentType = Convert.ToString(fgPayments[index, 0].Value);
				pay.PaymentAmount = Decimal.Parse(Convert.ToString(fgPayments[index, 1].Value), NumberStyles.Currency | NumberStyles.AllowExponent);
				pay.PaymentInfo = Convert.ToString(fgPayments[index, 2].Value);

				payments.Add(Guid.NewGuid().ToString(), pay);
			}
			return payments;
		}

		// Sums up all the payments
		public decimal SumPayments()
		{
			decimal result = 0;
			// Remove the header from the rows count
			int totalRows = fgPayments.RowsCount - 1;
			int tempForEndVar = totalRows;
			for (int index = 1; index <= tempForEndVar; index++)
			{
				result += Decimal.Parse(Convert.ToString(fgPayments[index, 1].Value), NumberStyles.Currency | NumberStyles.AllowExponent);
			}
			return result;
		}

		// Sums up all the payments
		// And updates the paid so far amount
		public void UpdateTotals()
		{
			ucNumbers.Value = "";
			m_paidSoFar = SumPayments();
			lblRemaining.Text = (m_transactionAmount - m_paidSoFar).ToString("C");
			if (m_paidSoFar > m_transactionAmount)
			{
				gbPayments.Visible = false;
				lblPaymentReady.Visible = true;
				lblChange.Text = (m_paidSoFar - m_transactionAmount).ToString("C");
			}
			else
			{
				lblChange.Text = (0).ToString("C");
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}