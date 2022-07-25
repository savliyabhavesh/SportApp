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
	// Token: 0x0200009E RID: 158
	[DesignerGenerated]
	public partial class fromconect_Report : Form
	{
		// Token: 0x06001F4D RID: 8013 RVA: 0x003A5E14 File Offset: 0x003A4214
		public fromconect_Report()
		{
			base.Load += this.fromconect_Report_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x003A5F8C File Offset: 0x003A438C
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x003A5FA0 File Offset: 0x003A43A0
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x003A5FAC File Offset: 0x003A43AC
		// (set) Token: 0x06001F53 RID: 8019 RVA: 0x003A5FC0 File Offset: 0x003A43C0
		internal virtual C_Report C_Report1
		{
			get
			{
				return this._C_Report1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._C_Report1 = value;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x003A5FCC File Offset: 0x003A43CC
		private void fromconect_Report_Load(object sender, EventArgs e)
		{
			this.CrystalReportViewer1.PrintReport();
			this.Close();
		}

		// Token: 0x04000CA9 RID: 3241
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000CAA RID: 3242
		[AccessedThroughProperty("C_Report1")]
		private C_Report _C_Report1;
	}
}
