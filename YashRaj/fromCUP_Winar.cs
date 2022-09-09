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
    public partial class fromCUP_Winar : Form
    {
        public fromCUP_Winar()
        {
            this.InitializeComponent();
        }

        private void fromCUP_Winar_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnSave.Focus();
                this.txtid.Text = Conversions.ToString(Module1.IDCUP);
                this.DataGridView5.Rows.Add(new object[]
                {
                ""
                });
                this.DataGridView5.Rows.Add(new object[]
                {
                ""
                });
                this.DataGridView5.Rows.Add(new object[]
                {
                ""
                });
                this.DataGridView5.Rows.Add(new object[]
                {
                ""
                });
                this.DataGridView5.Rows.Add(new object[]
                {
                ""
                });
                this.lodTeam_ALL();
                this.name_lode();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600136C RID: 4972 RVA: 0x00345E24 File Offset: 0x00344224
        public void name_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT Id, PartyName FROM PartyMaster WHERE(ID = 1)";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.SRHINAME = oleDbDataReader["PartyName"].ToString();
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

        // Token: 0x0600136D RID: 4973 RVA: 0x00345EC4 File Offset: 0x003442C4
        public void lodTeam_ALL()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Newmatch where Sr_No=" + this.txtid.Text + "";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.DateTime.Text = oleDbDataReader["Date1"].ToString();
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[5], null, false))
                    {
                        this.txt1.Text = Conversions.ToString(oleDbDataReader[5]);                        
                        this.ComboBox1.Items.Add(this.txt1.Text);
                    }
                    if (Operators.CompareString(oleDbDataReader[6].ToString(), null, false) != 0)
                    {
                        this.txt2.Text = Conversions.ToString(oleDbDataReader[6]);
                        this.ComboBox1.Items.Add(this.txt2.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[7], null, false))
                    {
                        this.txt3.Text = Conversions.ToString(oleDbDataReader[7]);
                        this.ComboBox1.Items.Add(this.txt3.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[8], null, false))
                    {
                        this.txt4.Text = Conversions.ToString(oleDbDataReader[8]);
                        this.ComboBox1.Items.Add(this.txt4.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[9], null, false))
                    {
                        this.txt5.Text = Conversions.ToString(oleDbDataReader[9]);
                        this.ComboBox1.Items.Add(this.txt5.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[10], null, false))
                    {
                        this.txt6.Text = Conversions.ToString(oleDbDataReader[10]);
                        this.ComboBox1.Items.Add(this.txt6.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[11], null, false))
                    {
                        this.txt7.Text = Conversions.ToString(oleDbDataReader[11]);
                        this.ComboBox1.Items.Add(this.txt7.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[12], null, false))
                    {
                        this.txt8.Text = Conversions.ToString(oleDbDataReader[12]);
                        this.ComboBox1.Items.Add(this.txt8.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[13], null, false))
                    {
                        this.txt9.Text = Conversions.ToString(oleDbDataReader[13]);
                        this.ComboBox1.Items.Add(this.txt9.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[14], null, false))
                    {
                        this.txt10.Text = Conversions.ToString(oleDbDataReader[14]);
                        this.ComboBox1.Items.Add(this.txt10.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], null, false))
                    {
                        this.txt11.Text = Conversions.ToString(oleDbDataReader[15]);
                        this.ComboBox1.Items.Add(this.txt11.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], null, false))
                    {
                        this.txt12.Text = Conversions.ToString(oleDbDataReader[16]);
                        this.ComboBox1.Items.Add(this.txt12.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[17], null, false))
                    {
                        this.txt13.Text = Conversions.ToString(oleDbDataReader[17]);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[18], null, false))
                    {
                        this.txt14.Text = Conversions.ToString(oleDbDataReader[18]);
                        this.ComboBox1.Items.Add(this.txt14.Text);
                    }
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[19], null, false))
                    {
                        this.txt15.Text = Conversions.ToString(oleDbDataReader[19]);                        
                        this.ComboBox1.Items.Add(this.txt15.Text);
                    }                    
                }
                this.Non_Tem_Out();
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

        public void Non_Tem_Out()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT distinct m_team FROM (CupTrans) WHERE (m_id = ",
                    this.txtid.Text,                    
                    " AND m_tem_out = 1",
                    ")"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.ComboBox1.Items.Remove(oleDbDataReader["m_team"]);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBox1.Text == "")
                {
                    Interaction.MsgBox("Please Select Team First.", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    this.Button2.Enabled = false;
                    if (this.CheckBox1.Checked)
                    {
                        this.Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
                        string cmdText = $"UPDATE CupTrans SET M_Tem_Out = 1 WHERE m_id = {this.txtid.Text} ";
                        using (CupService cupService = new CupService())
                        {
                            cupService.Update(cmdText);
                        }
                    }
                    else if (!this.CheckBox1.Checked)
                    {
                        string cmdText2 = $"UPDATE CupTrans SET M_Tem_Out = 1 WHERE m_id = {this.txtid.Text} AND m_team = '{this.ComboBox1.Text}'";
                        using (CupService cupService = new CupService())
                        {
                            cupService.Update(cmdText2);
                        }
                        this.Team_Out();
                    }

                    string cmdText3 = $"update Newmatch set Result='Declared', Remark='{this.txtremark.Text}' where Sr_No={this.txtid.Text}";
                    using (MatchService matchService = new MatchService())
                    {
                        matchService.Update(cmdText3);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001370 RID: 4976 RVA: 0x003466CC File Offset: 0x00344ACC
        public void Team_Out()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT DISTINCT PartyMaster.PartyName, CupTrans.m_checked, CupTrans.m_id, PartyMaster.Status, PartyMaster.SCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.TParty, PartyMaster.TCup FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) WHERE (CupTrans.m_checked = 0) AND (CupTrans.m_id = " + this.txtid.Text + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    string cmdText2 = string.Concat(new string[]
                    {
                        "SELECT CupTrans.m_id, CupTrans.m_party, PartyMaster.SCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.TParty, PartyMaster.TCup, CupTrans.m_checked, CupTrans.M_Tem_Out, SUM(CupTrans.m_amt) AS Expr1, CupTrans.m_team, CupTrans.m_mode FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY CupTrans.m_id, CupTrans.m_party, PartyMaster.SCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.TParty, PartyMaster.TCup, CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_team, CupTrans.m_mode HAVING (CupTrans.m_id = ",
                        this.txtid.Text,
                        ") AND (CupTrans.m_checked = 0) AND (CupTrans.M_Tem_Out = 1) AND (CupTrans.m_team = '",
                        this.ComboBox1.Text,
                        "') AND (CupTrans.m_party = '",
                        oleDbDataReader["PartyName"].ToString(),
                        "')"
                    });
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    double num = 0;
                    double num2 = 0;
                    while (oleDbDataReader2.Read())
                    {
                        if (Operators.ConditionalCompareObjectEqual(oleDbDataReader2["m_mode"], "K", false))
                        {
                            num = Convert.ToDouble(oleDbDataReader2["Expr1"]);
                        }
                        else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader2["m_mode"], "L", false))
                        {
                            num2 = Convert.ToDouble(oleDbDataReader2["Expr1"]);
                        }
                    }
                    oleDbCommand.Clone();
                    double num3 = Conversion.Val(num) - Conversion.Val(num2);
                    num = 0.0;
                    num2 = 0.0;
                    this.txtpartyname.Text = oleDbDataReader["PartyName"].ToString();
                    this.txtagentname.Text = oleDbDataReader["AParty"].ToString();
                    this.txtpatnarname.Text = oleDbDataReader["TParty"].ToString();

                    //this.txtcomihorySelf.Text = Conversions.ToString(oleDbDataReader["SCup"]);
                    //this.txtcomihoryAgent.Text = Conversions.ToString(oleDbDataReader["ACup"]);
                    //this.txtcomihoryPatnar.Text = Conversions.ToString(oleDbDataReader["TCup"]);

                    double num4 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["SCup"]);
                    double num5 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["ACup"]);
                    double num6 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["TCup"]);

                    int num7 = checked((int)Math.Round(unchecked(Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3))));
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = this.txtpartyname.Text;
                    this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num7);
                    this.DataGridView1.Rows[index].Cells[2].Value = this.txtid.Text + " - " + this.ComboBox1.Text;

                    //if (num7 < 0)
                    //{
                    //	this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num7);
                    //}
                    //else
                    //{
                    //	this.DataGridView1.Rows[index].Cells[1].Value = num7;
                    //}

                    int index2 = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index2].Cells[0].Value = this.txtpartyname.Text;
                    this.DataGridView2.Rows[index2].Cells[1].Value = Conversion.Val(num3) * Conversion.Val(num4);
                    this.DataGridView2.Rows[index2].Cells[2].Value = "Self Share - " + this.ComboBox1.Text;

                    double num8 = Conversion.Val(num3) * Conversion.Val(num4);
                    double num9 = Conversion.Val(num3) - Conversion.Val(num8);

                    if (Operators.CompareString(this.txtagentname.Text, null, false) != 0)
                    {
                        int index3 = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index3].Cells[0].Value = this.txtagentname.Text;
                        this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(num9) * Conversion.Val(num5);
                        //if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[index3].Cells[1].Value, 0, false))
                        //{
                        //	this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value)) * Conversion.Val(num5) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value));
                        //	this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value));
                        //}
                        //else
                        //{
                        //	this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(num9) * Conversion.Val(num5);
                        //}
                        this.DataGridView3.Rows[index3].Cells[2].Value = "Agent Share - " + this.txtpartyname.Text + " -" + this.ComboBox1.Text;
                    }

                    if (Operators.CompareString(this.txtpatnarname.Text, null, false) != 0)
                    {
                        int index4 = this.DataGridView4.Rows.Add();
                        this.DataGridView4.Rows[index4].Cells[0].Value = this.txtpatnarname.Text;
                        this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(num9) * Conversion.Val(num6);
                        //if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[index4].Cells[1].Value, 0, false))
                        //{
                        //	this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value)) * Conversion.Val(num6) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value));
                        //	this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value));
                        //}
                        //else
                        //{
                        //	this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(num9) * Conversion.Val(num6);
                        //}
                        this.DataGridView4.Rows[index4].Cells[2].Value = "Patnar Share - " + this.txtpartyname.Text + " -" + this.ComboBox1.Text;
                    }
                }
                Module1.conn.Close();
                this.DataGridView5.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                this.DataGridView5.Rows[1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                this.DataGridView5.Rows[2].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                this.DataGridView5.Rows[3].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                int num10 = 0;
                double num21 = 0;
                checked
                {
                    int num11 = this.DataGridView1.RowCount - 1;
                    double num12 = 0;
                    for (int i = num10; i <= num11; i++)
                    {
                        unchecked
                        {
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[1].Value));
                        }
                    }
                    this.DataGridView5.Rows[0].Cells[1].Value = unchecked(num12 - num12 - num12);
                    this.DataGridView5.Rows[0].Cells[2].Value = this.txtid.Text + " - " + this.ComboBox1.Text;
                    this.DataGridView5.Rows[1].Cells[2].Value = "Self Share - " + this.ComboBox1.Text;
                    this.DataGridView5.Rows[2].Cells[2].Value = "Agent Share - " + this.ComboBox1.Text;
                    this.DataGridView5.Rows[3].Cells[2].Value = "Patnar Share - " + this.ComboBox1.Text;
                    int num13 = 0;
                    int num14 = this.DataGridView2.RowCount - 1;
                    double num15 = 0;
                    for (int j = num13; j <= num14; j++)
                    {
                        unchecked
                        {
                            num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[j].Cells[1].Value));
                        }
                    }
                    this.DataGridView5.Rows[1].Cells[1].Value = unchecked(Conversion.Val(num15.ToString()) - Conversion.Val(num15.ToString()) - Conversion.Val(num15.ToString()));
                    this.TextBox6.Text = num15.ToString();
                    int num16 = 0;
                    int num17 = this.DataGridView3.RowCount - 1;
                    double num18 = 0;
                    for (int k = num16; k <= num17; k++)
                    {
                        unchecked
                        {
                            num18 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[k].Cells[1].Value));
                        }
                    }
                    this.TextBox8.Text = num18.ToString();
                    this.DataGridView5.Rows[2].Cells[1].Value = unchecked(Conversion.Val(num18.ToString()) - Conversion.Val(num18.ToString()) - Conversion.Val(num18.ToString()));
                    int num19 = 0;
                    int num20 = this.DataGridView4.RowCount - 1;
                    for (int l = num19; l <= num20; l++)
                    {
                        unchecked
                        {
                            num21 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[l].Cells[1].Value));
                        }
                    }
                    this.TextBox9.Text = num21.ToString();
                }
                this.DataGridView5.Rows[3].Cells[1].Value = Conversion.Val(num21.ToString()) - Conversion.Val(num21.ToString()) - Conversion.Val(num21.ToString());
                this.save1();
                this.save2();
                this.save3();
                this.save4();
                this.save5();
                MessageBox.Show("Cup Decleard");
                this.Button2.Enabled = true;
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

        // Token: 0x06001371 RID: 4977 RVA: 0x00347534 File Offset: 0x00345934
        public void save1()
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {
                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001372 RID: 4978 RVA: 0x00347774 File Offset: 0x00345B74
        public void save2()
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView2.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {

                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001373 RID: 4979 RVA: 0x003479B4 File Offset: 0x00345DB4
        public void save3()
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView3.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {
                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001374 RID: 4980 RVA: 0x00347BF4 File Offset: 0x00345FF4
        public void save4()
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView4.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {

                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001375 RID: 4981 RVA: 0x00347E34 File Offset: 0x00346234
        public void save5()
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView5.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {

                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001376 RID: 4982 RVA: 0x00348074 File Offset: 0x00346474
        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            this.txtremark.Text = this.ComboBox1.Text;
        }

        // Token: 0x06001377 RID: 4983 RVA: 0x0034808C File Offset: 0x0034648C
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT CupTrans.m_id, CupTrans.m_party, PartyMaster.SCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.TParty, PartyMaster.TCup, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5,  SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9, SUM(CupTrans.m_team10) AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13,  SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15, CupTrans.m_checked, CupTrans.M_Tem_Out FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY CupTrans.m_id, CupTrans.m_party, PartyMaster.SCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.TParty, PartyMaster.TCup, CupTrans.m_checked,CupTrans.M_Tem_Out HAVING        (CupTrans.m_id = " + this.txtid.Text + ") AND (CupTrans.m_checked = 0) AND (CupTrans.M_Tem_Out = 0)";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = 0;
                    if (Operators.CompareString(this.txt1.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    }
                    else if (Operators.CompareString(this.txt2.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    }
                    else if (Operators.CompareString(this.txt3.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    }
                    else if (Operators.CompareString(this.txt4.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    }
                    else if (Operators.CompareString(this.txt5.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    }
                    else if (Operators.CompareString(this.txt6.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr6"]);
                    }
                    else if (Operators.CompareString(this.txt7.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr7"]);
                    }
                    else if (Operators.CompareString(this.txt8.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr8"]);
                    }
                    else if (Operators.CompareString(this.txt9.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr9"]);
                    }
                    else if (Operators.CompareString(this.txt10.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr10"]);
                    }
                    else if (Operators.CompareString(this.txt11.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr11"]);
                    }
                    else if (Operators.CompareString(this.txt12.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr12"]);
                    }
                    else if (Operators.CompareString(this.txt13.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr13"]);
                    }
                    else if (Operators.CompareString(this.txt14.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr14"]);
                    }
                    else if (Operators.CompareString(this.txt15.Text, this.ComboBox1.Text, false) == 0)
                    {
                        num = Convert.ToDouble(oleDbDataReader["Expr15"]);
                    }
                    this.txtpartyname.Text = Conversions.ToString(oleDbDataReader["m_party"]);
                    this.txtagentname.Text = Conversions.ToString(oleDbDataReader["AParty"]);
                    this.txtpatnarname.Text = Conversions.ToString(oleDbDataReader["TParty"]);

                    //this.txtcomihorySelf.Text = Conversions.ToString(oleDbDataReader["SCup"]);
                    //this.txtcomihoryAgent.Text = Conversions.ToString(oleDbDataReader["ACup"]);
                    //this.txtcomihoryPatnar.Text = Conversions.ToString(oleDbDataReader["TCup"]);

                    double num2 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["SCup"]);
                    double num3 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["ACup"]);
                    double num4 = Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["TCup"]);

                    int num5 = checked((int)Math.Round(unchecked(Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num))));
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = this.txtpartyname.Text;
                    if (num5 < 0)
                    {
                        this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num5) * Conversion.Val(num2);
                        this.DataGridView1.Rows[index].Cells[1].Value = Conversion.Val(num5) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value));
                    }
                    else
                    {
                        this.DataGridView1.Rows[index].Cells[1].Value = num5;
                    }
                    this.DataGridView1.Rows[index].Cells[2].Value = string.Concat(new string[]
                    {
                        this.txtid.Text,
                        " - ",
                        this.txt1.Text,
                        " - VS - ",
                        this.txt2.Text
                    });

                    int index2 = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index2].Cells[0].Value = this.txtpartyname.Text;
                    this.DataGridView2.Rows[index2].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num2);
                    this.DataGridView2.Rows[index2].Cells[2].Value = "Self Share - " + this.txt1.Text + " - VS - " + this.txt2.Text;

                    double afterld = Conversion.Val(num2) * Conversion.Val(num) - Conversion.Val(num);
                    afterld = Conversion.Val(afterld) - Conversion.Val(afterld) - Conversion.Val(afterld);

                    if (Operators.CompareString(this.txtagentname.Text, null, false) != 0)
                    {
                        int index3 = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index3].Cells[0].Value = this.txtagentname.Text;
                        this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num3);

                        //if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[index3].Cells[1].Value, 0, false))
                        //{
                        //	this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value)) * Conversion.Val(num3) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value));
                        //	this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value));
                        //}
                        //else
                        //{
                        //	this.DataGridView3.Rows[index3].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num3);
                        //}
                        this.DataGridView3.Rows[index3].Cells[2].Value = string.Concat(new string[]
                        {
                            "Agent Share - ",
                            this.txtpartyname.Text,
                            this.txt1.Text,
                            " - VS - ",
                            this.txt2.Text
                        });
                    }

                    if (Operators.CompareString(this.txtpatnarname.Text, null, false) != 0)
                    {
                        int index4 = this.DataGridView4.Rows.Add();
                        this.DataGridView4.Rows[index4].Cells[0].Value = this.txtpatnarname.Text;
                        this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(afterld) * Conversion.Val(num4);
                        //if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[index4].Cells[1].Value, 0, false))
                        //{
                        //	this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value)) * Conversion.Val(num4) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value));
                        //	this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value));
                        //}
                        //else
                        //{
                        //	this.DataGridView4.Rows[index4].Cells[1].Value = Conversion.Val(num) * Conversion.Val(num4);
                        //}
                        this.DataGridView4.Rows[index4].Cells[2].Value = string.Concat(new string[]
                        {
                            "Patnar Share - ",
                            this.txtpartyname.Text,
                            this.txt1.Text,
                            " - VS - ",
                            this.txt2.Text
                        });
                    }
                }
                this.DataGridView5.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                this.DataGridView5.Rows[1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                this.DataGridView5.Rows[2].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                this.DataGridView5.Rows[3].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.SRHINAME);
                int num6 = 0;
                double num17 = 0;
                checked
                {
                    int num7 = this.DataGridView1.RowCount - 1;
                    double num8 = 0;
                    for (int i = num6; i <= num7; i++)
                    {
                        unchecked
                        {
                            num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[1].Value));
                        }
                    }
                    this.DataGridView5.Rows[0].Cells[1].Value = unchecked(num8 - num8 - num8);
                    this.DataGridView5.Rows[0].Cells[2].Value = string.Concat(new string[]
                    {
                        this.txtid.Text,
                        " - ",
                        this.txt1.Text,
                        " - VS - ",
                        this.txt2.Text
                    });
                    this.DataGridView5.Rows[1].Cells[2].Value = "Self Share - " + this.txt1.Text + " - VS - " + this.txt2.Text;
                    this.DataGridView5.Rows[2].Cells[2].Value = "Agent Share - " + this.txt1.Text + " - VS - " + this.txt2.Text;
                    this.DataGridView5.Rows[3].Cells[2].Value = "Patnar Share - " + this.txt1.Text + " - VS - " + this.txt2.Text;
                    int num9 = 0;
                    int num10 = this.DataGridView2.RowCount - 1;
                    double num11 = 0;
                    for (int j = num9; j <= num10; j++)
                    {
                        unchecked
                        {
                            num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[j].Cells[1].Value));
                        }
                    }
                    this.DataGridView5.Rows[1].Cells[1].Value = unchecked(Conversion.Val(num11.ToString()) - Conversion.Val(num11.ToString()) - Conversion.Val(num11.ToString()));
                    this.TextBox6.Text = num11.ToString();
                    int num12 = 0;
                    int num13 = this.DataGridView3.RowCount - 1;
                    double num14 = 0;
                    for (int k = num12; k <= num13; k++)
                    {
                        unchecked
                        {
                            num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[k].Cells[1].Value));
                        }
                    }
                    this.TextBox8.Text = num14.ToString();
                    this.DataGridView5.Rows[2].Cells[1].Value = unchecked(Conversion.Val(num14.ToString()) - Conversion.Val(num14.ToString()) - Conversion.Val(num14.ToString()));
                    int num15 = 0;
                    int num16 = this.DataGridView4.RowCount - 1;
                    for (int l = num15; l <= num16; l++)
                    {
                        unchecked
                        {
                            num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[l].Cells[1].Value));
                        }
                    }
                    this.TextBox9.Text = num17.ToString();
                }
                this.DataGridView5.Rows[3].Cells[1].Value = Conversion.Val(num17.ToString()) - Conversion.Val(num17.ToString()) - Conversion.Val(num17.ToString());
                this.Grid1_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Grid2_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Grid3_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Grid4_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Grid5_Click(RuntimeHelpers.GetObjectValue(sender), e);
                MessageBox.Show("Cup Decleard");
                this.Button2.Enabled = true;
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

        // Token: 0x06001378 RID: 4984 RVA: 0x00349238 File Offset: 0x00347638
        private void txtpartyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600137A RID: 4986 RVA: 0x00349278 File Offset: 0x00347678
        private void Grid1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {
                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600137B RID: 4987 RVA: 0x003494B8 File Offset: 0x003478B8
        private void Grid2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView2.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {

                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600137C RID: 4988 RVA: 0x003496F8 File Offset: 0x00347AF8
        private void Grid3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView3.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {

                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600137D RID: 4989 RVA: 0x00349938 File Offset: 0x00347D38
        private void Grid4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView4.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {

                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600137E RID: 4990 RVA: 0x00349B78 File Offset: 0x00347F78
        private void Grid5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView5.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                    {
                        string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{this.txtid.Text},'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','CUP',{this.txtvid.Text},0,0,'No','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600137F RID: 4991 RVA: 0x00349DB8 File Offset: 0x003481B8
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x04000811 RID: 2065
        private object SRHINAME;
    }
}
