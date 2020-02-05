
namespace TailwindPOS
{
	partial class frmGiftCardCode
	{

		#region "Upgrade Support "
		private static frmGiftCardCode m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmGiftCardCode DefInstance
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
		public static frmGiftCardCode CreateInstance()
		{
			frmGiftCardCode theInstance = new frmGiftCardCode();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbCancel", "cbOK", "txtCode", "lblMessage", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbCancel;
		public System.Windows.Forms.Button cbOK;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.Label lblMessage;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiftCardCode));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cbCancel = new System.Windows.Forms.Button();
			this.cbOK = new System.Windows.Forms.Button();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// cbCancel
			// 
			this.cbCancel.AllowDrop = true;
			this.cbCancel.BackColor = System.Drawing.Color.White;
			this.cbCancel.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbCancel.Location = new System.Drawing.Point(360, 128);
			this.cbCancel.Name = "cbCancel";
			this.cbCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbCancel.Size = new System.Drawing.Size(265, 65);
			this.cbCancel.TabIndex = 3;
			this.cbCancel.Text = "Cancel";
			this.cbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbCancel.UseVisualStyleBackColor = false;
			this.cbCancel.Click += new System.EventHandler(this.cbCancel_Click);
			// 
			// cbOK
			// 
			this.cbOK.AllowDrop = true;
			this.cbOK.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			this.cbOK.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbOK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbOK.Location = new System.Drawing.Point(72, 128);
			this.cbOK.Name = "cbOK";
			this.cbOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbOK.Size = new System.Drawing.Size(265, 65);
			this.cbOK.TabIndex = 2;
			this.cbOK.Text = "OK";
			this.cbOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbOK.UseVisualStyleBackColor = false;
			this.cbOK.Click += new System.EventHandler(this.cbOK_Click);
			// 
			// txtCode
			// 
			this.txtCode.AcceptsReturn = true;
			this.txtCode.AllowDrop = true;
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCode.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCode.Location = new System.Drawing.Point(24, 72);
			this.txtCode.MaxLength = 0;
			this.txtCode.Name = "txtCode";
			this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCode.Size = new System.Drawing.Size(633, 49);
			this.txtCode.TabIndex = 1;
			// 
			// lblMessage
			// 
			this.lblMessage.AllowDrop = true;
			this.lblMessage.BackColor = System.Drawing.Color.White;
			this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblMessage.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.lblMessage.Location = new System.Drawing.Point(40, 24);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMessage.Size = new System.Drawing.Size(313, 41);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "Enter GIFT CARD CODE";
			// 
			// frmGiftCardCode
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(688, 213);
			this.ControlBox = false;
			this.Controls.Add(this.cbCancel);
			this.Controls.Add(this.cbOK);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.lblMessage);
			this.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(184, 250);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGiftCardCode";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.Text = "Enter Gift Card Code";
			commandButtonHelper1.SetStyle(this.cbCancel, 1);
			commandButtonHelper1.SetStyle(this.cbOK, 1);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}