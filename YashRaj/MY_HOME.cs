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
using SHAI9167111516;
using YashAksh.My;

namespace YashAksh
{
	// Token: 0x02000053 RID: 83
	[DesignerGenerated]
	public partial class MY_HOME : Form
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x00357AE8 File Offset: 0x00355EE8
		public MY_HOME()
		{
			base.Activated += this.MY_HOME_Activated;
			base.Load += this.MY_HOME_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00357EE0 File Offset: 0x003562E0
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x00357EF4 File Offset: 0x003562F4
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00357F40 File Offset: 0x00356340
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x00357F54 File Offset: 0x00356354
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

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00357F60 File Offset: 0x00356360
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x00357F74 File Offset: 0x00356374
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x00357F80 File Offset: 0x00356380
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x00357F94 File Offset: 0x00356394
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x00357FA0 File Offset: 0x003563A0
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x00357FB4 File Offset: 0x003563B4
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

		// Token: 0x060014D7 RID: 5335 RVA: 0x00357FC0 File Offset: 0x003563C0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (Conversions.ToDouble(this.Label2.Text) <= 60.0)
				{
					Label label = this.Label2;
					label.Text = Conversions.ToString(Conversions.ToDouble(label.Text) + 1.0);
				}
				else
				{
					this.Timer1.Enabled = false;
					TextBox textBox = new TextBox();
					mod_serial_id.GetDriverSerialNumber();
					if (mod_serial_id.serial_number < 0)
					{
						textBox.Text = Conversions.ToString(checked(mod_serial_id.serial_number - mod_serial_id.serial_number - mod_serial_id.serial_number));
					}
					else
					{
						textBox.Text = mod_serial_id.serial_number.ToString();
					}
					Module1.SerialNO = textBox.Text;
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					TextBox textBox2 = new TextBox();
					textBox2.Text = Strings.FormatDateTime(DateTime.Now.Date, DateFormat.ShortDate);
					DateTime t = default(DateTime);
					TextBox textBox3 = new TextBox();
					string cmdText = "Select* from Error1 Where ID=1";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						t = Conversions.ToDate(Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Error_D"]), DateFormat.ShortDate));
						textBox3.Text = Conversions.ToString(oleDbDataReader[1]);
					}
					Module1.conn.Close();
					TextBox textBox4 = new TextBox();
					TextBox textBox5 = new TextBox();
					string text = Conversions.ToString(DateTime.Now.Year);
					if (Operators.CompareString(text, "2016", false) == 0)
					{
						text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
					}
					else
					{
						text = Conversions.ToString(Conversions.ToDouble(text) + 2.0);
					}
					textBox4.Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - 161189.0 * Conversions.ToDouble(text));
					textBox5.Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - 23027.0);
					if (DateTime.Compare(t, Conversions.ToDate(textBox2.Text)) < 0)
					{
						this.Hide();
						MyProject.Forms.Kbys.Show();
					}
					else if (Operators.CompareString(textBox3.Text, textBox5.Text, false) == 0)
					{
						this.Hide();
						MyProject.Forms.Login.Show();
					}
					else if (Operators.CompareString(textBox3.Text, textBox4.Text, false) == 0)
					{
						this.Hide();
						MyProject.Forms.Login.Show();
					}
					else
					{
						this.Hide();
						MyProject.Forms.Kbys.Show();
					}
				}
			}
			catch (Exception ex)
			{
				this.Timer1.Enabled = false;
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				this.Close();
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x003582D4 File Offset: 0x003566D4
		private void MY_HOME_Activated(object sender, EventArgs e)
		{
			try
			{
				Module1.conn = _ParthavI1516.OledbConn;
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Session_ID, Match_ID FROM Session_mst WHERE(Session_ID = 1)";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (!oleDbDataReader.Read())
				{
					string cmdText2 = "INSERT INTO Session_mst (Session_ID, Match_ID) VALUES(1, 1)";
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					oleDbCommand2.ExecuteNonQuery();
				}
				try
				{
					cmdText = "CREATE TABLE tb_MYID ([Id] COUNTER, [tb_MID] Number, [tb_SID] Number, [tb_CID] Number, [tb_AID] Number)";
					oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
					oleDbCommand.Clone();
					cmdText = "SELECT        MAX(tns_MatchID) AS Expr1, MAX(tns_Sessionid) AS Expr2  FROM Trans";
					oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbDataReader = oleDbCommand.ExecuteReader();
					double num;
					double num2;
					if (oleDbDataReader.Read())
					{
						num = Conversions.ToDouble(oleDbDataReader["Expr1"].ToString());
						num2 = Conversions.ToDouble(oleDbDataReader["Expr2"].ToString());
					}
					cmdText = "SELECT        Id  FROM tb_MYID";
					oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbDataReader = oleDbCommand.ExecuteReader();
					if (!oleDbDataReader.Read())
					{
						cmdText = string.Concat(new string[]
						{
							"INSERT INTO tb_MYID    (tb_MID, tb_SID)  VALUES(",
							num.ToString(),
							", ",
							num2.ToString(),
							")"
						});
						oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						oleDbCommand.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
				}
				this.Label2.Hide();
				this.Timer1.Enabled = true;
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x003584A4 File Offset: 0x003568A4
		private void MY_HOME_Load(object sender, EventArgs e)
		{
			this.Label2.Hide();
		}

		// Token: 0x040008B4 RID: 2228
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040008B5 RID: 2229
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040008B6 RID: 2230
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040008B7 RID: 2231
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040008B8 RID: 2232
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
