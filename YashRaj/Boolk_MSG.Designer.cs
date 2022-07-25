namespace YashAksh
{
	// Token: 0x0200004F RID: 79
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Boolk_MSG : global::System.Windows.Forms.Form
	{
		// Token: 0x06001495 RID: 5269 RVA: 0x00355F14 File Offset: 0x00354314
		[global::System.Diagnostics.DebuggerNonUserCode]
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

		// Token: 0x06001496 RID: 5270 RVA: 0x00355F54 File Offset: 0x00354354
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::YashAksh.Boolk_MSG));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.Red;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(49, 35);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(199, 18);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "THIS SOFTWARE IS BOLCK";
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(15, 30);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(28, 27);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.Label2.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(12, 71);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(325, 78);
			label4.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Button1.BackColor = global::System.Drawing.Color.Crimson;
			this.Button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.Button1.FlatAppearance.BorderSize = 0;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(125, 152);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 32);
			button2.Size = size;
			this.Button1.TabIndex = 3;
			this.Button1.Text = "&OK";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.BackColor = global::System.Drawing.Color.FromArgb(22, 116, 216);
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Label3.Font = new global::System.Drawing.Font("Arial Black", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new global::System.Drawing.Point(0, 0);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(349, 23);
			label6.Size = size;
			this.Label3.TabIndex = 5;
			this.Label3.Text = "MessageBox";
			this.Label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.AcceptButton = this.Button1;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			size = new global::System.Drawing.Size(349, 188);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Boolk_MSG";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Blocked";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000896 RID: 2198
		private global::System.ComponentModel.IContainer components;
	}
}
