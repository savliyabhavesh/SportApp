
namespace YashAksh
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Dialog_PriDATA : System.Windows.Forms.Form
	{
		[System.Diagnostics.DebuggerNonUserCode]
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

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
//			this.Privesdata1 = new YashAksh.Privesdata();
			this.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			//System.Drawing.Point location = new System.Drawing.Point(0, 0);
			//crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			//this.CrystalReportViewer1.ReportSource = this.Privesdata1;
			System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			//System.Drawing.Size size = new System.Drawing.Size(1128, 376);
			//crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.Size = new System.Drawing.Size(1128, 376);
			this.CrystalReportViewer1.TabIndex = 0;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//size = new System.Drawing.Size(1128, 376);
			//this.ClientSize = size;
			this.ClientSize = new System.Drawing.Size(1128, 376);
			this.Controls.Add(this.CrystalReportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dialog_PriDATA";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dialog_PriDATA";
			this.ResumeLayout(false);
		}

		private System.ComponentModel.IContainer components;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
		//private YashAksh.Privesdata Privesdata1;
	}
}
