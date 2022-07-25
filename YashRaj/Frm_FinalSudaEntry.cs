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
	// Token: 0x02000040 RID: 64
	[DesignerGenerated]
	public partial class Frm_FinalSudaEntry : Form
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00306A04 File Offset: 0x00304E04
		public Frm_FinalSudaEntry()
		{
			base.Load += this.Frm_FinalSudaEntry_Load;
			this.InitializeComponent();
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00308E70 File Offset: 0x00307270
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00308E84 File Offset: 0x00307284
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00308E90 File Offset: 0x00307290
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00308EA4 File Offset: 0x003072A4
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

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00308EB0 File Offset: 0x003072B0
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00308EC4 File Offset: 0x003072C4
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00308F10 File Offset: 0x00307310
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00308F24 File Offset: 0x00307324
		internal virtual SplitContainer SplitContainer1
		{
			get
			{
				return this._SplitContainer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer1 = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00308F30 File Offset: 0x00307330
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00308F44 File Offset: 0x00307344
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00308F50 File Offset: 0x00307350
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00308F64 File Offset: 0x00307364
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00308F70 File Offset: 0x00307370
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00308F84 File Offset: 0x00307384
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00308F90 File Offset: 0x00307390
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00308FA4 File Offset: 0x003073A4
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00308FB0 File Offset: 0x003073B0
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00308FC4 File Offset: 0x003073C4
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00308FD0 File Offset: 0x003073D0
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00308FE4 File Offset: 0x003073E4
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00309030 File Offset: 0x00307430
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00309044 File Offset: 0x00307444
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00309050 File Offset: 0x00307450
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00309064 File Offset: 0x00307464
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00309070 File Offset: 0x00307470
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00309084 File Offset: 0x00307484
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00309090 File Offset: 0x00307490
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x003090A4 File Offset: 0x003074A4
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x003090B0 File Offset: 0x003074B0
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x003090C4 File Offset: 0x003074C4
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x003090D0 File Offset: 0x003074D0
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x003090E4 File Offset: 0x003074E4
		internal virtual CheckBox CheckBox1
		{
			get
			{
				return this._CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00309130 File Offset: 0x00307530
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00309144 File Offset: 0x00307544
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00309190 File Offset: 0x00307590
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x003091A4 File Offset: 0x003075A4
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x003091B0 File Offset: 0x003075B0
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x003091C4 File Offset: 0x003075C4
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x003091D0 File Offset: 0x003075D0
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x003091E4 File Offset: 0x003075E4
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x003091F0 File Offset: 0x003075F0
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00309204 File Offset: 0x00307604
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00309250 File Offset: 0x00307650
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00309264 File Offset: 0x00307664
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00309270 File Offset: 0x00307670
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00309284 File Offset: 0x00307684
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00309290 File Offset: 0x00307690
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x003092A4 File Offset: 0x003076A4
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x003092B0 File Offset: 0x003076B0
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x003092C4 File Offset: 0x003076C4
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x003092D0 File Offset: 0x003076D0
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x003092E4 File Offset: 0x003076E4
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00309330 File Offset: 0x00307730
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00309344 File Offset: 0x00307744
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00309390 File Offset: 0x00307790
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x003093A4 File Offset: 0x003077A4
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x003093F0 File Offset: 0x003077F0
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00309404 File Offset: 0x00307804
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00309410 File Offset: 0x00307810
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00309424 File Offset: 0x00307824
		internal virtual SplitContainer SplitContainer2
		{
			get
			{
				return this._SplitContainer2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer2 = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00309430 File Offset: 0x00307830
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00309444 File Offset: 0x00307844
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00309450 File Offset: 0x00307850
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00309464 File Offset: 0x00307864
		internal virtual Label lblmatchID
		{
			get
			{
				return this._lblmatchID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblmatchID_TextChanged);
				if (this._lblmatchID != null)
				{
					this._lblmatchID.TextChanged -= value2;
				}
				this._lblmatchID = value;
				if (this._lblmatchID != null)
				{
					this._lblmatchID.TextChanged += value2;
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x003094B0 File Offset: 0x003078B0
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x003094C4 File Offset: 0x003078C4
		internal virtual ComboBox comsesstionID
		{
			get
			{
				return this._comsesstionID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._comsesstionID = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x003094D0 File Offset: 0x003078D0
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x003094E4 File Offset: 0x003078E4
		internal virtual CheckBox CheckBox2
		{
			get
			{
				return this._CheckBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox2 = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x003094F0 File Offset: 0x003078F0
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00309504 File Offset: 0x00307904
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00309510 File Offset: 0x00307910
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00309524 File Offset: 0x00307924
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

		// Token: 0x06000CCF RID: 3279 RVA: 0x00309530 File Offset: 0x00307930
		private void Frm_FinalSudaEntry_Load(object sender, EventArgs e)
		{
			try
			{
				this.YES_NO();
				this.CheckBox2.Hide();
				this.txtnu.Hide();
				this.comsesstionID.Hide();
				this.lblmatchID.Hide();
				this.Lode_All_Entrys();
				this.combolod();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x003095AC File Offset: 0x003079AC
		public void combolod()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				this.Strsql = "select* from Newparty ";
				this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
				this.dr = this.cmd.ExecuteReader();
				while (this.dr.Read())
				{
					if (!Operators.ConditionalCompareObjectEqual(this.dr[0], "1", false))
					{
						if (!Operators.ConditionalCompareObjectEqual(this.dr[0], "2", false))
						{
							if (!Operators.ConditionalCompareObjectEqual(this.dr[0], "3", false))
							{
								this.txtname.Items.Add(this.dr[1].ToString());
								this.txtsname.Items.Add(this.dr[1].ToString());
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

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0030970C File Offset: 0x00307B0C
		public void YES_NO()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = " select*  from Settings";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.CheckBox2.Checked = Conversions.ToBoolean(oleDbDataReader[3]);
				}
				if (this.CheckBox2.Checked)
				{
					this.txtnu.Text = ".00";
				}
				else
				{
					this.txtnu.Text = ".000";
				}
				if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
				{
					this.txtnu.Text = "0";
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00309804 File Offset: 0x00307C04
		public void Lode_All_Entrys()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				this.Strsql = "SELECT        Sr_No AS ID_NO, Date1 AS [DATE], Team1 AS Team_A, Name AS Team_B, Type AS TYPE, Result AS RESULT FROM Newmatch ORDER BY Sr_No DESC, Date1 DESC";
				OleDbCommand oleDbCommand = new OleDbCommand(this.Strsql, Module1.conn);
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
				DataSet dataSet = new DataSet();
				DataTable dataTable = new DataTable();
				oleDbDataAdapter.SelectCommand = new OleDbCommand(this.Strsql, Module1.conn);
				oleDbDataAdapter.Fill(dataSet, "Newmatch");
				this.DataGridView1.DataSource = dataSet;
				this.DataGridView1.DataMember = "Newmatch";
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x003098C8 File Offset: 0x00307CC8
		private void lblmatchID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.lblmatchID.Text, "", false) != 0)
				{
					this.comsesstionID.Items.Clear();
					this.sessionall.Items.Clear();
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					this.Strsql = "SELECT        Sr_No, Match_ID, N_name FROM ewSession  WHERE(Match_ID = " + this.lblmatchID.Text + ") ORDER BY Sr_No DESC";
					this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
					this.dr = this.cmd.ExecuteReader();
					while (this.dr.Read())
					{
						this.comsesstionID.Items.Add(this.dr["Sr_No"].ToString());
						this.sessionall.Items.Add(this.dr["N_name"].ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x003099FC File Offset: 0x00307DFC
		private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells["ID_NO"].Value, null, false))
				{
					this.lblmatchID.Text = this.DataGridView1.CurrentRow.Cells["ID_NO"].Value.ToString();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00309A84 File Offset: 0x00307E84
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.CheckBox1.Checked)
				{
					this.sessionall.Enabled = false;
					this.comsesstionID.Enabled = false;
				}
				else
				{
					this.sessionall.Enabled = true;
					this.comsesstionID.Enabled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00309AF0 File Offset: 0x00307EF0
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00309AF8 File Offset: 0x00307EF8
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

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00309C54 File Offset: 0x00308054
		private void txtname_KeyPress(object sender, KeyPressEventArgs e)
		{
			ComboBox txtname = this.txtname;
			this.AutoComplete(ref txtname, e, false);
			this.txtname = txtname;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00309C7C File Offset: 0x0030807C
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

		// Token: 0x06000CDA RID: 3290 RVA: 0x00309DD8 File Offset: 0x003081D8
		private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
		{
			ComboBox txtsname = this.txtsname;
			this.AutoComplete11(ref txtsname, e, false);
			this.txtsname = txtsname;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00309E00 File Offset: 0x00308200
		private void sessionall_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comsesstionID.SelectedIndex = this.sessionall.SelectedIndex;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00309E18 File Offset: 0x00308218
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string text;
					if (this.RA.Checked)
					{
						text = "m_party ='" + this.txtname.Text + "'";
					}
					else if (this.Ramunt.Checked)
					{
						text = "m_amt =" + this.txtamount.Text + "";
					}
					else if (this.Rrate.Checked)
					{
						text = "m_rate =" + this.txtrate.Text + "";
					}
					else
					{
						if (!this.Rteam.Checked)
						{
							return;
						}
						text = "m_team ='" + this.txtteam.Text + "'";
					}
					this.Strsql = string.Concat(new string[]
					{
						"SELECT         m_eid AS Sr_No, m_amt AS Amount, m_rate AS Rate, m_team AS Fovrt, m_mode AS Mode, m_party AS [Party Name], m_team1  , m_team2 , m_team3 , m_team4 ,    m_time AS [Time], m_page AS Page_No, m_dt AS [Date], m_checked, Modify, M_chk FROM MatchTrans  WHERE(m_id = ",
						this.lblmatchID.Text,
						") AND (",
						text,
						") ORDER BY m_eid DESC"
					});
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(this.Strsql, Module1.conn);
					DataSet dataSet = new DataSet();
					oleDbDataAdapter.Fill(dataSet, "Table");
					this.DataGridView2.AutoGenerateColumns = true;
					this.DataGridView2.DataSource = dataSet;
					this.DataGridView2.DataMember = "Table";
					this.Strsql = "SELECT        horse1, horse2, horse3, horse4 FROM Newmatch  WHERE(Sr_No = " + this.lblmatchID.Text + ")";
					this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
					this.dr = this.cmd.ExecuteReader();
					if (this.dr.Read())
					{
						this.DataGridView2.Columns[6].HeaderText = this.dr["horse1"].ToString();
						this.DataGridView2.Columns[7].HeaderText = this.dr["horse2"].ToString();
						this.DataGridView2.Columns[8].HeaderText = this.dr["horse3"].ToString();
						this.DataGridView2.Columns[9].HeaderText = this.dr["horse4"].ToString();
					}
					if (Operators.CompareString(this.DataGridView2.Columns[8].HeaderText, null, false) == 0)
					{
						this.DataGridView2.Columns[8].Visible = false;
					}
					if (Operators.CompareString(this.DataGridView2.Columns[9].HeaderText, null, false) == 0)
					{
						this.DataGridView2.Columns[9].Visible = false;
					}
					this.DataGridView2.Columns[1].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView2.Columns[6].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView2.Columns[7].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView2.Columns[8].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView2.Columns[9].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView2.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["Fovrt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["Mode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["Party Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["m_team1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["m_team2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["m_team3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.Columns["m_team4"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
					int num = 0;
					int num2 = this.DataGridView2.RowCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Conversions.ToDouble(this.DataGridView2.Rows[i].Cells[13].Value.ToString()) == 1.0)
						{
							this.DataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
						}
						else if (Conversions.ToDouble(this.DataGridView2.Rows[i].Cells[14].Value.ToString()) == 1.0)
						{
							this.DataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
						}
						else if (Conversions.ToDouble(this.DataGridView2.Rows[i].Cells[15].Value.ToString()) == 1.0)
						{
							this.DataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Lime;
						}
					}
					this.DataGridView2.Columns["Page_No"].Visible = false;
					this.DataGridView2.Columns["m_checked"].Visible = false;
					this.DataGridView2.Columns["Modify"].Visible = false;
					this.DataGridView2.Columns["M_chk"].Visible = false;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0030A4CC File Offset: 0x003088CC
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Enty_Show_all();
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0030A4D4 File Offset: 0x003088D4
		public void Enty_Show_all()
		{
			checked
			{
				try
				{
					this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
					string text;
					if (this.SA.Checked)
					{
						text = "s_party ='" + this.txtsname.Text + "'";
					}
					else if (this.SA.Checked)
					{
						text = "s_amt =" + this.txtsamount.Text + "";
					}
					else if (this.SR.Checked)
					{
						text = "s_rate =" + this.txtsrate.Text + "";
					}
					else
					{
						if (!this.SRUN.Checked)
						{
							Interaction.MsgBox("Please Select Serche Sesstion Type", MsgBoxStyle.OkOnly, null);
							return;
						}
						text = "S_RUN =" + this.txtsrun.Text + "";
					}
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					if (this.CheckBox1.Checked)
					{
						this.Strsql = string.Concat(new string[]
						{
							"SELECT        s_eid AS Sr_No,  s_amt AS Amount,S_RUN AS Run, s_rate AS Rate, s_mod AS Mode, s_party AS Party_Name, s_bild AS Badli, s_yes AS Yes, s_no AS [No], s_time AS [Time], s_page AS Page_No, s_checked,  s_modify, M_chk FROM SessionTrans WHERE        (S_Sr_No = ",
							this.lblmatchID.Text,
							") AND (",
							text,
							" )  ORDER BY s_eid DESC"
						});
					}
					else
					{
						this.Strsql = string.Concat(new string[]
						{
							"SELECT        s_eid AS Sr_No,  s_amt AS Amount,S_RUN AS Run, s_rate AS Rate, s_mod AS Mode, s_party AS Party_Name, s_bild AS Badli, s_yes AS Yes, s_no AS [No], s_time AS [Time], s_page AS Page_No, s_checked,  s_modify, M_chk FROM SessionTrans WHERE        (S_Sr_No = ",
							this.lblmatchID.Text,
							") AND (Session_ID = ",
							this.comsesstionID.Text,
							") AND (",
							text,
							" ) ORDER BY s_eid DESC"
						});
					}
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(this.Strsql, Module1.conn);
					DataSet dataSet = new DataSet();
					oleDbDataAdapter.Fill(dataSet, "Table1");
					this.DataGridView3.AutoGenerateColumns = true;
					this.DataGridView3.DataSource = dataSet;
					this.DataGridView3.DataMember = "Table1";
					this.DataGridView3.Columns["Run"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["Mode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["Party_Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["Yes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.DataGridView3.Columns["Amount"].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns["Yes"].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns["No"].DefaultCellStyle.Format = this.txtnu.Text;
					this.DataGridView3.Columns["Time"].DefaultCellStyle.Format = "T";
					this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
					int num = 0;
					int num2 = this.DataGridView3.RowCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[11].Value, "1", false))
						{
							this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
						}
						else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[12].Value, "1", false))
						{
							this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
						}
						else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[13].Value, "1", false))
						{
							this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Lime;
						}
					}
					this.DataGridView3.Columns["Page_No"].Visible = false;
					this.DataGridView3.Columns["s_checked"].Visible = false;
					this.DataGridView3.Columns["s_modify"].Visible = false;
					this.DataGridView3.Columns["M_chk"].Visible = false;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x04000506 RID: 1286
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000507 RID: 1287
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000508 RID: 1288
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x04000509 RID: 1289
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer _SplitContainer1;

		// Token: 0x0400050A RID: 1290
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400050B RID: 1291
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400050C RID: 1292
		[AccessedThroughProperty("txtteam")]
		private TextBox _txtteam;

		// Token: 0x0400050D RID: 1293
		[AccessedThroughProperty("txtrate")]
		private TextBox _txtrate;

		// Token: 0x0400050E RID: 1294
		[AccessedThroughProperty("txtamount")]
		private TextBox _txtamount;

		// Token: 0x0400050F RID: 1295
		[AccessedThroughProperty("txtname")]
		private ComboBox _txtname;

		// Token: 0x04000510 RID: 1296
		[AccessedThroughProperty("Rteam")]
		private RadioButton _Rteam;

		// Token: 0x04000511 RID: 1297
		[AccessedThroughProperty("Rrate")]
		private RadioButton _Rrate;

		// Token: 0x04000512 RID: 1298
		[AccessedThroughProperty("Ramunt")]
		private RadioButton _Ramunt;

		// Token: 0x04000513 RID: 1299
		[AccessedThroughProperty("RA")]
		private RadioButton _RA;

		// Token: 0x04000514 RID: 1300
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000515 RID: 1301
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000516 RID: 1302
		[AccessedThroughProperty("txtsname")]
		private ComboBox _txtsname;

		// Token: 0x04000517 RID: 1303
		[AccessedThroughProperty("txtsrun")]
		private TextBox _txtsrun;

		// Token: 0x04000518 RID: 1304
		[AccessedThroughProperty("txtsrate")]
		private TextBox _txtsrate;

		// Token: 0x04000519 RID: 1305
		[AccessedThroughProperty("txtsamount")]
		private TextBox _txtsamount;

		// Token: 0x0400051A RID: 1306
		[AccessedThroughProperty("sessionall")]
		private ComboBox _sessionall;

		// Token: 0x0400051B RID: 1307
		[AccessedThroughProperty("SRUN")]
		private RadioButton _SRUN;

		// Token: 0x0400051C RID: 1308
		[AccessedThroughProperty("SR")]
		private RadioButton _SR;

		// Token: 0x0400051D RID: 1309
		[AccessedThroughProperty("SA")]
		private RadioButton _SA;

		// Token: 0x0400051E RID: 1310
		[AccessedThroughProperty("SN")]
		private RadioButton _SN;

		// Token: 0x0400051F RID: 1311
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000520 RID: 1312
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000521 RID: 1313
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000522 RID: 1314
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000523 RID: 1315
		[AccessedThroughProperty("SplitContainer2")]
		private SplitContainer _SplitContainer2;

		// Token: 0x04000524 RID: 1316
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x04000525 RID: 1317
		[AccessedThroughProperty("lblmatchID")]
		private Label _lblmatchID;

		// Token: 0x04000526 RID: 1318
		[AccessedThroughProperty("comsesstionID")]
		private ComboBox _comsesstionID;

		// Token: 0x04000527 RID: 1319
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x04000528 RID: 1320
		[AccessedThroughProperty("txtnu")]
		private TextBox _txtnu;

		// Token: 0x04000529 RID: 1321
		[AccessedThroughProperty("DataGridView3")]
		private DataGridView _DataGridView3;

		// Token: 0x0400052A RID: 1322
		private string Strsql;

		// Token: 0x0400052B RID: 1323
		private OleDbCommand cmd;

		// Token: 0x0400052C RID: 1324
		private OleDbDataReader dr;
	}
}
