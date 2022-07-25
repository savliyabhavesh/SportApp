using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SHAI9167111516;

namespace YashAksh
{
	// Token: 0x02000050 RID: 80
	[DesignerGenerated]
	public partial class Kbys : Form
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x003566FC File Offset: 0x00354AFC
		public Kbys()
		{
			base.Load += this.Keys_Load;
			this.pathd = new TextBox();
			this.Expeard = new TextBox();
			this.t2 = new TextBox();
			this.txtIpaddress = new TextBox();
			this.txthostname = new TextBox();
			this.txtDays = new TextBox();
			this.InitializeComponent();
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00356F10 File Offset: 0x00355310
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00356F24 File Offset: 0x00355324
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00356F30 File Offset: 0x00355330
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00356F44 File Offset: 0x00355344
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00356F50 File Offset: 0x00355350
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x00356F64 File Offset: 0x00355364
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00356F70 File Offset: 0x00355370
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00356F84 File Offset: 0x00355384
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00356F90 File Offset: 0x00355390
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x00356FA4 File Offset: 0x003553A4
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00356FB0 File Offset: 0x003553B0
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00356FC4 File Offset: 0x003553C4
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00357010 File Offset: 0x00355410
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x00357024 File Offset: 0x00355424
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00357070 File Offset: 0x00355470
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00357084 File Offset: 0x00355484
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00357090 File Offset: 0x00355490
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x003570A4 File Offset: 0x003554A4
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

		// Token: 0x060014B8 RID: 5304 RVA: 0x003570B0 File Offset: 0x003554B0
		private void Keys_Load(object sender, EventArgs e)
		{
			try
			{
				this.Label4.Hide();
				this.Label5.Hide();
				this.Expeard.Text = Strings.FormatDateTime(DateTime.Now.Date, DateFormat.ShortDate);
				this.GetIPAddress();
				mod_serial_id.GetDriverSerialNumber();
				if (mod_serial_id.serial_number < 0)
				{
					this.TextBox1.Text = Conversions.ToString(checked(mod_serial_id.serial_number - mod_serial_id.serial_number - mod_serial_id.serial_number));
				}
				else
				{
					this.TextBox1.Text = mod_serial_id.serial_number.ToString();
				}
				string text = Conversions.ToString(DateTime.Now.Year);
				if (Operators.CompareString(text, "2016", false) == 0)
				{
					text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
				}
				else
				{
					text = Conversions.ToString(Conversions.ToDouble(text) + 2.0);
				}
				this.Label4.Text = Conversions.ToString(Conversions.ToDouble(this.TextBox1.Text) - 161189.0 * Conversions.ToDouble(text));
				this.Label5.Text = Conversions.ToString(Conversions.ToDouble(this.TextBox1.Text) - 23027.0);
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "delete* from Error1 Where ID=1";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				oleDbCommand.ExecuteNonQuery();
				string cmdText2 = "update Donotopne SET Field1='False' , Field2='False'";
				OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
				oleDbCommand2.ExecuteNonQuery();
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

		// Token: 0x060014B9 RID: 5305 RVA: 0x00357294 File Offset: 0x00355694
		private void GetIPAddress()
		{
			try
			{
				string hostName = Dns.GetHostName();
				string text = Dns.GetHostByName(hostName).AddressList[0].ToString();
				this.txthostname.Text = hostName;
				this.txtIpaddress.Text = text;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x003572F4 File Offset: 0x003556F4
		private static void Show(string p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x003572FC File Offset: 0x003556FC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.Label5.Text, this.TextBox2.Text, false) == 0)
				{
					this.Expeard.Text = Strings.FormatDateTime(DateTime.Now.AddDays(7.0), DateFormat.ShortDate);
					this.txtDays.Text = "7 Days";
				}
				else if (Operators.CompareString(this.Label4.Text, this.TextBox2.Text, false) == 0)
				{
					this.Expeard.Text = "31/12/" + Conversions.ToString(DateTime.Now.Year);
					this.txtDays.Text = "One Year";
				}
				if (Operators.CompareString(this.TextBox2.Text, this.Label4.Text, false) == 0)
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "delete* from Error1 Where ID=1";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
					string cmdText2 = string.Concat(new string[]
					{
						"insert into Error1 Values (1,'",
						this.Label4.Text,
						"','",
						this.Expeard.Text,
						"')"
					});
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					oleDbCommand2.ExecuteNonQuery();
					_ParthavI1516.MY_Add_Days();
					_ParthavI1516.LoginID = Module1.SerialNO;
					_ParthavI1516.Login_Conectiong();
					ProjectData.EndApp();
				}
				else if (Operators.CompareString(this.TextBox2.Text, this.Label5.Text, false) == 0)
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText3 = "delete* from Error1 Where ID=1";
					OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
					oleDbCommand3.ExecuteNonQuery();
					string cmdText4 = string.Concat(new string[]
					{
						"insert into Error1 Values (1,'",
						this.Label5.Text,
						"','",
						this.Expeard.Text,
						"')"
					});
					OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText4, Module1.conn);
					oleDbCommand4.ExecuteNonQuery();
					_ParthavI1516.MY_Add_Days();
					_ParthavI1516.LoginID = Module1.SerialNO;
					_ParthavI1516.Login_Conectiong();
					ProjectData.EndApp();
				}
				else
				{
					MessageBox.Show("Please Contact Administrator ..? Key Not Working..", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					MessageBox.Show("Thank You Sir...?", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please Contact Administrator..?", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x003575E0 File Offset: 0x003559E0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0400089D RID: 2205
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x0400089E RID: 2206
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400089F RID: 2207
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040008A0 RID: 2208
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008A1 RID: 2209
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040008A2 RID: 2210
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040008A3 RID: 2211
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040008A4 RID: 2212
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040008A5 RID: 2213
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040008A6 RID: 2214
		private TextBox pathd;

		// Token: 0x040008A7 RID: 2215
		private TextBox Expeard;

		// Token: 0x040008A8 RID: 2216
		private TextBox t2;

		// Token: 0x040008A9 RID: 2217
		private TextBox txtIpaddress;

		// Token: 0x040008AA RID: 2218
		private TextBox txthostname;

		// Token: 0x040008AB RID: 2219
		private TextBox txtDays;
	}
}
