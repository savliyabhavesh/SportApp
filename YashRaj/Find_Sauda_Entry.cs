using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x02000041 RID: 65
	[DesignerGenerated]
	public partial class Find_Sauda_Entry : Form
	{
		// Token: 0x06000CDF RID: 3295 RVA: 0x0030AA10 File Offset: 0x00308E10
		public Find_Sauda_Entry()
		{
			base.Load += this.Find_Sauda_Entry_Load;
			base.KeyDown += this.Find_Sauda_Entry_KeyDown;
			this.InitializeComponent();
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0030D224 File Offset: 0x0030B624
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x0030D238 File Offset: 0x0030B638
		internal virtual DataGridView DataGridView1
		{
			get
			{
				return this._DataGridView1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.DataGridView1_MouseClick);
				if (this._DataGridView1 != null)
				{
					this._DataGridView1.MouseClick -= value2;
				}
				this._DataGridView1 = value;
				if (this._DataGridView1 != null)
				{
					this._DataGridView1.MouseClick += value2;
				}
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0030D284 File Offset: 0x0030B684
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x0030D298 File Offset: 0x0030B698
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0030D2A4 File Offset: 0x0030B6A4
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x0030D2B8 File Offset: 0x0030B6B8
		internal virtual RadioButton RA
		{
			get
			{
				return this._RA;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RA = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0030D2C4 File Offset: 0x0030B6C4
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x0030D2D8 File Offset: 0x0030B6D8
		internal virtual RadioButton Rrate
		{
			get
			{
				return this._Rrate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Rrate = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0030D2E4 File Offset: 0x0030B6E4
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0030D2F8 File Offset: 0x0030B6F8
		internal virtual RadioButton Ramunt
		{
			get
			{
				return this._Ramunt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Ramunt = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0030D304 File Offset: 0x0030B704
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0030D318 File Offset: 0x0030B718
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0030D364 File Offset: 0x0030B764
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0030D378 File Offset: 0x0030B778
		internal virtual RadioButton Rteam
		{
			get
			{
				return this._Rteam;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Rteam = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0030D384 File Offset: 0x0030B784
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0030D398 File Offset: 0x0030B798
		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0030D3A4 File Offset: 0x0030B7A4
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x0030D3B8 File Offset: 0x0030B7B8
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0030D404 File Offset: 0x0030B804
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0030D418 File Offset: 0x0030B818
		internal virtual RadioButton SRUN
		{
			get
			{
				return this._SRUN;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SRUN = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0030D424 File Offset: 0x0030B824
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0030D438 File Offset: 0x0030B838
		internal virtual RadioButton SR
		{
			get
			{
				return this._SR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SR = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0030D444 File Offset: 0x0030B844
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x0030D458 File Offset: 0x0030B858
		internal virtual RadioButton SA
		{
			get
			{
				return this._SA;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SA = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0030D464 File Offset: 0x0030B864
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0030D478 File Offset: 0x0030B878
		internal virtual RadioButton SN
		{
			get
			{
				return this._SN;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SN = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0030D484 File Offset: 0x0030B884
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x0030D498 File Offset: 0x0030B898
		internal virtual ComboBox sessionall
		{
			get
			{
				return this._sessionall;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.sessionall_SelectedIndexChanged);
				if (this._sessionall != null)
				{
					this._sessionall.SelectedIndexChanged -= value2;
				}
				this._sessionall = value;
				if (this._sessionall != null)
				{
					this._sessionall.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0030D4E4 File Offset: 0x0030B8E4
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0030D4F8 File Offset: 0x0030B8F8
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0030D504 File Offset: 0x0030B904
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0030D518 File Offset: 0x0030B918
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0030D524 File Offset: 0x0030B924
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0030D538 File Offset: 0x0030B938
		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0030D544 File Offset: 0x0030B944
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x0030D558 File Offset: 0x0030B958
		internal virtual TextBox txtteam
		{
			get
			{
				return this._txtteam;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtteam = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0030D564 File Offset: 0x0030B964
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x0030D578 File Offset: 0x0030B978
		internal virtual TextBox txtrate
		{
			get
			{
				return this._txtrate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtrate = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0030D584 File Offset: 0x0030B984
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0030D598 File Offset: 0x0030B998
		internal virtual TextBox txtamount
		{
			get
			{
				return this._txtamount;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtamount = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0030D5A4 File Offset: 0x0030B9A4
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x0030D5B8 File Offset: 0x0030B9B8
		internal virtual ComboBox txtname
		{
			get
			{
				return this._txtname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.txtname_KeyPress);
				if (this._txtname != null)
				{
					this._txtname.KeyPress -= value2;
				}
				this._txtname = value;
				if (this._txtname != null)
				{
					this._txtname.KeyPress += value2;
				}
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0030D604 File Offset: 0x0030BA04
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0030D618 File Offset: 0x0030BA18
		internal virtual TextBox txtsrun
		{
			get
			{
				return this._txtsrun;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtsrun = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0030D624 File Offset: 0x0030BA24
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0030D638 File Offset: 0x0030BA38
		internal virtual TextBox txtsrate
		{
			get
			{
				return this._txtsrate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtsrate = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0030D644 File Offset: 0x0030BA44
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x0030D658 File Offset: 0x0030BA58
		internal virtual TextBox txtsamount
		{
			get
			{
				return this._txtsamount;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtsamount = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0030D664 File Offset: 0x0030BA64
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0030D678 File Offset: 0x0030BA78
		internal virtual Panel Panel2
		{
			get
			{
				return this._Panel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0030D684 File Offset: 0x0030BA84
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0030D698 File Offset: 0x0030BA98
		internal virtual TextBox testnu
		{
			get
			{
				return this._testnu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._testnu = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0030D6A4 File Offset: 0x0030BAA4
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0030D6B8 File Offset: 0x0030BAB8
		internal virtual DataGridView DataGridView2
		{
			get
			{
				return this._DataGridView2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridView2 = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0030D6C4 File Offset: 0x0030BAC4
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x0030D6D8 File Offset: 0x0030BAD8
		internal virtual DataGridViewTextBoxColumn Column1
		{
			get
			{
				return this._Column1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column1 = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0030D6E4 File Offset: 0x0030BAE4
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x0030D6F8 File Offset: 0x0030BAF8
		internal virtual DataGridViewTextBoxColumn Column2
		{
			get
			{
				return this._Column2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column2 = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0030D704 File Offset: 0x0030BB04
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x0030D718 File Offset: 0x0030BB18
		internal virtual DataGridViewTextBoxColumn Column3
		{
			get
			{
				return this._Column3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column3 = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0030D724 File Offset: 0x0030BB24
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x0030D738 File Offset: 0x0030BB38
		internal virtual DataGridViewTextBoxColumn Column4
		{
			get
			{
				return this._Column4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column4 = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0030D744 File Offset: 0x0030BB44
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x0030D758 File Offset: 0x0030BB58
		internal virtual DataGridViewTextBoxColumn Column5
		{
			get
			{
				return this._Column5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column5 = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0030D764 File Offset: 0x0030BB64
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x0030D778 File Offset: 0x0030BB78
		internal virtual DataGridViewTextBoxColumn Column6
		{
			get
			{
				return this._Column6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column6 = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0030D784 File Offset: 0x0030BB84
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x0030D798 File Offset: 0x0030BB98
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click_1);
				if (this._Button3 != null)
				{
					this._Button3.Click -= value2;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += value2;
				}
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0030D7E4 File Offset: 0x0030BBE4
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0030D7F8 File Offset: 0x0030BBF8
		internal virtual TextBox txtnu
		{
			get
			{
				return this._txtnu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtnu = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0030D804 File Offset: 0x0030BC04
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0030D818 File Offset: 0x0030BC18
		internal virtual DataGridViewTextBoxColumn Column7
		{
			get
			{
				return this._Column7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column7 = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0030D824 File Offset: 0x0030BC24
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x0030D838 File Offset: 0x0030BC38
		internal virtual DataGridViewTextBoxColumn Column8
		{
			get
			{
				return this._Column8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column8 = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0030D844 File Offset: 0x0030BC44
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x0030D858 File Offset: 0x0030BC58
		internal virtual DataGridViewTextBoxColumn Column9
		{
			get
			{
				return this._Column9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column9 = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0030D864 File Offset: 0x0030BC64
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x0030D878 File Offset: 0x0030BC78
		internal virtual DataGridViewTextBoxColumn Column10
		{
			get
			{
				return this._Column10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column10 = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0030D884 File Offset: 0x0030BC84
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0030D898 File Offset: 0x0030BC98
		internal virtual DataGridViewTextBoxColumn Column11
		{
			get
			{
				return this._Column11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column11 = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0030D8A4 File Offset: 0x0030BCA4
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x0030D8B8 File Offset: 0x0030BCB8
		internal virtual DataGridViewTextBoxColumn Column12
		{
			get
			{
				return this._Column12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column12 = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0030D8C4 File Offset: 0x0030BCC4
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0030D8D8 File Offset: 0x0030BCD8
		internal virtual DataGridViewTextBoxColumn Column13
		{
			get
			{
				return this._Column13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column13 = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0030D8E4 File Offset: 0x0030BCE4
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0030D8F8 File Offset: 0x0030BCF8
		internal virtual DataGridViewTextBoxColumn Column14
		{
			get
			{
				return this._Column14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column14 = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0030D904 File Offset: 0x0030BD04
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x0030D918 File Offset: 0x0030BD18
		internal virtual DataGridViewTextBoxColumn Column15
		{
			get
			{
				return this._Column15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column15 = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0030D924 File Offset: 0x0030BD24
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x0030D938 File Offset: 0x0030BD38
		internal virtual DataGridViewTextBoxColumn Column16
		{
			get
			{
				return this._Column16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column16 = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0030D944 File Offset: 0x0030BD44
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0030D958 File Offset: 0x0030BD58
		internal virtual DataGridViewTextBoxColumn Column17
		{
			get
			{
				return this._Column17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column17 = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0030D964 File Offset: 0x0030BD64
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x0030D978 File Offset: 0x0030BD78
		internal virtual DataGridViewTextBoxColumn Column18
		{
			get
			{
				return this._Column18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column18 = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0030D984 File Offset: 0x0030BD84
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x0030D998 File Offset: 0x0030BD98
		internal virtual DataGridViewTextBoxColumn Column19
		{
			get
			{
				return this._Column19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column19 = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0030D9A4 File Offset: 0x0030BDA4
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x0030D9B8 File Offset: 0x0030BDB8
		internal virtual ComboBox txtsid
		{
			get
			{
				return this._txtsid;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtsid = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0030D9C4 File Offset: 0x0030BDC4
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0030D9D8 File Offset: 0x0030BDD8
		internal virtual DataGridView DataGridView3
		{
			get
			{
				return this._DataGridView3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridView3 = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0030D9E4 File Offset: 0x0030BDE4
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x0030D9F8 File Offset: 0x0030BDF8
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
		{
			get
			{
				return this._DataGridViewTextBoxColumn1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn1 = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0030DA04 File Offset: 0x0030BE04
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x0030DA18 File Offset: 0x0030BE18
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
		{
			get
			{
				return this._DataGridViewTextBoxColumn2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn2 = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0030DA24 File Offset: 0x0030BE24
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0030DA38 File Offset: 0x0030BE38
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
		{
			get
			{
				return this._DataGridViewTextBoxColumn3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn3 = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0030DA44 File Offset: 0x0030BE44
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0030DA58 File Offset: 0x0030BE58
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
		{
			get
			{
				return this._DataGridViewTextBoxColumn4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn4 = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0030DA64 File Offset: 0x0030BE64
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0030DA78 File Offset: 0x0030BE78
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
		{
			get
			{
				return this._DataGridViewTextBoxColumn5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn5 = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0030DA84 File Offset: 0x0030BE84
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0030DA98 File Offset: 0x0030BE98
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
		{
			get
			{
				return this._DataGridViewTextBoxColumn6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn6 = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0030DAA4 File Offset: 0x0030BEA4
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x0030DAB8 File Offset: 0x0030BEB8
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
		{
			get
			{
				return this._DataGridViewTextBoxColumn7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn7 = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0030DAC4 File Offset: 0x0030BEC4
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x0030DAD8 File Offset: 0x0030BED8
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
		{
			get
			{
				return this._DataGridViewTextBoxColumn8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn8 = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0030DAE4 File Offset: 0x0030BEE4
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x0030DAF8 File Offset: 0x0030BEF8
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
		{
			get
			{
				return this._DataGridViewTextBoxColumn9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn9 = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0030DB04 File Offset: 0x0030BF04
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x0030DB18 File Offset: 0x0030BF18
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
		{
			get
			{
				return this._DataGridViewTextBoxColumn10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn10 = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0030DB24 File Offset: 0x0030BF24
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x0030DB38 File Offset: 0x0030BF38
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
		{
			get
			{
				return this._DataGridViewTextBoxColumn11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn11 = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0030DB44 File Offset: 0x0030BF44
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x0030DB58 File Offset: 0x0030BF58
		internal virtual ComboBox txtsname
		{
			get
			{
				return this._txtsname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.txtsname_KeyPress);
				if (this._txtsname != null)
				{
					this._txtsname.KeyPress -= value2;
				}
				this._txtsname = value;
				if (this._txtsname != null)
				{
					this._txtsname.KeyPress += value2;
				}
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0030DBA4 File Offset: 0x0030BFA4
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0030DBB8 File Offset: 0x0030BFB8
		internal virtual Panel Panel3
		{
			get
			{
				return this._Panel3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel3 = value;
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0030DBC4 File Offset: 0x0030BFC4
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0030DBCC File Offset: 0x0030BFCC
		private void Find_Sauda_Entry_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0030DBE0 File Offset: 0x0030BFE0
		private void Find_Sauda_Entry_Load(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Open)
				{
					Module1.conn.Close();
				}
				this.combolod();
				this.matchAll();
				this.testnu.Hide();
				this.SN.Checked = true;
				this.DataGridView2.Hide();
				this.DataGridView3.Hide();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0030DC6C File Offset: 0x0030C06C
		public void matchAll()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "select* from Newmatch";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					int index = this.DataGridView1.Rows.Add();
					this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
					this.DataGridView1.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
					this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
					this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
					this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
					this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[20]);
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0030DE38 File Offset: 0x0030C238
		public void listvieColumname()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "select* from Newmatch where Sr_No=" + this.testnu.Text;
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.DataGridView2.Columns[6].HeaderText = Conversions.ToString(oleDbDataReader[5]);
					this.DataGridView2.Columns[7].HeaderText = Conversions.ToString(oleDbDataReader[6]);
					if (Operators.CompareString(this.DataGridView2.Columns[8].HeaderText, "", false) == 0)
					{
						this.DataGridView2.Columns[8].Visible = false;
					}
					else
					{
						this.DataGridView2.Columns[8].HeaderText = Conversions.ToString(oleDbDataReader[7]);
					}
					if (Operators.CompareString(this.DataGridView2.Columns[9].HeaderText, "", false) == 0)
					{
						this.DataGridView2.Columns[9].Visible = false;
					}
					else
					{
						this.DataGridView2.Columns[9].HeaderText = Conversions.ToString(oleDbDataReader[8]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0030DFF0 File Offset: 0x0030C3F0
		public void combolod()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "select* from Newparty ";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "1", false))
					{
						if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "2", false))
						{
							if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "3", false))
							{
								this.txtname.Items.Add(oleDbDataReader[1].ToString());
								this.txtsname.Items.Add(oleDbDataReader[1].ToString());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0030E0FC File Offset: 0x0030C4FC
		private void Button1_Click(object sender, EventArgs e)
		{
			this.DataGridView2.Rows.Clear();
			this.DataGridView2.Show();
			this.DataGridView3.Hide();
			if (Operators.CompareString(this.testnu.Text, "", false) == 0)
			{
				MessageBox.Show(" Please Select Match");
			}
			else
			{
				if (this.RA.Checked)
				{
					if (Operators.CompareString(this.txtname.Text, "", false) == 0)
					{
						MessageBox.Show("Please Enter Party Name");
					}
					else
					{
						this.listvieColumname();
						this.listlode();
					}
				}
				if (this.Ramunt.Checked)
				{
					if (Operators.CompareString(this.txtamount.Text, "", false) == 0)
					{
						MessageBox.Show("Please Enter Amount");
					}
					else
					{
						this.listvieColumname();
						this.amount_enter();
					}
				}
				if (this.Rrate.Checked)
				{
					if (Operators.CompareString(this.txtrate.Text, "", false) == 0)
					{
						MessageBox.Show("Please Enter Rate");
					}
					else
					{
						this.listvieColumname();
						this.rate_all();
					}
				}
				if (this.Rteam.Checked)
				{
					if (Operators.CompareString(this.txtteam.Text, "", false) == 0)
					{
						MessageBox.Show("Please Enter Team");
					}
					else
					{
						this.listvieColumname();
						this.team_all();
					}
				}
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0030E254 File Offset: 0x0030C654
		public void listlode()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from MatchTrans where m_id=",
					this.testnu.Text,
					" and m_party='",
					this.txtname.Text,
					"'"
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[17], "1", false))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
						this.DataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else
					{
						int index2 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index2].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index2].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
					}
					this.DataGridView2.DefaultCellStyle.Format = this.txtnu.Text;
				}
				this.DataGridView2.DefaultCellStyle.Format = this.txtnu.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0030E88C File Offset: 0x0030CC8C
		public void amount_enter()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from MatchTrans where m_id=",
					this.testnu.Text,
					" and m_amt=",
					this.txtamount.Text,
					""
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[17], "1", false))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
						this.DataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else
					{
						int index2 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index2].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index2].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
					}
					this.DataGridView2.DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0030EEA8 File Offset: 0x0030D2A8
		public void rate_all()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from MatchTrans where m_id=",
					this.testnu.Text,
					" and m_rate=",
					this.txtrate.Text,
					""
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[17], "1", false))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
						this.DataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else
					{
						int index2 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index2].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index2].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
					}
					this.DataGridView2.DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0030F4C4 File Offset: 0x0030D8C4
		public void team_all()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from MatchTrans where m_id=",
					this.testnu.Text,
					" and m_team='",
					this.txtteam.Text,
					"'"
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[17], "1", false))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
						this.DataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else
					{
						int index2 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView2.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView2.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView2.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView2.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView2.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView2.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
						this.DataGridView2.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
						this.DataGridView2.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView2.Rows[index2].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index2].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
					}
					this.DataGridView2.DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0030FAE0 File Offset: 0x0030DEE0
		public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
		{
			checked
			{
				string text;
				if (e.KeyChar == '\b')
				{
					if (this.txtname.SelectionStart <= 1)
					{
						this.txtname.Text = "";
						return;
					}
					if (this.txtname.SelectionLength == 0)
					{
						text = this.txtname.Text.Substring(0, this.txtname.Text.Length - 1);
					}
					else
					{
						text = this.txtname.Text.Substring(0, this.txtname.SelectionStart - 1);
					}
				}
				else if (this.txtname.SelectionLength == 0)
				{
					text = this.txtname.Text + Conversions.ToString(e.KeyChar);
				}
				else
				{
					text = this.txtname.Text.Substring(0, this.txtname.SelectionStart) + Conversions.ToString(e.KeyChar);
				}
				int num = this.txtname.FindString(text);
				if (num != -1)
				{
					this.txtname.SelectedText = "";
					this.txtname.SelectedIndex = num;
					this.txtname.SelectionStart = text.Length;
					this.txtname.SelectionLength = this.txtname.Text.Length;
					e.Handled = true;
				}
				else if (blnLimitToList)
				{
					e.Handled = true;
				}
				else
				{
					e.Handled = false;
				}
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0030FC3C File Offset: 0x0030E03C
		private void txtname_KeyPress(object sender, KeyPressEventArgs e)
		{
			ComboBox txtname = this.txtname;
			this.AutoComplete(ref txtname, e, false);
			this.txtname = txtname;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0030FC64 File Offset: 0x0030E064
		private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			this.testnu.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
			this.sessionall.Items.Clear();
			this.session_show_all();
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0030FCB4 File Offset: 0x0030E0B4
		private void Button3_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0030FCBC File Offset: 0x0030E0BC
		public void session_show_all()
		{
			try
			{
				if (Operators.CompareString(this.testnu.Text, null, false) != 0)
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "select* from ewSession where Match_ID=" + this.testnu.Text + "";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					while (oleDbDataReader.Read())
					{
						this.sessionall.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]));
						this.txtsid.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[0]));
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0030FDB4 File Offset: 0x0030E1B4
		private void sessionall_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtsid.SelectedIndex = this.sessionall.SelectedIndex;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0030FE08 File Offset: 0x0030E208
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.DataGridView2.Hide();
				this.DataGridView3.Show();
				if (Operators.CompareString(this.sessionall.Text, null, false) == 0)
				{
					Interaction.MsgBox(" Please Select Match ?", MsgBoxStyle.OkOnly, null);
				}
				else if (this.SN.Checked)
				{
					if (Operators.CompareString(this.txtsname.Text, "", false) == 0)
					{
						Interaction.MsgBox("Please Enter Party Name", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						this.Enty_Show_all();
					}
				}
				else if (this.SA.Checked)
				{
					if (Operators.CompareString(this.txtsamount.Text, null, false) == 0)
					{
						Interaction.MsgBox("Please Enter Amount", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						this.Enty_Show_all_Amount();
					}
				}
				else if (this.SR.Checked)
				{
					if (Operators.CompareString(this.txtsrate.Text, null, false) == 0)
					{
						Interaction.MsgBox("Please Enter Rate", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						this.Enty_Show_all_Rate();
					}
				}
				else if (this.SRUN.Checked)
				{
					if (Operators.CompareString(this.txtsrun.Text, null, false) == 0)
					{
						Interaction.MsgBox("Please Enter Run", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						this.Enty_Show_all_Run();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0030FF78 File Offset: 0x0030E378
		public void Enty_Show_all()
		{
			try
			{
				this.DataGridView3.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from SessionTrans where S_Sr_No=",
					this.testnu.Text,
					" and Session_ID=",
					this.txtsid.Text,
					" and s_party='",
					this.txtsname.Text,
					"'"
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "1", false))
					{
						int index = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView3.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "0", false))
					{
						int index2 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
					}
					this.DataGridView3.Columns[2].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[3].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[7].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[8].DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00310594 File Offset: 0x0030E994
		public void Enty_Show_all_Amount()
		{
			try
			{
				this.DataGridView3.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from SessionTrans where S_Sr_No=",
					this.testnu.Text,
					" and Session_ID=",
					this.txtsid.Text,
					" and s_amt=",
					this.txtsamount.Text
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "1", false))
					{
						int index = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView3.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "0", false))
					{
						int index2 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
					}
					this.DataGridView3.Columns[2].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[3].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[7].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[8].DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00310BA8 File Offset: 0x0030EFA8
		public void Enty_Show_all_Rate()
		{
			try
			{
				this.DataGridView3.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from SessionTrans where S_Sr_No=",
					this.testnu.Text,
					" and Session_ID=",
					this.txtsid.Text,
					" and s_rate=",
					this.txtsrate.Text
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "1", false))
					{
						int index = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView3.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "0", false))
					{
						int index2 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
					}
					this.DataGridView3.Columns[2].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[3].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[7].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[8].DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x003111BC File Offset: 0x0030F5BC
		public void Enty_Show_all_Run()
		{
			try
			{
				this.DataGridView3.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"select* from SessionTrans where S_Sr_No=",
					this.testnu.Text,
					" and Session_ID=",
					this.txtsid.Text,
					" and S_RUN=",
					this.txtsrun.Text
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "1", false))
					{
						int index = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView3.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "0", false))
					{
						int index2 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
						this.DataGridView3.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
						this.DataGridView3.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
						this.DataGridView3.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
						this.DataGridView3.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
						this.DataGridView3.Rows[index2].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
						this.DataGridView3.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
						this.DataGridView3.Rows[index2].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
						this.DataGridView3.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
						this.DataGridView3.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
					}
					this.DataGridView3.Columns[2].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[3].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[7].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns[8].DefaultCellStyle.Format = this.txtnu.Text;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x003117D0 File Offset: 0x0030FBD0
		public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
		{
			checked
			{
				string text;
				if (e.KeyChar == '\b')
				{
					if (this.txtsname.SelectionStart <= 1)
					{
						this.txtsname.Text = "";
						return;
					}
					if (this.txtsname.SelectionLength == 0)
					{
						text = this.txtsname.Text.Substring(0, this.txtsname.Text.Length - 1);
					}
					else
					{
						text = this.txtsname.Text.Substring(0, this.txtsname.SelectionStart - 1);
					}
				}
				else if (this.txtsname.SelectionLength == 0)
				{
					text = this.txtsname.Text + Conversions.ToString(e.KeyChar);
				}
				else
				{
					text = this.txtsname.Text.Substring(0, this.txtsname.SelectionStart) + Conversions.ToString(e.KeyChar);
				}
				int num = this.txtname.FindString(text);
				if (num != -1)
				{
					this.txtsname.SelectedText = "";
					this.txtsname.SelectedIndex = num;
					this.txtsname.SelectionStart = text.Length;
					this.txtsname.SelectionLength = this.txtsname.Text.Length;
					e.Handled = true;
				}
				else if (blnLimitToList)
				{
					e.Handled = true;
				}
				else
				{
					e.Handled = false;
				}
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0031192C File Offset: 0x0030FD2C
		private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
		{
			ComboBox txtsname = this.txtsname;
			this.AutoComplete11(ref txtsname, e, false);
			this.txtsname = txtsname;
		}

		// Token: 0x0400052E RID: 1326
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x0400052F RID: 1327
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000530 RID: 1328
		[AccessedThroughProperty("RA")]
		private RadioButton _RA;

		// Token: 0x04000531 RID: 1329
		[AccessedThroughProperty("Rrate")]
		private RadioButton _Rrate;

		// Token: 0x04000532 RID: 1330
		[AccessedThroughProperty("Ramunt")]
		private RadioButton _Ramunt;

		// Token: 0x04000533 RID: 1331
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000534 RID: 1332
		[AccessedThroughProperty("Rteam")]
		private RadioButton _Rteam;

		// Token: 0x04000535 RID: 1333
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000536 RID: 1334
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000537 RID: 1335
		[AccessedThroughProperty("SRUN")]
		private RadioButton _SRUN;

		// Token: 0x04000538 RID: 1336
		[AccessedThroughProperty("SR")]
		private RadioButton _SR;

		// Token: 0x04000539 RID: 1337
		[AccessedThroughProperty("SA")]
		private RadioButton _SA;

		// Token: 0x0400053A RID: 1338
		[AccessedThroughProperty("SN")]
		private RadioButton _SN;

		// Token: 0x0400053B RID: 1339
		[AccessedThroughProperty("sessionall")]
		private ComboBox _sessionall;

		// Token: 0x0400053C RID: 1340
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400053D RID: 1341
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400053E RID: 1342
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400053F RID: 1343
		[AccessedThroughProperty("txtteam")]
		private TextBox _txtteam;

		// Token: 0x04000540 RID: 1344
		[AccessedThroughProperty("txtrate")]
		private TextBox _txtrate;

		// Token: 0x04000541 RID: 1345
		[AccessedThroughProperty("txtamount")]
		private TextBox _txtamount;

		// Token: 0x04000542 RID: 1346
		[AccessedThroughProperty("txtname")]
		private ComboBox _txtname;

		// Token: 0x04000543 RID: 1347
		[AccessedThroughProperty("txtsrun")]
		private TextBox _txtsrun;

		// Token: 0x04000544 RID: 1348
		[AccessedThroughProperty("txtsrate")]
		private TextBox _txtsrate;

		// Token: 0x04000545 RID: 1349
		[AccessedThroughProperty("txtsamount")]
		private TextBox _txtsamount;

		// Token: 0x04000546 RID: 1350
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000547 RID: 1351
		[AccessedThroughProperty("testnu")]
		private TextBox _testnu;

		// Token: 0x04000548 RID: 1352
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x04000549 RID: 1353
		[AccessedThroughProperty("Column1")]
		private DataGridViewTextBoxColumn _Column1;

		// Token: 0x0400054A RID: 1354
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x0400054B RID: 1355
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x0400054C RID: 1356
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x0400054D RID: 1357
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x0400054E RID: 1358
		[AccessedThroughProperty("Column6")]
		private DataGridViewTextBoxColumn _Column6;

		// Token: 0x0400054F RID: 1359
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000550 RID: 1360
		[AccessedThroughProperty("txtnu")]
		private TextBox _txtnu;

		// Token: 0x04000551 RID: 1361
		[AccessedThroughProperty("Column7")]
		private DataGridViewTextBoxColumn _Column7;

		// Token: 0x04000552 RID: 1362
		[AccessedThroughProperty("Column8")]
		private DataGridViewTextBoxColumn _Column8;

		// Token: 0x04000553 RID: 1363
		[AccessedThroughProperty("Column9")]
		private DataGridViewTextBoxColumn _Column9;

		// Token: 0x04000554 RID: 1364
		[AccessedThroughProperty("Column10")]
		private DataGridViewTextBoxColumn _Column10;

		// Token: 0x04000555 RID: 1365
		[AccessedThroughProperty("Column11")]
		private DataGridViewTextBoxColumn _Column11;

		// Token: 0x04000556 RID: 1366
		[AccessedThroughProperty("Column12")]
		private DataGridViewTextBoxColumn _Column12;

		// Token: 0x04000557 RID: 1367
		[AccessedThroughProperty("Column13")]
		private DataGridViewTextBoxColumn _Column13;

		// Token: 0x04000558 RID: 1368
		[AccessedThroughProperty("Column14")]
		private DataGridViewTextBoxColumn _Column14;

		// Token: 0x04000559 RID: 1369
		[AccessedThroughProperty("Column15")]
		private DataGridViewTextBoxColumn _Column15;

		// Token: 0x0400055A RID: 1370
		[AccessedThroughProperty("Column16")]
		private DataGridViewTextBoxColumn _Column16;

		// Token: 0x0400055B RID: 1371
		[AccessedThroughProperty("Column17")]
		private DataGridViewTextBoxColumn _Column17;

		// Token: 0x0400055C RID: 1372
		[AccessedThroughProperty("Column18")]
		private DataGridViewTextBoxColumn _Column18;

		// Token: 0x0400055D RID: 1373
		[AccessedThroughProperty("Column19")]
		private DataGridViewTextBoxColumn _Column19;

		// Token: 0x0400055E RID: 1374
		[AccessedThroughProperty("txtsid")]
		private ComboBox _txtsid;

		// Token: 0x0400055F RID: 1375
		[AccessedThroughProperty("DataGridView3")]
		private DataGridView _DataGridView3;

		// Token: 0x04000560 RID: 1376
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

		// Token: 0x04000561 RID: 1377
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

		// Token: 0x04000562 RID: 1378
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

		// Token: 0x04000563 RID: 1379
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

		// Token: 0x04000564 RID: 1380
		[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

		// Token: 0x04000565 RID: 1381
		[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

		// Token: 0x04000566 RID: 1382
		[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

		// Token: 0x04000567 RID: 1383
		[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

		// Token: 0x04000568 RID: 1384
		[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

		// Token: 0x04000569 RID: 1385
		[AccessedThroughProperty("DataGridViewTextBoxColumn10")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

		// Token: 0x0400056A RID: 1386
		[AccessedThroughProperty("DataGridViewTextBoxColumn11")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

		// Token: 0x0400056B RID: 1387
		[AccessedThroughProperty("txtsname")]
		private ComboBox _txtsname;

		// Token: 0x0400056C RID: 1388
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;
	}
}
