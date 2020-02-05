using System;
using System.Windows.Forms;

namespace TailwindPOS
{
	internal partial class frmGiftCardCode
		: System.Windows.Forms.Form
	{

		public frmGiftCardCode()
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




		public string Code
		{
			get
			{
				return txtCode.Text;
			}
		}



		private void cbCancel_Click(Object eventSender, EventArgs eventArgs)
		{
			// Clean code
			txtCode.Text = "";
			this.Hide();
		}

		private void cbOK_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Hide();
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}