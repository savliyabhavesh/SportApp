namespace YashAksh
{
	// Token: 0x020000A5 RID: 165
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Tran_Dialog_Report : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F8F RID: 8079 RVA: 0x003A697C File Offset: 0x003A4D7C
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

		// Token: 0x06001F90 RID: 8080 RVA: 0x003A69BC File Offset: 0x003A4DBC
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
			global::System.Drawing.Size size = new global::System.Drawing.Size(1148, 386);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 0;
			this.CrystalReportViewer1.ViewTimeSelectionFormula = "";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1148, 386);
			this.ClientSize = size;
			this.Controls.Add(this.CrystalReportViewer1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Tran_Dialog_Report";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tran_Dialog_Report";
			this.ResumeLayout(false);
		}

		// Token: 0x04000CB8 RID: 3256
		private global::System.ComponentModel.IContainer components;
	}
}
