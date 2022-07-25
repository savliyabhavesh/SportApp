using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;

namespace YashAksh
{
	// Token: 0x020000CD RID: 205
	[DesignerGenerated]
	public partial class TransactionReport : Form
	{
		// Token: 0x06002491 RID: 9361 RVA: 0x003CC6BC File Offset: 0x003CAABC
		public TransactionReport()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x003D11AC File Offset: 0x003CF5AC
		private void TransactionReport_Activated(object sender, EventArgs e)
		{
			try
			{
				this.txttraName.Focus();				
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x003D1200 File Offset: 0x003CF600
		private void TransactionReport_Load(object sender, EventArgs e)
		{
			try
			{
				this.WindowState = FormWindowState.Maximized;
				this.DataGridView1.Rows.Clear();
				this.txtdate.Hide();
				this.Button4.Hide();
				this.Button5.Hide();
				this.txtname.Text = Conversions.ToString(Module1.tranID);
				this.txtnu.Text = Module1.decimalnumberformat;
				this.CheckBox1.Hide();
				this.hide_all();
				this.DataGridView4.Hide();
				this.name_lode();
				this.DataGridView5.Rows.Add();
				this.DataGridView5.Rows.Add();
				this.DataGridView6.Rows.Add();
				this.DataGridView6.Rows.Add();
				this.txtremark.CharacterCasing = CharacterCasing.Upper;
				this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
				this.Label11.Hide();
				this.ComboBox1.Hide();
				this.ComboBox3.Hide();
				this.Opning_Balance();
				this.Match();
				this.CUP();
				this.Session();
				//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
				//{
				//	double num = Conversions.ToDouble(this.Label9.Text);
				//	if (num >= 0.49)
				//	{
				//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
				//	}
				//	if (num <= -0.49)
				//	{
				//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
				//	}
				//}
				//else
				//{
					this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
				//}
				this.txttraName.Focus();
				this.Panel5.Hide();
				this.txttraName.Focus();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x003D14C8 File Offset: 0x003CF8C8
		public void colors()
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = this.DataGridView1.RowCount - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[2].Value, 0, false))
						{
							this.DataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Red;
						}
						else
						{
							this.DataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Green;
						}
					}
					if (Conversions.ToDouble(this.Label9.Text) < 0.0)
					{
						this.Label9.ForeColor = Color.Red;
					}
					else
					{
						this.Label9.ForeColor = Color.Green;
					}
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x003D1680 File Offset: 0x003CFA80
		public void hide_all()
		{
			this.TextBox3.Hide();
			this.Button3.Hide();
			this.txtnu.Hide();
			this.txtdate.Hide();
			this.ComboBox2.Hide();
			this.TextBox1.Hide();
			this.Button10.Hide();
			this.Button8.Hide();
			this.Button1.Hide();
			this.Button9.Hide();
			this.Button11.Hide();
			this.DataGridView5.Hide();
			this.Button12.Hide();
			this.DataGridView6.Hide();
			this.TextBox2.Hide();
			this.TextBox5.Hide();
			this.TextBox4.Hide();
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x003D1748 File Offset: 0x003CFB48
		public void name_lode()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT Party_name, ID FROM(Newparty)ORDER BY Party_name";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				this.txttraName.Items.Clear();
				this.txtname.Items.Clear();
				while (oleDbDataReader.Read())
				{
					this.txttraName.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Party_name"])).ToString();
					this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Party_name"])).ToString();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x003D1840 File Offset: 0x003CFC40
		private void btnoldrecord_Click(object sender, EventArgs e)
		{
			try
			{
				Module1.tranID = this.txtname.Text.ToString();
				MyProject.Forms.PrevoiusData.MdiParent = this.MdiParent;
				MyProject.Forms.PrevoiusData.WindowState = FormWindowState.Maximized;
				MyProject.Forms.PrevoiusData.Show();
				this.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			this.Close();
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x003D18D0 File Offset: 0x003CFCD0
		public void Match()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT DISTINCT Trans.tns_MatchID, Newmatch.Date1 FROM            (Newmatch INNER JOIN Trans ON Newmatch.Sr_No = Trans.tns_MatchID) GROUP BY Trans.tns_dt, Trans.tns_party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final, Trans.tns_MatchID, Newmatch.Date1 HAVING        (Trans.tns_party = '" + this.txtname.Text + "') AND (Trans.tns_chk = '0') AND (Trans.tns_Monday_Final = 'No')  AND (Trans.tns_Type <> 'Monday Settlement') AND (Trans.tns_Type <> 'ABDN') AND  (Trans.tns_Type <> 'Extra') AND (Trans.tns_Type <> 'CUP') AND (Trans.tns_Type <> 'Tie')AND (Trans.tns_Type <> 'Toss')";
					   cmdText = "SELECT DISTINCT Trans.tns_MatchID, Newmatch.Date1 FROM            (Newmatch INNER JOIN Trans ON Newmatch.Sr_No = Trans.tns_MatchID) GROUP BY Trans.tns_dt, Trans.tns_party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final, Trans.tns_MatchID, Newmatch.Date1 HAVING        (Trans.tns_party = '" + this.txtname.Text + "') AND (Trans.tns_chk = '0') AND (Trans.tns_Monday_Final = 'No') AND (Trans.tns_Type <> 'Monday Settlement') AND (Trans.tns_Type <> 'Extra') AND (Trans.tns_Type <> 'CUP') AND  (Trans.tns_Type <> 'Toss')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        Trans.tns_party, Trans.tns_chk, Trans.tns_Monday_Final, Trans.tns_MatchID, SUM(Trans.tns_Amount) AS Expr1, Newmatch.Date1, Newmatch.Team1, Newmatch.Name, Newmatch.Type FROM            (Trans INNER JOIN  Newmatch ON Trans.tns_MatchID = Newmatch.Sr_No) GROUP BY Trans.tns_party, Trans.tns_chk, Trans.tns_Monday_Final, Trans.tns_MatchID, Newmatch.Date1, Newmatch.Team1, Newmatch.Name, Newmatch.Type HAVING        (Trans.tns_MatchID = ", oleDbDataReader["tns_MatchID"]), ") AND (Trans.tns_party = '"), this.txtname.Text), "') AND (Trans.tns_chk <> '1') AND (Trans.tns_Monday_Final = 'No')"));
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader2.Read())
					{
						int index = this.DataGridView1.Rows.Add();
						this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader2["Date1"]), DateFormat.ShortDate);
						this.DataGridView1.Rows[index].Cells[1].Value = string.Concat(new string[]
						{
							"Match - ",
							oleDbDataReader2["tns_MatchID"].ToString(),
							" - ",
							oleDbDataReader2["Team1"].ToString(),
							" VS ",
							oleDbDataReader2["Name"].ToString()
						});
						this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])), this.txtnu.Text);
						this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
						this.DataGridView1.Rows[index].Cells[4].Value = "Match";
						this.DataGridView1.Rows[index].Cells[5].Value = "0";
						this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"]));
					}
				}
				this.Match_Toss();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x003D1BD0 File Offset: 0x003CFFD0
		public void Match_Toss()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Trans.tns_dt, SUM(tns_Amount) AS Expr1, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID FROM            (Newmatch INNER JOIN Trans ON Newmatch.Sr_No = Trans.tns_MatchID) GROUP BY Trans.tns_dt, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID HAVING        (Trans.tns_Party = '" + this.txtname.Text + "') AND (Trans.tns_Type = 'Toss') AND (Trans.tns_chk = '0') AND (Trans.tns_Monday_Final = 'No')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark, ID FROM(Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark, ID HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_Type = 'Toss') AND (tns_chk = '0') AND (tns_Monday_Final = 'No') AND (tns_MatchID =", oleDbDataReader["tns_MatchID"]), ") ORDER BY ID"));
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader2.Read())
					{
						int index = this.DataGridView1.Rows.Add();
						this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView1.Rows[index].Cells[1].Value = Operators.ConcatenateObject("Toss-", oleDbDataReader2["tns_Remark"]);
						this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
						this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
						this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
						this.DataGridView1.Rows[index].Cells[5].Value = "0";
						this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
					}
				}
				oleDbCommand.Clone();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x003D1E68 File Offset: 0x003D0268
		public void ABDN()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Trans.tns_dt, SUM(tns_Amount) AS Expr1, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID FROM            (Newmatch INNER JOIN Trans ON Newmatch.Sr_No = Trans.tns_MatchID) GROUP BY Trans.tns_dt, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID HAVING        (Trans.tns_Party = '" + this.txtname.Text + "') AND (Trans.tns_Type = 'ABDN') AND (Trans.tns_chk = '0') AND (Trans.tns_Monday_Final = 'No')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark, ID FROM(Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark, ID HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_Type = 'ABDN') AND (tns_chk = '0') AND (tns_Monday_Final = 'No') AND (tns_MatchID =", oleDbDataReader["tns_MatchID"]), ") ORDER BY ID"));
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader2.Read())
					{
						int index = this.DataGridView1.Rows.Add();
						this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView1.Rows[index].Cells[1].Value = Operators.ConcatenateObject("ABDN-", oleDbDataReader2["tns_Remark"]);
						this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
						this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
						this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
						this.DataGridView1.Rows[index].Cells[5].Value = "0";
						this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x003D20FC File Offset: 0x003D04FC
		public void Tie()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Trans.tns_dt, SUM(tns_Amount) AS Expr1, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID FROM            (Newmatch INNER JOIN Trans ON Newmatch.Sr_No = Trans.tns_MatchID) GROUP BY Trans.tns_dt, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID HAVING        (Trans.tns_Party = '" + this.txtname.Text + "') AND (Trans.tns_Type = 'Tie') AND (Trans.tns_chk = '0') AND (Trans.tns_Monday_Final = 'No')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark,  ID FROM(Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark,  ID HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_Type = 'Tie') AND (tns_chk = '0') AND (tns_Monday_Final = 'No') AND (tns_MatchID =", oleDbDataReader["tns_MatchID"]), ") ORDER BY ID"));
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader2.Read())
					{
						int index = this.DataGridView1.Rows.Add();
						this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView1.Rows[index].Cells[1].Value = Operators.ConcatenateObject("Tie-", oleDbDataReader2["tns_Remark"]);
						this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
						this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
						this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
						this.DataGridView1.Rows[index].Cells[5].Value = "0";
						this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x003D2390 File Offset: 0x003D0790
		public void CUP()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Trans.tns_dt, SUM(tns_Amount) AS Expr1, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID FROM            (Newmatch INNER JOIN Trans ON Newmatch.Sr_No = Trans.tns_MatchID) GROUP BY Trans.tns_dt, Trans.tns_Party, Trans.tns_Type, Trans.tns_chk, Trans.tns_Monday_Final,Trans.tns_MatchID HAVING        (Trans.tns_Party = '" + this.txtname.Text + "') AND (Trans.tns_Type = 'CUP') AND (Trans.tns_chk = '0') AND (Trans.tns_Monday_Final = 'No')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark, ID FROM(Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_Monday_Final, tns_MatchID, tns_Remark, ID HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_Type = 'CUP') AND (tns_chk = '0') AND (tns_Monday_Final = 'No') AND (tns_MatchID =", oleDbDataReader["tns_MatchID"]), ") ORDER BY ID"));
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader2.Read())
					{
						int index = this.DataGridView1.Rows.Add();
						this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView1.Rows[index].Cells[1].Value = Operators.ConcatenateObject("CUP -", oleDbDataReader2["tns_Remark"]);
						this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
						this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
						this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
						this.DataGridView1.Rows[index].Cells[5].Value = "0";
						this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x003D2624 File Offset: 0x003D0A24
		public void Session()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				this.AKD();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x003D268C File Offset: 0x003D0A8C
		public void AKD()
		{
			checked
			{
				try
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					double num = 0.0;
					int num2 = 0;
					int num3 = this.DataGridView1.Rows.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						unchecked
						{
							num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[2].Value));
							if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, "", false))
							{
								this.DataGridView1.Rows[i].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
								if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[6].Value, 0, false))
								{
									this.DataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Red;
								}
								else
								{
									this.DataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Green;
								}
							}
						}
					}
					this.Extra_Total();
					this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.txtClosingBalance), this.txtnu.Text);
					this.colors();
					this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
					this.txtClosingBalance = 0.0;
					this.txttraName.Focus();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
				finally
				{
				}
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x003D28C0 File Offset: 0x003D0CC0
		public void Extra_Total()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        tns_Party, SUM(tns_Amount) AS Expr1, tns_Type, tns_Monday_Final, tns_chk FROM(Trans) GROUP BY tns_Party, tns_Type, tns_Monday_Final, tns_chk HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_Type = 'Extra') AND (tns_Monday_Final = 'No') AND (tns_chk = '0')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.txtClosingBalance = Conversions.ToDouble(Operators.AddObject(this.txtClosingBalance, oleDbDataReader["Expr1"]));
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x003D297C File Offset: 0x003D0D7C
		private void Button10_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[0].Cells[2].Value, 0, false))
			{
				this.DataGridView1.Rows[0].Cells[2].Style.ForeColor = Color.Red;
			}
			else
			{
				this.DataGridView1.Rows[0].Cells[2].Style.ForeColor = Color.Green;
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x003D2A10 File Offset: 0x003D0E10
		private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[3].Value, null, false))
			{
				this.TextBox1.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[3].Value);
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x003D2A70 File Offset: 0x003D0E70
		private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridView1.CurrentRow.Cells[4].Value, null, false), Operators.CompareObjectEqual(this.DataGridView1.CurrentRow.Cells[3].Value, null, false))))
				{
					this.Panel5.Visible = false;
					this.DataGridView4.Hide();
				}
				else
				{
					this.DataGridView4.Rows.Clear();
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText;
					if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, "0", false))
					{
						cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        tns_Party, tns_Type, tns_chk, tns_MatchID, tns_Remark, tns_Amount AS Expr1,tns_Sessionid FROM(Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_MatchID, tns_Remark, ID, tns_Amount,tns_Sessionid HAVING        (tns_Party = '" + this.txtname.Text + "')   AND (tns_chk = '0') AND (tns_MatchID = ", this.DataGridView1.CurrentRow.Cells[3].Value), ")ORDER BY tns_Type, Id"));
					}
					else
					{
						cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        Trans.tns_Type, SUM(tns_Amount) AS Expr1, Trans.tns_dt, Trans.tns_Party, Trans.tns_Monday_Final, Trans.tns_chk, Trans.tns_MatchID, Trans.tns_Sessionid, Trans.tns_Remark FROM            (ewSession INNER JOIN Trans ON ewSession.Sr_No = Trans.tns_Sessionid)GROUP BY Trans.tns_Type, Trans.tns_dt, Trans.tns_Party, Trans.tns_Monday_Final, Trans.tns_chk, Trans.tns_MatchID, Trans.tns_Sessionid, Trans.tns_Remark HAVING        (Trans.tns_Type = '", this.DataGridView1.CurrentRow.Cells[5].Value), "') AND (Trans.tns_Party = '"), this.txtname.Text), "') AND (Trans.tns_Monday_Final = 'No') AND (Trans.tns_chk = '0') AND (Trans.tns_MatchID = "), this.DataGridView1.CurrentRow.Cells[3].Value), ")"));
					}
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					double num = 0;
					while (oleDbDataReader.Read())
					{
						int index = this.DataGridView4.Rows.Add();
						this.DataGridView4.Rows[index].Cells[0].Value = oleDbDataReader["tns_Remark"].ToString();
						this.DataGridView4.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
						this.DataGridView4.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
						this.DataGridView4.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
						this.DataGridView4.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Sessionid"]);
						num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
					}
					this.DataGridView4.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
					int num2 = 0;
					checked
					{
						int num3 = this.DataGridView4.RowCount - 1;
						for (int i = num2; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[i].Cells[1].Value, 0, false))
							{
								this.DataGridView4.Rows[i].Cells[1].Style.ForeColor = Color.Red;
							}
							else
							{
								this.DataGridView4.Rows[i].Cells[1].Style.ForeColor = Color.Green;
							}
						}
						int num4 = 0;
						int num5 = this.DataGridView4.RowCount - 1;
						for (int j = num4; j <= num5; j++)
						{
							if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[j].Cells[2].Value, 0, false))
							{
								this.DataGridView4.Rows[j].Cells[2].Style.ForeColor = Color.Red;
							}
							else
							{
								this.DataGridView4.Rows[j].Cells[2].Style.ForeColor = Color.Green;
							}
						}
						this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
						this.Panel5.Visible = true;
						this.DataGridView4.Show();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x003D2F88 File Offset: 0x003D1388
		public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
		{
			checked
			{
				string text;
				if (e.KeyChar == '\b')
				{
					if (this.txttraName.SelectionStart <= 1)
					{
						this.txttraName.Text = "";
						return;
					}
					if (this.txttraName.SelectionLength == 0)
					{
						text = this.txttraName.Text.Substring(0, this.txttraName.Text.Length - 1);
					}
					else
					{
						text = this.txttraName.Text.Substring(0, this.txttraName.SelectionStart - 1);
					}
				}
				else if (this.txttraName.SelectionLength == 0)
				{
					text = this.txttraName.Text + Conversions.ToString(e.KeyChar);
				}
				else
				{
					text = this.txttraName.Text.Substring(0, this.txttraName.SelectionStart) + Conversions.ToString(e.KeyChar);
				}
				int num = this.txttraName.FindString(text);
				if (num != -1)
				{
					this.txttraName.SelectedText = "";
					this.txttraName.SelectedIndex = num;
					this.txttraName.SelectionStart = text.Length;
					this.txttraName.SelectionLength = this.txttraName.Text.Length;
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

		// Token: 0x06002561 RID: 9569 RVA: 0x003D30E4 File Offset: 0x003D14E4
		private void txttraName_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				ComboBox txttraName = this.txttraName;
				this.AutoComplete(ref txttraName, e, false);
				this.txttraName = txttraName;
				if (Operators.CompareString(this.txttraName.Text, null, false) == 0)
				{
					this.Label7.Text = "0.00";
				}
				this.Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x003D316C File Offset: 0x003D156C
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txttraName.Text, null, false) == 0)
				{
					this.Label7.Text = "0.00";
				}
				else
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "select sum(tns_Amount) AS Exp2 from Trans where tns_Party='" + this.txttraName.Text + "' and tns_Type<>'Monday Settlement' and tns_Monday='0'and tns_chk='0'";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					double num = 0;
					while (oleDbDataReader.Read())
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader["Exp2"])))
						{
							num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Exp2"]));
						}
					}
					string cmdText2 = "SELECT        Party_name, SUM(Amount) AS Expr1,dt FROM(OP_BAL) GROUP BY Party_name,dt HAVING        (Party_name = '" + this.txttraName.Text + "')";
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					double num2 = 0;
					while (oleDbDataReader2.Read())
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])))
						{
							num2 = Conversions.ToDouble(Operators.AddObject(num2, oleDbDataReader2["Expr1"]));
						}
					}
					oleDbCommand2.Dispose();
					this.Label7.Text = Module1.SetNumFormat(Conversion.Val(num) + Conversion.Val(num2), this.txtnu.Text);
					if (Conversions.ToDouble(this.Label7.Text) < 0.0)
					{
						this.Label7.ForeColor = Color.Red;
					}
					else
					{
						this.Label7.ForeColor = Color.Green;
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x003D336C File Offset: 0x003D176C
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txttraName.Text, "", false) == 0)
				{
					Interaction.MsgBox("Insert the Party Name ?", MsgBoxStyle.OkOnly, null);
					this.txttraName.Focus();
				}
				else if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Insert Amount ?", MsgBoxStyle.OkOnly, null);
					this.txtamount.Focus();
				}
				else if (Operators.CompareString(this.txtamount.Text, "0.00", false) == 0)
				{
					Interaction.MsgBox("Please Insert Amount ?", MsgBoxStyle.OkOnly, null);
					this.txtamount.Focus();
				}
				else if (Operators.CompareString(this.txttraName.Text, this.txtname.Text, false) == 0)
				{
					MessageBox.Show("Error");
					this.txttraName.Text = null;
					this.txttraName.Focus();
				}
				else
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "select * from Newparty where Party_name='" + this.txttraName.Text + "'";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					string text;
					if (Operators.CompareString(this.txtremark.Text, null, false) == 0)
					{
						text = " ";
					}
					else
					{
						text = " (" + this.txtremark.Text + ")";
					}
					if (oleDbDataReader.Read())
					{
						if (Conversions.ToDouble(this.txtamount.Text) > 0.0)
						{
							this.DataGridView5.Rows[0].Cells[0].Value = this.txttraName.Text;
							this.DataGridView5.Rows[0].Cells[1].Value = Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text);
							this.DataGridView5.Rows[0].Cells[2].Value = this.txtname.Text + text.ToString();
							this.DataGridView5.Rows[0].Cells[3].Value = "0";
							this.DataGridView5.Rows[1].Cells[0].Value = this.txtname.Text;
							this.DataGridView5.Rows[1].Cells[1].Value = this.txtamount.Text;
							this.DataGridView5.Rows[1].Cells[2].Value = this.txttraName.Text + text.ToString();
							this.DataGridView5.Rows[1].Cells[3].Value = "1";
						}
						else
						{
							this.DataGridView5.Rows[0].Cells[0].Value = this.txttraName.Text;
							this.DataGridView5.Rows[0].Cells[1].Value = Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text);
							this.DataGridView5.Rows[0].Cells[2].Value = this.txtname.Text + text.ToString();
							this.DataGridView5.Rows[0].Cells[3].Value = "0";
							this.DataGridView5.Rows[1].Cells[0].Value = this.txtname.Text;
							this.DataGridView5.Rows[1].Cells[1].Value = this.txtamount.Text;
							this.DataGridView5.Rows[1].Cells[2].Value = this.txttraName.Text + text.ToString();
							this.DataGridView5.Rows[1].Cells[3].Value = "1";
						}
						string cmdText2 = "select max(tns_ModifyID)from Trans";
						OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
						checked
						{
							int num;
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
							{
								num = Conversions.ToInteger("1");
							}
							else
							{
								num = Conversions.ToInteger(oleDbCommand2.ExecuteScalar());
								num++;
							}
							this.TextBox4.Text = Conversions.ToString(num);
							try
							{
								foreach (object obj in ((IEnumerable)this.DataGridView5.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
									{
										if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, 0, false))
										{
											if (Module1.conn.State == ConnectionState.Closed)
											{
												Module1.conn.Open();
											}
											string cmdText3 = "insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala) values(@tns_Party,@tns_Amount,@tns_Remark,@tns_matchid,@tns_dt,@tns_type,@tns_vid,@tns_monday,@tns_sessionid,@tns_ModifyID,@tns_Monday_Final,@tns_Hawala)";
											OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
											oleDbCommand3.Parameters.AddWithValue("@tns_Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
											oleDbCommand3.Parameters.AddWithValue("@tns_Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
											oleDbCommand3.Parameters.AddWithValue("@tns_Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
											oleDbCommand3.Parameters.AddWithValue("@tns_matchid", "0");
											oleDbCommand3.Parameters.AddWithValue("@tns_dt", this.txtdate.Text);
											oleDbCommand3.Parameters.AddWithValue("@tns_type", "Extra");
											oleDbCommand3.Parameters.AddWithValue("@tns_vid", "0");
											oleDbCommand3.Parameters.AddWithValue("@tns_monday", "0");
											oleDbCommand3.Parameters.AddWithValue("@tns_sessionid", "0");
											oleDbCommand3.Parameters.AddWithValue("@tns_ModifyID", this.TextBox4.Text);
											oleDbCommand3.Parameters.AddWithValue("@tns_Monday_Final", "No");
											oleDbCommand3.Parameters.AddWithValue("@tns_Hawala", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value));
											oleDbCommand3.ExecuteNonQuery();
										}
									}
								}
							}
							finally
							{								
							}
							this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
							this.txttraName.Focus();
							this.Opning_Balance();
							this.Match();
							this.ABDN();
							this.Tie();
							this.CUP();
							this.Session();
							//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
							//{
							//	double num2 = Conversions.ToDouble(this.Label9.Text);
							//	if (num2 >= 0.49)
							//	{
							//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
							//	}
							//	if (num2 <= -0.49)
							//	{
							//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
							//	}
							//}
							//else
							//{
								this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
							//}
							this.txttraName.Text = "";
							this.txtamount.Text = "";
							this.txtremark.Text = "";
							this.Label7.Text = "";
						}
					}
					else
					{
						Interaction.MsgBox("Please Create A/C Than Proced...?", MsgBoxStyle.OkOnly, null);
						this.txttraName.Text = null;
						this.txttraName.Focus();
					}
				}
				this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x003D3CC4 File Offset: 0x003D20C4
		private void txtamount_Leave(object sender, EventArgs e)
		{
			this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x003D3CF8 File Offset: 0x003D20F8
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				this.DataGridView2.Rows.Clear();
				this.DataGridView3.Rows.Clear();
				this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT    ID, tns_Party, tns_Amount, tns_Remark, tns_Type,tns_dt,tns_ModifyID, tns_Monday_Final, tns_chk FROM(Trans) WHERE        (tns_Party = '" + this.txtname.Text + "') AND (tns_Type = 'Extra') AND (tns_Monday_Final = 'No')ORDER BY ID DESC";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(oleDbDataReader["tns_Amount"], 0, false), Operators.CompareObjectEqual(oleDbDataReader["tns_chk"], "1", false))))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView2.Rows[index].Cells[1].Value = oleDbDataReader["tns_Remark"].ToString();
						this.DataGridView2.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
						this.DataGridView2.Rows[index].Cells[3].Value = oleDbDataReader["tns_ModifyID"].ToString();
						this.DataGridView2.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(oleDbDataReader["tns_Amount"], 0, false), Operators.CompareObjectEqual(oleDbDataReader["tns_chk"], "1", false))))
					{
						int index2 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index2].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView3.Rows[index2].Cells[1].Value = oleDbDataReader["tns_Remark"].ToString();
						this.DataGridView3.Rows[index2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
						this.DataGridView3.Rows[index2].Cells[3].Value = oleDbDataReader["tns_ModifyID"].ToString();
						this.DataGridView3.Rows[index2].DefaultCellStyle.ForeColor = Color.Red;
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(oleDbDataReader["tns_Amount"], 0, false), Operators.CompareObjectEqual(oleDbDataReader["tns_chk"], "0", false))))
					{
						int index3 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index3].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView2.Rows[index3].Cells[1].Value = oleDbDataReader["tns_Remark"].ToString();
						this.DataGridView2.Rows[index3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
						this.DataGridView2.Rows[index3].Cells[3].Value = oleDbDataReader["tns_ModifyID"].ToString();
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(oleDbDataReader["tns_Amount"], 0, false), Operators.CompareObjectEqual(oleDbDataReader["tns_chk"], "0", false))))
					{
						int index4 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index4].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
						this.DataGridView3.Rows[index4].Cells[1].Value = oleDbDataReader["tns_Remark"].ToString();
						this.DataGridView3.Rows[index4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
						this.DataGridView3.Rows[index4].Cells[3].Value = oleDbDataReader["tns_ModifyID"].ToString();
					}
				}
				this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
				this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
				this.txttraName.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x003D432C File Offset: 0x003D272C
		private void Monday_Final_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Do You Want to Make Monday Settlement..?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int num = this.DataGridView6.Rows.Add();
					this.DataGridView6.Rows[0].Cells[0].Value = this.txtname.Text;
					this.DataGridView6.Rows[0].Cells[1].Value = this.Label9.Text;
					this.DataGridView6.Rows[0].Cells[2].Value = "Monday Final " + this.txtdate.Text;
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "update Trans set tns_Monday_Final='Yes' where tns_Party='" + this.txtname.Text + "'";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView6.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
							{
								if (Module1.conn.State == ConnectionState.Closed)
								{
									Module1.conn.Open();
								}
								string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Trans(tns_Party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_Monday_Final)VALUES('", dataGridViewRow.Cells[0].Value), "',"), dataGridViewRow.Cells[1].Value), " ,'"), dataGridViewRow.Cells[2].Value), "',0,'"), this.txtdate.Text), "','Monday Settlement',0,1,0,'Yes')"));
								OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
								oleDbCommand2.ExecuteNonQuery();
							}
						}
					}
					finally
					{
						//IEnumerator enumerator;
						//if (enumerator is IDisposable)
						//{
						//	(enumerator as IDisposable).Dispose();
						//}
						Module1.conn.Open();
					}
					this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
					this.Opning_Balance();
					this.Match();
					this.ABDN();
					this.Tie();
					this.CUP();
					this.Session();
					//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
					//{
					//	double num2 = Conversions.ToDouble(this.Label9.Text);
					//	if (num2 >= 0.49)
					//	{
					//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
					//	}
					//	if (num2 <= -0.49)
					//	{
					//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
					//	}
					//}
					//else
					//{
						this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
					//}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x003D46D4 File Offset: 0x003D2AD4
		public void show12()
		{
			try
			{
				this.DataGridView2.Rows.Clear();
				this.DataGridView3.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "select * from Trans where tns_Party='" + this.txtname.Text + "' and tns_Type='Extra' and tns_Monday_Final='Yes'";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (!oleDbDataReader.Read())
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(oleDbDataReader[2], 0, false), Operators.CompareObjectEqual(oleDbDataReader[13], "1", false))))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index].Cells[2].Value = Module1.SetNumFormat(Operators.ConcatenateObject(this.DataGridView2.Rows[index].Cells[2].Value, this.txtnu.Text), "");
						this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
						this.DataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Red;
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(oleDbDataReader[2], 0, false), Operators.CompareObjectEqual(oleDbDataReader[13], "1", false))))
					{
						int index2 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView3.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView3.Rows[index2].Cells[2].Value = Module1.SetNumFormat(Operators.ConcatenateObject(this.DataGridView3.Rows[index2].Cells[2].Value, this.txtnu.Text), "");
						this.DataGridView3.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
						this.DataGridView3.Rows[index2].DefaultCellStyle.BackColor = Color.Red;
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(oleDbDataReader[2], 0, false), Operators.CompareObjectEqual(oleDbDataReader[13], "0", false))))
					{
						int index3 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView2.Rows[index3].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView2.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView2.Rows[index3].Cells[2].Value = Module1.SetNumFormat(Operators.ConcatenateObject(this.DataGridView2.Rows[index3].Cells[2].Value, this.txtnu.Text), "");
						this.DataGridView2.Rows[index3].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(oleDbDataReader[2], 0, false), Operators.CompareObjectEqual(oleDbDataReader[13], "0", false))))
					{
						int index4 = this.DataGridView3.Rows.Add();
						this.DataGridView3.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
						this.DataGridView3.Rows[index4].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
						this.DataGridView3.Rows[index4].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
						this.DataGridView3.Rows[index4].Cells[2].Value = Module1.SetNumFormat(Operators.ConcatenateObject(this.DataGridView3.Rows[index4].Cells[2].Value, this.txtnu.Text), "");
						this.DataGridView3.Rows[index4].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x003D4D6C File Offset: 0x003D316C
		private void txtmodify_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT tns_Party, tns_Amount, tns_Remark, tns_ModifyID, tns_chk, tns_Type FROM Trans WHERE (tns_Type = 'Extra') AND (tns_chk = '0') AND (tns_ModifyID = " + this.TextBox5.Text + ")";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					if (Operators.CompareString(oleDbDataReader["tns_Party"].ToString(), this.txtname.Text, false) == 0)
					{
						cmdText = "SELECT tns_Party, tns_Amount, tns_Remark, tns_ModifyID, tns_chk, tns_Type FROM Trans WHERE        (tns_Type = 'Extra') AND (tns_chk = '0') AND (tns_ModifyID = " + this.TextBox5.Text + ") ORDER BY ID DESC";
						OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, Module1.conn);
						OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
						if (oleDbDataReader2.Read())
						{
							this.txttraName.Text = oleDbDataReader2["tns_Party"].ToString();
							this.txtamount.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])));
							string text = oleDbDataReader2["tns_Remark"].ToString();
							string text2 = text.Replace(this.txtname.Text, "");
							this.txtremark.Text = text2.ToString();
							this.Button4.Show();
							this.Button5.Show();
							this.Button6.Hide();
							this.txttraName.Focus();
						}
					}
					else
					{
						this.txttraName.Text = oleDbDataReader["tns_Party"].ToString();
						this.txtamount.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])));
						string text3 = oleDbDataReader["tns_Remark"].ToString();
						string text4 = text3.Replace(this.txtname.Text, "");
						this.txtremark.Text = text4.ToString();
						this.Button4.Show();
						this.Button5.Show();
						this.Button6.Hide();
						this.txttraName.Focus();
					}
				}
				else
				{
					Interaction.MsgBox("Cannot modify this Records ? Please Try..?", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x003D5044 File Offset: 0x003D3444
		private void DataGridView3_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				this.TextBox5.Text = Conversions.ToString(this.DataGridView3.CurrentRow.Cells[3].Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x003D509C File Offset: 0x003D349C
		private void DataGridView2_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				this.TextBox5.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x003D50F4 File Offset: 0x003D34F4
		private void BTNDELETE_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.TextBox5.Text, null, false) != 0)
				{
					if (Interaction.MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
					{
						if (Module1.conn.State == ConnectionState.Closed)
						{
							Module1.conn.Open();
						}
						string cmdText = "select tns_ModifyID,tns_chk from Trans where tns_ModifyID=" + this.TextBox5.Text + " and  tns_chk='1'";
						OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
						if (oleDbDataReader.Read())
						{
							Interaction.MsgBox("Cannot delete this records?", MsgBoxStyle.OkOnly, null);
						}
						else
						{
							string cmdText2 = "update Trans set tns_chk='1' where tns_ModifyID=" + this.TextBox5.Text + " ";
							OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
							oleDbCommand2.ExecuteNonQuery();
							this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
							this.Opning_Balance();
							this.Match();
							this.ABDN();
							this.Tie();
							this.CUP();
							this.Session();
							//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
							//{
							//	double num = Conversions.ToDouble(this.Label9.Text);
							//	if (num >= 0.49)
							//	{
							//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
							//	}
							//	if (num <= -0.49)
							//	{
							//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
							//	}
							//}
							//else
							//{
								this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
							//}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x003D5328 File Offset: 0x003D3728
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Setlement_Report.MdiParent = this.MdiParent;
				MyProject.Forms.Setlement_Report.WindowState = FormWindowState.Maximized;
				MyProject.Forms.Setlement_Report.Show();
				this.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x003D53A0 File Offset: 0x003D37A0
		public void Opning_Balance()
		{
			try
			{
				this.DataGridView1.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT Party_name, SUM(Amount) AS Expr1,dt FROM(OP_BAL) GROUP BY Party_name,dt HAVING (Party_name = '" + this.txtname.Text + "')";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				DateTime? expression = null;
				while (oleDbDataReader.Read())
				{
					this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
					expression = Conversions.ToDate(oleDbDataReader["dt"]);
					double num = Conversions.ToDouble(oleDbDataReader["Expr1"]);
				}
				string cmdText2 = "SELECT tns_Party, SUM(tns_Amount) AS amount, tns_dt, tns_chk, tns_Type, tns_Monday_Final FROM(Trans) GROUP BY tns_Party, tns_dt, tns_chk, tns_Type, tns_Monday_Final HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Monday_Final = 'Yes')";
				OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
				OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
				while (oleDbDataReader2.Read())
				{
					this.txtClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["amount"]));
				}
				string cmdText3 = "SELECT tns_Party, tns_dt, tns_Monday, tns_Monday_Final, tns_chk, tns_Type FROM(Trans) GROUP BY tns_Party, tns_dt, tns_Monday, tns_Monday_Final, tns_chk, tns_Type HAVING        (tns_Party = '" + this.txtname.Text + "') AND (tns_Monday = '1') AND (tns_Monday_Final = 'Yes') AND (tns_chk = '0') AND (tns_Type = 'Monday Settlement') ORDER BY tns_dt DESC";
				OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
				OleDbDataReader oleDbDataReader3 = oleDbCommand3.ExecuteReader();
				if (oleDbDataReader3.Read())
				{
					expression = Conversions.ToDate(Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader3["tns_dt"]), DateFormat.ShortDate));
				}

				int index = this.DataGridView1.Rows.Add();
				this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(expression.Value, DateFormat.ShortDate);
				this.DataGridView1.Rows[index].Cells[1].Value = "OP BAL ";
				this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.txtClosingBalance), this.txtnu.Text);
				oleDbCommand.Dispose();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x003D5614 File Offset: 0x003D3A14
		private void txttraName_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					this.txtamount.Focus();
				}
				if (e.KeyCode == Keys.Tab)
				{
					this.txtamount.Focus();
				}
				if (e.KeyCode == Keys.Escape)
				{
					if (this.Panel5.Visible)
					{
						this.Panel5.Hide();
						return;
					}
					MyProject.Forms.Setlement_Report.MdiParent = this.MdiParent;
					MyProject.Forms.Setlement_Report.WindowState = FormWindowState.Maximized;
					MyProject.Forms.Setlement_Report.Show();
					this.Close();
				}
				if (e.KeyCode == Keys.Back)
				{
					this.txttraName.Text = null;
					this.txttraName.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x003D56FC File Offset: 0x003D3AFC
		private void txtamount_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					SendKeys.Send("{Tab}");
				}
				if (e.KeyCode == Keys.Tab)
				{
					SendKeys.Send("{Tab}");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x003D5754 File Offset: 0x003D3B54
		private void txtremark_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					if (this.Button4.Visible)
					{
						this.Button4.Focus();
					}
					else
					{
						this.Button6.Focus();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x003D57B4 File Offset: 0x003D3BB4
		private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.DataGridView4.Hide();
			}
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x003D57CC File Offset: 0x003D3BCC
		private void DataGridView4_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					if (this.Panel5.Visible)
					{
						this.Panel5.Hide();
					}
					else
					{
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x003D5834 File Offset: 0x003D3C34
		private void TransactionReport_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					if (this.Panel5.Visible)
					{
						this.Panel5.Visible = false;
					}
					else
					{
						MyProject.Forms.Setlement_Report.MdiParent = this.MdiParent;
						MyProject.Forms.Setlement_Report.WindowState = FormWindowState.Maximized;
						MyProject.Forms.Setlement_Report.Show();
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x003D58D0 File Offset: 0x003D3CD0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable("DataTable3");
				DataSet dataSet = new DataSet();
				dataTable.Columns.Add("Date");
				dataTable.Columns.Add("Remarks");
				dataTable.Columns.Add("Amount");
				dataTable.Columns.Add("Cournt_amount");
				dataTable.Columns.Add("OPNING");
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
						{
							double num = 0;
							num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
							double num2 = Conversions.ToDouble(Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text));
							dataTable.Rows.Add(new object[]
							{
								RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value),
								RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
								RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value),
								Module1.SetNumFormat(Conversion.Val(num2), this.txtnu.Text),
								this.Label9.Text
							});
						}
					}
				}
				finally
				{
					//IEnumerator enumerator;
					//if (enumerator is IDisposable)
					//{
					//	(enumerator as IDisposable).Dispose();
					//}
					Module1.conn.Open();
				}
				dataSet.Tables.Add(dataTable);
				DataTable dataTable2 = new DataTable("DataTable4");
				dataTable2.Columns.Add("Column1");
				dataTable2.Columns.Add("Column2");
				dataTable2.Columns.Add("Column3");
				try
				{
					foreach (object obj2 in ((IEnumerable)this.DataGridView3.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells[0].Value, null, false))
						{
							if (!(dataGridViewRow2.DefaultCellStyle.BackColor == Color.Red))
							{
								dataTable2.Rows.Add(new object[]
								{
									Strings.FormatDateTime(Conversions.ToDate(dataGridViewRow2.Cells[0].Value), DateFormat.ShortDate),
									RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[1].Value),
									RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[2].Value)
								});
							}
						}
					}
				}
				finally
				{
					//IEnumerator enumerator2;
					//if (enumerator2 is IDisposable)
					//{
					//	(enumerator2 as IDisposable).Dispose();
					//}
					Module1.conn.Close();
				}
				dataSet.Tables.Add(dataTable2);
				DataTable dataTable3 = new DataTable("DataTable5");
				dataTable3.Columns.Add("Column1");
				dataTable3.Columns.Add("Column2");
				dataTable3.Columns.Add("Column3");
				try
				{
					foreach (object obj3 in ((IEnumerable)this.DataGridView2.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
						if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells[0].Value, null, false))
						{
							if (!(dataGridViewRow3.DefaultCellStyle.BackColor == Color.Red))
							{
								dataTable3.Rows.Add(new object[]
								{
									Strings.FormatDateTime(Conversions.ToDate(dataGridViewRow3.Cells[0].Value), DateFormat.ShortDate),
									RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells[1].Value),
									RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells[2].Value)
								});
							}
						}
					}
				}
				finally
				{
					//IEnumerator enumerator3;
					//if (enumerator3 is IDisposable)
					//{
					//	(enumerator3 as IDisposable).Dispose();
					//}
					Module1.conn.Close();
				}
				dataSet.Tables.Add(dataTable3);
				ReportDocument reportDocument = new T_report();
				reportDocument.SetDataSource(dataSet);
				reportDocument.PrintToPrinter(0, false, 0, 0);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x003D5DB8 File Offset: 0x003D41B8
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txttraName.Text, "", false) == 0)
				{
					Interaction.MsgBox("Insert the Party Name ?", MsgBoxStyle.OkOnly, null);
					this.txttraName.Focus();
				}
				else if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Insert Amount ?", MsgBoxStyle.OkOnly, null);
					this.txtamount.Focus();
				}
				else if (Operators.CompareString(this.txtamount.Text, "0.00", false) == 0)
				{
					Interaction.MsgBox("Please Insert Amount ?", MsgBoxStyle.OkOnly, null);
					this.txtamount.Focus();
				}
				else if (Operators.CompareString(this.txttraName.Text, this.txtname.Text, false) == 0)
				{
					MessageBox.Show("Error");
					this.txttraName.Text = null;
					this.txttraName.Focus();
				}
				else
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "Delete from Trans where tns_ModifyID=" + this.TextBox5.Text + " ";
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
					string text2 = "";
					if (Operators.CompareString(this.txtremark.Text, null, false) != 0)
					{
						string text = this.txtremark.Text;
						int num = text.IndexOf("(");
						if (num > -1)
						{
							text2 = this.txtremark.Text;
						}
						else
						{
							text2 = " (" + this.txtremark.Text + ")";
						}
					}
					string cmdText2 = "select Party_name from Newparty where Party_name='" + this.txttraName.Text + "'";
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						if (Conversions.ToDouble(this.txtamount.Text) > 0.0)
						{
							this.DataGridView5.Rows[0].Cells[0].Value = this.txttraName.Text;
							this.DataGridView5.Rows[0].Cells[1].Value = Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text);
							this.DataGridView5.Rows[0].Cells[2].Value = this.txtname.Text + text2.ToString();
							this.DataGridView5.Rows[0].Cells[3].Value = "0";
							this.DataGridView5.Rows[1].Cells[0].Value = this.txtname.Text;
							this.DataGridView5.Rows[1].Cells[1].Value = this.txtamount.Text;
							this.DataGridView5.Rows[1].Cells[2].Value = this.txttraName.Text + text2.ToString();
							this.DataGridView5.Rows[1].Cells[3].Value = "1";
						}
						else
						{
							this.DataGridView5.Rows[0].Cells[0].Value = this.txttraName.Text;
							this.DataGridView5.Rows[0].Cells[1].Value = Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text) - Conversions.ToDouble(this.txtamount.Text);
							this.DataGridView5.Rows[0].Cells[2].Value = this.txtname.Text + text2.ToString();
							this.DataGridView5.Rows[0].Cells[3].Value = "0";
							this.DataGridView5.Rows[1].Cells[0].Value = this.txtname.Text;
							this.DataGridView5.Rows[1].Cells[1].Value = this.txtamount.Text;
							this.DataGridView5.Rows[1].Cells[2].Value = this.txttraName.Text + text2.ToString();
							this.DataGridView5.Rows[1].Cells[3].Value = "1";
						}
						string cmdText3 = "select max(tns_ModifyID)from Trans";
						OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
						checked
						{
							int num2;
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand3.ExecuteScalar())))
							{
								num2 = Conversions.ToInteger("1");
							}
							else
							{
								num2 = Conversions.ToInteger(oleDbCommand3.ExecuteScalar());
								num2++;
							}
							this.TextBox4.Text = Conversions.ToString(num2);
							try
							{
								foreach (object obj in ((IEnumerable)this.DataGridView5.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
									{
										if (Module1.conn.State == ConnectionState.Closed)
										{
											Module1.conn.Open();
										}
										string cmdText4 = "insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala) values(@tns_Party,@tns_Amount,@tns_Remark,@tns_matchid,@tns_dt,@tns_type,@tns_vid,@tns_monday,@tns_sessionid,@tns_ModifyID,@tns_Monday_Final,@tns_Hawala)";
										OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText4, Module1.conn);
										oleDbCommand4.Parameters.AddWithValue("@tns_Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
										oleDbCommand4.Parameters.AddWithValue("@tns_Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
										oleDbCommand4.Parameters.AddWithValue("@tns_Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
										oleDbCommand4.Parameters.AddWithValue("@tns_matchid", "0");
										oleDbCommand4.Parameters.AddWithValue("@tns_dt", this.txtdate.Text);
										oleDbCommand4.Parameters.AddWithValue("@tns_type", "Extra");
										oleDbCommand4.Parameters.AddWithValue("@tns_vid", "0");
										oleDbCommand4.Parameters.AddWithValue("@tns_monday", "0");
										oleDbCommand4.Parameters.AddWithValue("@tns_sessionid", "0");
										oleDbCommand4.Parameters.AddWithValue("@tns_ModifyID", this.TextBox4.Text);
										oleDbCommand4.Parameters.AddWithValue("@tns_Monday_Final", "No");
										oleDbCommand4.Parameters.AddWithValue("@tns_Hawala", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value));
										oleDbCommand4.ExecuteNonQuery();
									}
								}
							}
							finally
							{								
							}
							this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
							this.Opning_Balance();
							this.Match();
							this.ABDN();
							this.Tie();
							this.CUP();
							this.Session();
							//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
							//{
							//	double num3 = Conversions.ToDouble(this.Label9.Text);
							//	if (num3 >= 0.49)
							//	{
							//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
							//	}
							//	if (num3 <= -0.49)
							//	{
							//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
							//	}
							//}
							//else
							//{
								this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
							//}
							this.Button4.Hide();
							this.Button5.Hide();
							this.Button6.Show();
							this.txttraName.Text = "";
							this.txtamount.Text = "";
							this.txtremark.Text = "";
							this.Label7.Text = "";
							this.txttraName.Focus();
						}
					}
					else
					{
						Interaction.MsgBox("Please Create A/C Than Proced...?", MsgBoxStyle.OkOnly, null);
						this.txttraName.Text = null;
						this.txttraName.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
			}
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x003D675C File Offset: 0x003D4B5C
		private void Button5_Click(object sender, EventArgs e)
		{
			this.Button4.Hide();
			this.Button5.Hide();
			this.Button6.Show();
			this.txttraName.Text = "";
			this.txtamount.Text = "";
			this.txtremark.Text = "";
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x003D67C0 File Offset: 0x003D4BC0
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboBox3.SelectedIndex = this.ComboBox1.SelectedIndex;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x003D67D8 File Offset: 0x003D4BD8
		private void Button14_Click(object sender, EventArgs e)
		{
			try
			{
				this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
				this.Opning_Balance();
				this.Match();
				this.ABDN();
				this.Tie();
				this.CUP();
				this.Session();
				//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
				//{
				//	double num = Conversions.ToDouble(this.Label9.Text);
				//	if (num >= 0.49)
				//	{
				//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
				//	}
				//	if (num <= -0.49)
				//	{
				//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
				//	}
				//}
				//else
				//{
					this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
				//}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x003D6938 File Offset: 0x003D4D38
		private void DataGridView3_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					if (this.Panel5.Visible)
					{
						this.Panel5.Hide();
					}
					else
					{
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x003D69A0 File Offset: 0x003D4DA0
		private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					if (this.Panel5.Visible)
					{
						this.Panel5.Hide();
					}
					else
					{
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x003D6A08 File Offset: 0x003D4E08
		private void DataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (!Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, null, false))
				{
					if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "Match", false))
					{
						Module1.machid = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[3].Value.ToString());
						Module1.name1 = this.txtname.Text;
						MyProject.Forms.DPP_Match.MdiParent = this.MdiParent;
						MyProject.Forms.DPP_Match.Show();
					}
					else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "ABDN", false))
					{
						Module1.machid = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[3].Value.ToString());
						Module1.sonu = this.txtname.Text;
						MyProject.Forms.DPP_AbnTie.MdiParent = this.MdiParent;
						MyProject.Forms.DPP_AbnTie.Show();
					}
					else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "CUP", false))
					{
						Module1.IDCUP = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[3].Value.ToString());
						Module1.name1 = this.txtname.Text;
						MyProject.Forms.DPP_CUP.MdiParent = this.MdiParent;
						MyProject.Forms.DPP_CUP.Show();
					}
					else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "Session", false))
					{
						Module1.sessionid = this.DataGridView4.CurrentRow.Cells[3].Value.ToString();
						Module1.nehaid = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[5].Value.ToString());
						Module1.dppname = this.txtname.Text;
						Module1.myexit = "1";
						MyProject.Forms.formDPPSession.MdiParent = this.MdiParent;
						MyProject.Forms.formDPPSession.Show();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x003D6D40 File Offset: 0x003D5140
		public void AutoComplete1(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
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

		// Token: 0x06002580 RID: 9600 RVA: 0x003D6E9C File Offset: 0x003D529C
		private void txtname_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				ComboBox txtname = this.txtname;
				this.AutoComplete1(ref txtname, e, false);
				this.txtname = txtname;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x003D6EF0 File Offset: 0x003D52F0
		private void txtname_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					if (Operators.CompareString(this.txtname.Text, null, false) == 0)
					{
						this.Focus();
					}
					else
					{
						this.Panel5.Visible = false;
						this.Button12_Click(RuntimeHelpers.GetObjectValue(sender), e);
						this.Opning_Balance();
						this.Match();
						this.ABDN();
						this.Tie();
						this.CUP();
						this.Session();
						//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
						//{
						//	double num = Conversions.ToDouble(this.Label9.Text);
						//	if (num >= 0.49)
						//	{
						//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
						//	}
						//	if (num <= -0.49)
						//	{
						//		this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), "0");
						//	}
						//}
						//else
						//{
							this.Label9.Text = Module1.SetNumFormat(Conversion.Val(this.Label9.Text), this.txtnu.Text);
						//}
					}
				}
				if (e.KeyCode == Keys.Back)
				{
					this.txtname.Text = null;
					this.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x003D70A4 File Offset: 0x003D54A4
		private void txttraName_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x003D70E0 File Offset: 0x003D54E0
		private void txttraName_Enter(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(sender, null, "SelectAll", new object[0], null, null, null, true);
		}


		// Token: 0x04000E7E RID: 3710
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000E7F RID: 3711
		[AccessedThroughProperty("Monday_Final")]
		private Button _Monday_Final;

		// Token: 0x04000E80 RID: 3712
		[AccessedThroughProperty("BTNDELETE")]
		private Button _BTNDELETE;

		// Token: 0x04000E81 RID: 3713
		[AccessedThroughProperty("txtmodify")]
		private Button _txtmodify;

		// Token: 0x04000E82 RID: 3714
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000E83 RID: 3715
		[AccessedThroughProperty("btnoldrecord")]
		private Button _btnoldrecord;

		// Token: 0x04000E84 RID: 3716
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000E85 RID: 3717
		[AccessedThroughProperty("DataGridView3")]
		private DataGridView _DataGridView3;

		// Token: 0x04000E86 RID: 3718
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x04000E87 RID: 3719
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		// Token: 0x04000E88 RID: 3720
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000E89 RID: 3721
		[AccessedThroughProperty("txtremark")]
		private TextBox _txtremark;

		// Token: 0x04000E8A RID: 3722
		[AccessedThroughProperty("txtamount")]
		private TextBox _txtamount;

		// Token: 0x04000E8B RID: 3723
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000E8C RID: 3724
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000E8D RID: 3725
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		// Token: 0x04000E8E RID: 3726
		[AccessedThroughProperty("txttraName")]
		private ComboBox _txttraName;

		// Token: 0x04000E8F RID: 3727
		[AccessedThroughProperty("txtdate")]
		private DateTimePicker _txtdate;

		// Token: 0x04000E90 RID: 3728
		[AccessedThroughProperty("ComboBox4")]
		private ComboBox _ComboBox4;

		// Token: 0x04000E91 RID: 3729
		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		// Token: 0x04000E92 RID: 3730
		[AccessedThroughProperty("DataGridView4")]
		private DataGridView _DataGridView4;

		// Token: 0x04000E93 RID: 3731
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000E94 RID: 3732
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		// Token: 0x04000E95 RID: 3733
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x04000E96 RID: 3734
		[AccessedThroughProperty("txtnu")]
		private TextBox _txtnu;

		// Token: 0x04000E97 RID: 3735
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x04000E98 RID: 3736
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000E99 RID: 3737
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		// Token: 0x04000E9A RID: 3738
		[AccessedThroughProperty("DataGridView5")]
		private DataGridView _DataGridView5;

		// Token: 0x04000E9B RID: 3739
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		// Token: 0x04000E9C RID: 3740
		[AccessedThroughProperty("DataGridView6")]
		private DataGridView _DataGridView6;

		// Token: 0x04000E9D RID: 3741
		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		// Token: 0x04000E9E RID: 3742
		[AccessedThroughProperty("TextBox5")]
		private TextBox _TextBox5;

		// Token: 0x04000E9F RID: 3743
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000EA0 RID: 3744
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000EA1 RID: 3745
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x04000EA2 RID: 3746
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000EA3 RID: 3747
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000EA4 RID: 3748
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000EA5 RID: 3749
		[AccessedThroughProperty("Column11")]
		private DataGridViewTextBoxColumn _Column11;

		// Token: 0x04000EA6 RID: 3750
		[AccessedThroughProperty("Column12")]
		private DataGridViewTextBoxColumn _Column12;

		// Token: 0x04000EA7 RID: 3751
		[AccessedThroughProperty("Column13")]
		private DataGridViewTextBoxColumn _Column13;

		// Token: 0x04000EA8 RID: 3752
		[AccessedThroughProperty("Column16")]
		private DataGridViewTextBoxColumn _Column16;

		// Token: 0x04000EA9 RID: 3753
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

		// Token: 0x04000EAA RID: 3754
		[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

		// Token: 0x04000EAB RID: 3755
		[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

		// Token: 0x04000EAC RID: 3756
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x04000EAD RID: 3757
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000EAE RID: 3758
		[AccessedThroughProperty("DataGridView7")]
		private DataGridView _DataGridView7;

		// Token: 0x04000EAF RID: 3759
		[AccessedThroughProperty("D")]
		private DataGridViewTextBoxColumn _D;

		// Token: 0x04000EB0 RID: 3760
		[AccessedThroughProperty("R")]
		private DataGridViewTextBoxColumn _R;

		// Token: 0x04000EB1 RID: 3761
		[AccessedThroughProperty("A")]
		private DataGridViewTextBoxColumn _A;

		// Token: 0x04000EB2 RID: 3762
		[AccessedThroughProperty("C")]
		private DataGridViewTextBoxColumn _C;

		// Token: 0x04000EB3 RID: 3763
		[AccessedThroughProperty("T")]
		private DataGridViewTextBoxColumn _T;

		// Token: 0x04000EB4 RID: 3764
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x04000EB5 RID: 3765
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x04000EB6 RID: 3766
		[AccessedThroughProperty("ComboBox3")]
		private ComboBox _ComboBox3;

		// Token: 0x04000EB7 RID: 3767
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000EB8 RID: 3768
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		// Token: 0x04000EB9 RID: 3769
		[AccessedThroughProperty("DataGridView8")]
		private DataGridView _DataGridView8;

		// Token: 0x04000EBA RID: 3770
		[AccessedThroughProperty("Column17")]
		private DataGridViewTextBoxColumn _Column17;

		// Token: 0x04000EBB RID: 3771
		[AccessedThroughProperty("DataGridView9")]
		private DataGridView _DataGridView9;

		// Token: 0x04000EBC RID: 3772
		[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

		// Token: 0x04000EBD RID: 3773
		[AccessedThroughProperty("Column18")]
		private DataGridViewTextBoxColumn _Column18;

		// Token: 0x04000EBE RID: 3774
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000EBF RID: 3775
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000EC0 RID: 3776
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		// Token: 0x04000EC1 RID: 3777
		[AccessedThroughProperty("Panel5")]
		private Panel _Panel5;

		// Token: 0x04000EC2 RID: 3778
		[AccessedThroughProperty("Panel6")]
		private Panel _Panel6;

		// Token: 0x04000EC3 RID: 3779
		[AccessedThroughProperty("Panel7")]
		private Panel _Panel7;

		// Token: 0x04000EC4 RID: 3780
		[AccessedThroughProperty("Panel4")]
		private Panel _Panel4;

		// Token: 0x04000EC5 RID: 3781
		[AccessedThroughProperty("txtname")]
		private ComboBox _txtname;

		// Token: 0x04000EC6 RID: 3782
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

		// Token: 0x04000EC7 RID: 3783
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

		// Token: 0x04000EC8 RID: 3784
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

		// Token: 0x04000EC9 RID: 3785
		[AccessedThroughProperty("Column14")]
		private DataGridViewTextBoxColumn _Column14;

		// Token: 0x04000ECA RID: 3786
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x04000ECB RID: 3787
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x04000ECC RID: 3788
		[AccessedThroughProperty("Column6")]
		private DataGridViewTextBoxColumn _Column6;

		// Token: 0x04000ECD RID: 3789
		[AccessedThroughProperty("Column15")]
		private DataGridViewTextBoxColumn _Column15;

		// Token: 0x04000ECE RID: 3790
		[AccessedThroughProperty("Column1")]
		private DataGridViewTextBoxColumn _Column1;

		// Token: 0x04000ECF RID: 3791
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x04000ED0 RID: 3792
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x04000ED1 RID: 3793
		[AccessedThroughProperty("Column10")]
		private DataGridViewTextBoxColumn _Column10;

		// Token: 0x04000ED2 RID: 3794
		[AccessedThroughProperty("Column19")]
		private DataGridViewTextBoxColumn _Column19;

		// Token: 0x04000ED3 RID: 3795
		[AccessedThroughProperty("Column23")]
		private DataGridViewTextBoxColumn _Column23;

		// Token: 0x04000ED4 RID: 3796
		[AccessedThroughProperty("Column24")]
		private DataGridViewTextBoxColumn _Column24;

		// Token: 0x04000ED5 RID: 3797
		[AccessedThroughProperty("Column7")]
		private DataGridViewTextBoxColumn _Column7;

		// Token: 0x04000ED6 RID: 3798
		[AccessedThroughProperty("Column8")]
		private DataGridViewTextBoxColumn _Column8;

		// Token: 0x04000ED7 RID: 3799
		[AccessedThroughProperty("Column9")]
		private DataGridViewTextBoxColumn _Column9;

		// Token: 0x04000ED8 RID: 3800
		[AccessedThroughProperty("Column20")]
		private DataGridViewTextBoxColumn _Column20;

		// Token: 0x04000ED9 RID: 3801
		[AccessedThroughProperty("Column21")]
		private DataGridViewTextBoxColumn _Column21;

		// Token: 0x04000EDA RID: 3802
		[AccessedThroughProperty("Column22")]
		private DataGridViewTextBoxColumn _Column22;

		// Token: 0x04000EDB RID: 3803
		private int amountsub;

		// Token: 0x04000EDC RID: 3804
		private double txtClosingBalance;

		// Token: 0x04000EDD RID: 3805
		//private TextBox txtid1;
	}
}



//// Token: 0x17000DF0 RID: 3568
//// (get) Token: 0x06002494 RID: 9364 RVA: 0x003CFE64 File Offset: 0x003CE264
//// (set) Token: 0x06002495 RID: 9365 RVA: 0x003CFE78 File Offset: 0x003CE278
//internal virtual Label Label1
//{
//	get
//	{
//		return this._Label1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label1 = value;
//	}
//}

//// Token: 0x17000DF1 RID: 3569
//// (get) Token: 0x06002496 RID: 9366 RVA: 0x003CFE84 File Offset: 0x003CE284
//// (set) Token: 0x06002497 RID: 9367 RVA: 0x003CFE98 File Offset: 0x003CE298
//internal virtual Button Monday_Final
//{
//	get
//	{
//		return this._Monday_Final;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Monday_Final_Click);
//		if (this._Monday_Final != null)
//		{
//			this._Monday_Final.Click -= value2;
//		}
//		this._Monday_Final = value;
//		if (this._Monday_Final != null)
//		{
//			this._Monday_Final.Click += value2;
//		}
//	}
//}

//// Token: 0x17000DF2 RID: 3570
//// (get) Token: 0x06002498 RID: 9368 RVA: 0x003CFEE4 File Offset: 0x003CE2E4
//// (set) Token: 0x06002499 RID: 9369 RVA: 0x003CFEF8 File Offset: 0x003CE2F8
//internal virtual Button BTNDELETE
//{
//	get
//	{
//		return this._BTNDELETE;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.BTNDELETE_Click);
//		if (this._BTNDELETE != null)
//		{
//			this._BTNDELETE.Click -= value2;
//		}
//		this._BTNDELETE = value;
//		if (this._BTNDELETE != null)
//		{
//			this._BTNDELETE.Click += value2;
//		}
//	}
//}

//// Token: 0x17000DF3 RID: 3571
//// (get) Token: 0x0600249A RID: 9370 RVA: 0x003CFF44 File Offset: 0x003CE344
//// (set) Token: 0x0600249B RID: 9371 RVA: 0x003CFF58 File Offset: 0x003CE358
//internal virtual Button txtmodify
//{
//	get
//	{
//		return this._txtmodify;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.txtmodify_Click);
//		if (this._txtmodify != null)
//		{
//			this._txtmodify.Click -= value2;
//		}
//		this._txtmodify = value;
//		if (this._txtmodify != null)
//		{
//			this._txtmodify.Click += value2;
//		}
//	}
//}

//// Token: 0x17000DF4 RID: 3572
//// (get) Token: 0x0600249C RID: 9372 RVA: 0x003CFFA4 File Offset: 0x003CE3A4
//// (set) Token: 0x0600249D RID: 9373 RVA: 0x003CFFB8 File Offset: 0x003CE3B8
//internal virtual Button Button2
//{
//	get
//	{
//		return this._Button2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button2_Click);
//		if (this._Button2 != null)
//		{
//			this._Button2.Click -= value2;
//		}
//		this._Button2 = value;
//		if (this._Button2 != null)
//		{
//			this._Button2.Click += value2;
//		}
//	}
//}

//// Token: 0x17000DF5 RID: 3573
//// (get) Token: 0x0600249E RID: 9374 RVA: 0x003D0004 File Offset: 0x003CE404
//// (set) Token: 0x0600249F RID: 9375 RVA: 0x003D0018 File Offset: 0x003CE418
//internal virtual Button btnoldrecord
//{
//	get
//	{
//		return this._btnoldrecord;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.btnoldrecord_Click);
//		if (this._btnoldrecord != null)
//		{
//			this._btnoldrecord.Click -= value2;
//		}
//		this._btnoldrecord = value;
//		if (this._btnoldrecord != null)
//		{
//			this._btnoldrecord.Click += value2;
//		}
//	}
//}

//// Token: 0x17000DF6 RID: 3574
//// (get) Token: 0x060024A0 RID: 9376 RVA: 0x003D0064 File Offset: 0x003CE464
//// (set) Token: 0x060024A1 RID: 9377 RVA: 0x003D0078 File Offset: 0x003CE478
//internal virtual Label Label4
//{
//	get
//	{
//		return this._Label4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label4 = value;
//	}
//}

//// Token: 0x17000DF7 RID: 3575
//// (get) Token: 0x060024A2 RID: 9378 RVA: 0x003D0084 File Offset: 0x003CE484
//// (set) Token: 0x060024A3 RID: 9379 RVA: 0x003D0098 File Offset: 0x003CE498
//internal virtual DataGridView DataGridView3
//{
//	get
//	{
//		return this._DataGridView3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		MouseEventHandler value2 = new MouseEventHandler(this.DataGridView3_MouseClick);
//		KeyEventHandler value3 = new KeyEventHandler(this.DataGridView3_KeyDown);
//		if (this._DataGridView3 != null)
//		{
//			this._DataGridView3.MouseClick -= value2;
//			this._DataGridView3.KeyDown -= value3;
//		}
//		this._DataGridView3 = value;
//		if (this._DataGridView3 != null)
//		{
//			this._DataGridView3.MouseClick += value2;
//			this._DataGridView3.KeyDown += value3;
//		}
//	}
//}

//// Token: 0x17000DF8 RID: 3576
//// (get) Token: 0x060024A4 RID: 9380 RVA: 0x003D0108 File Offset: 0x003CE508
//// (set) Token: 0x060024A5 RID: 9381 RVA: 0x003D011C File Offset: 0x003CE51C
//internal virtual DataGridView DataGridView2
//{
//	get
//	{
//		return this._DataGridView2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		KeyEventHandler value2 = new KeyEventHandler(this.DataGridView2_KeyDown);
//		MouseEventHandler value3 = new MouseEventHandler(this.DataGridView2_MouseClick);
//		if (this._DataGridView2 != null)
//		{
//			this._DataGridView2.KeyDown -= value2;
//			this._DataGridView2.MouseClick -= value3;
//		}
//		this._DataGridView2 = value;
//		if (this._DataGridView2 != null)
//		{
//			this._DataGridView2.KeyDown += value2;
//			this._DataGridView2.MouseClick += value3;
//		}
//	}
//}

//// Token: 0x17000DF9 RID: 3577
//// (get) Token: 0x060024A6 RID: 9382 RVA: 0x003D018C File Offset: 0x003CE58C
//// (set) Token: 0x060024A7 RID: 9383 RVA: 0x003D01A0 File Offset: 0x003CE5A0
//internal virtual Button Button6
//{
//	get
//	{
//		return this._Button6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button6_Click);
//		if (this._Button6 != null)
//		{
//			this._Button6.Click -= value2;
//		}
//		this._Button6 = value;
//		if (this._Button6 != null)
//		{
//			this._Button6.Click += value2;
//		}
//	}
//}

//// Token: 0x17000DFA RID: 3578
//// (get) Token: 0x060024A8 RID: 9384 RVA: 0x003D01EC File Offset: 0x003CE5EC
//// (set) Token: 0x060024A9 RID: 9385 RVA: 0x003D0200 File Offset: 0x003CE600
//internal virtual Label Label7
//{
//	get
//	{
//		return this._Label7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label7 = value;
//	}
//}

//// Token: 0x17000DFB RID: 3579
//// (get) Token: 0x060024AA RID: 9386 RVA: 0x003D020C File Offset: 0x003CE60C
//// (set) Token: 0x060024AB RID: 9387 RVA: 0x003D0220 File Offset: 0x003CE620
//internal virtual TextBox txtremark
//{
//	get
//	{
//		return this._txtremark;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.txttraName_Enter);
//		KeyEventHandler value3 = new KeyEventHandler(this.txtremark_KeyDown);
//		if (this._txtremark != null)
//		{
//			this._txtremark.Enter -= value2;
//			this._txtremark.KeyDown -= value3;
//		}
//		this._txtremark = value;
//		if (this._txtremark != null)
//		{
//			this._txtremark.Enter += value2;
//			this._txtremark.KeyDown += value3;
//		}
//	}
//}

//// Token: 0x17000DFC RID: 3580
//// (get) Token: 0x060024AC RID: 9388 RVA: 0x003D0290 File Offset: 0x003CE690
//// (set) Token: 0x060024AD RID: 9389 RVA: 0x003D02A4 File Offset: 0x003CE6A4
//internal virtual TextBox txtamount
//{
//	get
//	{
//		return this._txtamount;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.txttraName_Enter);
//		EventHandler value3 = new EventHandler(this.txtamount_Leave);
//		KeyEventHandler value4 = new KeyEventHandler(this.txtamount_KeyDown);
//		if (this._txtamount != null)
//		{
//			this._txtamount.Enter -= value2;
//			this._txtamount.Leave -= value3;
//			this._txtamount.KeyDown -= value4;
//		}
//		this._txtamount = value;
//		if (this._txtamount != null)
//		{
//			this._txtamount.Enter += value2;
//			this._txtamount.Leave += value3;
//			this._txtamount.KeyDown += value4;
//		}
//	}
//}

//// Token: 0x17000DFD RID: 3581
//// (get) Token: 0x060024AE RID: 9390 RVA: 0x003D033C File Offset: 0x003CE73C
//// (set) Token: 0x060024AF RID: 9391 RVA: 0x003D0350 File Offset: 0x003CE750
//internal virtual Label Label6
//{
//	get
//	{
//		return this._Label6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label6 = value;
//	}
//}

//// Token: 0x17000DFE RID: 3582
//// (get) Token: 0x060024B0 RID: 9392 RVA: 0x003D035C File Offset: 0x003CE75C
//// (set) Token: 0x060024B1 RID: 9393 RVA: 0x003D0370 File Offset: 0x003CE770
//internal virtual Label Label5
//{
//	get
//	{
//		return this._Label5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label5 = value;
//	}
//}

//// Token: 0x17000DFF RID: 3583
//// (get) Token: 0x060024B2 RID: 9394 RVA: 0x003D037C File Offset: 0x003CE77C
//// (set) Token: 0x060024B3 RID: 9395 RVA: 0x003D0390 File Offset: 0x003CE790
//internal virtual Button Button7
//{
//	get
//	{
//		return this._Button7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button7_Click);
//		if (this._Button7 != null)
//		{
//			this._Button7.Click -= value2;
//		}
//		this._Button7 = value;
//		if (this._Button7 != null)
//		{
//			this._Button7.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E00 RID: 3584
//// (get) Token: 0x060024B4 RID: 9396 RVA: 0x003D03DC File Offset: 0x003CE7DC
//// (set) Token: 0x060024B5 RID: 9397 RVA: 0x003D03F0 File Offset: 0x003CE7F0
//internal virtual ComboBox txttraName
//{
//	get
//	{
//		return this._txttraName;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.txttraName_Enter);
//		KeyEventHandler value3 = new KeyEventHandler(this.txttraName_KeyUp);
//		EventHandler value4 = new EventHandler(this.txttraName_Leave);
//		KeyEventHandler value5 = new KeyEventHandler(this.txttraName_KeyDown);
//		KeyPressEventHandler value6 = new KeyPressEventHandler(this.txttraName_KeyPress);
//		if (this._txttraName != null)
//		{
//			this._txttraName.Enter -= value2;
//			this._txttraName.KeyUp -= value3;
//			this._txttraName.Leave -= value4;
//			this._txttraName.KeyDown -= value5;
//			this._txttraName.KeyPress -= value6;
//		}
//		this._txttraName = value;
//		if (this._txttraName != null)
//		{
//			this._txttraName.Enter += value2;
//			this._txttraName.KeyUp += value3;
//			this._txttraName.Leave += value4;
//			this._txttraName.KeyDown += value5;
//			this._txttraName.KeyPress += value6;
//		}
//	}
//}

//// Token: 0x17000E01 RID: 3585
//// (get) Token: 0x060024B6 RID: 9398 RVA: 0x003D04D8 File Offset: 0x003CE8D8
//// (set) Token: 0x060024B7 RID: 9399 RVA: 0x003D04EC File Offset: 0x003CE8EC
//internal virtual DateTimePicker txtdate
//{
//	get
//	{
//		return this._txtdate;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtdate = value;
//	}
//}

//// Token: 0x17000E02 RID: 3586
//// (get) Token: 0x060024B8 RID: 9400 RVA: 0x003D04F8 File Offset: 0x003CE8F8
//// (set) Token: 0x060024B9 RID: 9401 RVA: 0x003D050C File Offset: 0x003CE90C
//internal virtual ComboBox ComboBox4
//{
//	get
//	{
//		return this._ComboBox4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._ComboBox4 = value;
//	}
//}

//// Token: 0x17000E03 RID: 3587
//// (get) Token: 0x060024BA RID: 9402 RVA: 0x003D0518 File Offset: 0x003CE918
//// (set) Token: 0x060024BB RID: 9403 RVA: 0x003D052C File Offset: 0x003CE92C
//internal virtual Button Button8
//{
//	get
//	{
//		return this._Button8;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Button8 = value;
//	}
//}

//// Token: 0x17000E04 RID: 3588
//// (get) Token: 0x060024BC RID: 9404 RVA: 0x003D0538 File Offset: 0x003CE938
//// (set) Token: 0x060024BD RID: 9405 RVA: 0x003D054C File Offset: 0x003CE94C
//internal virtual DataGridView DataGridView4
//{
//	get
//	{
//		return this._DataGridView4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		MouseEventHandler value2 = new MouseEventHandler(this.DataGridView4_MouseDoubleClick);
//		KeyEventHandler value3 = new KeyEventHandler(this.DataGridView4_KeyDown);
//		if (this._DataGridView4 != null)
//		{
//			this._DataGridView4.MouseDoubleClick -= value2;
//			this._DataGridView4.KeyDown -= value3;
//		}
//		this._DataGridView4 = value;
//		if (this._DataGridView4 != null)
//		{
//			this._DataGridView4.MouseDoubleClick += value2;
//			this._DataGridView4.KeyDown += value3;
//		}
//	}
//}

//// Token: 0x17000E05 RID: 3589
//// (get) Token: 0x060024BE RID: 9406 RVA: 0x003D05BC File Offset: 0x003CE9BC
//// (set) Token: 0x060024BF RID: 9407 RVA: 0x003D05D0 File Offset: 0x003CE9D0
//internal virtual Button Button1
//{
//	get
//	{
//		return this._Button1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Button1 = value;
//	}
//}

//// Token: 0x17000E06 RID: 3590
//// (get) Token: 0x060024C0 RID: 9408 RVA: 0x003D05DC File Offset: 0x003CE9DC
//// (set) Token: 0x060024C1 RID: 9409 RVA: 0x003D05F0 File Offset: 0x003CE9F0
//internal virtual ComboBox ComboBox2
//{
//	get
//	{
//		return this._ComboBox2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._ComboBox2 = value;
//	}
//}

//// Token: 0x17000E07 RID: 3591
//// (get) Token: 0x060024C2 RID: 9410 RVA: 0x003D05FC File Offset: 0x003CE9FC
//// (set) Token: 0x060024C3 RID: 9411 RVA: 0x003D0610 File Offset: 0x003CEA10
//internal virtual Button Button9
//{
//	get
//	{
//		return this._Button9;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Button9 = value;
//	}
//}

//// Token: 0x17000E08 RID: 3592
//// (get) Token: 0x060024C4 RID: 9412 RVA: 0x003D061C File Offset: 0x003CEA1C
//// (set) Token: 0x060024C5 RID: 9413 RVA: 0x003D0630 File Offset: 0x003CEA30
//internal virtual TextBox txtnu
//{
//	get
//	{
//		return this._txtnu;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtnu = value;
//	}
//}

//// Token: 0x17000E09 RID: 3593
//// (get) Token: 0x060024C6 RID: 9414 RVA: 0x003D063C File Offset: 0x003CEA3C
//// (set) Token: 0x060024C7 RID: 9415 RVA: 0x003D0650 File Offset: 0x003CEA50
//internal virtual Button Button10
//{
//	get
//	{
//		return this._Button10;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button10_Click);
//		if (this._Button10 != null)
//		{
//			this._Button10.Click -= value2;
//		}
//		this._Button10 = value;
//		if (this._Button10 != null)
//		{
//			this._Button10.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E0A RID: 3594
//// (get) Token: 0x060024C8 RID: 9416 RVA: 0x003D069C File Offset: 0x003CEA9C
//// (set) Token: 0x060024C9 RID: 9417 RVA: 0x003D06B0 File Offset: 0x003CEAB0
//internal virtual TextBox TextBox1
//{
//	get
//	{
//		return this._TextBox1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._TextBox1 = value;
//	}
//}

//// Token: 0x17000E0B RID: 3595
//// (get) Token: 0x060024CA RID: 9418 RVA: 0x003D06BC File Offset: 0x003CEABC
//// (set) Token: 0x060024CB RID: 9419 RVA: 0x003D06D0 File Offset: 0x003CEAD0
//internal virtual Button Button11
//{
//	get
//	{
//		return this._Button11;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button11_Click);
//		if (this._Button11 != null)
//		{
//			this._Button11.Click -= value2;
//		}
//		this._Button11 = value;
//		if (this._Button11 != null)
//		{
//			this._Button11.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E0C RID: 3596
//// (get) Token: 0x060024CC RID: 9420 RVA: 0x003D071C File Offset: 0x003CEB1C
//// (set) Token: 0x060024CD RID: 9421 RVA: 0x003D0730 File Offset: 0x003CEB30
//internal virtual DataGridView DataGridView5
//{
//	get
//	{
//		return this._DataGridView5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridView5 = value;
//	}
//}

//// Token: 0x17000E0D RID: 3597
//// (get) Token: 0x060024CE RID: 9422 RVA: 0x003D073C File Offset: 0x003CEB3C
//// (set) Token: 0x060024CF RID: 9423 RVA: 0x003D0750 File Offset: 0x003CEB50
//internal virtual Button Button12
//{
//	get
//	{
//		return this._Button12;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button12_Click);
//		if (this._Button12 != null)
//		{
//			this._Button12.Click -= value2;
//		}
//		this._Button12 = value;
//		if (this._Button12 != null)
//		{
//			this._Button12.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E0E RID: 3598
//// (get) Token: 0x060024D0 RID: 9424 RVA: 0x003D079C File Offset: 0x003CEB9C
//// (set) Token: 0x060024D1 RID: 9425 RVA: 0x003D07B0 File Offset: 0x003CEBB0
//internal virtual DataGridView DataGridView6
//{
//	get
//	{
//		return this._DataGridView6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridView6 = value;
//	}
//}

//// Token: 0x17000E0F RID: 3599
//// (get) Token: 0x060024D2 RID: 9426 RVA: 0x003D07BC File Offset: 0x003CEBBC
//// (set) Token: 0x060024D3 RID: 9427 RVA: 0x003D07D0 File Offset: 0x003CEBD0
//internal virtual TextBox TextBox4
//{
//	get
//	{
//		return this._TextBox4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._TextBox4 = value;
//	}
//}

//// Token: 0x17000E10 RID: 3600
//// (get) Token: 0x060024D4 RID: 9428 RVA: 0x003D07DC File Offset: 0x003CEBDC
//// (set) Token: 0x060024D5 RID: 9429 RVA: 0x003D07F0 File Offset: 0x003CEBF0
//internal virtual TextBox TextBox5
//{
//	get
//	{
//		return this._TextBox5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._TextBox5 = value;
//	}
//}

//// Token: 0x17000E11 RID: 3601
//// (get) Token: 0x060024D6 RID: 9430 RVA: 0x003D07FC File Offset: 0x003CEBFC
//// (set) Token: 0x060024D7 RID: 9431 RVA: 0x003D0810 File Offset: 0x003CEC10
//internal virtual TextBox TextBox2
//{
//	get
//	{
//		return this._TextBox2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._TextBox2 = value;
//	}
//}

//// Token: 0x17000E12 RID: 3602
//// (get) Token: 0x060024D8 RID: 9432 RVA: 0x003D081C File Offset: 0x003CEC1C
//// (set) Token: 0x060024D9 RID: 9433 RVA: 0x003D0830 File Offset: 0x003CEC30
//internal virtual Button Button3
//{
//	get
//	{
//		return this._Button3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Button3 = value;
//	}
//}

//// Token: 0x17000E13 RID: 3603
//// (get) Token: 0x060024DA RID: 9434 RVA: 0x003D083C File Offset: 0x003CEC3C
//// (set) Token: 0x060024DB RID: 9435 RVA: 0x003D0850 File Offset: 0x003CEC50
//internal virtual TextBox TextBox3
//{
//	get
//	{
//		return this._TextBox3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._TextBox3 = value;
//	}
//}

//// Token: 0x17000E14 RID: 3604
//// (get) Token: 0x060024DC RID: 9436 RVA: 0x003D085C File Offset: 0x003CEC5C
//// (set) Token: 0x060024DD RID: 9437 RVA: 0x003D0870 File Offset: 0x003CEC70
//internal virtual CheckBox CheckBox1
//{
//	get
//	{
//		return this._CheckBox1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._CheckBox1 = value;
//	}
//}

//// Token: 0x17000E15 RID: 3605
//// (get) Token: 0x060024DE RID: 9438 RVA: 0x003D087C File Offset: 0x003CEC7C
//// (set) Token: 0x060024DF RID: 9439 RVA: 0x003D0890 File Offset: 0x003CEC90
//internal virtual Label Label9
//{
//	get
//	{
//		return this._Label9;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Label9_TextChanged);
//		if (this._Label9 != null)
//		{
//			this._Label9.TextChanged -= value2;
//		}
//		this._Label9 = value;
//		if (this._Label9 != null)
//		{
//			this._Label9.TextChanged += value2;
//		}
//	}
//}

//// Token: 0x17000E16 RID: 3606
//// (get) Token: 0x060024E0 RID: 9440 RVA: 0x003D08DC File Offset: 0x003CECDC
//// (set) Token: 0x060024E1 RID: 9441 RVA: 0x003D08F0 File Offset: 0x003CECF0
//internal virtual Label Label10
//{
//	get
//	{
//		return this._Label10;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label10 = value;
//	}
//}

//// Token: 0x17000E17 RID: 3607
//// (get) Token: 0x060024E2 RID: 9442 RVA: 0x003D08FC File Offset: 0x003CECFC
//// (set) Token: 0x060024E3 RID: 9443 RVA: 0x003D0910 File Offset: 0x003CED10
//internal virtual DataGridViewTextBoxColumn Column11
//{
//	get
//	{
//		return this._Column11;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column11 = value;
//	}
//}

//// Token: 0x17000E18 RID: 3608
//// (get) Token: 0x060024E4 RID: 9444 RVA: 0x003D091C File Offset: 0x003CED1C
//// (set) Token: 0x060024E5 RID: 9445 RVA: 0x003D0930 File Offset: 0x003CED30
//internal virtual DataGridViewTextBoxColumn Column12
//{
//	get
//	{
//		return this._Column12;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column12 = value;
//	}
//}

//// Token: 0x17000E19 RID: 3609
//// (get) Token: 0x060024E6 RID: 9446 RVA: 0x003D093C File Offset: 0x003CED3C
//// (set) Token: 0x060024E7 RID: 9447 RVA: 0x003D0950 File Offset: 0x003CED50
//internal virtual DataGridViewTextBoxColumn Column13
//{
//	get
//	{
//		return this._Column13;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column13 = value;
//	}
//}

//// Token: 0x17000E1A RID: 3610
//// (get) Token: 0x060024E8 RID: 9448 RVA: 0x003D095C File Offset: 0x003CED5C
//// (set) Token: 0x060024E9 RID: 9449 RVA: 0x003D0970 File Offset: 0x003CED70
//internal virtual DataGridViewTextBoxColumn Column16
//{
//	get
//	{
//		return this._Column16;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column16 = value;
//	}
//}

//// Token: 0x17000E1B RID: 3611
//// (get) Token: 0x060024EA RID: 9450 RVA: 0x003D097C File Offset: 0x003CED7C
//// (set) Token: 0x060024EB RID: 9451 RVA: 0x003D0990 File Offset: 0x003CED90
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn4 = value;
//	}
//}

//// Token: 0x17000E1C RID: 3612
//// (get) Token: 0x060024EC RID: 9452 RVA: 0x003D099C File Offset: 0x003CED9C
//// (set) Token: 0x060024ED RID: 9453 RVA: 0x003D09B0 File Offset: 0x003CEDB0
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn5 = value;
//	}
//}

//// Token: 0x17000E1D RID: 3613
//// (get) Token: 0x060024EE RID: 9454 RVA: 0x003D09BC File Offset: 0x003CEDBC
//// (set) Token: 0x060024EF RID: 9455 RVA: 0x003D09D0 File Offset: 0x003CEDD0
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn6 = value;
//	}
//}

//// Token: 0x17000E1E RID: 3614
//// (get) Token: 0x060024F0 RID: 9456 RVA: 0x003D09DC File Offset: 0x003CEDDC
//// (set) Token: 0x060024F1 RID: 9457 RVA: 0x003D09F0 File Offset: 0x003CEDF0
//internal virtual DataGridView DataGridView1
//{
//	get
//	{
//		return this._DataGridView1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		MouseEventHandler value2 = new MouseEventHandler(this.DataGridView1_MouseDoubleClick);
//		MouseEventHandler value3 = new MouseEventHandler(this.DataGridView1_MouseDoubleClick);
//		KeyEventHandler value4 = new KeyEventHandler(this.DataGridView1_KeyDown);
//		if (this._DataGridView1 != null)
//		{
//			this._DataGridView1.MouseClick -= value2;
//			this._DataGridView1.MouseDoubleClick -= value3;
//			this._DataGridView1.KeyDown -= value4;
//		}
//		this._DataGridView1 = value;
//		if (this._DataGridView1 != null)
//		{
//			this._DataGridView1.MouseClick += value2;
//			this._DataGridView1.MouseDoubleClick += value3;
//			this._DataGridView1.KeyDown += value4;
//		}
//	}
//}

//// Token: 0x17000E1F RID: 3615
//// (get) Token: 0x060024F2 RID: 9458 RVA: 0x003D0A88 File Offset: 0x003CEE88
//// (set) Token: 0x060024F3 RID: 9459 RVA: 0x003D0A9C File Offset: 0x003CEE9C
//internal virtual Label Label11
//{
//	get
//	{
//		return this._Label11;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label11 = value;
//	}
//}

//// Token: 0x17000E20 RID: 3616
//// (get) Token: 0x060024F4 RID: 9460 RVA: 0x003D0AA8 File Offset: 0x003CEEA8
//// (set) Token: 0x060024F5 RID: 9461 RVA: 0x003D0ABC File Offset: 0x003CEEBC
//internal virtual DataGridView DataGridView7
//{
//	get
//	{
//		return this._DataGridView7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridView7 = value;
//	}
//}

//// Token: 0x17000E21 RID: 3617
//// (get) Token: 0x060024F6 RID: 9462 RVA: 0x003D0AC8 File Offset: 0x003CEEC8
//// (set) Token: 0x060024F7 RID: 9463 RVA: 0x003D0ADC File Offset: 0x003CEEDC
//internal virtual DataGridViewTextBoxColumn D
//{
//	get
//	{
//		return this._D;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._D = value;
//	}
//}

//// Token: 0x17000E22 RID: 3618
//// (get) Token: 0x060024F8 RID: 9464 RVA: 0x003D0AE8 File Offset: 0x003CEEE8
//// (set) Token: 0x060024F9 RID: 9465 RVA: 0x003D0AFC File Offset: 0x003CEEFC
//internal virtual DataGridViewTextBoxColumn R
//{
//	get
//	{
//		return this._R;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._R = value;
//	}
//}

//// Token: 0x17000E23 RID: 3619
//// (get) Token: 0x060024FA RID: 9466 RVA: 0x003D0B08 File Offset: 0x003CEF08
//// (set) Token: 0x060024FB RID: 9467 RVA: 0x003D0B1C File Offset: 0x003CEF1C
//internal virtual DataGridViewTextBoxColumn A
//{
//	get
//	{
//		return this._A;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._A = value;
//	}
//}

//// Token: 0x17000E24 RID: 3620
//// (get) Token: 0x060024FC RID: 9468 RVA: 0x003D0B28 File Offset: 0x003CEF28
//// (set) Token: 0x060024FD RID: 9469 RVA: 0x003D0B3C File Offset: 0x003CEF3C
//internal virtual DataGridViewTextBoxColumn C
//{
//	get
//	{
//		return this._C;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._C = value;
//	}
//}

//// Token: 0x17000E25 RID: 3621
//// (get) Token: 0x060024FE RID: 9470 RVA: 0x003D0B48 File Offset: 0x003CEF48
//// (set) Token: 0x060024FF RID: 9471 RVA: 0x003D0B5C File Offset: 0x003CEF5C
//internal virtual DataGridViewTextBoxColumn T
//{
//	get
//	{
//		return this._T;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._T = value;
//	}
//}

//// Token: 0x17000E26 RID: 3622
//// (get) Token: 0x06002500 RID: 9472 RVA: 0x003D0B68 File Offset: 0x003CEF68
//// (set) Token: 0x06002501 RID: 9473 RVA: 0x003D0B7C File Offset: 0x003CEF7C
//internal virtual Button Button4
//{
//	get
//	{
//		return this._Button4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button4_Click);
//		if (this._Button4 != null)
//		{
//			this._Button4.Click -= value2;
//		}
//		this._Button4 = value;
//		if (this._Button4 != null)
//		{
//			this._Button4.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E27 RID: 3623
//// (get) Token: 0x06002502 RID: 9474 RVA: 0x003D0BC8 File Offset: 0x003CEFC8
//// (set) Token: 0x06002503 RID: 9475 RVA: 0x003D0BDC File Offset: 0x003CEFDC
//internal virtual Button Button5
//{
//	get
//	{
//		return this._Button5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button5_Click);
//		if (this._Button5 != null)
//		{
//			this._Button5.Click -= value2;
//		}
//		this._Button5 = value;
//		if (this._Button5 != null)
//		{
//			this._Button5.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E28 RID: 3624
//// (get) Token: 0x06002504 RID: 9476 RVA: 0x003D0C28 File Offset: 0x003CF028
//// (set) Token: 0x06002505 RID: 9477 RVA: 0x003D0C3C File Offset: 0x003CF03C
//internal virtual ComboBox ComboBox3
//{
//	get
//	{
//		return this._ComboBox3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._ComboBox3 = value;
//	}
//}

//// Token: 0x17000E29 RID: 3625
//// (get) Token: 0x06002506 RID: 9478 RVA: 0x003D0C48 File Offset: 0x003CF048
//// (set) Token: 0x06002507 RID: 9479 RVA: 0x003D0C5C File Offset: 0x003CF05C
//internal virtual ComboBox ComboBox1
//{
//	get
//	{
//		return this._ComboBox1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.ComboBox1_SelectedIndexChanged);
//		if (this._ComboBox1 != null)
//		{
//			this._ComboBox1.SelectedIndexChanged -= value2;
//		}
//		this._ComboBox1 = value;
//		if (this._ComboBox1 != null)
//		{
//			this._ComboBox1.SelectedIndexChanged += value2;
//		}
//	}
//}

//// Token: 0x17000E2A RID: 3626
//// (get) Token: 0x06002508 RID: 9480 RVA: 0x003D0CA8 File Offset: 0x003CF0A8
//// (set) Token: 0x06002509 RID: 9481 RVA: 0x003D0CBC File Offset: 0x003CF0BC
//internal virtual Button Button14
//{
//	get
//	{
//		return this._Button14;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button14_Click);
//		if (this._Button14 != null)
//		{
//			this._Button14.Click -= value2;
//		}
//		this._Button14 = value;
//		if (this._Button14 != null)
//		{
//			this._Button14.Click += value2;
//		}
//	}
//}

//// Token: 0x17000E2B RID: 3627
//// (get) Token: 0x0600250A RID: 9482 RVA: 0x003D0D08 File Offset: 0x003CF108
//// (set) Token: 0x0600250B RID: 9483 RVA: 0x003D0D1C File Offset: 0x003CF11C
//internal virtual DataGridView DataGridView8
//{
//	get
//	{
//		return this._DataGridView8;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridView8 = value;
//	}
//}

//// Token: 0x17000E2C RID: 3628
//// (get) Token: 0x0600250C RID: 9484 RVA: 0x003D0D28 File Offset: 0x003CF128
//// (set) Token: 0x0600250D RID: 9485 RVA: 0x003D0D3C File Offset: 0x003CF13C
//internal virtual DataGridViewTextBoxColumn Column17
//{
//	get
//	{
//		return this._Column17;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column17 = value;
//	}
//}

//// Token: 0x17000E2D RID: 3629
//// (get) Token: 0x0600250E RID: 9486 RVA: 0x003D0D48 File Offset: 0x003CF148
//// (set) Token: 0x0600250F RID: 9487 RVA: 0x003D0D5C File Offset: 0x003CF15C
//internal virtual DataGridView DataGridView9
//{
//	get
//	{
//		return this._DataGridView9;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridView9 = value;
//	}
//}

//// Token: 0x17000E2E RID: 3630
//// (get) Token: 0x06002510 RID: 9488 RVA: 0x003D0D68 File Offset: 0x003CF168
//// (set) Token: 0x06002511 RID: 9489 RVA: 0x003D0D7C File Offset: 0x003CF17C
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn7 = value;
//	}
//}

//// Token: 0x17000E2F RID: 3631
//// (get) Token: 0x06002512 RID: 9490 RVA: 0x003D0D88 File Offset: 0x003CF188
//// (set) Token: 0x06002513 RID: 9491 RVA: 0x003D0D9C File Offset: 0x003CF19C
//internal virtual DataGridViewTextBoxColumn Column18
//{
//	get
//	{
//		return this._Column18;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column18 = value;
//	}
//}

//// Token: 0x17000E30 RID: 3632
//// (get) Token: 0x06002514 RID: 9492 RVA: 0x003D0DA8 File Offset: 0x003CF1A8
//// (set) Token: 0x06002515 RID: 9493 RVA: 0x003D0DBC File Offset: 0x003CF1BC
//internal virtual Panel Panel1
//{
//	get
//	{
//		return this._Panel1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel1 = value;
//	}
//}

//// Token: 0x17000E31 RID: 3633
//// (get) Token: 0x06002516 RID: 9494 RVA: 0x003D0DC8 File Offset: 0x003CF1C8
//// (set) Token: 0x06002517 RID: 9495 RVA: 0x003D0DDC File Offset: 0x003CF1DC
//internal virtual Panel Panel2
//{
//	get
//	{
//		return this._Panel2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel2 = value;
//	}
//}

//// Token: 0x17000E32 RID: 3634
//// (get) Token: 0x06002518 RID: 9496 RVA: 0x003D0DE8 File Offset: 0x003CF1E8
//// (set) Token: 0x06002519 RID: 9497 RVA: 0x003D0DFC File Offset: 0x003CF1FC
//internal virtual Panel Panel3
//{
//	get
//	{
//		return this._Panel3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel3 = value;
//	}
//}

//// Token: 0x17000E33 RID: 3635
//// (get) Token: 0x0600251A RID: 9498 RVA: 0x003D0E08 File Offset: 0x003CF208
//// (set) Token: 0x0600251B RID: 9499 RVA: 0x003D0E1C File Offset: 0x003CF21C
//internal virtual Panel Panel5
//{
//	get
//	{
//		return this._Panel5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel5 = value;
//	}
//}

//// Token: 0x17000E34 RID: 3636
//// (get) Token: 0x0600251C RID: 9500 RVA: 0x003D0E28 File Offset: 0x003CF228
//// (set) Token: 0x0600251D RID: 9501 RVA: 0x003D0E3C File Offset: 0x003CF23C
//internal virtual Panel Panel6
//{
//	get
//	{
//		return this._Panel6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel6 = value;
//	}
//}

//// Token: 0x17000E35 RID: 3637
//// (get) Token: 0x0600251E RID: 9502 RVA: 0x003D0E48 File Offset: 0x003CF248
//// (set) Token: 0x0600251F RID: 9503 RVA: 0x003D0E5C File Offset: 0x003CF25C
//internal virtual Panel Panel7
//{
//	get
//	{
//		return this._Panel7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel7 = value;
//	}
//}

//// Token: 0x17000E36 RID: 3638
//// (get) Token: 0x06002520 RID: 9504 RVA: 0x003D0E68 File Offset: 0x003CF268
//// (set) Token: 0x06002521 RID: 9505 RVA: 0x003D0E7C File Offset: 0x003CF27C
//internal virtual Panel Panel4
//{
//	get
//	{
//		return this._Panel4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel4 = value;
//	}
//}

//// Token: 0x17000E37 RID: 3639
//// (get) Token: 0x06002522 RID: 9506 RVA: 0x003D0E88 File Offset: 0x003CF288
//// (set) Token: 0x06002523 RID: 9507 RVA: 0x003D0E9C File Offset: 0x003CF29C
//internal virtual ComboBox txtname
//{
//	get
//	{
//		return this._txtname;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		KeyEventHandler value2 = new KeyEventHandler(this.txtname_KeyDown_1);
//		KeyPressEventHandler value3 = new KeyPressEventHandler(this.txtname_KeyPress);
//		if (this._txtname != null)
//		{
//			this._txtname.KeyDown -= value2;
//			this._txtname.KeyPress -= value3;
//		}
//		this._txtname = value;
//		if (this._txtname != null)
//		{
//			this._txtname.KeyDown += value2;
//			this._txtname.KeyPress += value3;
//		}
//	}
//}

//// Token: 0x17000E38 RID: 3640
//// (get) Token: 0x06002524 RID: 9508 RVA: 0x003D0F0C File Offset: 0x003CF30C
//// (set) Token: 0x06002525 RID: 9509 RVA: 0x003D0F20 File Offset: 0x003CF320
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn1 = value;
//	}
//}

//// Token: 0x17000E39 RID: 3641
//// (get) Token: 0x06002526 RID: 9510 RVA: 0x003D0F2C File Offset: 0x003CF32C
//// (set) Token: 0x06002527 RID: 9511 RVA: 0x003D0F40 File Offset: 0x003CF340
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn2 = value;
//	}
//}

//// Token: 0x17000E3A RID: 3642
//// (get) Token: 0x06002528 RID: 9512 RVA: 0x003D0F4C File Offset: 0x003CF34C
//// (set) Token: 0x06002529 RID: 9513 RVA: 0x003D0F60 File Offset: 0x003CF360
//internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
//{
//	get
//	{
//		return this._DataGridViewTextBoxColumn3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridViewTextBoxColumn3 = value;
//	}
//}

//// Token: 0x17000E3B RID: 3643
//// (get) Token: 0x0600252A RID: 9514 RVA: 0x003D0F6C File Offset: 0x003CF36C
//// (set) Token: 0x0600252B RID: 9515 RVA: 0x003D0F80 File Offset: 0x003CF380
//internal virtual DataGridViewTextBoxColumn Column14
//{
//	get
//	{
//		return this._Column14;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column14 = value;
//	}
//}

//// Token: 0x17000E3C RID: 3644
//// (get) Token: 0x0600252C RID: 9516 RVA: 0x003D0F8C File Offset: 0x003CF38C
//// (set) Token: 0x0600252D RID: 9517 RVA: 0x003D0FA0 File Offset: 0x003CF3A0
//internal virtual DataGridViewTextBoxColumn Column4
//{
//	get
//	{
//		return this._Column4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column4 = value;
//	}
//}

//// Token: 0x17000E3D RID: 3645
//// (get) Token: 0x0600252E RID: 9518 RVA: 0x003D0FAC File Offset: 0x003CF3AC
//// (set) Token: 0x0600252F RID: 9519 RVA: 0x003D0FC0 File Offset: 0x003CF3C0
//internal virtual DataGridViewTextBoxColumn Column5
//{
//	get
//	{
//		return this._Column5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column5 = value;
//	}
//}

//// Token: 0x17000E3E RID: 3646
//// (get) Token: 0x06002530 RID: 9520 RVA: 0x003D0FCC File Offset: 0x003CF3CC
//// (set) Token: 0x06002531 RID: 9521 RVA: 0x003D0FE0 File Offset: 0x003CF3E0
//internal virtual DataGridViewTextBoxColumn Column6
//{
//	get
//	{
//		return this._Column6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column6 = value;
//	}
//}

//// Token: 0x17000E3F RID: 3647
//// (get) Token: 0x06002532 RID: 9522 RVA: 0x003D0FEC File Offset: 0x003CF3EC
//// (set) Token: 0x06002533 RID: 9523 RVA: 0x003D1000 File Offset: 0x003CF400
//internal virtual DataGridViewTextBoxColumn Column15
//{
//	get
//	{
//		return this._Column15;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column15 = value;
//	}
//}

//// Token: 0x17000E40 RID: 3648
//// (get) Token: 0x06002534 RID: 9524 RVA: 0x003D100C File Offset: 0x003CF40C
//// (set) Token: 0x06002535 RID: 9525 RVA: 0x003D1020 File Offset: 0x003CF420
//internal virtual DataGridViewTextBoxColumn Column1
//{
//	get
//	{
//		return this._Column1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column1 = value;
//	}
//}

//// Token: 0x17000E41 RID: 3649
//// (get) Token: 0x06002536 RID: 9526 RVA: 0x003D102C File Offset: 0x003CF42C
//// (set) Token: 0x06002537 RID: 9527 RVA: 0x003D1040 File Offset: 0x003CF440
//internal virtual DataGridViewTextBoxColumn Column2
//{
//	get
//	{
//		return this._Column2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column2 = value;
//	}
//}

//// Token: 0x17000E42 RID: 3650
//// (get) Token: 0x06002538 RID: 9528 RVA: 0x003D104C File Offset: 0x003CF44C
//// (set) Token: 0x06002539 RID: 9529 RVA: 0x003D1060 File Offset: 0x003CF460
//internal virtual DataGridViewTextBoxColumn Column3
//{
//	get
//	{
//		return this._Column3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column3 = value;
//	}
//}

//// Token: 0x17000E43 RID: 3651
//// (get) Token: 0x0600253A RID: 9530 RVA: 0x003D106C File Offset: 0x003CF46C
//// (set) Token: 0x0600253B RID: 9531 RVA: 0x003D1080 File Offset: 0x003CF480
//internal virtual DataGridViewTextBoxColumn Column10
//{
//	get
//	{
//		return this._Column10;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column10 = value;
//	}
//}

//// Token: 0x17000E44 RID: 3652
//// (get) Token: 0x0600253C RID: 9532 RVA: 0x003D108C File Offset: 0x003CF48C
//// (set) Token: 0x0600253D RID: 9533 RVA: 0x003D10A0 File Offset: 0x003CF4A0
//internal virtual DataGridViewTextBoxColumn Column19
//{
//	get
//	{
//		return this._Column19;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column19 = value;
//	}
//}

//// Token: 0x17000E45 RID: 3653
//// (get) Token: 0x0600253E RID: 9534 RVA: 0x003D10AC File Offset: 0x003CF4AC
//// (set) Token: 0x0600253F RID: 9535 RVA: 0x003D10C0 File Offset: 0x003CF4C0
//internal virtual DataGridViewTextBoxColumn Column23
//{
//	get
//	{
//		return this._Column23;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column23 = value;
//	}
//}

//// Token: 0x17000E46 RID: 3654
//// (get) Token: 0x06002540 RID: 9536 RVA: 0x003D10CC File Offset: 0x003CF4CC
//// (set) Token: 0x06002541 RID: 9537 RVA: 0x003D10E0 File Offset: 0x003CF4E0
//internal virtual DataGridViewTextBoxColumn Column24
//{
//	get
//	{
//		return this._Column24;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column24 = value;
//	}
//}

//// Token: 0x17000E47 RID: 3655
//// (get) Token: 0x06002542 RID: 9538 RVA: 0x003D10EC File Offset: 0x003CF4EC
//// (set) Token: 0x06002543 RID: 9539 RVA: 0x003D1100 File Offset: 0x003CF500
//internal virtual DataGridViewTextBoxColumn Column7
//{
//	get
//	{
//		return this._Column7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column7 = value;
//	}
//}

//// Token: 0x17000E48 RID: 3656
//// (get) Token: 0x06002544 RID: 9540 RVA: 0x003D110C File Offset: 0x003CF50C
//// (set) Token: 0x06002545 RID: 9541 RVA: 0x003D1120 File Offset: 0x003CF520
//internal virtual DataGridViewTextBoxColumn Column8
//{
//	get
//	{
//		return this._Column8;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column8 = value;
//	}
//}

//// Token: 0x17000E49 RID: 3657
//// (get) Token: 0x06002546 RID: 9542 RVA: 0x003D112C File Offset: 0x003CF52C
//// (set) Token: 0x06002547 RID: 9543 RVA: 0x003D1140 File Offset: 0x003CF540
//internal virtual DataGridViewTextBoxColumn Column9
//{
//	get
//	{
//		return this._Column9;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column9 = value;
//	}
//}

//// Token: 0x17000E4A RID: 3658
//// (get) Token: 0x06002548 RID: 9544 RVA: 0x003D114C File Offset: 0x003CF54C
//// (set) Token: 0x06002549 RID: 9545 RVA: 0x003D1160 File Offset: 0x003CF560
//internal virtual DataGridViewTextBoxColumn Column20
//{
//	get
//	{
//		return this._Column20;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column20 = value;
//	}
//}

//// Token: 0x17000E4B RID: 3659
//// (get) Token: 0x0600254A RID: 9546 RVA: 0x003D116C File Offset: 0x003CF56C
//// (set) Token: 0x0600254B RID: 9547 RVA: 0x003D1180 File Offset: 0x003CF580
//internal virtual DataGridViewTextBoxColumn Column21
//{
//	get
//	{
//		return this._Column21;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column21 = value;
//	}
//}

//// Token: 0x17000E4C RID: 3660
//// (get) Token: 0x0600254C RID: 9548 RVA: 0x003D118C File Offset: 0x003CF58C
//// (set) Token: 0x0600254D RID: 9549 RVA: 0x003D11A0 File Offset: 0x003CF5A0
//internal virtual DataGridViewTextBoxColumn Column22
//{
//	get
//	{
//		return this._Column22;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column22 = value;
//	}
//}

