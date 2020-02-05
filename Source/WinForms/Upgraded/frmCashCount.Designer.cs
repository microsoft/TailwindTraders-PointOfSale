
namespace TailwindPOS
{
	partial class frmCashCount
	{

		#region "Upgrade Support "
		private static frmCashCount m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCashCount DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmCashCount CreateInstance()
		{
			frmCashCount theInstance = new frmCashCount();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtHalfDollars", "txtPennies", "txtNickels", "txtDimes", "txtQuarters", "txtOnes", "txtFives", "txtTens", "txtHundreds", "txtTwenties", "txtFifties", "cbOK", "cbClear", "ucNumbers", "lblMessage", "lblPennies", "lblNickels", "lblDimes", "lblQuarters", "lblHalfDollars", "lblOnes", "lblFives", "lblTens", "lblTwenties", "lblFifties", "lblHundreds", "lblTotalTitle", "lblTotal", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtHalfDollars;
		public System.Windows.Forms.TextBox txtPennies;
		public System.Windows.Forms.TextBox txtNickels;
		public System.Windows.Forms.TextBox txtDimes;
		public System.Windows.Forms.TextBox txtQuarters;
		public System.Windows.Forms.TextBox txtOnes;
		public System.Windows.Forms.TextBox txtFives;
		public System.Windows.Forms.TextBox txtTens;
		public System.Windows.Forms.TextBox txtHundreds;
		public System.Windows.Forms.TextBox txtTwenties;
		public System.Windows.Forms.TextBox txtFifties;
		public System.Windows.Forms.Button cbOK;
		public System.Windows.Forms.Button cbClear;
		public ucNumbersPad ucNumbers;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.Label lblPennies;
		public System.Windows.Forms.Label lblNickels;
		public System.Windows.Forms.Label lblDimes;
		public System.Windows.Forms.Label lblQuarters;
		public System.Windows.Forms.Label lblHalfDollars;
		public System.Windows.Forms.Label lblOnes;
		public System.Windows.Forms.Label lblFives;
		public System.Windows.Forms.Label lblTens;
		public System.Windows.Forms.Label lblTwenties;
		public System.Windows.Forms.Label lblFifties;
		public System.Windows.Forms.Label lblHundreds;
		public System.Windows.Forms.Label lblTotalTitle;
		public System.Windows.Forms.Label lblTotal;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashCount));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtHalfDollars = new System.Windows.Forms.TextBox();
			this.txtPennies = new System.Windows.Forms.TextBox();
			this.txtNickels = new System.Windows.Forms.TextBox();
			this.txtDimes = new System.Windows.Forms.TextBox();
			this.txtQuarters = new System.Windows.Forms.TextBox();
			this.txtOnes = new System.Windows.Forms.TextBox();
			this.txtFives = new System.Windows.Forms.TextBox();
			this.txtTens = new System.Windows.Forms.TextBox();
			this.txtHundreds = new System.Windows.Forms.TextBox();
			this.txtTwenties = new System.Windows.Forms.TextBox();
			this.txtFifties = new System.Windows.Forms.TextBox();
			this.cbOK = new System.Windows.Forms.Button();
			this.cbClear = new System.Windows.Forms.Button();
			this.ucNumbers = new ucNumbersPad();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblPennies = new System.Windows.Forms.Label();
			this.lblNickels = new System.Windows.Forms.Label();
			this.lblDimes = new System.Windows.Forms.Label();
			this.lblQuarters = new System.Windows.Forms.Label();
			this.lblHalfDollars = new System.Windows.Forms.Label();
			this.lblOnes = new System.Windows.Forms.Label();
			this.lblFives = new System.Windows.Forms.Label();
			this.lblTens = new System.Windows.Forms.Label();
			this.lblTwenties = new System.Windows.Forms.Label();
			this.lblFifties = new System.Windows.Forms.Label();
			this.lblHundreds = new System.Windows.Forms.Label();
			this.lblTotalTitle = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// txtHalfDollars
			// 
			this.txtHalfDollars.AcceptsReturn = true;
			this.txtHalfDollars.AllowDrop = true;
			this.txtHalfDollars.BackColor = System.Drawing.Color.White;
			this.txtHalfDollars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHalfDollars.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHalfDollars.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtHalfDollars.Location = new System.Drawing.Point(160, 296);
			this.txtHalfDollars.MaxLength = 0;
			this.txtHalfDollars.Name = "txtHalfDollars";
			this.txtHalfDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHalfDollars.Size = new System.Drawing.Size(113, 49);
			this.txtHalfDollars.TabIndex = 12;
			this.txtHalfDollars.Text = "0";
			this.txtHalfDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHalfDollars.Enter += new System.EventHandler(this.txtHalfDollars_Enter);
			this.txtHalfDollars.Leave += new System.EventHandler(this.txtHalfDollars_Leave);
			// 
			// txtPennies
			// 
			this.txtPennies.AcceptsReturn = true;
			this.txtPennies.AllowDrop = true;
			this.txtPennies.BackColor = System.Drawing.Color.White;
			this.txtPennies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPennies.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPennies.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtPennies.Location = new System.Drawing.Point(160, 72);
			this.txtPennies.MaxLength = 0;
			this.txtPennies.Name = "txtPennies";
			this.txtPennies.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPennies.Size = new System.Drawing.Size(113, 49);
			this.txtPennies.TabIndex = 11;
			this.txtPennies.Text = "0";
			this.txtPennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPennies.Enter += new System.EventHandler(this.txtPennies_Enter);
			this.txtPennies.Leave += new System.EventHandler(this.txtPennies_Leave);
			// 
			// txtNickels
			// 
			this.txtNickels.AcceptsReturn = true;
			this.txtNickels.AllowDrop = true;
			this.txtNickels.BackColor = System.Drawing.Color.White;
			this.txtNickels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtNickels.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNickels.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtNickels.Location = new System.Drawing.Point(160, 128);
			this.txtNickels.MaxLength = 0;
			this.txtNickels.Name = "txtNickels";
			this.txtNickels.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNickels.Size = new System.Drawing.Size(113, 49);
			this.txtNickels.TabIndex = 10;
			this.txtNickels.Text = "0";
			this.txtNickels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNickels.Enter += new System.EventHandler(this.txtNickels_Enter);
			this.txtNickels.Leave += new System.EventHandler(this.txtNickels_Leave);
			// 
			// txtDimes
			// 
			this.txtDimes.AcceptsReturn = true;
			this.txtDimes.AllowDrop = true;
			this.txtDimes.BackColor = System.Drawing.Color.White;
			this.txtDimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtDimes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDimes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtDimes.Location = new System.Drawing.Point(160, 184);
			this.txtDimes.MaxLength = 0;
			this.txtDimes.Name = "txtDimes";
			this.txtDimes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDimes.Size = new System.Drawing.Size(113, 49);
			this.txtDimes.TabIndex = 9;
			this.txtDimes.Text = "0";
			this.txtDimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDimes.Enter += new System.EventHandler(this.txtDimes_Enter);
			this.txtDimes.Leave += new System.EventHandler(this.txtDimes_Leave);
			// 
			// txtQuarters
			// 
			this.txtQuarters.AcceptsReturn = true;
			this.txtQuarters.AllowDrop = true;
			this.txtQuarters.BackColor = System.Drawing.Color.White;
			this.txtQuarters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtQuarters.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtQuarters.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtQuarters.Location = new System.Drawing.Point(160, 240);
			this.txtQuarters.MaxLength = 0;
			this.txtQuarters.Name = "txtQuarters";
			this.txtQuarters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtQuarters.Size = new System.Drawing.Size(113, 49);
			this.txtQuarters.TabIndex = 8;
			this.txtQuarters.Text = "0";
			this.txtQuarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQuarters.Enter += new System.EventHandler(this.txtQuarters_Enter);
			this.txtQuarters.Leave += new System.EventHandler(this.txtQuarters_Leave);
			// 
			// txtOnes
			// 
			this.txtOnes.AcceptsReturn = true;
			this.txtOnes.AllowDrop = true;
			this.txtOnes.BackColor = System.Drawing.Color.White;
			this.txtOnes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtOnes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtOnes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtOnes.Location = new System.Drawing.Point(416, 72);
			this.txtOnes.MaxLength = 0;
			this.txtOnes.Name = "txtOnes";
			this.txtOnes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtOnes.Size = new System.Drawing.Size(113, 49);
			this.txtOnes.TabIndex = 7;
			this.txtOnes.Text = "0";
			this.txtOnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOnes.Enter += new System.EventHandler(this.txtOnes_Enter);
			this.txtOnes.Leave += new System.EventHandler(this.txtOnes_Leave);
			// 
			// txtFives
			// 
			this.txtFives.AcceptsReturn = true;
			this.txtFives.AllowDrop = true;
			this.txtFives.BackColor = System.Drawing.Color.White;
			this.txtFives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtFives.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFives.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtFives.Location = new System.Drawing.Point(416, 128);
			this.txtFives.MaxLength = 0;
			this.txtFives.Name = "txtFives";
			this.txtFives.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFives.Size = new System.Drawing.Size(113, 49);
			this.txtFives.TabIndex = 6;
			this.txtFives.Text = "0";
			this.txtFives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFives.Enter += new System.EventHandler(this.txtFives_Enter);
			this.txtFives.Leave += new System.EventHandler(this.txtFives_Leave);
			// 
			// txtTens
			// 
			this.txtTens.AcceptsReturn = true;
			this.txtTens.AllowDrop = true;
			this.txtTens.BackColor = System.Drawing.Color.White;
			this.txtTens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtTens.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTens.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtTens.Location = new System.Drawing.Point(416, 184);
			this.txtTens.MaxLength = 0;
			this.txtTens.Name = "txtTens";
			this.txtTens.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTens.Size = new System.Drawing.Size(113, 49);
			this.txtTens.TabIndex = 5;
			this.txtTens.Text = "0";
			this.txtTens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTens.Enter += new System.EventHandler(this.txtTens_Enter);
			this.txtTens.Leave += new System.EventHandler(this.txtTens_Leave);
			// 
			// txtHundreds
			// 
			this.txtHundreds.AcceptsReturn = true;
			this.txtHundreds.AllowDrop = true;
			this.txtHundreds.BackColor = System.Drawing.Color.White;
			this.txtHundreds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHundreds.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHundreds.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtHundreds.Location = new System.Drawing.Point(416, 352);
			this.txtHundreds.MaxLength = 0;
			this.txtHundreds.Name = "txtHundreds";
			this.txtHundreds.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHundreds.Size = new System.Drawing.Size(113, 49);
			this.txtHundreds.TabIndex = 4;
			this.txtHundreds.Text = "0";
			this.txtHundreds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHundreds.Enter += new System.EventHandler(this.txtHundreds_Enter);
			this.txtHundreds.Leave += new System.EventHandler(this.txtHundreds_Leave);
			// 
			// txtTwenties
			// 
			this.txtTwenties.AcceptsReturn = true;
			this.txtTwenties.AllowDrop = true;
			this.txtTwenties.BackColor = System.Drawing.Color.White;
			this.txtTwenties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtTwenties.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTwenties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtTwenties.Location = new System.Drawing.Point(416, 240);
			this.txtTwenties.MaxLength = 0;
			this.txtTwenties.Name = "txtTwenties";
			this.txtTwenties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTwenties.Size = new System.Drawing.Size(113, 49);
			this.txtTwenties.TabIndex = 3;
			this.txtTwenties.Text = "0";
			this.txtTwenties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTwenties.Enter += new System.EventHandler(this.txtTwenties_Enter);
			this.txtTwenties.Leave += new System.EventHandler(this.txtTwenties_Leave);
			// 
			// txtFifties
			// 
			this.txtFifties.AcceptsReturn = true;
			this.txtFifties.AllowDrop = true;
			this.txtFifties.BackColor = System.Drawing.Color.White;
			this.txtFifties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtFifties.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFifties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtFifties.Location = new System.Drawing.Point(416, 296);
			this.txtFifties.MaxLength = 0;
			this.txtFifties.Name = "txtFifties";
			this.txtFifties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFifties.Size = new System.Drawing.Size(113, 49);
			this.txtFifties.TabIndex = 2;
			this.txtFifties.Text = "0";
			this.txtFifties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFifties.Enter += new System.EventHandler(this.txtFifties_Enter);
			this.txtFifties.Leave += new System.EventHandler(this.txtFifties_Leave);
			// 
			// cbOK
			// 
			this.cbOK.AllowDrop = true;
			this.cbOK.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			this.cbOK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbOK.Location = new System.Drawing.Point(568, 136);
			this.cbOK.Name = "cbOK";
			this.cbOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbOK.Size = new System.Drawing.Size(409, 57);
			this.cbOK.TabIndex = 1;
			this.cbOK.Text = "OK";
			this.cbOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbOK.UseVisualStyleBackColor = false;
			this.cbOK.Click += new System.EventHandler(this.cbOK_Click);
			// 
			// cbClear
			// 
			this.cbClear.AllowDrop = true;
			this.cbClear.BackColor = System.Drawing.Color.White;
			this.cbClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbClear.Location = new System.Drawing.Point(568, 72);
			this.cbClear.Name = "cbClear";
			this.cbClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbClear.Size = new System.Drawing.Size(409, 57);
			this.cbClear.TabIndex = 0;
			this.cbClear.Text = "Clear";
			this.cbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbClear.UseVisualStyleBackColor = false;
			this.cbClear.Click += new System.EventHandler(this.cbClear_Click);
			// 
			// ucNumbers
			// 
			this.ucNumbers.AllowDrop = true;
			this.ucNumbers.Location = new System.Drawing.Point(568, 200);
			this.ucNumbers.Name = "ucNumbers";
			this.ucNumbers.Size = new System.Drawing.Size(377, 425);
			this.ucNumbers.TabIndex = 13;
			this.ucNumbers.OnBack += new ucNumbersPad.OnBackHandler(this.ucNumbers_OnBack);
			this.ucNumbers.OnNumber += new ucNumbersPad.OnNumberHandler(this.ucNumbers_OnNumber);
			// 
			// lblMessage
			// 
			this.lblMessage.AllowDrop = true;
			this.lblMessage.BackColor = System.Drawing.Color.White;
			this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblMessage.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblMessage.Location = new System.Drawing.Point(8, 8);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMessage.Size = new System.Drawing.Size(297, 49);
			this.lblMessage.TabIndex = 27;
			this.lblMessage.Text = "Enter Cash Amount";
			// 
			// lblPennies
			// 
			this.lblPennies.AllowDrop = true;
			this.lblPennies.BackColor = System.Drawing.Color.White;
			this.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPennies.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblPennies.Location = new System.Drawing.Point(8, 72);
			this.lblPennies.Name = "lblPennies";
			this.lblPennies.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPennies.Size = new System.Drawing.Size(145, 49);
			this.lblPennies.TabIndex = 26;
			this.lblPennies.Text = "Pennies";
			// 
			// lblNickels
			// 
			this.lblNickels.AllowDrop = true;
			this.lblNickels.BackColor = System.Drawing.Color.White;
			this.lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblNickels.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblNickels.Location = new System.Drawing.Point(8, 128);
			this.lblNickels.Name = "lblNickels";
			this.lblNickels.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNickels.Size = new System.Drawing.Size(145, 49);
			this.lblNickels.TabIndex = 25;
			this.lblNickels.Text = "Nickels";
			// 
			// lblDimes
			// 
			this.lblDimes.AllowDrop = true;
			this.lblDimes.BackColor = System.Drawing.Color.White;
			this.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblDimes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblDimes.Location = new System.Drawing.Point(8, 184);
			this.lblDimes.Name = "lblDimes";
			this.lblDimes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDimes.Size = new System.Drawing.Size(145, 49);
			this.lblDimes.TabIndex = 24;
			this.lblDimes.Text = "Dimes";
			// 
			// lblQuarters
			// 
			this.lblQuarters.AllowDrop = true;
			this.lblQuarters.BackColor = System.Drawing.Color.White;
			this.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblQuarters.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblQuarters.Location = new System.Drawing.Point(8, 240);
			this.lblQuarters.Name = "lblQuarters";
			this.lblQuarters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblQuarters.Size = new System.Drawing.Size(145, 49);
			this.lblQuarters.TabIndex = 23;
			this.lblQuarters.Text = "Quarters";
			// 
			// lblHalfDollars
			// 
			this.lblHalfDollars.AllowDrop = true;
			this.lblHalfDollars.BackColor = System.Drawing.Color.White;
			this.lblHalfDollars.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblHalfDollars.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblHalfDollars.Location = new System.Drawing.Point(8, 296);
			this.lblHalfDollars.Name = "lblHalfDollars";
			this.lblHalfDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblHalfDollars.Size = new System.Drawing.Size(145, 49);
			this.lblHalfDollars.TabIndex = 22;
			this.lblHalfDollars.Text = "Half Dollars";
			// 
			// lblOnes
			// 
			this.lblOnes.AllowDrop = true;
			this.lblOnes.BackColor = System.Drawing.Color.White;
			this.lblOnes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblOnes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblOnes.Location = new System.Drawing.Point(296, 72);
			this.lblOnes.Name = "lblOnes";
			this.lblOnes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblOnes.Size = new System.Drawing.Size(185, 41);
			this.lblOnes.TabIndex = 21;
			this.lblOnes.Text = "Ones";
			// 
			// lblFives
			// 
			this.lblFives.AllowDrop = true;
			this.lblFives.BackColor = System.Drawing.Color.White;
			this.lblFives.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblFives.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblFives.Location = new System.Drawing.Point(296, 128);
			this.lblFives.Name = "lblFives";
			this.lblFives.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFives.Size = new System.Drawing.Size(185, 41);
			this.lblFives.TabIndex = 20;
			this.lblFives.Text = "Fives";
			// 
			// lblTens
			// 
			this.lblTens.AllowDrop = true;
			this.lblTens.BackColor = System.Drawing.Color.White;
			this.lblTens.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTens.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTens.Location = new System.Drawing.Point(296, 184);
			this.lblTens.Name = "lblTens";
			this.lblTens.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTens.Size = new System.Drawing.Size(185, 41);
			this.lblTens.TabIndex = 19;
			this.lblTens.Text = "Tens";
			// 
			// lblTwenties
			// 
			this.lblTwenties.AllowDrop = true;
			this.lblTwenties.BackColor = System.Drawing.Color.White;
			this.lblTwenties.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTwenties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTwenties.Location = new System.Drawing.Point(296, 240);
			this.lblTwenties.Name = "lblTwenties";
			this.lblTwenties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTwenties.Size = new System.Drawing.Size(185, 41);
			this.lblTwenties.TabIndex = 18;
			this.lblTwenties.Text = "Twenties";
			// 
			// lblFifties
			// 
			this.lblFifties.AllowDrop = true;
			this.lblFifties.BackColor = System.Drawing.Color.White;
			this.lblFifties.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblFifties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblFifties.Location = new System.Drawing.Point(296, 288);
			this.lblFifties.Name = "lblFifties";
			this.lblFifties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFifties.Size = new System.Drawing.Size(185, 41);
			this.lblFifties.TabIndex = 17;
			this.lblFifties.Text = "Fifties";
			// 
			// lblHundreds
			// 
			this.lblHundreds.AllowDrop = true;
			this.lblHundreds.BackColor = System.Drawing.Color.White;
			this.lblHundreds.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblHundreds.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblHundreds.Location = new System.Drawing.Point(296, 344);
			this.lblHundreds.Name = "lblHundreds";
			this.lblHundreds.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblHundreds.Size = new System.Drawing.Size(185, 41);
			this.lblHundreds.TabIndex = 16;
			this.lblHundreds.Text = "Hundreds";
			// 
			// lblTotalTitle
			// 
			this.lblTotalTitle.AllowDrop = true;
			this.lblTotalTitle.BackColor = System.Drawing.Color.White;
			this.lblTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTotalTitle.Location = new System.Drawing.Point(568, 8);
			this.lblTotalTitle.Name = "lblTotalTitle";
			this.lblTotalTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTotalTitle.Size = new System.Drawing.Size(113, 57);
			this.lblTotalTitle.TabIndex = 15;
			this.lblTotalTitle.Text = "Total";
			// 
			// lblTotal
			// 
			this.lblTotal.AllowDrop = true;
			this.lblTotal.BackColor = System.Drawing.Color.White;
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTotal.Location = new System.Drawing.Point(728, 8);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTotal.Size = new System.Drawing.Size(249, 65);
			this.lblTotal.TabIndex = 14;
			this.lblTotal.Text = "$0";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmCashCount
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1038, 640);
			this.ControlBox = false;
			this.Controls.Add(this.txtHalfDollars);
			this.Controls.Add(this.txtPennies);
			this.Controls.Add(this.txtNickels);
			this.Controls.Add(this.txtDimes);
			this.Controls.Add(this.txtQuarters);
			this.Controls.Add(this.txtOnes);
			this.Controls.Add(this.txtFives);
			this.Controls.Add(this.txtTens);
			this.Controls.Add(this.txtHundreds);
			this.Controls.Add(this.txtTwenties);
			this.Controls.Add(this.txtFifties);
			this.Controls.Add(this.cbOK);
			this.Controls.Add(this.cbClear);
			this.Controls.Add(this.ucNumbers);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblPennies);
			this.Controls.Add(this.lblNickels);
			this.Controls.Add(this.lblDimes);
			this.Controls.Add(this.lblQuarters);
			this.Controls.Add(this.lblHalfDollars);
			this.Controls.Add(this.lblOnes);
			this.Controls.Add(this.lblFives);
			this.Controls.Add(this.lblTens);
			this.Controls.Add(this.lblTwenties);
			this.Controls.Add(this.lblFifties);
			this.Controls.Add(this.lblHundreds);
			this.Controls.Add(this.lblTotalTitle);
			this.Controls.Add(this.lblTotal);
			this.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Location = new System.Drawing.Point(4, 27);
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "frmCashCount";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Count Cash Drawer";
			commandButtonHelper1.SetStyle(this.cbOK, 1);
			commandButtonHelper1.SetStyle(this.cbClear, 1);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}