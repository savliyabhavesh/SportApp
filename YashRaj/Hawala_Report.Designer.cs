namespace YashAksh
{
	
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Hawala_Report : System.Windows.Forms.Form
	{
		
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

		
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnu = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(1046, 30);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(91, 34);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "&Exit";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button2.Location = new System.Drawing.Point(937, 32);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(91, 31);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "&Print";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button1.Location = new System.Drawing.Point(832, 32);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(91, 31);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "&Show";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.ModifyDate,
            this.ModifyTime});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1335, 535);
            this.DataGridView1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1339, 27);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Transaction Report";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnu
            // 
            this.txtnu.Location = new System.Drawing.Point(1030, 299);
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(100, 20);
            this.txtnu.TabIndex = 4;
            this.txtnu.Text = ".000";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.DataGridView1);
            this.Panel1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Panel1.Location = new System.Drawing.Point(0, 69);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1335, 535);
            this.Panel1.TabIndex = 5;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(539, 37);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(124, 26);
            this.dtpTo.TabIndex = 33;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(505, 40);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 19);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(371, 37);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(122, 26);
            this.dtpFrom.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(316, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "From";
            // 
            // txtPartyName
            // 
            this.txtPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPartyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtPartyName.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPartyName.FormattingEnabled = true;
            this.txtPartyName.Location = new System.Drawing.Point(107, 34);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(203, 30);
            this.txtPartyName.TabIndex = 46;
            this.txtPartyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartyName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Party Name";
            // 
            // chkDeleted
            // 
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.BackColor = System.Drawing.Color.Transparent;
            this.chkDeleted.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleted.ForeColor = System.Drawing.Color.Red;
            this.chkDeleted.Location = new System.Drawing.Point(679, 39);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(125, 23);
            this.chkDeleted.TabIndex = 61;
            this.chkDeleted.Text = "Only Deleted";
            this.chkDeleted.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Credit (Jama)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Debit (Name)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Remark";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 240;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Entry Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Entry Time";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // ModifyDate
            // 
            this.ModifyDate.HeaderText = "Modify Date";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ReadOnly = true;
            this.ModifyDate.Width = 120;
            // 
            // ModifyTime
            // 
            this.ModifyTime.HeaderText = "Modify Time";
            this.ModifyTime.Name = "ModifyTime";
            this.ModifyTime.ReadOnly = true;
            this.ModifyTime.Width = 120;
            // 
            // Hawala_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button3;
            this.ClientSize = new System.Drawing.Size(1339, 698);
            this.Controls.Add(this.chkDeleted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hawala_Report";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hawala_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hawala_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hawala_Report_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.DataGridView DataGridView1;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox txtnu;
		private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtPartyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyTime;
    }
}
