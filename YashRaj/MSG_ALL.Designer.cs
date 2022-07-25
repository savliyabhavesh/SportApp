namespace YashAksh
{
	// Token: 0x02000052 RID: 82
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MSG_ALL : global::System.Windows.Forms.Form
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x00357630 File Offset: 0x00355A30
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

		// Token: 0x060014C0 RID: 5312 RVA: 0x00357670 File Offset: 0x00355A70
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::YashAksh.MSG_ALL));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Label1.BackColor = global::System.Drawing.Color.Crimson;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label1.Font = new global::System.Drawing.Font("Arial Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(409, 27);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Title Message";
			this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(12, 57);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(38, 32);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(56, 36);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(346, 132);
			label4.Size = size;
			this.Label2.TabIndex = 2;
			this.Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Button1.BackColor = global::System.Drawing.Color.Crimson;
			this.Button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.Button1.FlatAppearance.BorderSize = 0;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(176, 172);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(79, 27);
			button2.Size = size;
			this.Button1.TabIndex = 3;
			this.Button1.Text = "&OK";
			this.Button1.UseVisualStyleBackColor = false;
			this.AcceptButton = this.Button1;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(9f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(409, 200);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label1);
			this.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MSG_ALL";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040008AE RID: 2222
		private global::System.ComponentModel.IContainer components;
	}
}
