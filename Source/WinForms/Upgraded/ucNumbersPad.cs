using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TailwindPOS
{
	internal partial class ucNumbersPad
		: System.Windows.Forms.UserControl
	{

		[field: NonSerialized]
		public event OnNumberHandler OnNumber;
		public delegate void OnNumberHandler(Object Sender, OnNumberEventArgs e);

		[field: NonSerialized]
		public event OnBackHandler OnBack;
		public delegate void OnBackHandler(Object Sender, EventArgs e);


		[field: NonSerialized]
		public event OnEnterEventHandler OnEnterEvent;
		public delegate void OnEnterEventHandler(Object Sender, OnEnterEventEventArgs e);

		private bool m_ShowChars = false;
		public ucNumbersPad()
			: base()
		{
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}




		[Browsable(true)]
		public bool ShowChars
		{
			get
			{
				return m_ShowChars;
			}
			set
			{
				m_ShowChars = value;
				if (value)
				{
					txtAmount.PasswordChar = '\0';
				}
				else
				{
					txtAmount.PasswordChar = '*';
				}
			}
		}



		[Browsable(true)]
		public bool ShowEnter
		{
			get
			{
				return cb_Enter.Visible;
			}
			set
			{
				cb_Enter.Visible = value;
			}
		}



		[Browsable(true)]
		public bool ShowValue
		{
			get
			{
				return txtAmount.Visible;
			}
			set
			{
				txtAmount.Visible = value;
			}
		}



		[Browsable(true)]
		public string Value
		{
			get
			{
				return txtAmount.Text;
			}
			set
			{
				txtAmount.Text = value;
			}
		}


		private void cb_Back_Click(Object eventSender, EventArgs eventArgs)
		{
			if (Strings.Len(txtAmount.Text) > 0)
			{
				txtAmount.Text = txtAmount.Text.Substring(0, Math.Min(Strings.Len(txtAmount.Text) - 1, txtAmount.Text.Length));
			}
			if (OnBack != null)
			{
				OnBack(this, null);
			}
		}

		private void cb_Clear_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = "";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs(""));
			}
		}

		private void cb_Enter_Click(Object eventSender, EventArgs eventArgs)
		{
			if (OnEnterEvent != null)
			{
				OnEnterEvent(this, new OnEnterEventEventArgs(txtAmount.Text));
			}
		}

		private void cb_Number00_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "00";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("00"));
			}
		}

		private void cb_Number0_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "0";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("0"));
			}
		}

		private void cb_Number1_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "1";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("1"));
			}
		}

		private void cb_Number2_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "2";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("2"));
			}
		}

		private void cb_Number3_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "3";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("3"));
			}
		}

		private void cb_Number4_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "4";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("4"));
			}
		}

		private void cb_Number5_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "5";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("5"));
			}
		}

		private void cb_Number6_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "6";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("6"));
			}
		}

		private void cb_Number7_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "7";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("7"));
			}
		}

		private void cb_Number8_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "8";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("8"));
			}
		}

		private void cb_Number9_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + "9";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("9"));
			}
		}

		private void cb_Period_Click(Object eventSender, EventArgs eventArgs)
		{
			txtAmount.Text = txtAmount.Text + ".";
			if (OnNumber != null)
			{
				OnNumber(this, new OnNumberEventArgs("."));
			}
		}

		public void HighlightValueOff()
		{
			txtAmount.BackColor = Color.White;
		}

		public void HighlightValueOn()
		{
			txtAmount.BackColor = Color.Yellow;
		}

		private void txtAmount_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Strings.Asc(eventArgs.KeyChar);
			try
			{
				// When Enter is pressed
				if (KeyAscii == 13)
				{
					if (OnEnterEvent != null)
					{
						OnEnterEvent(this, new OnEnterEventEventArgs(txtAmount.Text));
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}
	}
}