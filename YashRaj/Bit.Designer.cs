namespace YashAksh
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Bit : global::System.Windows.Forms.Form
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x002A0068 File Offset: 0x0029E468
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

		// Token: 0x060003E5 RID: 997 RVA: 0x002A00A8 File Offset: 0x0029E4A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.WebBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			this.WebBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control webBrowser = this.WebBrowser1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			webBrowser.Location = location;
			global::System.Windows.Forms.Control webBrowser2 = this.WebBrowser1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(20, 20);
			webBrowser2.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			global::System.Windows.Forms.Control webBrowser3 = this.WebBrowser1;
			size = new global::System.Drawing.Size(1362, 715);
			webBrowser3.Size = size;
			this.WebBrowser1.TabIndex = 0;
			this.WebBrowser1.Url = new global::System.Uri("https://www.betfair.com", global::System.UriKind.Absolute);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1362, 715);
			this.ClientSize = size;
			this.Controls.Add(this.WebBrowser1);
			this.Name = "Bit";
			this.ShowIcon = false;
			this.Text = "Bit";
			this.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
		}

		// Token: 0x040001C6 RID: 454
		private global::System.ComponentModel.IContainer components;
	}
}
