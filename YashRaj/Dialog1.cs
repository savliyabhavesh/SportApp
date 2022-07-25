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
	// Token: 0x0200009A RID: 154
	[DesignerGenerated]
	public partial class Dialog1 : Form
	{
		// Token: 0x06001F29 RID: 7977 RVA: 0x003A5664 File Offset: 0x003A3A64
		public Dialog1()
		{
			base.Load += this.Dialog1_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x003A5800 File Offset: 0x003A3C00
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x003A5814 File Offset: 0x003A3C14
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x003A5820 File Offset: 0x003A3C20
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x003A5834 File Offset: 0x003A3C34
		internal virtual FinalTB_Report FinalTB_Report1
		{
			get
			{
				return this._FinalTB_Report1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FinalTB_Report1 = value;
			}
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x003A5840 File Offset: 0x003A3C40
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x003A5850 File Offset: 0x003A3C50
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x003A5860 File Offset: 0x003A3C60
		private void Dialog1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000C9E RID: 3230
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000C9F RID: 3231
		[AccessedThroughProperty("FinalTB_Report1")]
		private FinalTB_Report _FinalTB_Report1;
	}
}
