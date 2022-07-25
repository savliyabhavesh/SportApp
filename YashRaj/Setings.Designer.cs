namespace YashAksh
{
	// Token: 0x020000C8 RID: 200
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Setings : System.Windows.Forms.Form
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x003B0874 File Offset: 0x003AEC74
		[System.Diagnostics.DebuggerNonUserCode]
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

		// Token: 0x060021F3 RID: 8691 RVA: 0x003B08B4 File Offset: 0x003AECB4
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCompanyAccount = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNumberFormat = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNTPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEntryOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkLock = new System.Windows.Forms.CheckBox();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.cmbClinetReport = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel3.Controls.Add(this.Label12);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1000, 30);
            this.Panel3.TabIndex = 2;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(4, 6);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(112, 19);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "User Settings";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpassword.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtpassword.Location = new System.Drawing.Point(203, 124);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(179, 22);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(7, 124);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(90, 22);
            this.Label14.TabIndex = 23;
            this.Label14.Text = "Password";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(204, 321);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 35);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(298, 320);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(85, 35);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(7, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(141, 22);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Decimal Format";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(7, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 22);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Company Account";
            // 
            // txtCompanyAccount
            // 
            this.txtCompanyAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompanyAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompanyAccount.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtCompanyAccount.Location = new System.Drawing.Point(204, 61);
            this.txtCompanyAccount.Name = "txtCompanyAccount";
            this.txtCompanyAccount.Size = new System.Drawing.Size(179, 22);
            this.txtCompanyAccount.TabIndex = 1;
            this.txtCompanyAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyAccount_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(183, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(15, 22);
            this.Label1.TabIndex = 48;
            this.Label1.Text = ":";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(183, 124);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(15, 22);
            this.Label15.TabIndex = 48;
            this.Label15.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(183, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 22);
            this.label13.TabIndex = 49;
            this.label13.Text = ":";
            // 
            // cmbNumberFormat
            // 
            this.cmbNumberFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNumberFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumberFormat.FormattingEnabled = true;
            this.cmbNumberFormat.ItemHeight = 19;
            this.cmbNumberFormat.Items.AddRange(new object[] {
            "FULL AMOUNT",
            ".00",
            ".000"});
            this.cmbNumberFormat.Location = new System.Drawing.Point(204, 24);
            this.cmbNumberFormat.Name = "cmbNumberFormat";
            this.cmbNumberFormat.Size = new System.Drawing.Size(179, 27);
            this.cmbNumberFormat.TabIndex = 0;
            this.cmbNumberFormat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNumberFormat_KeyDown);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmbClinetReport);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.cmbNTPosition);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.cmbEntryOrder);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.chkLock);
            this.GroupBox1.Controls.Add(this.txtOpeningBalance);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.cmbNumberFormat);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.Label15);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtCompanyAccount);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.btnsave);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.txtpassword);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupBox1.Location = new System.Drawing.Point(8, 36);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(394, 389);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // cmbNTPosition
            // 
            this.cmbNTPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNTPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNTPosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNTPosition.FormattingEnabled = true;
            this.cmbNTPosition.ItemHeight = 19;
            this.cmbNTPosition.Items.AddRange(new object[] {
            "TOP",
            "BOTTOM"});
            this.cmbNTPosition.Location = new System.Drawing.Point(206, 190);
            this.cmbNTPosition.Name = "cmbNTPosition";
            this.cmbNTPosition.Size = new System.Drawing.Size(179, 27);
            this.cmbNTPosition.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(183, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 67;
            this.label9.Text = "NT Position";
            // 
            // cmbEntryOrder
            // 
            this.cmbEntryOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEntryOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntryOrder.FormattingEnabled = true;
            this.cmbEntryOrder.ItemHeight = 19;
            this.cmbEntryOrder.Items.AddRange(new object[] {
            "FIRST AMOUNT",
            "FIRST RATE"});
            this.cmbEntryOrder.Location = new System.Drawing.Point(204, 155);
            this.cmbEntryOrder.Name = "cmbEntryOrder";
            this.cmbEntryOrder.Size = new System.Drawing.Size(179, 27);
            this.cmbEntryOrder.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(183, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 65;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Entry Order";
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.BackColor = System.Drawing.Color.Transparent;
            this.chkLock.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkLock.ForeColor = System.Drawing.Color.Red;
            this.chkLock.Location = new System.Drawing.Point(203, 288);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(69, 26);
            this.chkLock.TabIndex = 62;
            this.chkLock.Text = "Lock";
            this.chkLock.UseVisualStyleBackColor = false;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpeningBalance.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtOpeningBalance.Location = new System.Drawing.Point(203, 93);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(179, 22);
            this.txtOpeningBalance.TabIndex = 2;
            this.txtOpeningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpeningBalance_KeyDown);
            this.txtOpeningBalance.Leave += new System.EventHandler(this.txtOpeningBalance_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(183, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 22);
            this.label4.TabIndex = 60;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 58;
            this.label6.Text = "Opening Balance";
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(408, 61);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(10, 22);
            this.txtdate.TabIndex = 66;
            // 
            // cmbClinetReport
            // 
            this.cmbClinetReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinetReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClinetReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClinetReport.FormattingEnabled = true;
            this.cmbClinetReport.ItemHeight = 19;
            this.cmbClinetReport.Items.AddRange(new object[] {
            "TWO",
            "THREE"});
            this.cmbClinetReport.Location = new System.Drawing.Point(207, 225);
            this.cmbClinetReport.Name = "cmbClinetReport";
            this.cmbClinetReport.Size = new System.Drawing.Size(179, 27);
            this.cmbClinetReport.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(184, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 22);
            this.label10.TabIndex = 71;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 22);
            this.label11.TabIndex = 70;
            this.label11.Text = "Agent Report";
            // 
            // Setings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(1000, 713);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.txtdate);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Setings";
            this.Text = "Setings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Setings_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000D35 RID: 3381
		private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtCompanyAccount;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNumberFormat;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.CheckBox chkLock;
        private System.Windows.Forms.ComboBox cmbEntryOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.ComboBox cmbNTPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbClinetReport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
