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
	// Token: 0x020000A1 RID: 161
	[DesignerGenerated]
	public partial class Hawla_Print : Form
	{
		// Token: 0x06001F67 RID: 8039 RVA: 0x003A659C File Offset: 0x003A499C
		public Hawla_Print()
		{
			base.Load += this.Hawla_Print_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x003A6714 File Offset: 0x003A4B14
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x003A6728 File Offset: 0x003A4B28
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x003A6734 File Offset: 0x003A4B34
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x003A6748 File Offset: 0x003A4B48
		internal virtual HReport HReport1
		{
			get
			{
				return this._HReport1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HReport1 = value;
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x003A6754 File Offset: 0x003A4B54
		private void Hawla_Print_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000CB3 RID: 3251
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000CB4 RID: 3252
		[AccessedThroughProperty("HReport1")]
		private HReport _HReport1;
	}
}
