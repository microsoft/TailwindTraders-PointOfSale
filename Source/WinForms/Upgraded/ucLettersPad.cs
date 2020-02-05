using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TailwindPOS
{
	internal partial class ucLettersPad
		: System.Windows.Forms.UserControl
	{

		bool m_capstate = false;
		bool m_capsstate = false;
		[field: NonSerialized]
		public event OnEnterEventHandler OnEnterEvent;
		public delegate void OnEnterEventHandler(Object Sender, OnEnterEventEventArgs e);

		private bool m_ShowChars = false;

		public ucLettersPad()
			: base()
		{
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			ReLoadForm(false);
		}




		[Browsable(true)]
		public string Value
		{
			get
			{
				return txtValue.Text;
			}
			set
			{
				txtValue.Text = value;
			}
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
					txtValue.PasswordChar = '\0';
				}
				else
				{
					txtValue.PasswordChar = '*';
				}
			}
		}



		private void cb_Enter_Click(Object eventSender, EventArgs eventArgs)
		{
			if (OnEnterEvent != null)
			{
				OnEnterEvent(this, new OnEnterEventEventArgs(txtValue.Text));
			}
		}

		private void cb_Number1_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "1";
		}

		private void cb_Number2_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "2";
		}

		private void cb_Number3_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "3";

		}

		private void cb_Number4_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "4";

		}

		private void cb_Number5_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "5";

		}

		private void cb_Number6_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "6";

		}

		private void cb_Number7_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "7";

		}

		private void cb_Number8_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "8";

		}

		private void cb_Number9_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "9";

		}

		private void cb_Period_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + ".";

		}



		private void ChangeCase()
		{
			cbLetterA.Text = GetLetter("A");
			cbLetterB.Text = GetLetter("B");
			cbLetterC.Text = GetLetter("C");
			cbLetterD.Text = GetLetter("D");
			cbLetterE.Text = GetLetter("E");
			cbLetterF.Text = GetLetter("F");
			cbLetterG.Text = GetLetter("G");
			cbLetterH.Text = GetLetter("H");
			cbLetterI.Text = GetLetter("I");
			cbLetterJ.Text = GetLetter("J");
			cbLetterK.Text = GetLetter("K");
			cbLetterL.Text = GetLetter("L");
			cbLetterM.Text = GetLetter("M");
			cbLetterN.Text = GetLetter("N");
			cbLetterO.Text = GetLetter("O");
			cbLetterP.Text = GetLetter("P");
			cbLetterQ.Text = GetLetter("Q");
			cbLetterR.Text = GetLetter("R");
			cbLetterS.Text = GetLetter("S");
			cbLetterT.Text = GetLetter("T");
			cbLetterU.Text = GetLetter("U");
			cbLetterV.Text = GetLetter("V");
			cbLetterW.Text = GetLetter("W");
			cbLetterX.Text = GetLetter("X");
			cbLetterY.Text = GetLetter("Y");
			cbLetterZ.Text = GetLetter("Z");
		}

		private string GetLetter(string X)
		{
			return (m_capstate) ? X.ToUpper() : X.ToLower();
		}

		private void cbAllCaps_Click(Object eventSender, EventArgs eventArgs)
		{
			// toggle caps state
			if (!m_capstate)
			{
				m_capstate = true;
				cbAllCaps.BackColor = Color.Yellow;
				cbAllCaps.Text = "ALL CAPS";
			}
			else
			{
				m_capstate = false;
				cbAllCaps.BackColor = SystemColors.Window;
				cbAllCaps.Text = "NO CAPS";
			}
			ChangeCase();
		}

		private void cbAt_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("@");

		}

		private void cbDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			if (txtValue.Text != "")
			{
				txtValue.Text = txtValue.Text.Substring(0, Math.Min(Strings.Len(txtValue.Text) - 1, txtValue.Text.Length));
			}
		}

		private void cbLetterA_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("A");

		}

		private void cbLetterB_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("B");

		}

		private void cbLetterC_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("C");

		}

		private void cbLetterD_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("D");

		}

		private void cbLetterE_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("E");

		}

		private void cbLetterF_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("F");

		}

		private void cbLetterG_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("G");

		}

		private void cbLetterH_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("H");

		}

		private void cbLetterI_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("I");
		}

		private void cbLetterJ_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("J");
		}

		private void cbLetterK_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("K");
		}

		private void cbLetterL_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("L");
		}

		private void cbLetterM_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("M");
		}

		private void cbLetterN_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("N");
		}

		private void cbLetterO_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("O");
		}

		private void cbLetterP_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("P");
		}

		private void cbLetterQ_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("Q");
		}

		private void cbLetterR_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("R");
		}

		private void cbLetterS_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("S");
		}

		private void cbLetterT_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("T");
		}

		private void cbLetterU_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("U");
		}

		private void cbLetterV_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("V");
		}

		private void cbLetterW_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("W");
		}

		private void cbLetterX_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("X");
		}

		private void cbLetterY_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("Y");
		}

		private void cbLetterZ_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + GetLetter("Z");
		}

		private void cbMinus_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "-";
		}

		private void cbSpace_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + " ";
		}

		private void cbUnderscore_Click(Object eventSender, EventArgs eventArgs)
		{
			txtValue.Text = txtValue.Text + "_";
		}

		//UPGRADE_NOTE: (7001) The following declaration (Command1_Click) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
		//private void Command1_Click()
		//{
			//
		//}

		private void UserControl_Initialize()
		{
			m_capstate = true;
		}
	}
}