using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class Bit : Form
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x002A0044 File Offset: 0x0029E444
		public Bit()
		{
			base.Load += this.Bit_Load;
			this.InitializeComponent();
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x002A01C4 File Offset: 0x0029E5C4
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x002A01D8 File Offset: 0x0029E5D8
		internal virtual WebBrowser WebBrowser1
		{
			get
			{
				return this._WebBrowser1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser1 = value;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x002A01E4 File Offset: 0x0029E5E4
		private void Bit_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040001C7 RID: 455
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;
	}
}
