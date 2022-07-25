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
    // Token: 0x0200004B RID: 75
    //[DesignerGenerated]
    public partial class frommatchDecleard : Form
    {
        string strTime = "";
        // Token: 0x06001382 RID: 4994 RVA: 0x00349DC8 File Offset: 0x003481C8
        public frommatchDecleard()
        {
            this.InitializeComponent();
        }

        // Token: 0x060013ED RID: 5101 RVA: 0x0034BBC8 File Offset: 0x00349FC8
        private void frommatchDecleard_Load(object sender, EventArgs e)
        {
            try
            {
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

        // Token: 0x060013EE RID: 5102 RVA: 0x0034BC6C File Offset: 0x0034A06C
        public void match_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select* from Newmatch where Sr_No=" + Conversions.ToString(Module1.Matchdecalerd);
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
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
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[4], "TEST", false))
                    {
                        this.txtdate.Text = oleDbDataReader["Date1"].ToString();
                        strTime = oleDbDataReader["entry_time"].ToString();
                        this.txtmatch.Items.Add("Abandon");
                        this.txtmatch.Items.Add("Tie");
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

        // Token: 0x060013EF RID: 5103 RVA: 0x0034BED4 File Offset: 0x0034A2D4
        public void Name_lode()
        {
            try
            {
                //this.DataGridView2.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select* from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Id"], "1", false))
                    {
                        this.sri = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                    }
                    //else if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["Id"], "2", false))
                    //{
                    //	if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["Id"], "3", false))
                    //	{
                    //		int index = this.DataGridView2.Rows.Add();
                    //		this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                    //	}
                    //}
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

        // Token: 0x060013F0 RID: 5104 RVA: 0x0034C024 File Offset: 0x0034A424
        public void SRHI1()
        {
            try
            {
                int num = 0;
                double num4 = 0;
                double num8 = 0;
                double num12 = 0;
                double num15 = 0;
                checked
                {
                    int num2 = this.DataGridView1.RowCount - 1;
                    double num3 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[1].Value));
                        }
                    }
                    if (num3 != Convert.ToDouble("0"))
                    {
                        num4 = unchecked(Conversion.Val(num3.ToString()) - Conversion.Val(num3.ToString()) - Conversion.Val(num3.ToString()));
                    }
                    int num5 = 0;
                    int num6 = this.DataSelf.RowCount - 1;
                    double num7 = 0;
                    for (int j = num5; j <= num6; j++)
                    {
                        unchecked
                        {
                            num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataSelf.Rows[j].Cells[1].Value));
                        }
                    }
                    if (num7 != Convert.ToDouble("0"))
                    {
                        num8 = unchecked(Conversion.Val(num7.ToString()) - Conversion.Val(num7.ToString()) - Conversion.Val(num7.ToString()));
                    }
                    int num9 = 0;
                    int num10 = this.DataAgent.RowCount - 1;
                    double num11 = 0;
                    for (int k = num9; k <= num10; k++)
                    {
                        unchecked
                        {
                            num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataAgent.Rows[k].Cells[1].Value));
                        }
                    }
                    if (num11 != Convert.ToDouble("0"))
                    {
                        num12 = unchecked(Conversion.Val(num11.ToString()) - Conversion.Val(num11.ToString()) - Conversion.Val(num11.ToString()));
                    }
                    int num13 = 0;
                    int num14 = this.DataThirdParty.RowCount - 1;
                    for (int l = num13; l <= num14; l++)
                    {
                        unchecked
                        {
                            num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataThirdParty.Rows[l].Cells[1].Value));
                        }
                    }
                }
                double num16 = 0;
                if (num15 != Convert.ToDouble("0"))
                {
                    num16 = Conversion.Val(num15.ToString()) - Conversion.Val(num15.ToString()) - Conversion.Val(num15.ToString());
                }
                this.DataSRHI.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.sri);
                this.DataSRHI.Rows[0].Cells[1].Value = Conversion.Val(num4) + Conversion.Val(num8) + Conversion.Val(num12) + Conversion.Val(num16);
                this.DataSRHI.Rows[0].Cells[2].Value = string.Concat(new string[]
                {
                    Conversions.ToString(Module1.Matchdecalerd),
                    "-",
                    this.txttem1.Text,
                    " vs ",
                    this.txttem2.Text
                });
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x060013F1 RID: 5105 RVA: 0x0034C36C File Offset: 0x0034A76C
        public void ABDN_sum()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                this.DataSelf.Rows.Clear();
                this.DataAgent.Rows.Clear();
                this.DataThirdParty.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.SAbandon, PartyMaster.AParty, PartyMaster.AAbandon, PartyMaster.TParty, PartyMaster.TAbandon, SUM(Abdntie.ABDN) AS Expr1, Abdntie.Delete_CHK, Abdntie.Match_ID, PartyMaster.PartyName FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.SAbandon, PartyMaster.AParty, PartyMaster.AAbandon, PartyMaster.TParty, PartyMaster.TAbandon, Abdntie.Delete_CHK, Abdntie.Match_ID, PartyMaster.PartyName HAVING        (Abdntie.Match_ID = " + Conversions.ToString(Module1.Matchdecalerd) + ") AND (Abdntie.Delete_CHK = '0')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    if (num != 0)
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num);
                        this.DataGridView1.Rows[index].Cells[2].Value = string.Concat(new string[]
                        {
                            "ABDN - ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            " - ",
                            this.txttem1.Text,
                            " VS ",
                            this.txttem2.Text
                        });
                        double num2 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SAbandon"]));
                        int index2 = this.DataSelf.Rows.Add();
                        this.DataSelf.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        this.DataSelf.Rows[index2].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num2);
                        this.DataSelf.Rows[index2].Cells[2].Value = string.Concat(new string[]
                        {
                            "ABDN - Self LD ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            "-",
                            this.txttem1.Text,
                            " vs ",
                            this.txttem2.Text
                        });

                        object objectValue = RuntimeHelpers.GetObjectValue(oleDbDataReader["AParty"]);
                        double afterld = Conversion.Val(num2) * Conversion.Val(num) - Conversion.Val(num);
                        afterld = Conversion.Val(afterld) - Conversion.Val(afterld) - Conversion.Val(afterld);

                        if (!Operators.ConditionalCompareObjectEqual(objectValue, null, false))
                        {
                            double num3 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AAbandon"]));
                            int index3 = this.DataAgent.Rows.Add();
                            this.DataAgent.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(objectValue);
                            this.DataAgent.Rows[index3].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num3);
                            this.DataAgent.Rows[index3].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ABDN - Agent LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                        object objectValue2 = RuntimeHelpers.GetObjectValue(oleDbDataReader["TParty"]);
                        if (!Operators.ConditionalCompareObjectEqual(objectValue2, null, false))
                        {
                            double num4 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TAbandon"]));
                            int index4 = this.DataThirdParty.Rows.Add();
                            this.DataThirdParty.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(objectValue2);
                            this.DataThirdParty.Rows[index4].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num4);
                            this.DataThirdParty.Rows[index4].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ABDN - ThirdParty LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                    }
                }
                this.SRHI1();
                this.grid1();
                this.grid2();
                this.grid3();
                this.grid4();
                this.grid5();
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

        // Token: 0x060013F2 RID: 5106 RVA: 0x0034C994 File Offset: 0x0034AD94
        public void Tie_sum()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                this.DataSelf.Rows.Clear();
                this.DataAgent.Rows.Clear();
                this.DataThirdParty.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.AParty, PartyMaster.TParty, Abdntie.Delete_CHK, Abdntie.Match_ID, PartyMaster.PartyName, SUM(Abdntie.Tie) AS Expr1, PartyMaster.TTie, PartyMaster.ATie, PartyMaster.STie FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.AParty, PartyMaster.TParty, Abdntie.Delete_CHK, Abdntie.Match_ID, PartyMaster.PartyName, PartyMaster.TTie, PartyMaster.ATie, PartyMaster.STie HAVING (Abdntie.Match_ID = " + Conversions.ToString(Module1.Matchdecalerd) + ") AND (Abdntie.Delete_CHK = '0')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    if (num != 0)
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num);
                        this.DataGridView1.Rows[index].Cells[2].Value = string.Concat(new string[]
                        {
                            "Tie - ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            " - ",
                            this.txttem1.Text,
                            " VS ",
                            this.txttem2.Text
                        });
                        double num2 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["STie"]));
                        int index2 = this.DataSelf.Rows.Add();
                        this.DataSelf.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        this.DataSelf.Rows[index2].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num2);
                        this.DataSelf.Rows[index2].Cells[2].Value = string.Concat(new string[]
                        {
                            "Tie - Self LD ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            "-",
                            this.txttem1.Text,
                            " vs ",
                            this.txttem2.Text
                        });

                        object objectValue = RuntimeHelpers.GetObjectValue(oleDbDataReader["AParty"]);
                        double afterld = Conversion.Val(num2) * Conversion.Val(num) - Conversion.Val(num);
                        afterld = Conversion.Val(afterld) - Conversion.Val(afterld) - Conversion.Val(afterld);

                        if (!Operators.ConditionalCompareObjectEqual(objectValue, null, false))
                        {
                            double num3 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ATie"]));
                            int index3 = this.DataAgent.Rows.Add();
                            this.DataAgent.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(objectValue);
                            this.DataAgent.Rows[index3].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num3);
                            this.DataAgent.Rows[index3].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Tie - Agent LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                        object objectValue2 = RuntimeHelpers.GetObjectValue(oleDbDataReader["TParty"]);
                        if (!Operators.ConditionalCompareObjectEqual(objectValue2, null, false))
                        {
                            double num4 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TTie"]));
                            int index4 = this.DataThirdParty.Rows.Add();
                            this.DataThirdParty.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(objectValue2);
                            this.DataThirdParty.Rows[index4].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num4);
                            this.DataThirdParty.Rows[index4].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Tie - ThirdParty LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }

                    }
                }
                this.update_Decleard();
                this.SRHI1();
                this.grid1();
                this.grid2();
                this.grid3();
                this.grid4();
                this.grid5();
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

        // Token: 0x060013F3 RID: 5107 RVA: 0x0034CFBC File Offset: 0x0034B3BC
        public void update_Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = $"update Newmatch set Result='Declared', Remark='{this.txtmatch.Text}' where Sr_No={Conversions.ToString(Module1.Matchdecalerd)}";
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
                Module1.conn.Close();
            }
        }

        // Token: 0x060013F4 RID: 5108 RVA: 0x0034D07C File Offset: 0x0034B47C
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView3.Rows.Clear();
                if (Operators.CompareString(this.typea.Text, "Match", false) == 0)
                {
                    this.Decliar_New();
                    this.typea.Text = "ABDN";
                    this.ABDN_NON_sum();
                    this.typea.Text = "Tie";
                    this.Tie_NON_sum();
                    //MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
                    //MyProject.Forms.Match_Report.Show();
                    this.Close();
                }
                else if (Operators.CompareString(this.typea.Text, "ABDN", false) == 0)
                {
                    this.ABDN_sum();
                    this.Tie_NON_sum();
                    //MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
                    //MyProject.Forms.Match_Report.Show();
                    this.Close();
                }
                else if (Operators.CompareString(this.typea.Text, "Tie", false) == 0)
                {
                    this.Tie_sum();
                    this.ABDN_NON_sum();
                    //MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
                    //MyProject.Forms.Match_Report.Show();
                    this.Close();
                }
                else
                {
                    Interaction.MsgBox("Please Select Result..", MsgBoxStyle.OkOnly, null);
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

        // Token: 0x060013F5 RID: 5109 RVA: 0x0034D210 File Offset: 0x0034B610
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x060013F6 RID: 5110 RVA: 0x0034D218 File Offset: 0x0034B618
        public void grid1()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{Module1.Matchdecalerd},'{this.txtdate.Text}','{this.typea.Text}','',0,0,'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x060013F7 RID: 5111 RVA: 0x0034D458 File Offset: 0x0034B858
        public void grid2()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataSelf.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{Module1.Matchdecalerd},'{this.txtdate.Text}','{this.typea.Text}','',0,0,'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x060013F8 RID: 5112 RVA: 0x0034D698 File Offset: 0x0034BA98
        public void grid3()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataAgent.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{Module1.Matchdecalerd},'{this.txtdate.Text}','{this.typea.Text}','',0,0,'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x060013F9 RID: 5113 RVA: 0x0034D8D8 File Offset: 0x0034BCD8
        public void grid4()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataThirdParty.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{ RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{Module1.Matchdecalerd},'{this.txtdate.Text}','{this.typea.Text}','',0,0,'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x060013FA RID: 5114 RVA: 0x0034DB14 File Offset: 0x0034BF14
        public void grid5()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataSRHI.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{Module1.Matchdecalerd},'{this.txtdate.Text}','{this.typea.Text}','',0,0,'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
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

        // Token: 0x060013FB RID: 5115 RVA: 0x0034DD6C File Offset: 0x0034C16C
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
                    this.typea.Text = "Match";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x060013FC RID: 5116 RVA: 0x0034DDE0 File Offset: 0x0034C1E0
        public void Party_lode_from_match()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select* from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.ComboBox1.Items.Clear();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["ID"], "1", false))
                    {
                        //if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["ID"], "2", false))
                        //{
                        //	if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["ID"], "3", false))
                        //	{
                        //		if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["ID"], "4", false))
                        //		{
                        this.ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                        //		}
                        //	}
                        //}
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

        // Token: 0x060013FF RID: 5119 RVA: 0x0034E05C File Offset: 0x0034C45C
        public void Save_All_Data()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string right = string.Concat(new string[]
                            {
                                Conversions.ToString(Module1.Matchdecalerd),
                                " - ",
                                this.txttem1.Text,
                                " VS ",
                                this.txttem2.Text
                            });
                            string cmdText = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{ dataGridViewRow.Cells[0].Value}',{ dataGridViewRow.Cells[1].Value},'{ right}','{ Module1.Matchdecalerd}','{ this.txtdate.Text}','{ this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    foreach (object obj2 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells[4].Value, null, false))
                        {
                            string right2 = string.Concat(new string[]
                            {
                                "Self LD ",
                                Conversions.ToString(Module1.Matchdecalerd),
                                " - ",
                                this.txttem1.Text,
                                " VS ",
                                this.txttem2.Text
                            });
                            string cmdText2 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{ dataGridViewRow2.Cells[4].Value}',{ dataGridViewRow2.Cells[5].Value},'{right2}','{ Module1.Matchdecalerd }','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText2);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    foreach (object obj3 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells[2].Value, null, false))
                        {
                            string right3 = string.Concat(new string[]
                            {
                                "Commi Tranfar ",
                                Conversions.ToString(Module1.Matchdecalerd),
                                " - ",
                                this.txttem1.Text,
                                " VS ",
                                this.txttem2.Text
                            });
                            string cmdText3 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{dataGridViewRow3.Cells[2].Value}',{dataGridViewRow3.Cells[3].Value},'{right3}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText3);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    foreach (object obj4 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells[6].Value, null, false))
                        {
                            string right4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Agent LD ", dataGridViewRow4.Cells[0].Value), " "), Module1.Matchdecalerd), " - "), this.txttem1.Text), " VS "), this.txttem2.Text));
                            string cmdText4 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{dataGridViewRow4.Cells[6].Value}',{dataGridViewRow4.Cells[7].Value},'{right4}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText4);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    foreach (object obj5 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj5;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow5.Cells[8].Value, null, false))
                        {
                            string right5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ThirdParty LD ", dataGridViewRow5.Cells[0].Value), " "), Module1.Matchdecalerd), " - "), this.txttem1.Text), " VS "), this.txttem2.Text));
                            string cmdText5 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{dataGridViewRow5.Cells[8].Value}',{dataGridViewRow5.Cells[9].Value},'{right5}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText5);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    foreach (object obj6 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow6 = (DataGridViewRow)obj6;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow6.Cells[10].Value, null, false))
                        {
                            string right6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Commission ", dataGridViewRow6.Cells[0].Value), " "), Module1.Matchdecalerd), " - "), this.txttem1.Text), " VS "), this.txttem2.Text));
                            string cmdText6 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{dataGridViewRow6.Cells[10].Value}',{dataGridViewRow6.Cells[11].Value},'{right6}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText6);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    foreach (object obj7 in ((IEnumerable)this.DataGridView3.Rows))
                    {
                        DataGridViewRow dataGridViewRow7 = (DataGridViewRow)obj7;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow7.Cells[12].Value, null, false))
                        {
                            string right7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Commission ", dataGridViewRow7.Cells[0].Value), " "), Module1.Matchdecalerd), " - "), this.txttem1.Text), " VS "), this.txttem2.Text));
                            string cmdText7 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{dataGridViewRow7.Cells[12].Value}',{dataGridViewRow7.Cells[13].Value},'{right7}','{Module1.Matchdecalerd}','{this.txtdate.Text}','{this.typea.Text}','','0','0',0,'No','','0','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText7);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001400 RID: 5120 RVA: 0x0034ED24 File Offset: 0x0034D124
        public void Decliar_New()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT DISTINCT PartyMaster.PartyName FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = " + Conversions.ToString(Module1.Matchdecalerd) + ") ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    string text = oleDbDataReader["PartyName"].ToString();

                    string cmdText2 = string.Concat(new string[]
                    {
                        "SELECT * FROM (",
                        "SELECT PartyMaster.SMatchCommi, PartyMaster.AMatchCommi, PartyMaster.TMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, MatchTrans.m_id, PartyMaster.Status, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.AMatchCommi, PartyMaster.TMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, MatchTrans.m_checked, MatchTrans.m_id, PartyMaster.Status, PartyMaster.MatchCommiType HAVING (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = ",
                        Conversions.ToString(Module1.Matchdecalerd),
                        ") AND (PartyMaster.PartyName = '",
                        text,
                        "') AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus'))",
                        " UNION ALL ",
                        "SELECT PartyMaster.SMatchCommi, PartyMaster.AMatchCommi, PartyMaster.TMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, MatchTrans.m_id, PartyMaster.Status, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = ",
                        Conversions.ToString(Module1.Matchdecalerd),
                        ") AND (PartyMaster.PartyName = '",
                        text,
                        "') AND (PartyMaster.MatchCommiType IN ('Entry Wise'))",
                        ") ORDER BY PartyName"

                    });
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();

                    while (oleDbDataReader2.Read())
                    {
                        double smatch = Convert.ToDouble(oleDbDataReader2["SMatch"].ToString());
                        double amatch = Convert.ToDouble(oleDbDataReader2["AMatch"].ToString());
                        double tmatch = Convert.ToDouble(oleDbDataReader2["TMatch"].ToString());
                        double num4 = Conversion.Val(amatch) + Conversion.Val(tmatch);
                        double smatchcommi = Convert.ToDouble(oleDbDataReader2["SMatchCommi"].ToString());
                        double amatchcommi = Convert.ToDouble(oleDbDataReader2["AMatchCommi"].ToString());
                        double tmatchcommi = Convert.ToDouble(oleDbDataReader2["TMatchCommi"].ToString());
                        double totalcommi = Conversion.Val(smatchcommi) + Conversion.Val(amatchcommi) + Conversion.Val(tmatchcommi);

                        string party = oleDbDataReader2["PartyName"].ToString();
                        string aparty = oleDbDataReader2["AParty"].ToString();
                        string tparty = oleDbDataReader2["TParty"].ToString();
                        string status = oleDbDataReader2["Status"].ToString();

                        double num6 = 0;
                        if (Operators.CompareString(this.txttem1.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReader2["Expr1"]);
                        else if (Operators.CompareString(this.txttem2.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReader2["Expr2"]);
                        else if (Operators.CompareString(this.txttem3.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReader2["Expr3"]);
                        else if (Operators.CompareString(this.txttem4.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReader2["Expr4"]);

                        int index = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index].Cells[0].Value = party;
                        this.DataGridView3.Rows[index].Cells[1].Value = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
                        this.DataGridView3.Rows[index].Cells[4].Value = party;
                        this.DataGridView3.Rows[index].Cells[5].Value = Conversion.Val(num6) * Conversion.Val(smatch) / 100;

                        double afterldamt;
                        //afterldamt = (Conversion.Val(num6) * Conversion.Val(smatch) / 100) - Conversion.Val(num6); //Regular
                        afterldamt = Conversion.Val(num6) - (Conversion.Val(num6) * Conversion.Val(smatch) / 100); //Booky

                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            if (num6 < 0)
                            {
                                this.DataGridView3.Rows[index].Cells[2].Value = party;
                                double num8 = Conversion.Val(afterldamt) * Conversion.Val(smatchcommi) / 100;
                                this.DataGridView3.Rows[index].Cells[3].Value = Conversion.Val(num8); // - Conversion.Val(num8) - Conversion.Val(num8);								
                            }

                            if (Operators.CompareString(aparty, null, false) != 0)
                            {
                                if (num6 < 0)
                                {
                                    this.DataGridView3.Rows[index].Cells[6].Value = aparty;
                                    double num101 = Conversion.Val(afterldamt) * Conversion.Val(amatch) / 100;
                                    double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt) * Conversion.Val(amatchcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(num111);// - Conversion.Val(num111) - Conversion.Val(num111);
                                    this.DataGridView3.Rows[index].Cells[10].Value = aparty;
                                    double num112 = Conversion.Val(num101) * Conversion.Val(totalcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[11].Value = Conversion.Val(num112);
                                }
                            }

                            if (Operators.CompareString(tparty, null, false) != 0)
                            {
                                if (num6 < 0)
                                {
                                    this.DataGridView3.Rows[index].Cells[8].Value = tparty;
                                    double num101 = Conversion.Val(afterldamt) * Conversion.Val(tmatch) / 100;
                                    double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt) * Conversion.Val(tmatchcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[9].Value = Conversion.Val(num111);// - Conversion.Val(num111) - Conversion.Val(num111);
                                    this.DataGridView3.Rows[index].Cells[12].Value = tparty;
                                    double num112 = Conversion.Val(num101) * Conversion.Val(totalcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[13].Value = Conversion.Val(num112);
                                }
                            }
                        }
                        else if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            if (num6 > 0)
                            {
                                this.DataGridView3.Rows[index].Cells[2].Value = party;
                                double num8 = Conversion.Val(afterldamt) * Conversion.Val(smatchcommi) / 100;
                                this.DataGridView3.Rows[index].Cells[3].Value = Conversion.Val(num8); //- Conversion.Val(num8) - Conversion.Val(num8);
                            }

                            if (Operators.CompareString(aparty, null, false) != 0)
                            {
                                if (num6 > 0)
                                {
                                    this.DataGridView3.Rows[index].Cells[6].Value = aparty;
                                    double num101 = Conversion.Val(afterldamt) * Conversion.Val(amatch) / 100;
                                    double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt) * Conversion.Val(amatchcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(num111);
                                    this.DataGridView3.Rows[index].Cells[10].Value = aparty;
                                    double num112 = Conversion.Val(num101) * Conversion.Val(totalcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[11].Value = Conversion.Val(num112) - Conversion.Val(num112) - Conversion.Val(num112);
                                }
                                else
                                {
                                    this.DataGridView3.Rows[index].Cells[6].Value = aparty;
                                    double num101 = Conversion.Val(afterldamt) * Conversion.Val(amatch) / 100;
                                    this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(num101);
                                }
                            }

                            if (Operators.CompareString(tparty, null, false) != 0)
                            {
                                if (num6 > 0)
                                {
                                    this.DataGridView3.Rows[index].Cells[8].Value = tparty;
                                    double num101 = Conversion.Val(afterldamt) * Conversion.Val(tmatch) / 100;
                                    double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt) * Conversion.Val(tmatchcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[9].Value = Conversion.Val(num111);
                                    this.DataGridView3.Rows[index].Cells[12].Value = tparty;
                                    double num112 = Conversion.Val(num101) * Conversion.Val(totalcommi) / 100;
                                    this.DataGridView3.Rows[index].Cells[13].Value = Conversion.Val(num112) - Conversion.Val(num112) - Conversion.Val(num112);
                                }
                                else
                                {
                                    this.DataGridView3.Rows[index].Cells[8].Value = tparty;
                                    double num101 = Conversion.Val(afterldamt) * Conversion.Val(tmatch) / 100;
                                    this.DataGridView3.Rows[index].Cells[9].Value = Conversion.Val(num101);
                                }
                            }
                        }

                        this.testtotal += Convert.ToDouble(num6);

                        this.SelfTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[5].Value));
                        this.AgentTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[7].Value));
                        this.ThirdPartyTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[9].Value));

                        this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[3].Value));
                        this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[11].Value));
                        this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[13].Value));

                    }
                    oleDbDataReader2.Close();
                    ///For Per Peti Calculation
                    string cmdTextPerPeti = string.Concat(new string[]
                    {
                        "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatch, PartyMaster.SMatchCommi, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TMatch, PartyMaster.TMatchCommi, MatchTrans.m_rate, MatchTrans.m_amt, PartyMaster.Rate FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) ",
                        "WHERE (MatchTrans.m_id = ",
                        Conversions.ToString(Module1.Matchdecalerd),
                        ") AND (PartyMaster.PartyName = '",
                        text,
                        "') AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType = 'Per Peti') "
                    });
                    OleDbCommand oleDbCommandPerPeti = new OleDbCommand(cmdTextPerPeti, Module1.conn);
                    OleDbDataReader oleDbDataReaderPerPeti = oleDbCommandPerPeti.ExecuteReader();

                    while (oleDbDataReaderPerPeti.Read())
                    {
                        string status = Conversions.ToString(oleDbDataReaderPerPeti["Status"]);
                        double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["SMatch"])));
                        double amatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["AMatch"])));
                        double tmatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["TMatch"])));
                        double totalld = amatch + tmatch;

                        double smatchcommi = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["SMatchCommi"]));
                        double amatchcommi = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["AMatchCommi"]));
                        double tmatchcommi = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["TMatchCommi"]));
                        double totalcommi = smatchcommi + amatchcommi + tmatchcommi;

                        double m_rate = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["m_rate"]));
                        double p_rate = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["Rate"]));
                        double m_amt = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderPerPeti["m_amt"]));

                        double totalamt_afterselfld = m_amt - (m_amt * smatch);

                        string party = oleDbDataReaderPerPeti["PartyName"].ToString();
                        string aparty = oleDbDataReaderPerPeti["AParty"].ToString();
                        string tparty = oleDbDataReaderPerPeti["TParty"].ToString();

                        double num6 = 0;
                        if (Operators.CompareString(this.txttem1.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReaderPerPeti["Expr1"]);
                        else if (Operators.CompareString(this.txttem2.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReaderPerPeti["Expr2"]);
                        else if (Operators.CompareString(this.txttem3.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReaderPerPeti["Expr3"]);
                        else if (Operators.CompareString(this.txttem4.Text, this.txtmatch.Text, false) == 0)
                            num6 = Convert.ToDouble(oleDbDataReaderPerPeti["Expr4"]);

                        int index = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index].Cells[0].Value = party;
                        this.DataGridView3.Rows[index].Cells[1].Value = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
                        this.DataGridView3.Rows[index].Cells[4].Value = party;
                        this.DataGridView3.Rows[index].Cells[5].Value = Conversion.Val(num6) * Conversion.Val(smatch);


                        double totalcommiamt = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(totalcommi);
                        if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false))
                        {
                            double exp2_selfld = num6 - (num6 * smatch);
                            double exp2_afterldcommi = exp2_selfld - (exp2_selfld * amatch);

                            if (Operators.CompareString(status, "Booky", false) == 0)
                            {
                                this.DataGridView3.Rows[index].Cells[2].Value = party;
                                double num8 = (Conversion.Val(totalamt_afterselfld) * Conversion.Val(smatchcommi)) / 100000;
                                this.DataGridView3.Rows[index].Cells[3].Value = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);

                                if (Operators.CompareString(aparty, null, false) != 0)
                                {
                                    double numa = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(amatchcommi);
                                    this.DataGridView3.Rows[index].Cells[6].Value = aparty;
                                    exp2_afterldcommi = Conversion.Val(exp2_selfld) * Conversion.Val(amatch);
                                    double numAgent = Conversion.Val(exp2_afterldcommi) + (numa);
                                    this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(numAgent) - Conversion.Val(numAgent) - Conversion.Val(numAgent);
                                    this.DataGridView3.Rows[index].Cells[10].Value = aparty;
                                    double num112 = Conversion.Val(totalcommiamt) * Conversion.Val(amatch);
                                    this.DataGridView3.Rows[index].Cells[11].Value = Conversion.Val(num112) - Conversion.Val(num112) - Conversion.Val(num112);
                                }
                            }
                            else if (Operators.CompareString(status, "Regular", false) == 0)
                            {
                                this.DataGridView3.Rows[index].Cells[2].Value = party;
                                double num8 = (Conversion.Val(totalamt_afterselfld) * Conversion.Val(smatchcommi)) / 100000;
                                this.DataGridView3.Rows[index].Cells[3].Value = Conversion.Val(num8);

                                if (Operators.CompareString(aparty, null, false) != 0)
                                {
                                    double numa = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(amatchcommi);
                                    this.DataGridView3.Rows[index].Cells[6].Value = aparty;
                                    exp2_afterldcommi = Conversion.Val(exp2_selfld) * Conversion.Val(amatch);
                                    this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(exp2_afterldcommi) + (numa);
                                    this.DataGridView3.Rows[index].Cells[10].Value = aparty;
                                    double num112 = Conversion.Val(totalcommiamt) * Conversion.Val(amatch);
                                    this.DataGridView3.Rows[index].Cells[11].Value = Conversion.Val(num112) - Conversion.Val(num112) - Conversion.Val(num112);
                                }

                                if (Operators.CompareString(tparty, null, false) != 0)
                                {
                                    double numt = (Conversion.Val(totalamt_afterselfld) / Conversion.Val(100000)) * Conversion.Val(tmatchcommi);
                                    this.DataGridView3.Rows[index].Cells[8].Value = tparty;
                                    exp2_afterldcommi = Conversion.Val(exp2_selfld) * Conversion.Val(tmatch);
                                    this.DataGridView3.Rows[index].Cells[9].Value = Conversion.Val(exp2_afterldcommi) + (numt);
                                    this.DataGridView3.Rows[index].Cells[12].Value = tparty;
                                    double num112 = Conversion.Val(totalcommiamt) * Conversion.Val(tmatch);
                                    this.DataGridView3.Rows[index].Cells[13].Value = Conversion.Val(num112) - Conversion.Val(num112) - Conversion.Val(num112);
                                }
                            }
                        }

                        this.testtotal += Convert.ToDouble(num6);

                        this.SelfTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[5].Value));
                        this.AgentTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[7].Value));
                        this.ThirdPartyTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[9].Value));

                        this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[3].Value));
                        this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[11].Value));
                        this.commiTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[13].Value));
                    }
                    oleDbDataReaderPerPeti.Close();
                }
                oleDbDataReader.Close();
                string cmdText3 = "select* from PartyMaster Where ID=1";
                OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                OleDbDataReader oleDbDataReader3 = oleDbCommand3.ExecuteReader();
                string text4 = "";
                if (oleDbDataReader3.Read())
                {
                    text4 = oleDbDataReader3["PartyName"].ToString();
                }
                double num11 = Conversion.Val(this.commiTotal) - Conversion.Val(this.commiTotal) - Conversion.Val(this.commiTotal);
                double num12 = Conversion.Val(this.SelfTotal) - Conversion.Val(this.SelfTotal) - Conversion.Val(this.SelfTotal);
                double num13 = Conversion.Val(this.AgentTotal) - Conversion.Val(this.AgentTotal) - Conversion.Val(this.AgentTotal);
                double num14 = Conversion.Val(this.ThirdPartyTotal) - Conversion.Val(this.ThirdPartyTotal) - Conversion.Val(this.ThirdPartyTotal);
                int index2 = this.DataGridView3.Rows.Add();
                this.DataGridView3.Rows[index2].Cells[0].Value = text4.ToString();
                this.DataGridView3.Rows[index2].Cells[1].Value = Conversion.Val(this.testtotal) + Conversion.Val(num11) + Conversion.Val(num12) + Conversion.Val(num13) + Conversion.Val(num14);
                this.testtotal = 0.0;
                this.commiTotal = 0.0;
                this.SelfTotal = 0.0;
                this.AgentTotal = 0.0;
                this.ThirdPartyTotal = 0.0;
                checked
                {
                    for (int i = this.DataGridView3.Rows.Count - 2; i >= 1; i += -1)
                    {
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[i].Cells[2]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[i - 1].Cells[2]).EditedFormattedValue)) & ((DataGridViewTextBoxCell)this.DataGridView3.Rows[i].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[i - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[i].Cells[2].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[i - 1].Cells[3];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[3].Value)), "0.00"));
                            this.DataGridView3.Rows[i].Cells[3].Value = null;
                        }
                    }
                    for (int j = this.DataGridView3.Rows.Count - 2; j >= 1; j += -1)
                    {
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[j].Cells[4]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[j - 1].Cells[4]).EditedFormattedValue)) & ((DataGridViewTextBoxCell)this.DataGridView3.Rows[j].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[j - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[j].Cells[4].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[j - 1].Cells[5];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[j].Cells[5].Value)), "0.00"));
                            this.DataGridView3.Rows[j].Cells[5].Value = null;
                        }
                    }
                    for (int k = this.DataGridView3.Rows.Count - 2; k >= 1; k += -1)
                    {
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[k].Cells[6]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[k - 1].Cells[6]).EditedFormattedValue)) & ((DataGridViewTextBoxCell)this.DataGridView3.Rows[k].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[k - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[k].Cells[6].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[k - 1].Cells[7];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[k].Cells[7].Value)), "0.00"));
                            this.DataGridView3.Rows[k].Cells[7].Value = null;
                        }
                    }
                    for (int l = this.DataGridView3.Rows.Count - 2; l >= 1; l += -1)
                    {
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[l].Cells[8]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[l - 1].Cells[8]).EditedFormattedValue)) & ((DataGridViewTextBoxCell)this.DataGridView3.Rows[l].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[l - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[l].Cells[8].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[l - 1].Cells[9];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[l].Cells[9].Value)), "0.00"));
                            this.DataGridView3.Rows[l].Cells[9].Value = null;
                        }
                    }
                    for (int m = this.DataGridView3.Rows.Count - 2; m >= 1; m += -1)
                    {
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[m].Cells[10]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[m - 1].Cells[10]).EditedFormattedValue)) & ((DataGridViewTextBoxCell)this.DataGridView3.Rows[m].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[m - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[m].Cells[10].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[m - 1].Cells[11];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[m].Cells[11].Value)), "0.00"));
                            this.DataGridView3.Rows[m].Cells[11].Value = null;
                        }
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[m].Cells[12]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[m - 1].Cells[12]).EditedFormattedValue)) & ((DataGridViewTextBoxCell)this.DataGridView3.Rows[m].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[m - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[m].Cells[12].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[m - 1].Cells[13];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[m].Cells[13].Value)), "0.00"));
                            this.DataGridView3.Rows[m].Cells[13].Value = null;
                        }
                    }
                    for (int n = this.DataGridView3.Rows.Count - 2; n >= 1; n += -1)
                    {
                        if (((DataGridViewTextBoxCell)this.DataGridView3.Rows[n].Cells[0]).EditedFormattedValue.Equals(RuntimeHelpers.GetObjectValue(((DataGridViewTextBoxCell)this.DataGridView3.Rows[n - 1].Cells[0]).EditedFormattedValue)))
                        {
                            this.DataGridView3.Rows[n].Cells[0].Value = null;
                            DataGridViewCell dataGridViewCell = this.DataGridView3.Rows[n - 1].Cells[1];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Module1.SetNumFormat(Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[n].Cells[1].Value)), "0.00"));
                            this.DataGridView3.Rows[n].Cells[1].Value = null;
                        }
                    }
                    this.Save_All_Data();
                    this.update_Decleard();
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

        // Token: 0x06001401 RID: 5121 RVA: 0x003506E8 File Offset: 0x0034EAE8
        public void ABDN_NON_sum()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                this.DataSelf.Rows.Clear();
                this.DataAgent.Rows.Clear();
                this.DataThirdParty.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.Status, PartyMaster.SAbandon, PartyMaster.AParty, PartyMaster.AAbandon, PartyMaster.TParty, PartyMaster.TAbandon, SUM(Abdntie.Non_ABDN) AS Expr1, Abdntie.Delete_CHK, Abdntie.Match_ID, PartyMaster.PartyName FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.Status, PartyMaster.SAbandon, PartyMaster.AParty, PartyMaster.AAbandon, PartyMaster.TParty, PartyMaster.TAbandon, Abdntie.Delete_CHK,  Abdntie.Match_ID, PartyMaster.PartyName HAVING (Abdntie.Delete_CHK = '0') AND (Abdntie.Match_ID = " + Conversions.ToString(Module1.Matchdecalerd) + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["Expr1"]);

                    if (num != 0)
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num);
                        this.DataGridView1.Rows[index].Cells[2].Value = string.Concat(new string[]
                        {
                            "ABDN - ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            " - ",
                            this.txttem1.Text,
                            " VS ",
                            this.txttem2.Text
                        });
                        double num2 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["SAbandon"].ToString());
                        int index2 = this.DataSelf.Rows.Add();
                        this.DataSelf.Rows[index2].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        this.DataSelf.Rows[index2].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num2);
                        this.DataSelf.Rows[index2].Cells[2].Value = string.Concat(new string[]
                        {
                            "ABDN - Self LD ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            "-",
                            this.txttem1.Text,
                            " vs ",
                            this.txttem2.Text
                        });


                        object obj = oleDbDataReader["AParty"].ToString();
                        double afterld = Conversion.Val(num2) * Conversion.Val(num) - Conversion.Val(num);
                        afterld = Conversion.Val(afterld) - Conversion.Val(afterld) - Conversion.Val(afterld);

                        if (!Operators.ConditionalCompareObjectEqual(obj, null, false))
                        {
                            double num3 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AAbandon"]));
                            int index3 = this.DataAgent.Rows.Add();
                            this.DataAgent.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(obj);
                            this.DataAgent.Rows[index3].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num3);
                            this.DataAgent.Rows[index3].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ABDN - Agent LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                        object obj2 = oleDbDataReader["TParty"].ToString();
                        if (!Operators.ConditionalCompareObjectEqual(obj2, null, false))
                        {
                            double num4 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TAbandon"]));
                            int index4 = this.DataThirdParty.Rows.Add();
                            this.DataThirdParty.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(obj2);
                            this.DataThirdParty.Rows[index4].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num4);
                            this.DataThirdParty.Rows[index4].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ABDN - ThirdParty LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                    }
                }
                this.typea.Text = "ABDN";
                this.SRHI1();
                this.grid1();
                this.grid2();
                this.grid3();
                this.grid4();
                this.grid5();
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

        // Token: 0x06001402 RID: 5122 RVA: 0x00350D1C File Offset: 0x0034F11C
        public void Tie_NON_sum()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                this.DataSelf.Rows.Clear();
                this.DataAgent.Rows.Clear();
                this.DataThirdParty.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = " SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.STie, PartyMaster.AParty, PartyMaster.ATie, PartyMaster.TParty, PartyMaster.TTie, SUM(Abdntie.Non_Tie)  AS Expr1, Abdntie.Delete_CHK, Abdntie.Match_ID FROM (PartyMaster INNER JOIN  Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.PartyName, PartyMaster.Status, PartyMaster.STie, PartyMaster.AParty, PartyMaster.ATie, PartyMaster.TParty, PartyMaster.TTie, Abdntie.Delete_CHK, Abdntie.Match_ID HAVING (Abdntie.Delete_CHK = '0') AND (Abdntie.Match_ID = " + Conversions.ToString(Module1.Matchdecalerd) + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    if (num != 0)
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num);
                        this.DataGridView1.Rows[index].Cells[2].Value = string.Concat(new string[]
                        {
                            "Tie - ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            " - ",
                            this.txttem1.Text,
                            " VS ",
                            this.txttem2.Text
                        });
                        double num2 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["STie"].ToString());
                        int index2 = this.DataSelf.Rows.Add();
                        this.DataSelf.Rows[index2].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        this.DataSelf.Rows[index2].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num2);
                        this.DataSelf.Rows[index2].Cells[2].Value = string.Concat(new string[]
                        {
                            "Tie - Self LD ",
                            Conversions.ToString(Module1.Matchdecalerd),
                            "-",
                            this.txttem1.Text,
                            " vs ",
                            this.txttem2.Text
                        });

                        object obj = oleDbDataReader["AParty"].ToString();
                        double afterld = Conversion.Val(num2) * Conversion.Val(num) - Conversion.Val(num);
                        afterld = Conversion.Val(afterld) - Conversion.Val(afterld) - Conversion.Val(afterld);

                        if (!Operators.ConditionalCompareObjectEqual(obj, null, false))
                        {
                            double num3 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ATie"]));
                            int index3 = this.DataAgent.Rows.Add();
                            this.DataAgent.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(obj);
                            this.DataAgent.Rows[index3].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num3);
                            this.DataAgent.Rows[index3].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Tie - Agent LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                        object obj2 = oleDbDataReader["TParty"].ToString();
                        if (!Operators.ConditionalCompareObjectEqual(obj2, null, false))
                        {
                            double num4 = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TTie"]));
                            int index4 = this.DataThirdParty.Rows.Add();
                            this.DataThirdParty.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(obj2);
                            this.DataThirdParty.Rows[index4].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num4);
                            this.DataThirdParty.Rows[index4].Cells[2].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Tie - ThirdParty LD ", oleDbDataReader["PartyName"]), "  "), Module1.Matchdecalerd), "-"), this.txttem1.Text), " vs "), this.txttem2.Text);
                        }
                    }
                }
                this.typea.Text = "ABDN";
                this.SRHI1();
                this.grid1();
                this.grid2();
                this.grid3();
                this.grid4();
                this.grid5();
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

        // Token: 0x06001403 RID: 5123 RVA: 0x00351350 File Offset: 0x0034F750
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //	if (this.ComboBox1.SelectedIndex < checked(this.ComboBox1.Items.Count - 1))
            //	{
            //		this.ComboBox1.SelectedIndex = checked(this.ComboBox1.SelectedIndex + 1);
            //		if (Module1.conn.State == ConnectionState.Closed)
            //		{
            //			Module1.conn.Open();
            //		}
            //		string cmdText = "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, MatchTrans.m_id, MatchTrans.m_team FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, MatchTrans.m_checked, MatchTrans.m_id,  MatchTrans.m_team HAVING (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = " + Conversions.ToString(Module1.Matchdecalerd) + ")";
            //		OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
            //		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            //		while (oleDbDataReader.Read())
            //		{
            //			double num = Convert.ToDouble(oleDbDataReader["SMatchCommi"]);
            //			double num2 = Convert.ToDouble(oleDbDataReader["SMatch"]);
            //			double num3 = Convert.ToDouble(oleDbDataReader["AMatch"]);
            //			double num4 = Convert.ToDouble(oleDbDataReader["TMatch"]);
            //			string value = Conversions.ToString(oleDbDataReader["AParty"]);
            //			string value2 = Conversions.ToString(oleDbDataReader["TParty"]);
            //			double num5 = 0;
            //			if (Operators.CompareString(this.txttem1.Text, this.txtmatch.Text, false) == 0)
            //			{
            //				num5 = Convert.ToDouble(oleDbDataReader["Expr1"]);
            //			}
            //			else if (Operators.CompareString(this.txttem2.Text, this.txtmatch.Text, false) == 0)
            //			{
            //				num5 = Convert.ToDouble(oleDbDataReader["Expr2"]);
            //			}
            //			else if (Operators.CompareString(this.txttem3.Text, this.txtmatch.Text, false) == 0)
            //			{
            //				num5 = Convert.ToDouble(oleDbDataReader["Expr3"]);
            //			}
            //			else if (Operators.CompareString(this.txttem4.Text, this.txtmatch.Text, false) == 0)
            //			{
            //				num5 = Convert.ToDouble(oleDbDataReader["Expr4"]);
            //			}
            //			int index = this.DataGridView3.Rows.Add();
            //			this.DataGridView3.Rows[index].Cells[0].Value = this.ComboBox1.Text;
            //			this.DataGridView3.Rows[index].Cells[1].Value = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
            //			double num6 = 0;
            //			if (num5 > 0.0)
            //			{
            //				this.DataGridView3.Rows[index].Cells[2].Value = this.ComboBox1.Text;
            //				num6 = Conversion.Val(num5) * Conversion.Val(num) / 100;
            //				this.DataGridView3.Rows[index].Cells[3].Value = num6;
            //			}
            //			double num7 = Conversion.Val(num5) - Conversion.Val(num6);
            //			this.DataGridView3.Rows[index].Cells[4].Value = this.ComboBox1.Text;
            //			this.DataGridView3.Rows[index].Cells[5].Value = Conversion.Val(num7) * Conversion.Val(num2) / 100;
            //			this.DataGridView3.Rows[index].Cells[6].Value = value;
            //			this.DataGridView3.Rows[index].Cells[7].Value = Conversion.Val(num7) * Conversion.Val(num3) / 100;
            //			this.DataGridView3.Rows[index].Cells[8].Value = value2;
            //			this.DataGridView3.Rows[index].Cells[9].Value = Conversion.Val(num7) * Conversion.Val(num4) / 100;
            //			this.testtotal += Convert.ToDouble(num5);
            //			this.commiTotal += Convert.ToDouble(num6);
            //			this.SelfTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[5].Value));
            //			this.AgentTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[7].Value));
            //			this.ThirdPartyTotal += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[9].Value));
            //		}
            //		this.Timer1.Enabled = false;
            //		string cmdText2 = "select* from PartyMaster Where ID=1";
            //		OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
            //		OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
            //		string value3 = "";
            //		if (oleDbDataReader2.Read())
            //		{
            //			value3 = Conversions.ToString(oleDbDataReader2["PartyName"]);
            //		}
            //		int index2 = this.DataGridView3.Rows.Add();
            //		this.DataGridView3.Rows[index2].Cells[0].Value = value3;
            //		this.DataGridView3.Rows[index2].Cells[1].Value = this.testtotal;
            //		this.DataGridView3.Rows[index2].Cells[2].Value = value3;
            //		this.DataGridView3.Rows[index2].Cells[3].Value = this.commiTotal - this.commiTotal - this.commiTotal;
            //		this.DataGridView3.Rows[index2].Cells[4].Value = value3;
            //		this.DataGridView3.Rows[index2].Cells[5].Value = this.SelfTotal - this.SelfTotal - this.SelfTotal;
            //		this.DataGridView3.Rows[index2].Cells[6].Value = value3;
            //		this.DataGridView3.Rows[index2].Cells[7].Value = this.AgentTotal - this.AgentTotal - this.AgentTotal;
            //		this.DataGridView3.Rows[index2].Cells[8].Value = value3;
            //		this.DataGridView3.Rows[index2].Cells[9].Value = this.ThirdPartyTotal - this.ThirdPartyTotal - this.ThirdPartyTotal;
            //		this.testtotal = 0.0;
            //		this.commiTotal = 0.0;
            //		this.SelfTotal = 0.0;
            //		this.AgentTotal = 0.0;
            //		this.ThirdPartyTotal = 0.0;
            //		this.Save_All_Data();
            //		this.update_Decleard();
            //		this.Close();
            //		MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
            //		MyProject.Forms.Match_Report.Show();
            //	}
            //}
            //catch (Exception ex)
            //{
            //	Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            //}
            //finally
            //{
            //	Module1.conn.Close();
            //}
        }

        // Token: 0x0400084A RID: 2122
        private double testtotal;

        // Token: 0x0400084B RID: 2123
        private double commiTotal;

        // Token: 0x0400084C RID: 2124
        private double SelfTotal;

        // Token: 0x0400084D RID: 2125
        private double AgentTotal;

        // Token: 0x0400084E RID: 2126
        private double ThirdPartyTotal;

        // Token: 0x04000854 RID: 2132
        private object sri;
    }
}
