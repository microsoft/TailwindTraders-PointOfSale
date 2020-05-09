using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmGiftCardCode
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmGiftCardCode m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
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

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "cbCancel", "cbOK", "txtCode", "lblMessage"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbCancel { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbOK { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCode { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblMessage { get; set; }


      
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiftCardCode));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cbCancel = new Mobilize.Web.Button();
      	this.cbOK = new Mobilize.Web.Button();
      	this.txtCode = new Mobilize.Web.TextBox();
      	this.lblMessage = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	
      	// 
      	// cbCancel
      	// 
      	this.cbCancel.AllowDrop = true;
      	this.cbCancel.BackColor = System.Drawing.Color.White;
      	this.cbCancel.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbCancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbCancel.Location = new System.Drawing.Point(360, 128);
         this.cbCancel.Name = "cbCancel";

         this.cbCancel.Size = new System.Drawing.Size(265, 65);
         this.cbCancel.TabIndex = 3;
         this.cbCancel.Text = "Cancel";
         this.cbCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbCancel.UseVisualStyleBackColor = false;
         this.cbCancel.Click += new System.EventHandler(this.cbCancel_Click);
         // 
         // cbOK
         // 
         this.cbOK.AllowDrop = true;
         this.cbOK.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
         this.cbOK.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbOK.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbOK.Location = new System.Drawing.Point(72, 128);
         this.cbOK.Name = "cbOK";

         this.cbOK.Size = new System.Drawing.Size(265, 65);
         this.cbOK.TabIndex = 2;
         this.cbOK.Text = "OK";
         this.cbOK.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbOK.UseVisualStyleBackColor = false;
         this.cbOK.Click += new System.EventHandler(this.cbOK_Click);
         // 
         // txtCode
         // 
         this.txtCode.AcceptsReturn = true;
         this.txtCode.AllowDrop = true;
         this.txtCode.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtCode.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;

         this.txtCode.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtCode.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCode.Location = new System.Drawing.Point(24, 72);
         this.txtCode.MaxLength = 0;
         this.txtCode.Name = "txtCode";

         this.txtCode.Size = new System.Drawing.Size(633, 49);
         this.txtCode.TabIndex = 1;
         // 
         // lblMessage
         // 
         this.lblMessage.AllowDrop = true;
         this.lblMessage.BackColor = System.Drawing.Color.White;
         this.lblMessage.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblMessage.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblMessage.Location = new System.Drawing.Point(40, 24);
         this.lblMessage.Name = "lblMessage";

         this.lblMessage.Size = new System.Drawing.Size(313, 41);
         this.lblMessage.TabIndex = 0;
         this.lblMessage.Text = "Enter GIFT CARD CODE";
         // 
         // frmGiftCardCode
         // 
         this.AllowDrop = true;


         this.BackColor = System.Drawing.Color.White;

         this.ControlBox = false;
         this.Controls.Add(this.cbCancel);
         this.Controls.Add(this.cbOK);
         this.Controls.Add(this.txtCode);
         this.Controls.Add(this.lblMessage);
         this.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;

         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmGiftCardCode";


         this.Text = "Enter Gift Card Code";
         this.Closed += new System.EventHandler(this.Form_Closed);

      }
      #endregion

   }
}