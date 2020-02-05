
namespace TailwindPOS
{
	partial class frmSales
	{

		#region "Upgrade Support "
		private static frmSales m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbRePrint", "ucNumericKeyPad", "cbQuantity", "fgItems", "lblCustomerInfo", "gbCustomerInfo", "cbBreak", "cbLogOff", "cbVoidTransaction", "cbVoidItem", "cbAddCustomer", "cbCustomerSearch", "cbPayment", "lblTotal", "lblTax", "lblSubTotal", "lblTotalTitle", "lblTaxTitle", "lblSubTotalTitle", "frSubTotals", "picLogo", "lblPOS", "lblPOSTitle", "lblCashier", "lblCashierTitle", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbRePrint;
		public ucNumbersPad ucNumericKeyPad;
		public System.Windows.Forms.Button cbQuantity;
		public UpgradeHelpers.DataGridViewFlex fgItems;
		public System.Windows.Forms.Label lblCustomerInfo;
		public System.Windows.Forms.GroupBox gbCustomerInfo;
		public System.Windows.Forms.Button cbBreak;
		public System.Windows.Forms.Button cbLogOff;
		public System.Windows.Forms.Button cbVoidTransaction;
		public System.Windows.Forms.Button cbVoidItem;
		public System.Windows.Forms.Button cbAddCustomer;
		public System.Windows.Forms.Button cbCustomerSearch;
		public System.Windows.Forms.Button cbPayment;
		public System.Windows.Forms.Label lblTotal;
		public System.Windows.Forms.Label lblTax;
		public System.Windows.Forms.Label lblSubTotal;
		public System.Windows.Forms.Label lblTotalTitle;
		public System.Windows.Forms.Label lblTaxTitle;
		public System.Windows.Forms.Label lblSubTotalTitle;
		public System.Windows.Forms.GroupBox frSubTotals;
		public System.Windows.Forms.PictureBox picLogo;
		public System.Windows.Forms.Label lblPOS;
		public System.Windows.Forms.Label lblPOSTitle;
		public System.Windows.Forms.Label lblCashier;
		public System.Windows.Forms.Label lblCashierTitle;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cbRePrint = new System.Windows.Forms.Button();
			this.ucNumericKeyPad = new ucNumbersPad();
			this.cbQuantity = new System.Windows.Forms.Button();
			this.fgItems = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
			this.lblCustomerInfo = new System.Windows.Forms.Label();
			this.cbBreak = new System.Windows.Forms.Button();
			this.cbLogOff = new System.Windows.Forms.Button();
			this.cbVoidTransaction = new System.Windows.Forms.Button();
			this.cbVoidItem = new System.Windows.Forms.Button();
			this.cbAddCustomer = new System.Windows.Forms.Button();
			this.cbCustomerSearch = new System.Windows.Forms.Button();
			this.cbPayment = new System.Windows.Forms.Button();
			this.frSubTotals = new System.Windows.Forms.GroupBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblTax = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblTotalTitle = new System.Windows.Forms.Label();
			this.lblTaxTitle = new System.Windows.Forms.Label();
			this.lblSubTotalTitle = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.lblPOS = new System.Windows.Forms.Label();
			this.lblPOSTitle = new System.Windows.Forms.Label();
			this.lblCashier = new System.Windows.Forms.Label();
			this.lblCashierTitle = new System.Windows.Forms.Label();
			this.gbCustomerInfo.SuspendLayout();
			this.frSubTotals.SuspendLayout();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// cbRePrint
			// 
			this.cbRePrint.AllowDrop = true;
			this.cbRePrint.BackColor = System.Drawing.Color.White;
			this.cbRePrint.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbRePrint.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbRePrint.Location = new System.Drawing.Point(800, 384);
			this.cbRePrint.Name = "cbRePrint";
			this.cbRePrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbRePrint.Size = new System.Drawing.Size(185, 114);
			this.cbRePrint.TabIndex = 7;
			this.cbRePrint.Text = "PRINT LAST TICKET";
			this.cbRePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
			this.cbQuantity.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbQuantity.Location = new System.Drawing.Point(800, 264);
			this.cbQuantity.Name = "cbQuantity";
			this.cbQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbQuantity.Size = new System.Drawing.Size(185, 114);
			this.cbQuantity.TabIndex = 5;
			this.cbQuantity.Text = "CHANGE QUANTITY";
			this.cbQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbQuantity.UseVisualStyleBackColor = false;
			this.cbQuantity.Click += new System.EventHandler(this.cbQuantity_Click);
			// 
			// fgItems
			// 
			this.fgItems.AllowDrop = true;
			this.fgItems.AllowUserToAddRows = false;
			this.fgItems.AllowUserToDeleteRows = false;
			this.fgItems.AllowUserToResizeColumns = false;
			this.fgItems.AllowUserToResizeRows = false;
			this.fgItems.BackgroundColor = System.Drawing.Color.White;
			this.fgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fgItems.ColumnsCount = 6;
			this.fgItems.FixedColumns = 0;
			this.fgItems.FocusRect = UpgradeHelpers.FocusRectSettings.FocusNone;
			this.fgItems.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fgItems.Location = new System.Drawing.Point(8, 8);
			this.fgItems.Name = "fgItems";
			this.fgItems.ReadOnly = true;
			this.fgItems.RowsCount = 1;
			this.fgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.fgItems.Size = new System.Drawing.Size(777, 449);
			this.fgItems.StandardTab = true;
			this.fgItems.TabIndex = 0;
			// 
			// gbCustomerInfo
			// 
			this.gbCustomerInfo.AllowDrop = true;
			this.gbCustomerInfo.BackColor = System.Drawing.Color.White;
			this.gbCustomerInfo.Controls.Add(this.lblCustomerInfo);
			this.gbCustomerInfo.Enabled = true;
			this.gbCustomerInfo.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.gbCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.gbCustomerInfo.Location = new System.Drawing.Point(800, 136);
			this.gbCustomerInfo.Name = "gbCustomerInfo";
			this.gbCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbCustomerInfo.Size = new System.Drawing.Size(393, 114);
			this.gbCustomerInfo.TabIndex = 3;
			this.gbCustomerInfo.Text = "Customer Info";
			this.gbCustomerInfo.Visible = true;
			// 
			// lblCustomerInfo
			// 
			this.lblCustomerInfo.AllowDrop = true;
			this.lblCustomerInfo.BackColor = System.Drawing.Color.White;
			this.lblCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCustomerInfo.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblCustomerInfo.Location = new System.Drawing.Point(24, 40);
			this.lblCustomerInfo.Name = "lblCustomerInfo";
			this.lblCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCustomerInfo.Size = new System.Drawing.Size(337, 49);
			this.lblCustomerInfo.TabIndex = 4;
			// 
			// cbBreak
			// 
			this.cbBreak.AllowDrop = true;
			this.cbBreak.BackColor = System.Drawing.Color.White;
			this.cbBreak.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbBreak.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbBreak.Location = new System.Drawing.Point(800, 504);
			this.cbBreak.Name = "cbBreak";
			this.cbBreak.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbBreak.Size = new System.Drawing.Size(185, 114);
			this.cbBreak.TabIndex = 17;
			this.cbBreak.Text = "PAUSE";
			this.cbBreak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbBreak.UseVisualStyleBackColor = false;
			this.cbBreak.Click += new System.EventHandler(this.cbBreak_Click);
			// 
			// cbLogOff
			// 
			this.cbLogOff.AllowDrop = true;
			this.cbLogOff.BackColor = System.Drawing.Color.White;
			this.cbLogOff.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbLogOff.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbLogOff.Location = new System.Drawing.Point(1008, 504);
			this.cbLogOff.Name = "cbLogOff";
			this.cbLogOff.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbLogOff.Size = new System.Drawing.Size(185, 114);
			this.cbLogOff.TabIndex = 18;
			this.cbLogOff.Text = "LOG OFF";
			this.cbLogOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbLogOff.UseVisualStyleBackColor = false;
			this.cbLogOff.Click += new System.EventHandler(this.cbLogOff_Click);
			// 
			// cbVoidTransaction
			// 
			this.cbVoidTransaction.AllowDrop = true;
			this.cbVoidTransaction.BackColor = System.Drawing.Color.White;
			this.cbVoidTransaction.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbVoidTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbVoidTransaction.Location = new System.Drawing.Point(1008, 384);
			this.cbVoidTransaction.Name = "cbVoidTransaction";
			this.cbVoidTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbVoidTransaction.Size = new System.Drawing.Size(185, 114);
			this.cbVoidTransaction.TabIndex = 8;
			this.cbVoidTransaction.Text = "VOID TRANSACTION";
			this.cbVoidTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbVoidTransaction.UseVisualStyleBackColor = false;
			this.cbVoidTransaction.Click += new System.EventHandler(this.cbVoidTransaction_Click);
			// 
			// cbVoidItem
			// 
			this.cbVoidItem.AllowDrop = true;
			this.cbVoidItem.BackColor = System.Drawing.Color.White;
			this.cbVoidItem.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbVoidItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbVoidItem.Location = new System.Drawing.Point(1008, 264);
			this.cbVoidItem.Name = "cbVoidItem";
			this.cbVoidItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbVoidItem.Size = new System.Drawing.Size(185, 114);
			this.cbVoidItem.TabIndex = 6;
			this.cbVoidItem.Text = "VOID ITEM";
			this.cbVoidItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbVoidItem.UseVisualStyleBackColor = false;
			this.cbVoidItem.Click += new System.EventHandler(this.cbVoidItem_Click);
			// 
			// cbAddCustomer
			// 
			this.cbAddCustomer.AllowDrop = true;
			this.cbAddCustomer.BackColor = System.Drawing.Color.White;
			this.cbAddCustomer.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbAddCustomer.Location = new System.Drawing.Point(800, 8);
			this.cbAddCustomer.Name = "cbAddCustomer";
			this.cbAddCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbAddCustomer.Size = new System.Drawing.Size(185, 114);
			this.cbAddCustomer.TabIndex = 1;
			this.cbAddCustomer.Text = "ADD CUSTOMER";
			this.cbAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbAddCustomer.UseVisualStyleBackColor = false;
			this.cbAddCustomer.Click += new System.EventHandler(this.cbAddCustomer_Click);
			// 
			// cbCustomerSearch
			// 
			this.cbCustomerSearch.AllowDrop = true;
			this.cbCustomerSearch.BackColor = System.Drawing.Color.White;
			this.cbCustomerSearch.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbCustomerSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbCustomerSearch.Location = new System.Drawing.Point(1008, 8);
			this.cbCustomerSearch.Name = "cbCustomerSearch";
			this.cbCustomerSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbCustomerSearch.Size = new System.Drawing.Size(185, 114);
			this.cbCustomerSearch.TabIndex = 2;
			this.cbCustomerSearch.Text = "CUSTOMER SEARCH";
			this.cbCustomerSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbCustomerSearch.UseVisualStyleBackColor = false;
			this.cbCustomerSearch.Click += new System.EventHandler(this.cbCustomerSearch_Click);
			// 
			// cbPayment
			// 
			this.cbPayment.AllowDrop = true;
			this.cbPayment.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
			this.cbPayment.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbPayment.Location = new System.Drawing.Point(360, 688);
			this.cbPayment.Name = "cbPayment";
			this.cbPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbPayment.Size = new System.Drawing.Size(353, 73);
			this.cbPayment.TabIndex = 21;
			this.cbPayment.Text = "PAY";
			this.cbPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
			this.frSubTotals.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.frSubTotals.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.frSubTotals.Location = new System.Drawing.Point(360, 464);
			this.frSubTotals.Name = "frSubTotals";
			this.frSubTotals.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frSubTotals.Size = new System.Drawing.Size(353, 217);
			this.frSubTotals.TabIndex = 10;
			this.frSubTotals.Visible = true;
			// 
			// lblTotal
			// 
			this.lblTotal.AllowDrop = true;
			this.lblTotal.BackColor = System.Drawing.Color.White;
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTotal.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTotal.Location = new System.Drawing.Point(168, 128);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTotal.Size = new System.Drawing.Size(129, 33);
			this.lblTotal.TabIndex = 16;
			this.lblTotal.Text = "0.00";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTax
			// 
			this.lblTax.AllowDrop = true;
			this.lblTax.BackColor = System.Drawing.Color.White;
			this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTax.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTax.Location = new System.Drawing.Point(168, 80);
			this.lblTax.Name = "lblTax";
			this.lblTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTax.Size = new System.Drawing.Size(129, 33);
			this.lblTax.TabIndex = 14;
			this.lblTax.Text = "0.00";
			this.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AllowDrop = true;
			this.lblSubTotal.BackColor = System.Drawing.Color.White;
			this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblSubTotal.Location = new System.Drawing.Point(168, 32);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSubTotal.Size = new System.Drawing.Size(129, 33);
			this.lblSubTotal.TabIndex = 12;
			this.lblSubTotal.Text = "0.00";
			this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTotalTitle
			// 
			this.lblTotalTitle.AllowDrop = true;
			this.lblTotalTitle.BackColor = System.Drawing.Color.White;
			this.lblTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTotalTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTotalTitle.Location = new System.Drawing.Point(16, 128);
			this.lblTotalTitle.Name = "lblTotalTitle";
			this.lblTotalTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTotalTitle.Size = new System.Drawing.Size(97, 41);
			this.lblTotalTitle.TabIndex = 15;
			this.lblTotalTitle.Text = "Total:";
			// 
			// lblTaxTitle
			// 
			this.lblTaxTitle.AllowDrop = true;
			this.lblTaxTitle.BackColor = System.Drawing.Color.White;
			this.lblTaxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTaxTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTaxTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblTaxTitle.Location = new System.Drawing.Point(16, 80);
			this.lblTaxTitle.Name = "lblTaxTitle";
			this.lblTaxTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTaxTitle.Size = new System.Drawing.Size(81, 41);
			this.lblTaxTitle.TabIndex = 13;
			this.lblTaxTitle.Text = "Tax:";
			// 
			// lblSubTotalTitle
			// 
			this.lblSubTotalTitle.AllowDrop = true;
			this.lblSubTotalTitle.BackColor = System.Drawing.Color.White;
			this.lblSubTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblSubTotalTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblSubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblSubTotalTitle.Location = new System.Drawing.Point(16, 32);
			this.lblSubTotalTitle.Name = "lblSubTotalTitle";
			this.lblSubTotalTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSubTotalTitle.Size = new System.Drawing.Size(129, 33);
			this.lblSubTotalTitle.TabIndex = 11;
			this.lblSubTotalTitle.Text = "SubTotal:";
			// 
			// picLogo
			// 
			this.picLogo.AllowDrop = true;
			this.picLogo.BackColor = System.Drawing.SystemColors.Window;
			this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLogo.CausesValidation = true;
			this.picLogo.Dock = System.Windows.Forms.DockStyle.None;
			this.picLogo.Enabled = true;
			this.picLogo.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.picLogo.Image = (System.Drawing.Image) resources.GetObject("picLogo.Image");
			this.picLogo.Location = new System.Drawing.Point(960, 696);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(230, 206);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picLogo.TabIndex = 24;
			this.picLogo.TabStop = true;
			this.picLogo.Visible = true;
			// 
			// lblPOS
			// 
			this.lblPOS.AllowDrop = true;
			this.lblPOS.BackColor = System.Drawing.Color.White;
			this.lblPOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPOS.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblPOS.Location = new System.Drawing.Point(752, 768);
			this.lblPOS.Name = "lblPOS";
			this.lblPOS.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPOS.Size = new System.Drawing.Size(153, 49);
			this.lblPOS.TabIndex = 23;
			this.lblPOS.Text = "POSName";
			// 
			// lblPOSTitle
			// 
			this.lblPOSTitle.AllowDrop = true;
			this.lblPOSTitle.BackColor = System.Drawing.Color.White;
			this.lblPOSTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPOSTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblPOSTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblPOSTitle.Location = new System.Drawing.Point(752, 704);
			this.lblPOSTitle.Name = "lblPOSTitle";
			this.lblPOSTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPOSTitle.Size = new System.Drawing.Size(105, 57);
			this.lblPOSTitle.TabIndex = 22;
			this.lblPOSTitle.Text = "POS:";
			// 
			// lblCashier
			// 
			this.lblCashier.AllowDrop = true;
			this.lblCashier.BackColor = System.Drawing.Color.White;
			this.lblCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCashier.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblCashier.Location = new System.Drawing.Point(960, 632);
			this.lblCashier.Name = "lblCashier";
			this.lblCashier.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCashier.Size = new System.Drawing.Size(185, 57);
			this.lblCashier.TabIndex = 20;
			this.lblCashier.Text = "CashierID";
			// 
			// lblCashierTitle
			// 
			this.lblCashierTitle.AllowDrop = true;
			this.lblCashierTitle.BackColor = System.Drawing.Color.White;
			this.lblCashierTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCashierTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCashierTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblCashierTitle.Location = new System.Drawing.Point(752, 632);
			this.lblCashierTitle.Name = "lblCashierTitle";
			this.lblCashierTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCashierTitle.Size = new System.Drawing.Size(145, 49);
			this.lblCashierTitle.TabIndex = 19;
			this.lblCashierTitle.Text = "Cashier:";
			// 
			// frmSales
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1202, 909);
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
			this.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSales";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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