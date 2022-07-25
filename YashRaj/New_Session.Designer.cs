namespace YashAksh
{
	// Token: 0x0200005E RID: 94
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class New_Session : System.Windows.Forms.Form
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x00385440 File Offset: 0x00383840
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
        

		// Token: 0x06001917 RID: 6423 RVA: 0x00385480 File Offset: 0x00383880
		//[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtcommi = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.txtsessin = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(739, 30);
            this.Panel1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(739, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "New Session";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtid);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.txtcommi);
            this.GroupBox2.Controls.Add(this.dtpdate);
            this.GroupBox2.Controls.Add(this.txtsessin);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(269, 37);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(206, 262);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(26, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(166, 26);
            this.txtid.TabIndex = 0;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(79, 19);
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
            "YES",
            "NO"});
            this.txtcommi.Location = new System.Drawing.Point(26, 208);
            this.txtcommi.Name = "txtcommi";
            this.txtcommi.Size = new System.Drawing.Size(166, 27);
            this.txtcommi.TabIndex = 2;
            this.txtcommi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcommi_KeyDown);
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(26, 150);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(166, 26);
            this.dtpdate.TabIndex = 1;
            this.dtpdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown);
            // 
            // txtsessin
            // 
            this.txtsessin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsessin.Location = new System.Drawing.Point(26, 98);
            this.txtsessin.Name = "txtsessin";
            this.txtsessin.Size = new System.Drawing.Size(166, 26);
            this.txtsessin.TabIndex = 0;
            this.txtsessin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsessin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsessin_KeyDown);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(37, 181);
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
            this.Label3.Location = new System.Drawing.Point(89, 126);
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
            this.Label2.Location = new System.Drawing.Point(57, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(119, 19);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Session Name";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnSave);
            this.GroupBox3.Controls.Add(this.Button1);
            this.GroupBox3.Controls.Add(this.btnUpdate);
            this.GroupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(269, 300);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(206, 55);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(112, 15);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(80, 34);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "&Close";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(14, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // New_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button1;
            this.ClientSize = new System.Drawing.Size(739, 501);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Session";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Activated += new System.EventHandler(this.New_Session_Activated);
            this.Deactivate += new System.EventHandler(this.New_Session_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_Session_FormClosing);
            this.Load += new System.EventHandler(this.New_Session_Load);
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000AD7 RID: 2775
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel Panel1;

		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label5;

		private System.Windows.Forms.GroupBox GroupBox2;
		private System.Windows.Forms.GroupBox GroupBox3;

		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.TextBox txtsessin;

		private System.Windows.Forms.ComboBox txtcommi;
		private System.Windows.Forms.DateTimePicker dtpdate;

		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
    }
}
