using System;
using System.Collections;
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
using App.Service;

namespace YashAksh
{
    public partial class Agent_abntie : Form
    {
        public Agent_abntie()
        {
            //base.Activated += this.Agent_abntie_Activated;
            //base.Load += this.Agent_match_Load;
            this.InitializeComponent();
        }

        // Token: 0x06000168 RID: 360 RVA: 0x0027C22C File Offset: 0x0027A62C
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtmatchID.Text + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
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
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06000169 RID: 361 RVA: 0x0027C2F0 File Offset: 0x0027A6F0
        private void Agent_abntie_Activated(object sender, EventArgs e)
        {
            try
            {
                this.txtname.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600016A RID: 362 RVA: 0x0027C300 File Offset: 0x0027A700
        private void Agent_match_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows.Add();
                this.DataGridView3.Rows.Add();
                this.DataGridView3.Rows.Add();
                this.CheckBox1.Checked = true;
                this.txtnu.Text = Module1.decimalnumberformat;
                this.testnu.Text = Conversions.ToString(Module1.machid);
                this.txtmatchID.Text = Conversions.ToString(Module1.machid);
                //this.YES_NO();

                this.Panel5.Hide();
                this.combolod();
                this.txtname.Text = Conversions.ToString(Module1.name1);
                this.txtname_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                this.txtnu.Hide();
                this.txtagent.Hide();
                this.CheckBox2.Hide();
                this.total.Hide();
                this.colore.Hide();
                this.testnu.Hide();
                this.txtparsent.Hide();
                this.pmatch.Hide();
                this.amatch.Hide();
                this.smatch.Hide();
                this.colore_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Decleard();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600016C RID: 364 RVA: 0x0027C554 File Offset: 0x0027A954
        public void listlode_Agent()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.TParty, Abdntie.ID, Abdntie.Match_ID, Abdntie.Page_No, Abdntie.Amount, Abdntie.Rate, Abdntie.Team, Abdntie.Mode, Abdntie.Party_Name AS Expr1, Abdntie.[Date], Abdntie.[Time], Abdntie.ABDN, Abdntie.Non_ABDN, Abdntie.Tie, Abdntie.Non_Tie, Abdntie.Date1, Abdntie.DARA, Abdntie.Delete_CHK, Abdntie.A_P, Abdntie.A_Modify, Abdntie.M_chk, PartyMaster.SAbandon,PartyMaster.STie, PartyMaster.AParty, PartyMaster.AAbandon, PartyMaster.TAbandon, PartyMaster.TTie, PartyMaster.ATie FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) WHERE (PartyMaster.AParty = '",
                    this.txtname.Text,
                    "') AND (Abdntie.Match_ID = ",
                    this.testnu.Text,
                    ") OR (PartyMaster.PartyName = '",
                    this.txtname.Text,
                    "') OR (PartyMaster.TParty = '",
                    this.txtname.Text,
                    "') ORDER BY Abdntie.ID DESC"
                });
                this.a = 0.0;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num5 = 0;
                double num6 = 0;
                double num7 = 0;
                double num8 = 0;
                while (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Match_ID"], this.testnu.Text, false))
                    {
                        checked
                        {
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Delete_CHK"], "1", false))
                            {
                                int num = this.DataGridView5.Rows.Add();
                                this.DataGridView5.Rows[num].Cells[1].Value = oleDbDataReader["ID"].ToString();
                                this.DataGridView5.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num].Cells[4].Value = oleDbDataReader["Team"].ToString();
                                this.DataGridView5.Rows[num].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                                this.DataGridView5.Rows[num].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num].Cells[10].Value = oleDbDataReader["Time"].ToString();
                                this.DataGridView5.Rows[num].Cells[11].Value = oleDbDataReader["Date"].ToString();
                                this.DataGridView5.Rows[num].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                                this.DataGridView5.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                                this.a = (double)(num + 1);
                            }
                            else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                            {
                                int num2 = this.DataGridView5.Rows.Add();
                                this.DataGridView5.Rows[num2].Cells[1].Value = oleDbDataReader["ID"].ToString();
                                this.DataGridView5.Rows[num2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num2].Cells[4].Value = oleDbDataReader["Team"].ToString();
                                this.DataGridView5.Rows[num2].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                                this.DataGridView5.Rows[num2].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num2].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num2].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num2].Cells[10].Value = oleDbDataReader["Time"].ToString();
                                this.DataGridView5.Rows[num2].Cells[11].Value = oleDbDataReader["Date"].ToString();
                                this.DataGridView5.Rows[num2].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                                this.DataGridView5.Rows[num2].DefaultCellStyle.BackColor = Color.LimeGreen;
                                this.DataGridView5.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
                                this.DataGridView5.Rows[num2].Cells[0].Value = true;
                                this.a = (double)(num2 + 1);
                            }
                            else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["A_Modify"], "1", false))
                            {
                                int num3 = this.DataGridView5.Rows.Add();
                                this.DataGridView5.Rows[num3].Cells[1].Value = oleDbDataReader["ID"].ToString();
                                this.DataGridView5.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num3].Cells[4].Value = oleDbDataReader["Team"].ToString();
                                this.DataGridView5.Rows[num3].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                                this.DataGridView5.Rows[num3].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num3].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num3].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num3].Cells[10].Value = oleDbDataReader["Time"].ToString();
                                this.DataGridView5.Rows[num3].Cells[11].Value = oleDbDataReader["Date"].ToString();
                                this.DataGridView5.Rows[num3].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                                this.DataGridView5.Rows[num3].DefaultCellStyle.ForeColor = Color.Blue;
                                this.a = (double)(num3 + 1);
                            }
                            else
                            {
                                int num4 = this.DataGridView5.Rows.Add();
                                this.DataGridView5.Rows[num4].Cells[1].Value = oleDbDataReader["ID"].ToString();
                                this.DataGridView5.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num4].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num4].Cells[4].Value = oleDbDataReader["Team"].ToString();
                                this.DataGridView5.Rows[num4].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                                this.DataGridView5.Rows[num4].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num4].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num4].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                                this.DataGridView5.Rows[num4].Cells[10].Value = oleDbDataReader["Time"].ToString();
                                this.DataGridView5.Rows[num4].Cells[11].Value = oleDbDataReader["Date"].ToString();
                                this.DataGridView5.Rows[num4].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                                this.a = (double)(num4 + 1);
                            }
                        }
                        if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["Delete_CHK"], "1", false))
                        {
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["PartyName"], this.txtname.Text, false))
                            {
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ABDN"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Abandon"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Non_ABDN"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Abandon"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Tie"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Tie"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Non_Tie"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["S_Tie"])) / 100);
                            }
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["TParty"], this.txtname.Text, false))
                            {
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ABDN"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["P_abandon"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Non_ABDN"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["P_abandon"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Tie"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["P_tie"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Non_Tie"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["P_tie"])) / 100);
                            }
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["AParty"], this.txtname.Text, false))
                            {
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ABDN"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["A_Abandon"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Non_ABDN"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["A_Abandon"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Tie"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["A_Tie"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Non_Tie"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["A_Tie"])) / 100);
                            }
                        }
                    }
                }
                num5 = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                num6 = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
                num7 = Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7);
                num8 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
                this.DataGridView3.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                this.DataGridView3.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                num5 = 0.0;
                num6 = 0.0;
                num7 = 0.0;
                num8 = 0.0;
                this.Label4.Text = "TOTAL ENTRY : " + Conversions.ToString(this.a);
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

        // Token: 0x0600016D RID: 365 RVA: 0x0027D9AC File Offset: 0x0027BDAC
        public void combolod()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]));
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[18]));
                    this.txtagent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                    this.smatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[15]));
                    this.ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[16]));
                    this.amatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]));
                    this.pmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[19]));
                    this.txtregular.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]));
                    this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                    this.c1a.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[9]));
                    this.c2a.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[15]));
                    this.c3A.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[21]));
                    this.c1t.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[10]));
                    this.c2t.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[16]));
                    this.c3t.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[22]));
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

        // Token: 0x0600016E RID: 366 RVA: 0x0027DC18 File Offset: 0x0027C018
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

        // Token: 0x0600016F RID: 367 RVA: 0x0027DE90 File Offset: 0x0027C290
        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = checked((int)Math.Round(Conversion.Val(this.smatch.Text)));
            double value = Conversion.Val(0.01) * Conversion.Val(num);
            this.txtparsent.Text = Conversions.ToString(value);
            this.tieparsent = Conversion.Val(0.01) * Conversion.Val(this.ComboBox1.Text);
        }

        // Token: 0x06000170 RID: 368 RVA: 0x0027DF10 File Offset: 0x0027C310
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
            }
        }

        // Token: 0x06000171 RID: 369 RVA: 0x0027E06C File Offset: 0x0027C46C
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtname = this.txtname;
                this.AutoComplete(ref txtname, e, false);
                this.txtname = txtname;
                this.all_Agent();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000172 RID: 370 RVA: 0x0027E098 File Offset: 0x0027C498
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listlode_Agent();
                this.colore_Click(RuntimeHelpers.GetObjectValue(sender), e);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000173 RID: 371 RVA: 0x0027E0E8 File Offset: 0x0027C4E8
        private void colore_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                checked
                {
                    do
                    {
                        this.DataGridView3.Rows[0].Cells[num].Value = "0" + this.txtnu.Text;
                        this.DataGridView2.Rows[1].Cells[num].Value = "0" + this.txtnu.Text;
                        this.DataGridView3.Rows[0].Cells[num].Style.ForeColor = Color.Green;
                        this.DataGridView2.Rows[0].Cells[num].Style.ForeColor = Color.Green;
                        this.DataGridView2.Rows[1].Cells[num].Style.ForeColor = Color.Green;
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[num].Value, 0, false))
                        {
                            this.DataGridView3.Rows[1].Cells[num].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView3.Rows[1].Cells[num].Style.ForeColor = Color.Green;
                        }
                        num++;
                    }
                    while (num <= 3);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000174 RID: 372 RVA: 0x0027E278 File Offset: 0x0027C678
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                //MyProject.Forms.fromAbn.MdiParent = this.MdiParent;
                //MyProject.Forms.fromAbn.WindowState = FormWindowState.Maximized;
                //MyProject.Forms.fromAbn.Show();

                fromAbn fromAbn = new fromAbn();
                fromAbn.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000175 RID: 373 RVA: 0x0027E2D4 File Offset: 0x0027C6D4
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
                        "Select * from Abdntie where Match_ID=",
                        this.txtmatchID.Text,
                        " and ID=",
                        this.txtmodify.Text,
                        " and Delete_CHK='1'"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("con not edit this record", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = "Select * from Abdntie where Match_ID=" + this.txtmatchID.Text + " and ID=" + this.txtmodify.Text;
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        while (oleDbDataReader2.Read())
                        {
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader2[16], "1", false))
                            {
                                Interaction.MsgBox("can not edit this record", MsgBoxStyle.OkOnly, null);
                            }
                            else
                            {
                                this.Panel5.Show();
                                this.txtid.Text = Conversions.ToString(oleDbDataReader2[0]);
                                this.txtamount.Text = Conversions.ToString(oleDbDataReader2[3]);
                                this.txtrate.Text = Conversions.ToString(oleDbDataReader2[4]);
                                this.txtteam.Text = Conversions.ToString(oleDbDataReader2[5]);
                                this.txtmode.Text = Conversions.ToString(oleDbDataReader2[6]);
                                this.txtparty.Text = Conversions.ToString(oleDbDataReader2[7]);
                                this.txtABDN.Text = Conversions.ToString(oleDbDataReader2[10]);
                                this.txtNonABDN.Text = Conversions.ToString(oleDbDataReader2[11]);
                                this.txtTie.Text = Conversions.ToString(oleDbDataReader2[12]);
                                this.txtNontie.Text = Conversions.ToString(oleDbDataReader2[13]);
                                this.txtime.Text = Conversions.ToString(oleDbDataReader2["Time"]);
                                this.txtpage.Text = Conversions.ToString(oleDbDataReader2[2]);
                                this.txtparty.Text = Conversions.ToString(oleDbDataReader2[7]);
                                this.txtparty_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                            }
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

        // Token: 0x06000176 RID: 374 RVA: 0x0027E5B4 File Offset: 0x0027C9B4
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = $"delete from Abdntie where Match_ID={ this.txtmatchID.Text } and ID={ this.txtmodify.Text}";
                using (AbdntieService abdntieService = new AbdntieService())
                {
                    abdntieService.Update(cmdText);
                }
                    this.txtteam_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                string cmdText2 = string.Concat(new string[]
                {
                    "Insert Into Abdntie values (",
                    this.txtid.Text,
                    ",",
                    this.txtmatchID.Text,
                    ",'",
                    this.txtpage.Text,
                    "',",
                    this.txtamount.Text,
                    ",",
                    this.txtrate.Text,
                    ",'",
                    this.txtteam.Text,
                    "','",
                    this.txtmode.Text,
                    "','",
                    this.txtparty.Text,
                    "','",
                    Conversions.ToString(DateAndTime.Now.Date),
                    "' ,'",
                    this.txtime.Text,
                    "','",
                    this.txtABDN.Text,
                    "','",
                    this.txtNonABDN.Text,
                    "','",
                    this.txtTie.Text,
                    "','",
                    this.txtNontie.Text,
                    "','",
                    Conversions.ToString(DateAndTime.Now.Date),
                    "','",
                    this.txtregular.Text,
                    "','0','",
                    this.txtabp.Text,
                    "',1,0)"
                });
                using (AbdntieService abdntieService1 = new AbdntieService())
                {
                    abdntieService1.Update(cmdText2);
                }
                    this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Panel5.Hide();
                this.txtmodify.Text = null;
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

        // Token: 0x06000177 RID: 375 RVA: 0x0027E890 File Offset: 0x0027CC90
        private void txtteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ABDN12();
                this.Tie();
                if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0)
                {
                    this.txtTie.Text = "0";
                    this.txtNontie.Text = "0";
                }
                if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0)
                {
                    this.txtTie.Text = "0";
                    this.txtNontie.Text = "0";
                }
                if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0)
                {
                    this.txtABDN.Text = "0";
                    this.txtNonABDN.Text = "0";
                }
                if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0)
                {
                    this.txtABDN.Text = "0";
                    this.txtNonABDN.Text = "0";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000178 RID: 376 RVA: 0x0027E990 File Offset: 0x0027CD90
        public void ABDN12()
        {
            try
            {
                this.txttotal.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtABDN.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtNonABDN.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtNonABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtNonABDN.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtABDN.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtNonABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
                this.txtTie.Text = "0";
                this.txtNontie.Text = "0";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000179 RID: 377 RVA: 0x0027ECA4 File Offset: 0x0027D0A4
        public void Tie()
        {
            try
            {
                this.txttotal.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtTie.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtNontie.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtTie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtNontie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtNontie.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtTie.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtNontie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtTie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600017A RID: 378 RVA: 0x0027EF98 File Offset: 0x0027D398
        private void txtparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tieparsent = 0.0;
                this.txtregular.SelectedIndex = this.txtparty.SelectedIndex;
                this.smatch.SelectedIndex = this.txtparty.SelectedIndex;
                this.ComboBox1.SelectedIndex = this.txtparty.SelectedIndex;
                this.amatch.SelectedIndex = this.txtparty.SelectedIndex;
                this.pmatch.SelectedIndex = this.txtparty.SelectedIndex;
                int num = checked((int)Math.Round(unchecked(Conversion.Val(this.smatch.Text) + Conversion.Val(this.amatch.Text) + Conversion.Val(this.pmatch.Text))));
                this.txtabp.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num));
                this.tieparsent = Conversion.Val(0.01) * Conversion.Val(this.ComboBox1.Text);
                this.c1a.SelectedIndex = this.txtparty.SelectedIndex;
                this.c2a.SelectedIndex = this.txtparty.SelectedIndex;
                this.c3A.SelectedIndex = this.txtparty.SelectedIndex;
                double num2 = Conversion.Val(this.c1a.Text) + Conversion.Val(this.c2a.Text) + Conversion.Val(this.c3A.Text);
                this.txtaparsent.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num2));
                this.c1t.SelectedIndex = this.txtparty.SelectedIndex;
                this.c2t.SelectedIndex = this.txtparty.SelectedIndex;
                this.c3t.SelectedIndex = this.txtparty.SelectedIndex;
                double num3 = Conversion.Val(this.c1t.Text) + Conversion.Val(this.c2t.Text) + Conversion.Val(this.c3t.Text);
                this.txttparsent.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num3));
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600017B RID: 379 RVA: 0x0027F238 File Offset: 0x0027D638
        private void txtagent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.smatch.SelectedIndex = this.txtagent.SelectedIndex;
                int num = checked((int)Math.Round(Conversion.Val(this.smatch.Text)));
                double value = Conversion.Val(0.01) * Conversion.Val(num);
                this.txtparsent.Text = Conversions.ToString(value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600017C RID: 380 RVA: 0x0027F2A4 File Offset: 0x0027D6A4
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel5.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600017D RID: 381 RVA: 0x0027F2F8 File Offset: 0x0027D6F8
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmodify.Text, "", false) != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "Select * from Abdntie where Match_ID=",
                        this.txtmatchID.Text,
                        " and ID=",
                        this.txtmodify.Text,
                        " and Delete_CHK='1'"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("connot delete this record", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = $"update  Abdntie set Delete_CHK=1 where Match_ID={ this.txtmatchID.Text }and ID={ this.txtmodify.Text}";
                        using (AbdntieService abdntieService = new AbdntieService())
                        {
                            abdntieService.Update(cmdText2);
                        }
                            this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

        // Token: 0x0600017E RID: 382 RVA: 0x0027F454 File Offset: 0x0027D854
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.ListView2.Items.Clear();
                this.listlode_print();
                mareport mareport = new mareport();
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add("ListViewData");
                DataColumnCollection columns = dataSet.Tables[0].Columns;
                columns.Add("Sr_No", Type.GetType("System.String"));
                columns.Add("Amount", Type.GetType("System.String"));
                columns.Add("Rate", Type.GetType("System.String"));
                columns.Add("Fovrt", Type.GetType("System.String"));
                columns.Add("Mode", Type.GetType("System.String"));
                columns.Add("name", Type.GetType("System.String"));
                try
                {
                    foreach (object obj in this.ListView2.Items)
                    {
                        ListViewItem listViewItem = (ListViewItem)obj;
                        DataRow dataRow = dataSet.Tables[0].NewRow();
                        dataRow[0] = listViewItem.SubItems[0].Text;
                        dataRow[1] = listViewItem.SubItems[1].Text;
                        dataRow[2] = listViewItem.SubItems[2].Text;
                        dataRow[3] = listViewItem.SubItems[3].Text;
                        dataRow[4] = listViewItem.SubItems[4].Text;
                        dataRow[5] = listViewItem.SubItems[5].Text;
                        dataSet.Tables[0].Rows.Add(dataRow);
                    }
                }
                finally
                {
                    IEnumerator enumerator = null;
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                mareport.SetDataSource(dataSet);
                mareport.PrintToPrinter(0, false, 0, 0);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600017F RID: 383 RVA: 0x0027F69C File Offset: 0x0027DA9C
        public void listlode_print()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "Select * from  Abdntie where Match_ID=",
                    this.testnu.Text,
                    " and Party_Name='",
                    this.txtagent.Text,
                    "'"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "1", false))
                    {
                        if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "0", false))
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem = (ListViewItem)NewLateBinding.LateGet(this.ListView2.Items, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[0])
                            }, null, null, null);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[3])
                            }, null, null, null, true);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[4])
                            }, null, null, null, true);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[5])
                            }, null, null, null, true);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[6])
                            }, null, null, null, true);
                            listViewItem.SubItems.Add(this.txtname.Text);
                            listViewItem.BackColor = Color.White;
                        }
                    }
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

        // Token: 0x06000180 RID: 384 RVA: 0x0027F8DC File Offset: 0x0027DCDC
        public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
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
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000181 RID: 385 RVA: 0x0027FA38 File Offset: 0x0027DE38
        private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtparty = this.txtparty;
                this.AutoComplete11(ref txtparty, e, false);
                this.txtparty = txtparty;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000182 RID: 386 RVA: 0x0027FA60 File Offset: 0x0027DE60
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
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000183 RID: 387 RVA: 0x0027FA78 File Offset: 0x0027DE78
        private void txtparty_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000184 RID: 388 RVA: 0x0027FA90 File Offset: 0x0027DE90
        public void all_Agent()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select PartyName from PartyMaster where AParty='" + this.txtname.Text + "'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                }
                else
                {
                    string cmdText2 = "select PartyName from PartyMaster where TParty='" + this.txtname.Text + "'";
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    if (oleDbDataReader2.Read())
                    {
                        int index2 = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["PartyName"]);
                    }
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

        // Token: 0x06000185 RID: 389 RVA: 0x0027FC20 File Offset: 0x0027E020
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{HOME}");
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

        // Token: 0x06000186 RID: 390 RVA: 0x0027FC58 File Offset: 0x0027E058
        private void DataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView5.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView5.CurrentRow.Cells[0].Value = true;
                        }
                        int num = 0;
                        int num2 = this.DataGridView5.Rows.Count - 1;
                        double num3 = 0;
                        double num4 = 0;
                        double num5 = 0;
                        double num6 = 0;
                        for (int i = num; i <= num2; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[i].Cells[0].Value, true, false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[6].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[7].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                                }
                            }
                        }
                        this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, true, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE       Abdntie SET M_chk = 1 WHERE        (Match_ID = " + this.testnu.Text + ") AND (ID = ", this.DataGridView5.CurrentRow.Cells[1].Value), ")"));
                            OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                            oleDbCommand.ExecuteNonQuery();
                            this.DataGridView5.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, false, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE      Abdntie SET M_chk = 0 WHERE        (Match_ID = " + this.testnu.Text + ") AND (ID = ", this.DataGridView5.CurrentRow.Cells[1].Value), ")"));
                            OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                            oleDbCommand.ExecuteNonQuery();
                            this.DataGridView5.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
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
        }

        // Token: 0x06000187 RID: 391 RVA: 0x002800E8 File Offset: 0x0027E4E8
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
                    int num = 0;
                    int num2 = this.DataGridView5.Rows.Count - 1;
                    double num3 = 0;
                    double num4 = 0;
                    double num5 = 0;
                    double num6 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        this.DataGridView5.Rows[i].Cells[0].Value = true;
                        unchecked
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[i].Cells[0].Value, true, false))
                            {
                                num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[6].Value));
                                num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[7].Value));
                                num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                                num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE       Abdntie SET M_chk = 1 WHERE        (Match_ID = " + this.testnu.Text + ") AND (ID = ", this.DataGridView5.Rows[i].Cells[1].Value), ")"));
                                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                oleDbCommand.ExecuteNonQuery();
                                this.DataGridView5.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
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

        // Token: 0x06000188 RID: 392 RVA: 0x00280444 File Offset: 0x0027E844
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView5.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private Panel _Panel2;

        private Label _Label2;

        // Token: 0x0400004D RID: 77
        [AccessedThroughProperty("txtname")]
        private ComboBox _txtname;

        // Token: 0x0400004E RID: 78
        [AccessedThroughProperty("btnshow")]
        private Button _btnshow;

        private Button _Button2;

        private Button _Button3;

        // Token: 0x04000051 RID: 81
        [AccessedThroughProperty("Button6")]
        private Button _Button6;

        // Token: 0x04000052 RID: 82
        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        // Token: 0x04000053 RID: 83
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000054 RID: 84
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;

        // Token: 0x04000055 RID: 85
        [AccessedThroughProperty("testnu")]
        private TextBox _testnu;

        // Token: 0x04000056 RID: 86
        [AccessedThroughProperty("DataGridView3")]
        private DataGridView _DataGridView3;

        // Token: 0x04000057 RID: 87
        [AccessedThroughProperty("DataGridView2")]
        private DataGridView _DataGridView2;

        // Token: 0x04000058 RID: 88
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x04000059 RID: 89
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x0400005A RID: 90
        [AccessedThroughProperty("txtparsent")]
        private TextBox _txtparsent;

        // Token: 0x0400005B RID: 91
        [AccessedThroughProperty("pmatch")]
        private ComboBox _pmatch;

        // Token: 0x0400005C RID: 92
        [AccessedThroughProperty("amatch")]
        private ComboBox _amatch;

        // Token: 0x0400005D RID: 93
        [AccessedThroughProperty("smatch")]
        private ComboBox _smatch;

        // Token: 0x0400005E RID: 94
        [AccessedThroughProperty("colore")]
        private Button _colore;

        // Token: 0x0400005F RID: 95
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000060 RID: 96
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;

        // Token: 0x04000061 RID: 97
        [AccessedThroughProperty("Column18")]
        private DataGridViewTextBoxColumn _Column18;

        // Token: 0x04000062 RID: 98
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;

        // Token: 0x04000063 RID: 99
        [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

        // Token: 0x04000064 RID: 100
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;

        // Token: 0x04000065 RID: 101
        [AccessedThroughProperty("Column13")]
        private DataGridViewTextBoxColumn _Column13;

        // Token: 0x04000066 RID: 102
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;

        // Token: 0x04000067 RID: 103
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;

        // Token: 0x04000068 RID: 104
        [AccessedThroughProperty("Column14")]
        private DataGridViewTextBoxColumn _Column14;

        // Token: 0x04000069 RID: 105
        [AccessedThroughProperty("txtagent")]
        private ComboBox _txtagent;

        // Token: 0x0400006A RID: 106
        [AccessedThroughProperty("txtnu")]
        private TextBox _txtnu;

        // Token: 0x0400006B RID: 107
        [AccessedThroughProperty("total")]
        private Button _total;

        // Token: 0x0400006C RID: 108
        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;

        // Token: 0x0400006D RID: 109
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;

        // Token: 0x0400006E RID: 110
        [AccessedThroughProperty("Panel4")]
        private Panel _Panel4;

        // Token: 0x0400006F RID: 111
        [AccessedThroughProperty("txtime")]
        private DateTimePicker _txtime;

        // Token: 0x04000070 RID: 112
        [AccessedThroughProperty("txtmatchID")]
        private TextBox _txtmatchID;

        // Token: 0x04000071 RID: 113
        [AccessedThroughProperty("txtmodify")]
        private TextBox _txtmodify;

        // Token: 0x04000072 RID: 114
        [AccessedThroughProperty("txtabp")]
        private TextBox _txtabp;

        // Token: 0x04000073 RID: 115
        [AccessedThroughProperty("txtregular")]
        private ComboBox _txtregular;

        // Token: 0x04000074 RID: 116
        [AccessedThroughProperty("txtid")]
        private TextBox _txtid;

        // Token: 0x04000075 RID: 117
        [AccessedThroughProperty("txtTie")]
        private TextBox _txtTie;

        // Token: 0x04000076 RID: 118
        [AccessedThroughProperty("txtNontie")]
        private TextBox _txtNontie;

        // Token: 0x04000077 RID: 119
        [AccessedThroughProperty("txtNonABDN")]
        private TextBox _txtNonABDN;

        // Token: 0x04000078 RID: 120
        [AccessedThroughProperty("txtABDN")]
        private TextBox _txtABDN;

        // Token: 0x04000079 RID: 121
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;

        // Token: 0x0400007A RID: 122
        [AccessedThroughProperty("Button9")]
        private Button _Button9;

        // Token: 0x0400007B RID: 123
        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        // Token: 0x0400007C RID: 124
        [AccessedThroughProperty("Button7")]
        private Button _Button7;

        // Token: 0x0400007D RID: 125
        [AccessedThroughProperty("txtpage")]
        private TextBox _txtpage;

        // Token: 0x0400007E RID: 126
        [AccessedThroughProperty("txtparty")]
        private ComboBox _txtparty;

        // Token: 0x0400007F RID: 127
        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        // Token: 0x04000080 RID: 128
        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        // Token: 0x04000081 RID: 129
        [AccessedThroughProperty("txtmode")]
        private ComboBox _txtmode;

        // Token: 0x04000082 RID: 130
        [AccessedThroughProperty("txtamount")]
        private TextBox _txtamount;

        // Token: 0x04000083 RID: 131
        [AccessedThroughProperty("txtteam")]
        private ComboBox _txtteam;

        // Token: 0x04000084 RID: 132
        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        // Token: 0x04000085 RID: 133
        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        // Token: 0x04000086 RID: 134
        [AccessedThroughProperty("txtrate")]
        private TextBox _txtrate;

        // Token: 0x04000087 RID: 135
        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        // Token: 0x04000088 RID: 136
        [AccessedThroughProperty("txttotal")]
        private TextBox _txttotal;

        // Token: 0x04000089 RID: 137
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;

        // Token: 0x0400008A RID: 138
        [AccessedThroughProperty("c1a")]
        private ComboBox _c1a;

        // Token: 0x0400008B RID: 139
        [AccessedThroughProperty("c2a")]
        private ComboBox _c2a;

        // Token: 0x0400008C RID: 140
        [AccessedThroughProperty("c3A")]
        private ComboBox _c3A;

        // Token: 0x0400008D RID: 141
        [AccessedThroughProperty("c3t")]
        private ComboBox _c3t;

        // Token: 0x0400008E RID: 142
        [AccessedThroughProperty("c2t")]
        private ComboBox _c2t;

        // Token: 0x0400008F RID: 143
        [AccessedThroughProperty("c1t")]
        private ComboBox _c1t;

        // Token: 0x04000090 RID: 144
        [AccessedThroughProperty("txtaparsent")]
        private TextBox _txtaparsent;

        // Token: 0x04000091 RID: 145
        [AccessedThroughProperty("txttparsent")]
        private TextBox _txttparsent;

        // Token: 0x04000092 RID: 146
        [AccessedThroughProperty("ListView2")]
        private ListView _ListView2;

        // Token: 0x04000093 RID: 147
        [AccessedThroughProperty("ColumnHeader13")]
        private ColumnHeader _ColumnHeader13;

        // Token: 0x04000094 RID: 148
        [AccessedThroughProperty("ColumnHeader14")]
        private ColumnHeader _ColumnHeader14;

        // Token: 0x04000095 RID: 149
        [AccessedThroughProperty("ColumnHeader15")]
        private ColumnHeader _ColumnHeader15;

        // Token: 0x04000096 RID: 150
        [AccessedThroughProperty("ColumnHeader16")]
        private ColumnHeader _ColumnHeader16;

        // Token: 0x04000097 RID: 151
        [AccessedThroughProperty("ColumnHeader17")]
        private ColumnHeader _ColumnHeader17;

        // Token: 0x04000098 RID: 152
        [AccessedThroughProperty("ColumnHeader25")]
        private ColumnHeader _ColumnHeader25;

        // Token: 0x0400009A RID: 154
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;

        // Token: 0x0400009B RID: 155
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;

        // Token: 0x0400009C RID: 156
        [AccessedThroughProperty("DataGridView4")]
        private DataGridView _DataGridView4;

        // Token: 0x0400009D RID: 157
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

        // Token: 0x0400009E RID: 158
        [AccessedThroughProperty("Column23")]
        private DataGridViewTextBoxColumn _Column23;

        // Token: 0x040000A0 RID: 160
        [AccessedThroughProperty("DataGridView5")]
        private DataGridView _DataGridView5;

        // Token: 0x040000A1 RID: 161
        [AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
        private DataGridViewCheckBoxColumn _DataGridViewCheckBoxColumn1;

        // Token: 0x040000A2 RID: 162
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;

        // Token: 0x040000A3 RID: 163
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;

        // Token: 0x040000A4 RID: 164
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;

        // Token: 0x040000A5 RID: 165
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;

        // Token: 0x040000A6 RID: 166
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;

        // Token: 0x040000A7 RID: 167
        [AccessedThroughProperty("Column15")]
        private DataGridViewTextBoxColumn _Column15;

        // Token: 0x040000A8 RID: 168
        [AccessedThroughProperty("Column16")]
        private DataGridViewTextBoxColumn _Column16;

        // Token: 0x040000A9 RID: 169
        [AccessedThroughProperty("Column17")]
        private DataGridViewTextBoxColumn _Column17;

        // Token: 0x040000AA RID: 170
        [AccessedThroughProperty("Column19")]
        private DataGridViewTextBoxColumn _Column19;

        // Token: 0x040000AB RID: 171
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;

        // Token: 0x040000AC RID: 172
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;

        // Token: 0x040000AD RID: 173
        [AccessedThroughProperty("Column20")]
        private DataGridViewTextBoxColumn _Column20;

        // Token: 0x040000AE RID: 174
        private double tieparsent;

        // Token: 0x040000AF RID: 175
        private double a;
    }
}
