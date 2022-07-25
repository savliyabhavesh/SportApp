using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x02000052 RID: 82
	[DesignerGenerated]
	public partial class MSG_ALL : Form
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x00357620 File Offset: 0x00355A20
		public MSG_ALL()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00357A1C File Offset: 0x00355E1C
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x00357A30 File Offset: 0x00355E30
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00357A3C File Offset: 0x00355E3C
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x00357A50 File Offset: 0x00355E50
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00357A5C File Offset: 0x00355E5C
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x00357A70 File Offset: 0x00355E70
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00357A7C File Offset: 0x00355E7C
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x00357A90 File Offset: 0x00355E90
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00357ADC File Offset: 0x00355EDC
		private void Button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
		}

		// Token: 0x040008AF RID: 2223
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008B0 RID: 2224
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040008B1 RID: 2225
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040008B2 RID: 2226
		[AccessedThroughProperty("Button1")]
		private Button _Button1;
	}
}
