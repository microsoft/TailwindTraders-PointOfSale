using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmCashCount
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmCashCount m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
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

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "txtHalfDollars", "txtPennies", "txtNickels", "txtDimes", "txtQuarters", "txtOnes", "txtFives", "txtTens", "txtHundreds", "txtTwenties", "txtFifties", "cbOK", "cbClear", "ucNumbers", "lblMessage", "lblPennies", "lblNickels", "lblDimes", "lblQuarters", "lblHalfDollars", "lblOnes", "lblFives", "lblTens", "lblTwenties", "lblFifties", "lblHundreds", "lblTotalTitle", "lblTotal"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtHalfDollars { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtPennies { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtNickels { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtDimes { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtQuarters { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtOnes { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtFives { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtTens { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtHundreds { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtTwenties { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtFifties { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbOK { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbClear { get; set; }

      [Intercepted]
      public ucNumbersPad ucNumbers { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblMessage { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPennies { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblNickels { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblDimes { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblQuarters { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblHalfDollars { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblOnes { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblFives { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTens { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTwenties { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblFifties { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblHundreds { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTotalTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTotal { get; set; }
      
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashCount));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.txtHalfDollars = new Mobilize.Web.TextBox();
      	this.txtPennies = new Mobilize.Web.TextBox();
      	this.txtNickels = new Mobilize.Web.TextBox();
      	this.txtDimes = new Mobilize.Web.TextBox();
      	this.txtQuarters = new Mobilize.Web.TextBox();
      	this.txtOnes = new Mobilize.Web.TextBox();
      	this.txtFives = new Mobilize.Web.TextBox();
      	this.txtTens = new Mobilize.Web.TextBox();
      	this.txtHundreds = new Mobilize.Web.TextBox();
      	this.txtTwenties = new Mobilize.Web.TextBox();
      	this.txtFifties = new Mobilize.Web.TextBox();
      	this.cbOK = new Mobilize.Web.Button();
      	this.cbClear = new Mobilize.Web.Button();
      	this.ucNumbers = new ucNumbersPad();
      	this.lblMessage = new Mobilize.Web.Label();
      	this.lblPennies = new Mobilize.Web.Label();
      	this.lblNickels = new Mobilize.Web.Label();
      	this.lblDimes = new Mobilize.Web.Label();
      	this.lblQuarters = new Mobilize.Web.Label();
      	this.lblHalfDollars = new Mobilize.Web.Label();
      	this.lblOnes = new Mobilize.Web.Label();
      	this.lblFives = new Mobilize.Web.Label();
      	this.lblTens = new Mobilize.Web.Label();
      	this.lblTwenties = new Mobilize.Web.Label();
      	this.lblFifties = new Mobilize.Web.Label();
      	this.lblHundreds = new Mobilize.Web.Label();
      	this.lblTotalTitle = new Mobilize.Web.Label();
      	this.lblTotal = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	
      	// 
      	// txtHalfDollars
      	// 
      	this.txtHalfDollars.AcceptsReturn = true;
      	this.txtHalfDollars.AllowDrop = true;
      	this.txtHalfDollars.BackColor = System.Drawing.Color.White;
      	this.txtHalfDollars.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtHalfDollars.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtHalfDollars.Location = new System.Drawing.Point(160, 296);
         this.txtHalfDollars.MaxLength = 0;
         this.txtHalfDollars.Name = "txtHalfDollars";

         this.txtHalfDollars.Size = new System.Drawing.Size(113, 49);
         this.txtHalfDollars.TabIndex = 12;
         this.txtHalfDollars.Text = "0";
         this.txtHalfDollars.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtHalfDollars.Enter += new System.EventHandler(this.txtHalfDollars_Enter);
         this.txtHalfDollars.Leave += new System.EventHandler(this.txtHalfDollars_Leave);
         // 
         // txtPennies
         // 
         this.txtPennies.AcceptsReturn = true;
         this.txtPennies.AllowDrop = true;
         this.txtPennies.BackColor = System.Drawing.Color.White;
         this.txtPennies.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtPennies.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtPennies.Location = new System.Drawing.Point(160, 72);
         this.txtPennies.MaxLength = 0;
         this.txtPennies.Name = "txtPennies";

         this.txtPennies.Size = new System.Drawing.Size(113, 49);
         this.txtPennies.TabIndex = 11;
         this.txtPennies.Text = "0";
         this.txtPennies.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtPennies.Enter += new System.EventHandler(this.txtPennies_Enter);
         this.txtPennies.Leave += new System.EventHandler(this.txtPennies_Leave);
         // 
         // txtNickels
         // 
         this.txtNickels.AcceptsReturn = true;
         this.txtNickels.AllowDrop = true;
         this.txtNickels.BackColor = System.Drawing.Color.White;
         this.txtNickels.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtNickels.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtNickels.Location = new System.Drawing.Point(160, 128);
         this.txtNickels.MaxLength = 0;
         this.txtNickels.Name = "txtNickels";

         this.txtNickels.Size = new System.Drawing.Size(113, 49);
         this.txtNickels.TabIndex = 10;
         this.txtNickels.Text = "0";
         this.txtNickels.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtNickels.Enter += new System.EventHandler(this.txtNickels_Enter);
         this.txtNickels.Leave += new System.EventHandler(this.txtNickels_Leave);
         // 
         // txtDimes
         // 
         this.txtDimes.AcceptsReturn = true;
         this.txtDimes.AllowDrop = true;
         this.txtDimes.BackColor = System.Drawing.Color.White;
         this.txtDimes.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtDimes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtDimes.Location = new System.Drawing.Point(160, 184);
         this.txtDimes.MaxLength = 0;
         this.txtDimes.Name = "txtDimes";

         this.txtDimes.Size = new System.Drawing.Size(113, 49);
         this.txtDimes.TabIndex = 9;
         this.txtDimes.Text = "0";
         this.txtDimes.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtDimes.Enter += new System.EventHandler(this.txtDimes_Enter);
         this.txtDimes.Leave += new System.EventHandler(this.txtDimes_Leave);
         // 
         // txtQuarters
         // 
         this.txtQuarters.AcceptsReturn = true;
         this.txtQuarters.AllowDrop = true;
         this.txtQuarters.BackColor = System.Drawing.Color.White;
         this.txtQuarters.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtQuarters.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtQuarters.Location = new System.Drawing.Point(160, 240);
         this.txtQuarters.MaxLength = 0;
         this.txtQuarters.Name = "txtQuarters";

         this.txtQuarters.Size = new System.Drawing.Size(113, 49);
         this.txtQuarters.TabIndex = 8;
         this.txtQuarters.Text = "0";
         this.txtQuarters.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtQuarters.Enter += new System.EventHandler(this.txtQuarters_Enter);
         this.txtQuarters.Leave += new System.EventHandler(this.txtQuarters_Leave);
         // 
         // txtOnes
         // 
         this.txtOnes.AcceptsReturn = true;
         this.txtOnes.AllowDrop = true;
         this.txtOnes.BackColor = System.Drawing.Color.White;
         this.txtOnes.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtOnes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtOnes.Location = new System.Drawing.Point(416, 72);
         this.txtOnes.MaxLength = 0;
         this.txtOnes.Name = "txtOnes";

         this.txtOnes.Size = new System.Drawing.Size(113, 49);
         this.txtOnes.TabIndex = 7;
         this.txtOnes.Text = "0";
         this.txtOnes.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtOnes.Enter += new System.EventHandler(this.txtOnes_Enter);
         this.txtOnes.Leave += new System.EventHandler(this.txtOnes_Leave);
         // 
         // txtFives
         // 
         this.txtFives.AcceptsReturn = true;
         this.txtFives.AllowDrop = true;
         this.txtFives.BackColor = System.Drawing.Color.White;
         this.txtFives.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtFives.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtFives.Location = new System.Drawing.Point(416, 128);
         this.txtFives.MaxLength = 0;
         this.txtFives.Name = "txtFives";

         this.txtFives.Size = new System.Drawing.Size(113, 49);
         this.txtFives.TabIndex = 6;
         this.txtFives.Text = "0";
         this.txtFives.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtFives.Enter += new System.EventHandler(this.txtFives_Enter);
         this.txtFives.Leave += new System.EventHandler(this.txtFives_Leave);
         // 
         // txtTens
         // 
         this.txtTens.AcceptsReturn = true;
         this.txtTens.AllowDrop = true;
         this.txtTens.BackColor = System.Drawing.Color.White;
         this.txtTens.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtTens.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtTens.Location = new System.Drawing.Point(416, 184);
         this.txtTens.MaxLength = 0;
         this.txtTens.Name = "txtTens";

         this.txtTens.Size = new System.Drawing.Size(113, 49);
         this.txtTens.TabIndex = 5;
         this.txtTens.Text = "0";
         this.txtTens.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtTens.Enter += new System.EventHandler(this.txtTens_Enter);
         this.txtTens.Leave += new System.EventHandler(this.txtTens_Leave);
         // 
         // txtHundreds
         // 
         this.txtHundreds.AcceptsReturn = true;
         this.txtHundreds.AllowDrop = true;
         this.txtHundreds.BackColor = System.Drawing.Color.White;
         this.txtHundreds.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtHundreds.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtHundreds.Location = new System.Drawing.Point(416, 352);
         this.txtHundreds.MaxLength = 0;
         this.txtHundreds.Name = "txtHundreds";

         this.txtHundreds.Size = new System.Drawing.Size(113, 49);
         this.txtHundreds.TabIndex = 4;
         this.txtHundreds.Text = "0";
         this.txtHundreds.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtHundreds.Enter += new System.EventHandler(this.txtHundreds_Enter);
         this.txtHundreds.Leave += new System.EventHandler(this.txtHundreds_Leave);
         // 
         // txtTwenties
         // 
         this.txtTwenties.AcceptsReturn = true;
         this.txtTwenties.AllowDrop = true;
         this.txtTwenties.BackColor = System.Drawing.Color.White;
         this.txtTwenties.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtTwenties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtTwenties.Location = new System.Drawing.Point(416, 240);
         this.txtTwenties.MaxLength = 0;
         this.txtTwenties.Name = "txtTwenties";

         this.txtTwenties.Size = new System.Drawing.Size(113, 49);
         this.txtTwenties.TabIndex = 3;
         this.txtTwenties.Text = "0";
         this.txtTwenties.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtTwenties.Enter += new System.EventHandler(this.txtTwenties_Enter);
         this.txtTwenties.Leave += new System.EventHandler(this.txtTwenties_Leave);
         // 
         // txtFifties
         // 
         this.txtFifties.AcceptsReturn = true;
         this.txtFifties.AllowDrop = true;
         this.txtFifties.BackColor = System.Drawing.Color.White;
         this.txtFifties.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtFifties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.txtFifties.Location = new System.Drawing.Point(416, 296);
         this.txtFifties.MaxLength = 0;
         this.txtFifties.Name = "txtFifties";

         this.txtFifties.Size = new System.Drawing.Size(113, 49);
         this.txtFifties.TabIndex = 2;
         this.txtFifties.Text = "0";
         this.txtFifties.TextAlign = Mobilize.Web.HorizontalAlignment.Center;
         this.txtFifties.Enter += new System.EventHandler(this.txtFifties_Enter);
         this.txtFifties.Leave += new System.EventHandler(this.txtFifties_Leave);
         // 
         // cbOK
         // 
         this.cbOK.AllowDrop = true;
         this.cbOK.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
         this.cbOK.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbOK.Location = new System.Drawing.Point(568, 136);
         this.cbOK.Name = "cbOK";

         this.cbOK.Size = new System.Drawing.Size(409, 57);
         this.cbOK.TabIndex = 1;
         this.cbOK.Text = "OK";
         this.cbOK.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbOK.UseVisualStyleBackColor = false;
         this.cbOK.Click += new System.EventHandler(this.cbOK_Click);
         // 
         // cbClear
         // 
         this.cbClear.AllowDrop = true;
         this.cbClear.BackColor = System.Drawing.Color.White;
         this.cbClear.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbClear.Location = new System.Drawing.Point(568, 72);
         this.cbClear.Name = "cbClear";

         this.cbClear.Size = new System.Drawing.Size(409, 57);
         this.cbClear.TabIndex = 0;
         this.cbClear.Text = "Clear";
         this.cbClear.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
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
         this.lblMessage.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblMessage.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblMessage.Location = new System.Drawing.Point(8, 8);
         this.lblMessage.Name = "lblMessage";

         this.lblMessage.Size = new System.Drawing.Size(297, 49);
         this.lblMessage.TabIndex = 27;
         this.lblMessage.Text = "Enter Cash Amount";
         // 
         // lblPennies
         // 
         this.lblPennies.AllowDrop = true;
         this.lblPennies.BackColor = System.Drawing.Color.White;
         this.lblPennies.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPennies.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblPennies.Location = new System.Drawing.Point(8, 72);
         this.lblPennies.Name = "lblPennies";

         this.lblPennies.Size = new System.Drawing.Size(145, 49);
         this.lblPennies.TabIndex = 26;
         this.lblPennies.Text = "Pennies";
         // 
         // lblNickels
         // 
         this.lblNickels.AllowDrop = true;
         this.lblNickels.BackColor = System.Drawing.Color.White;
         this.lblNickels.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblNickels.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblNickels.Location = new System.Drawing.Point(8, 128);
         this.lblNickels.Name = "lblNickels";

         this.lblNickels.Size = new System.Drawing.Size(145, 49);
         this.lblNickels.TabIndex = 25;
         this.lblNickels.Text = "Nickels";
         // 
         // lblDimes
         // 
         this.lblDimes.AllowDrop = true;
         this.lblDimes.BackColor = System.Drawing.Color.White;
         this.lblDimes.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblDimes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblDimes.Location = new System.Drawing.Point(8, 184);
         this.lblDimes.Name = "lblDimes";

         this.lblDimes.Size = new System.Drawing.Size(145, 49);
         this.lblDimes.TabIndex = 24;
         this.lblDimes.Text = "Dimes";
         // 
         // lblQuarters
         // 
         this.lblQuarters.AllowDrop = true;
         this.lblQuarters.BackColor = System.Drawing.Color.White;
         this.lblQuarters.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblQuarters.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblQuarters.Location = new System.Drawing.Point(8, 240);
         this.lblQuarters.Name = "lblQuarters";

         this.lblQuarters.Size = new System.Drawing.Size(145, 49);
         this.lblQuarters.TabIndex = 23;
         this.lblQuarters.Text = "Quarters";
         // 
         // lblHalfDollars
         // 
         this.lblHalfDollars.AllowDrop = true;
         this.lblHalfDollars.BackColor = System.Drawing.Color.White;
         this.lblHalfDollars.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblHalfDollars.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblHalfDollars.Location = new System.Drawing.Point(8, 296);
         this.lblHalfDollars.Name = "lblHalfDollars";

         this.lblHalfDollars.Size = new System.Drawing.Size(145, 49);
         this.lblHalfDollars.TabIndex = 22;
         this.lblHalfDollars.Text = "Half Dollars";
         // 
         // lblOnes
         // 
         this.lblOnes.AllowDrop = true;
         this.lblOnes.BackColor = System.Drawing.Color.White;
         this.lblOnes.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblOnes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblOnes.Location = new System.Drawing.Point(296, 72);
         this.lblOnes.Name = "lblOnes";

         this.lblOnes.Size = new System.Drawing.Size(185, 41);
         this.lblOnes.TabIndex = 21;
         this.lblOnes.Text = "Ones";
         // 
         // lblFives
         // 
         this.lblFives.AllowDrop = true;
         this.lblFives.BackColor = System.Drawing.Color.White;
         this.lblFives.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblFives.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblFives.Location = new System.Drawing.Point(296, 128);
         this.lblFives.Name = "lblFives";

         this.lblFives.Size = new System.Drawing.Size(185, 41);
         this.lblFives.TabIndex = 20;
         this.lblFives.Text = "Fives";
         // 
         // lblTens
         // 
         this.lblTens.AllowDrop = true;
         this.lblTens.BackColor = System.Drawing.Color.White;
         this.lblTens.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTens.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTens.Location = new System.Drawing.Point(296, 184);
         this.lblTens.Name = "lblTens";

         this.lblTens.Size = new System.Drawing.Size(185, 41);
         this.lblTens.TabIndex = 19;
         this.lblTens.Text = "Tens";
         // 
         // lblTwenties
         // 
         this.lblTwenties.AllowDrop = true;
         this.lblTwenties.BackColor = System.Drawing.Color.White;
         this.lblTwenties.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTwenties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTwenties.Location = new System.Drawing.Point(296, 240);
         this.lblTwenties.Name = "lblTwenties";

         this.lblTwenties.Size = new System.Drawing.Size(185, 41);
         this.lblTwenties.TabIndex = 18;
         this.lblTwenties.Text = "Twenties";
         // 
         // lblFifties
         // 
         this.lblFifties.AllowDrop = true;
         this.lblFifties.BackColor = System.Drawing.Color.White;
         this.lblFifties.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblFifties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblFifties.Location = new System.Drawing.Point(296, 288);
         this.lblFifties.Name = "lblFifties";

         this.lblFifties.Size = new System.Drawing.Size(185, 41);
         this.lblFifties.TabIndex = 17;
         this.lblFifties.Text = "Fifties";
         // 
         // lblHundreds
         // 
         this.lblHundreds.AllowDrop = true;
         this.lblHundreds.BackColor = System.Drawing.Color.White;
         this.lblHundreds.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblHundreds.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblHundreds.Location = new System.Drawing.Point(296, 344);
         this.lblHundreds.Name = "lblHundreds";

         this.lblHundreds.Size = new System.Drawing.Size(185, 41);
         this.lblHundreds.TabIndex = 16;
         this.lblHundreds.Text = "Hundreds";
         // 
         // lblTotalTitle
         // 
         this.lblTotalTitle.AllowDrop = true;
         this.lblTotalTitle.BackColor = System.Drawing.Color.White;
         this.lblTotalTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTotalTitle.Location = new System.Drawing.Point(568, 8);
         this.lblTotalTitle.Name = "lblTotalTitle";

         this.lblTotalTitle.Size = new System.Drawing.Size(113, 57);
         this.lblTotalTitle.TabIndex = 15;
         this.lblTotalTitle.Text = "Total";
         // 
         // lblTotal
         // 
         this.lblTotal.AllowDrop = true;
         this.lblTotal.BackColor = System.Drawing.Color.White;
         this.lblTotal.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTotal.Location = new System.Drawing.Point(728, 8);
         this.lblTotal.Name = "lblTotal";

         this.lblTotal.Size = new System.Drawing.Size(249, 65);
         this.lblTotal.TabIndex = 14;
         this.lblTotal.Text = "$0";
         this.lblTotal.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // frmCashCount
         // 
         this.AllowDrop = true;


         this.BackColor = System.Drawing.Color.White;

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
         this.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);

         this.MaximizeBox = true;
         this.MinimizeBox = true;
         this.Name = "frmCashCount";


         this.Text = "  Count Cash Drawer";
         this.Closed += new System.EventHandler(this.Form_Closed);

      }
      #endregion

   }
}