using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmSearchCust
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmSearchCust m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
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

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "ucLettersPad", "cbClose", "fgCustomers"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public ucLettersPad ucLettersPad { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbClose { get; set; }

      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgCustomers { get; set; }

     
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCust));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.ucLettersPad = new ucLettersPad();
      	this.cbClose = new Mobilize.Web.Button();
      	this.fgCustomers = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.SuspendLayout();
      	
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
      	this.cbClose.Font = new Mobilize.Web.Font("Arial", 24f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbClose.Location = new System.Drawing.Point(1248, 640);
         this.cbClose.Name = "cbClose";

         this.cbClose.Size = new System.Drawing.Size(241, 57);
         this.cbClose.TabIndex = 2;
         this.cbClose.Text = "Close";
         this.cbClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbClose.UseVisualStyleBackColor = false;
         this.cbClose.Click += new System.EventHandler(this.cbClose_Click);
         // 
         // fgCustomers
         // 
         this.fgCustomers.AllowDrop = true;
         this.fgCustomers.AllowUserToAddRows = false;
         this.fgCustomers.AllowUserToDeleteRows = false;



         this.fgCustomers.ColumnsCount = 5;
         this.fgCustomers.FixedColumns = 0;

         this.fgCustomers.Font = new Mobilize.Web.Font("Arial", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.fgCustomers.Location = new System.Drawing.Point(648, 24);
         this.fgCustomers.Name = "fgCustomers";


         this.fgCustomers.Size = new System.Drawing.Size(849, 577);

         this.fgCustomers.TabIndex = 1;
         this.fgCustomers.DoubleClick += new System.EventHandler(this.fgCustomers_DoubleClick);
         // 
         // frmSearchCust
         // 
         this.AllowDrop = true;


         this.BackColor = System.Drawing.Color.White;

         this.Controls.Add(this.ucLettersPad);
         this.Controls.Add(this.cbClose);
         this.Controls.Add(this.fgCustomers);
         this.Font = new Mobilize.Web.Font("Arial", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);

         this.MaximizeBox = true;
         this.MinimizeBox = true;
         this.Name = "frmSearchCust";


         this.Text = "Customer Search";
         this.Closed += new System.EventHandler(this.Form_Closed);

      }
      #endregion

   }
}