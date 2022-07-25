using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using App.Service;

namespace YashAksh
{
    // Token: 0x02000009 RID: 9
    //[DesignerGenerated]
    public partial class Agent_match : Form
    {
        // Token: 0x06000189 RID: 393 RVA: 0x002804D0 File Offset: 0x0027E8D0
        public Agent_match()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000242 RID: 578 RVA: 0x00284BCC File Offset: 0x00282FCC
        private void Agent_match_Activated(object sender, EventArgs e)
        {
            try
            {
                this.txtname1.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000243 RID: 579 RVA: 0x00284C14 File Offset: 0x00283014
        private void Agent_match_Load(object sender, EventArgs e)
        {
            try
            {
                this.testnu.Text = Conversions.ToString(Module1.machid);
                this.txtnu.Text = Module1.decimalnumberformat;
                this.listvieColumname();
                this.combolod();
                this.nptotal();
                this.colore_Click();
                this.txtname1.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000244 RID: 580 RVA: 0x00284D3C File Offset: 0x0028313C
        public void listlode_Agent_name()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    int totalcnt = 0;
                    if (Operators.CompareString(this.txtname1.Text, null, false) != 0)
                    {
                        this.DataGridView1.Rows.Clear();
                        string cmdText = string.Concat(new string[]
                        {
                            "SELECT PartyMaster.PartyName, MatchTrans.m_party, MatchTrans.id, MatchTrans.m_id, MatchTrans.m_eid, MatchTrans.m_page, MatchTrans.m_amt, MatchTrans.m_rate, MatchTrans.m_team, MatchTrans.m_mode, MatchTrans.Status, MatchTrans.m_dt, MatchTrans.m_time, MatchTrans.m_team1, MatchTrans.m_team2, MatchTrans.m_team3, MatchTrans.m_team4, MatchTrans.Modify, MatchTrans.m_checked, MatchTrans.M_P, MatchTrans.M_chk, PartyMaster.TParty FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_id = ",
                            this.testnu.Text,
                            ") AND (PartyMaster.AParty = '",
                            this.txtname1.Text,
                            "' OR PartyMaster.PartyName = '",
                            this.txtname1.Text,
                            "' OR PartyMaster.TParty = '",
                            this.txtname1.Text,
                            "') ORDER BY MatchTrans.m_eid DESC"

							//this.txtname1.Text,
							//"') AND (MatchTrans.m_id = ",
							//this.testnu.Text,
							//") OR (PartyMaster.PartyName = '",
							//this.txtname1.Text,
							//"' OR PartyMaster.TParty = '",
							//this.txtname1.Text,
							//"')ORDER BY MatchTrans.m_eid DESC"

						});
                        this.cmd = new OleDbCommand(cmdText, Module1.conn);
                        this.dr = this.cmd.ExecuteReader();
                        while (this.dr.Read())
                        {

                            int num = this.DataGridView1.Rows.Add();
                            this.DataGridView1.Rows[num].Cells[1].Value = this.dr["m_eid"].ToString();
                            this.DataGridView1.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                            this.DataGridView1.Rows[num].Cells[3].Value = this.dr["m_rate"].ToString();
                            this.DataGridView1.Rows[num].Cells[4].Value = this.dr["m_team"].ToString();
                            this.DataGridView1.Rows[num].Cells[5].Value = this.dr["m_mode"].ToString();
                            this.DataGridView1.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(this.dr["m_time"].ToString()), DateFormat.LongTime);
                            this.DataGridView1.Rows[num].Cells[7].Value = this.dr["m_dt"].ToString();
                            this.DataGridView1.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team1"].ToString()), this.txtnu.Text);
                            this.DataGridView1.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team2"].ToString()), this.txtnu.Text);
                            this.DataGridView1.Rows[num].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team3"].ToString()), this.txtnu.Text);
                            this.DataGridView1.Rows[num].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team4"].ToString()), this.txtnu.Text);

                            this.DataGridView1.Rows[num].Cells[12].Value = this.dr["Modify"].ToString();
                            this.DataGridView1.Rows[num].Cells[13].Value = this.dr["m_checked"].ToString();
                            this.DataGridView1.Rows[num].Cells[14].Value = this.dr["M_chk"].ToString();

                            if (Operators.ConditionalCompareObjectEqual(this.dr["m_checked"], "1", false))
                            {
                                this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                                //this.DataGridView1.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                            }
                            else if (Operators.ConditionalCompareObjectEqual(this.dr["M_chk"], "1", false))
                            {
                                this.DataGridView1.Rows[num].Cells[0].Value = true;
                                this.DataGridView1.Rows[num].DefaultCellStyle.BackColor = Color.LimeGreen;
                                this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.White;
                                totalcnt += 1;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(this.dr["Modify"], "1", false))
                            {
                                this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                                totalcnt += 1;
                            }
                            else
                            {
                                totalcnt += 1;
                            }

                            //if (Operators.ConditionalCompareObjectEqual(this.dr["m_id"], this.testnu.Text, false))
                            //{
                            //	if (Operators.CompareString(this.dr["m_checked"].ToString(), "1", false) == 0)
                            //	{
                            //		int num = this.DataGridView1.Rows.Add();
                            //		this.DataGridView1.Rows[num].Cells[1].Value = this.dr["m_eid"].ToString();
                            //		this.DataGridView1.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num].Cells[3].Value = this.dr["m_rate"].ToString();
                            //		this.DataGridView1.Rows[num].Cells[4].Value = this.dr["m_team"].ToString();
                            //		this.DataGridView1.Rows[num].Cells[5].Value = this.dr["m_mode"].ToString();
                            //		this.DataGridView1.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(this.dr["m_time"].ToString()), DateFormat.LongTime);
                            //		this.DataGridView1.Rows[num].Cells[7].Value = this.dr["m_dt"].ToString();
                            //		this.DataGridView1.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team1"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team2"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team3"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team4"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Red;

                            //		value = (double)(num + 1);
                            //	}
                            //	else if (Operators.CompareString(this.dr["M_chk"].ToString(), "1", false) == 0)
                            //	{
                            //		int num2 = this.DataGridView1.Rows.Add();
                            //		this.DataGridView1.Rows[num2].Cells[1].Value = this.dr["m_eid"].ToString();
                            //		this.DataGridView1.Rows[num2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num2].Cells[3].Value = this.dr["m_rate"].ToString();
                            //		this.DataGridView1.Rows[num2].Cells[4].Value = this.dr["m_team"].ToString();
                            //		this.DataGridView1.Rows[num2].Cells[5].Value = this.dr["m_mode"].ToString();
                            //		this.DataGridView1.Rows[num2].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(this.dr["m_time"].ToString()), DateFormat.LongTime);
                            //		this.DataGridView1.Rows[num2].Cells[7].Value = this.dr["m_dt"].ToString();
                            //		this.DataGridView1.Rows[num2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team1"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num2].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team2"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num2].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team3"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num2].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team4"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num2].Cells[0].Value = true;
                            //		this.DataGridView1.Rows[num2].DefaultCellStyle.BackColor = Color.LimeGreen;
                            //		this.DataGridView1.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
                            //		value = (double)(num2 + 1);
                            //	}
                            //	else if (Operators.CompareString(this.dr["Modify"].ToString(), "1", false) == 0)
                            //	{
                            //		int num3 = this.DataGridView1.Rows.Add();
                            //		this.DataGridView1.Rows[num3].Cells[1].Value = this.dr["m_eid"].ToString();
                            //		this.DataGridView1.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num3].Cells[3].Value = this.dr["m_rate"].ToString();
                            //		this.DataGridView1.Rows[num3].Cells[4].Value = this.dr["m_team"].ToString();
                            //		this.DataGridView1.Rows[num3].Cells[5].Value = this.dr["m_mode"].ToString();
                            //		this.DataGridView1.Rows[num3].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(this.dr["m_time"].ToString()), DateFormat.LongTime);
                            //		this.DataGridView1.Rows[num3].Cells[7].Value = this.dr["m_dt"].ToString();
                            //		this.DataGridView1.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team1"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num3].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team2"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num3].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team3"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num3].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team4"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num3].DefaultCellStyle.ForeColor = Color.Blue;
                            //		value = (double)(num3 + 1);
                            //	}
                            //	else
                            //	{
                            //		int num4 = this.DataGridView1.Rows.Add();
                            //		this.DataGridView1.Rows[num4].Cells[1].Value = this.dr["m_eid"].ToString();
                            //		this.DataGridView1.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num4].Cells[3].Value = this.dr["m_rate"].ToString();
                            //		this.DataGridView1.Rows[num4].Cells[4].Value = this.dr["m_team"].ToString();
                            //		this.DataGridView1.Rows[num4].Cells[5].Value = this.dr["m_mode"].ToString();
                            //		this.DataGridView1.Rows[num4].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(this.dr["m_time"].ToString()), DateFormat.LongTime);
                            //		this.DataGridView1.Rows[num4].Cells[7].Value = this.dr["m_dt"].ToString();
                            //		this.DataGridView1.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team1"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num4].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team2"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num4].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team3"].ToString()), this.txtnu.Text);
                            //		this.DataGridView1.Rows[num4].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_team4"].ToString()), this.txtnu.Text);
                            //		value = (double)(num4 + 1);
                            //	}
                            //}
                        }
                        this.Label4.Text = "TOTAL ENTRY : " + Conversions.ToString(totalcnt);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        // Token: 0x06000245 RID: 581 RVA: 0x00285C08 File Offset: 0x00284008
        public void listvieColumname()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });
                this.Strsql = "SELECT Date1, Sr_No, horse1, horse2, horse3, horse4 FROM Newmatch WHERE(Sr_No = " + this.testnu.Text + ")";
                this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
                this.dr = this.cmd.ExecuteReader();
                if (this.dr.Read())
                {
                    this.DataGridView1.Columns[8].HeaderText = this.dr["horse1"].ToString();
                    this.DataGridView1.Columns[9].HeaderText = this.dr["horse2"].ToString();
                    this.DataGridView1.Columns[10].HeaderText = this.dr["horse3"].ToString();
                    this.DataGridView1.Columns[11].HeaderText = this.dr["horse4"].ToString();
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, null, false) == 0)
                    {
                        this.DataGridView1.Columns[10].Visible = false;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, null, false) == 0)
                    {
                        this.DataGridView1.Columns[11].Visible = false;
                    }
                    this.Label5.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.dr["Date1"], " "), this.dr["Sr_No"]), " "), this.dr["horse1"]), " VS "), this.dr["horse2"]));

                    this.DataGridView3.Columns[0].HeaderText = this.dr["horse1"].ToString();
                    this.DataGridView3.Columns[1].HeaderText = this.dr["horse2"].ToString();
                    this.DataGridView3.Columns[2].HeaderText = this.dr["horse3"].ToString();
                    this.DataGridView3.Columns[3].HeaderText = this.dr["horse4"].ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06000246 RID: 582 RVA: 0x00286174 File Offset: 0x00284574
        public void combolod()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.Strsql = "Select * from PartyMaster";
                this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
                this.dr = this.cmd.ExecuteReader();
                while (this.dr.Read())
                {
                    this.txtname1.Items.Add(RuntimeHelpers.GetObjectValue(this.dr["AParty"]));
                    this.txtname1.Items.Add(RuntimeHelpers.GetObjectValue(this.dr["TParty"]));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06000247 RID: 583 RVA: 0x002862C8 File Offset: 0x002846C8
        public void nptotal()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.Strsql = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked <> 1) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch HAVING (MatchTrans.m_id = ",
                    this.testnu.Text.ToString(),
                    ") AND (PartyMaster.AParty = '",
                    this.txtname1.Text,
                    "') OR (PartyMaster.PartyName = '",
                    this.txtname1.Text,
                    "') OR (PartyMaster.TParty = '",
                    this.txtname1.Text,
                    "')"
                });
                this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
                this.dr = this.cmd.ExecuteReader();
                double num9 = 0, num10 = 0, num11 = 0, num12 = 0;
                while (this.dr.Read())
                {
                    if (Operators.CompareString(this.dr["m_id"].ToString(), this.testnu.Text.ToString(), false) == 0)
                    {
                        double num = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                        double num2 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                        double num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                        double num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);

                        double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr1"])) - Conversion.Val(num);
                        double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr2"])) - Conversion.Val(num2);
                        double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr3"])) - Conversion.Val(num3);
                        double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr4"])) - Conversion.Val(num4);

                        if (Operators.CompareString(this.dr["PartyName"].ToString(), this.txtname1.Text, false) == 0)
                        {
                            num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                            num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                            num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                            num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["Expr4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["SMatch"])) / 100);
                        }
                        if (Operators.CompareString(this.dr["AParty"].ToString(), this.txtname1.Text, false) == 0)
                        {
                            num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["AMatch"])) / 100);
                            num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["AMatch"])) / 100);
                            num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["AMatch"])) / 100);
                            num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["AMatch"])) / 100);
                        }
                        if (Operators.CompareString(this.dr["TParty"].ToString(), this.txtname1.Text, false) == 0)
                        {
                            num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["TMatch"])) / 100);
                            num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["TMatch"])) / 100);
                            num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["TMatch"])) / 100);
                            num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.dr["TMatch"])) / 100);
                        }
                    }
                }

                this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[1].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[2].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[3].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                this.DataGridView3.Rows[2].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[0].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[1].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[2].Value)), this.txtnu.Text);
                this.DataGridView3.Rows[2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[3].Value)), this.txtnu.Text);
                this.colore_Click();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.DataGridView3.ClearSelection();
                Module1.conn.Close();
            }
        }

        // Token: 0x06000248 RID: 584 RVA: 0x00286DA4 File Offset: 0x002851A4
        public void colore_Click()
        {
            try
            {
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[3].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[3].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[3].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[3].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[3].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[3].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[3].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[3].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[3].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[3].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[3].Cells[3].Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600024A RID: 586 RVA: 0x00287B68 File Offset: 0x00285F68
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtname1.SelectionStart <= 1)
                        {
                            this.txtname1.Text = "";
                            return;
                        }
                        if (this.txtname1.SelectionLength == 0)
                        {
                            text = this.txtname1.Text.Substring(0, this.txtname1.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtname1.Text.Substring(0, this.txtname1.SelectionStart - 1);
                        }
                    }
                    else if (this.txtname1.SelectionLength == 0)
                    {
                        text = this.txtname1.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtname1.Text.Substring(0, this.txtname1.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtname1.FindString(text);
                    if (num != -1)
                    {
                        this.txtname1.SelectedText = "";
                        this.txtname1.SelectedIndex = num;
                        this.txtname1.SelectionStart = text.Length;
                        this.txtname1.SelectionLength = this.txtname1.Text.Length;
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
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }


        // Token: 0x0600024C RID: 588 RVA: 0x00287CEC File Offset: 0x002860EC
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listlode_Agent_name();
                this.nptotal();
                this.colore_Click();
                //this.DataGridView3.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[0].Value)), this.txtnu.Text);
                //this.DataGridView3.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[1].Value)), this.txtnu.Text);
                //this.DataGridView3.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[2].Value)), this.txtnu.Text);
                //this.DataGridView3.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[3].Value)), this.txtnu.Text);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        //// Token: 0x0600024D RID: 589 RVA: 0x00288030 File Offset: 0x00286430
        //public void nptotal1()
        //{
        //	this.DataGridView4.Rows.Clear();
        //	this.DataGridView4.Rows.Add();
        //	this.DataGridView4.Rows.Add();
        //	this.DataGridView4.Rows.Add();
        //	try
        //	{
        //		if (Module1.conn.State == ConnectionState.Closed)
        //		{
        //			Module1.conn.Open();
        //		}
        //		string cmdText = string.Concat(new string[]
        //		{
        //			"SELECT PartyMaster.PartyName, MatchTrans.m_id, MatchTrans.m_checked, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatchCommi, PartyMaster.SMatch HAVING (PartyMaster.PartyName = '",
        //			this.txtname1.Text,
        //			"') AND (MatchTrans.m_id = ",
        //			this.testnu.Text,
        //			") AND (MatchTrans.m_checked = 0)"
        //		});
        //		OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
        //		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
        //		while (oleDbDataReader.Read())
        //		{
        //			double num = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatchCommi"]));
        //			this.txtparsent.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])));
        //			this.DataGridView4.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]);
        //			this.DataGridView4.Rows[1].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)) * Conversion.Val(this.txtparsent.Text);
        //			this.DataGridView4.Rows[2].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value));
        //			this.DataGridView4.Rows[1].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value));
        //			if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[0].Value, 0, false))
        //			{
        //				double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[0].Value)) * Conversion.Val(num);
        //				this.DataGridView4.Rows[2].Cells[0].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[0].Value, num2);
        //			}
        //			this.DataGridView4.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[2].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[0].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[0].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"]);
        //			this.DataGridView4.Rows[1].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[1].Value)) * Conversion.Val(this.txtparsent.Text);
        //			this.DataGridView4.Rows[2].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value));
        //			this.DataGridView4.Rows[1].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value));
        //			if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[1].Value, 0, false))
        //			{
        //				double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[1].Value)) * Conversion.Val(num);
        //				this.DataGridView4.Rows[2].Cells[1].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[1].Value, num3);
        //			}
        //			this.DataGridView4.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[1].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[1].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[0].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"]);
        //			this.DataGridView4.Rows[1].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[2].Value)) * Conversion.Val(this.txtparsent.Text);
        //			this.DataGridView4.Rows[2].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value));
        //			this.DataGridView4.Rows[1].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value));
        //			if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[2].Value, 0, false))
        //			{
        //				double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[2].Value)) * Conversion.Val(num);
        //				this.DataGridView4.Rows[2].Cells[2].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[2].Value, num4);
        //			}
        //			this.DataGridView4.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[2].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[2].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[0].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"]);
        //			this.DataGridView4.Rows[1].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[3].Value)) * Conversion.Val(this.txtparsent.Text);
        //			this.DataGridView4.Rows[2].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value));
        //			this.DataGridView4.Rows[1].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value));
        //			if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[3].Value, 0, false))
        //			{
        //				double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[3].Value)) * Conversion.Val(num);
        //				this.DataGridView4.Rows[2].Cells[3].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[3].Value, num5);
        //			}
        //			this.DataGridView4.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[3].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value)), this.txtnu.Text);
        //			this.DataGridView4.Rows[2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[3].Value)), this.txtnu.Text);
        //		}
        //	}
        //	catch (Exception ex)
        //	{
        //		MessageBox.Show(ex.Message);
        //	}
        //	finally
        //	{
        //		Module1.conn.Close();
        //	}
        //}

        // Token: 0x0600024F RID: 591 RVA: 0x00289074 File Offset: 0x00287474
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600025C RID: 604 RVA: 0x0028A7E4 File Offset: 0x00288BE4
        private void txtname1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600024B RID: 587 RVA: 0x00287CC4 File Offset: 0x002860C4
        private void txtname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtname1 = this.txtname1;
                this.AutoComplete(ref txtname1, e, false);
                this.txtname1 = txtname1;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600025E RID: 606 RVA: 0x0028A828 File Offset: 0x00288C28
        private void Agent_match_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0400010B RID: 267
        private string Strsql;

        // Token: 0x0400010C RID: 268
        private OleDbCommand cmd;

        // Token: 0x0400010D RID: 269
        private OleDbDataReader dr;


    }
}
