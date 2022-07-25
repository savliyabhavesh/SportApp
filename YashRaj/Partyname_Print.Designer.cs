namespace YashAksh
{
	// Token: 0x02000062 RID: 98
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Partyname_Print : global::System.Windows.Forms.Form
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x00396EEC File Offset: 0x003952EC
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

		// Token: 0x06001B36 RID: 6966 RVA: 0x00396F2C File Offset: 0x0039532C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.CrystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.CrystalReport11 = new global::YashAksh.CrystalReport1();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label1.BackColor = global::System.Drawing.Color.SteelBlue;
			this.Label1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1276, 27);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Party Report";
			this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.CrystalReportViewer1.ActiveViewIndex = 0;
			this.CrystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.CrystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control crystalReportViewer = this.CrystalReportViewer1;
			location = new global::System.Drawing.Point(0, 27);
			crystalReportViewer.Location = location;
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = this.CrystalReport11;
			global::System.Windows.Forms.Control crystalReportViewer2 = this.CrystalReportViewer1;
			size = new global::System.Drawing.Size(1276, 596);
			crystalReportViewer2.Size = size;
			this.CrystalReportViewer1.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.LightSlateGray;
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(1188, 2);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "&Close";
			this.Button1.UseVisualStyleBackColor = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1276, 623);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.CrystalReportViewer1);
			this.Controls.Add(this.Label1);
			this.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.Name = "Partyname_Print";
			this.Text = "Party Report";
			this.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
		}

		// Token: 0x04000BBB RID: 3003
		private global::System.ComponentModel.IContainer components;
	}
}
