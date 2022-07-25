namespace YashAksh
{
	// Token: 0x020000A1 RID: 161
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Hawla_Print : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x003A65C0 File Offset: 0x003A49C0
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

		// Token: 0x06001F69 RID: 8041 RVA: 0x003A6600 File Offset: 0x003A4A00
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.HReport1 = new global::YashAksh.HReport();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = this.HReport1;
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1158, 394);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1158, 394);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.Name = "Hawla_Print";
			this.Text = "Hawla_Print";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CB2 RID: 3250
		private global::System.ComponentModel.IContainer components;
	}
}
