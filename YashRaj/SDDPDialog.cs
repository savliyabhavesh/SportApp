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
	// Token: 0x020000A4 RID: 164
	[DesignerGenerated]
	public partial class SDDPDialog : Form
	{
		// Token: 0x06001F84 RID: 8068 RVA: 0x003A6758 File Offset: 0x003A4B58
		public SDDPDialog()
		{
			base.Load += this.SDDPDialog_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x003A68F4 File Offset: 0x003A4CF4
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x003A6908 File Offset: 0x003A4D08
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x003A6914 File Offset: 0x003A4D14
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x003A6928 File Offset: 0x003A4D28
		internal virtual SDDPreport SDDPreport1
		{
			get
			{
				return this._SDDPreport1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SDDPreport1 = value;
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x003A6934 File Offset: 0x003A4D34
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x003A6944 File Offset: 0x003A4D44
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x003A6954 File Offset: 0x003A4D54
		private void SDDPDialog_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000CB6 RID: 3254
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000CB7 RID: 3255
		[AccessedThroughProperty("SDDPreport1")]
		private SDDPreport _SDDPreport1;
	}
}
