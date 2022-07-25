using System;
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
using App.Service;
using System.Threading.Tasks;

namespace YashAksh
{
    // Token: 0x0200003E RID: 62
    //[DesignerGenerated]
    public partial class DPP_Match : Form
    {
        // Token: 0x06000B48 RID: 2888 RVA: 0x002F9390 File Offset: 0x002F7790
        public DPP_Match()
        {
            //base.Activated += this.DPP_Match_Activated;
            //base.KeyDown += this.DPP_Match_KeyDown;
            //base.Load += this.DPP_Match_Load;
            //base.FormClosing += this.DPP_Match_FormClosing;
            this.InitializeComponent();
        }

        // Token: 0x06000BE9 RID: 3049 RVA: 0x002FD344 File Offset: 0x002FB744
        private void Button6_Click(object sender, EventArgs e)
        {
            //MyProject.Forms.Match.Activate();
            MyProject.Forms.Match.Match_Max_MiniDPS();
            if (Module1.ismatchbookpopupopen == true)
            {
                MyProject.Forms.MatchBOOKPOPUP.Decliar_New();
            }
            this.Close();
        }

        // Token: 0x06000BEA RID: 3050 RVA: 0x002FD364 File Offset: 0x002FB764
        private void DPP_Match_Activated(object sender, EventArgs e)
        {
            this.txtname.Focus();
        }

        // Token: 0x06000BEB RID: 3051 RVA: 0x002FD374 File Offset: 0x002FB774
        private void DPP_Match_KeyDown(object sender, KeyEventArgs e)
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000BED RID: 3053 RVA: 0x002FD460 File Offset: 0x002FB860
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select Remark,Result,Sr_No from Newmatch where Sr_No=" + this.testnu.Text + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Label3.Text = "WINNER TEAM :- " + oleDbDataReader["Remark"].ToString();
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = false;
                }
                else
                {
                    this.Button2.Enabled = true;
                    this.Button3.Enabled = true;
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

        // Token: 0x06000BEE RID: 3054 RVA: 0x002FD558 File Offset: 0x002FB958
        private void DPP_Match_Load(object sender, EventArgs e)
        {
            try
            {
                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(96, 32);
                    txtrate.Location = new Point(8, 32);

                    Label12.Text = "Amount";
                    Label11.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.CheckBox1.Checked = true;
                this.Panel6.Hide();
                this.txtnu.Text = Module1.decimalnumberformat;
                this.testnu.Text = Conversions.ToString(Module1.machid);
                //this.YES_NO();				
                this.listvieColumname();
                this.combolod();
                this.txtname.Text = Conversions.ToString(Module1.name1);
                this.Decleard();
                if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, null, false) == 0)
                {
                    this.DataGridView1.Columns[10].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, null, false) == 0)
                {
                    this.DataGridView1.Columns[11].Visible = false;
                }

