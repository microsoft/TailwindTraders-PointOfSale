
namespace TailwindPOS
{
	partial class frmCustAdd
	{

		#region "Upgrade Support "
		private static frmCustAdd m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCustAdd DefInstance
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
		public static frmCustAdd CreateInstance()
		{
			frmCustAdd theInstance = new frmCustAdd();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbClose", "cbSave", "txtPhone", "txtCounty", "txtZipCode", "txtState", "txtCity", "txtStreetAddress2", "txtStreetAddress1", "txtCompany", "txtEmail", "txtLastName", "txtFirstName", "lblCompany", "lblCounty", "lblCity", "lblState", "lblZipCode", "lblStreetAdress2", "lblStreetAddress1", "lblPhone", "lblEmail", "lblLastName", "lblFirstName", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbClose;
		public System.Windows.Forms.Button cbSave;
		public System.Windows.Forms.TextBox txtPhone;
		public System.Windows.Forms.TextBox txtCounty;
		public System.Windows.Forms.TextBox txtZipCode;
		public System.Windows.Forms.TextBox txtState;
		public System.Windows.Forms.TextBox txtCity;
		public System.Windows.Forms.TextBox txtStreetAddress2;
		public System.Windows.Forms.TextBox txtStreetAddress1;
		public System.Windows.Forms.TextBox txtCompany;
		public System.Windows.Forms.TextBox txtEmail;
		public System.Windows.Forms.TextBox txtLastName;
		public System.Windows.Forms.TextBox txtFirstName;
		public System.Windows.Forms.Label lblCompany;
		public System.Windows.Forms.Label lblCounty;
		public System.Windows.Forms.Label lblCity;
		public System.Windows.Forms.Label lblState;
		public System.Windows.Forms.Label lblZipCode;
		public System.Windows.Forms.Label lblStreetAdress2;
		public System.Windows.Forms.Label lblStreetAddress1;
		public System.Windows.Forms.Label lblPhone;
		public System.Windows.Forms.Label lblEmail;
		public System.Windows.Forms.Label lblLastName;
		public System.Windows.Forms.Label lblFirstName;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustAdd));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cbClose = new System.Windows.Forms.Button();
			this.cbSave = new System.Windows.Forms.Button();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtCounty = new System.Windows.Forms.TextBox();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtStreetAddress2 = new System.Windows.Forms.TextBox();
			this.txtStreetAddress1 = new System.Windows.Forms.TextBox();
			this.txtCompany = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblCompany = new System.Windows.Forms.Label();
			this.lblCounty = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.lblZipCode = new System.Windows.Forms.Label();
			this.lblStreetAdress2 = new System.Windows.Forms.Label();
			this.lblStreetAddress1 = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// cbClose
			// 
			this.cbClose.AllowDrop = true;
			this.cbClose.BackColor = System.Drawing.Color.White;
			this.cbClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbClose.Location = new System.Drawing.Point(488, 624);
			this.cbClose.Name = "cbClose";
			this.cbClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbClose.Size = new System.Drawing.Size(417, 65);
			this.cbClose.TabIndex = 23;
			this.cbClose.Text = "Close";
			this.cbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbClose.UseVisualStyleBackColor = false;
			this.cbClose.Click += new System.EventHandler(this.cbClose_Click);
			// 
			// cbSave
			// 
			this.cbSave.AllowDrop = true;
			this.cbSave.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			this.cbSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbSave.Location = new System.Drawing.Point(64, 624);
			this.cbSave.Name = "cbSave";
			this.cbSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbSave.Size = new System.Drawing.Size(401, 65);
			this.cbSave.TabIndex = 22;
			this.cbSave.Text = "Save";
			this.cbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cbSave.UseVisualStyleBackColor = false;
			this.cbSave.Click += new System.EventHandler(this.cbSave_Click);
			// 
			// txtPhone
			// 
			this.txtPhone.AcceptsReturn = true;
			this.txtPhone.AllowDrop = true;
			this.txtPhone.BackColor = System.Drawing.Color.White;
			this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPhone.Location = new System.Drawing.Point(184, 216);
			this.txtPhone.MaxLength = 0;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPhone.Size = new System.Drawing.Size(305, 65);
			this.txtPhone.TabIndex = 9;
			// 
			// txtCounty
			// 
			this.txtCounty.AcceptsReturn = true;
			this.txtCounty.AllowDrop = true;
			this.txtCounty.BackColor = System.Drawing.Color.White;
			this.txtCounty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCounty.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCounty.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCounty.Location = new System.Drawing.Point(176, 520);
			this.txtCounty.MaxLength = 0;
			this.txtCounty.Name = "txtCounty";
			this.txtCounty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCounty.Size = new System.Drawing.Size(353, 65);
			this.txtCounty.TabIndex = 21;
			// 
			// txtZipCode
			// 
			this.txtZipCode.AcceptsReturn = true;
			this.txtZipCode.AllowDrop = true;
			this.txtZipCode.BackColor = System.Drawing.Color.White;
			this.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtZipCode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtZipCode.Location = new System.Drawing.Point(856, 432);
			this.txtZipCode.MaxLength = 0;
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtZipCode.Size = new System.Drawing.Size(225, 65);
			this.txtZipCode.TabIndex = 19;
			// 
			// txtState
			// 
			this.txtState.AcceptsReturn = true;
			this.txtState.AllowDrop = true;
			this.txtState.BackColor = System.Drawing.Color.White;
			this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtState.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtState.Location = new System.Drawing.Point(120, 432);
			this.txtState.MaxLength = 0;
			this.txtState.Name = "txtState";
			this.txtState.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtState.Size = new System.Drawing.Size(209, 57);
			this.txtState.TabIndex = 15;
			// 
			// txtCity
			// 
			this.txtCity.AcceptsReturn = true;
			this.txtCity.AllowDrop = true;
			this.txtCity.BackColor = System.Drawing.Color.White;
			this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCity.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCity.Location = new System.Drawing.Point(424, 432);
			this.txtCity.MaxLength = 0;
			this.txtCity.Name = "txtCity";
			this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCity.Size = new System.Drawing.Size(289, 57);
			this.txtCity.TabIndex = 17;
			// 
			// txtStreetAddress2
			// 
			this.txtStreetAddress2.AcceptsReturn = true;
			this.txtStreetAddress2.AllowDrop = true;
			this.txtStreetAddress2.BackColor = System.Drawing.Color.White;
			this.txtStreetAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtStreetAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtStreetAddress2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtStreetAddress2.Location = new System.Drawing.Point(256, 360);
			this.txtStreetAddress2.MaxLength = 0;
			this.txtStreetAddress2.Name = "txtStreetAddress2";
			this.txtStreetAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtStreetAddress2.Size = new System.Drawing.Size(937, 57);
			this.txtStreetAddress2.TabIndex = 13;
			// 
			// txtStreetAddress1
			// 
			this.txtStreetAddress1.AcceptsReturn = true;
			this.txtStreetAddress1.AllowDrop = true;
			this.txtStreetAddress1.BackColor = System.Drawing.Color.White;
			this.txtStreetAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtStreetAddress1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtStreetAddress1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtStreetAddress1.Location = new System.Drawing.Point(256, 288);
			this.txtStreetAddress1.MaxLength = 0;
			this.txtStreetAddress1.Name = "txtStreetAddress1";
			this.txtStreetAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtStreetAddress1.Size = new System.Drawing.Size(937, 65);
			this.txtStreetAddress1.TabIndex = 11;
			// 
			// txtCompany
			// 
			this.txtCompany.AcceptsReturn = true;
			this.txtCompany.AllowDrop = true;
			this.txtCompany.BackColor = System.Drawing.Color.White;
			this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCompany.Location = new System.Drawing.Point(184, 144);
			this.txtCompany.MaxLength = 0;
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCompany.Size = new System.Drawing.Size(857, 65);
			this.txtCompany.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.AcceptsReturn = true;
			this.txtEmail.AllowDrop = true;
			this.txtEmail.BackColor = System.Drawing.Color.White;
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEmail.Location = new System.Drawing.Point(184, 80);
			this.txtEmail.MaxLength = 0;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtEmail.Size = new System.Drawing.Size(857, 57);
			this.txtEmail.TabIndex = 5;
			// 
			// txtLastName
			// 
			this.txtLastName.AcceptsReturn = true;
			this.txtLastName.AllowDrop = true;
			this.txtLastName.BackColor = System.Drawing.Color.White;
			this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtLastName.Location = new System.Drawing.Point(728, 16);
			this.txtLastName.MaxLength = 0;
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtLastName.Size = new System.Drawing.Size(361, 57);
			this.txtLastName.TabIndex = 3;
			// 
			// txtFirstName
			// 
			this.txtFirstName.AcceptsReturn = true;
			this.txtFirstName.AllowDrop = true;
			this.txtFirstName.BackColor = System.Drawing.Color.White;
			this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFirstName.Location = new System.Drawing.Point(184, 16);
			this.txtFirstName.MaxLength = 0;
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFirstName.Size = new System.Drawing.Size(337, 57);
			this.txtFirstName.TabIndex = 1;
			// 
			// lblCompany
			// 
			this.lblCompany.AllowDrop = true;
			this.lblCompany.BackColor = System.Drawing.Color.White;
			this.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCompany.Location = new System.Drawing.Point(40, 136);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCompany.Size = new System.Drawing.Size(145, 65);
			this.lblCompany.TabIndex = 6;
			this.lblCompany.Text = "Company";
			// 
			// lblCounty
			// 
			this.lblCounty.AllowDrop = true;
			this.lblCounty.BackColor = System.Drawing.Color.White;
			this.lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCounty.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCounty.Location = new System.Drawing.Point(40, 520);
			this.lblCounty.Name = "lblCounty";
			this.lblCounty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCounty.Size = new System.Drawing.Size(217, 65);
			this.lblCounty.TabIndex = 20;
			this.lblCounty.Text = "County";
			// 
			// lblCity
			// 
			this.lblCity.AllowDrop = true;
			this.lblCity.BackColor = System.Drawing.Color.White;
			this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCity.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCity.Location = new System.Drawing.Point(344, 432);
			this.lblCity.Name = "lblCity";
			this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCity.Size = new System.Drawing.Size(217, 65);
			this.lblCity.TabIndex = 16;
			this.lblCity.Text = "City";
			// 
			// lblState
			// 
			this.lblState.AllowDrop = true;
			this.lblState.BackColor = System.Drawing.Color.White;
			this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblState.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblState.Location = new System.Drawing.Point(40, 432);
			this.lblState.Name = "lblState";
			this.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblState.Size = new System.Drawing.Size(225, 81);
			this.lblState.TabIndex = 14;
			this.lblState.Text = "State";
			// 
			// lblZipCode
			// 
			this.lblZipCode.AllowDrop = true;
			this.lblZipCode.BackColor = System.Drawing.Color.White;
			this.lblZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblZipCode.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblZipCode.Location = new System.Drawing.Point(736, 432);
			this.lblZipCode.Name = "lblZipCode";
			this.lblZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblZipCode.Size = new System.Drawing.Size(233, 73);
			this.lblZipCode.TabIndex = 18;
			this.lblZipCode.Text = "Zip Code";
			// 
			// lblStreetAdress2
			// 
			this.lblStreetAdress2.AllowDrop = true;
			this.lblStreetAdress2.BackColor = System.Drawing.Color.White;
			this.lblStreetAdress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblStreetAdress2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblStreetAdress2.Location = new System.Drawing.Point(40, 352);
			this.lblStreetAdress2.Name = "lblStreetAdress2";
			this.lblStreetAdress2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblStreetAdress2.Size = new System.Drawing.Size(233, 73);
			this.lblStreetAdress2.TabIndex = 12;
			this.lblStreetAdress2.Text = "Street Address 2:";
			// 
			// lblStreetAddress1
			// 
			this.lblStreetAddress1.AllowDrop = true;
			this.lblStreetAddress1.BackColor = System.Drawing.Color.White;
			this.lblStreetAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblStreetAddress1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblStreetAddress1.Location = new System.Drawing.Point(40, 288);
			this.lblStreetAddress1.Name = "lblStreetAddress1";
			this.lblStreetAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblStreetAddress1.Size = new System.Drawing.Size(233, 57);
			this.lblStreetAddress1.TabIndex = 10;
			this.lblStreetAddress1.Text = "Street Address:";
			// 
			// lblPhone
			// 
			this.lblPhone.AllowDrop = true;
			this.lblPhone.BackColor = System.Drawing.Color.White;
			this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPhone.Location = new System.Drawing.Point(40, 208);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPhone.Size = new System.Drawing.Size(185, 57);
			this.lblPhone.TabIndex = 8;
			this.lblPhone.Text = "Phone";
			// 
			// lblEmail
			// 
			this.lblEmail.AllowDrop = true;
			this.lblEmail.BackColor = System.Drawing.Color.White;
			this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblEmail.Location = new System.Drawing.Point(40, 80);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblEmail.Size = new System.Drawing.Size(185, 57);
			this.lblEmail.TabIndex = 4;
			this.lblEmail.Text = "Email";
			// 
			// lblLastName
			// 
			this.lblLastName.AllowDrop = true;
			this.lblLastName.BackColor = System.Drawing.Color.White;
			this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLastName.Location = new System.Drawing.Point(576, 16);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLastName.Size = new System.Drawing.Size(185, 57);
			this.lblLastName.TabIndex = 2;
			this.lblLastName.Text = "Last Name:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AllowDrop = true;
			this.lblFirstName.BackColor = System.Drawing.Color.White;
			this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFirstName.Location = new System.Drawing.Point(40, 16);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFirstName.Size = new System.Drawing.Size(201, 49);
			this.lblFirstName.TabIndex = 0;
			this.lblFirstName.Text = "First Name:";
			// 
			// frmCustAdd
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1298, 693);
			this.Controls.Add(this.cbClose);
			this.Controls.Add(this.cbSave);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtCounty);
			this.Controls.Add(this.txtZipCode);
			this.Controls.Add(this.txtState);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtStreetAddress2);
			this.Controls.Add(this.txtStreetAddress1);
			this.Controls.Add(this.txtCompany);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblCompany);
			this.Controls.Add(this.lblCounty);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.lblZipCode);
			this.Controls.Add(this.lblStreetAdress2);
			this.Controls.Add(this.lblStreetAddress1);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Location = new System.Drawing.Point(4, 27);
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "frmCustAdd";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register New Customer";
			commandButtonHelper1.SetStyle(this.cbClose, 1);
			commandButtonHelper1.SetStyle(this.cbSave, 1);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}