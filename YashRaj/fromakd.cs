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
	// Token: 0x02000049 RID: 73
	//[DesignerGenerated]
	public partial class fromakd : Form
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x0033CA04 File Offset: 0x0033AE04
		public fromakd()
		{
			//base.Activated += this.fromakd_Activated;
			//base.Load += this.fromakd_Load;
			//base.MouseEnter += this.fromakd_MouseEnter;
			this.InitializeComponent();
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0034014C File Offset: 0x0033E54C
		public void YES_NO()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = " Select *  from Settings";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.CheckBox2.Checked = Conversions.ToBoolean(oleDbDataReader[3]);
					this.txtnu.Text = Conversions.ToString(oleDbDataReader["s_Number_Format"]);
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

		// Token: 0x060012B4 RID: 4788 RVA: 0x003401F0 File Offset: 0x0033E5F0
		private void fromakd_Activated(object sender, EventArgs e)
		{
			this.txtamount.Focus();
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00340200 File Offset: 0x0033E600
		private void fromakd_Load(object sender, EventArgs e)
		{
			try
			{
				Size size = new Size(718, 659);
				this.Size = size;
				int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
				int y = 1; //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
				Point location = new Point(x, y);
				this.Location = location;
				this.YES_NO();
				//if (this.CheckBox2.Checked)
				//{
				//	this.txtnu.Text = ".00";
				//}
				//else
				//{
				//	this.txtnu.Text = ".000";
				//}
				//if (Operators.CompareString(this.txtnu.Text, ".00", false) == 0 & Operators.CompareString(mod_serial_id._mindi_hide, "1", false) == 0)
				//{
				//	this.txtnu.Text = "0";
				//}
				this.CheckBox2.Hide();
				this.DataGridView2.Rows.Clear();
				this.DataGridView1.Rows.Add(new object[]
				{
					"Net"
				});
				this.txtsesionID.Text = Conversions.ToString(Module1.nehaid);
				this.Combolod();
				this.dispayname_Match();
				this.shwo_all_Enty();
				this.Autono();
				this.Total();
				this.Decleard();
				this.color_all();
				this.txtamount.Focus();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x003403A4 File Offset: 0x0033E7A4
		public void Decleard()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "Select * from ewSession where Sr_No=" + Conversions.ToString(Module1.nehaid) + " and Result='Declared'";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.BtnDelete.Enabled = false;
					this.btnModify.Enabled = false;
					this.btnOK.Enabled = false;
				}
				else
				{
					this.BtnDelete.Enabled = true;
					this.btnModify.Enabled = true;
					this.btnOK.Enabled = true;
				}
				Module1.conn.Close();
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

		// Token: 0x060012B7 RID: 4791 RVA: 0x00340498 File Offset: 0x0033E898
		public void dispayname_Match()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "Select * from Newmatch where Sr_No=" + this.txtsesionID.Text;
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					this.lblDispay.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader[2], "  "), " VS "), "  "), oleDbDataReader[3]));
				}
				string cmdText2 = "Select * from ewSession where Match_ID=" + this.txtsesionID.Text;
				OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
				OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
				while (oleDbDataReader2.Read())
				{
					this.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader2[3], "      "), "("), oleDbDataReader2[7]), ")"));
					this.Session_Fipty_tmp = RuntimeHelpers.GetObjectValue(oleDbDataReader2[7]);
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

		// Token: 0x060012B8 RID: 4792 RVA: 0x0034061C File Offset: 0x0033EA1C
		public void Combolod()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				this.txtparty.Items.Clear();
				string cmdText = "Select * from Newparty";
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
								this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
							}
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
				Module1.conn.Close();
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00340718 File Offset: 0x0033EB18
		private void fromakd_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Size size = new Size(718, 659);
				this.Size = size;
				int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
				int y = 1; //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
				Point location = new Point(x, y);
				this.Location = location;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x003407B4 File Offset: 0x0033EBB4
		private void Button10_Click(object sender, EventArgs e)
		{
			this.DataGridView1.Columns.Clear();
			this.DataGridView1.Columns.Clear();
			this.DataGridView1.Columns.Add("Column Name", "Team");
			this.DataGridView1.Rows.Add(new object[]
			{
				" Net Total "
			});
			this.DataGridView1.Columns[0].Width = 120;
			this.DataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightSlateGray;
			this.DataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.White;
			this.DataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
			this.DataGridView1.Columns[0].DefaultCellStyle.SelectionForeColor = Color.White;
			int num = 0;
			this.DataGridView1.Columns[num].Width = 90;
			num = 0;
			checked
			{
				do
				{
					this.DataGridView1.Columns.Add("Column Name", Conversions.ToString(num));
					num++;
				}
				while (num <= 9);
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x003408F4 File Offset: 0x0033ECF4
		private void Button11_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtmode.Text, "K", false) == 0)
			{
				this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text) - Conversion.Val(this.txtamount.Text));
				this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text));
				this.txtL.Text = this.txtamount.Text;
			}
			else if (Operators.CompareString(this.txtmode.Text, "L", false) == 0)
			{
				this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text) - Conversion.Val(this.txtamount.Text));
				this.txtL.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00340A5C File Offset: 0x0033EE5C
		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				this.Autono();
				this.Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
				this.save_Data_to_Databesh();
				this.TextBox1.Text = Conversions.ToString(Conversion.Val(this.txtakd.Text) + 1.0);
				this.shwo_all_Enty();
				this.Total();
				this.color_all();
				this.txtamount.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00340AF8 File Offset: 0x0033EEF8
		public void Total()
		{
			try
			{
				this.DataGridView1.Rows.Clear();
				this.DataGridView1.Rows.Add(new object[]
				{
					" Net Total "
				});
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Newparty.Status, Newparty.Comm_On_Hari, Newparty.S_AKD, Newparty.A_AKD, Newparty.P_AKD, tablakd.Session_ID, tablakd.Rate, tablakd.Amount, tablakd.AKD, tablakd.Mode, tablakd.Party_name,tablakd.S_Yes, tablakd.S_No, tablakd.A_Delete FROM            (tablakd INNER JOIN Newparty ON tablakd.Party_name = Newparty.Party_name)WHERE        (tablakd.Session_ID = " + this.txtsesionID.Text + ") AND (tablakd.A_Delete <> 1)";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					double num = Conversions.ToDouble(oleDbDataReader["AKD"]);
					double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Yes"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_AKD"])) / 100.0 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Yes"]));
					double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_No"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_AKD"])) / 100.0 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_No"]));
					double num4 = Conversion.Val(num2) - Conversion.Val(num2) - Conversion.Val(num2);
					double num5 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
					double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["A_AKD"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["P_AKD"]));
					double num7 = Conversion.Val(num4) * Conversion.Val(num6) / 100.0 - Conversion.Val(num4);
					double num8 = Conversion.Val(num5) * Conversion.Val(num6) / 100.0 - Conversion.Val(num5);
					double num9 = Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7);
					double num10 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
					int num11 = 1;
					checked
					{
						int num12 = this.DataGridView1.Columns.Count - 1;
						for (int i = num11; i <= num12; i++)
						{
							if (Conversions.ToDouble(this.DataGridView1.Columns[i].HeaderText) == num)
							{
								DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
								dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(num9));
							}
							else
							{
								DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
								dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(num10));
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

		// Token: 0x060012BE RID: 4798 RVA: 0x00340E9C File Offset: 0x0033F29C
		public void shwo_all_Enty()
		{
			try
			{
				this.DataGridView2.Rows.Clear();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        ID, Session_ID, Page_No, Rate, Amount, AKD, Mode, Party_name, S_Yes, S_No, [Date], [Time], Modify, A_Delete, S_P FROM(tablakd)WHERE(Session_ID = " + this.txtsesionID.Text + ")ORDER BY ID DESC";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["A_Delete"], "1", false))
					{
						int index = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["ID"]);
						this.DataGridView2.Rows[index].Cells[1].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Amount"])), this.txtnu.Text);
						this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Rate"]);
						this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["AKD"]);
						this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Mode"]);
						this.DataGridView2.Rows[index].Cells[5].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Yes"])), this.txtnu.Text);
						this.DataGridView2.Rows[index].Cells[6].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_No"])), this.txtnu.Text);
						this.DataGridView2.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Party_name"]);
						this.DataGridView2.Rows[index].Cells[8].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Date"]), DateFormat.ShortDate);
						this.DataGridView2.Rows[index].Cells[10].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Time"]), DateFormat.LongTime);
						this.DataGridView2.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Page_No"]);
						this.DataGridView2.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
					}
					else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Modify"], "1", false))
					{
						int index2 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["ID"]);
						this.DataGridView2.Rows[index2].Cells[1].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Amount"])), this.txtnu.Text);
						this.DataGridView2.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Rate"]);
						this.DataGridView2.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["AKD"]);
						this.DataGridView2.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Mode"]);
						this.DataGridView2.Rows[index2].Cells[5].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Yes"])), this.txtnu.Text);
						this.DataGridView2.Rows[index2].Cells[6].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_No"])), this.txtnu.Text);
						this.DataGridView2.Rows[index2].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Party_name"]);
						this.DataGridView2.Rows[index2].Cells[8].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Date"]), DateFormat.ShortDate);
						this.DataGridView2.Rows[index2].Cells[10].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Time"]), DateFormat.LongTime);
						this.DataGridView2.Rows[index2].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Page_No"]);
						this.DataGridView2.Rows[index2].DefaultCellStyle.ForeColor = Color.Blue;
					}
					else
					{
						int index3 = this.DataGridView2.Rows.Add();
						this.DataGridView2.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["ID"]);
						this.DataGridView2.Rows[index3].Cells[1].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Amount"])), this.txtnu.Text);
						this.DataGridView2.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Rate"]);
						this.DataGridView2.Rows[index3].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["AKD"]);
						this.DataGridView2.Rows[index3].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Mode"]);
						this.DataGridView2.Rows[index3].Cells[5].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Yes"])), this.txtnu.Text);
						this.DataGridView2.Rows[index3].Cells[6].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_No"])), this.txtnu.Text);
						this.DataGridView2.Rows[index3].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Party_name"]);
						this.DataGridView2.Rows[index3].Cells[8].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Date"]), DateFormat.ShortDate);
						this.DataGridView2.Rows[index3].Cells[10].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Time"]), DateFormat.LongTime);
						this.DataGridView2.Rows[index3].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Page_No"]);
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

		// Token: 0x060012BF RID: 4799 RVA: 0x003417A0 File Offset: 0x0033FBA0
		public void color_all()
		{
			checked
			{
				try
				{
					int num = 1;
					do
					{
						this.DataGridView1.Rows[0].Cells[num].Value = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[num].Value)), this.txtnu.Text);
						if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[0].Cells[num].Value, 0, false))
						{
							this.DataGridView1.Rows[0].Cells[num].Style.ForeColor = Color.Red;
						}
						else
						{
							this.DataGridView1.Rows[0].Cells[num].Style.ForeColor = Color.Blue;
						}
						num++;
					}
					while (num <= 10);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x003418C4 File Offset: 0x0033FCC4
		public void save_Data_to_Databesh()
		{
			try
			{
				if (Operators.CompareString(this.txtamount.Text, "0.00", false) == 0)
				{
					Interaction.MsgBox("Please Fill Amount..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtrate.Text, "0.00", false) == 0)
				{
					Interaction.MsgBox("Please Fill Rate..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtakd.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Fill AKD..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtmode.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Fill Mode..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtparty.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Fill Party Name..?", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = string.Concat(new string[]
					{
						"insert into tablakd values(",
						this.txtid.Text,
						",",
						this.txtsesionID.Text,
						",'",
						this.txtpage.Text,
						"',",
						this.txtrate.Text,
						",",
						this.txtamount.Text,
						",",
						this.txtakd.Text,
						",'",
						this.txtmode.Text,
						"' ,'",
						this.txtparty.Text,
						"',",
						this.txtK.Text,
						",",
						this.txtL.Text,
						",'",
						Strings.FormatDateTime(DateTime.Now.Date, DateFormat.ShortDate),
						"','",
						Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime),
						"',0,0,'",
						this.txtparsent.Text,
						"')"
					});
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
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

		// Token: 0x060012C1 RID: 4801 RVA: 0x00341B90 File Offset: 0x0033FF90
		public void Autono()
		{
			checked
			{
				try
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = "select max(ID) from tablakd where Session_ID=" + this.txtsesionID.Text;
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
					{
						this.txtid.Text = "1";
					}
					else
					{
						int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
						num++;
						this.txtid.Text = num.ToString();
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
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00341C64 File Offset: 0x00340064
		private void txtmode_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00341C74 File Offset: 0x00340074
		private void btnrefrash_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					Size size = new Size(718, 682);
					this.Size = size;
					int x = Screen.PrimaryScreen.WorkingArea.Width - 726;
					int y = Screen.PrimaryScreen.WorkingArea.Height - 737;
					Point location = new Point(x, y);
					this.Location = location;
					this.Combolod();
					this.shwo_all_Enty();
					this.Autono();
					this.Total();
					this.color_all();
					this.txtamount.Focus();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00341D38 File Offset: 0x00340138
		private void txtakd_TextChanged(object sender, EventArgs e)
		{
			this.TextBox1.Text = Conversions.ToString(Conversion.Val(this.txtakd.Text) + 1.0);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00341D64 File Offset: 0x00340164
		private void DataGridView2_MouseClick(object sender, MouseEventArgs e)
		{

        }

        // Token: 0x060012C6 RID: 4806 RVA: 0x00341DC8 File Offset: 0x003401C8
        private void BtnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txtsesionID.Text, null, false) != 0)
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = string.Concat(new string[]
					{
						"update tablakd set A_Delete=1 where Session_ID=",
						this.txtsesionID.Text,
						" and ID=",
						Conversions.ToString(this.deleteID),
						""
					});
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
					Module1.conn.Close();
					this.Combolod();
					this.shwo_all_Enty();
					this.Autono();
					this.Total();
					this.color_all();
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

		// Token: 0x060012C7 RID: 4807 RVA: 0x00341EC8 File Offset: 0x003402C8
		private void Button9_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form3_SESSION.MdiParent = this.MdiParent;
			MyProject.Forms.Form3_SESSION.Show();
			this.Close();
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00341EF4 File Offset: 0x003402F4
		private void Button4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form3_SESSION.MdiParent = this.MdiParent;
			MyProject.Forms.Form3_SESSION.Show();
			this.Close();
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00341F20 File Offset: 0x00340320
		private void Button5_Click(object sender, EventArgs e)
		{			
			MyProject.Forms.New_Party.MdiParent = this.MdiParent;
			MyProject.Forms.New_Party.WindowState = FormWindowState.Maximized;
			MyProject.Forms.New_Party.Show();
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00341F58 File Offset: 0x00340358
		private void btnModify_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"Select * from tablakd  where Session_ID=",
					this.txtsesionID.Text,
					" and ID=",
					Conversions.ToString(this.deleteID),
					" and A_Delete=1 "
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					Interaction.MsgBox("Can not edit this Record", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					string cmdText2 = string.Concat(new string[]
					{
						"Select * from tablakd  where Session_ID=",
						this.txtsesionID.Text,
						" and ID=",
						Conversions.ToString(this.deleteID),
						" and A_Delete=0 "
					});
					OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
					OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
					if (oleDbDataReader2.Read())
					{
						this.txtpage.Text = Conversions.ToString(oleDbDataReader2[2]);
						this.txtamount.Text = Conversions.ToString(oleDbDataReader2[4]);
						this.txtrate.Text = Strings.Format(RuntimeHelpers.GetObjectValue(oleDbDataReader2[3]), this.txtnu.Text);
						this.txtakd.Text = Conversions.ToString(oleDbDataReader2[5]);
						this.txtmode.Text = Conversions.ToString(oleDbDataReader2[6]);
						this.txtparty.Text = Conversions.ToString(oleDbDataReader2[7]);
						this.txtid.Text = Conversions.ToString(oleDbDataReader2[0]);
						this.txtK.Text = Conversions.ToString(oleDbDataReader2[8]);
						this.txtL.Text = Conversions.ToString(oleDbDataReader2[9]);
						this.btnOK.Visible = false;
						this.Button1.Visible = true;
						this.Button2.Visible = true;
						this.txtamount.Focus();
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

		// Token: 0x060012CB RID: 4811 RVA: 0x003421D8 File Offset: 0x003405D8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.TextBox1.Text = Conversions.ToString(Conversion.Val(this.txtakd.Text) + 1.0);
				if (Operators.CompareString(this.txtamount.Text, "0.00", false) == 0)
				{
					Interaction.MsgBox("Please Fill Amount..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtrate.Text, "0.00", false) == 0)
				{
					Interaction.MsgBox("Please Fill Rate..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtakd.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Fill AKD..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtmode.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Fill Mode..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(this.txtparty.Text, null, false) == 0)
				{
					Interaction.MsgBox("Please Fill Party Name..?", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					this.Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
					string cmdText = string.Concat(new string[]
					{
						"UPDATE       tablakd SET                Page_No = '",
						this.txtpage.Text,
						"', Rate = ",
						this.txtrate.Text,
						", Amount = ",
						this.txtamount.Text,
						", AKD = ",
						this.txtakd.Text,
						", Mode = '",
						this.txtmode.Text,
						"', Party_name = '",
						this.txtparty.Text,
						"', S_Yes = ",
						this.txtK.Text,
						", S_No = ",
						this.txtL.Text,
						", [Date] = '",
						Strings.FormatDateTime(DateTime.Now.Date, DateFormat.ShortDate),
						"', [Time] = '",
						Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime),
						"', Modify = 1 WHERE        (tablakd.ID = ",
						Conversions.ToString(this.deleteID),
						") AND (tablakd.Session_ID = ",
						this.txtsesionID.Text,
						")"
					});
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					oleDbCommand.ExecuteNonQuery();
					this.Combolod();
					this.shwo_all_Enty();
					this.Autono();
					this.Total();
					this.color_all();
					this.GroupBox1.BackColor = Color.Transparent;
					this.btnOK.Show();
					this.Button1.Hide();
					this.Button2.Hide();
					this.txtamount.Focus();
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

		// Token: 0x060012CC RID: 4812 RVA: 0x0034251C File Offset: 0x0034091C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtpage.Text = "1";
				this.txtamount.Text = "";
				this.txtrate.Text = "";
				this.txtakd.Text = "";
				this.txtmode.Text = "";
				this.txtparty.Text = "";
				this.txtK.Text = "";
				this.txtL.Text = "";
				this.txtid.Text = "";
				this.GroupBox1.BackColor = Color.Transparent;
				this.btnOK.Visible = true;
				this.Button1.Visible = false;
				this.Button2.Visible = false;
				this.txtamount.Focus();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00342628 File Offset: 0x00340A28
		public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
		{
			checked
			{
				string text;
				if (e.KeyChar == '\b')
				{
					if (this.txtparty.SelectionStart <= 1)
					{
						this.txtparty.Text = "";
						return;
					}
					if (this.txtparty.SelectionLength == 0)
					{
						text = this.txtparty.Text.Substring(0, this.txtparty.Text.Length - 1);
					}
					else
					{
						text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart - 1);
					}
				}
				else if (this.txtparty.SelectionLength == 0)
				{
					text = this.txtparty.Text + Conversions.ToString(e.KeyChar);
				}
				else
				{
					text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart) + Conversions.ToString(e.KeyChar);
				}
				int num = this.txtparty.FindString(text);
				if (num != -1)
				{
					this.txtparty.SelectedText = "";
					this.txtparty.SelectedIndex = num;
					this.txtparty.SelectionStart = text.Length;
					this.txtparty.SelectionLength = this.txtparty.Text.Length;
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

		// Token: 0x060012CE RID: 4814 RVA: 0x00342784 File Offset: 0x00340B84
		private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
		{
			ComboBox txtparty = this.txtparty;
			this.AutoComplete11(ref txtparty, e, false);
			this.txtparty = txtparty;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x003427AC File Offset: 0x00340BAC
		private void txtamount_Leave(object sender, EventArgs e)
		{
			this.txtamount.Text = Strings.Format(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x003427E0 File Offset: 0x00340BE0
		private void txtrate_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
				{
					this.txtrate.Focus();
				}
				else
				{
					string text = this.txtrate.Text;
					double num = (double)text.IndexOf(".");
					if (num < 0.0)
					{
						this.txtrate.Text = this.txtrate.Text.Replace(this.txtrate.Text, "." + this.txtrate.Text);
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x003428A0 File Offset: 0x00340CA0
		private void txtpage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				SendKeys.Send("{Tab}");
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x003428B8 File Offset: 0x00340CB8
		private void txtparty_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return && this.btnOK.Visible)
				{
					this.btnOK.Focus();
				}
				else
				{
					this.Button1.Focus();
				}
				if (e.KeyCode == Keys.Back)
				{
					this.txtparty.Text = null;
					this.txtparty.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0400077E RID: 1918
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400077F RID: 1919
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x04000780 RID: 1920
		[AccessedThroughProperty("btnrefrash")]
		private Button _btnrefrash;

		// Token: 0x04000781 RID: 1921
		[AccessedThroughProperty("BtnDelete")]
		private Button _BtnDelete;

		// Token: 0x04000782 RID: 1922
		[AccessedThroughProperty("btnModify")]
		private Button _btnModify;

		// Token: 0x04000783 RID: 1923
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x04000784 RID: 1924
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x04000785 RID: 1925
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000786 RID: 1926
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000787 RID: 1927
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x04000788 RID: 1928
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000789 RID: 1929
		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		// Token: 0x0400078A RID: 1930
		[AccessedThroughProperty("txtparty")]
		private ComboBox _txtparty;

		// Token: 0x0400078B RID: 1931
		[AccessedThroughProperty("txtmode")]
		private ComboBox _txtmode;

		// Token: 0x0400078C RID: 1932
		[AccessedThroughProperty("txtakd")]
		private ComboBox _txtakd;

		// Token: 0x0400078D RID: 1933
		[AccessedThroughProperty("txtrate")]
		private TextBox _txtrate;

		// Token: 0x0400078E RID: 1934
		[AccessedThroughProperty("txtamount")]
		private TextBox _txtamount;

		// Token: 0x0400078F RID: 1935
		[AccessedThroughProperty("txtpage")]
		private TextBox _txtpage;

		// Token: 0x04000790 RID: 1936
		[AccessedThroughProperty("txtsn")]
		private TextBox _txtsn;

		// Token: 0x04000791 RID: 1937
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000792 RID: 1938
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000793 RID: 1939
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000794 RID: 1940
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000795 RID: 1941
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000796 RID: 1942
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000797 RID: 1943
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000798 RID: 1944
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x04000799 RID: 1945
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x0400079A RID: 1946
		[AccessedThroughProperty("txtK")]
		private TextBox _txtK;

		// Token: 0x0400079B RID: 1947
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		// Token: 0x0400079C RID: 1948
		[AccessedThroughProperty("txtL")]
		private TextBox _txtL;

		// Token: 0x0400079D RID: 1949
		[AccessedThroughProperty("txtid")]
		private TextBox _txtid;

		// Token: 0x0400079E RID: 1950
		[AccessedThroughProperty("txtsesionID")]
		private TextBox _txtsesionID;

		// Token: 0x0400079F RID: 1951
		[AccessedThroughProperty("txtdate")]
		private DateTimePicker _txtdate;

		// Token: 0x040007A0 RID: 1952
		[AccessedThroughProperty("txtparsent")]
		private Label _txtparsent;

		// Token: 0x040007A1 RID: 1953
		[AccessedThroughProperty("btnYesh")]
		private Button _btnYesh;

		// Token: 0x040007A2 RID: 1954
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040007A3 RID: 1955
		[AccessedThroughProperty("txtnu")]
		private TextBox _txtnu;

		// Token: 0x040007A4 RID: 1956
		[AccessedThroughProperty("btnno")]
		private Button _btnno;

		// Token: 0x040007A5 RID: 1957
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040007A6 RID: 1958
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040007A7 RID: 1959
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040007A8 RID: 1960
		[AccessedThroughProperty("lblDispay")]
		private Label _lblDispay;

		// Token: 0x040007A9 RID: 1961
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x040007AA RID: 1962
		[AccessedThroughProperty("Column11")]
		private DataGridViewTextBoxColumn _Column11;

		// Token: 0x040007AB RID: 1963
		[AccessedThroughProperty("Column13")]
		private DataGridViewTextBoxColumn _Column13;

		// Token: 0x040007AC RID: 1964
		[AccessedThroughProperty("Column14")]
		private DataGridViewTextBoxColumn _Column14;

		// Token: 0x040007AD RID: 1965
		[AccessedThroughProperty("Column15")]
		private DataGridViewTextBoxColumn _Column15;

		// Token: 0x040007AE RID: 1966
		[AccessedThroughProperty("Column21")]
		private DataGridViewTextBoxColumn _Column21;

		// Token: 0x040007AF RID: 1967
		[AccessedThroughProperty("Column19")]
		private DataGridViewTextBoxColumn _Column19;

		// Token: 0x040007B0 RID: 1968
		[AccessedThroughProperty("Column1")]
		private DataGridViewTextBoxColumn _Column1;

		// Token: 0x040007B1 RID: 1969
		[AccessedThroughProperty("Column16")]
		private DataGridViewTextBoxColumn _Column16;

		// Token: 0x040007B2 RID: 1970
		[AccessedThroughProperty("Column17")]
		private DataGridViewTextBoxColumn _Column17;

		// Token: 0x040007B3 RID: 1971
		[AccessedThroughProperty("Column12")]
		private DataGridViewTextBoxColumn _Column12;

		// Token: 0x040007B4 RID: 1972
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x040007B5 RID: 1973
		[AccessedThroughProperty("Panel4")]
		private Panel _Panel4;

		// Token: 0x040007B6 RID: 1974
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x040007B7 RID: 1975
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x040007B8 RID: 1976
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x040007B9 RID: 1977
		[AccessedThroughProperty("Column6")]
		private DataGridViewTextBoxColumn _Column6;

		// Token: 0x040007BA RID: 1978
		[AccessedThroughProperty("Column7")]
		private DataGridViewTextBoxColumn _Column7;

		// Token: 0x040007BB RID: 1979
		[AccessedThroughProperty("Column8")]
		private DataGridViewTextBoxColumn _Column8;

		// Token: 0x040007BC RID: 1980
		[AccessedThroughProperty("Column9")]
		private DataGridViewTextBoxColumn _Column9;

		// Token: 0x040007BD RID: 1981
		[AccessedThroughProperty("Column10")]
		private DataGridViewTextBoxColumn _Column10;

		// Token: 0x040007BE RID: 1982
		[AccessedThroughProperty("Column18")]
		private DataGridViewTextBoxColumn _Column18;

		// Token: 0x040007BF RID: 1983
		[AccessedThroughProperty("Column20")]
		private DataGridViewTextBoxColumn _Column20;

		// Token: 0x040007C0 RID: 1984
		[AccessedThroughProperty("Column22")]
		private DataGridViewTextBoxColumn _Column22;

		// Token: 0x040007C1 RID: 1985
		private int deleteID;

		// Token: 0x040007C2 RID: 1986
		private object Session_Fipty_tmp;
	}
}