                this.btnshow_Click(sender, e);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000BEF RID: 3055 RVA: 0x002FD6F8 File Offset: 0x002FBAF8
        public void listvieColumname()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
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
                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });

                this.Strsql = "SELECT Date1, Sr_No, horse1, horse2, horse3, horse4 FROM Newmatch WHERE(Sr_No = " + this.testnu.Text + ")";
                this.Cmd = new OleDbCommand(this.Strsql, Module1.conn);
                this.dr = this.Cmd.ExecuteReader();
                if (this.dr.Read())
                {
                    this.DataGridView1.Columns[8].HeaderText = this.dr["horse1"].ToString();
                    this.DataGridView1.Columns[9].HeaderText = this.dr["horse2"].ToString();
                    this.DataGridView1.Columns[10].HeaderText = this.dr["horse3"].ToString();
                    this.DataGridView1.Columns[11].HeaderText = this.dr["horse4"].ToString();
                    this.Label5.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.dr["Date1"], " "), this.dr["Sr_No"]), " "), this.dr["horse1"]), " VS "), this.dr["horse2"]));
                    this.cmbteam.Items.Add(this.dr["horse1"].ToString());
                    this.cmbteam.Items.Add(this.dr["horse2"].ToString());
                    if (Operators.CompareString(this.dr["horse3"].ToString(), null, false) != 0)
                    {
                        this.cmbteam.Items.Add(this.dr["horse3"].ToString());
                    }
                    if (Operators.CompareString(this.dr["horse4"].ToString(), null, false) != 0)
                    {
                        this.cmbteam.Items.Add(this.dr["horse4"].ToString());
                    }
                    this.DataGridView2.Columns[0].HeaderText = this.dr["horse1"].ToString();
                    this.DataGridView2.Columns[1].HeaderText = this.dr["horse2"].ToString();
                    this.DataGridView2.Columns[2].HeaderText = this.dr["horse3"].ToString();
                    this.DataGridView2.Columns[3].HeaderText = this.dr["horse4"].ToString();

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

        // Token: 0x06000BF0 RID: 3056 RVA: 0x002FDBF4 File Offset: 0x002FBFF4
        public void combolod()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.txtname.Items.Clear();
                this.txtpartiname.Items.Clear();
                this.Strsql = "SELECT Id, PartyName FROM PartyMaster ";
                this.Cmd = new OleDbCommand(this.Strsql, Module1.conn);
                this.dr = this.Cmd.ExecuteReader();
                while (this.dr.Read())
                {
                    this.txtname.Items.Add(this.dr["PartyName"].ToString());
                    this.txtpartiname.Items.Add(this.dr["PartyName"].ToString());
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

        // Token: 0x06000BF1 RID: 3057 RVA: 0x002FDD0C File Offset: 0x002FC10C
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
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
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000BF2 RID: 3058 RVA: 0x002FDE68 File Offset: 0x002FC268
        private void txtpartiname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtpartiname = this.txtpartiname;
                this.AutoComplete11(ref txtpartiname, e, false);
                this.txtpartiname = txtpartiname;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000BF3 RID: 3059 RVA: 0x002FDE90 File Offset: 0x002FC290
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.All_DPP_SHWO();
                this.DataGridView3.Rows[0].Cells[0].Value = null;
                this.DataGridView3.Rows[0].Cells[1].Value = null;
                this.DataGridView3.Rows[0].Cells[2].Value = null;
                this.DataGridView3.Rows[0].Cells[3].Value = null;
                this.DataGridView3.Rows[1].Cells[0].Value = null;
                this.DataGridView3.Rows[1].Cells[1].Value = null;
                this.DataGridView3.Rows[1].Cells[2].Value = null;
                this.DataGridView3.Rows[1].Cells[3].Value = null;
                this.DataGridView3.Rows[2].Cells[0].Value = null;
                this.DataGridView3.Rows[2].Cells[1].Value = null;
                this.DataGridView3.Rows[2].Cells[2].Value = null;
                this.DataGridView3.Rows[2].Cells[3].Value = null;
                this.nptotal();
                //this.DataGridView2.Rows[0].Cells[0].Value = null;
                //this.DataGridView2.Rows[0].Cells[1].Value = null;
                //this.DataGridView2.Rows[0].Cells[2].Value = null;
                //this.DataGridView2.Rows[0].Cells[3].Value = null;
                this.colore_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.txtname.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000BF4 RID: 3060 RVA: 0x002FE11C File Offset: 0x002FC51C
        public async Task All_DPP_SHWO()
        {
            checked
            {
                try
                {
                    this.DataGridView1.Rows.Clear();
                    if (Operators.CompareString(this.txtname.Text, null, false) != 0)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        int totalcnt = 0;
                        this.Strsql = string.Concat(new string[]
                        {
                            "SELECT id, m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, Modify, m_checked, M_chk, modify_time, modify_date FROM MatchTrans WHERE (m_id = ",
                            this.testnu.Text,
                            ") AND (m_party = '",
                            this.txtname.Text,
                            "') ORDER BY m_eid DESC"
                        });
                        this.Cmd = new OleDbCommand(this.Strsql, Module1.conn);
                        this.dr = this.Cmd.ExecuteReader();
                        while (this.dr.Read())
                        {
                            int num = this.DataGridView1.Rows.Add();
                            this.DataGridView1.Rows[num].Cells[1].Value = this.dr["m_eid"].ToString();

                            if (Module1.isratefirst == true)
                            {
                                this.DataGridView1.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                                this.DataGridView1.Columns[3].HeaderText = "Amount";
                                this.DataGridView1.Rows[num].Cells[2].Value = Strings.Format(Conversion.Val(this.dr["m_rate"].ToString()), "0.0000");  //Convert.ToString(this.dr["m_rate"],"0.0000");
                                this.DataGridView1.Columns[2].HeaderText = "Rate";
                            }
                            else
                            {
                                this.DataGridView1.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.dr["m_amt"].ToString()), this.txtnu.Text);
                                this.DataGridView1.Rows[num].Cells[3].Value = Strings.Format(Conversion.Val(this.dr["m_rate"].ToString()), "0.0000");  //Convert.ToString(this.dr["m_rate"],"0.0000");
                            }


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

                            this.DataGridView1.Rows[num].Cells[15].Value = this.dr["modify_time"].ToString();
                            this.DataGridView1.Rows[num].Cells[16].Value = this.dr["modify_date"].ToString();

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

                        }
                        this.Label4.Text = "TOTAL ENTRY :- " + Conversions.ToString(totalcnt);

                        double num3 = 0;
                        double num4 = 0;
                        double num5 = 0;
                        double num6 = 0;
                        for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false)
                                    && Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells["M_Checked"].Value, "0", false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[11].Value));
                                }
                            }
                        }
                        this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);

                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                    DataGridView2.ClearSelection();
                    Module1.conn.Close();
                }
            }
        }

        // Token: 0x06000BF5 RID: 3061 RVA: 0x002FEF7C File Offset: 0x002FD37C
        public void Colore1()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView2.RowCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[0].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[0].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[1].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[2].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[3].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
        }

        // Token: 0x06000BF6 RID: 3062 RVA: 0x002FF1F4 File Offset: 0x002FD5F4
        public void nptotal()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT * FROM (",
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatchCommi, PartyMaster.SMatch HAVING (PartyMaster.PartyName = '",
                    this.txtname.Text,
                    "') AND (MatchTrans.m_id = ",
                    this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus')) ",
                    " UNION ALL ",
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) WHERE (PartyMaster.PartyName = '",
                    this.txtname.Text,
                    "') AND (MatchTrans.m_id = ",
                    this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('Entry Wise')) ",
                    ") ORDER BY PartyMaster.PartyName"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    // Added By Bhavesh
                    string status = Conversions.ToString(oleDbDataReader["Status"]);
                    double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])));
                    double smatchcommi = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatchCommi"])));

                    double exp1 = Conversion.Val(oleDbDataReader["Expr1"]);
                    double exp2 = Conversion.Val(oleDbDataReader["Expr2"]);
                    double exp3 = Conversion.Val(oleDbDataReader["Expr3"]);
                    double exp4 = Conversion.Val(oleDbDataReader["Expr4"]);

                    double exp1_total = 0, exp1_selfld = 0, exp1_afterldcommi = 0;
                    double exp2_total = 0, exp2_selfld = 0, exp2_afterldcommi = 0;
                    double exp3_total = 0, exp3_selfld = 0, exp3_afterldcommi = 0;
                    double exp4_total = 0, exp4_selfld = 0, exp4_afterldcommi = 0;

                    exp1_total = exp1;
                    exp1_selfld = exp1 * smatch;
                    exp1_selfld = (exp1 * smatch) - (exp1 * smatch) - (exp1 * smatch);
                    exp1_afterldcommi = exp1 - (exp1 * smatch);
                    if (!Operators.ConditionalCompareObjectLess(exp1_afterldcommi, 0, false) && status == "Regular")
                    {
                        double num = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
                        exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num));
                    }
                    if (!Operators.ConditionalCompareObjectGreater(exp1_afterldcommi, 0, false) && status == "Booky")
                    {
                        double num = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
                        exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num));
                    }
                    this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)), Conversion.Val(exp1_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[0].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value)), Conversion.Val(exp1_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[0].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[0].Value)), Conversion.Val(exp1_afterldcommi)), this.txtnu.Text);

                    exp2_total = exp2;
                    exp2_selfld = exp2 * smatch;
                    exp2_selfld = (exp2 * smatch) - (exp2 * smatch) - (exp2 * smatch);
                    exp2_afterldcommi = exp2 - (exp2 * smatch);
                    if (!Operators.ConditionalCompareObjectLess(exp2_afterldcommi, 0, false) && status == "Regular")
                    {
                        double num = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
                        exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num));
                    }
                    if (!Operators.ConditionalCompareObjectGreater(exp2_afterldcommi, 0, false) && status == "Booky")
                    {
                        double num = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
                        exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num));
                    }
                    this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[1].Value)), Conversion.Val(exp2_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[1].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value)), Conversion.Val(exp2_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[1].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[1].Value)), Conversion.Val(exp2_afterldcommi)), this.txtnu.Text);

                    exp3_total = exp3;
                    exp3_selfld = exp3 * smatch;
                    exp3_selfld = (exp3 * smatch) - (exp3 * smatch) - (exp3 * smatch);
                    exp3_afterldcommi = exp3 - (exp3 * smatch);
                    if (!Operators.ConditionalCompareObjectLess(exp3_afterldcommi, 0, false) && status == "Regular")
                    {
                        double num = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
                        exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num));
                    }
                    if (!Operators.ConditionalCompareObjectGreater(exp3_afterldcommi, 0, false) && status == "Booky")
                    {
                        double num = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
                        exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num));
                    }
                    this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[2].Value)), Conversion.Val(exp3_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[2].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value)), Conversion.Val(exp3_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[2].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[2].Value)), Conversion.Val(exp3_afterldcommi)), this.txtnu.Text);

                    exp4_total = exp4;
                    exp4_selfld = exp4 * smatch;
                    exp4_selfld = (exp4 * smatch) - (exp4 * smatch) - (exp4 * smatch);
                    exp4_afterldcommi = exp4 - (exp4 * smatch);
                    if (!Operators.ConditionalCompareObjectLess(exp4_afterldcommi, 0, false) && status == "Regular")
                    {
                        double num = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
                        exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num));
                    }
                    if (!Operators.ConditionalCompareObjectGreater(exp4_afterldcommi, 0, false) && status == "Booky")
                    {
                        double num = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
                        exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num));
                    }
                    this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[3].Value)), Conversion.Val(exp4_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[3].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value)), Conversion.Val(exp4_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[3].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[3].Value)), Conversion.Val(exp4_afterldcommi)), this.txtnu.Text);

                    //this.DataGridView3.Rows[0].Cells[0].Value = exp1;
                    //this.DataGridView3.Rows[1].Cells[0].Value = exp1 * smatch;
                    //this.DataGridView3.Rows[1].Cells[0].Value = (exp1 * smatch) - (exp1 * smatch) - (exp1 * smatch);
                    //this.DataGridView3.Rows[2].Cells[0].Value = exp1 - (exp1 * smatch);

                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[0].Value, 0, false) && status == "Regular")
                    //{
                    //	double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[0].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[0].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[0].Value, num2);
                    //}
                    //if (!Operators.ConditionalCompareObjectGreater(this.DataGridView3.Rows[2].Cells[0].Value, 0, false) && status == "Booky")
                    //{
                    //	double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[0].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[0].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[0].Value, num2);
                    //}
                    //this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[2].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[0].Value)), this.txtnu.Text);

                    //this.DataGridView3.Rows[0].Cells[1].Value = exp2;
                    //this.DataGridView3.Rows[1].Cells[1].Value = exp2 * smatch;
                    //this.DataGridView3.Rows[1].Cells[1].Value = (exp2 * smatch) - (exp2 * smatch) - (exp2 * smatch);
                    //this.DataGridView3.Rows[2].Cells[1].Value = exp2 - (exp2 * smatch);					
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[1].Value, 0, false) && status == "Regular")
                    //{
                    //	double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[1].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[1].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[1].Value, num3);
                    //}
                    //if (!Operators.ConditionalCompareObjectGreater(this.DataGridView3.Rows[2].Cells[1].Value, 0, false) && status == "Booky")
                    //{
                    //	double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[1].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[1].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[1].Value, num3);
                    //}
                    //this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[1].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[1].Value)), this.txtnu.Text);

                    //this.DataGridView3.Rows[0].Cells[2].Value = exp3;
                    //this.DataGridView3.Rows[1].Cells[2].Value = exp3 * smatch;
                    //this.DataGridView3.Rows[1].Cells[2].Value = (exp3 * smatch) - (exp3 * smatch) - (exp3 * smatch);
                    //this.DataGridView3.Rows[2].Cells[2].Value = exp3 - (exp3 * smatch);                    
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[2].Value, 0, false) && status == "Regular")
                    //{
                    //	double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[2].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[2].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[2].Value, num4);
                    //}
                    //if (!Operators.ConditionalCompareObjectGreater(this.DataGridView3.Rows[2].Cells[2].Value, 0, false) && status == "Booky")
                    //{
                    //	double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[2].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[2].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[2].Value, num4);
                    //}
                    //this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[2].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[2].Value)), this.txtnu.Text);

                    //this.DataGridView3.Rows[0].Cells[3].Value = exp4;
                    //this.DataGridView3.Rows[1].Cells[3].Value = exp4 * smatch;
                    //this.DataGridView3.Rows[1].Cells[3].Value = (exp4 * smatch) - (exp4 * smatch) - (exp4 * smatch);
                    //this.DataGridView3.Rows[2].Cells[3].Value = exp4 - (exp4 * smatch);                    
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[2].Cells[3].Value, 0, false) && status == "Regular")
                    //{
                    //	double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[3].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[3].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[3].Value, num5);
                    //}
                    //if (!Operators.ConditionalCompareObjectGreater(this.DataGridView3.Rows[2].Cells[3].Value, 0, false) && status == "Booky")
                    //{
                    //	double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[3].Value)) * Conversion.Val(smatchcommi);
                    //	this.DataGridView3.Rows[2].Cells[3].Value = Operators.SubtractObject(this.DataGridView3.Rows[2].Cells[3].Value, num5);
                    //}
                    //this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[3].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value)), this.txtnu.Text);
                    //this.DataGridView3.Rows[2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[3].Value)), this.txtnu.Text);
                }

                string cmdText1 = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch, MatchTrans.m_rate, MatchTrans.m_amt, PartyMaster.Rate FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) WHERE (PartyMaster.PartyName = '",
                    this.txtname.Text,
                    "') AND (MatchTrans.m_id = ",
                    this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType = 'Per Peti') "
                });
                OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
                OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                while (oleDbDataReader1.Read())
                {
                    string status = Conversions.ToString(oleDbDataReader1["Status"]);
                    double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["SMatch"])));
                    double smatchcommi = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["SMatchCommi"]));
                    double m_rate = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["m_rate"]));
                    double p_rate = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["Rate"]));
                    double m_amt = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["m_amt"]));
                    double totalamt_afterselfld = m_amt - (m_amt * smatch);
                    //double afterldcommiamt = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["m_amt"])) - (Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader1["m_amt"])) * smatch);

                    double exp1 = Conversion.Val(oleDbDataReader1["Expr1"]);
                    double exp2 = Conversion.Val(oleDbDataReader1["Expr2"]);
                    double exp3 = Conversion.Val(oleDbDataReader1["Expr3"]);
                    double exp4 = Conversion.Val(oleDbDataReader1["Expr4"]);

                    double exp1_total = 0, exp1_selfld = 0, exp1_afterldcommi = 0;
                    double exp2_total = 0, exp2_selfld = 0, exp2_afterldcommi = 0;
                    double exp3_total = 0, exp3_selfld = 0, exp3_afterldcommi = 0;
                    double exp4_total = 0, exp4_selfld = 0, exp4_afterldcommi = 0;

                    exp1_total = exp1;
                    exp1_selfld = exp1 * smatch;
                    exp1_selfld = (exp1 * smatch) - (exp1 * smatch) - (exp1 * smatch);
                    exp1_afterldcommi = exp1 - (exp1 * smatch);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp1 != 0)
                    {
                        double num = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(smatchcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp1_afterldcommi = Conversion.Val(Operators.AddObject(exp1_afterldcommi, num));
                        }
                    }
                    this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)), Conversion.Val(exp1_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[0].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value)), Conversion.Val(exp1_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[0].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[0].Value)), Conversion.Val(exp1_afterldcommi)), this.txtnu.Text);

                    exp2_total = exp2;
                    exp2_selfld = exp2 * smatch;
                    exp2_selfld = (exp2 * smatch) - (exp2 * smatch) - (exp2 * smatch);
                    exp2_afterldcommi = exp2 - (exp2 * smatch);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp2 != 0)
                    {
                        double num = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(smatchcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp2_afterldcommi = Conversion.Val(Operators.AddObject(exp2_afterldcommi, num));
                        }
                    }
                    this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[1].Value)), Conversion.Val(exp2_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[1].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value)), Conversion.Val(exp2_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[1].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[1].Value)), Conversion.Val(exp2_afterldcommi)), this.txtnu.Text);

                    exp3_total = exp3;
                    exp3_selfld = exp3 * smatch;
                    exp3_selfld = (exp3 * smatch) - (exp3 * smatch) - (exp3 * smatch);
                    exp3_afterldcommi = exp3 - (exp3 * smatch);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp3 != 0)
                    {
                        double num = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(smatchcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp3_afterldcommi = Conversion.Val(Operators.AddObject(exp3_afterldcommi, num));
                        }
                    }
                    this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[2].Value)), Conversion.Val(exp3_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[2].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value)), Conversion.Val(exp3_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[2].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[2].Value)), Conversion.Val(exp3_afterldcommi)), this.txtnu.Text);

                    exp4_total = exp4;
                    exp4_selfld = exp4 * smatch;
                    exp4_selfld = (exp4 * smatch) - (exp4 * smatch) - (exp4 * smatch);
                    exp4_afterldcommi = exp4 - (exp4 * smatch);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp4 != 0)
                    {
                        double num = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(smatchcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp4_afterldcommi = Conversion.Val(Operators.AddObject(exp4_afterldcommi, num));
                        }
                    }
                    this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[3].Value)), Conversion.Val(exp4_total)), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[3].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value)), Conversion.Val(exp4_selfld)), this.txtnu.Text);
                    this.DataGridView3.Rows[2].Cells[3].Value = Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[2].Cells[3].Value)), Conversion.Val(exp4_afterldcommi)), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataGridView3.ClearSelection();
                Module1.conn.Close();
            }
        }

        // Token: 0x06000BF7 RID: 3063 RVA: 0x003001A0 File Offset: 0x002FE5A0
        private void colore_Click(object sender, EventArgs e)
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
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[1].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[1].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[1].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[1].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[3].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[2].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[2].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[2].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView3.Rows[2].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[2].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[2].Cells[3].Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000BF8 RID: 3064 RVA: 0x003008B4 File Offset: 0x002FECB4
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = string.Concat(new string[]
                {
                    "select n.Team1,n.Name,n.Type,n.Date1,n.Sr_No,m.m_eid,m.m_amt,m.m_rate,m.m_team,m.m_mode,m.m_party from Newmatch n,MatchTrans m where n.Sr_No=",
                    this.testnu.Text,
                    " and m.m_id=",
                    this.testnu.Text,
                    " and m.m_party='",
                    this.txtname.Text,
                    "' and m_checked=0"
                });
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);

                //Add RPT
                //MatchDPP matchDPP = new MatchDPP();
                //matchDPP.SetDataSource(dataTable);
                //matchDPP.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\MatchDPP.rpt");
                reportDocument.SetDataSource(dataTable);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000BF9 RID: 3065 RVA: 0x003009A0 File Offset: 0x002FEDA0
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmodify.Text, null, false) != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "Select * from MatchTrans where m_id=",
                        this.testnu.Text,
                        " and m_eid=",
                        this.txtmodify.Text,
                        " and m_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Connot edit this Record", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = string.Concat(new string[]
                        {
                            "Select * from MatchTrans where m_id=",
                            this.testnu.Text,
                            " and m_eid=",
                            this.txtmodify.Text,
                            " "
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        if (oleDbDataReader2.Read())
                        {
                            this.Panel6.Show();
                            this.id.Text = Conversions.ToString(oleDbDataReader2[0]);
                            this.testnu.Text = Conversions.ToString(oleDbDataReader2[1]);
                            this.txtsrno.Text = Conversions.ToString(oleDbDataReader2[2]);
                            this.txtpage.Text = Conversions.ToString(oleDbDataReader2[3]);
                            this.txtamount.Text = Conversions.ToString(oleDbDataReader2[4]);
                            this.txtrate.Text = Conversions.ToString(oleDbDataReader2[5]);
                            this.cmbteam.Text = Conversions.ToString(oleDbDataReader2[6]);
                            this.ComboBox2.Text = Conversions.ToString(oleDbDataReader2[7]);
                            this.txtpartiname.Text = Conversions.ToString(oleDbDataReader2[8]);
                            this.cmbostus.Text = Conversions.ToString(oleDbDataReader2[9]);
                            this.txtdate.Text = Conversions.ToString(oleDbDataReader2[10]);
                            this.txttime.Text = Conversions.ToString(oleDbDataReader2[11]);
                            this.txtpak.Text = Conversions.ToString(oleDbDataReader2[12]);
                            this.txtend.Text = Conversions.ToString(oleDbDataReader2[13]);
                            this.txtsut.Text = Conversions.ToString(oleDbDataReader2[14]);
                            this.txtind.Text = Conversions.ToString(oleDbDataReader2[15]);
                            this.txtmpar.Text = Conversions.ToString(oleDbDataReader2[17]);
                            this.txtpartiname.Text = Conversions.ToString(oleDbDataReader2[8]);
                            if (Module1.isratefirst == true)
                            {
                                this.txtrate.Focus();
                            }
                            else
                            {
                                this.txtamount.Focus();
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

        // Token: 0x06000BFA RID: 3066 RVA: 0x00300CF0 File Offset: 0x002FF0F0
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.mod_K_L();
                this.Savedata_all();
                this.Panel6.Hide();
                this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.txtmodify.Text = null;
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

        // Token: 0x06000BFB RID: 3067 RVA: 0x00300D84 File Offset: 0x002FF184
        public void Savedata_all()
        {
            try
            {
                string cmdText = $"UPDATE MatchTrans SET m_page = '{this.txtpage.Text}', m_amt = {this.txtamount.Text}, m_rate = '{this.txtrate.Text}', m_team = '{this.cmbteam.Text}', m_mode = '{this.ComboBox2.Text}', m_party = '{this.txtpartiname.Text}', Status = 'N', modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', m_team1 = {this.txtpak.Text}, m_team2 = {this.txtend.Text}, m_team3 = {this.txtsut.Text}, m_team4 = {this.txtind.Text}, Modify = '1', m_checked = 0, M_P = '0', M_chk = 0 WHERE MatchTrans.m_id = {this.testnu.Text} AND MatchTrans.m_eid = {this.txtmodify.Text}";
                using (MatchService matchService = new MatchService())
                {
                    matchService.Update(cmdText);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
            }
        }

        // Token: 0x06000BFC RID: 3068 RVA: 0x00300F78 File Offset: 0x002FF378
        public void mod_K_L()
        {
            try
            {
                if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(-Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtend.Text = this.txtamount.Text;
                        this.txtind.Text = this.txtamount.Text;
                        this.txtsut.Text = this.txtamount.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(-Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtpak.Text = this.txtamount.Text;
                        this.txtind.Text = this.txtamount.Text;
                        this.txtsut.Text = this.txtamount.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtsut.Text = Conversions.ToString(-Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtind.Text = this.txtamount.Text;
                        this.txtend.Text = this.txtamount.Text;
                        this.txtpak.Text = this.txtamount.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtind.Text = Conversions.ToString(-Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtsut.Text = this.txtamount.Text;
                        this.txtend.Text = this.txtamount.Text;
                        this.txtpak.Text = this.txtamount.Text;
                    }
                }
                if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, null, false) == 0)
                {
                    this.txtsut.Text = "0.00";
                }
                if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, null, false) == 0)
                {
                    this.txtind.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000BFD RID: 3069 RVA: 0x00301840 File Offset: 0x002FFC40
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.mod_K_L();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000BFE RID: 3070 RVA: 0x00301848 File Offset: 0x002FFC48
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel6.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000BFF RID: 3071 RVA: 0x00301864 File Offset: 0x002FFC64
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Operators.CompareString(this.txtmodify.Text, null, false) != 0)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = string.Concat(new string[]
                        {
                        "Select * from MatchTrans where m_id=",
                        this.testnu.Text,
                        " and m_eid=",
                        this.txtmodify.Text,
                        " and m_checked=1"
                        });
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            Interaction.MsgBox("Connot Delete This Record..?", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            Module1.conn.Close();
                            string cmdText2 = $"Update MatchTrans Set m_checked=1,m_chk=0, modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{ Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) }' where m_id={ this.testnu.Text } and m_eid={ this.txtmodify.Text}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(cmdText2);
                            }
                            this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                        }
                    }
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

        // Token: 0x06000C00 RID: 3072 RVA: 0x003019BC File Offset: 0x002FFDBC
        public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtpartiname.SelectionStart <= 1)
                        {
                            this.txtpartiname.Text = "";
                            return;
                        }
                        if (this.txtpartiname.SelectionLength == 0)
                        {
                            text = this.txtpartiname.Text.Substring(0, this.txtpartiname.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtpartiname.Text.Substring(0, this.txtpartiname.SelectionStart - 1);
                        }
                    }
                    else if (this.txtpartiname.SelectionLength == 0)
                    {
                        text = this.txtpartiname.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtpartiname.Text.Substring(0, this.txtpartiname.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtpartiname.FindString(text);
                    if (num != -1)
                    {
                        this.txtpartiname.SelectedText = "";
                        this.txtpartiname.SelectedIndex = num;
                        this.txtpartiname.SelectionStart = text.Length;
                        this.txtpartiname.SelectionLength = this.txtpartiname.Text.Length;
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000C01 RID: 3073 RVA: 0x00301B18 File Offset: 0x002FFF18
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtname = this.txtname;
                this.AutoComplete(ref txtname, e, false);
                this.txtname = txtname;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000C02 RID: 3074 RVA: 0x00301B40 File Offset: 0x002FFF40
        private void txtpage_KeyDown(object sender, KeyEventArgs e)
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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000C03 RID: 3075 RVA: 0x00301B58 File Offset: 0x002FFF58
        private void txtname_KeyDown(object sender, KeyEventArgs e)
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

        // Token: 0x06000C04 RID: 3076 RVA: 0x00301BD0 File Offset: 0x002FFFD0
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000C05 RID: 3077 RVA: 0x00301C5C File Offset: 0x0030005C
        private void Button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    double num3 = 0;
                    double num4 = 0;
                    double num5 = 0;
                    double num6 = 0;
                    for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
                    {
                        unchecked
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells["M_Checked"].Value, "0", false))
                            {
                                num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[8].Value));
                                num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[9].Value));
                                num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[10].Value));
                                num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[11].Value));
                                this.Strsql = $"UPDATE MatchTrans SET M_chk = 1 WHERE m_checked=0 AND m_id = { this.testnu.Text } AND m_eid = { this.DataGridView1.Rows[i].Cells[1].Value}";
                                using (MatchService matchService = new MatchService())
                                {
                                    matchService.Update(Strsql);
                                }
                                this.DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                                this.DataGridView1.Rows[i].Cells[0].Value = true;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[0].Value = false;
                            }
                        }
                    }
                    this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
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
        }

        // Token: 0x06000C06 RID: 3078 RVA: 0x00301FC8 File Offset: 0x003003C8
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = true;
                        }
                        //int num = 0;
                        //int num2 = this.DataGridView1.Rows.Count - 1;
                        double num3 = 0;
                        double num4 = 0;
                        double num5 = 0;
                        double num6 = 0;
                        for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false)
                                    && Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells["M_Checked"].Value, "0", false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[11].Value));
                                }
                            }
                        }
                        this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false)
                            && Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells["M_Checked"].Value, "0", false))
                        {
                            this.Strsql = $"UPDATE MatchTrans SET M_chk = 1 WHERE m_checked=0 AND m_id = { this.testnu.Text } AND m_eid = { this.DataGridView1.CurrentRow.Cells[1].Value}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(Strsql);
                            }
                            this.DataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, false, false)
                            && Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells["M_Checked"].Value, "0", false))
                        {
                            this.Strsql = $"UPDATE MatchTrans SET M_chk = 0 WHERE m_checked=0 AND m_id = { this.testnu.Text } AND m_eid = { this.DataGridView1.CurrentRow.Cells[1].Value}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(Strsql);
                            }
                            this.DataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            Interaction.MsgBox("Cannot chk the delete record", MsgBoxStyle.OkOnly, null);
                            this.DataGridView1.CurrentRow.Cells[0].Value = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                    DataGridView2.ClearSelection();
                }
            }
        }

        // Token: 0x06000C07 RID: 3079 RVA: 0x0030247C File Offset: 0x0030087C
        private void txtpartiname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.Button7.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000C08 RID: 3080 RVA: 0x003024D0 File Offset: 0x003008D0
        private void txtrate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtrate.Text != "")
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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000C0A RID: 3082 RVA: 0x00302564 File Offset: 0x00300964
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = true;
                        }
                        int num = 0;
                        int num2 = this.DataGridView1.Rows.Count - 1;
                        double num3 = 0;
                        double num4 = 0;
                        double num5 = 0;
                        double num6 = 0;
                        for (int i = num; i <= num2; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false)
                                    && Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells["M_Checked"].Value, "0", false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[11].Value));
                                }
                            }
                        }
                        this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false)
                            && Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells["M_Checked"].Value, "0", false))
                        {
                            this.Strsql = $"UPDATE MatchTrans SET M_chk = 1 WHERE m_checked=0 AND m_id = { this.testnu.Text } AND m_eid = {this.DataGridView1.CurrentRow.Cells[1].Value}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(Strsql);
                            }
                            this.DataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, false, false)
                            && Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells["M_Checked"].Value, "0", false))
                        {
                            this.Strsql = $"UPDATE MatchTrans SET M_chk = 0 WHERE m_checked=0 AND m_id = { this.testnu.Text }AND m_eid = { this.DataGridView1.CurrentRow.Cells[1].Value}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(Strsql);
                            }
                            this.DataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            Interaction.MsgBox("Cannot chk the delete record", MsgBoxStyle.OkOnly, null);
                            this.DataGridView1.CurrentRow.Cells[0].Value = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x040004CA RID: 1226
        private string Strsql;

        // Token: 0x040004CB RID: 1227
        private OleDbCommand Cmd;

        // Token: 0x040004CC RID: 1228
        private OleDbDataReader dr;

        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                        if (Module1.isamountfirst == true)
                        {
                            this.txtrate.SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                        if (Module1.isratefirst == true)
                        {
                            this.txtamount.SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void cmbteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
                if (e.KeyCode == Keys.NumPad1)
                {
                    this.ComboBox2.SelectedItem = "K";
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    this.ComboBox2.SelectedItem = "L";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtamount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtamount.Text != "")
                {
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), Module1.decimalnumberformat);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
    }
}
