
namespace TailwindPOS
{
	partial class frmPause
	{

		#region "Upgrade Support "
		private static frmPause m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmPause DefInstance
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
		public static frmPause CreateInstance()
		{
			frmPause theInstance = new frmPause();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbReturn", "lblPauseMessage", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbReturn;
		public System.Windows.Forms.Label lblPauseMessage;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPause));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cbReturn = new System.Windows.Forms.Button();
			this.lblPauseMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// cbReturn
			// 
			this.cbReturn.AllowDrop = true;
			this.cbReturn.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			this.cbReturn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbReturn.Location = new System.Drawing.Point(224, 160);
			this.cbReturn.Name = "cbReturn";
			this.cbReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbReturn.Size = new System.Drawing.Size(417, 81);
			this.cbReturn.TabIndex = 1;
			this.cbReturn.Text = "Return";
			this.cbReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbReturn.UseVisualStyleBackColor = false;
			this.cbReturn.Click += new System.EventHandler(this.cbReturn_Click);
			// 
			// lblPauseMessage
			// 
			this.lblPauseMessage.AllowDrop = true;
			this.lblPauseMessage.BackColor = System.Drawing.Color.White;
			this.lblPauseMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPauseMessage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPauseMessage.Location = new System.Drawing.Point(56, 32);
			this.lblPauseMessage.Name = "lblPauseMessage";
			this.lblPauseMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPauseMessage.Size = new System.Drawing.Size(713, 73);
			this.lblPauseMessage.TabIndex = 0;
			this.lblPauseMessage.Text = "POS Paused";
			this.lblPauseMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmPause
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(844, 334);
			this.ControlBox = false;
			this.Controls.Add(this.cbReturn);
			this.Controls.Add(this.lblPauseMessage);
			this.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPause";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tailwind Point of Sale Paused";
			commandButtonHelper1.SetStyle(this.cbReturn, 1);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}