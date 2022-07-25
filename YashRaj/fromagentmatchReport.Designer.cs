namespace YashAksh
{
	// Token: 0x0200009D RID: 157
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class fromagentmatchReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F44 RID: 8004 RVA: 0x003A5C38 File Offset: 0x003A4038
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

		// Token: 0x06001F45 RID: 8005 RVA: 0x003A5C78 File Offset: 0x003A4078
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.mareport1 = new global::YashAksh.mareport();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = this.mareport1;
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1198, 440);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1198, 440);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fromagentmatchReport";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fromagentmatchReport";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CA5 RID: 3237
		private global::System.ComponentModel.IContainer components;
	}
}
