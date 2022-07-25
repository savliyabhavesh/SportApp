namespace YashAksh
{
    // Token: 0x020000C5 RID: 197
    //[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
    public partial class frmLicenseInfo : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateKey = new System.Windows.Forms.Button();
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
            this.Label1.Size = new System.Drawing.Size(509, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "License Information";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnUpdateKey);
            this.GroupBox3.Controls.Add(this.btnExit);
            this.GroupBox3.Controls.Add(this.btnDeleteAll);
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(1, 32);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(505, 53);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(316, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(105, 11);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(87, 34);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "&Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btndeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(4, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
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
            this.DataGridView2.ColumnHeadersHeight = 27;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.Column1});
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
            this.DataGridView2.MultiSelect = false;
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.RowHeadersWidth = 50;
            this.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size = new System.Drawing.Size(507, 375);
            this.DataGridView2.TabIndex = 8;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
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
            this.Panel1.Size = new System.Drawing.Size(509, 377);
            this.Panel1.TabIndex = 27;
            // 
            // btnUpdateKey
            // 
            this.btnUpdateKey.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnUpdateKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKey.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateKey.Location = new System.Drawing.Point(206, 11);
            this.btnUpdateKey.Name = "btnUpdateKey";
            this.btnUpdateKey.Size = new System.Drawing.Size(96, 34);
            this.btnUpdateKey.TabIndex = 7;
            this.btnUpdateKey.Text = "&Update Key";
            this.btnUpdateKey.UseVisualStyleBackColor = false;
            this.btnUpdateKey.Click += new System.EventHandler(this.btnUpdateKey_Click);
            // 
            // frmLicenseInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(509, 469);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseInfo";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Session_Report_Load);
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Token: 0x04000CBC RID: 3260
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnUpdateKey;
    }
}
