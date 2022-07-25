namespace YashAksh
{
    // Token: 0x02000009 RID: 9
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
    public partial class Agent_Connect : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtname1 = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgvCredit = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDebit = new System.Windows.Forms.DataGridView();
            this.txtneva = new System.Windows.Forms.Label();
            this.txtjuma = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredit)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebit)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Button2);
            this.Panel2.Controls.Add(this.button1);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.txtname1);
            this.Panel2.Controls.Add(this.btnshow);
            this.Panel2.Controls.Add(this.Button6);
            this.Panel2.Location = new System.Drawing.Point(0, 30);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(653, 40);
            this.Panel2.TabIndex = 33;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(520, 1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(63, 34);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "&Print";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(355, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Post To Agent Ledger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(102, 19);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Agent Name";
            // 
            // txtname1
            // 
            this.txtname1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtname1.FormattingEnabled = true;
            this.txtname1.Location = new System.Drawing.Point(108, 6);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(169, 24);
            this.txtname1.TabIndex = 0;
            this.txtname1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname1_KeyDown);
            this.txtname1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname1_KeyPress);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.Control;
            this.btnshow.Location = new System.Drawing.Point(283, 1);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(66, 34);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "S&how";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(589, 1);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(57, 34);
            this.Button6.TabIndex = 3;
            this.Button6.Text = "E&xit";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(655, 30);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Agent Wise Customer";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.dgvCredit);
            this.Panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 71);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(325, 388);
            this.Panel1.TabIndex = 32;
            // 
            // dgvCredit
            // 
            this.dgvCredit.AllowUserToAddRows = false;
            this.dgvCredit.AllowUserToDeleteRows = false;
            this.dgvCredit.AllowUserToResizeColumns = false;
            this.dgvCredit.AllowUserToResizeRows = false;
            this.dgvCredit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ca,
            this.cb});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCredit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCredit.EnableHeadersVisualStyles = false;
            this.dgvCredit.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCredit.Location = new System.Drawing.Point(0, 0);
            this.dgvCredit.Name = "dgvCredit";
            this.dgvCredit.ReadOnly = true;
            this.dgvCredit.RowHeadersVisible = false;
            this.dgvCredit.Size = new System.Drawing.Size(323, 386);
            this.dgvCredit.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvDebit);
            this.panel3.Location = new System.Drawing.Point(329, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 388);
            this.panel3.TabIndex = 125;
            // 
            // dgvDebit
            // 
            this.dgvDebit.AllowUserToAddRows = false;
            this.dgvDebit.AllowUserToDeleteRows = false;
            this.dgvDebit.AllowUserToResizeColumns = false;
            this.dgvDebit.AllowUserToResizeRows = false;
            this.dgvDebit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cc,
            this.cd});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDebit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebit.EnableHeadersVisualStyles = false;
            this.dgvDebit.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDebit.Location = new System.Drawing.Point(0, 0);
            this.dgvDebit.Name = "dgvDebit";
            this.dgvDebit.ReadOnly = true;
            this.dgvDebit.RowHeadersVisible = false;
            this.dgvDebit.Size = new System.Drawing.Size(322, 386);
            this.dgvDebit.TabIndex = 42;
            // 
            // txtneva
            // 
            this.txtneva.BackColor = System.Drawing.Color.Silver;
            this.txtneva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtneva.ForeColor = System.Drawing.Color.Black;
            this.txtneva.Location = new System.Drawing.Point(511, 464);
            this.txtneva.Name = "txtneva";
            this.txtneva.Size = new System.Drawing.Size(134, 28);
            this.txtneva.TabIndex = 130;
            this.txtneva.Text = "0.00";
            this.txtneva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtjuma
            // 
            this.txtjuma.BackColor = System.Drawing.Color.Silver;
            this.txtjuma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjuma.ForeColor = System.Drawing.Color.Black;
            this.txtjuma.Location = new System.Drawing.Point(198, 463);
            this.txtjuma.Name = "txtjuma";
            this.txtjuma.Size = new System.Drawing.Size(121, 28);
            this.txtjuma.TabIndex = 129;
            this.txtjuma.Text = "0.00";
            this.txtjuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Silver;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(329, 462);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(323, 31);
            this.Label9.TabIndex = 128;
            this.Label9.Text = "Debit / Name Total";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Silver;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(1, 462);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(322, 31);
            this.Label7.TabIndex = 127;
            this.Label7.Text = "Credit / Jama Total";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Silver;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(503, 501);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 28);
            this.lblTotal.TabIndex = 132;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(329, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 31);
            this.label6.TabIndex = 131;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ca
            // 
            this.ca.HeaderText = "Name";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            this.ca.Width = 200;
            // 
            // cb
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.cb.DefaultCellStyle = dataGridViewCellStyle2;
            this.cb.HeaderText = "Amount";
            this.cb.Name = "cb";
            this.cb.ReadOnly = true;
            // 
            // cc
            // 
            this.cc.HeaderText = "Name";
            this.cc.Name = "cc";
            this.cc.ReadOnly = true;
            this.cc.Width = 200;
            // 
            // cd
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = null;
            this.cd.DefaultCellStyle = dataGridViewCellStyle5;
            this.cd.HeaderText = "Amount";
            this.cd.Name = "cd";
            this.cd.ReadOnly = true;
            // 
            // Agent_Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.Button6;
            this.ClientSize = new System.Drawing.Size(655, 533);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtjuma);
            this.Controls.Add(this.txtneva);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label9);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agent_Connect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Agent_Connect_Activated);
            this.Load += new System.EventHandler(this.Agent_Connect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Agent_Connect_KeyDown);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredit)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebit)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x040000B0 RID: 176
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel Panel2;

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button Button6;

        private System.Windows.Forms.ComboBox txtname1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView dgvCredit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDebit;
        private System.Windows.Forms.Label txtneva;
        private System.Windows.Forms.Label txtjuma;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd;
    }
}
