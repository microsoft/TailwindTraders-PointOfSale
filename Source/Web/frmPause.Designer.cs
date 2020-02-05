using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmPause
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmPause m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
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

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "cbReturn", "lblPauseMessage", "commandButtonHelper1"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbReturn { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPauseMessage { get; set; }

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
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPause));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cbReturn = new Mobilize.Web.Button();
      	this.lblPauseMessage = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.CommandButtonHelper(this.components);
      	// 
      	// cbReturn
      	// 
      	this.cbReturn.AllowDrop = true;
      	this.cbReturn.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
      	this.cbReturn.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbReturn.Location = new System.Drawing.Point(224, 160);
         this.cbReturn.Name = "cbReturn";
         this.cbReturn.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cbReturn.Size = new System.Drawing.Size(417, 81);
         this.cbReturn.TabIndex = 1;
         this.cbReturn.Text = "Return";
         this.cbReturn.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbReturn.UseVisualStyleBackColor = false;
         this.cbReturn.Click += new System.EventHandler(this.cbReturn_Click);
         // 
         // lblPauseMessage
         // 
         this.lblPauseMessage.AllowDrop = true;
         this.lblPauseMessage.BackColor = System.Drawing.Color.White;
         this.lblPauseMessage.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPauseMessage.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblPauseMessage.Location = new System.Drawing.Point(56, 32);
         this.lblPauseMessage.Name = "lblPauseMessage";
         this.lblPauseMessage.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblPauseMessage.Size = new System.Drawing.Size(713, 73);
         this.lblPauseMessage.TabIndex = 0;
         this.lblPauseMessage.Text = "POS Paused";
         this.lblPauseMessage.TextAlign = Mobilize.Web.ContentAlignment.TopCenter;
         // 
         // frmPause
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Window;
         this.Properties().ClientSize = new System.Drawing.Size(844, 334);
         this.ControlBox = false;
         this.Controls.Add(this.cbReturn);
         this.Controls.Add(this.lblPauseMessage);
         this.Font = new Mobilize.Web.Font("Arial", 24f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.Properties().Location = new System.Drawing.Point(3, 26);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmPause";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Tailwind Point of Sale Paused";
         commandButtonHelper1.SetStyle(this.cbReturn, 1);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);
      }
      #endregion

   }
}