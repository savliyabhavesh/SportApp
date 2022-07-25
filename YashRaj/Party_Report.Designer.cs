using System.Windows.Forms;

namespace YashAksh
{
	public partial class Party_Report : Form
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

        private Label Label1;
        private Button btnexit;
        private Button btnprint;
        private Button Button4;
        private Button delete;
        private Button btnmodify;
        private TextBox txtid;
        private ComboBox txtname;
        private ComboBox ComboBox1;
        private Panel Panel3;
        private Panel Panel4;
        private Label Label3;

        private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.ComboBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel4.SuspendLayout();
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
            this.Label1.Size = new System.Drawing.Size(1276, 27);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Party Report";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(868, 31);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 36);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.Control;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnprint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Location = new System.Drawing.Point(969, 31);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(95, 36);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "&Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Visible = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.Control;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.Black;
            this.Button4.Location = new System.Drawing.Point(767, 31);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(95, 36);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "&New Party";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(666, 31);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(95, 36);
            this.delete.TabIndex = 2;
            this.delete.Text = "&Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.Blue;
            this.btnmodify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnmodify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.White;
            this.btnmodify.Location = new System.Drawing.Point(565, 31);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(95, 36);
            this.btnmodify.TabIndex = 1;
            this.btnmodify.Text = "&Modify";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(984, 54);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(80, 23);
            this.txtid.TabIndex = 3;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.FormattingEnabled = true;
            this.txtname.Location = new System.Drawing.Point(127, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(268, 27);
            this.txtname.TabIndex = 0;
            this.txtname.SelectedIndexChanged += new System.EventHandler(this.txtname_SelectedIndexChanged);
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(1085, 69);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ComboBox1.TabIndex = 8;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.DataGridView1);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Panel3.Location = new System.Drawing.Point(0, 77);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1276, 621);
            this.Panel3.TabIndex = 9;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1276, 621);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            this.DataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            this.DataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.label2);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.Label1);
            this.Panel4.Controls.Add(this.txtname);
            this.Panel4.Controls.Add(this.btnmodify);
            this.Panel4.Controls.Add(this.delete);
            this.Panel4.Controls.Add(this.Button4);
            this.Panel4.Controls.Add(this.btnprint);
            this.Panel4.Controls.Add(this.btnexit);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1276, 77);
            this.Panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "PartyName";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(404, 37);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(0, 23);
            this.Label3.TabIndex = 11;
            // 
            // Party_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(1276, 698);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Party_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party_Report";
            this.Activated += new System.EventHandler(this.Party_Report_Activated);
            this.Load += new System.EventHandler(this.Party_Report_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components;
        //private BindingSource mYDBDataSetBindingSource;
        //private MY_DBDataSet mY_DBDataSet;
        private DataGridView DataGridView1;
        private Label label2;
    }
}
