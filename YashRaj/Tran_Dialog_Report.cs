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
	// Token: 0x020000A5 RID: 165
	[DesignerGenerated]
	public partial class Tran_Dialog_Report : Form
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x003A6958 File Offset: 0x003A4D58
		public Tran_Dialog_Report()
		{
			base.Load += this.Tran_Dialog_Report_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x003A6AF8 File Offset: 0x003A4EF8
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x003A6B0C File Offset: 0x003A4F0C
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

		// Token: 0x06001F93 RID: 8083 RVA: 0x003A6B18 File Offset: 0x003A4F18
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x003A6B28 File Offset: 0x003A4F28
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x003A6B38 File Offset: 0x003A4F38
		private void Tran_Dialog_Report_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000CB9 RID: 3257
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;
	}
}
