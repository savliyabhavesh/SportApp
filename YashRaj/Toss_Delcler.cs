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
    // Token: 0x020000CA RID: 202
    //[DesignerGenerated]
    public partial class Toss_Delcler : Form
    {
        string strTime = "";
        // Token: 0x060022BE RID: 8894 RVA: 0x003B7628 File Offset: 0x003B5A28
        public Toss_Delcler()
        {
            //base.Load += this.Toss_Delcler_Load;			
            this.InitializeComponent();
        }

        // Token: 0x0600231D RID: 8989 RVA: 0x003B932C File Offset: 0x003B772C
        private void Toss_Delcler_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.match_lode();
                this.Name_lode();
                this.txtdate.Hide();
                this.DataSRHI.Rows.Add();
                this.DataSRHI.Rows.Add();
                this.DataSRHI.Rows.Add();
                this.DataSRHI.Rows.Add();
                this.typea.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600231E RID: 8990 RVA: 0x003B93D4 File Offset: 0x003B77D4
        public void match_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + Conversions.ToString(Module1.Matchdecalerd);
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.txtdate.Text = oleDbDataReader["Date1"].ToString();
                    strTime = oleDbDataReader["entry_time"].ToString();
                    this.lbldisply.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader[0], " - "), oleDbDataReader[2]), "  VS  "), oleDbDataReader[3]), "    "), oleDbDataReader[4]), "       "), oleDbDataReader[1]));
                    this.txtmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[2]));
                    this.txttem1.Text = Conversions.ToString(oleDbDataReader[5]);
                    this.txtmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]));
                    this.txttem2.Text = Conversions.ToString(oleDbDataReader[6]);
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[7], "", false))
                    {
                        this.txtmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[7]));
                        this.txttem3.Text = Conversions.ToString(oleDbDataReader[7]);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[8], "", false))
                    {
                        this.txtmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[8]));
                        this.txttem4.Text = Conversions.ToString(oleDbDataReader[8]);
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

        // Token: 0x0600231F RID: 8991 RVA: 0x003B9610 File Offset: 0x003B7A10
        public void Name_lode()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Id"], "1", false))
                    {
                        this.sri = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                    }
                    else if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["Id"], "2", false))
                    {
                        if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["Id"], "3", false))
                        {
                            int index = this.DataGridView2.Rows.Add();
                            this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
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

        // Token: 0x06002320 RID: 8992 RVA: 0x003B9760 File Offset: 0x003B7B60
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView3.Rows.Clear();
                if (Operators.CompareString(this.typea.Text, "Toss", false) == 0)
                {
                    this.Decliar_New();
                    MyProject.Forms.Toss_Reports.MdiParent = this.MdiParent;
                    MyProject.Forms.Toss_Reports.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.Toss_Reports.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002321 RID: 8993 RVA: 0x003B97F4 File Offset: 0x003B7BF4
        public void Decliar_New()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, SUM(MatchTrans1.m_team1) AS Expr1, SUM(MatchTrans1.m_team2) AS Expr2, SUM(MatchTrans1.m_team3) AS Expr3, SUM(MatchTrans1.m_team4) AS Expr4, MatchTrans1.m_checked, MatchTrans1.m_id FROM (PartyMaster INNER JOIN MatchTrans1 ON PartyMaster.PartyName = MatchTrans1.m_party) GROUP BY PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, MatchTrans1.m_checked, MatchTrans1.m_id HAVING (MatchTrans1.m_checked = 0) AND (MatchTrans1.m_id = " + Conversions.ToString(Module1.Matchdecalerd) + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["SMatch"]);
                    double num2 = Convert.ToDouble(oleDbDataReader["AMatch"]);
                    double num3 = Convert.ToDouble(oleDbDataReader["TMatch"]);
                    string text = Conversions.ToString(oleDbDataReader["AParty"]);
                    string text2 = Conversions.ToString(oleDbDataReader["TParty"]);
                    double num4 = 0;
                    if (Operators.CompareString(this.txttem1.Text, this.txtmatch.Text, false) == 0)
                    {
                        num4 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    }
                    else if (Operators.CompareString(this.txttem2.Text, this.txtmatch.Text, false) == 0)
                    {
                        num4 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    }
                    else if (Operators.CompareString(this.txttem3.Text, this.txtmatch.Text, false) == 0)
                    {
                        num4 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    }
                    else if (Operators.CompareString(this.txttem4.Text, this.txtmatch.Text, false) == 0)
                    {
                        num4 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    }
                    int index = this.DataGridView3.Rows.Add();
                    this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                    this.DataGridView3.Rows[index].Cells[1].Value = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
                    double num5 = 0;
                    if (num4 > 0.0)
                    {
                        this.DataGridView3.Rows[index].Cells[2].Value = this.ComboBox1.Text;
                        double num6 = 0;
                        num5 = Conversion.Val(num4) * Conversion.Val(num6) / 100;
                        this.DataGridView3.Rows[index].Cells[3].Value = num5;
                    }
                    double num7 = Conversion.Val(num4) - Conversion.Val(num5);
                    this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                    this.DataGridView3.Rows[index].Cells[5].Value = Conversion.Val(num7) * Conversion.Val(num) / 100;
                    double num8 = Conversion.Val(num7) * Conversion.Val(num) / 100 - Conversion.Val(num7);
                    num8 = num8 - num8 - num8;
                    if (Operators.CompareString(text, null, false) != 0)
                    {
                        this.DataGridView3.Rows[index].Cells[6].Value = text;
                        this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(num8) * Conversion.Val(num2) / 100;
                    }
                    if (Operators.CompareString(text2, null, false) != 0)
                    {
                        this.DataGridView3.Rows[index].Cells[8].Value = text2;
                        this.DataGridView3.Rows[index].Cells[9].Value = Conversion.Val(num8) * Conversion.Val(num3) / 100;
                    }
                    this.testtotal += Convert.ToDouble(num4);
                    this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[3].Value));
                    this.SelfTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[5].Value));
                    this.AgentTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[7].Value));
                    this.PatnerTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[9].Value));
                }
                string cmdText2 = "Select * from PartyMaster Where ID=1";
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                string text3 = "";
                if (oleDbDataReader2.Read())
                {
                    text3 = oleDbDataReader2["PartyName"].ToString();
                }
                double num9 = Conversion.Val(this.commiTotal) - Conversion.Val(this.commiTotal) - Conversion.Val(this.commiTotal);
                double num10 = Conversion.Val(this.SelfTotal) - Conversion.Val(this.SelfTotal) - Conversion.Val(this.SelfTotal);
                double num11 = Conversion.Val(this.AgentTotal) - Conversion.Val(this.AgentTotal) - Conversion.Val(this.AgentTotal);
                double num12 = Conversion.Val(this.PatnerTotal) - Conversion.Val(this.PatnerTotal) - Conversion.Val(this.PatnerTotal);
                int index2 = this.DataGridView3.Rows.Add();
                this.DataGridView3.Rows[index2].Cells[0].Value = text3.ToString();
                this.DataGridView3.Rows[index2].Cells[1].Value = Conversion.Val(this.testtotal) + Conversion.Val(num9) + Conversion.Val(num10) + Conversion.Val(num11) + Conversion.Val(num12);
                this.testtotal = 0.0;
                this.commiTotal = 0.0;
                this.SelfTotal = 0.0;
                this.AgentTotal = 0.0;
                this.PatnerTotal = 0.0;
                this.Save_All_Data();
                this.update_Decleard();
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

        // Token: 0x06002323 RID: 8995 RVA: 0x003B9FCC File Offset: 0x003B83CC
        public void update_Decleard()
        {
            try
            {
                string cmdText = $"update  Newmatch set Result='Declared', Remark='{this.txtmatch.Text}' where Sr_No={Conversions.ToString(Module1.Matchdecalerd)}";
                using (MatchService matchService = new MatchService())
                {
                    Module1.conn.Close();
                    matchService.Update(cmdText);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002324 RID: 8996 RVA: 0x003BA08C File Offset: 0x003B848C
        public void Save_All_Data()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, "0", false))
                            {
                                if (Module1.conn.State == ConnectionState.Closed)
                                {
                                    Module1.conn.Open();
                                }
                                string right = string.Concat(new string[]
                                {
                                    Conversions.ToString(Module1.Matchdecalerd),
                                    " - ",
                                    this.txttem1.Text,
                                    " VS ",
                                    this.txttem2.Text
                                });
                                string cmdText = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time)VALUES('{dataGridViewRow.Cells[0].Value}',{dataGridViewRow.Cells[1].Value},'{right}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    Module1.conn.Close();
                                    transactionService.Insert(cmdText);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                try
                {
                    foreach (object obj2 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells[3].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells[3].Value, "0", false))
                            {
                                if (Module1.conn.State == ConnectionState.Closed)
                                {
                                    Module1.conn.Open();
                                }
                                string right2 = string.Concat(new string[]
                                {
                                    "Commission ",
                                    Conversions.ToString(Module1.Matchdecalerd),
                                    " - ",
                                    this.txttem1.Text,
                                    " VS ",
                                    this.txttem2.Text
                                });
                                string cmdText2 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time)VALUES('{dataGridViewRow2.Cells[0].Value}',{dataGridViewRow2.Cells[3].Value},'{right2}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    Module1.conn.Close();
                                    transactionService.Insert(cmdText2);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                try
                {
                    foreach (object obj3 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells[5].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells[5].Value, "0", false))
                            {
                                string right3 = string.Concat(new string[]
                                {
                                    "Self LD ",
                                    Conversions.ToString(Module1.Matchdecalerd),
                                    " - ",
                                    this.txttem1.Text,
                                    " VS ",
                                    this.txttem2.Text
                                });
                                string cmdText3 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time)VALUES('{dataGridViewRow3.Cells[0].Value}',{ dataGridViewRow3.Cells[5].Value},'{right3}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    Module1.conn.Close();
                                    transactionService.Insert(cmdText3);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                try
                {
                    foreach (object obj4 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells[7].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells[7].Value, "0", false))
                            {
                                string right4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Agent LD ", dataGridViewRow4.Cells[0].Value), " "), Module1.Matchdecalerd), " - "), this.txttem1.Text), " VS "), this.txttem2.Text));
                                string cmdText4 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time)VALUES('{dataGridViewRow4.Cells[6].Value}',{dataGridViewRow4.Cells[7].Value},'{right4}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    Module1.conn.Close();
                                    transactionService.Insert(cmdText4);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                try
                {
                    foreach (object obj5 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj5;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow5.Cells[9].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow5.Cells[9].Value, "0", false))
                            {
                                string right5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ThirdParty LD ", dataGridViewRow5.Cells[0].Value), " "), Module1.Matchdecalerd), " - "), this.txttem1.Text), " VS "), this.txttem2.Text));
                                string cmdText5 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time)VALUES('{dataGridViewRow5.Cells[8].Value}',{dataGridViewRow5.Cells[9].Value},'{right5}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    Module1.conn.Close();
                                    transactionService.Insert(cmdText5);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
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

        // Token: 0x06002325 RID: 8997 RVA: 0x003BAA64 File Offset: 0x003B8E64
        private void txtmatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmatch.Text, "Abandon", false) == 0)
                {
                    this.typea.Text = "ABDN";
                }
                else if (Operators.CompareString(this.txtmatch.Text, "Tie", false) == 0)
                {
                    this.typea.Text = "Tie";
                }
                else
                {
                    this.typea.Text = "Toss";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002326 RID: 8998 RVA: 0x003BAAD8 File Offset: 0x003B8ED8
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x04000D95 RID: 3477
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000D96 RID: 3478
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x04000D97 RID: 3479
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000D98 RID: 3480
        [AccessedThroughProperty("txtmatch")]
        private ComboBox _txtmatch;

        // Token: 0x04000D99 RID: 3481
        [AccessedThroughProperty("lbldisply")]
        private Label _lbldisply;

        // Token: 0x04000D9A RID: 3482
        [AccessedThroughProperty("DataGridView3")]
        private DataGridView _DataGridView3;

        // Token: 0x04000D9B RID: 3483
        [AccessedThroughProperty("DataGridViewTextBoxColumn13")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;

        // Token: 0x04000D9C RID: 3484
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;

        // Token: 0x04000D9D RID: 3485
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;

        // Token: 0x04000D9E RID: 3486
        [AccessedThroughProperty("Column13")]
        private DataGridViewTextBoxColumn _Column13;

        // Token: 0x04000D9F RID: 3487
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;

        // Token: 0x04000DA0 RID: 3488
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;

        // Token: 0x04000DA1 RID: 3489
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;

        // Token: 0x04000DA2 RID: 3490
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;

        // Token: 0x04000DA3 RID: 3491
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;

        // Token: 0x04000DA4 RID: 3492
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;

        // Token: 0x04000DA5 RID: 3493
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;

        // Token: 0x04000DA6 RID: 3494
        [AccessedThroughProperty("DataGridView2")]
        private DataGridView _DataGridView2;

        // Token: 0x04000DA7 RID: 3495
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;

        // Token: 0x04000DA8 RID: 3496
        [AccessedThroughProperty("txtdate")]
        private DateTimePicker _txtdate;

        // Token: 0x04000DA9 RID: 3497
        [AccessedThroughProperty("typea")]
        private TextBox _typea;

        // Token: 0x04000DAA RID: 3498
        [AccessedThroughProperty("DataSRHI")]
        private DataGridView _DataSRHI;

        // Token: 0x04000DAB RID: 3499
        [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

        // Token: 0x04000DAC RID: 3500
        [AccessedThroughProperty("DataGridViewTextBoxColumn11")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

        // Token: 0x04000DAD RID: 3501
        [AccessedThroughProperty("DataGridViewTextBoxColumn12")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;

        // Token: 0x04000DAE RID: 3502
        [AccessedThroughProperty("DataPatner")]
        private DataGridView _DataPatner;

        // Token: 0x04000DAF RID: 3503
        [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

        // Token: 0x04000DB0 RID: 3504
        [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

        // Token: 0x04000DB1 RID: 3505
        [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

        // Token: 0x04000DB2 RID: 3506
        [AccessedThroughProperty("DataAgent")]
        private DataGridView _DataAgent;

        // Token: 0x04000DB3 RID: 3507
        [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

        // Token: 0x04000DB4 RID: 3508
        [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

        // Token: 0x04000DB5 RID: 3509
        [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

        // Token: 0x04000DB6 RID: 3510
        [AccessedThroughProperty("Dataself")]
        private DataGridView _Dataself;

        // Token: 0x04000DB7 RID: 3511
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

        // Token: 0x04000DB8 RID: 3512
        [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

        // Token: 0x04000DB9 RID: 3513
        [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

        // Token: 0x04000DBA RID: 3514
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;

        // Token: 0x04000DBB RID: 3515
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;

        // Token: 0x04000DBC RID: 3516
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;

        // Token: 0x04000DBD RID: 3517
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;

        // Token: 0x04000DBE RID: 3518
        [AccessedThroughProperty("txttem4")]
        private TextBox _txttem4;

        // Token: 0x04000DBF RID: 3519
        [AccessedThroughProperty("txttem3")]
        private TextBox _txttem3;

        // Token: 0x04000DC0 RID: 3520
        [AccessedThroughProperty("txttem2")]
        private TextBox _txttem2;

        // Token: 0x04000DC1 RID: 3521
        [AccessedThroughProperty("txttem1")]
        private TextBox _txttem1;

        // Token: 0x04000DC2 RID: 3522
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;

        // Token: 0x04000DC3 RID: 3523
        private TextBox TeamFoumula;

        // Token: 0x04000DC4 RID: 3524
        private double testtotal;

        // Token: 0x04000DC5 RID: 3525
        private double commiTotal;

        // Token: 0x04000DC6 RID: 3526
        private double SelfTotal;

        // Token: 0x04000DC7 RID: 3527
        private double AgentTotal;

        // Token: 0x04000DC8 RID: 3528
        private double PatnerTotal;

        // Token: 0x04000DC9 RID: 3529
        private double selfp;

        // Token: 0x04000DCA RID: 3530
        private double agentp;

        // Token: 0x04000DCB RID: 3531
        private double patnerp;

        // Token: 0x04000DCD RID: 3533
        private double total;

        // Token: 0x04000DCE RID: 3534
        private object sri;
    }
}
