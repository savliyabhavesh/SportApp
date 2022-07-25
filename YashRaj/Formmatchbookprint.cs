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
	// Token: 0x0200009C RID: 156
	[DesignerGenerated]
	public partial class Formmatchbookprint : Form
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x003A5A64 File Offset: 0x003A3E64
		public Formmatchbookprint()
		{
			base.Load += this.Formmatchbookprint_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x003A5BE0 File Offset: 0x003A3FE0
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x003A5BF4 File Offset: 0x003A3FF4
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

		// Token: 0x06001F42 RID: 8002 RVA: 0x003A5C00 File Offset: 0x003A4000
		private void Formmatchbookprint_Load(object sender, EventArgs e)
		{
			this.CrystalReportViewer1.PrintReport();
			this.Close();
		}

		// Token: 0x04000CA4 RID: 3236
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;
	}
}
