namespace YashAksh
{
    // Token: 0x0200004E RID: 78
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
    public partial class frmRegistrationInfo : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.OK = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.Red;
            this.OK.Location = new System.Drawing.Point(143, 158);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(89, 25);
            this.OK.TabIndex = 5;
            this.OK.Text = "&Update";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(183, 48);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(3, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(163, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "&Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Black;
            this.txtMobileNo.Location = new System.Drawing.Point(183, 80);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(146, 26);
            this.txtMobileNo.TabIndex = 2;
            this.txtMobileNo.TextChanged += new System.EventHandler(this.txtMobileNo_TextChanged);
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMobileNo.ForeColor = System.Drawing.Color.Black;
            this.lblMobileNo.Location = new System.Drawing.Point(3, 82);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(163, 19);
            this.lblMobileNo.TabIndex = 8;
            this.lblMobileNo.Text = "&Mobile No. :";
            this.lblMobileNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRemark.ForeColor = System.Drawing.Color.Black;
            this.txtRemark.Location = new System.Drawing.Point(183, 112);
            this.txtRemark.MaxLength = 20;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(146, 26);
            this.txtRemark.TabIndex = 3;
            // 
            // lblRemark
            // 
            this.lblRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(3, 114);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(163, 19);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "&Remark :";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(238, 157);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(98, 27);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "&Exit";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmRegistrationInfo
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 222);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.OK);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrationInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Information";
            this.Load += new System.EventHandler(this.frmRegistrationInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button Cancel;
    }
}
