using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
    public partial class Agent_Connect : Form
    {
        // Token: 0x06000189 RID: 393 RVA: 0x002804D0 File Offset: 0x0027E8D0
        public Agent_Connect()
        {
            try
            {
                this.InitializeComponent();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Agent_Connect_Activated(object sender, EventArgs e)
        {
            try
            {
                this.txtname1.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000243 RID: 579 RVA: 0x00284C14 File Offset: 0x00283014
        private void Agent_Connect_Load(object sender, EventArgs e)
        {
            try
            {
                this.combolod();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000246 RID: 582 RVA: 0x00286174 File Offset: 0x00284574
        public void combolod()
        {
            try
            {
                this.txtname1.Items.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.Strsql = "Select * from PartyMaster";
                this.cmd = new OleDbCommand(this.Strsql, Module1.conn);
                this.dr = this.cmd.ExecuteReader();
                while (this.dr.Read())
                {
                    //this.txtname1.Items.Add(RuntimeHelpers.GetObjectValue(this.dr["AParty"]));
                    //this.txtname1.Items.Add(RuntimeHelpers.GetObjectValue(this.dr["TParty"]));

                    if (!this.txtname1.Items.Contains(RuntimeHelpers.GetObjectValue(this.dr["AParty"]).ToString()))
                        this.txtname1.Items.Add(RuntimeHelpers.GetObjectValue(this.dr["AParty"]));

                    if (!this.txtname1.Items.Contains(RuntimeHelpers.GetObjectValue(this.dr["TParty"]).ToString()))
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        // Token: 0x0600024C RID: 588 RVA: 0x00287CEC File Offset: 0x002860EC
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvCredit.Rows.Clear();
                this.dgvDebit.Rows.Clear();
                txtjuma.Text = "";
                txtneva.Text = "";
                lblTotal.Text = "";
                string TPartyName = "";
                bool isParty = false;
                if (Module1.isclientreport == true)
                {
                    string cmdText1 = $"SELECT TOP 1 Tparty FROM PartyMaster where AParty = '{txtname1.Text}' AND TParty Not IN ( '')";
                    using (PartyMasterService partyMasterService = new PartyMasterService())
                    {
                        DataTable DtTParty = partyMasterService.Get(cmdText1);
                        TPartyName = DtTParty.Rows.Count > 0 ? $"OR PartyName = '{DtTParty.Rows[0]["TParty"].ToString()}'" : "";
                    }
                }
                if (Module1.DtMatch != null && Module1.DtMatch.Rows.Count > 0 && txtname1.Text != "")
                {
                    string _sqlWhere = $"PartyName = '{txtname1.Text}' OR AParty = '{txtname1.Text}' OR TParty = '{txtname1.Text}' {TPartyName}";
                    string _sqlOrder = "PartyName ASC";
                    DataTable dt = Module1.DtMatch.Select(_sqlWhere, _sqlOrder).CopyToDataTable();

                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    double num8 = 0, num9 = 0;
                    string cmdText = "SELECT PartyName FROM PartyMaster ORDER BY PartyName";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        double num5 = 0.0;
                        for (int k = 0; k <= dt.Rows.Count - 1; k++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(dt.Rows[k]["PartyName"].ToString(), oleDbDataReader["PartyName"], false))
                                {
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dt.Rows[k]["Expr1"]));
                                    isParty = true;

                                }
                            }
                        }
                        unchecked
                        {
                            //if (Math.Abs(num5) != 0)
                            //{
                            if (isParty)
                            {
                                if (num5 < 0.0)
                                {
                                    int num = this.dgvDebit.Rows.Add();
                                    this.dgvDebit.Rows[num].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                    this.dgvDebit.Rows[num].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), Module1.decimalnumberformat);
                                    num8 += Convert.ToDouble(num5);
                                }
                                else
                                {
                                    int num = this.dgvCredit.Rows.Add();
                                    this.dgvCredit.Rows[num].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                    this.dgvCredit.Rows[num].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), Module1.decimalnumberformat);
                                    num9 += Convert.ToDouble(num5);
                                }
                                isParty = false;
                            }
                           //}
                        }
                    }
                    this.txtjuma.Text = Module1.SetNumFormat(Conversion.Val(num9), Module1.decimalnumberformat);
                    this.txtneva.Text = Module1.SetNumFormat(Conversion.Val(num8), Module1.decimalnumberformat);
                    num8 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
                    this.lblTotal.Text = Module1.SetNumFormat(Conversion.Val(num9) - Conversion.Val(num8), Module1.decimalnumberformat);
                }
                else
                {
                    MessageBox.Show("First Run Profit Loss Report");
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
            finally
            {
                dgvCredit.ClearSelection();
                dgvDebit.ClearSelection();
                Module1.conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to Posting To Agent Ledger?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (this.txtname1.Text != "")
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }

                        for (int i = 0; i <= this.dgvCredit.RowCount - 1; i++)
                        {
                            string cmdText2 = "select max(tns_ModifyID) from Trans";
                            OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                            checked
                            {
                                int modifyid;
                                if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                                {
                                    modifyid = Conversions.ToInteger("1");
                                }
                                else
                                {
                                    modifyid = Conversions.ToInteger(oleDbCommand2.ExecuteScalar());
                                    modifyid++;
                                }

                                string toparty = Conversions.ToString(RuntimeHelpers.GetObjectValue(this.dgvCredit.Rows[i].Cells[0].Value));
                                double amount = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgvCredit.Rows[i].Cells[1].Value));

                                try
                                {
                                    if (toparty != "" && amount != 0 && toparty != txtname1.Text)
                                    {
                                        double amt1 = Conversion.Val(amount) - Conversion.Val(amount) - Conversion.Val(amount);
                                        string cmdText3 = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala,tns_chk,tns_time,tns_date,tns_IsAuto) values('{toparty}',{amt1},'{this.txtname1.Text + " (Auto)"}','0','{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','{(amt1 > 0 ? "CR" : "DR")}',0,0,0,{modifyid},'No',0,0,'{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}','{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','1')";

                                        string cmdText4 = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala,tns_chk,tns_time,tns_date,tns_IsAuto) values('{this.txtname1.Text}',{amount},'{toparty + " (Auto)"}','0','{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','{(amount > 0 ? "CR" : "DR")}', 0,0,0,{modifyid},'No','1',0,'{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}','{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','1')";
                                        using (TransactionService transactionService = new TransactionService())
                                        {
                                            transactionService.Insert(cmdText3);
                                            transactionService.Insert(cmdText4);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        }

                        for (int i = 0; i <= this.dgvDebit.RowCount - 1; i++)
                        {
                            string cmdText2 = "select max(tns_ModifyID) from Trans";
                            OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                            checked
                            {
                                int modifyid;
                                if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                                {
                                    modifyid = Conversions.ToInteger("1");
                                }
                                else
                                {
                                    modifyid = Conversions.ToInteger(oleDbCommand2.ExecuteScalar());
                                    modifyid++;
                                }

                                string toparty = Conversions.ToString(RuntimeHelpers.GetObjectValue(this.dgvDebit.Rows[i].Cells[0].Value));
                                double amount = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgvDebit.Rows[i].Cells[1].Value));
                                try
                                {
                                    if (toparty != "" && amount != 0 && toparty != txtname1.Text)
                                    {
                                        double amt1 = Conversion.Val(amount) - Conversion.Val(amount) - Conversion.Val(amount);
                                        string cmdText3 = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala,tns_chk,tns_time,tns_date,tns_IsAuto) values('{toparty}',{amt1},'{this.txtname1.Text + " (Auto)"}',0,'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','{(amt1 > 0 ? "CR" : "DR")}',0,0,0,{modifyid},'No','0',0,'{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}','{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','1')";
                                        string cmdText4 = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala,tns_chk,tns_time,tns_date,tns_IsAuto) values('{this.txtname1.Text}',{amount},'{toparty + " (Auto)"}',0,'{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','{(amount > 0 ? "CR" : "DR")}',0,0,0,{modifyid},'No','1',0,'{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}','{Strings.FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)}','1')";
                                        using (TransactionService transactionService = new TransactionService())
                                        {
                                            transactionService.Insert(cmdText3);
                                            transactionService.Insert(cmdText4);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        }

                        Interaction.MsgBox("Posting To Agent Ledger Successfully..!", MsgBoxStyle.OkOnly);
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600024F RID: 591 RVA: 0x00289074 File Offset: 0x00287474
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvCredit.Rows.Clear();
                this.dgvDebit.Rows.Clear();
                txtname1.Text = "";
                txtjuma.Text = "";
                txtneva.Text = "";
                lblTotal.Text = "";
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly);
            }
        }

        // Token: 0x0600025C RID: 604 RVA: 0x0028A7E4 File Offset: 0x00288BE4
        private void txtname1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    //this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.btnshow.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly);
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly);
            }
        }

        // Token: 0x0600025E RID: 606 RVA: 0x0028A828 File Offset: 0x00288C28
        private void Agent_Connect_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable("DataTable1");
                dataTable.Columns.Add("Column1");
                dataTable.Columns.Add("Column2");
                dataTable.Columns.Add("Column3");
                dataTable.Columns.Add("Column4");
                dataTable.Columns.Add("Jama");

                DataTable dataTable2 = new DataTable("DataTable2");
                dataTable2.Columns.Add("Column1");
                dataTable2.Columns.Add("Column2");
                dataTable2.Columns.Add("Column3");
                dataTable2.Columns.Add("Column4");
                dataTable2.Columns.Add("Neva");

                DataTable dataTable3 = new DataTable("DataTable3");
                dataTable3.Columns.Add("Party");

                try
                {
                    foreach (object obj in ((IEnumerable)this.dgvCredit.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        dataTable.Rows.Add(new object[]
                        {
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                            "",
                            "", //this.txtname1.Text,
							this.Label7.Text + "                                       " + this.txtjuma.Text
                        });
                    }
                }
                finally
                {
                }
                dataSet.Tables.Add(dataTable);

                try
                {
                    foreach (object obj2 in ((IEnumerable)this.dgvDebit.Rows))
                    {
                        DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                        dataTable2.Rows.Add(new object[]
                        {
                            RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[0].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[1].Value),
                            "",
                            this.label6.Text + "                                                               " + this.lblTotal.Text,
                            this.Label9.Text + "                                       " + this.txtneva.Text
                        });
                    }
                }
                finally
                {
                }
                dataSet.Tables.Add(dataTable2);

                dataTable3.Rows.Add(new object[]
                {
                    this.txtname1.Text
                });
                dataSet.Tables.Add(dataTable3);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\AgentC_Report.rpt");
                reportDocument.SetDataSource(dataSet);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
    }
}
