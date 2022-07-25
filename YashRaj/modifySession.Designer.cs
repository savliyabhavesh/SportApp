namespace YashAksh
{
	// Token: 0x020000C6 RID: 198
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class modifySession : System.Windows.Forms.Form
	{
		// Token: 0x0600211F RID: 8479 RVA: 0x003A9630 File Offset: 0x003A7A30
		//[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		

		// Token: 0x06002120 RID: 8480 RVA: 0x003A9670 File Offset: 0x003A7A70
		//[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtcommi = new System.Windows.Forms.ComboBox();
            this.txtsessionname = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.BTNMODIFY = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtdate);
            this.GroupBox2.Controls.Add(this.txtid);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.txtcommi);
            this.GroupBox2.Controls.Add(this.txtsessionname);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(536, 34);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(267, 259);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(20, 154);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(235, 26);
            this.txtdate.TabIndex = 12;
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(20, 46);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(235, 26);
            this.txtid.TabIndex = 11;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(96, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(55, 19);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Sr.No.";
            // 
            // txtcommi
            // 
            this.txtcommi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcommi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcommi.FormattingEnabled = true;
            this.txtcommi.Items.AddRange(new object[] {
            "TEST",
            "50-50",
            "40-40",
            "20-20"});
            this.txtcommi.Location = new System.Drawing.Point(20, 207);
            this.txtcommi.Name = "txtcommi";
            this.txtcommi.Size = new System.Drawing.Size(235, 27);
            this.txtcommi.TabIndex = 9;
            this.txtcommi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcommi_KeyDown);
            // 
            // txtsessionname
            // 
            this.txtsessionname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsessionname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsessionname.Location = new System.Drawing.Point(20, 102);
            this.txtsessionname.Name = "txtsessionname";
            this.txtsessionname.Size = new System.Drawing.Size(235, 26);
            this.txtsessionname.TabIndex = 7;
            this.txtsessionname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsessionname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsessionname_KeyDown);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(62, 184);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(146, 19);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Commission Type";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(107, 131);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 19);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Date";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(78, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(119, 19);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Session Name";
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(701, 301);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(102, 31);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Colse";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BTNMODIFY
            // 
            this.BTNMODIFY.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMODIFY.Location = new System.Drawing.Point(536, 301);
            this.BTNMODIFY.Name = "BTNMODIFY";
            this.BTNMODIFY.Size = new System.Drawing.Size(109, 31);
            this.BTNMODIFY.TabIndex = 0;
            this.BTNMODIFY.Text = "Save";
            this.BTNMODIFY.UseVisualStyleBackColor = true;
            this.BTNMODIFY.Click += new System.EventHandler(this.BTNMODIFY_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1276, 30);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "New Session";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifySession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BTNMODIFY);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "modifySession";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Session";
            this.Load += new System.EventHandler(this.modifySession_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000CD8 RID: 3288
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.DateTimePicker txtdate;
		private System.Windows.Forms.GroupBox GroupBox2;
		private System.Windows.Forms.ComboBox txtcommi;
		private System.Windows.Forms.TextBox txtsessionname;
		private System.Windows.Forms.TextBox txtid;

		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label5;

		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button BTNMODIFY;


	}
}
