using System;
using System.Collections;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x020000C7 RID: 199
	[DesignerGenerated]
	public partial class SessionDelear : Form
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x003AA80C File Offset: 0x003A8C0C
		public SessionDelear()
		{
			base.Activated += this.SessionDelear_Activated;
			base.Load += this.SessionDelear_Load;
			this.txtid1 = new TextBox();
			this.InitializeComponent();
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x003ACE84 File Offset: 0x003AB284
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x003ACE98 File Offset: 0x003AB298
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

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x003ACEE4 File Offset: 0x003AB2E4
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x003ACEF8 File Offset: 0x003AB2F8
		internal virtual Button Save
		{
			get
			{
				return this._Save;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Save_Click);
				if (this._Save != null)
				{
					this._Save.Click -= value2;
				}
				this._Save = value;
				if (this._Save != null)
				{
					this._Save.Click += value2;
				}
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x003ACF44 File Offset: 0x003AB344
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x003ACF58 File Offset: 0x003AB358
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

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x003ACF64 File Offset: 0x003AB364
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x003ACF78 File Offset: 0x003AB378
		internal virtual TextBox txtdeclard
		{
			get
			{
				return this._txtdeclard;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txtdeclard_KeyDown);
				if (this._txtdeclard != null)
				{
					this._txtdeclard.KeyDown -= value2;
				}
				this._txtdeclard = value;
				if (this._txtdeclard != null)
				{
					this._txtdeclard.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x003ACFC4 File Offset: 0x003AB3C4
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x003ACFD8 File Offset: 0x003AB3D8
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

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x003ACFE4 File Offset: 0x003AB3E4
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x003ACFF8 File Offset: 0x003AB3F8
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x003AD004 File Offset: 0x003AB404
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x003AD018 File Offset: 0x003AB418
		internal virtual TextBox txtdecl
		{
			get
			{
				return this._txtdecl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtdecl = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x003AD024 File Offset: 0x003AB424
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x003AD038 File Offset: 0x003AB438
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x003AD044 File Offset: 0x003AB444
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x003AD058 File Offset: 0x003AB458
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x003AD064 File Offset: 0x003AB464
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x003AD078 File Offset: 0x003AB478
		internal virtual TextBox txtrun
		{
			get
			{
				return this._txtrun;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtrun_TextChanged);
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.txtrun_KeyPress);
				KeyEventHandler value4 = new KeyEventHandler(this.txtrun_KeyDown);
				if (this._txtrun != null)
				{
					this._txtrun.TextChanged -= value2;
					this._txtrun.KeyPress -= value3;
					this._txtrun.KeyDown -= value4;
				}
				this._txtrun = value;
				if (this._txtrun != null)
				{
					this._txtrun.TextChanged += value2;
					this._txtrun.KeyPress += value3;
					this._txtrun.KeyDown += value4;
				}
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x003AD110 File Offset: 0x003AB510
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x003AD124 File Offset: 0x003AB524
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x003AD170 File Offset: 0x003AB570
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x003AD184 File Offset: 0x003AB584
		internal virtual ComboBox txtpname
		{
			get
			{
				return this._txtpname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtpname_SelectedIndexChanged);
				if (this._txtpname != null)
				{
					this._txtpname.SelectedIndexChanged -= value2;
				}
				this._txtpname = value;
				if (this._txtpname != null)
				{
					this._txtpname.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x003AD1D0 File Offset: 0x003AB5D0
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x003AD1E4 File Offset: 0x003AB5E4
		internal virtual DataGridView datagridmen
		{
			get
			{
				return this._datagridmen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._datagridmen = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x003AD1F0 File Offset: 0x003AB5F0
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x003AD204 File Offset: 0x003AB604
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x003AD250 File Offset: 0x003AB650
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x003AD264 File Offset: 0x003AB664
		internal virtual TextBox TextBox2
		{
			get
			{
				return this._TextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x003AD270 File Offset: 0x003AB670
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x003AD284 File Offset: 0x003AB684
		internal virtual Button Button4
		{
			get
			{
				return this._Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				if (this._Button4 != null)
				{
					this._Button4.Click -= value2;
				}
				this._Button4 = value;
				if (this._Button4 != null)
				{
					this._Button4.Click += value2;
				}
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x003AD2D0 File Offset: 0x003AB6D0
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x003AD2E4 File Offset: 0x003AB6E4
		internal virtual DataGridView DataGridView1
		{
			get
			{
				return this._DataGridView1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridView1 = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x003AD2F0 File Offset: 0x003AB6F0
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x003AD304 File Offset: 0x003AB704
		internal virtual ComboBox TextBox3
		{
			get
			{
				return this._TextBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x003AD310 File Offset: 0x003AB710
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x003AD324 File Offset: 0x003AB724
		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x003AD330 File Offset: 0x003AB730
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x003AD344 File Offset: 0x003AB744
		internal virtual ComboBox txtagentparsent
		{
			get
			{
				return this._txtagentparsent;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtagentparsent = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x003AD350 File Offset: 0x003AB750
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x003AD364 File Offset: 0x003AB764
		internal virtual ComboBox txtself
		{
			get
			{
				return this._txtself;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtself = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x003AD370 File Offset: 0x003AB770
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x003AD384 File Offset: 0x003AB784
		internal virtual Timer Timer1
		{
			get
			{
				return this._Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x003AD3D0 File Offset: 0x003AB7D0
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x003AD3E4 File Offset: 0x003AB7E4
		internal virtual Button Button5
		{
			get
			{
				return this._Button5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				if (this._Button5 != null)
				{
					this._Button5.Click -= value2;
				}
				this._Button5 = value;
				if (this._Button5 != null)
				{
					this._Button5.Click += value2;
				}
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x003AD430 File Offset: 0x003AB830
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x003AD444 File Offset: 0x003AB844
		internal virtual ComboBox txtpartyname
		{
			get
			{
				return this._txtpartyname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtpartyname_SelectedIndexChanged);
				if (this._txtpartyname != null)
				{
					this._txtpartyname.SelectedIndexChanged -= value2;
				}
				this._txtpartyname = value;
				if (this._txtpartyname != null)
				{
					this._txtpartyname.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x003AD490 File Offset: 0x003AB890
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x003AD4A4 File Offset: 0x003AB8A4
		internal virtual ComboBox txtagentname
		{
			get
			{
				return this._txtagentname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtagentname = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x003AD4B0 File Offset: 0x003AB8B0
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x003AD4C4 File Offset: 0x003AB8C4
		internal virtual ComboBox txtpatnarname
		{
			get
			{
				return this._txtpatnarname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtpatnarname = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x003AD4D0 File Offset: 0x003AB8D0
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x003AD4E4 File Offset: 0x003AB8E4
		internal virtual ComboBox txtpatnarparsent
		{
			get
			{
				return this._txtpatnarparsent;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtpatnarparsent = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x003AD4F0 File Offset: 0x003AB8F0
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x003AD504 File Offset: 0x003AB904
		internal virtual ComboBox txtcomission
		{
			get
			{
				return this._txtcomission;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtcomission = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x003AD510 File Offset: 0x003AB910
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x003AD524 File Offset: 0x003AB924
		internal virtual Label txttype
		{
			get
			{
				return this._txttype;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txttype = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x003AD530 File Offset: 0x003AB930
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x003AD544 File Offset: 0x003AB944
		internal virtual Timer Timer2
		{
			get
			{
				return this._Timer2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				if (this._Timer2 != null)
				{
					this._Timer2.Tick -= value2;
				}
				this._Timer2 = value;
				if (this._Timer2 != null)
				{
					this._Timer2.Tick += value2;
				}
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x003AD590 File Offset: 0x003AB990
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x003AD5A4 File Offset: 0x003AB9A4
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

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x003AD5B0 File Offset: 0x003AB9B0
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x003AD5C4 File Offset: 0x003AB9C4
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

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x003AD5D0 File Offset: 0x003AB9D0
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x003AD5E4 File Offset: 0x003AB9E4
		internal virtual Button Button6
		{
			get
			{
				return this._Button6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button6_Click);
				if (this._Button6 != null)
				{
					this._Button6.Click -= value2;
				}
				this._Button6 = value;
				if (this._Button6 != null)
				{
					this._Button6.Click += value2;
				}
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x003AD630 File Offset: 0x003ABA30
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x003AD644 File Offset: 0x003ABA44
		internal virtual DataGridView DataSelf
		{
			get
			{
				return this._DataSelf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataSelf = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x003AD650 File Offset: 0x003ABA50
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x003AD664 File Offset: 0x003ABA64
		internal virtual DataGridView Dataagent
		{
			get
			{
				return this._Dataagent;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Dataagent = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x003AD670 File Offset: 0x003ABA70
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x003AD684 File Offset: 0x003ABA84
		internal virtual DataGridView Datapatner
		{
			get
			{
				return this._Datapatner;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Datapatner = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x003AD690 File Offset: 0x003ABA90
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x003AD6A4 File Offset: 0x003ABAA4
		internal virtual DataGridView Datacomision
		{
			get
			{
				return this._Datacomision;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Datacomision = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x003AD6B0 File Offset: 0x003ABAB0
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x003AD6C4 File Offset: 0x003ABAC4
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x003AD6D0 File Offset: 0x003ABAD0
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x003AD6E4 File Offset: 0x003ABAE4
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

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x003AD6F0 File Offset: 0x003ABAF0
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x003AD704 File Offset: 0x003ABB04
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

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x003AD710 File Offset: 0x003ABB10
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x003AD724 File Offset: 0x003ABB24
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

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x003AD730 File Offset: 0x003ABB30
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x003AD744 File Offset: 0x003ABB44
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

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x003AD750 File Offset: 0x003ABB50
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x003AD764 File Offset: 0x003ABB64
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

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x003AD770 File Offset: 0x003ABB70
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x003AD784 File Offset: 0x003ABB84
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x003AD790 File Offset: 0x003ABB90
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x003AD7A4 File Offset: 0x003ABBA4
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

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x003AD7B0 File Offset: 0x003ABBB0
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x003AD7C4 File Offset: 0x003ABBC4
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x003AD7D0 File Offset: 0x003ABBD0
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x003AD7E4 File Offset: 0x003ABBE4
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x003AD7F0 File Offset: 0x003ABBF0
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x003AD804 File Offset: 0x003ABC04
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

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x003AD810 File Offset: 0x003ABC10
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x003AD824 File Offset: 0x003ABC24
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

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x003AD830 File Offset: 0x003ABC30
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x003AD844 File Offset: 0x003ABC44
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x003AD850 File Offset: 0x003ABC50
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x003AD864 File Offset: 0x003ABC64
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x003AD870 File Offset: 0x003ABC70
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x003AD884 File Offset: 0x003ABC84
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
		{
			get
			{
				return this._DataGridViewTextBoxColumn12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn12 = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x003AD890 File Offset: 0x003ABC90
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x003AD8A4 File Offset: 0x003ABCA4
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x003AD8B0 File Offset: 0x003ABCB0
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x003AD8C4 File Offset: 0x003ABCC4
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
		{
			get
			{
				return this._DataGridViewTextBoxColumn13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn13 = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x003AD8D0 File Offset: 0x003ABCD0
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x003AD8E4 File Offset: 0x003ABCE4
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
		{
			get
			{
				return this._DataGridViewTextBoxColumn14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn14 = value;
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x003AD8F0 File Offset: 0x003ABCF0
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x003AD904 File Offset: 0x003ABD04
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
		{
			get
			{
				return this._DataGridViewTextBoxColumn15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn15 = value;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x003AD910 File Offset: 0x003ABD10
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x003AD924 File Offset: 0x003ABD24
		internal virtual Button Button7
		{
			get
			{
				return this._Button7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button7_Click);
				if (this._Button7 != null)
				{
					this._Button7.Click -= value2;
				}
				this._Button7 = value;
				if (this._Button7 != null)
				{
					this._Button7.Click += value2;
				}
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x003AD970 File Offset: 0x003ABD70
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x003AD984 File Offset: 0x003ABD84
		internal virtual Button Button8
		{
			get
			{
				return this._Button8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button8_Click);
				if (this._Button8 != null)
				{
					this._Button8.Click -= value2;
				}
				this._Button8 = value;
				if (this._Button8 != null)
				{
					this._Button8.Click += value2;
				}
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x003AD9D0 File Offset: 0x003ABDD0
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x003AD9E4 File Offset: 0x003ABDE4
		internal virtual Button Button9
		{
			get
			{
				return this._Button9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button9_Click);
				if (this._Button9 != null)
				{
					this._Button9.Click -= value2;
				}
				this._Button9 = value;
				if (this._Button9 != null)
				{
					this._Button9.Click += value2;
				}
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x003ADA30 File Offset: 0x003ABE30
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x003ADA44 File Offset: 0x003ABE44
		internal virtual Button Button10
		{
			get
			{
				return this._Button10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button10_Click);
				if (this._Button10 != null)
				{
					this._Button10.Click -= value2;
				}
				this._Button10 = value;
				if (this._Button10 != null)
				{
					this._Button10.Click += value2;
				}
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x003ADA90 File Offset: 0x003ABE90
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x003ADAA4 File Offset: 0x003ABEA4
		internal virtual Button Button11
		{
			get
			{
				return this._Button11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button11_Click);
				if (this._Button11 != null)
				{
					this._Button11.Click -= value2;
				}
				this._Button11 = value;
				if (this._Button11 != null)
				{
					this._Button11.Click += value2;
				}
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x003ADAF0 File Offset: 0x003ABEF0
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x003ADB04 File Offset: 0x003ABF04
		internal virtual Button Button12
		{
			get
			{
				return this._Button12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button12_Click);
				if (this._Button12 != null)
				{
					this._Button12.Click -= value2;
				}
				this._Button12 = value;
				if (this._Button12 != null)
				{
					this._Button12.Click += value2;
				}
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x003ADB50 File Offset: 0x003ABF50
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x003ADB64 File Offset: 0x003ABF64
		internal virtual ComboBox AgentTransfar
		{
			get
			{
				return this._AgentTransfar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AgentTransfar = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x003ADB70 File Offset: 0x003ABF70
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x003ADB84 File Offset: 0x003ABF84
		internal virtual ComboBox PatnareTransfar
		{
			get
			{
				return this._PatnareTransfar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PatnareTransfar = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x003ADB90 File Offset: 0x003ABF90
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x003ADBA4 File Offset: 0x003ABFA4
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x003ADBB0 File Offset: 0x003ABFB0
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x003ADBC4 File Offset: 0x003ABFC4
		internal virtual DateTimePicker txtdate
		{
			get
			{
				return this._txtdate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtdate = value;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x003ADBD0 File Offset: 0x003ABFD0
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x003ADBE4 File Offset: 0x003ABFE4
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

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x003ADBF0 File Offset: 0x003ABFF0
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x003ADC04 File Offset: 0x003AC004
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

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x003ADC10 File Offset: 0x003AC010
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x003ADC24 File Offset: 0x003AC024
		internal virtual CheckBox CheckBox1
		{
			get
			{
				return this._CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x003ADC30 File Offset: 0x003AC030
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x003ADC44 File Offset: 0x003AC044
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x003ADC50 File Offset: 0x003AC050
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x003ADC80 File Offset: 0x003AC080
		public static SessionDelear GlobalForm
		{
			get
			{
				if (SessionDelear.m_GlobalForm == null || SessionDelear.m_GlobalForm.IsDisposed)
				{
					SessionDelear.m_GlobalForm = new SessionDelear();
				}
				return SessionDelear.m_GlobalForm;
			}
			set
			{
				SessionDelear.m_GlobalForm = value;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x003ADC88 File Offset: 0x003AC088
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x003ADC90 File Offset: 0x003AC090
		private void SessionDelear_Activated(object sender, EventArgs e)
		{
			this.txtrun.Focus();
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x003ADCA0 File Offset: 0x003AC0A0
		private void SessionDelear_Load(object sender, EventArgs e)
		{
			try
			{
				this.WindowState = FormWindowState.Maximized;
				this.DataGridView2.Rows.Add();
				this.DataGridView2.Rows.Add();
				this.DataGridView2.Rows.Add();
				this.DataGridView2.Rows.Add();
				this.DataGridView2.Rows.Add();
				this.txtdate.Text = Conversions.ToString(DateAndTime.Now.Date);
				this.txtdate.Hide();
				this.partyname();
				this.find();
				this.partyname_lode_and_Agent_patnar_self();
				Module1.akdname1 = this.Label2.Text;
				this.txtrun.Focus();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x003ADD90 File Offset: 0x003AC190
		public void partyname_lode_and_Agent_patnar_self()
		{
			try
			{
				string cmdText = "select * from Newparty";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "1", false))
					{
						if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "2", false))
						{
							if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "3", false))
							{
								this.SRHICommi = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
								this.SRHIN = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
							}
							else
							{
								this.txtpartyname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
								this.txtself.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[8]));
								this.txtagentname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]));
								this.txtagentparsent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[14]));
								this.txtpatnarname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[18]));
								this.txtpatnarparsent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[20]));
								this.AgentTransfar.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["cl_Agent_commi_Trsf"]));
								this.PatnareTransfar.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["cl_share_P_transfer"]));
								if (Operators.CompareString(this.txttype.Text, "TEST", false) == 0)
								{
									this.txtcomission.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[24]));
								}
								else if (Operators.CompareString(this.txttype.Text, "50-50", false) == 0)
								{
									this.txtcomission.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[25]));
								}
								else if (Operators.CompareString(this.txttype.Text, "40-40", false) == 0)
								{
									this.txtcomission.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[26]));
								}
								else if (Operators.CompareString(this.txttype.Text, "20-20", false) == 0)
								{
									this.txtcomission.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[27]));
								}
								else
								{
									this.txtcomission.Text = "0";
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x003AE060 File Offset: 0x003AC460
		public void session_ID_All()
		{
			string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from NewSession where Sr_No=", Module1.sessionid), ""));
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				string text = Conversions.ToString(oleDbDataReader[3]);
				string text2 = (from f in text.Split(new char[]
				{
					' '
				})
				where Versioned.IsNumeric(f)
				select f).FirstOrDefault<string>();
				this.txtrun.Text = text2;
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x003AE0F0 File Offset: 0x003AC4F0
		public void partyname()
		{
			try
			{
				string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select* from SessionTrans where Session_ID=" + Conversions.ToString(Module1.nehaid) + " and S_Sr_No=", Module1.sessionid), " and s_checked=0"));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					this.txtpname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[9]));
					this.TextBox3.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[6]));
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x003AE1BC File Offset: 0x003AC5BC
		public void find()
		{
			try
			{
				string cmdText = "select* from ewSession where Sr_No=" + Conversions.ToString(Module1.nehaid) + "";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.Label2.Text = Conversions.ToString(oleDbDataReader[3]);
					this.txttype.Text = Conversions.ToString(oleDbDataReader[7]);
				}
				else
				{
					Interaction.MsgBox("Record No", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x003AE26C File Offset: 0x003AC66C
		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txtrun.Text, null, false) == 0)
				{
					this.Timer1.Enabled = false;
					Interaction.MsgBox("Declared The Runs", MsgBoxStyle.OkOnly, null);
					this.txtrun.Focus();
					this.txtrun.BackColor = Color.Maroon;
					this.txtrun.ForeColor = Color.White;
				}
				else
				{
					string text = this.txtrun.Text;
					this.Label5.Text = text.Substring(checked(text.Length - 1), 1);
					Module1.AKDNumbare = Conversions.ToInteger(this.Label5.Text);
					this.Timer1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x003AE348 File Offset: 0x003AC748
		public void decl()
		{
			try
			{
				string cmdText = Conversions.ToString(Operators.ConcatenateObject("update ewSession set Result='" + this.txtdecl.Text + "' ,Remark='" + this.txtrun.Text + "' where Sr_No=" + Conversions.ToString(Module1.nehaid) + " and Match_ID=", Module1.sessionid));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				oleDbCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x003AE3F8 File Offset: 0x003AC7F8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Button3_Click(RuntimeHelpers.GetObjectValue(sender), e);
				string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select* from SessionTrans where s_party='" + this.txtpname.Text + "' and Session_ID=" + Conversions.ToString(Module1.nehaid) + " and S_Sr_No=", Module1.sessionid), " and s_checked=0"));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.datagridmen.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"]);
				}
				string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select* from SessionTrans where s_party='" + this.txtpname.Text + "' and Session_ID=" + Conversions.ToString(Module1.nehaid) + " and S_Sr_No=", Module1.sessionid), " and s_checked=0"));
				OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
				OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
				if (oleDbDataReader2.Read())
				{
					this.datagridmen.Rows[0].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["s_no"]));
				}
				this.Button4_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x003AE5A8 File Offset: 0x003AC9A8
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.TextBox3.Text, this.txtrun.Text, false) == 0)
				{
					int value = checked((int)Math.Round(unchecked(Conversion.Val(this.txtrun.Text) + 1.0)));
					this.datagridmen.Rows.Clear();
					this.datagridmen.Columns[0].HeaderText = this.TextBox3.Text;
					this.datagridmen.Columns[1].HeaderText = Conversions.ToString(value);
					this.datagridmen.Rows.Add();
				}
				else
				{
					this.datagridmen.Rows.Clear();
					this.datagridmen.Columns[0].HeaderText = this.TextBox3.Text;
					this.datagridmen.Columns[1].HeaderText = this.txtrun.Text;
					this.datagridmen.Rows.Add();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x003AE6F8 File Offset: 0x003ACAF8
		private void txtrun_TextChanged(object sender, EventArgs e)
		{
			this.TextBox2.Text = Conversions.ToString(Conversion.Val(this.txtrun.Text) - 3.0);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x003AE724 File Offset: 0x003ACB24
		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			this.TextBox2.Text = Conversions.ToString(Conversion.Val(this.TextBox3.Text) - 10.0);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x003AE750 File Offset: 0x003ACB50
		private void Button4_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.datagridmen.Columns[0].HeaderText, this.txtrun.Text, false) == 0)
			{
				this.Neha1 = Conversions.ToDouble(this.datagridmen.Rows[0].Cells[0].Value);
			}
			else if (Operators.CompareString(this.datagridmen.Columns[1].HeaderText, this.txtrun.Text, false) == 0)
			{
				this.Neha1 = Conversions.ToDouble(this.datagridmen.Rows[0].Cells[1].Value);
			}
			string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Session_mst values(" + Module1.nehaid.ToString() + ",", Module1.sessionid), ",'"), this.txtpname.Text), "','"), this.Neha1.ToString()), "')"));
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
			oleDbCommand.ExecuteNonQuery();
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x003AE88C File Offset: 0x003ACC8C
		private void txtrun_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x003AE890 File Offset: 0x003ACC90
		private void txtpname_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.TextBox3.SelectedIndex = this.txtpname.SelectedIndex;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x003AE8A8 File Offset: 0x003ACCA8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (this.txtpname.SelectedIndex < this.txtpname.Items.Count - 1)
				{
					this.txtpname.SelectedIndex = this.txtpname.SelectedIndex + 1;
					this.Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					this.Timer1.Enabled = false;
					this.Timer2_Tick(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x003AE914 File Offset: 0x003ACD14
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(Amount)from Session_mst where Session_ID=" + Conversions.ToString(Module1.nehaid) + " and Match_ID=", Module1.sessionid), " and Name='"), this.txtpartyname.Text), "'"));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
				{
					double num = Conversion.Val(0.01) * Conversion.Val(this.txtself.Text);
					double num2 = Conversion.Val(0.01) * Conversion.Val(this.txtagentparsent.Text);
					double num3 = Conversion.Val(0.01) * Conversion.Val(this.txtpatnarparsent.Text);
					double num4 = Conversion.Val(0.01) * Conversion.Val(this.txtcomission.Text);
					this.total1 = Conversions.ToDouble(oleDbCommand.ExecuteScalar());
					int index = this.DataGridView1.Rows.Add();
					this.DataGridView1.Rows[index].Cells[0].Value = this.txtpartyname.Text;
					this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(this.total1) - Conversion.Val(this.total1) - Conversion.Val(this.total1);
					this.DataGridView1.Rows[index].Cells[2].Value = this.Label2.Text;
					int index2 = this.DataSelf.Rows.Add();
					this.DataSelf.Rows[index2].Cells[0].Value = this.txtpartyname.Text;
					this.DataSelf.Rows[index2].Cells[1].Value = Conversion.Val(this.total1) * Conversion.Val(num);
					this.DataSelf.Rows[index2].Cells[2].Value = "As an Self Share - " + this.Label2.Text;
					int index3 = this.Datacomision.Rows.Add();
					this.Datacomision.Rows[index3].Cells[0].Value = this.txtpartyname.Text;
					double num5 = Conversion.Val(this.total1) * Conversion.Val(num) * Conversion.Val(num4);
					this.Datacomision.Rows[index3].Cells[1].Value = num5 - num5 - num5;
					this.Datacomision.Rows[index3].Cells[2].Value = "Comm on session of LD -  -" + this.txtpartyname.Text + " - " + this.Label2.Text;
					if (Operators.CompareString(this.AgentTransfar.Text, "0", false) == 0 & Operators.CompareString(this.PatnareTransfar.Text, "0", false) == 0)
					{
						int index4 = this.Datacomision.Rows.Add();
						this.Datacomision.Rows[index4].Cells[0].Value = this.txtpartyname.Text;
						double num6 = Conversion.Val(this.total1) * Conversion.Val(num4);
						this.Datacomision.Rows[index4].Cells[1].Value = Conversion.Val(num6);
						this.Datacomision.Rows[index4].Cells[2].Value = " Comm on session of - " + this.txtpartyname.Text + "-" + this.Label2.Text;
					}
					else if (Operators.CompareString(this.AgentTransfar.Text, "1", false) == 0)
					{
						int index5 = this.Datacomision.Rows.Add();
						this.Datacomision.Rows[index5].Cells[0].Value = this.txtagentname.Text;
						double num7 = Conversion.Val(this.total1) * Conversion.Val(num4);
						this.Datacomision.Rows[index5].Cells[1].Value = Conversion.Val(num7);
						this.Datacomision.Rows[index5].Cells[2].Value = " Comm on session of - " + this.txtpartyname.Text + "-" + this.Label2.Text;
					}
					else if (Operators.CompareString(this.PatnareTransfar.Text, "1", false) == 0)
					{
						int index6 = this.Datacomision.Rows.Add();
						this.Datacomision.Rows[index6].Cells[0].Value = this.txtpatnarname.Text;
						double num8 = Conversion.Val(this.total1) * Conversion.Val(num4);
						this.Datacomision.Rows[index6].Cells[1].Value = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
						this.Datacomision.Rows[index6].Cells[2].Value = " Comm on session of - " + this.txtpartyname.Text + "-" + this.Label2.Text;
					}
					if (Operators.CompareString(this.txtagentname.Text, "", false) != 0)
					{
						int index7 = this.Dataagent.Rows.Add();
						this.Dataagent.Rows[index7].Cells[0].Value = this.txtagentname.Text;
						this.Dataagent.Rows[index7].Cells[1].Value = Conversion.Val(this.total1) * Conversion.Val(num2);
						this.Dataagent.Rows[index7].Cells[2].Value = "As an Agent of -   " + this.txtpartyname.Text + " - " + this.Label2.Text;
						int index8 = this.Datacomision.Rows.Add();
						this.Datacomision.Rows[index8].Cells[0].Value = this.txtagentname.Text;
						double num9 = Conversion.Val(this.total1) * Conversion.Val(num2) * Conversion.Val(num4);
						this.Datacomision.Rows[index8].Cells[1].Value = num9 - num9 - num9;
						this.Datacomision.Rows[index8].Cells[2].Value = "Comm on session of LD -   " + this.txtpartyname.Text + " - " + this.Label2.Text;
					}
					if (Operators.CompareString(this.txtpatnarname.Text, "", false) != 0)
					{
						int index9 = this.Datapatner.Rows.Add();
						this.Datapatner.Rows[index9].Cells[0].Value = this.txtpatnarname.Text;
						this.Datapatner.Rows[index9].Cells[1].Value = Conversion.Val(this.total1) * Conversion.Val(num3);
						this.Datapatner.Rows[index9].Cells[2].Value = "As Partner of - -" + this.txtpartyname.Text + " - " + this.Label2.Text;
						int index10 = this.Datacomision.Rows.Add();
						this.Datacomision.Rows[index10].Cells[0].Value = this.txtpatnarname.Text;
						double num10 = Conversion.Val(this.total1) * Conversion.Val(num3) * Conversion.Val(num4);
						this.Datacomision.Rows[index10].Cells[1].Value = num10 - num10 - num10;
						this.Datacomision.Rows[index10].Cells[2].Value = "Comm on session of LD -  -" + this.txtpartyname.Text + " - " + this.Label2.Text;
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x003AF3A0 File Offset: 0x003AD7A0
		private void txtpartyname_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtself.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.txtagentname.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.txtagentparsent.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.txtpatnarname.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.txtpatnarparsent.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.txtcomission.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.AgentTransfar.SelectedIndex = this.txtpartyname.SelectedIndex;
				this.PatnareTransfar.SelectedIndex = this.txtpartyname.SelectedIndex;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x003AF48C File Offset: 0x003AD88C
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.Timer2.Enabled = true;
			checked
			{
				if (this.txtpartyname.SelectedIndex < this.txtpartyname.Items.Count - 1)
				{
					this.txtpartyname.SelectedIndex = this.txtpartyname.SelectedIndex + 1;
					this.Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					this.Timer2.Enabled = false;
					this.decl();
					this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Button7_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Button8_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Button9_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Button10_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Interaction.MsgBox("Session is Declared ", MsgBoxStyle.OkOnly, null);
					this.Close();
				}
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x003AF570 File Offset: 0x003AD970
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				double num = 0.0;
				int num2 = 0;
				double num13;
				checked
				{
					int num3 = this.DataGridView1.RowCount - 1;
					for (int i = num2; i <= num3; i++)
					{
						unchecked
						{
							num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[1].Value));
						}
					}
					this.DataGridView2.Rows[0].Cells[1].Value = unchecked(Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num));
					this.DataGridView2.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHIN);
					this.DataGridView2.Rows[0].Cells[2].Value = this.Label2.Text;
					double num4 = 0.0;
					int num5 = 0;
					int num6 = this.DataSelf.RowCount - 1;
					for (int j = num5; j <= num6; j++)
					{
						unchecked
						{
							num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataSelf.Rows[j].Cells[1].Value));
						}
					}
					this.DataGridView2.Rows[1].Cells[1].Value = unchecked(Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4));
					this.DataGridView2.Rows[1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHIN);
					this.DataGridView2.Rows[1].Cells[2].Value = "As an Self Agent -" + this.Label2.Text;
					double num7 = 0.0;
					int num8 = 0;
					int num9 = this.Dataagent.RowCount - 1;
					for (int k = num8; k <= num9; k++)
					{
						unchecked
						{
							num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.Dataagent.Rows[k].Cells[1].Value));
						}
					}
					this.DataGridView2.Rows[2].Cells[1].Value = unchecked(Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7));
					this.DataGridView2.Rows[2].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHIN);
					this.DataGridView2.Rows[2].Cells[2].Value = "As an Agent of  -" + this.Label2.Text;
					double num10 = 0.0;
					int num11 = 0;
					int num12 = this.Datapatner.RowCount - 1;
					for (int l = num11; l <= num12; l++)
					{
						unchecked
						{
							num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.Datapatner.Rows[l].Cells[1].Value));
						}
					}
					this.DataGridView2.Rows[3].Cells[1].Value = unchecked(Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10));
					this.DataGridView2.Rows[3].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHIN);
					this.DataGridView2.Rows[3].Cells[2].Value = "As an Partner of -" + this.Label2.Text;
					num13 = 0.0;
					int num14 = 0;
					int num15 = this.Datacomision.RowCount - 1;
					for (int m = num14; m <= num15; m++)
					{
						unchecked
						{
							num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.Datacomision.Rows[m].Cells[1].Value));
						}
					}
				}
				this.DataGridView2.Rows[4].Cells[1].Value = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
				this.DataGridView2.Rows[4].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHIN);
				this.DataGridView2.Rows[4].Cells[2].Value = "Comm Session of - " + this.Label2.Text;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x003AFACC File Offset: 0x003ADECC
		public void Sr_Nos()
		{
			checked
			{
				try
				{
					string cmdText = "select max(ID) from Trans";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
					{
						this.txtid1.Text = "1";
					}
					else
					{
						int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
						num++;
						this.txtid1.Text = Conversions.ToString(num);
					}
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x003AFB60 File Offset: 0x003ADF60
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							this.Sr_Nos();
							string cmdText = "insert into Trans(ID,Party,Amount,Remark,MatchID,dt,Type,Vid,Monday,Sessionid,Monday_Final) values(@ID,@Party,@Amount,@Remark,@matchid,@dt,@type,@vid,@monday,@sessionid,@Monday_Final)";
							OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
							oleDbCommand.Parameters.AddWithValue("@ID", this.txtid1.Text);
							oleDbCommand.Parameters.AddWithValue("@Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							oleDbCommand.Parameters.AddWithValue("@Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
							oleDbCommand.Parameters.AddWithValue("@Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							oleDbCommand.Parameters.AddWithValue("@matchid", RuntimeHelpers.GetObjectValue(Module1.sessionid));
							oleDbCommand.Parameters.AddWithValue("@dt", this.txtdate.Text);
							oleDbCommand.Parameters.AddWithValue("@type", "Session");
							oleDbCommand.Parameters.AddWithValue("@vid", "");
							oleDbCommand.Parameters.AddWithValue("@monday", "0");
							oleDbCommand.Parameters.AddWithValue("@sessionid", Module1.nehaid);
							oleDbCommand.Parameters.AddWithValue("@Monday_Final", "No");
							oleDbCommand.ExecuteNonQuery();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x003AFD80 File Offset: 0x003AE180
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataSelf.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							this.Sr_Nos();
							string cmdText = "insert into Trans(ID,Party,Amount,Remark,MatchID,dt,Type,Vid,Monday,Sessionid,Monday_Final) values(@ID,@Party,@Amount,@Remark,@matchid,@dt,@type,@vid,@monday,@sessionid,@Monday_Final)";
							OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
							oleDbCommand.Parameters.AddWithValue("@ID", this.txtid1.Text);
							oleDbCommand.Parameters.AddWithValue("@Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							oleDbCommand.Parameters.AddWithValue("@Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
							oleDbCommand.Parameters.AddWithValue("@Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							oleDbCommand.Parameters.AddWithValue("@matchid", RuntimeHelpers.GetObjectValue(Module1.sessionid));
							oleDbCommand.Parameters.AddWithValue("@dt", this.txtdate.Text);
							oleDbCommand.Parameters.AddWithValue("@type", "Session");
							oleDbCommand.Parameters.AddWithValue("@vid", "");
							oleDbCommand.Parameters.AddWithValue("@monday", "0");
							oleDbCommand.Parameters.AddWithValue("@sessionid", Module1.nehaid);
							oleDbCommand.Parameters.AddWithValue("@Monday_Final", "No");
							oleDbCommand.ExecuteNonQuery();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x003AFFA0 File Offset: 0x003AE3A0
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.Dataagent.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							this.Sr_Nos();
							string cmdText = "insert into Trans(ID,Party,Amount,Remark,MatchID,dt,Type,Vid,Monday,Sessionid,Monday_Final) values(@ID,@Party,@Amount,@Remark,@matchid,@dt,@type,@vid,@monday,@sessionid,@Monday_Final)";
							OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
							oleDbCommand.Parameters.AddWithValue("@ID", this.txtid1.Text);
							oleDbCommand.Parameters.AddWithValue("@Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							oleDbCommand.Parameters.AddWithValue("@Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
							oleDbCommand.Parameters.AddWithValue("@Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							oleDbCommand.Parameters.AddWithValue("@matchid", RuntimeHelpers.GetObjectValue(Module1.sessionid));
							oleDbCommand.Parameters.AddWithValue("@dt", this.txtdate.Text);
							oleDbCommand.Parameters.AddWithValue("@type", "Session");
							oleDbCommand.Parameters.AddWithValue("@vid", "");
							oleDbCommand.Parameters.AddWithValue("@monday", "0");
							oleDbCommand.Parameters.AddWithValue("@sessionid", Module1.nehaid);
							oleDbCommand.Parameters.AddWithValue("@Monday_Final", "No");
							oleDbCommand.ExecuteNonQuery();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x003B01C0 File Offset: 0x003AE5C0
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.Datapatner.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							this.Sr_Nos();
							string cmdText = "insert into Trans(ID,Party,Amount,Remark,MatchID,dt,Type,Vid,Monday,Sessionid,Monday_Final) values(@ID,@Party,@Amount,@Remark,@matchid,@dt,@type,@vid,@monday,@sessionid,@Monday_Final)";
							OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
							oleDbCommand.Parameters.AddWithValue("@ID", this.txtid1.Text);
							oleDbCommand.Parameters.AddWithValue("@Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							oleDbCommand.Parameters.AddWithValue("@Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
							oleDbCommand.Parameters.AddWithValue("@Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							oleDbCommand.Parameters.AddWithValue("@matchid", RuntimeHelpers.GetObjectValue(Module1.sessionid));
							oleDbCommand.Parameters.AddWithValue("@dt", this.txtdate.Text);
							oleDbCommand.Parameters.AddWithValue("@type", "Session");
							oleDbCommand.Parameters.AddWithValue("@vid", "");
							oleDbCommand.Parameters.AddWithValue("@monday", "0");
							oleDbCommand.Parameters.AddWithValue("@sessionid", Module1.nehaid);
							oleDbCommand.Parameters.AddWithValue("@Monday_Final", "No");
							oleDbCommand.ExecuteNonQuery();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x003B03E0 File Offset: 0x003AE7E0
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.Datacomision.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							this.Sr_Nos();
							string cmdText = "insert into Trans(ID,Party,Amount,Remark,MatchID,dt,Type,Vid,Monday,Sessionid,Monday_Final) values(@ID,@Party,@Amount,@Remark,@matchid,@dt,@type,@vid,@monday,@sessionid,@Monday_Final)";
							OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
							oleDbCommand.Parameters.AddWithValue("@ID", this.txtid1.Text);
							oleDbCommand.Parameters.AddWithValue("@Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							oleDbCommand.Parameters.AddWithValue("@Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
							oleDbCommand.Parameters.AddWithValue("@Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							oleDbCommand.Parameters.AddWithValue("@matchid", RuntimeHelpers.GetObjectValue(Module1.sessionid));
							oleDbCommand.Parameters.AddWithValue("@dt", this.txtdate.Text);
							oleDbCommand.Parameters.AddWithValue("@type", "Session");
							oleDbCommand.Parameters.AddWithValue("@vid", "");
							oleDbCommand.Parameters.AddWithValue("@monday", "0");
							oleDbCommand.Parameters.AddWithValue("@sessionid", Module1.nehaid);
							oleDbCommand.Parameters.AddWithValue("@Monday_Final", "No");
							oleDbCommand.ExecuteNonQuery();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x003B0600 File Offset: 0x003AEA00
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView2.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							this.Sr_Nos();
							string cmdText = "insert into Trans(ID,Party,Amount,Remark,MatchID,dt,Type,Vid,Monday,Sessionid,Monday_Final) values(@ID,@Party,@Amount,@Remark,@matchid,@dt,@type,@vid,@monday,@sessionid,@Monday_Final)";
							OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
							oleDbCommand.Parameters.AddWithValue("@ID", this.txtid1.Text);
							oleDbCommand.Parameters.AddWithValue("@Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							oleDbCommand.Parameters.AddWithValue("@Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
							oleDbCommand.Parameters.AddWithValue("@Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							oleDbCommand.Parameters.AddWithValue("@matchid", RuntimeHelpers.GetObjectValue(Module1.sessionid));
							oleDbCommand.Parameters.AddWithValue("@dt", this.txtdate.Text);
							oleDbCommand.Parameters.AddWithValue("@type", "Session");
							oleDbCommand.Parameters.AddWithValue("@vid", "");
							oleDbCommand.Parameters.AddWithValue("@monday", "0");
							oleDbCommand.Parameters.AddWithValue("@sessionid", Module1.nehaid);
							oleDbCommand.Parameters.AddWithValue("@Monday_Final", "No");
							oleDbCommand.ExecuteNonQuery();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x003B0820 File Offset: 0x003AEC20
		private void txtrun_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.txtdeclard.Focus();
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x003B0838 File Offset: 0x003AEC38
		private void txtdeclard_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.Save.Focus();
			}
		}

		// Token: 0x04000CE6 RID: 3302
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000CE7 RID: 3303
		[AccessedThroughProperty("Save")]
		private Button _Save;

		// Token: 0x04000CE8 RID: 3304
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000CE9 RID: 3305
		[AccessedThroughProperty("txtdeclard")]
		private TextBox _txtdeclard;

		// Token: 0x04000CEA RID: 3306
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000CEB RID: 3307
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000CEC RID: 3308
		[AccessedThroughProperty("txtdecl")]
		private TextBox _txtdecl;

		// Token: 0x04000CED RID: 3309
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000CEE RID: 3310
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000CEF RID: 3311
		[AccessedThroughProperty("txtrun")]
		private TextBox _txtrun;

		// Token: 0x04000CF0 RID: 3312
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000CF1 RID: 3313
		[AccessedThroughProperty("txtpname")]
		private ComboBox _txtpname;

		// Token: 0x04000CF2 RID: 3314
		[AccessedThroughProperty("datagridmen")]
		private DataGridView _datagridmen;

		// Token: 0x04000CF3 RID: 3315
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000CF4 RID: 3316
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000CF5 RID: 3317
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x04000CF6 RID: 3318
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x04000CF7 RID: 3319
		[AccessedThroughProperty("TextBox3")]
		private ComboBox _TextBox3;

		// Token: 0x04000CF8 RID: 3320
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000CF9 RID: 3321
		[AccessedThroughProperty("txtagentparsent")]
		private ComboBox _txtagentparsent;

		// Token: 0x04000CFA RID: 3322
		[AccessedThroughProperty("txtself")]
		private ComboBox _txtself;

		// Token: 0x04000CFB RID: 3323
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000CFC RID: 3324
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x04000CFD RID: 3325
		[AccessedThroughProperty("txtpartyname")]
		private ComboBox _txtpartyname;

		// Token: 0x04000CFE RID: 3326
		[AccessedThroughProperty("txtagentname")]
		private ComboBox _txtagentname;

		// Token: 0x04000CFF RID: 3327
		[AccessedThroughProperty("txtpatnarname")]
		private ComboBox _txtpatnarname;

		// Token: 0x04000D00 RID: 3328
		[AccessedThroughProperty("txtpatnarparsent")]
		private ComboBox _txtpatnarparsent;

		// Token: 0x04000D01 RID: 3329
		[AccessedThroughProperty("txtcomission")]
		private ComboBox _txtcomission;

		// Token: 0x04000D02 RID: 3330
		[AccessedThroughProperty("txttype")]
		private Label _txttype;

		// Token: 0x04000D03 RID: 3331
		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		// Token: 0x04000D04 RID: 3332
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x04000D05 RID: 3333
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x04000D06 RID: 3334
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		// Token: 0x04000D07 RID: 3335
		[AccessedThroughProperty("DataSelf")]
		private DataGridView _DataSelf;

		// Token: 0x04000D08 RID: 3336
		[AccessedThroughProperty("Dataagent")]
		private DataGridView _Dataagent;

		// Token: 0x04000D09 RID: 3337
		[AccessedThroughProperty("Datapatner")]
		private DataGridView _Datapatner;

		// Token: 0x04000D0A RID: 3338
		[AccessedThroughProperty("Datacomision")]
		private DataGridView _Datacomision;

		// Token: 0x04000D0B RID: 3339
		[AccessedThroughProperty("Column1")]
		private DataGridViewTextBoxColumn _Column1;

		// Token: 0x04000D0C RID: 3340
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x04000D0D RID: 3341
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x04000D0E RID: 3342
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

		// Token: 0x04000D0F RID: 3343
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

		// Token: 0x04000D10 RID: 3344
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

		// Token: 0x04000D11 RID: 3345
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

		// Token: 0x04000D12 RID: 3346
		[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

		// Token: 0x04000D13 RID: 3347
		[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

		// Token: 0x04000D14 RID: 3348
		[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

		// Token: 0x04000D15 RID: 3349
		[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

		// Token: 0x04000D16 RID: 3350
		[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

		// Token: 0x04000D17 RID: 3351
		[AccessedThroughProperty("DataGridViewTextBoxColumn10")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

		// Token: 0x04000D18 RID: 3352
		[AccessedThroughProperty("DataGridViewTextBoxColumn11")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

		// Token: 0x04000D19 RID: 3353
		[AccessedThroughProperty("DataGridViewTextBoxColumn12")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;

		// Token: 0x04000D1A RID: 3354
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x04000D1B RID: 3355
		[AccessedThroughProperty("DataGridViewTextBoxColumn13")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;

		// Token: 0x04000D1C RID: 3356
		[AccessedThroughProperty("DataGridViewTextBoxColumn14")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;

		// Token: 0x04000D1D RID: 3357
		[AccessedThroughProperty("DataGridViewTextBoxColumn15")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;

		// Token: 0x04000D1E RID: 3358
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		// Token: 0x04000D1F RID: 3359
		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		// Token: 0x04000D20 RID: 3360
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x04000D21 RID: 3361
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x04000D22 RID: 3362
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		// Token: 0x04000D23 RID: 3363
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		// Token: 0x04000D24 RID: 3364
		[AccessedThroughProperty("AgentTransfar")]
		private ComboBox _AgentTransfar;

		// Token: 0x04000D25 RID: 3365
		[AccessedThroughProperty("PatnareTransfar")]
		private ComboBox _PatnareTransfar;

		// Token: 0x04000D26 RID: 3366
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000D27 RID: 3367
		[AccessedThroughProperty("txtdate")]
		private DateTimePicker _txtdate;

		// Token: 0x04000D28 RID: 3368
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000D29 RID: 3369
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000D2A RID: 3370
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000D2B RID: 3371
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		// Token: 0x04000D2C RID: 3372
		private static SessionDelear m_GlobalForm;

		// Token: 0x04000D2D RID: 3373
		private double Neha1;

		// Token: 0x04000D2E RID: 3374
		private double d1;

		// Token: 0x04000D2F RID: 3375
		private double d2;

		// Token: 0x04000D30 RID: 3376
		private double total1;

		// Token: 0x04000D31 RID: 3377
		private double SRHI;

		// Token: 0x04000D32 RID: 3378
		public object SRHIN;

		// Token: 0x04000D33 RID: 3379
		public object SRHICommi;

		// Token: 0x04000D34 RID: 3380
		private TextBox txtid1;
	}
}
