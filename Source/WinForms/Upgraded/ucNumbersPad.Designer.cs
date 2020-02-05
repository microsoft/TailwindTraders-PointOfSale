
namespace TailwindPOS
{
	partial class ucNumbersPad
	{

		#region "Windows Form Designer generated code "
		public static ucNumbersPad CreateInstance()
		{
			ucNumbersPad theInstance = new ucNumbersPad();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtAmount", "cb_Period", "cb_Number00", "cb_Number0", "cb_Enter", "cb_Number3", "cb_Number2", "cb_Number1", "cb_Clear", "cb_Number6", "cb_Number5", "cb_Number4", "cb_Back", "cb_Number9", "cb_Number8", "cb_Number7", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		internal System.Windows.Forms.TextBox txtAmount;
		internal System.Windows.Forms.Button cb_Period;
		internal System.Windows.Forms.Button cb_Number00;
		internal System.Windows.Forms.Button cb_Number0;
		internal System.Windows.Forms.Button cb_Enter;
		internal System.Windows.Forms.Button cb_Number3;
		internal System.Windows.Forms.Button cb_Number2;
		internal System.Windows.Forms.Button cb_Number1;
		internal System.Windows.Forms.Button cb_Clear;
		internal System.Windows.Forms.Button cb_Number6;
		internal System.Windows.Forms.Button cb_Number5;
		internal System.Windows.Forms.Button cb_Number4;
		internal System.Windows.Forms.Button cb_Back;
		internal System.Windows.Forms.Button cb_Number9;
		internal System.Windows.Forms.Button cb_Number8;
		internal System.Windows.Forms.Button cb_Number7;
		private UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNumbersPad));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.cb_Period = new System.Windows.Forms.Button();
			this.cb_Number00 = new System.Windows.Forms.Button();
			this.cb_Number0 = new System.Windows.Forms.Button();
			this.cb_Enter = new System.Windows.Forms.Button();
			this.cb_Number3 = new System.Windows.Forms.Button();
			this.cb_Number2 = new System.Windows.Forms.Button();
			this.cb_Number1 = new System.Windows.Forms.Button();
			this.cb_Clear = new System.Windows.Forms.Button();
			this.cb_Number6 = new System.Windows.Forms.Button();
			this.cb_Number5 = new System.Windows.Forms.Button();
			this.cb_Number4 = new System.Windows.Forms.Button();
			this.cb_Back = new System.Windows.Forms.Button();
			this.cb_Number9 = new System.Windows.Forms.Button();
			this.cb_Number8 = new System.Windows.Forms.Button();
			this.cb_Number7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// txtAmount
			// 
			this.txtAmount.AcceptsReturn = true;
			this.txtAmount.AllowDrop = true;
			this.txtAmount.BackColor = System.Drawing.Color.White;
			this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAmount.Font = new System.Drawing.Font("Arial", 36f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			this.txtAmount.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtAmount.Location = new System.Drawing.Point(8, 8);
			this.txtAmount.MaxLength = 0;
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.PasswordChar = (char) 42;
			this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtAmount.Size = new System.Drawing.Size(313, 73);
			this.txtAmount.TabIndex = 15;
			this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			// 
			// cb_Period
			// 
			this.cb_Period.AllowDrop = true;
			this.cb_Period.BackColor = System.Drawing.Color.White;
			this.cb_Period.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Period.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Period.Location = new System.Drawing.Point(168, 328);
			this.cb_Period.Name = "cb_Period";
			this.cb_Period.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Period.Size = new System.Drawing.Size(73, 73);
			this.cb_Period.TabIndex = 14;
			this.cb_Period.Text = ".";
			this.cb_Period.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Period.UseVisualStyleBackColor = false;
			this.cb_Period.Click += new System.EventHandler(this.cb_Period_Click);
			// 
			// cb_Number00
			// 
			this.cb_Number00.AllowDrop = true;
			this.cb_Number00.BackColor = System.Drawing.Color.White;
			this.cb_Number00.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number00.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number00.Location = new System.Drawing.Point(88, 328);
			this.cb_Number00.Name = "cb_Number00";
			this.cb_Number00.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number00.Size = new System.Drawing.Size(73, 73);
			this.cb_Number00.TabIndex = 13;
			this.cb_Number00.Text = "00";
			this.cb_Number00.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number00.UseVisualStyleBackColor = false;
			this.cb_Number00.Click += new System.EventHandler(this.cb_Number00_Click);
			// 
			// cb_Number0
			// 
			this.cb_Number0.AllowDrop = true;
			this.cb_Number0.BackColor = System.Drawing.Color.White;
			this.cb_Number0.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number0.Location = new System.Drawing.Point(8, 328);
			this.cb_Number0.Name = "cb_Number0";
			this.cb_Number0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number0.Size = new System.Drawing.Size(73, 73);
			this.cb_Number0.TabIndex = 12;
			this.cb_Number0.Text = "0";
			this.cb_Number0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number0.UseVisualStyleBackColor = false;
			this.cb_Number0.Click += new System.EventHandler(this.cb_Number0_Click);
			// 
			// cb_Enter
			// 
			this.cb_Enter.AllowDrop = true;
			this.cb_Enter.BackColor = System.Drawing.Color.White;
			this.cb_Enter.Font = new System.Drawing.Font("Arial", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Enter.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Enter.Location = new System.Drawing.Point(248, 248);
			this.cb_Enter.Name = "cb_Enter";
			this.cb_Enter.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Enter.Size = new System.Drawing.Size(73, 153);
			this.cb_Enter.TabIndex = 11;
			this.cb_Enter.Text = "+";
			this.cb_Enter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Enter.UseVisualStyleBackColor = false;
			this.cb_Enter.Click += new System.EventHandler(this.cb_Enter_Click);
			// 
			// cb_Number3
			// 
			this.cb_Number3.AllowDrop = true;
			this.cb_Number3.BackColor = System.Drawing.Color.White;
			this.cb_Number3.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number3.Location = new System.Drawing.Point(168, 248);
			this.cb_Number3.Name = "cb_Number3";
			this.cb_Number3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number3.Size = new System.Drawing.Size(73, 73);
			this.cb_Number3.TabIndex = 10;
			this.cb_Number3.Text = "3";
			this.cb_Number3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number3.UseVisualStyleBackColor = false;
			this.cb_Number3.Click += new System.EventHandler(this.cb_Number3_Click);
			// 
			// cb_Number2
			// 
			this.cb_Number2.AllowDrop = true;
			this.cb_Number2.BackColor = System.Drawing.Color.White;
			this.cb_Number2.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number2.Location = new System.Drawing.Point(88, 248);
			this.cb_Number2.Name = "cb_Number2";
			this.cb_Number2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number2.Size = new System.Drawing.Size(73, 73);
			this.cb_Number2.TabIndex = 9;
			this.cb_Number2.Text = "2";
			this.cb_Number2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number2.UseVisualStyleBackColor = false;
			this.cb_Number2.Click += new System.EventHandler(this.cb_Number2_Click);
			// 
			// cb_Number1
			// 
			this.cb_Number1.AllowDrop = true;
			this.cb_Number1.BackColor = System.Drawing.Color.White;
			this.cb_Number1.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number1.Location = new System.Drawing.Point(8, 248);
			this.cb_Number1.Name = "cb_Number1";
			this.cb_Number1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number1.Size = new System.Drawing.Size(73, 73);
			this.cb_Number1.TabIndex = 8;
			this.cb_Number1.Text = "1";
			this.cb_Number1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number1.UseVisualStyleBackColor = false;
			this.cb_Number1.Click += new System.EventHandler(this.cb_Number1_Click);
			// 
			// cb_Clear
			// 
			this.cb_Clear.AllowDrop = true;
			this.cb_Clear.BackColor = System.Drawing.Color.White;
			this.cb_Clear.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Clear.Location = new System.Drawing.Point(248, 168);
			this.cb_Clear.Name = "cb_Clear";
			this.cb_Clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Clear.Size = new System.Drawing.Size(73, 73);
			this.cb_Clear.TabIndex = 7;
			this.cb_Clear.Text = "C";
			this.cb_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Clear.UseVisualStyleBackColor = false;
			this.cb_Clear.Click += new System.EventHandler(this.cb_Clear_Click);
			// 
			// cb_Number6
			// 
			this.cb_Number6.AllowDrop = true;
			this.cb_Number6.BackColor = System.Drawing.Color.White;
			this.cb_Number6.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number6.Location = new System.Drawing.Point(168, 168);
			this.cb_Number6.Name = "cb_Number6";
			this.cb_Number6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number6.Size = new System.Drawing.Size(73, 73);
			this.cb_Number6.TabIndex = 6;
			this.cb_Number6.Text = "6";
			this.cb_Number6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number6.UseVisualStyleBackColor = false;
			this.cb_Number6.Click += new System.EventHandler(this.cb_Number6_Click);
			// 
			// cb_Number5
			// 
			this.cb_Number5.AllowDrop = true;
			this.cb_Number5.BackColor = System.Drawing.Color.White;
			this.cb_Number5.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number5.Location = new System.Drawing.Point(88, 168);
			this.cb_Number5.Name = "cb_Number5";
			this.cb_Number5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number5.Size = new System.Drawing.Size(73, 73);
			this.cb_Number5.TabIndex = 5;
			this.cb_Number5.Text = "5";
			this.cb_Number5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number5.UseVisualStyleBackColor = false;
			this.cb_Number5.Click += new System.EventHandler(this.cb_Number5_Click);
			// 
			// cb_Number4
			// 
			this.cb_Number4.AllowDrop = true;
			this.cb_Number4.BackColor = System.Drawing.Color.White;
			this.cb_Number4.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number4.Location = new System.Drawing.Point(8, 168);
			this.cb_Number4.Name = "cb_Number4";
			this.cb_Number4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number4.Size = new System.Drawing.Size(73, 73);
			this.cb_Number4.TabIndex = 4;
			this.cb_Number4.Text = "4";
			this.cb_Number4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number4.UseVisualStyleBackColor = false;
			this.cb_Number4.Click += new System.EventHandler(this.cb_Number4_Click);
			// 
			// cb_Back
			// 
			this.cb_Back.AllowDrop = true;
			this.cb_Back.BackColor = System.Drawing.Color.White;
			this.cb_Back.Font = new System.Drawing.Font("Arial", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Back.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Back.Location = new System.Drawing.Point(248, 88);
			this.cb_Back.Name = "cb_Back";
			this.cb_Back.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Back.Size = new System.Drawing.Size(73, 73);
			this.cb_Back.TabIndex = 3;
			this.cb_Back.Text = "<-";
			this.cb_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Back.UseVisualStyleBackColor = false;
			this.cb_Back.Click += new System.EventHandler(this.cb_Back_Click);
			// 
			// cb_Number9
			// 
			this.cb_Number9.AllowDrop = true;
			this.cb_Number9.BackColor = System.Drawing.Color.White;
			this.cb_Number9.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number9.Location = new System.Drawing.Point(168, 88);
			this.cb_Number9.Name = "cb_Number9";
			this.cb_Number9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number9.Size = new System.Drawing.Size(73, 73);
			this.cb_Number9.TabIndex = 2;
			this.cb_Number9.Text = "9";
			this.cb_Number9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number9.UseVisualStyleBackColor = false;
			this.cb_Number9.Click += new System.EventHandler(this.cb_Number9_Click);
			// 
			// cb_Number8
			// 
			this.cb_Number8.AllowDrop = true;
			this.cb_Number8.BackColor = System.Drawing.Color.White;
			this.cb_Number8.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number8.Location = new System.Drawing.Point(88, 88);
			this.cb_Number8.Name = "cb_Number8";
			this.cb_Number8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number8.Size = new System.Drawing.Size(73, 73);
			this.cb_Number8.TabIndex = 1;
			this.cb_Number8.Text = "8";
			this.cb_Number8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number8.UseVisualStyleBackColor = false;
			this.cb_Number8.Click += new System.EventHandler(this.cb_Number8_Click);
			// 
			// cb_Number7
			// 
			this.cb_Number7.AllowDrop = true;
			this.cb_Number7.BackColor = System.Drawing.Color.White;
			this.cb_Number7.Font = new System.Drawing.Font("Arial", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cb_Number7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb_Number7.Location = new System.Drawing.Point(8, 88);
			this.cb_Number7.Name = "cb_Number7";
			this.cb_Number7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_Number7.Size = new System.Drawing.Size(73, 73);
			this.cb_Number7.TabIndex = 0;
			this.cb_Number7.Text = "7";
			this.cb_Number7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cb_Number7.UseVisualStyleBackColor = false;
			this.cb_Number7.Click += new System.EventHandler(this.cb_Number7_Click);
			// 
			// ucNumbersPad
			// 
			base.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(334, 412);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.cb_Period);
			this.Controls.Add(this.cb_Number00);
			this.Controls.Add(this.cb_Number0);
			this.Controls.Add(this.cb_Enter);
			this.Controls.Add(this.cb_Number3);
			this.Controls.Add(this.cb_Number2);
			this.Controls.Add(this.cb_Number1);
			this.Controls.Add(this.cb_Clear);
			this.Controls.Add(this.cb_Number6);
			this.Controls.Add(this.cb_Number5);
			this.Controls.Add(this.cb_Number4);
			this.Controls.Add(this.cb_Back);
			this.Controls.Add(this.cb_Number9);
			this.Controls.Add(this.cb_Number8);
			this.Controls.Add(this.cb_Number7);
			base.Location = new System.Drawing.Point(0, 0);
			base.Name = "ucNumbersPad";
			commandButtonHelper1.SetStyle(this.cb_Period, 1);
			commandButtonHelper1.SetStyle(this.cb_Number00, 1);
			commandButtonHelper1.SetStyle(this.cb_Number0, 1);
			commandButtonHelper1.SetStyle(this.cb_Enter, 1);
			commandButtonHelper1.SetStyle(this.cb_Number3, 1);
			commandButtonHelper1.SetStyle(this.cb_Number2, 1);
			commandButtonHelper1.SetStyle(this.cb_Number1, 1);
			commandButtonHelper1.SetStyle(this.cb_Clear, 1);
			commandButtonHelper1.SetStyle(this.cb_Number6, 1);
			commandButtonHelper1.SetStyle(this.cb_Number5, 1);
			commandButtonHelper1.SetStyle(this.cb_Number4, 1);
			commandButtonHelper1.SetStyle(this.cb_Back, 1);
			commandButtonHelper1.SetStyle(this.cb_Number9, 1);
			commandButtonHelper1.SetStyle(this.cb_Number8, 1);
			commandButtonHelper1.SetStyle(this.cb_Number7, 1);
			this.ResumeLayout(false);
		}
		#endregion
		#region "Upgrade Support"
		public sealed class OnEnterEventEventArgs
			: System.EventArgs
		{

			public string Text_Renamed = "";
			public OnEnterEventEventArgs(string Text_Renamed)
				: base()
			{
				this.Text_Renamed = Text_Renamed;
			}
		}
		public sealed class OnNumberEventArgs
			: System.EventArgs
		{

			public string Number = "";
			public OnNumberEventArgs(string Number)
				: base()
			{
				this.Number = Number;
			}
		}
		#endregion
	}
}