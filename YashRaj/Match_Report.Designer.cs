namespace YashAksh
{
	// Token: 0x02000055 RID: 85
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Match_Report : System.Windows.Forms.Form
	{
		
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

		
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.txtdek = new System.Windows.Forms.TextBox();
            this.listid = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdecl = new System.Windows.Forms.TextBox();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.ForeColor = System.Drawing.Color.Black;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1276, 31);
            this.Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label1.Location = new System.Drawing.Point(8, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Match Report";
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(707, 37);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(82, 34);
            this.Button7.TabIndex = 2;
            this.Button7.Text = "&Exit";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DELETE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DELETE.ForeColor = System.Drawing.Color.White;
            this.DELETE.Location = new System.Drawing.Point(500, 37);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(89, 34);
            this.DELETE.TabIndex = 2;
            this.DELETE.Text = "D&elete";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Blue;
            this.Button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(405, 37);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(87, 34);
            this.Button5.TabIndex = 4;
            this.Button5.Text = "M&odify";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // UnDeclare
            // 
            this.UnDeclare.BackColor = System.Drawing.SystemColors.Control;
            this.UnDeclare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UnDeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UnDeclare.Location = new System.Drawing.Point(308, 37);
            this.UnDeclare.Name = "UnDeclare";
            this.UnDeclare.Size = new System.Drawing.Size(89, 34);
            this.UnDeclare.TabIndex = 3;
            this.UnDeclare.Text = "&Un Declare";
            this.UnDeclare.UseVisualStyleBackColor = false;
            this.UnDeclare.Click += new System.EventHandler(this.UnDeclare_Click);
            // 
            // btnmdeclare
            // 
            this.btnmdeclare.BackColor = System.Drawing.SystemColors.Control;
            this.btnmdeclare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmdeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmdeclare.Location = new System.Drawing.Point(217, 37);
            this.btnmdeclare.Name = "btnmdeclare";
            this.btnmdeclare.Size = new System.Drawing.Size(83, 34);
            this.btnmdeclare.TabIndex = 2;
            this.btnmdeclare.Text = "&Declare";
            this.btnmdeclare.UseVisualStyleBackColor = false;
            this.btnmdeclare.Click += new System.EventHandler(this.btnmdeclare_Click);
            // 
            // btnmatchbook
            // 
            this.btnmatchbook.BackColor = System.Drawing.SystemColors.Control;
            this.btnmatchbook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmatchbook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmatchbook.ForeColor = System.Drawing.Color.Black;
            this.btnmatchbook.Location = new System.Drawing.Point(120, 37);
            this.btnmatchbook.Name = "btnmatchbook";
            this.btnmatchbook.Size = new System.Drawing.Size(89, 34);
            this.btnmatchbook.TabIndex = 1;
            this.btnmatchbook.Text = "&Match Book";
            this.btnmatchbook.UseVisualStyleBackColor = false;
            this.btnmatchbook.Click += new System.EventHandler(this.btnmatchbook_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button1.Location = new System.Drawing.Point(6, 37);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(106, 34);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Select Match";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(20, 738);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(43, 23);
            this.TextBox1.TabIndex = 9;
            this.TextBox1.Text = "CUP";
            this.TextBox1.Visible = false;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(69, 738);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(42, 23);
            this.TextBox2.TabIndex = 10;
            this.TextBox2.Text = "50-50";
            this.TextBox2.Visible = false;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(117, 738);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(54, 23);
            this.TextBox3.TabIndex = 11;
            this.TextBox3.Text = "40-40";
            this.TextBox3.Visible = false;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(177, 737);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(94, 23);
            this.TextBox4.TabIndex = 12;
            this.TextBox4.Text = "TEST";
            this.TextBox4.Visible = false;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(310, 734);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(106, 23);
            this.TextBox5.TabIndex = 13;
            this.TextBox5.Visible = false;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(101, 359);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(106, 23);
            this.TextBox6.TabIndex = 14;
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(177, 768);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(94, 23);
            this.TextBox7.TabIndex = 15;
            this.TextBox7.Text = "20-20";
            this.TextBox7.Visible = false;
            // 
            // txtdek
            // 
            this.txtdek.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtdek.Location = new System.Drawing.Point(310, 774);
            this.txtdek.Name = "txtdek";
            this.txtdek.Size = new System.Drawing.Size(106, 23);
            this.txtdek.TabIndex = 19;
            this.txtdek.Visible = false;
            // 
            // listid
            // 
            this.listid.Location = new System.Drawing.Point(444, 768);
            this.listid.Name = "listid";
            this.listid.Size = new System.Drawing.Size(106, 23);
            this.listid.TabIndex = 20;
            this.listid.Visible = false;
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(135, 209);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(110, 23);
            this.TextBox8.TabIndex = 21;
            this.TextBox8.Text = "CUP";
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
            this.DataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(805, 569);
            this.DataGridView1.TabIndex = 22;
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            this.DataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick_1);
            this.DataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick_1);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Sr_No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Team1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Team2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "Result";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // txtdecl
            // 
            this.txtdecl.Location = new System.Drawing.Point(115, 303);
            this.txtdecl.Name = "txtdecl";
            this.txtdecl.Size = new System.Drawing.Size(110, 23);
            this.txtdecl.TabIndex = 23;
            this.txtdecl.Text = "CUP";
            this.txtdecl.Visible = false;
            // 
            // TextBox11
            // 
            this.TextBox11.Location = new System.Drawing.Point(88, 135);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.Size = new System.Drawing.Size(50, 23);
            this.TextBox11.TabIndex = 26;
            this.TextBox11.Text = "40-40";
            // 
            // TextBox12
            // 
            this.TextBox12.Location = new System.Drawing.Point(88, 168);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(50, 23);
            this.TextBox12.TabIndex = 27;
            this.TextBox12.Text = "20-20";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.DataGridView1);
            this.Panel2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Panel2.Location = new System.Drawing.Point(2, 75);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(805, 570);
            this.Panel2.TabIndex = 28;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button2.Location = new System.Drawing.Point(597, 37);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(102, 34);
            this.Button2.TabIndex = 30;
            this.Button2.Text = "Delete Match";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
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
            this.Panel4.Location = new System.Drawing.Point(813, 75);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(244, 106);
            this.Panel4.TabIndex = 31;
            this.Panel4.Visible = false;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(141, 69);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(65, 29);
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
            this.Button3.Size = new System.Drawing.Size(65, 29);
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
            this.DateTimePicker2.Size = new System.Drawing.Size(140, 26);
            this.DateTimePicker2.TabIndex = 3;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(66, 7);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(140, 26);
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
            // Match_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button7;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.TextBox12);
            this.Controls.Add(this.UnDeclare);
            this.Controls.Add(this.TextBox11);
            this.Controls.Add(this.btnmdeclare);
            this.Controls.Add(this.btnmatchbook);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtdecl);
            this.Controls.Add(this.TextBox8);
            this.Controls.Add(this.listid);
            this.Controls.Add(this.txtdek);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Match_Report";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Match_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximumSizeChanged += new System.EventHandler(this.Match_Report_MaximumSizeChanged);
            this.Activated += new System.EventHandler(this.Match_Report_Activated);
            this.Load += new System.EventHandler(this.Match_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Match_Report_KeyDown);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

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
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.TextBox TextBox2;
		private System.Windows.Forms.TextBox TextBox3;
		private System.Windows.Forms.TextBox TextBox4;
		private System.Windows.Forms.TextBox TextBox5;
		private System.Windows.Forms.TextBox TextBox6;
		private System.Windows.Forms.TextBox TextBox7;
		private System.Windows.Forms.TextBox txtdek;
		private System.Windows.Forms.TextBox listid;
		private System.Windows.Forms.TextBox TextBox8;
		private System.Windows.Forms.DataGridView DataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.TextBox txtdecl;
		private System.Windows.Forms.TextBox TextBox11;
		private System.Windows.Forms.TextBox TextBox12;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Panel Panel4;
		private System.Windows.Forms.Button Button4;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.DateTimePicker DateTimePicker2;
		private System.Windows.Forms.DateTimePicker DateTimePicker1;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
	}
}
