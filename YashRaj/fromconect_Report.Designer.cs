namespace YashAksh
{
	// Token: 0x0200009E RID: 158
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class fromconect_Report : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F4E RID: 8014 RVA: 0x003A5E38 File Offset: 0x003A4238
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

		// Token: 0x06001F4F RID: 8015 RVA: 0x003A5E78 File Offset: 0x003A4278
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.C_Report1 = new global::YashAksh.C_Report();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = this.C_Report1;
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(947, 324);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(947, 324);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.Name = "fromconect_Report";
			this.Text = "fromconect_Report";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CA8 RID: 3240
		private global::System.ComponentModel.IContainer components;
	}
}
