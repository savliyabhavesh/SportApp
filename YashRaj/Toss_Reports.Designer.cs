namespace YashAksh
{
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Toss_Reports : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.UnDeclare = new System.Windows.Forms.Button();
            this.btnmdeclare = new System.Windows.Forms.Button();
            this.btnmatchbook = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.txtdecl = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.ForeColor = System.Drawing.Color.Black;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1276, 29);
            this.Panel1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(5, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Toss Report";
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(650, 34);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(87, 34);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "&Exit";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DELETE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.Color.White;
            this.DELETE.Location = new System.Drawing.Point(557, 34);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(87, 34);
            this.DELETE.TabIndex = 9;
            this.DELETE.Text = "D&elete";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Blue;
            this.Button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(461, 34);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(88, 34);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "M&odify";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // UnDeclare
            // 
            this.UnDeclare.BackColor = System.Drawing.SystemColors.Control;
            this.UnDeclare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UnDeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnDeclare.Location = new System.Drawing.Point(362, 34);
            this.UnDeclare.Name = "UnDeclare";
            this.UnDeclare.Size = new System.Drawing.Size(91, 34);
            this.UnDeclare.TabIndex = 10;
            this.UnDeclare.Text = "&Un Declare";
            this.UnDeclare.UseVisualStyleBackColor = false;
            this.UnDeclare.Click += new System.EventHandler(this.UnDeclare_Click);
            // 
            // btnmdeclare
            // 
            this.btnmdeclare.BackColor = System.Drawing.SystemColors.Control;
            this.btnmdeclare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmdeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmdeclare.Location = new System.Drawing.Point(263, 34);
            this.btnmdeclare.Name = "btnmdeclare";
            this.btnmdeclare.Size = new System.Drawing.Size(91, 34);
            this.btnmdeclare.TabIndex = 7;
            this.btnmdeclare.Text = "&Declare";
            this.btnmdeclare.UseVisualStyleBackColor = false;
            this.btnmdeclare.Click += new System.EventHandler(this.btnmdeclare_Click);
            // 
            // btnmatchbook
            // 
            this.btnmatchbook.BackColor = System.Drawing.SystemColors.Control;
            this.btnmatchbook.Enabled = false;
            this.btnmatchbook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmatchbook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatchbook.ForeColor = System.Drawing.Color.Black;
            this.btnmatchbook.Location = new System.Drawing.Point(163, 34);
            this.btnmatchbook.Name = "btnmatchbook";
            this.btnmatchbook.Size = new System.Drawing.Size(92, 34);
            this.btnmatchbook.TabIndex = 6;
            this.btnmatchbook.Text = "&Match Book";
            this.btnmatchbook.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(55, 34);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 34);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "&Select Toss";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.DataGridView1);
            this.Panel2.Controls.Add(this.TextBox6);
            this.Panel2.Controls.Add(this.TextBox5);
            this.Panel2.Controls.Add(this.txtdecl);
            this.Panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Panel2.Location = new System.Drawing.Point(1, 71);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(805, 570);
            this.Panel2.TabIndex = 29;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(805, 569);
            this.DataGridView1.TabIndex = 22;
            this.DataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_MouseClick_1);
            this.DataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_MouseDoubleClick);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Sr_No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Team1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Team2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "Result";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(642, 75);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(106, 26);
            this.TextBox6.TabIndex = 31;
            this.TextBox6.Visible = false;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(642, 46);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(106, 26);
            this.TextBox5.TabIndex = 30;
            this.TextBox5.Visible = false;
            // 
            // txtdecl
            // 
            this.txtdecl.Location = new System.Drawing.Point(642, 104);
            this.txtdecl.Name = "txtdecl";
            this.txtdecl.Size = new System.Drawing.Size(106, 26);
            this.txtdecl.TabIndex = 33;
            this.txtdecl.Visible = false;
            // 
            // Toss_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.UnDeclare);
            this.Controls.Add(this.btnmdeclare);
            this.Controls.Add(this.btnmatchbook);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Toss_Reports";
            this.Text = "Toss_Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Toss_Reports_Activated);
            this.Load += new System.EventHandler(this.Toss_Reports_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Toss_Reports_KeyDown);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000E5F RID: 3679
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button Button7;
		private System.Windows.Forms.Button DELETE;
		private System.Windows.Forms.Button Button5;
		private System.Windows.Forms.Button UnDeclare;
		private System.Windows.Forms.Button btnmdeclare;
		private System.Windows.Forms.Button btnmatchbook;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.DataGridView DataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.TextBox TextBox5;
		private System.Windows.Forms.TextBox TextBox6;
		private System.Windows.Forms.TextBox txtdecl;
	}
}
