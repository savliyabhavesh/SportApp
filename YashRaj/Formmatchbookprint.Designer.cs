namespace YashAksh
{
	// Token: 0x0200009C RID: 156
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Formmatchbookprint : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F3E RID: 7998 RVA: 0x003A5A88 File Offset: 0x003A3E88
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

		// Token: 0x06001F3F RID: 7999 RVA: 0x003A5AC8 File Offset: 0x003A3EC8
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
			global::System.Drawing.Size size = new global::System.Drawing.Size(1102, 421);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			this.CrystalReportViewer1.ViewTimeSelectionFormula = "";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1102, 421);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.Name = "Formmatchbookprint";
			this.Text = "Formmatchbookprint";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CA3 RID: 3235
		private global::System.ComponentModel.IContainer components;
	}
}
