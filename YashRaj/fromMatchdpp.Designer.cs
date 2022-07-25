namespace YashAksh
{
	// Token: 0x020000A0 RID: 160
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class fromMatchdpp : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F5E RID: 8030 RVA: 0x003A62BC File Offset: 0x003A46BC
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

		// Token: 0x06001F5F RID: 8031 RVA: 0x003A62FC File Offset: 0x003A46FC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.MatchDPP1 = new global::YashAksh.MatchDPP();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = this.MatchDPP1;
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1276, 564);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1276, 564);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.Name = "fromMatchdpp";
			this.Text = "fromMatchdpp";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CAE RID: 3246
		private global::System.ComponentModel.IContainer components;
	}
}
