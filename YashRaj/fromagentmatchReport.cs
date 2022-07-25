using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x0200009D RID: 157
	[DesignerGenerated]
	public partial class fromagentmatchReport : Form
	{
		// Token: 0x06001F43 RID: 8003 RVA: 0x003A5C14 File Offset: 0x003A4014
		public fromagentmatchReport()
		{
			base.Load += this.fromagentmatchReport_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x003A5DB0 File Offset: 0x003A41B0
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x003A5DC4 File Offset: 0x003A41C4
		internal virtual CrystalReportViewer CrystalReportViewer1
		{
			get
			{
				return this._CrystalReportViewer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CrystalReportViewer1 = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x003A5DD0 File Offset: 0x003A41D0
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x003A5DE4 File Offset: 0x003A41E4
		internal virtual mareport mareport1
		{
			get
			{
				return this._mareport1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mareport1 = value;
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x003A5DF0 File Offset: 0x003A41F0
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x003A5E00 File Offset: 0x003A4200
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x003A5E10 File Offset: 0x003A4210
		private void fromagentmatchReport_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000CA6 RID: 3238
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000CA7 RID: 3239
		[AccessedThroughProperty("mareport1")]
		private mareport _mareport1;
	}
}
