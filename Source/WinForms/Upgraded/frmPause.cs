using System;
using System.Windows.Forms;

namespace TailwindPOS
{
	internal partial class frmPause
		: System.Windows.Forms.Form
	{

		int m_BreakId = 0;
		public frmPause()
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


		private void cbReturn_Click(Object eventSender, EventArgs eventArgs)
		{
			decimal MINIMUM_CASH = 0;
			decimal Total = 0;
			frmCashCount cash = null;
			int ShiftID = 0;
			if (MainModule.CurrentShift.UserID == 0)
			{
				// And we need a shift
				MessageBox.Show("You are starting your shift, please count cash on drawer", Application.ProductName);
				Total = 0;
				while (Total < 300)
				{
					cash = frmCashCount.CreateInstance();
					cash.ShowDialog();
					Total = cash.Total;
					// Validate that the POS has enough cash on Drawer to
					// Begin shift
					if (Total > MINIMUM_CASH)
					{
						// Start a shift and register it into database
						ShiftID = MainModule.StartShiftWithAmount(MainModule.CurrentPOS.POSID, MainModule.CurrentShift.UserID, DateTime.Now, Total);
						if (ShiftID > 0)
						{
							this.Hide();
							MainModule.CurrentShift.ShiftID = ShiftID;
						}
					}
					else
					{
						MessageBox.Show("You need to have a minimum of " + MINIMUM_CASH.ToString() + " to Start a Shift", Application.ProductName);
					}
				}
			}
			else
			{
				this.Hide();
			}
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			int CurrentUserID = 0;
			m_BreakId = 0;
			// There is a Current Shift Then Register a Break
			if (MainModule.CurrentShift.ShiftID != 0)
			{
				m_BreakId = MainModule.RegisterBreakStart(MainModule.CurrentPOS.POSID, MainModule.CurrentShift.ShiftID, DateTime.Now);
			}
			else
			{
				if (CurrentUserID == 0)
				{
					lblPauseMessage.Text = "No user Logged In";
				}

			}
		}

		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
			if (m_BreakId != 0)
			{
				MainModule.RegisterBreakEnd(MainModule.CurrentPOS.POSID, MainModule.CurrentShift.ShiftID, m_BreakId, DateTime.Now);
			}
		}
	}
}