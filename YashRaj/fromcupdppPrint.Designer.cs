namespace YashAksh
{
	// Token: 0x0200009F RID: 159
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class fromcupdppPrint : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F56 RID: 8022 RVA: 0x003A6004 File Offset: 0x003A4404
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

		// Token: 0x06001F57 RID: 8023 RVA: 0x003A6044 File Offset: 0x003A4444
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.SelectionFormula = "";
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1304, 520);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			this.CrystalReportViewer1.ViewTimeSelectionFormula = "";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1304, 520);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.Name = "fromcupdppPrint";
			this.Text = "fromcupdppPrint";
			this.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
		}

		// Token: 0x04000CAB RID: 3243
		private global::System.ComponentModel.IContainer components;
	}
}
