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
using App.Service;

namespace YashAksh
{
    // Token: 0x02000048 RID: 72
    //[DesignerGenerated]
    public partial class fromAgentSession : Form
    {
        // Token: 0x0400077C RID: 1916
        private double a;

        // Token: 0x06001156 RID: 4438 RVA: 0x003345E4 File Offset: 0x003329E4
        public fromAgentSession()
        {
            this.InitializeComponent();
        }

        // Token: 0x06001209 RID: 4617 RVA: 0x003389F0 File Offset: 0x00336DF0
        public void YES_NO()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select *  from Settings";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    //this.CheckBox2.Checked = Conversions.ToBoolean(oleDbDataReader[3]);
                    this.txtnu.Text = Conversions.ToString(oleDbDataReader["s_Number_Format"]);
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

        // Token: 0x0600120A RID: 4618 RVA: 0x00338A94 File Offset: 0x00336E94
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
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = false;
                    this.txtrun.Text = Conversions.ToString(oleDbDataReader["Remark"]);
                    this.Label5.Text = Conversions.ToString(Operators.ConcatenateObject("DECLARED RUN : ", oleDbDataReader["Remark"]));
                }
                else
                {
                    this.txtrun.Text = "1";
                    this.Button2.Enabled = true;
                    this.Button3.Enabled = true;
                    this.Label5.Text = null;
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

        // Token: 0x0600120B RID: 4619 RVA: 0x00338BB4 File Offset: 0x00336FB4
        private void fromAgentSession_Load(object sender, EventArgs e)
        {
            try
            {
                this.Panel4.Hide();
                this.TXTMNANE.Text = Conversions.ToString(Module1.dppname);
                this.txtsid.Text = Conversions.ToString(Module1.sessionid);
                this.txtnu.Text = Module1.decimalnumberformat;
                this.CheckBox1.Checked = true;
                this.dispayname_Match();
                this.txtp.Hide();
                this.TextBox2.Hide();
                this.TXTMNANE.Hide();
                this.CheckBox1.Hide();
                this.RUN.Hide();
                this.combolodall();
                this.Decleard();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600120C RID: 4620 RVA: 0x00338D1C File Offset: 0x0033711C
        public void dispayname_Match()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtsid.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Label6.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("    ", oleDbDataReader[2]), " "), "VS"), " "), oleDbDataReader[3]));
                }
                string cmdText2 = "Select * from ewSession where Match_ID=" + this.txtsid.Text + " and Sr_No=" + Conversions.ToString(Module1.nehaid);
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                while (oleDbDataReader2.Read())
                {
                    this.Label7.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader2[3], " "), "("), oleDbDataReader2[7]), ")"));
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

        // Token: 0x0600120D RID: 4621 RVA: 0x00338EA4 File Offset: 0x003372A4
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listlode_Agent();
                this.ALL_TOTAL();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600120E RID: 4622 RVA: 0x00338EB4 File Offset: 0x003372B4
        public void ALL_TOTAL()
        {
            checked
            {
                try
                {
                    this.DataGridView1.Columns.Clear();
                    this.DataGridView1.Columns.Clear();
                    this.DataGridView1.Columns.Add("Column Name", "Run");
                    this.DataGridView1.Columns[0].Width = 100;
                    this.DataGridView1.Rows.Add(new object[]
                    {
                        " Total "
                    });
                    this.DataGridView1.Rows.Add(new object[]
                    {
                        " LD "
                    });
                    int i = 0;
                    this.DataGridView1.Columns[i].Width = 66;
                    int num = Conversions.ToInteger(this.txtrun.Text);
                    int num2 = (int)Math.Round(unchecked(Convert.ToDouble(this.txtrun.Text) + 40.0));
                    for (i = num; i <= num2; i++)
                    {
                        this.DataGridView1.Columns.Add("Column Name", Conversions.ToString(i));
                    }
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT PartyMaster.PartyName, PartyMaster.SSession, PartyMaster.AParty, PartyMaster.ASession, PartyMaster.TParty, PartyMaster.TSession, SessionTrans.S_Sr_No, SessionTrans.s_rate, SessionTrans.s_amt, SessionTrans.S_RUN, SessionTrans.s_bild, SessionTrans.s_party, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.s_checked, SessionTrans.Session_ID, SessionTrans.M_chk FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (PartyMaster.AParty = '" + this.txtname.Text + "') AND (SessionTrans.S_Sr_No = ", Module1.sessionid), ") AND (SessionTrans.Session_ID = "), Module1.nehaid), ") AND (SessionTrans.s_checked=0) OR (PartyMaster.PartyName = '"), this.txtname.Text), "') OR (PartyMaster.TParty = '"), this.txtname.Text), "')"));
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(oleDbDataReader["S_Sr_No"], Module1.sessionid.ToString(), false), Operators.CompareObjectEqual(oleDbDataReader["Session_ID"], Module1.nehaid.ToString(), false))))
                        {
                            if (Operators.CompareString(oleDbDataReader["s_checked"].ToString(), "1", false) != 0)
                            {
                                double num3 = 0;
                                double num4 = 0;
                                double num5 = 0;
                                unchecked
                                {
                                    if (Operators.CompareString(oleDbDataReader["PartyName"].ToString(), this.txtname.Text, false) == 0)
                                    {
                                        num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"])) / 100);
                                        num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"])) / 100);
                                    }
                                    if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), this.txtname.Text, false) == 0)
                                    {
                                        num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ASession"])) / 100);
                                        num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ASession"])) / 100);
                                    }
                                    if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), this.txtname.Text, false) == 0)
                                    {
                                        num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TSession"])) / 100);
                                        num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TSession"])) / 100);
                                    }
                                    num3 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
                                    num4 = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
                                    num5 = Convert.ToDouble(Operators.SubtractObject(oleDbDataReader["S_RUN"], 1));
                                }
                                if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_bild"], "0", false))
                                {
                                    double num6 = Convert.ToDouble("0");
                                    int num7 = 1;
                                    int num8 = this.DataGridView1.Columns.Count - 1;
                                    for (i = num7; i <= num8; i++)
                                    {
                                        if (Convert.ToDouble(this.DataGridView1.Columns[i].HeaderText) > num5)
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"]))));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num3)));
                                        }
                                        else
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"]))));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num4)));
                                        }
                                        this.DataGridView1.Rows[0].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[i].Value)), this.txtnu.Text);
                                        this.DataGridView1.Rows[1].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[i].Value)), this.txtnu.Text);
                                    }
                                }
                                else
                                {
                                    double num6 = Convert.ToDouble(Operators.AddObject(Operators.AddObject(num5, oleDbDataReader["s_bild"]), 2));
                                    int num9 = 1;
                                    int num10 = this.DataGridView1.Columns.Count - 1;
                                    for (i = num9; i <= num10; i++)
                                    {
                                        if (Convert.ToDouble(this.DataGridView1.Columns[i].HeaderText) > num5 & Convert.ToDouble(this.DataGridView1.Columns[i].HeaderText) < num6)
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"]))));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num3)));
                                        }
                                        else
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"]))));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num4)));
                                        }
                                        this.DataGridView1.Rows[0].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[i].Value)), this.txtnu.Text);
                                        this.DataGridView1.Rows[1].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[i].Value)), this.txtnu.Text);
                                    }
                                }
                            }
                        }
                    }
                    int num11 = 1;
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[0].Cells[num11].Value, 0, false))
                        {
                            this.DataGridView1.Rows[0].Cells[num11].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[0].Cells[num11].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[1].Cells[num11].Value, 0, false))
                        {
                            this.DataGridView1.Rows[1].Cells[num11].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[1].Cells[num11].Style.ForeColor = Color.Green;
                        }
                        num11++;
                    }
                    while (num11 <= 41);
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

        // Token: 0x0600120F RID: 4623 RVA: 0x003399C0 File Offset: 0x00337DC0
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

        // Token: 0x06001210 RID: 4624 RVA: 0x00339B1C File Offset: 0x00337F1C
        public void listlode_Agent()
        {
            checked
            {
                try
                {
                    this.DataGridView4.Rows.Clear();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    this.a = 0.0;
                    string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT PartyMaster.PartyName, PartyMaster.SSession, PartyMaster.AParty, PartyMaster.ASession, PartyMaster.TParty, PartyMaster.TSession, SessionTrans.id, SessionTrans.S_Sr_No, SessionTrans.s_eid, SessionTrans.s_page, SessionTrans.s_rate, SessionTrans.s_amt, SessionTrans.S_RUN, SessionTrans.s_bild, SessionTrans.s_mod, SessionTrans.s_party, SessionTrans.Status, SessionTrans.s_yes,SessionTrans.s_no, SessionTrans.s_time, SessionTrans.s_modify, SessionTrans.s_checked, SessionTrans.Session_ID, SessionTrans.M_chk FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (PartyMaster.AParty = '" + this.txtname.Text + "') AND (SessionTrans.S_Sr_No = ", Module1.sessionid), ") AND (SessionTrans.Session_ID = "), Module1.nehaid), ") OR (PartyMaster.PartyName = '"), this.txtname.Text), "') OR (PartyMaster.TParty = '"), this.txtname.Text), "') ORDER BY SessionTrans.s_eid DESC"));
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        if (Operators.CompareString(oleDbDataReader["S_Sr_No"].ToString(), Module1.sessionid.ToString(), false) == 0 & Operators.CompareString(oleDbDataReader["Session_ID"].ToString(), Module1.nehaid.ToString(), false) == 0)
                        {
                            if (Operators.CompareString(oleDbDataReader["s_checked"].ToString(), "1", false) == 0)
                            {
                                int num = this.DataGridView4.Rows.Add();
                                this.DataGridView4.Rows[num].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                                this.DataGridView4.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                                this.DataGridView4.Rows[num].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                                this.DataGridView4.Rows[num].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                                this.DataGridView4.Rows[num].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                                this.DataGridView4.Rows[num].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                                this.DataGridView4.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                                this.a = Convert.ToDouble(num + 1);
                            }
                            else if (Operators.CompareString(oleDbDataReader["M_chk"].ToString(), "1", false) == 0)
                            {
                                int num2 = this.DataGridView4.Rows.Add();
                                this.DataGridView4.Rows[num2].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                                this.DataGridView4.Rows[num2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num2].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                                this.DataGridView4.Rows[num2].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                                this.DataGridView4.Rows[num2].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                                this.DataGridView4.Rows[num2].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num2].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                                this.DataGridView4.Rows[num2].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                                this.a = Convert.ToDouble(num2 + 1);
                                this.DataGridView4.Rows[num2].Cells[0].Value = true;
                                this.DataGridView4.Rows[num2].DefaultCellStyle.BackColor = Color.LimeGreen;
                                this.DataGridView4.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
                            }
                            else if (Operators.CompareString(oleDbDataReader["s_modify"].ToString(), "1", false) == 0)
                            {
                                int num3 = this.DataGridView4.Rows.Add();
                                this.DataGridView4.Rows[num3].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                                this.DataGridView4.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num3].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                                this.DataGridView4.Rows[num3].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                                this.DataGridView4.Rows[num3].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                                this.DataGridView4.Rows[num3].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num3].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                                this.DataGridView4.Rows[num3].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                                this.a = Convert.ToDouble(num3 + 1);
                                this.DataGridView4.Rows[num3].DefaultCellStyle.ForeColor = Color.Blue;
                            }
                            else
                            {
                                int num4 = this.DataGridView4.Rows.Add();
                                this.DataGridView4.Rows[num4].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                                this.DataGridView4.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num4].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num4].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                                this.DataGridView4.Rows[num4].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                                this.DataGridView4.Rows[num4].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                                this.DataGridView4.Rows[num4].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                                this.DataGridView4.Rows[num4].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                                this.DataGridView4.Rows[num4].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                                this.a = Convert.ToDouble(num4 + 1);
                            }
                        }
                    }
                    this.Label2.Text = "TOTAL ENTRY : " + Conversions.ToString(this.a);
                    this.ALL_TOTAL();
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

        // Token: 0x06001211 RID: 4625 RVA: 0x0033A810 File Offset: 0x00338C10
        public void combolodall()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.txtname.Items.Clear();
                while (oleDbDataReader.Read())
                {
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["AParty"]));
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TParty"]));
                    this.TXTMNANE.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                    this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                    this.Cstaus.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"]));
                    this.txtself.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"]));
                    this.txtagent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["ASession"]));
                    this.txtpatnar.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TSession"]));
                }
                double value = Conversion.Val(0.01) * Conversion.Val(this.txtp.Text);
                this.TextBox2.Text = Conversions.ToString(value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001212 RID: 4626 RVA: 0x0033AA7C File Offset: 0x00338E7C
        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001213 RID: 4627 RVA: 0x0033AAB8 File Offset: 0x00338EB8
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

        // Token: 0x06001214 RID: 4628 RVA: 0x0033AAE0 File Offset: 0x00338EE0
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form3_SESSION form3_SESSION = new Form3_SESSION();
                form3_SESSION.MdiParent = this.MdiParent;
                form3_SESSION.Session_Size();
                form3_SESSION.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001215 RID: 4629 RVA: 0x0033AB3C File Offset: 0x00338F3C
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
                        "Select * from SessionTrans where s_eid=",
                        this.txtmodify.Text,
                        " and S_Sr_No=",
                        this.txtsid.Text,
                        " and Session_ID=",
                        Conversions.ToString(Module1.nehaid),
                        " and s_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Connot delete this record ", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = string.Concat(new string[]
                        {
                            "SELECT        S_Sr_No, s_eid, s_page, s_rate, s_amt, S_RUN, s_bild, s_mod, s_party, s_yes, s_no, s_time, s_modify, s_checked, Session_ID, M_chk FROM SessionTrans WHERE        (S_Sr_No = ",
                            this.txtsid.Text,
                            ") AND (Session_ID = ",
                            Conversions.ToString(Module1.nehaid),
                            ") AND (s_eid = ",
                            this.txtmodify.Text,
                            ")"
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        if (oleDbDataReader2.Read())
                        {
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader2["s_checked"], "1", false))
                            {
                                Interaction.MsgBox("Cannot edit this record.?", MsgBoxStyle.OkOnly, null);
                            }
                            else
                            {
                                this.Panel4.Show();
                                this.txtpage.Text = oleDbDataReader2["s_page"].ToString();
                                this.modifyrun.Text = oleDbDataReader2["S_RUN"].ToString();
                                this.txtrate.Text = oleDbDataReader2["s_rate"].ToString();
                                this.txtamount.Text = oleDbDataReader2["s_amt"].ToString();
                                this.txtbild.Text = oleDbDataReader2["s_bild"].ToString();
                                this.txtmodeKL.Text = oleDbDataReader2["s_mod"].ToString();
                                this.txtparty.Text = oleDbDataReader2["s_party"].ToString();
                                this.txtK.Text = oleDbDataReader2["s_yes"].ToString();
                                this.txtL.Text = oleDbDataReader2["s_no"].ToString();
                                this.txttime.Text = oleDbDataReader2["s_time"].ToString();
                                this.modifyrun.Focus();
                            }
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

        // Token: 0x06001216 RID: 4630 RVA: 0x0033AE40 File Offset: 0x00339240
        private void txtparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cstaus.SelectedIndex = this.txtparty.SelectedIndex;
                this.txtself.SelectedIndex = this.txtparty.SelectedIndex;
                this.txtagent.SelectedIndex = this.txtparty.SelectedIndex;
                this.txtpatnar.SelectedIndex = this.txtparty.SelectedIndex;
                int num = checked((int)Math.Round(unchecked(Conversion.Val(this.txtself.Text) + Conversion.Val(this.txtagent.Text) + Conversion.Val(this.txtpatnar.Text))));
                this.txttotalsession.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num));
                //this.txtt.SelectedIndex = this.txtparty.SelectedIndex;
                //this.txtt_20.SelectedIndex = this.txtparty.SelectedIndex;
                //this.txtt_40.SelectedIndex = this.txtparty.SelectedIndex;
                //this.txtt_50.SelectedIndex = this.txtparty.SelectedIndex;
                //if (Operators.CompareString(this.Label4.Text, "50-50", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt_50.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "40-40", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt_40.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "20-20", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt_20.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "TEST", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "NO COMMISSION", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = "0";
                //}
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001217 RID: 4631 RVA: 0x0033B094 File Offset: 0x00339494
        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.K__L();
                string cmdText = $"UPDATE SessionTrans SET s_page ={this.txtpage.Text}, s_rate ={this.txtrate.Text}, s_amt ={this.txtamount.Text}, S_RUN ={this.modifyrun.Text}, s_bild ={this.txtbild.Text}, s_mod ='{this.txtmodeKL.Text}', s_party ='{this.txtparty.Text}', Status ='N', s_yes ={this.txtK.Text}, s_no ={this.txtL.Text}, s_time ='{this.txttime.Text}', s_modify =1, s_checked =0, totalpa =0, M_chk =0 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                using (SessionService sessionService = new SessionService())
                {
                    sessionService.Update(cmdText);
                }
                this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Panel4.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001218 RID: 4632 RVA: 0x0033B298 File Offset: 0x00339698
        public void K__L()
        {
            try
            {
                if (Operators.CompareString(this.txtmodeKL.Text, "K", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text));
                    this.txtL.Text = this.txtamount.Text;
                }
                if (Operators.CompareString(this.txtmodeKL.Text, "L", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtL.Text = Conversions.ToString(Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001219 RID: 4633 RVA: 0x0033B410 File Offset: 0x00339810
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel4.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600121A RID: 4634 RVA: 0x0033B464 File Offset: 0x00339864
        private void Button3_Click(object sender, EventArgs e)
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
                        "Select * from SessionTrans where s_eid=",
                        this.txtmodify.Text,
                        " and S_Sr_No=",
                        this.txtsid.Text,
                        " and Session_ID=",
                        Conversions.ToString(Module1.nehaid),
                        " and s_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Connot delete this record ", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = $"update SessionTrans set s_checked=1 where s_eid={this.txtmodify.Text} and S_Sr_No={this.txtsid.Text} and Session_ID={Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText2);
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

        // Token: 0x0600121B RID: 4635 RVA: 0x0033B604 File Offset: 0x00339A04
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.ListView2.Items.Clear();
                if (Operators.CompareString(this.txtname.Text, null, false) != 0)
                {
                    //Add RPT
                    //SDDPreport sddpreport = new SDDPreport();

                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add("ListViewData1");
                    DataColumnCollection columns = dataSet.Tables[0].Columns;
                    columns.Add("Sr_No", Type.GetType("System.String"));
                    columns.Add("Amount", Type.GetType("System.String"));
                    columns.Add("Rate", Type.GetType("System.String"));
                    columns.Add("Run", Type.GetType("System.String"));
                    columns.Add("Mode", Type.GetType("System.String"));
                    columns.Add("Badli", Type.GetType("System.String"));
                    columns.Add("name", Type.GetType("System.String"));

                    //sddpreport.SetDataSource(dataSet);
                    //sddpreport.PrintToPrinter(0, false, 0, 0);

                    print_view printView = new print_view();
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(Application.StartupPath + "\\RPT\\SDDPreport.rpt");
                    reportDocument.SetDataSource(dataSet);
                    printView.crystalReportViewer1.ReportSource = reportDocument;
                    printView.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600121C RID: 4636 RVA: 0x0033B71C File Offset: 0x00339B1C
        public void listlode1_print()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from SessionTrans where S_Sr_No=", Module1.sessionid), " and s_party='"), this.TXTMNANE.Text), "' and Session_ID="), Module1.nehaid));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "1", false))
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem = (ListViewItem)NewLateBinding.LateGet(this.ListView2.Items, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[0])
                        }, null, null, null);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[5])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[4])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[6])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[8])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[7])
                        }, null, null, null, true);
                        listViewItem.SubItems.Add(this.txtname.Text);
                        listViewItem.SubItems[1].Text = Convert.ToDouble(listViewItem.SubItems[1].Text).ToString(this.txtnu.Text);
                        listViewItem.SubItems[2].Text = Convert.ToDouble(listViewItem.SubItems[2].Text).ToString(this.txtnu.Text);
                        listViewItem.BackColor = Color.White;
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

        // Token: 0x0600121D RID: 4637 RVA: 0x0033B9EC File Offset: 0x00339DEC
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

        // Token: 0x0600121E RID: 4638 RVA: 0x0033BB48 File Offset: 0x00339F48
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

        // Token: 0x0600121F RID: 4639 RVA: 0x0033BB70 File Offset: 0x00339F70
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

        // Token: 0x06001220 RID: 4640 RVA: 0x0033BB88 File Offset: 0x00339F88
        public void total_all()
        {
            try
            {
                this.DataGridView3.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView2.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(ASession) from PartyMaster where PartyName='", dataGridViewRow.Cells[0].Value), "'"));
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        double num2 = 0;
                        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                        {
                            double num = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                            num2 = Conversion.Val(0.01) * Conversion.Val(num);
                        }
                        string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(s_yes)  from SessionTrans where  s_party='", dataGridViewRow.Cells[0].Value), "'  and S_Sr_No="), this.txtsid.Text), " and  s_checked=0 and Session_ID="), Module1.nehaid));
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                        {
                            double num3 = Convert.ToDouble(oleDbCommand2.ExecuteScalar());
                            string cmdText3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(s_no)  from SessionTrans  where s_party='", dataGridViewRow.Cells[0].Value), "'  and S_Sr_No="), this.txtsid.Text), " and  s_checked=0 and Session_ID="), Module1.nehaid));
                            OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                            double num4 = 0;
                            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand3.ExecuteScalar())))
                            {
                                num4 = Convert.ToDouble(oleDbCommand3.ExecuteScalar());
                            }
                            int index = this.DataGridView3.Rows.Add();
                            this.DataGridView3.Rows[index].Cells[0].Value = Conversion.Val(num2) * Conversion.Val(num3);
                            this.DataGridView3.Rows[index].Cells[1].Value = Conversion.Val(num2) * Conversion.Val(num4);
                        }
                    }
                }
                finally
                {
                    Module1.conn.Close();
                }
                int num5 = 0;
                checked
                {
                    int num6 = this.DataGridView3.RowCount - 1;
                    double num7 = 0;
                    double num8 = 0;
                    for (int i = num5; i <= num6; i++)
                    {
                        unchecked
                        {
                            num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[0].Value));
                            num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[1].Value));
                        }
                    }
                    int num9 = 1;
                    do
                    {
                        this.DataGridView1.Rows[1].Cells[num9].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                        num9++;
                    }
                    while (num9 <= 3);
                    int num10 = 4;
                    do
                    {
                        this.DataGridView1.Rows[1].Cells[num10].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                        num10++;
                    }
                    while (num10 <= 41);
                    int num11 = 1;
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[0].Cells[num11].Value, 0, false))
                        {
                            this.DataGridView1.Rows[0].Cells[num11].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[0].Cells[num11].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[1].Cells[num11].Value, 0, false))
                        {
                            this.DataGridView1.Rows[1].Cells[num11].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[1].Cells[num11].Style.ForeColor = Color.Green;
                        }
                        num11++;
                    }
                    while (num11 <= 41);
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

        // Token: 0x06001221 RID: 4641 RVA: 0x0033C0E0 File Offset: 0x0033A4E0
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Form3_SESSION form3_SESSION = new Form3_SESSION();
                    form3_SESSION.MdiParent = this.MdiParent;
                    form3_SESSION.Session_Size();
                    form3_SESSION.Show();
                    this.Close();
                }
                if (e.KeyCode == Keys.Return)
                {
                    this.listlode_Agent();
                    this.ALL_TOTAL();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001222 RID: 4642 RVA: 0x0033C17C File Offset: 0x0033A57C
        private void fromAgentSession_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Form3_SESSION form3_SESSION = new Form3_SESSION();
                    form3_SESSION.MdiParent = this.MdiParent;
                    form3_SESSION.Session_Size();
                    form3_SESSION.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001223 RID: 4643 RVA: 0x0033C204 File Offset: 0x0033A604
        private void txtrun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtname.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please insert Name..?", MsgBoxStyle.OkOnly, null);
                }
                else if (e.KeyCode == Keys.Return)
                {
                    this.ALL_TOTAL();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001224 RID: 4644 RVA: 0x0033C274 File Offset: 0x0033A674
        private void fromAgentSession_Activated(object sender, EventArgs e)
        {
            this.txtname.Focus();
        }

        // Token: 0x06001225 RID: 4645 RVA: 0x0033C284 File Offset: 0x0033A684
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView4.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001226 RID: 4646 RVA: 0x0033C310 File Offset: 0x0033A710
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[0].Value, true, false))
                    {
                        this.DataGridView4.CurrentRow.Cells[0].Value = false;
                    }
                    else
                    {
                        this.DataGridView4.CurrentRow.Cells[0].Value = true;
                    }
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[0].Value, true, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE  SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView4.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[0].Value, false, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView4.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001227 RID: 4647 RVA: 0x0033C598 File Offset: 0x0033A998
        private void Button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView4.Rows.Count - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        this.DataGridView4.Rows[i].Cells[0].Value = true;
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[i].Cells[0].Value, true, false))
                        {
                            string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.DataGridView4.Rows[i].Cells[1].Value} AND SessionTrans.Session_ID = {Module1.nehaid}";
                            using (SessionService sessionService = new SessionService())
                            {
                                sessionService.Update(cmdText);
                            }
                            this.DataGridView4.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
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

        // Token: 0x06001228 RID: 4648 RVA: 0x0033C73C File Offset: 0x0033AB3C
        private void txtparty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.Button8.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001229 RID: 4649 RVA: 0x0033C790 File Offset: 0x0033AB90
        private void DataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[0].Value, true, false))
                    {
                        this.DataGridView4.CurrentRow.Cells[0].Value = false;
                    }
                    else
                    {
                        this.DataGridView4.CurrentRow.Cells[0].Value = true;
                    }
                    this.DataGridView1_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[0].Value, true, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView4.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[0].Value, false, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                          using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView4.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
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
}
