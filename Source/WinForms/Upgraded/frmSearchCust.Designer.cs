
namespace TailwindPOS
{
	partial class frmSearchCust
	{

		#region "Upgrade Support "
		private static frmSearchCust m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSearchCust DefInstance
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
		public static frmSearchCust CreateInstance()
		{
			frmSearchCust theInstance = new frmSearchCust();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "ucLettersPad", "cbClose", "fgCustomers", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public ucLettersPad ucLettersPad;
		public System.Windows.Forms.Button cbClose;
		public UpgradeHelpers.DataGridViewFlex fgCustomers;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCust));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.ucLettersPad = new ucLettersPad();
			this.cbClose = new System.Windows.Forms.Button();
			this.fgCustomers = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// ucLettersPad
			// 
			this.ucLettersPad.AllowDrop = true;
			this.ucLettersPad.Location = new System.Drawing.Point(8, 24);
			this.ucLettersPad.Name = "ucLettersPad";
			this.ucLettersPad.Size = new System.Drawing.Size(633, 569);
			this.ucLettersPad.TabIndex = 0;
			this.ucLettersPad.OnEnterEvent += new ucLettersPad.OnEnterEventHandler(this.ucLettersPad_OnEnterEvent);
			// 
			// cbClose
			// 
			this.cbClose.AllowDrop = true;
			this.cbClose.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			this.cbClose.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbClose.Location = new System.Drawing.Point(1248, 640);
			this.cbClose.Name = "cbClose";
			this.cbClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbClose.Size = new System.Drawing.Size(241, 57);
			this.cbClose.TabIndex = 2;
			this.cbClose.Text = "Close";
			this.cbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbClose.UseVisualStyleBackColor = false;
			this.cbClose.Click += new System.EventHandler(this.cbClose_Click);
			// 
			// fgCustomers
			// 
			this.fgCustomers.AllowDrop = true;
			this.fgCustomers.AllowUserToAddRows = false;
			this.fgCustomers.AllowUserToDeleteRows = false;
			this.fgCustomers.AllowUserToResizeColumns = false;
			this.fgCustomers.AllowUserToResizeRows = false;
			this.fgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fgCustomers.ColumnsCount = 5;
			this.fgCustomers.FixedColumns = 0;
			this.fgCustomers.FocusRect = UpgradeHelpers.FocusRectSettings.FocusNone;
			this.fgCustomers.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fgCustomers.Location = new System.Drawing.Point(648, 24);
			this.fgCustomers.Name = "fgCustomers";
			this.fgCustomers.ReadOnly = true;
			this.fgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.fgCustomers.Size = new System.Drawing.Size(849, 577);
			this.fgCustomers.StandardTab = true;
			this.fgCustomers.TabIndex = 1;
			this.fgCustomers.DoubleClick += new System.EventHandler(this.fgCustomers_DoubleClick);
			// 
			// frmSearchCust
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1496, 737);
			this.Controls.Add(this.ucLettersPad);
			this.Controls.Add(this.cbClose);
			this.Controls.Add(this.fgCustomers);
			this.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Location = new System.Drawing.Point(11, 34);
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "frmSearchCust";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Search";
			commandButtonHelper1.SetStyle(this.cbClose, 1);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}