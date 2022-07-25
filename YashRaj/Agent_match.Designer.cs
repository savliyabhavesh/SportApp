namespace YashAksh
{
	// Token: 0x02000009 RID: 9
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Agent_match : System.Windows.Forms.Form
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00280538 File Offset: 0x0027E938
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

		// Token: 0x0600018B RID: 395 RVA: 0x00280578 File Offset: 0x0027E978
		//[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtname1 = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.testnu = new System.Windows.Forms.TextBox();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtnu = new System.Windows.Forms.TextBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.txtname1);
            this.Panel2.Controls.Add(this.btnshow);
            this.Panel2.Controls.Add(this.Button6);
            this.Panel2.Location = new System.Drawing.Point(0, 30);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1049, 40);
            this.Panel2.TabIndex = 33;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 19);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Party Name";
            // 
            // txtname1
            // 
            this.txtname1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtname1.FormattingEnabled = true;
            this.txtname1.Location = new System.Drawing.Point(108, 6);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(169, 24);
            this.txtname1.TabIndex = 22;
            this.txtname1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname1_KeyDown);
            this.txtname1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname1_KeyPress);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.Control;
            this.btnshow.Location = new System.Drawing.Point(406, 1);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(117, 34);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "S&how";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Visible = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(283, 1);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(117, 34);
            this.Button6.TabIndex = 14;
            this.Button6.Text = "E&xit";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1051, 30);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Party Report";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.DataGridView1);
            this.Panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 69);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1049, 340);
            this.Panel1.TabIndex = 32;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridView1.ColumnHeadersHeight = 25;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column19,
            this.Modify,
            this.M_Checked,
            this.M_Chk});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1047, 338);
            this.DataGridView1.TabIndex = 42;
            // 
            // testnu
            // 
            this.testnu.Location = new System.Drawing.Point(926, 416);
            this.testnu.Name = "testnu";
            this.testnu.Size = new System.Drawing.Size(100, 22);
            this.testnu.TabIndex = 31;
            this.testnu.Text = "10";
            this.testnu.Visible = false;
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToAddRows = false;
            this.DataGridView3.AllowUserToDeleteRows = false;
            this.DataGridView3.AllowUserToOrderColumns = true;
            this.DataGridView3.AllowUserToResizeColumns = false;
            this.DataGridView3.AllowUserToResizeRows = false;
            this.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column18,
            this.Column5,
            this.DataGridViewTextBoxColumn2,
            this.Column1});
            this.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView3.EnableHeadersVisualStyles = false;
            this.DataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView3.Location = new System.Drawing.Point(0, 0);
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.ReadOnly = true;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.RowTemplate.Height = 23;
            this.DataGridView3.Size = new System.Drawing.Size(523, 147);
            this.DataGridView3.TabIndex = 30;
            // 
            // Column18
            // 
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Column18.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Transparent;
            this.DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridViewTextBoxColumn2.HeaderText = "Column14";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(524, 412);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(523, 26);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Total Book";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnu
            // 
            this.txtnu.Location = new System.Drawing.Point(820, 416);
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(100, 22);
            this.txtnu.TabIndex = 42;
            this.txtnu.Text = ".000";
            this.txtnu.Visible = false;
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.DataGridView3);
            this.Panel4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(523, 444);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(525, 149);
            this.Panel4.TabIndex = 44;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(307, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(561, 30);
            this.Label5.TabIndex = 124;
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 20;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sr.No.";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Rate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Favour";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mode";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 30;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Time";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Date";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 110;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 110;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 110;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 110;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 110;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "Modify";
            this.Modify.Name = "Modify";
            this.Modify.Visible = false;
            // 
            // M_Checked
            // 
            this.M_Checked.HeaderText = "M_Checked";
            this.M_Checked.Name = "M_Checked";
            this.M_Checked.Visible = false;
            // 
            // M_Chk
            // 
            this.M_Chk.HeaderText = "M_Chk";
            this.M_Chk.Name = "M_Chk";
            this.M_Chk.Visible = false;
            // 
            // Agent_match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button6;
            this.ClientSize = new System.Drawing.Size(1051, 597);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtnu);
            this.Controls.Add(this.testnu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Agent_match";
            this.Text = "Agent_match";
            this.Activated += new System.EventHandler(this.Agent_match_Activated);
            this.Load += new System.EventHandler(this.Agent_match_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Agent_match_KeyDown);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000B0 RID: 176
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label5;

		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Panel Panel4;

		private System.Windows.Forms.Button btnshow;
		private System.Windows.Forms.Button Button6;

		private System.Windows.Forms.DataGridView DataGridView1;
		private System.Windows.Forms.DataGridView DataGridView3;

        private System.Windows.Forms.ComboBox txtname1;

		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private System.Windows.Forms.TextBox testnu;
		private System.Windows.Forms.TextBox txtnu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Chk;
    }
}
