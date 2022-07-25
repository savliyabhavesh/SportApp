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
	// Token: 0x02000046 RID: 70
	[DesignerGenerated]
	public partial class Formftb_Print : Form
	{
		// Token: 0x06001083 RID: 4227 RVA: 0x0032B6DC File Offset: 0x00329ADC
		public Formftb_Print()
		{
			base.Load += this.Formftb_Print_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0032B838 File Offset: 0x00329C38
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x0032B84C File Offset: 0x00329C4C
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

		// Token: 0x06001088 RID: 4232 RVA: 0x0032B858 File Offset: 0x00329C58
		private void Formftb_Print_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040006DB RID: 1755
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;
	}
}
