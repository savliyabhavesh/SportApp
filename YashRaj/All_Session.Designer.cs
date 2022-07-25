namespace YashAksh
{
	// Token: 0x0200000B RID: 11
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class All_Session : System.Windows.Forms.Form
	{
		// Token: 0x06000384 RID: 900 RVA: 0x0029CD9C File Offset: 0x0029B19C
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



		// Token: 0x06000385 RID: 901 RVA: 0x0029CDDC File Offset: 0x0029B1DC
		//[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button1 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.BtnUnDeclare = new System.Windows.Forms.Button();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsessinID = new System.Windows.Forms.TextBox();
            this.txttyp = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.txtunde = new System.Windows.Forms.TextBox();
            this.txtdeclar = new System.Windows.Forms.TextBox();
            this.sessionmdi = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(666, 33);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(78, 34);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "&Exit";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(464, 33);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 34);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Blue;
            this.btnmodify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.White;
            this.btnmodify.Location = new System.Drawing.Point(368, 33);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(89, 34);
            this.btnmodify.TabIndex = 4;
            this.btnmodify.Text = "&Modify";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // BtnUnDeclare
            // 
            this.BtnUnDeclare.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUnDeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnDeclare.Location = new System.Drawing.Point(273, 33);
            this.BtnUnDeclare.Name = "BtnUnDeclare";
            this.BtnUnDeclare.Size = new System.Drawing.Size(88, 34);
            this.BtnUnDeclare.TabIndex = 3;
            this.BtnUnDeclare.Text = "&Un Declare";
            this.BtnUnDeclare.UseVisualStyleBackColor = false;
            this.BtnUnDeclare.Click += new System.EventHandler(this.BtnUnDeclare_Click);
            // 
            // btnDeclare
            // 
            this.btnDeclare.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.Black;
            this.btnDeclare.Location = new System.Drawing.Point(183, 33);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(83, 34);
            this.btnDeclare.TabIndex = 2;
            this.btnDeclare.Text = "De&clare";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // Button13
            // 
            this.Button13.BackColor = System.Drawing.SystemColors.Control;
            this.Button13.Enabled = false;
            this.Button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button13.Location = new System.Drawing.Point(97, 33);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(79, 34);
            this.Button13.TabIndex = 1;
            this.Button13.Text = "&New";
            this.Button13.UseVisualStyleBackColor = false;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // Button14
            // 
            this.Button14.BackColor = System.Drawing.SystemColors.Control;
            this.Button14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button14.Location = new System.Drawing.Point(6, 33);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(84, 34);
            this.Button14.TabIndex = 0;
            this.Button14.Text = "Select";
            this.Button14.UseVisualStyleBackColor = false;
            this.Button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.DataGridView2);
            this.Panel1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Panel1.Location = new System.Drawing.Point(1, 71);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(746, 519);
            this.Panel1.TabIndex = 30;
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToDeleteRows = false;
            this.DataGridView2.AllowUserToOrderColumns = true;
            this.DataGridView2.AllowUserToResizeColumns = false;
            this.DataGridView2.AllowUserToResizeRows = false;
            this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView2.EnableHeadersVisualStyles = false;
            this.DataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView2.Location = new System.Drawing.Point(0, 0);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.RowHeadersWidth = 50;
            this.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size = new System.Drawing.Size(744, 517);
            this.DataGridView2.TabIndex = 9;
            this.DataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView2_KeyDown);
            this.DataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseClick);
            this.DataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseDoubleClick);
            this.DataGridView2.MouseEnter += new System.EventHandler(this.DataGridView2_MouseEnter);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 380;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Result";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 2;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 2;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(128, 664);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 37;
            // 
            // txtsessinID
            // 
            this.txtsessinID.Location = new System.Drawing.Point(22, 636);
            this.txtsessinID.Name = "txtsessinID";
            this.txtsessinID.Size = new System.Drawing.Size(100, 22);
            this.txtsessinID.TabIndex = 36;
            // 
            // txttyp
            // 
            this.txttyp.Location = new System.Drawing.Point(352, 636);
            this.txttyp.Name = "txttyp";
            this.txttyp.Size = new System.Drawing.Size(100, 22);
            this.txttyp.TabIndex = 35;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(570, 636);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(106, 22);
            this.TextBox1.TabIndex = 34;
            // 
            // txtunde
            // 
            this.txtunde.Location = new System.Drawing.Point(458, 636);
            this.txtunde.Name = "txtunde";
            this.txtunde.Size = new System.Drawing.Size(106, 22);
            this.txtunde.TabIndex = 33;
            this.txtunde.Text = "UnDeclare";
            // 
            // txtdeclar
            // 
            this.txtdeclar.Location = new System.Drawing.Point(240, 636);
            this.txtdeclar.Name = "txtdeclar";
            this.txtdeclar.Size = new System.Drawing.Size(106, 22);
            this.txtdeclar.TabIndex = 32;
            this.txtdeclar.Text = "Declare";
            // 
            // sessionmdi
            // 
            this.sessionmdi.Location = new System.Drawing.Point(128, 636);
            this.sessionmdi.Name = "sessionmdi";
            this.sessionmdi.Size = new System.Drawing.Size(106, 22);
            this.sessionmdi.TabIndex = 31;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(12, 636);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1340, 54);
            this.Panel2.TabIndex = 38;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1276, 30);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Session Report";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.Button4);
            this.Panel4.Controls.Add(this.Button3);
            this.Panel4.Controls.Add(this.DateTimePicker2);
            this.Panel4.Controls.Add(this.DateTimePicker1);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(747, 71);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(244, 106);
            this.Panel4.TabIndex = 40;
            this.Panel4.Visible = false;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(157, 69);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 29);
            this.Button4.TabIndex = 32;
            this.Button4.Text = "No";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(66, 69);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 29);
            this.Button3.TabIndex = 31;
            this.Button3.Text = "Yes";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker2.Location = new System.Drawing.Point(66, 39);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(166, 26);
            this.DateTimePicker2.TabIndex = 3;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(66, 7);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(166, 26);
            this.DateTimePicker1.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(25, 43);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 19);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "To :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(4, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 19);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "From :";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button2.Location = new System.Drawing.Point(557, 33);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(102, 34);
            this.Button2.TabIndex = 41;
            this.Button2.Text = "Delete Session";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // All_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button1;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtsessinID);
            this.Controls.Add(this.BtnUnDeclare);
            this.Controls.Add(this.txttyp);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.txtunde);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this.txtdeclar);
            this.Controls.Add(this.sessionmdi);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "All_Session";
            this.Text = "All_Session";
            this.Load += new System.EventHandler(this.All_Session_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400019F RID: 415
		private System.ComponentModel.IContainer components;

		private System.Windows.Forms.DataGridView DataGridView2;

		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.Button Button4;
		private System.Windows.Forms.Button Button13;
		private System.Windows.Forms.Button Button14;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnmodify;
		private System.Windows.Forms.Button btnDeclare;
		private System.Windows.Forms.Button BtnUnDeclare;

		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Panel Panel3;
		private System.Windows.Forms.Panel Panel4;

		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label3;

		private System.Windows.Forms.DateTimePicker DateTimePicker1;
		private System.Windows.Forms.DateTimePicker DateTimePicker2;

		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.TextBox txtsessinID;
		private System.Windows.Forms.TextBox txttyp;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.TextBox txtunde;
		private System.Windows.Forms.TextBox txtdeclar;
		private System.Windows.Forms.TextBox sessionmdi;

	}
}
