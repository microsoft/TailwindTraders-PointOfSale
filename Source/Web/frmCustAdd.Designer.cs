using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmCustAdd
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmCustAdd m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
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

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "cbClose", "cbSave", "txtPhone", "txtCounty", "txtZipCode", "txtState", "txtCity", "txtStreetAddress2", "txtStreetAddress1", "txtCompany", "txtEmail", "txtLastName", "txtFirstName", "lblCompany", "lblCounty", "lblCity", "lblState", "lblZipCode", "lblStreetAdress2", "lblStreetAddress1", "lblPhone", "lblEmail", "lblLastName", "lblFirstName"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbClose { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbSave { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtPhone { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCounty { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtZipCode { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtState { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCity { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtStreetAddress2 { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtStreetAddress1 { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCompany { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtEmail { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtLastName { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtFirstName { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblCompany { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblCounty { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblCity { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblState { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblZipCode { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblStreetAdress2 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblStreetAddress1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPhone { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblEmail { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblLastName { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblFirstName { get; set; }
     
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustAdd));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cbClose = new Mobilize.Web.Button();
      	this.cbSave = new Mobilize.Web.Button();
      	this.txtPhone = new Mobilize.Web.TextBox();
      	this.txtCounty = new Mobilize.Web.TextBox();
      	this.txtZipCode = new Mobilize.Web.TextBox();
      	this.txtState = new Mobilize.Web.TextBox();
      	this.txtCity = new Mobilize.Web.TextBox();
      	this.txtStreetAddress2 = new Mobilize.Web.TextBox();
      	this.txtStreetAddress1 = new Mobilize.Web.TextBox();
      	this.txtCompany = new Mobilize.Web.TextBox();
      	this.txtEmail = new Mobilize.Web.TextBox();
      	this.txtLastName = new Mobilize.Web.TextBox();
      	this.txtFirstName = new Mobilize.Web.TextBox();
      	this.lblCompany = new Mobilize.Web.Label();
      	this.lblCounty = new Mobilize.Web.Label();
      	this.lblCity = new Mobilize.Web.Label();
      	this.lblState = new Mobilize.Web.Label();
      	this.lblZipCode = new Mobilize.Web.Label();
      	this.lblStreetAdress2 = new Mobilize.Web.Label();
      	this.lblStreetAddress1 = new Mobilize.Web.Label();
      	this.lblPhone = new Mobilize.Web.Label();
      	this.lblEmail = new Mobilize.Web.Label();
      	this.lblLastName = new Mobilize.Web.Label();
      	this.lblFirstName = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	
      	// 
      	// cbClose
      	// 
      	this.cbClose.AllowDrop = true;
      	this.cbClose.BackColor = System.Drawing.Color.White;
      	this.cbClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbClose.Location = new System.Drawing.Point(488, 624);
         this.cbClose.Name = "cbClose";

         this.cbClose.Size = new System.Drawing.Size(417, 65);
         this.cbClose.TabIndex = 23;
         this.cbClose.Text = "Close";
         this.cbClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbClose.UseVisualStyleBackColor = false;
         this.cbClose.Click += new System.EventHandler(this.cbClose_Click);
         // 
         // cbSave
         // 
         this.cbSave.AllowDrop = true;
         this.cbSave.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
         this.cbSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbSave.Location = new System.Drawing.Point(64, 624);
         this.cbSave.Name = "cbSave";

         this.cbSave.Size = new System.Drawing.Size(401, 65);
         this.cbSave.TabIndex = 22;
         this.cbSave.Text = "Save";
         this.cbSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbSave.UseVisualStyleBackColor = false;
         this.cbSave.Click += new System.EventHandler(this.cbSave_Click);
         // 
         // txtPhone
         // 
         this.txtPhone.AcceptsReturn = true;
         this.txtPhone.AllowDrop = true;
         this.txtPhone.BackColor = System.Drawing.Color.White;
         this.txtPhone.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtPhone.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtPhone.Location = new System.Drawing.Point(184, 216);
         this.txtPhone.MaxLength = 0;
         this.txtPhone.Name = "txtPhone";

         this.txtPhone.Size = new System.Drawing.Size(305, 65);
         this.txtPhone.TabIndex = 9;
         // 
         // txtCounty
         // 
         this.txtCounty.AcceptsReturn = true;
         this.txtCounty.AllowDrop = true;
         this.txtCounty.BackColor = System.Drawing.Color.White;
         this.txtCounty.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtCounty.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCounty.Location = new System.Drawing.Point(176, 520);
         this.txtCounty.MaxLength = 0;
         this.txtCounty.Name = "txtCounty";

         this.txtCounty.Size = new System.Drawing.Size(353, 65);
         this.txtCounty.TabIndex = 21;
         // 
         // txtZipCode
         // 
         this.txtZipCode.AcceptsReturn = true;
         this.txtZipCode.AllowDrop = true;
         this.txtZipCode.BackColor = System.Drawing.Color.White;
         this.txtZipCode.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtZipCode.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtZipCode.Location = new System.Drawing.Point(856, 432);
         this.txtZipCode.MaxLength = 0;
         this.txtZipCode.Name = "txtZipCode";

         this.txtZipCode.Size = new System.Drawing.Size(225, 65);
         this.txtZipCode.TabIndex = 19;
         // 
         // txtState
         // 
         this.txtState.AcceptsReturn = true;
         this.txtState.AllowDrop = true;
         this.txtState.BackColor = System.Drawing.Color.White;
         this.txtState.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtState.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtState.Location = new System.Drawing.Point(120, 432);
         this.txtState.MaxLength = 0;
         this.txtState.Name = "txtState";

         this.txtState.Size = new System.Drawing.Size(209, 57);
         this.txtState.TabIndex = 15;
         // 
         // txtCity
         // 
         this.txtCity.AcceptsReturn = true;
         this.txtCity.AllowDrop = true;
         this.txtCity.BackColor = System.Drawing.Color.White;
         this.txtCity.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtCity.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCity.Location = new System.Drawing.Point(424, 432);
         this.txtCity.MaxLength = 0;
         this.txtCity.Name = "txtCity";

         this.txtCity.Size = new System.Drawing.Size(289, 57);
         this.txtCity.TabIndex = 17;
         // 
         // txtStreetAddress2
         // 
         this.txtStreetAddress2.AcceptsReturn = true;
         this.txtStreetAddress2.AllowDrop = true;
         this.txtStreetAddress2.BackColor = System.Drawing.Color.White;
         this.txtStreetAddress2.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtStreetAddress2.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtStreetAddress2.Location = new System.Drawing.Point(256, 360);
         this.txtStreetAddress2.MaxLength = 0;
         this.txtStreetAddress2.Name = "txtStreetAddress2";

         this.txtStreetAddress2.Size = new System.Drawing.Size(937, 57);
         this.txtStreetAddress2.TabIndex = 13;
         // 
         // txtStreetAddress1
         // 
         this.txtStreetAddress1.AcceptsReturn = true;
         this.txtStreetAddress1.AllowDrop = true;
         this.txtStreetAddress1.BackColor = System.Drawing.Color.White;
         this.txtStreetAddress1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtStreetAddress1.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtStreetAddress1.Location = new System.Drawing.Point(256, 288);
         this.txtStreetAddress1.MaxLength = 0;
         this.txtStreetAddress1.Name = "txtStreetAddress1";

         this.txtStreetAddress1.Size = new System.Drawing.Size(937, 65);
         this.txtStreetAddress1.TabIndex = 11;
         // 
         // txtCompany
         // 
         this.txtCompany.AcceptsReturn = true;
         this.txtCompany.AllowDrop = true;
         this.txtCompany.BackColor = System.Drawing.Color.White;
         this.txtCompany.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtCompany.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCompany.Location = new System.Drawing.Point(184, 144);
         this.txtCompany.MaxLength = 0;
         this.txtCompany.Name = "txtCompany";

         this.txtCompany.Size = new System.Drawing.Size(857, 65);
         this.txtCompany.TabIndex = 7;
         // 
         // txtEmail
         // 
         this.txtEmail.AcceptsReturn = true;
         this.txtEmail.AllowDrop = true;
         this.txtEmail.BackColor = System.Drawing.Color.White;
         this.txtEmail.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtEmail.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtEmail.Location = new System.Drawing.Point(184, 80);
         this.txtEmail.MaxLength = 0;
         this.txtEmail.Name = "txtEmail";

         this.txtEmail.Size = new System.Drawing.Size(857, 57);
         this.txtEmail.TabIndex = 5;
         // 
         // txtLastName
         // 
         this.txtLastName.AcceptsReturn = true;
         this.txtLastName.AllowDrop = true;
         this.txtLastName.BackColor = System.Drawing.Color.White;
         this.txtLastName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtLastName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtLastName.Location = new System.Drawing.Point(728, 16);
         this.txtLastName.MaxLength = 0;
         this.txtLastName.Name = "txtLastName";

         this.txtLastName.Size = new System.Drawing.Size(361, 57);
         this.txtLastName.TabIndex = 3;
         // 
         // txtFirstName
         // 
         this.txtFirstName.AcceptsReturn = true;
         this.txtFirstName.AllowDrop = true;
         this.txtFirstName.BackColor = System.Drawing.Color.White;
         this.txtFirstName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtFirstName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFirstName.Location = new System.Drawing.Point(184, 16);
         this.txtFirstName.MaxLength = 0;
         this.txtFirstName.Name = "txtFirstName";

         this.txtFirstName.Size = new System.Drawing.Size(337, 57);
         this.txtFirstName.TabIndex = 1;
         // 
         // lblCompany
         // 
         this.lblCompany.AllowDrop = true;
         this.lblCompany.BackColor = System.Drawing.Color.White;
         this.lblCompany.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCompany.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblCompany.Location = new System.Drawing.Point(40, 136);
         this.lblCompany.Name = "lblCompany";

         this.lblCompany.Size = new System.Drawing.Size(145, 65);
         this.lblCompany.TabIndex = 6;
         this.lblCompany.Text = "Company";
         // 
         // lblCounty
         // 
         this.lblCounty.AllowDrop = true;
         this.lblCounty.BackColor = System.Drawing.Color.White;
         this.lblCounty.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCounty.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblCounty.Location = new System.Drawing.Point(40, 520);
         this.lblCounty.Name = "lblCounty";

         this.lblCounty.Size = new System.Drawing.Size(217, 65);
         this.lblCounty.TabIndex = 20;
         this.lblCounty.Text = "County";
         // 
         // lblCity
         // 
         this.lblCity.AllowDrop = true;
         this.lblCity.BackColor = System.Drawing.Color.White;
         this.lblCity.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblCity.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblCity.Location = new System.Drawing.Point(344, 432);
         this.lblCity.Name = "lblCity";

         this.lblCity.Size = new System.Drawing.Size(217, 65);
         this.lblCity.TabIndex = 16;
         this.lblCity.Text = "City";
         // 
         // lblState
         // 
         this.lblState.AllowDrop = true;
         this.lblState.BackColor = System.Drawing.Color.White;
         this.lblState.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblState.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblState.Location = new System.Drawing.Point(40, 432);
         this.lblState.Name = "lblState";

         this.lblState.Size = new System.Drawing.Size(225, 81);
         this.lblState.TabIndex = 14;
         this.lblState.Text = "State";
         // 
         // lblZipCode
         // 
         this.lblZipCode.AllowDrop = true;
         this.lblZipCode.BackColor = System.Drawing.Color.White;
         this.lblZipCode.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblZipCode.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblZipCode.Location = new System.Drawing.Point(736, 432);
         this.lblZipCode.Name = "lblZipCode";

         this.lblZipCode.Size = new System.Drawing.Size(233, 73);
         this.lblZipCode.TabIndex = 18;
         this.lblZipCode.Text = "Zip Code";
         // 
         // lblStreetAdress2
         // 
         this.lblStreetAdress2.AllowDrop = true;
         this.lblStreetAdress2.BackColor = System.Drawing.Color.White;
         this.lblStreetAdress2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblStreetAdress2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblStreetAdress2.Location = new System.Drawing.Point(40, 352);
         this.lblStreetAdress2.Name = "lblStreetAdress2";

         this.lblStreetAdress2.Size = new System.Drawing.Size(233, 73);
         this.lblStreetAdress2.TabIndex = 12;
         this.lblStreetAdress2.Text = "Street Address 2:";
         // 
         // lblStreetAddress1
         // 
         this.lblStreetAddress1.AllowDrop = true;
         this.lblStreetAddress1.BackColor = System.Drawing.Color.White;
         this.lblStreetAddress1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblStreetAddress1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblStreetAddress1.Location = new System.Drawing.Point(40, 288);
         this.lblStreetAddress1.Name = "lblStreetAddress1";

         this.lblStreetAddress1.Size = new System.Drawing.Size(233, 57);
         this.lblStreetAddress1.TabIndex = 10;
         this.lblStreetAddress1.Text = "Street Address:";
         // 
         // lblPhone
         // 
         this.lblPhone.AllowDrop = true;
         this.lblPhone.BackColor = System.Drawing.Color.White;
         this.lblPhone.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPhone.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblPhone.Location = new System.Drawing.Point(40, 208);
         this.lblPhone.Name = "lblPhone";

         this.lblPhone.Size = new System.Drawing.Size(185, 57);
         this.lblPhone.TabIndex = 8;
         this.lblPhone.Text = "Phone";
         // 
         // lblEmail
         // 
         this.lblEmail.AllowDrop = true;
         this.lblEmail.BackColor = System.Drawing.Color.White;
         this.lblEmail.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblEmail.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblEmail.Location = new System.Drawing.Point(40, 80);
         this.lblEmail.Name = "lblEmail";

         this.lblEmail.Size = new System.Drawing.Size(185, 57);
         this.lblEmail.TabIndex = 4;
         this.lblEmail.Text = "Email";
         // 
         // lblLastName
         // 
         this.lblLastName.AllowDrop = true;
         this.lblLastName.BackColor = System.Drawing.Color.White;
         this.lblLastName.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblLastName.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblLastName.Location = new System.Drawing.Point(576, 16);
         this.lblLastName.Name = "lblLastName";

         this.lblLastName.Size = new System.Drawing.Size(185, 57);
         this.lblLastName.TabIndex = 2;
         this.lblLastName.Text = "Last Name:";
         // 
         // lblFirstName
         // 
         this.lblFirstName.AllowDrop = true;
         this.lblFirstName.BackColor = System.Drawing.Color.White;
         this.lblFirstName.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblFirstName.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblFirstName.Location = new System.Drawing.Point(40, 16);
         this.lblFirstName.Name = "lblFirstName";

         this.lblFirstName.Size = new System.Drawing.Size(201, 49);
         this.lblFirstName.TabIndex = 0;
         this.lblFirstName.Text = "First Name:";
         // 
         // frmCustAdd
         // 
         this.AllowDrop = true;


         this.BackColor = System.Drawing.Color.White;

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
         this.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);

         this.MaximizeBox = true;
         this.MinimizeBox = true;
         this.Name = "frmCustAdd";


         this.Text = "Register New Customer";
         this.Closed += new System.EventHandler(this.Form_Closed);

      }
      #endregion

   }
}