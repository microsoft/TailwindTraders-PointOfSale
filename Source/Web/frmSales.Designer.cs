using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmSales
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmSales m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
      public static frmSales DefInstance
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

      public static frmSales CreateInstance()
      {
      	frmSales theInstance = new frmSales();
      	theInstance.Form_Load();
      	return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "cbRePrint", "ucNumericKeyPad", "cbQuantity", "fgItems", "lblCustomerInfo", "gbCustomerInfo", "cbBreak", "cbLogOff", "cbVoidTransaction", "cbVoidItem", "cbAddCustomer", "cbCustomerSearch", "cbPayment", "lblTotal", "lblTax", "lblSubTotal", "lblTotalTitle", "lblTaxTitle", "lblSubTotalTitle", "frSubTotals", "picLogo", "lblPOS", "lblPOSTitle", "lblCashier", "lblCashierTitle", "commandButtonHelper1"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbRePrint { get; set; }

      [Intercepted]
      public ucNumbersPad ucNumericKeyPad { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbQuantity { get; set; }

      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgItems { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblCustomerInfo { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox gbCustomerInfo { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbBreak { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbLogOff { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbVoidTransaction { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbVoidItem { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbAddCustomer { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbCustomerSearch { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbPayment { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTotal { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTax { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblSubTotal { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTotalTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTaxTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblSubTotalTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox frSubTotals { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox picLogo { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPOS { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPOSTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblCashier { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblCashierTitle { get; set; }

      [Intercepted]
      private Stub._UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1 { get; set; }
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cbRePrint = new Mobilize.Web.Button();
      	this.ucNumericKeyPad = new ucNumbersPad();
      	this.cbQuantity = new Mobilize.Web.Button();
      	this.fgItems = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.gbCustomerInfo = new Mobilize.Web.GroupBox();
      	this.lblCustomerInfo = new Mobilize.Web.Label();
      	this.cbBreak = new Mobilize.Web.Button();
      	this.cbLogOff = new Mobilize.Web.Button();
      	this.cbVoidTransaction = new Mobilize.Web.Button();
      	this.cbVoidItem = new Mobilize.Web.Button();
      	this.cbAddCustomer = new Mobilize.Web.Button();
      	this.cbCustomerSearch = new Mobilize.Web.Button();
      	this.cbPayment = new Mobilize.Web.Button();
      	this.frSubTotals = new Mobilize.Web.GroupBox();
      	this.lblTotal = new Mobilize.Web.Label();
      	this.lblTax = new Mobilize.Web.Label();
      	this.lblSubTotal = new Mobilize.Web.Label();
      	this.lblTotalTitle = new Mobilize.Web.Label();
      	this.lblTaxTitle = new Mobilize.Web.Label();
      	this.lblSubTotalTitle = new Mobilize.Web.Label();
      	this.picLogo = new Mobilize.Web.PictureBox();
      	this.lblPOS = new Mobilize.Web.Label();
      	this.lblPOSTitle = new Mobilize.Web.Label();
      	this.lblCashier = new Mobilize.Web.Label();
      	this.lblCashierTitle = new Mobilize.Web.Label();
      	this.gbCustomerInfo.SuspendLayout();
      	this.frSubTotals.SuspendLayout();
      	this.SuspendLayout();
      	this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.CommandButtonHelper(this.components);
      	// 
      	// cbRePrint
      	// 
      	this.cbRePrint.AllowDrop = true;
      	this.cbRePrint.BackColor = System.Drawing.Color.White;
      	this.cbRePrint.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbRePrint.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbRePrint.Location = new System.Drawing.Point(800, 384);
         this.cbRePrint.Name = "cbRePrint";
         this.cbRePrint.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbRePrint.Size = new System.Drawing.Size(185, 114);
         this.cbRePrint.TabIndex = 7;
         this.cbRePrint.Text = "PRINT LAST TICKET";
         this.cbRePrint.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbRePrint.UseVisualStyleBackColor = false;
         this.cbRePrint.Click += new System.EventHandler(this.cbRePrint_Click);
         // 
         // ucNumericKeyPad
         // 
         this.ucNumericKeyPad.AllowDrop = true;
         this.ucNumericKeyPad.Location = new System.Drawing.Point(8, 464);
         this.ucNumericKeyPad.Name = "ucNumericKeyPad";
         this.ucNumericKeyPad.Size = new System.Drawing.Size(337, 417);
         this.ucNumericKeyPad.TabIndex = 9;
         this.ucNumericKeyPad.OnEnterEvent += new ucNumbersPad.OnEnterEventHandler(this.ucNumericKeyPad_OnEnterEvent);
         // 
         // cbQuantity
         // 
         this.cbQuantity.AllowDrop = true;
         this.cbQuantity.BackColor = System.Drawing.Color.White;
         this.cbQuantity.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbQuantity.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbQuantity.Location = new System.Drawing.Point(800, 264);
         this.cbQuantity.Name = "cbQuantity";
         this.cbQuantity.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbQuantity.Size = new System.Drawing.Size(185, 114);
         this.cbQuantity.TabIndex = 5;
         this.cbQuantity.Text = "CHANGE QUANTITY";
         this.cbQuantity.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbQuantity.UseVisualStyleBackColor = false;
         this.cbQuantity.Click += new System.EventHandler(this.cbQuantity_Click);
         // 
         // fgItems
         // 
         this.fgItems.AllowDrop = true;
         this.fgItems.AllowUserToAddRows = false;
         this.fgItems.AllowUserToDeleteRows = false;
         this.fgItems.Properties().AllowUserToResizeColumns = false;
         this.fgItems.Properties().AllowUserToResizeRows = false;
         this.fgItems.Properties().BackgroundColor = System.Drawing.Color.White;
         this.fgItems.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.fgItems.ColumnsCount = 6;
         this.fgItems.FixedColumns = 0;
         this.fgItems.Properties().FocusRect = Stub._UpgradeHelpers.FocusRectSettings.FocusNone;
         this.fgItems.Font = new Mobilize.Web.Font("Arial", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.fgItems.Location = new System.Drawing.Point(8, 8);
         this.fgItems.Name = "fgItems";
         this.fgItems.Properties().ReadOnly = true;
         this.fgItems.RowsCount = 1;
         this.fgItems.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.FullRowSelect;
         this.fgItems.Size = new System.Drawing.Size(777, 449);
         this.fgItems.Properties().StandardTab = true;
         this.fgItems.TabIndex = 0;
         // 
         // gbCustomerInfo
         // 
         this.gbCustomerInfo.AllowDrop = true;
         this.gbCustomerInfo.BackColor = System.Drawing.Color.White;
         this.gbCustomerInfo.Controls.Add(this.lblCustomerInfo);
         this.gbCustomerInfo.Enabled = true;
         this.gbCustomerInfo.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.gbCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.gbCustomerInfo.Location = new System.Drawing.Point(800, 136);
         this.gbCustomerInfo.Name = "gbCustomerInfo";
         this.gbCustomerInfo.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.gbCustomerInfo.Size = new System.Drawing.Size(393, 114);
         this.gbCustomerInfo.TabIndex = 3;
         this.gbCustomerInfo.Text = "Customer Info";
         this.gbCustomerInfo.Visible = true;
         // 
         // lblCustomerInfo
         // 
         this.lblCustomerInfo.AllowDrop = true;
         this.lblCustomerInfo.BackColor = System.Drawing.Color.White;
         this.lblCustomerInfo.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCustomerInfo.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblCustomerInfo.Location = new System.Drawing.Point(24, 40);
         this.lblCustomerInfo.Name = "lblCustomerInfo";
         this.lblCustomerInfo.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblCustomerInfo.Size = new System.Drawing.Size(337, 49);
         this.lblCustomerInfo.TabIndex = 4;
         // 
         // cbBreak
         // 
         this.cbBreak.AllowDrop = true;
         this.cbBreak.BackColor = System.Drawing.Color.White;
         this.cbBreak.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbBreak.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbBreak.Location = new System.Drawing.Point(800, 504);
         this.cbBreak.Name = "cbBreak";
         this.cbBreak.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbBreak.Size = new System.Drawing.Size(185, 114);
         this.cbBreak.TabIndex = 17;
         this.cbBreak.Text = "PAUSE";
         this.cbBreak.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbBreak.UseVisualStyleBackColor = false;
         this.cbBreak.Click += new System.EventHandler(this.cbBreak_Click);
         // 
         // cbLogOff
         // 
         this.cbLogOff.AllowDrop = true;
         this.cbLogOff.BackColor = System.Drawing.Color.White;
         this.cbLogOff.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbLogOff.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbLogOff.Location = new System.Drawing.Point(1008, 504);
         this.cbLogOff.Name = "cbLogOff";
         this.cbLogOff.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbLogOff.Size = new System.Drawing.Size(185, 114);
         this.cbLogOff.TabIndex = 18;
         this.cbLogOff.Text = "LOG OFF";
         this.cbLogOff.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbLogOff.UseVisualStyleBackColor = false;
         this.cbLogOff.Click += new System.EventHandler(this.cbLogOff_Click);
         // 
         // cbVoidTransaction
         // 
         this.cbVoidTransaction.AllowDrop = true;
         this.cbVoidTransaction.BackColor = System.Drawing.Color.White;
         this.cbVoidTransaction.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbVoidTransaction.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbVoidTransaction.Location = new System.Drawing.Point(1008, 384);
         this.cbVoidTransaction.Name = "cbVoidTransaction";
         this.cbVoidTransaction.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbVoidTransaction.Size = new System.Drawing.Size(185, 114);
         this.cbVoidTransaction.TabIndex = 8;
         this.cbVoidTransaction.Text = "VOID TRANSACTION";
         this.cbVoidTransaction.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbVoidTransaction.UseVisualStyleBackColor = false;
         this.cbVoidTransaction.Click += new System.EventHandler(this.cbVoidTransaction_Click);
         // 
         // cbVoidItem
         // 
         this.cbVoidItem.AllowDrop = true;
         this.cbVoidItem.BackColor = System.Drawing.Color.White;
         this.cbVoidItem.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbVoidItem.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbVoidItem.Location = new System.Drawing.Point(1008, 264);
         this.cbVoidItem.Name = "cbVoidItem";
         this.cbVoidItem.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbVoidItem.Size = new System.Drawing.Size(185, 114);
         this.cbVoidItem.TabIndex = 6;
         this.cbVoidItem.Text = "VOID ITEM";
         this.cbVoidItem.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbVoidItem.UseVisualStyleBackColor = false;
         this.cbVoidItem.Click += new System.EventHandler(this.cbVoidItem_Click);
         // 
         // cbAddCustomer
         // 
         this.cbAddCustomer.AllowDrop = true;
         this.cbAddCustomer.BackColor = System.Drawing.Color.White;
         this.cbAddCustomer.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbAddCustomer.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbAddCustomer.Location = new System.Drawing.Point(800, 8);
         this.cbAddCustomer.Name = "cbAddCustomer";
         this.cbAddCustomer.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbAddCustomer.Size = new System.Drawing.Size(185, 114);
         this.cbAddCustomer.TabIndex = 1;
         this.cbAddCustomer.Text = "ADD CUSTOMER";
         this.cbAddCustomer.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbAddCustomer.UseVisualStyleBackColor = false;
         this.cbAddCustomer.Click += new System.EventHandler(this.cbAddCustomer_Click);
         // 
         // cbCustomerSearch
         // 
         this.cbCustomerSearch.AllowDrop = true;
         this.cbCustomerSearch.BackColor = System.Drawing.Color.White;
         this.cbCustomerSearch.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbCustomerSearch.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbCustomerSearch.Location = new System.Drawing.Point(1008, 8);
         this.cbCustomerSearch.Name = "cbCustomerSearch";
         this.cbCustomerSearch.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbCustomerSearch.Size = new System.Drawing.Size(185, 114);
         this.cbCustomerSearch.TabIndex = 2;
         this.cbCustomerSearch.Text = "CUSTOMER SEARCH";
         this.cbCustomerSearch.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbCustomerSearch.UseVisualStyleBackColor = false;
         this.cbCustomerSearch.Click += new System.EventHandler(this.cbCustomerSearch_Click);
         // 
         // cbPayment
         // 
         this.cbPayment.AllowDrop = true;
         this.cbPayment.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
         this.cbPayment.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbPayment.Location = new System.Drawing.Point(360, 688);
         this.cbPayment.Name = "cbPayment";
         this.cbPayment.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbPayment.Size = new System.Drawing.Size(353, 73);
         this.cbPayment.TabIndex = 21;
         this.cbPayment.Text = "PAY";
         this.cbPayment.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbPayment.UseVisualStyleBackColor = false;
         this.cbPayment.Click += new System.EventHandler(this.cbPayment_Click);
         // 
         // frSubTotals
         // 
         this.frSubTotals.AllowDrop = true;
         this.frSubTotals.BackColor = System.Drawing.Color.White;
         this.frSubTotals.Controls.Add(this.lblTotal);
         this.frSubTotals.Controls.Add(this.lblTax);
         this.frSubTotals.Controls.Add(this.lblSubTotal);
         this.frSubTotals.Controls.Add(this.lblTotalTitle);
         this.frSubTotals.Controls.Add(this.lblTaxTitle);
         this.frSubTotals.Controls.Add(this.lblSubTotalTitle);
         this.frSubTotals.Enabled = true;
         this.frSubTotals.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.frSubTotals.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.frSubTotals.Location = new System.Drawing.Point(360, 464);
         this.frSubTotals.Name = "frSubTotals";
         this.frSubTotals.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.frSubTotals.Size = new System.Drawing.Size(353, 217);
         this.frSubTotals.TabIndex = 10;
         this.frSubTotals.Visible = true;
         // 
         // lblTotal
         // 
         this.lblTotal.AllowDrop = true;
         this.lblTotal.BackColor = System.Drawing.Color.White;
         this.lblTotal.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTotal.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTotal.Location = new System.Drawing.Point(168, 128);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblTotal.Size = new System.Drawing.Size(129, 33);
         this.lblTotal.TabIndex = 16;
         this.lblTotal.Text = "0.00";
         this.lblTotal.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblTax
         // 
         this.lblTax.AllowDrop = true;
         this.lblTax.BackColor = System.Drawing.Color.White;
         this.lblTax.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTax.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTax.Location = new System.Drawing.Point(168, 80);
         this.lblTax.Name = "lblTax";
         this.lblTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblTax.Size = new System.Drawing.Size(129, 33);
         this.lblTax.TabIndex = 14;
         this.lblTax.Text = "0.00";
         this.lblTax.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblSubTotal
         // 
         this.lblSubTotal.AllowDrop = true;
         this.lblSubTotal.BackColor = System.Drawing.Color.White;
         this.lblSubTotal.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblSubTotal.Location = new System.Drawing.Point(168, 32);
         this.lblSubTotal.Name = "lblSubTotal";
         this.lblSubTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblSubTotal.Size = new System.Drawing.Size(129, 33);
         this.lblSubTotal.TabIndex = 12;
         this.lblSubTotal.Text = "0.00";
         this.lblSubTotal.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblTotalTitle
         // 
         this.lblTotalTitle.AllowDrop = true;
         this.lblTotalTitle.BackColor = System.Drawing.Color.White;
         this.lblTotalTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTotalTitle.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTotalTitle.Location = new System.Drawing.Point(16, 128);
         this.lblTotalTitle.Name = "lblTotalTitle";
         this.lblTotalTitle.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblTotalTitle.Size = new System.Drawing.Size(97, 41);
         this.lblTotalTitle.TabIndex = 15;
         this.lblTotalTitle.Text = "Total:";
         // 
         // lblTaxTitle
         // 
         this.lblTaxTitle.AllowDrop = true;
         this.lblTaxTitle.BackColor = System.Drawing.Color.White;
         this.lblTaxTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTaxTitle.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblTaxTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblTaxTitle.Location = new System.Drawing.Point(16, 80);
         this.lblTaxTitle.Name = "lblTaxTitle";
         this.lblTaxTitle.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblTaxTitle.Size = new System.Drawing.Size(81, 41);
         this.lblTaxTitle.TabIndex = 13;
         this.lblTaxTitle.Text = "Tax:";
         // 
         // lblSubTotalTitle
         // 
         this.lblSubTotalTitle.AllowDrop = true;
         this.lblSubTotalTitle.BackColor = System.Drawing.Color.White;
         this.lblSubTotalTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblSubTotalTitle.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblSubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblSubTotalTitle.Location = new System.Drawing.Point(16, 32);
         this.lblSubTotalTitle.Name = "lblSubTotalTitle";
         this.lblSubTotalTitle.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblSubTotalTitle.Size = new System.Drawing.Size(129, 33);
         this.lblSubTotalTitle.TabIndex = 11;
         this.lblSubTotalTitle.Text = "SubTotal:";
         // 
         // picLogo
         // 
         this.picLogo.AllowDrop = true;
         this.picLogo.BackColor = Mobilize.Web.SystemColors.Window;
         this.picLogo.BorderStyle = Mobilize.Web.BorderStyle.FixedSingle;
         this.picLogo.Properties().CausesValidation = true;
         this.picLogo.Properties().Dock = Mobilize.Web.DockStyle.None;
         this.picLogo.Enabled = true;
         this.picLogo.Font = new Mobilize.Web.Font("Arial", 12f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.picLogo.Image = "assets/images/TailwindPOS.frmSales.picLogo.Image.png";
         this.picLogo.Location = new System.Drawing.Point(960, 696);
         this.picLogo.Name = "picLogo";
         this.picLogo.Size = new System.Drawing.Size(230, 206);
         this.picLogo.SizeMode = Mobilize.Web.PictureBoxSizeMode.AutoSize;
         this.picLogo.Properties().TabIndex = 24;
         this.picLogo.Properties().TabStop = true;
         this.picLogo.Visible = true;
         // 
         // lblPOS
         // 
         this.lblPOS.AllowDrop = true;
         this.lblPOS.BackColor = System.Drawing.Color.White;
         this.lblPOS.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPOS.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblPOS.Location = new System.Drawing.Point(752, 768);
         this.lblPOS.Name = "lblPOS";
         this.lblPOS.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblPOS.Size = new System.Drawing.Size(153, 49);
         this.lblPOS.TabIndex = 23;
         this.lblPOS.Text = "POSName";
         // 
         // lblPOSTitle
         // 
         this.lblPOSTitle.AllowDrop = true;
         this.lblPOSTitle.BackColor = System.Drawing.Color.White;
         this.lblPOSTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPOSTitle.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblPOSTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblPOSTitle.Location = new System.Drawing.Point(752, 704);
         this.lblPOSTitle.Name = "lblPOSTitle";
         this.lblPOSTitle.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblPOSTitle.Size = new System.Drawing.Size(105, 57);
         this.lblPOSTitle.TabIndex = 22;
         this.lblPOSTitle.Text = "POS:";
         // 
         // lblCashier
         // 
         this.lblCashier.AllowDrop = true;
         this.lblCashier.BackColor = System.Drawing.Color.White;
         this.lblCashier.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCashier.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblCashier.Location = new System.Drawing.Point(960, 632);
         this.lblCashier.Name = "lblCashier";
         this.lblCashier.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblCashier.Size = new System.Drawing.Size(185, 57);
         this.lblCashier.TabIndex = 20;
         this.lblCashier.Text = "CashierID";
         // 
         // lblCashierTitle
         // 
         this.lblCashierTitle.AllowDrop = true;
         this.lblCashierTitle.BackColor = System.Drawing.Color.White;
         this.lblCashierTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCashierTitle.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblCashierTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblCashierTitle.Location = new System.Drawing.Point(752, 632);
         this.lblCashierTitle.Name = "lblCashierTitle";
         this.lblCashierTitle.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblCashierTitle.Size = new System.Drawing.Size(145, 49);
         this.lblCashierTitle.TabIndex = 19;
         this.lblCashierTitle.Text = "Cashier:";
         // 
         // frmSales
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Properties().ClientSize = new System.Drawing.Size(1202, 909);
         this.ControlBox = false;
         this.Controls.Add(this.cbRePrint);
         this.Controls.Add(this.ucNumericKeyPad);
         this.Controls.Add(this.cbQuantity);
         this.Controls.Add(this.fgItems);
         this.Controls.Add(this.gbCustomerInfo);
         this.Controls.Add(this.cbBreak);
         this.Controls.Add(this.cbLogOff);
         this.Controls.Add(this.cbVoidTransaction);
         this.Controls.Add(this.cbVoidItem);
         this.Controls.Add(this.cbAddCustomer);
         this.Controls.Add(this.cbCustomerSearch);
         this.Controls.Add(this.cbPayment);
         this.Controls.Add(this.frSubTotals);
         this.Controls.Add(this.picLogo);
         this.Controls.Add(this.lblPOS);
         this.Controls.Add(this.lblPOSTitle);
         this.Controls.Add(this.lblCashier);
         this.Controls.Add(this.lblCashierTitle);
         this.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.Properties().Location = new System.Drawing.Point(3, 26);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmSales";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Sales";
         commandButtonHelper1.SetStyle(this.cbRePrint, 1);
         commandButtonHelper1.SetStyle(this.cbQuantity, 1);
         commandButtonHelper1.SetStyle(this.cbBreak, 1);
         commandButtonHelper1.SetStyle(this.cbLogOff, 1);
         commandButtonHelper1.SetStyle(this.cbVoidTransaction, 1);
         commandButtonHelper1.SetStyle(this.cbVoidItem, 1);
         commandButtonHelper1.SetStyle(this.cbAddCustomer, 1);
         commandButtonHelper1.SetStyle(this.cbCustomerSearch, 1);
         commandButtonHelper1.SetStyle(this.cbPayment, 1);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.gbCustomerInfo.ResumeLayout(false);
         this.frSubTotals.ResumeLayout(false);
         this.ResumeLayout(false);
      }
      #endregion

   }
}