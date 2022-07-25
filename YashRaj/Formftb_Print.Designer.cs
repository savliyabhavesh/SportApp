namespace YashAksh
{
	// Token: 0x02000046 RID: 70
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Formftb_Print : global::System.Windows.Forms.Form
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x0032B700 File Offset: 0x00329B00
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

		// Token: 0x06001085 RID: 4229 RVA: 0x0032B740 File Offset: 0x00329B40
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
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1194, 481);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1194, 481);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.Name = "Formftb_Print";
			this.Text = "Formftb_Print";
			this.ResumeLayout(false);
		}

		// Token: 0x040006DA RID: 1754
		private global::System.ComponentModel.IContainer components;
	}
}
