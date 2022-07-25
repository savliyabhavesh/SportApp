namespace YashAksh
{
	public partial class print_view : System.Windows.Forms.Form
	{
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

		private void InitializeComponent()
		{
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(727, 370);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // print_view
            // 
            this.ClientSize = new System.Drawing.Size(727, 370);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "print_view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.print_view_KeyDown);
            this.ResumeLayout(false);

		}

		private System.ComponentModel.IContainer components;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }

}
