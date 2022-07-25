namespace YashAksh
{
	// Token: 0x0200004E RID: 78
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Login : System.Windows.Forms.Form
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblexpirydate = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.UsernameLabel.Location = new System.Drawing.Point(243, 50);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(103, 21);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "&User Name :";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsernameLabel.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(243, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(108, 21);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "&Password :";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(352, 48);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(120, 26);
            this.Username.TabIndex = 1;
            this.Username.Text = "Admin";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Visible = false;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(352, 98);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(120, 23);
            this.Password.TabIndex = 3;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OK.Location = new System.Drawing.Point(284, 149);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(91, 27);
            this.OK.TabIndex = 4;
            this.OK.Text = "&Login";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(381, 149);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 27);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "&Exit";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(617, 33);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "It is totally an  A/C  software. It should not be misused for other reason.\r\nRisk" +
    " should be bared by user for misusing it. Thanks!";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 248);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(617, 33);
            this.Panel1.TabIndex = 7;
            // 
            // lblexpirydate
            // 
            this.lblexpirydate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblexpirydate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblexpirydate.Location = new System.Drawing.Point(12, 203);
            this.lblexpirydate.Name = "lblexpirydate";
            this.lblexpirydate.Size = new System.Drawing.Size(579, 21);
            this.lblexpirydate.TabIndex = 8;
            this.lblexpirydate.Text = "&Remaining Days on License are :  ";
            this.lblexpirydate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblVersion.Location = new System.Drawing.Point(19, 225);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(579, 18);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "version: ";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(617, 281);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblexpirydate);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label lblexpirydate;
        private System.Windows.Forms.Label lblVersion;
    }
}
