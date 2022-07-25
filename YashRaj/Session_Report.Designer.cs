namespace YashAksh
{
	// Token: 0x020000C5 RID: 197
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Session_Report : System.Windows.Forms.Form
	{
		// Token: 0x060020D8 RID: 8408 RVA: 0x003A6D6C File Offset: 0x003A516C
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

		// Token: 0x060020D9 RID: 8409 RVA: 0x003A6DAC File Offset: 0x003A51AC
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.BtnUnDeclare = new System.Windows.Forms.Button();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtunde = new System.Windows.Forms.TextBox();
            this.txtdeclar = new System.Windows.Forms.TextBox();
            this.sessionmdi = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.txttyp = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtMatchId = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(702, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "SESSION REPORT";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Button1);
            this.GroupBox3.Controls.Add(this.btndelete);
            this.GroupBox3.Controls.Add(this.btnmodify);
            this.GroupBox3.Controls.Add(this.BtnUnDeclare);
            this.GroupBox3.Controls.Add(this.btnDeclare);
            this.GroupBox3.Controls.Add(this.Button13);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(1, 32);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(701, 53);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(551, 11);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(87, 34);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "&Exit";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(450, 11);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(87, 34);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Blue;
            this.btnmodify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.White;
            this.btnmodify.Location = new System.Drawing.Point(349, 11);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(87, 34);
            this.btnmodify.TabIndex = 4;
            this.btnmodify.Text = "&Modify";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // BtnUnDeclare
            // 
            this.BtnUnDeclare.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUnDeclare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnDeclare.Location = new System.Drawing.Point(248, 11);
            this.BtnUnDeclare.Name = "BtnUnDeclare";
            this.BtnUnDeclare.Size = new System.Drawing.Size(87, 34);
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
            this.btnDeclare.Location = new System.Drawing.Point(147, 11);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(87, 34);
            this.btnDeclare.TabIndex = 2;
            this.btnDeclare.Text = "De&clare";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // Button13
            // 
            this.Button13.BackColor = System.Drawing.SystemColors.Control;
            this.Button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button13.Location = new System.Drawing.Point(44, 11);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(87, 34);
            this.Button13.TabIndex = 1;
            this.Button13.Text = "&New";
            this.Button13.UseVisualStyleBackColor = false;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
            this.DataGridView2.AllowUserToResizeColumns = false;
            this.DataGridView2.AllowUserToResizeRows = false;
            this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView2.ColumnHeadersHeight = 27;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView2.EnableHeadersVisualStyles = false;
            this.DataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView2.Location = new System.Drawing.Point(0, 0);
            this.DataGridView2.MultiSelect = false;
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.RowHeadersWidth = 50;
            this.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size = new System.Drawing.Size(700, 462);
            this.DataGridView2.TabIndex = 8;
            this.DataGridView2.SelectionChanged += new System.EventHandler(this.DataGridView2_SelectionChanged);
            this.DataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView2_KeyDown);
            this.DataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseClick);
            this.DataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Result";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SesId";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MatchId";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Comm Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // txtunde
            // 
            this.txtunde.Location = new System.Drawing.Point(455, 555);
            this.txtunde.Name = "txtunde";
            this.txtunde.Size = new System.Drawing.Size(106, 22);
            this.txtunde.TabIndex = 24;
            this.txtunde.Text = "UnDeclare";
            this.txtunde.Visible = false;
            // 
            // txtdeclar
            // 
            this.txtdeclar.Location = new System.Drawing.Point(237, 555);
            this.txtdeclar.Name = "txtdeclar";
            this.txtdeclar.Size = new System.Drawing.Size(106, 22);
            this.txtdeclar.TabIndex = 23;
            this.txtdeclar.Text = "Declare";
            this.txtdeclar.Visible = false;
            // 
            // sessionmdi
            // 
            this.sessionmdi.Location = new System.Drawing.Point(125, 555);
            this.sessionmdi.Name = "sessionmdi";
            this.sessionmdi.Size = new System.Drawing.Size(106, 22);
            this.sessionmdi.TabIndex = 22;
            this.sessionmdi.Visible = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(567, 555);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(106, 22);
            this.TextBox1.TabIndex = 25;
            this.TextBox1.Visible = false;
            // 
            // txttyp
            // 
            this.txttyp.Location = new System.Drawing.Point(349, 555);
            this.txttyp.Name = "txttyp";
            this.txttyp.Size = new System.Drawing.Size(100, 22);
            this.txttyp.TabIndex = 26;
            this.txttyp.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.DataGridView2);
            this.Panel1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Panel1.Location = new System.Drawing.Point(0, 91);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(702, 464);
            this.Panel1.TabIndex = 27;
            // 
            // txtMatchId
            // 
            this.txtMatchId.Location = new System.Drawing.Point(19, 555);
            this.txtMatchId.Name = "txtMatchId";
            this.txtMatchId.Size = new System.Drawing.Size(100, 22);
            this.txtMatchId.TabIndex = 29;
            this.txtMatchId.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(125, 583);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 30;
            this.txtid.Visible = false;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(6, 555);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(684, 81);
            this.Panel2.TabIndex = 31;
            this.Panel2.Visible = false;
            // 
            // Session_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Button1;
            this.ClientSize = new System.Drawing.Size(702, 648);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtMatchId);
            this.Controls.Add(this.txttyp);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.txtunde);
            this.Controls.Add(this.txtdeclar);
            this.Controls.Add(this.sessionmdi);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Session_Report";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Session_Report_Activated);
            this.Load += new System.EventHandler(this.Session_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Session_Report_KeyDown);
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000CBC RID: 3260
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.GroupBox GroupBox3;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnmodify;
		private System.Windows.Forms.Button BtnUnDeclare;
		private System.Windows.Forms.Button btnDeclare;
		private System.Windows.Forms.Button Button13;
		private System.Windows.Forms.DataGridView DataGridView2;
		private System.Windows.Forms.TextBox txtunde;
		private System.Windows.Forms.TextBox txtdeclar;
		private System.Windows.Forms.TextBox sessionmdi;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.TextBox txttyp;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.TextBox txtMatchId;
		private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
