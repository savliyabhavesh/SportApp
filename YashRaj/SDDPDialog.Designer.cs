namespace YashAksh
{
	// Token: 0x020000A4 RID: 164
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SDDPDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F85 RID: 8069 RVA: 0x003A677C File Offset: 0x003A4B7C
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

		// Token: 0x06001F86 RID: 8070 RVA: 0x003A67BC File Offset: 0x003A4BBC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SDDPreport1 = new global::YashAksh.SDDPreport();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = this.SDDPreport1;
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1176, 426);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1176, 426);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SDDPDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SDDPDialog";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CB5 RID: 3253
		private global::System.ComponentModel.IContainer components;
	}
}
