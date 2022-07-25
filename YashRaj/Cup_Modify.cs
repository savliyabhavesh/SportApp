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
using YashAksh.My;

namespace YashAksh
{
	// Token: 0x0200000F RID: 15
	//[DesignerGenerated]
	public partial class Cup_Modify : Form
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x002A391C File Offset: 0x002A1D1C
		public Cup_Modify()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x002A6AF0 File Offset: 0x002A4EF0
		public void find()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Open)
				{
					Module1.conn.Close();
				}
				Module1.conn.Open();
				string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox1.Text + "";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.txtid.Text = Conversions.ToString(oleDbDataReader[0]);
					this.txtdate.Text = Conversions.ToString(oleDbDataReader[1]);
					this.txtteam1.Text = Conversions.ToString(oleDbDataReader[2]);
					this.txtteam2.Text = Conversions.ToString(oleDbDataReader[3]);
					this.txttype.Text = Conversions.ToString(oleDbDataReader[4]);
					this.txth1.Text = Conversions.ToString(oleDbDataReader[5]);
					this.txth2.Text = Conversions.ToString(oleDbDataReader[6]);
					this.txth3.Text = Conversions.ToString(oleDbDataReader[7]);
					this.txth4.Text = Conversions.ToString(oleDbDataReader[8]);
					this.txth5.Text = Conversions.ToString(oleDbDataReader[9]);
					this.txth6.Text = Conversions.ToString(oleDbDataReader[10]);
					this.txth7.Text = Conversions.ToString(oleDbDataReader[11]);
					this.txth8.Text = Conversions.ToString(oleDbDataReader[12]);
					this.txth9.Text = Conversions.ToString(oleDbDataReader[13]);
					this.txth10.Text = Conversions.ToString(oleDbDataReader[14]);
					this.txth11.Text = Conversions.ToString(oleDbDataReader[15]);
					this.txth12.Text = Conversions.ToString(oleDbDataReader[16]);
					this.txth13.Text = Conversions.ToString(oleDbDataReader[17]);
					this.txth14.Text = Conversions.ToString(oleDbDataReader[18]);
					this.txth15.Text = Conversions.ToString(oleDbDataReader[19]);
					this.RedOnly();
				}
				else
				{
					Interaction.MsgBox("Record No", MsgBoxStyle.OkOnly, null);
				}
				Module1.conn.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x002A6D88 File Offset: 0x002A5188
		public void RedOnly()
		{
			try
			{
				if (Operators.CompareString(this.txtid.Text, "", false) != 0)
				{
					this.txtid.ReadOnly = true;
				}
				if (Operators.CompareString(this.txtdate.Text, "", false) != 0)
				{
					this.txtdate.Enabled = false;
				}
				if (Operators.CompareString(this.txtteam1.Text, "", false) != 0)
				{
					this.txtteam1.Enabled = false;
				}
				if (Operators.CompareString(this.txtteam2.Text, "", false) != 0)
				{
					this.txtteam2.Enabled = false;
				}
				if (Operators.CompareString(this.txttype.Text, "", false) != 0)
				{
					this.txttype.Enabled = false;
				}
				if (Operators.CompareString(this.txth1.Text, "", false) != 0)
				{
					this.txth1.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth2.Text, "", false) != 0)
				{
					this.txth2.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth3.Text, "", false) != 0)
				{
					this.txth3.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth4.Text, "", false) != 0)
				{
					this.txth4.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth5.Text, "", false) != 0)
				{
					this.txth5.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth6.Text, "", false) != 0)
				{
					this.txth6.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth8.Text, "", false) != 0)
				{
					this.txth8.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth10.Text, "", false) != 0)
				{
					this.txth10.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth11.Text, "", false) != 0)
				{
					this.txth11.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth12.Text, "", false) != 0)
				{
					this.txth12.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth13.Text, "", false) != 0)
				{
					this.txth13.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth14.Text, "", false) != 0)
				{
					this.txth14.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth15.Text, "", false) != 0)
				{
					this.txth15.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth7.Text, "", false) != 0)
				{
					this.txth7.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth9.Text, "", false) != 0)
				{
					this.txth9.ReadOnly = true;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x002A70DC File Offset: 0x002A54DC
		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Cup_Report.MdiParent = this.MdiParent;
			MyProject.Forms.Cup_Report.Show();
			this.Close();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x002A7108 File Offset: 0x002A5508
		private void Cup_Modify_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x002A711C File Offset: 0x002A551C
		private void Button1_Click(object sender, EventArgs e)
		{
			Module1.conn.Open();
			string cmdText = string.Concat(new string[]
			{
				"Update Newmatch set Team1='",
				this.txtteam1.Text,
				"', Name='",
				this.txtteam2.Text,
				"', Type='",
				this.txttype.Text,
				"', horse1='",
				this.txth1.Text,
				"', horse2='",
				this.txth2.Text,
				"', horse3='",
				this.txth3.Text,
				"', horse4='",
				this.txth4.Text,
				"', horse5='",
				this.txth5.Text,
				"', horse6='",
				this.txth6.Text,
				"', horse7='",
				this.txth7.Text,
				"', horse8='",
				this.txth8.Text,
				"', horse9='",
				this.txth9.Text,
				"', horse10='",
				this.txth10.Text,
				"', horse11='",
				this.txth11.Text,
				"', horse12='",
				this.txth12.Text,
				"', horse13='",
				this.txth13.Text,
				"', horse14='",
				this.txth14.Text,
				"', horse15='",
				this.txth15.Text,
				"' , Date1='",
				this.txtdate.Text,
				"'  Where Sr_No=",
				this.TextBox1.Text,
				""
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
			oleDbCommand.ExecuteNonQuery();
			Module1.conn.Close();
			Interaction.MsgBox("Record saved", MsgBoxStyle.OkOnly, null);
			MyProject.Forms.Cup_Report.MdiParent = this.MdiParent;
			MyProject.Forms.Cup_Report.Show();
			this.Close();
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x002A7378 File Offset: 0x002A5778
		private void txtid_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					SendKeys.Send("{Tab}");
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x040001E4 RID: 484
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001E5 RID: 485
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040001E6 RID: 486
		[AccessedThroughProperty("txth15")]
		private TextBox _txth15;

		// Token: 0x040001E7 RID: 487
		[AccessedThroughProperty("txth14")]
		private TextBox _txth14;

		// Token: 0x040001E8 RID: 488
		[AccessedThroughProperty("txth13")]
		private TextBox _txth13;

		// Token: 0x040001E9 RID: 489
		[AccessedThroughProperty("txth12")]
		private TextBox _txth12;

		// Token: 0x040001EA RID: 490
		[AccessedThroughProperty("txth11")]
		private TextBox _txth11;

		// Token: 0x040001EB RID: 491
		[AccessedThroughProperty("txth10")]
		private TextBox _txth10;

		// Token: 0x040001EC RID: 492
		[AccessedThroughProperty("txth9")]
		private TextBox _txth9;

		// Token: 0x040001ED RID: 493
		[AccessedThroughProperty("txth8")]
		private TextBox _txth8;

		// Token: 0x040001EE RID: 494
		[AccessedThroughProperty("txth7")]
		private TextBox _txth7;

		// Token: 0x040001EF RID: 495
		[AccessedThroughProperty("txth6")]
		private TextBox _txth6;

		// Token: 0x040001F0 RID: 496
		[AccessedThroughProperty("txth5")]
		private TextBox _txth5;

		// Token: 0x040001F1 RID: 497
		[AccessedThroughProperty("txth4")]
		private TextBox _txth4;

		// Token: 0x040001F2 RID: 498
		[AccessedThroughProperty("txth3")]
		private TextBox _txth3;

		// Token: 0x040001F3 RID: 499
		[AccessedThroughProperty("txth2")]
		private TextBox _txth2;

		// Token: 0x040001F4 RID: 500
		[AccessedThroughProperty("txth1")]
		private TextBox _txth1;

		// Token: 0x040001F5 RID: 501
		[AccessedThroughProperty("txttype")]
		private ComboBox _txttype;

		// Token: 0x040001F6 RID: 502
		[AccessedThroughProperty("txtdate")]
		private DateTimePicker _txtdate;

		// Token: 0x040001F7 RID: 503
		[AccessedThroughProperty("txtid")]
		private TextBox _txtid;

		// Token: 0x040001F8 RID: 504
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x040001F9 RID: 505
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x040001FA RID: 506
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x040001FB RID: 507
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x040001FC RID: 508
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040001FD RID: 509
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040001FE RID: 510
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040001FF RID: 511
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000200 RID: 512
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000201 RID: 513
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000202 RID: 514
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000203 RID: 515
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000204 RID: 516
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000205 RID: 517
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000206 RID: 518
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000207 RID: 519
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000208 RID: 520
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000209 RID: 521
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400020A RID: 522
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400020B RID: 523
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400020C RID: 524
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400020D RID: 525
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400020E RID: 526
		[AccessedThroughProperty("txtteam2")]
		private TextBox _txtteam2;

		// Token: 0x0400020F RID: 527
		[AccessedThroughProperty("txtteam1")]
		private TextBox _txtteam1;

		// Token: 0x04000210 RID: 528
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;
	}
}
