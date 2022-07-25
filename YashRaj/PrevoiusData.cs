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
    // Token: 0x02000099 RID: 153
    //[DesignerGenerated]
    public partial class PrevoiusData : Form
    {
        // Token: 0x06001EDD RID: 7901 RVA: 0x003A2704 File Offset: 0x003A0B04
        public PrevoiusData()
        {
            this.InitializeComponent();
        }

        // Token: 0x06001F20 RID: 7968 RVA: 0x003A3F88 File Offset: 0x003A2388
        private void PrevoiusData_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtnu.Text = Module1.decimalnumberformat;
                this.txtname.Text = Conversions.ToString(Module1.tranID);
                this.Amount_IS_Partyname();
                this.Monday_Final();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001F21 RID: 7969 RVA: 0x003A4058 File Offset: 0x003A2458
        public void Monday_Final()
        {
            try
            {
                this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                //string cmdText = "SELECT Id, tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk FROM Trans  WHERE (tns_party = '" + this.txtname.Text + "') AND (tns_Monday_Final = 'Yes') AND (tns_chk = '0') ORDER BY Id DESC";
                string cmdText = "SELECT * FROM Trans WHERE (tns_party = '" + this.txtname.Text + "') AND (tns_Monday_Final = 'Yes') AND (tns_chk = '0') ORDER BY Id DESC";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["tns_Type"], "Monday Settlement", false))
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LimeGreen;
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                        this.DataGridView1.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.GeneralDate);
                        this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);
                        this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
                        this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Sessionid"]);
                        this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
                        int index2 = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index2].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                        this.DataGridView3.Rows[index2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView3.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);
                        int index3 = this.DataGridView2.Rows.Add();
                        this.DataGridView2.Rows[index3].DefaultCellStyle.BackColor = Color.LimeGreen;
                        this.DataGridView2.Rows[index3].DefaultCellStyle.ForeColor = Color.White;
                        this.DataGridView2.Rows[index3].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                        this.DataGridView2.Rows[index3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView2.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);
                        this.DataGridView2.Rows[index3].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
                        this.DataGridView2.Rows[index3].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Sessionid"]);
                        this.DataGridView2.Rows[index3].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);

                        //if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["modify"].ToString())) == 1.0)
                        //{
                        //	this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Blue;
                        //}
                    }
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(oleDbDataReader["tns_Amount"], 0, false), Operators.CompareObjectNotEqual(oleDbDataReader["tns_Type"], "Monday Settlement", false))))
                    {
                        int index4 = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index4].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                        this.DataGridView1.Rows[index4].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView1.Rows[index4].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);
                        this.DataGridView1.Rows[index4].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
                        this.DataGridView1.Rows[index4].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Sessionid"]);
                        this.DataGridView1.Rows[index4].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
                        int index5 = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index5].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                        this.DataGridView3.Rows[index5].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView3.Rows[index5].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);

                        if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["modify"].ToString())) == 1.0)
                        {
                            this.DataGridView1.Rows[index4].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                    }
                    else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(oleDbDataReader["tns_Amount"], 0, false), Operators.CompareObjectNotEqual(oleDbDataReader["tns_Type"], "Monday Settlement", false))))
                    {
                        int index6 = this.DataGridView2.Rows.Add();
                        this.DataGridView2.Rows[index6].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                        this.DataGridView2.Rows[index6].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView2.Rows[index6].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);
                        this.DataGridView2.Rows[index6].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
                        this.DataGridView2.Rows[index6].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Sessionid"]);
                        this.DataGridView2.Rows[index6].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
                        int index7 = this.DataGridView3.Rows.Add();
                        this.DataGridView3.Rows[index7].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                        this.DataGridView3.Rows[index7].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])), this.txtnu.Text);
                        this.DataGridView3.Rows[index7].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);

                        if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["modify"].ToString())) == 1.0)
                        {
                            //this.DataGridView1.Rows[index6].DefaultCellStyle.ForeColor = Color.Blue;
                            this.DataGridView2.Rows[index6].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                    }
                }
                this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001F22 RID: 7970 RVA: 0x003A4A2C File Offset: 0x003A2E2C
        public void Amount_IS_Partyname()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select sum(tns_Amount)from Trans where tns_Party='" + this.txtname.Text + "'  and tns_Monday='0'and tns_Monday_Final='Yes'and tns_chk='0'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                    this.DataGridView3.Rows[0].Cells[3].Value = this.txtname.Text + "  Net Balance = " + Module1.SetNumFormat(num, this.txtnu.Text);
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

        // Token: 0x06001F24 RID: 7972 RVA: 0x003A4BD4 File Offset: 0x003A2FD4
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //MyProject.Forms.TransactionReport.MdiParent = this.MdiParent;
                //MyProject.Forms.TransactionReport.WindowState = FormWindowState.Maximized;
                //MyProject.Forms.TransactionReport.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001F25 RID: 7973 RVA: 0x003A4C4C File Offset: 0x003A304C
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable("DataTable6");
                dataTable.Columns.Add("Names");
                dataTable.Columns.Add("Cls");
                dataTable.Rows.Add(new object[]
                {
                    this.txtname.Text,
                    ""
                });
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                DataTable dataTable2 = new DataTable("DataTable4");
                dataTable2.Columns.Add("Column1");
                dataTable2.Columns.Add("Column2");
                dataTable2.Columns.Add("Column3");
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            if (!(dataGridViewRow.DefaultCellStyle.BackColor == Color.Red))
                            {
                                dataTable2.Rows.Add(new object[]
                                {
                                    Strings.FormatDateTime(Conversions.ToDate(dataGridViewRow.Cells[0].Value), DateFormat.ShortDate),
                                    RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                                    RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)
                                });
                            }
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
                    Module1.conn.Close();
                }
                dataSet.Tables.Add(dataTable2);
                DataTable dataTable3 = new DataTable("DataTable5");
                dataTable3.Columns.Add("Column1");
                dataTable3.Columns.Add("Column2");
                dataTable3.Columns.Add("Column3");
                try
                {
                    foreach (object obj2 in ((IEnumerable)this.DataGridView2.Rows))
                    {
                        DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells[0].Value, null, false))
                        {
                            if (!(dataGridViewRow2.DefaultCellStyle.BackColor == Color.Red))
                            {
                                dataTable3.Rows.Add(new object[]
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
                //dataSet.Tables.Add(dataTable3);
                //Privesdata privesdata = new Privesdata();
                //privesdata.SetDataSource(dataSet);
                //privesdata.PrintToPrinter(0, false, 0, 0);

                dataSet.Tables.Add(dataTable3);
                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\Privesdata.rpt");
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

        // Token: 0x06001F26 RID: 7974 RVA: 0x003A4FC0 File Offset: 0x003A33C0
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = Conversions.ToDate(this.DateTimePicker1.Text);
                DateTime dateTime2 = Conversions.ToDate(this.DateTimePicker2.Text);
                string text = dateTime.ToString("yyyy-MM-dd");
                string text2 = dateTime2.ToString("yyyy-MM-dd");
                string cmdText = $"DELETE FROM Trans WHERE Trans.tns_party = '{this.txtname.Text}' AND Trans.tns_Monday_Final = 'Yes' AND Trans.tns_dt >='{text.ToString()}'AND Trans.tns_dt <='{text2.ToString()}')";
                using (TransactionService transactionService = new TransactionService())
                {
                    transactionService.Insert(cmdText);

                }
                Interaction.MsgBox("Old Record Delete Sucessfully..", MsgBoxStyle.OkOnly, null);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001F27 RID: 7975 RVA: 0x003A50CC File Offset: 0x003A34CC
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, null, false))
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, "Match", false))
                    {
                        Module1.machid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[3].Value.ToString());
                        Module1.name1 = this.txtname.Text;
                        DPP_Match dPP_Match = new DPP_Match();
                        dPP_Match.MdiParent = this.MdiParent;
                        dPP_Match.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, "ABDN", false))
                    {
                        Module1.machid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[3].Value.ToString());
                        Module1.sonu = this.txtname.Text;
                        DPP_AbnTie dPP_AbnTie = new DPP_AbnTie();
                        dPP_AbnTie.MdiParent = this.MdiParent;
                        dPP_AbnTie.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, "CUP", false))
                    {
                        Module1.IDCUP = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[3].Value.ToString());
                        Module1.name1 = this.txtname.Text;
                        DPP_CUP dPP_CUP = new DPP_CUP();
                        dPP_CUP.MdiParent = this.MdiParent;
                        dPP_CUP.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, "Session", false))
                    {
                        Module1.sessionid = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
                        Module1.nehaid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[4].Value.ToString());
                        Module1.dppname = this.txtname.Text;
                        Module1.myexit = "1";
                        formDPPSession formDPPSession = new formDPPSession();
                        formDPPSession.MdiParent = this.MdiParent;
                        formDPPSession.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001F28 RID: 7976 RVA: 0x003A5398 File Offset: 0x003A3798
        private void DataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[5].Value, null, false))
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[5].Value, "Match", false))
                    {
                        Module1.machid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[3].Value.ToString());
                        Module1.name1 = this.txtname.Text;
                        DPP_Match dPP_Match = new DPP_Match();
                        dPP_Match.MdiParent = this.MdiParent;
                        dPP_Match.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[5].Value, "ABDN", false))
                    {
                        Module1.machid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[3].Value.ToString());
                        Module1.sonu = this.txtname.Text;
                        DPP_AbnTie dPP_AbnTie = new DPP_AbnTie();
                        dPP_AbnTie.MdiParent = this.MdiParent;
                        dPP_AbnTie.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[5].Value, "CUP", false))
                    {
                        Module1.IDCUP = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[3].Value.ToString());
                        Module1.name1 = this.txtname.Text;
                        DPP_CUP dPP_CUP = new DPP_CUP();
                        dPP_CUP.MdiParent = this.MdiParent;
                        dPP_CUP.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[5].Value, "Session", false))
                    {
                        Module1.sessionid = this.DataGridView2.CurrentRow.Cells[3].Value.ToString();
                        Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value.ToString());
                        Module1.dppname = this.txtname.Text;
                        Module1.myexit = "1";
                        formDPPSession formDPPSession = new formDPPSession();
                        formDPPSession.MdiParent = this.MdiParent;
                        formDPPSession.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x04000C7D RID: 3197
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000C7E RID: 3198
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;

        // Token: 0x04000C7F RID: 3199
        [AccessedThroughProperty("DataGridView2")]
        private DataGridView _DataGridView2;

        // Token: 0x04000C80 RID: 3200
        [AccessedThroughProperty("txtname")]
        private TextBox _txtname;

        // Token: 0x04000C81 RID: 3201
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000C82 RID: 3202
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x04000C83 RID: 3203
        [AccessedThroughProperty("txtnu")]
        private TextBox _txtnu;

        // Token: 0x04000C84 RID: 3204
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;

        // Token: 0x04000C85 RID: 3205
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;

        // Token: 0x04000C86 RID: 3206
        [AccessedThroughProperty("DataGridView3")]
        private DataGridView _DataGridView3;

        // Token: 0x04000C87 RID: 3207
        [AccessedThroughProperty("Date1")]
        private DataGridViewTextBoxColumn _Date1;

        // Token: 0x04000C88 RID: 3208
        [AccessedThroughProperty("Amount")]
        private DataGridViewTextBoxColumn _Amount;

        // Token: 0x04000C89 RID: 3209
        [AccessedThroughProperty("Remark")]
        private DataGridViewTextBoxColumn _Remark;

        // Token: 0x04000C8A RID: 3210
        [AccessedThroughProperty("partyamount")]
        private DataGridViewTextBoxColumn _partyamount;

        // Token: 0x04000C8B RID: 3211
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;

        // Token: 0x04000C8C RID: 3212
        [AccessedThroughProperty("DateTimePicker1")]
        private DateTimePicker _DateTimePicker1;

        // Token: 0x04000C8D RID: 3213
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x04000C8E RID: 3214
        [AccessedThroughProperty("DateTimePicker2")]
        private DateTimePicker _DateTimePicker2;

        // Token: 0x04000C8F RID: 3215
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x04000C90 RID: 3216
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000C91 RID: 3217
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;

        // Token: 0x04000C92 RID: 3218
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;

        // Token: 0x04000C93 RID: 3219
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;

        // Token: 0x04000C94 RID: 3220
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;

        // Token: 0x04000C95 RID: 3221
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;

        // Token: 0x04000C96 RID: 3222
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;

        // Token: 0x04000C97 RID: 3223
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

        // Token: 0x04000C98 RID: 3224
        [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

        // Token: 0x04000C99 RID: 3225
        [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

        // Token: 0x04000C9A RID: 3226
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;

        // Token: 0x04000C9B RID: 3227
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;

        // Token: 0x04000C9C RID: 3228
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;
    }
}



//// Token: 0x17000B8A RID: 2954
//// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x003A3A48 File Offset: 0x003A1E48
//// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x003A3A5C File Offset: 0x003A1E5C
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

//// Token: 0x17000B8B RID: 2955
//// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x003A3A68 File Offset: 0x003A1E68
//// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x003A3A7C File Offset: 0x003A1E7C
//internal virtual DataGridView DataGridView1
//{
//	get
//	{
//		return this._DataGridView1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		DataGridViewCellMouseEventHandler value2 = new DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
//		if (this._DataGridView1 != null)
//		{
//			this._DataGridView1.CellMouseDoubleClick -= value2;
//		}
//		this._DataGridView1 = value;
//		if (this._DataGridView1 != null)
//		{
//			this._DataGridView1.CellMouseDoubleClick += value2;
//		}
//	}
//}

//// Token: 0x17000B8C RID: 2956
//// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x003A3AC8 File Offset: 0x003A1EC8
//// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x003A3ADC File Offset: 0x003A1EDC
//internal virtual DataGridView DataGridView2
//{
//	get
//	{
//		return this._DataGridView2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		DataGridViewCellMouseEventHandler value2 = new DataGridViewCellMouseEventHandler(this.DataGridView2_CellMouseDoubleClick);
//		if (this._DataGridView2 != null)
//		{
//			this._DataGridView2.CellMouseDoubleClick -= value2;
//		}
//		this._DataGridView2 = value;
//		if (this._DataGridView2 != null)
//		{
//			this._DataGridView2.CellMouseDoubleClick += value2;
//		}
//	}
//}

//// Token: 0x17000B8D RID: 2957
//// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x003A3B28 File Offset: 0x003A1F28
//// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x003A3B3C File Offset: 0x003A1F3C
//internal virtual TextBox txtname
//{
//	get
//	{
//		return this._txtname;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtname = value;
//	}
//}

//// Token: 0x17000B8E RID: 2958
//// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x003A3B48 File Offset: 0x003A1F48
//// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x003A3B5C File Offset: 0x003A1F5C
//internal virtual Button Button1
//{
//	get
//	{
//		return this._Button1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button1_Click);
//		if (this._Button1 != null)
//		{
//			this._Button1.Click -= value2;
//		}
//		this._Button1 = value;
//		if (this._Button1 != null)
//		{
//			this._Button1.Click += value2;
//		}
//	}
//}

//// Token: 0x17000B8F RID: 2959
//// (get) Token: 0x06001EEA RID: 7914 RVA: 0x003A3BA8 File Offset: 0x003A1FA8
//// (set) Token: 0x06001EEB RID: 7915 RVA: 0x003A3BBC File Offset: 0x003A1FBC
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

//// Token: 0x17000B90 RID: 2960
//// (get) Token: 0x06001EEC RID: 7916 RVA: 0x003A3C08 File Offset: 0x003A2008
//// (set) Token: 0x06001EED RID: 7917 RVA: 0x003A3C1C File Offset: 0x003A201C
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

//// Token: 0x17000B91 RID: 2961
//// (get) Token: 0x06001EEE RID: 7918 RVA: 0x003A3C28 File Offset: 0x003A2028
//// (set) Token: 0x06001EEF RID: 7919 RVA: 0x003A3C3C File Offset: 0x003A203C
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

//// Token: 0x17000B92 RID: 2962
//// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x003A3C48 File Offset: 0x003A2048
//// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x003A3C5C File Offset: 0x003A205C
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

//// Token: 0x17000B93 RID: 2963
//// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x003A3C68 File Offset: 0x003A2068
//// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x003A3C7C File Offset: 0x003A207C
//internal virtual DataGridView DataGridView3
//{
//	get
//	{
//		return this._DataGridView3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DataGridView3 = value;
//	}
//}

//// Token: 0x17000B94 RID: 2964
//// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x003A3C88 File Offset: 0x003A2088
//// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x003A3C9C File Offset: 0x003A209C
//internal virtual DataGridViewTextBoxColumn Date1
//{
//	get
//	{
//		return this._Date1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Date1 = value;
//	}
//}

//// Token: 0x17000B95 RID: 2965
//// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x003A3CA8 File Offset: 0x003A20A8
//// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x003A3CBC File Offset: 0x003A20BC
//internal virtual DataGridViewTextBoxColumn Amount
//{
//	get
//	{
//		return this._Amount;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Amount = value;
//	}
//}

//// Token: 0x17000B96 RID: 2966
//// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x003A3CC8 File Offset: 0x003A20C8
//// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x003A3CDC File Offset: 0x003A20DC
//internal virtual DataGridViewTextBoxColumn Remark
//{
//	get
//	{
//		return this._Remark;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Remark = value;
//	}
//}

//// Token: 0x17000B97 RID: 2967
//// (get) Token: 0x06001EFA RID: 7930 RVA: 0x003A3CE8 File Offset: 0x003A20E8
//// (set) Token: 0x06001EFB RID: 7931 RVA: 0x003A3CFC File Offset: 0x003A20FC
//internal virtual DataGridViewTextBoxColumn partyamount
//{
//	get
//	{
//		return this._partyamount;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._partyamount = value;
//	}
//}

//// Token: 0x17000B98 RID: 2968
//// (get) Token: 0x06001EFC RID: 7932 RVA: 0x003A3D08 File Offset: 0x003A2108
//// (set) Token: 0x06001EFD RID: 7933 RVA: 0x003A3D1C File Offset: 0x003A211C
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

//// Token: 0x17000B99 RID: 2969
//// (get) Token: 0x06001EFE RID: 7934 RVA: 0x003A3D28 File Offset: 0x003A2128
//// (set) Token: 0x06001EFF RID: 7935 RVA: 0x003A3D3C File Offset: 0x003A213C
//internal virtual DateTimePicker DateTimePicker1
//{
//	get
//	{
//		return this._DateTimePicker1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DateTimePicker1 = value;
//	}
//}

//// Token: 0x17000B9A RID: 2970
//// (get) Token: 0x06001F00 RID: 7936 RVA: 0x003A3D48 File Offset: 0x003A2148
//// (set) Token: 0x06001F01 RID: 7937 RVA: 0x003A3D5C File Offset: 0x003A215C
//internal virtual Label Label2
//{
//	get
//	{
//		return this._Label2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label2 = value;
//	}
//}

//// Token: 0x17000B9B RID: 2971
//// (get) Token: 0x06001F02 RID: 7938 RVA: 0x003A3D68 File Offset: 0x003A2168
//// (set) Token: 0x06001F03 RID: 7939 RVA: 0x003A3D7C File Offset: 0x003A217C
//internal virtual DateTimePicker DateTimePicker2
//{
//	get
//	{
//		return this._DateTimePicker2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DateTimePicker2 = value;
//	}
//}

//// Token: 0x17000B9C RID: 2972
//// (get) Token: 0x06001F04 RID: 7940 RVA: 0x003A3D88 File Offset: 0x003A2188
//// (set) Token: 0x06001F05 RID: 7941 RVA: 0x003A3D9C File Offset: 0x003A219C
//internal virtual Label Label3
//{
//	get
//	{
//		return this._Label3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label3 = value;
//	}
//}

//// Token: 0x17000B9D RID: 2973
//// (get) Token: 0x06001F06 RID: 7942 RVA: 0x003A3DA8 File Offset: 0x003A21A8
//// (set) Token: 0x06001F07 RID: 7943 RVA: 0x003A3DBC File Offset: 0x003A21BC
//internal virtual Button Button3
//{
//	get
//	{
//		return this._Button3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button3_Click);
//		if (this._Button3 != null)
//		{
//			this._Button3.Click -= value2;
//		}
//		this._Button3 = value;
//		if (this._Button3 != null)
//		{
//			this._Button3.Click += value2;
//		}
//	}
//}

//// Token: 0x17000B9E RID: 2974
//// (get) Token: 0x06001F08 RID: 7944 RVA: 0x003A3E08 File Offset: 0x003A2208
//// (set) Token: 0x06001F09 RID: 7945 RVA: 0x003A3E1C File Offset: 0x003A221C
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

//// Token: 0x17000B9F RID: 2975
//// (get) Token: 0x06001F0A RID: 7946 RVA: 0x003A3E28 File Offset: 0x003A2228
//// (set) Token: 0x06001F0B RID: 7947 RVA: 0x003A3E3C File Offset: 0x003A223C
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

//// Token: 0x17000BA0 RID: 2976
//// (get) Token: 0x06001F0C RID: 7948 RVA: 0x003A3E48 File Offset: 0x003A2248
//// (set) Token: 0x06001F0D RID: 7949 RVA: 0x003A3E5C File Offset: 0x003A225C
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

//// Token: 0x17000BA1 RID: 2977
//// (get) Token: 0x06001F0E RID: 7950 RVA: 0x003A3E68 File Offset: 0x003A2268
//// (set) Token: 0x06001F0F RID: 7951 RVA: 0x003A3E7C File Offset: 0x003A227C
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

//// Token: 0x17000BA2 RID: 2978
//// (get) Token: 0x06001F10 RID: 7952 RVA: 0x003A3E88 File Offset: 0x003A2288
//// (set) Token: 0x06001F11 RID: 7953 RVA: 0x003A3E9C File Offset: 0x003A229C
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

//// Token: 0x17000BA3 RID: 2979
//// (get) Token: 0x06001F12 RID: 7954 RVA: 0x003A3EA8 File Offset: 0x003A22A8
//// (set) Token: 0x06001F13 RID: 7955 RVA: 0x003A3EBC File Offset: 0x003A22BC
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

//// Token: 0x17000BA4 RID: 2980
//// (get) Token: 0x06001F14 RID: 7956 RVA: 0x003A3EC8 File Offset: 0x003A22C8
//// (set) Token: 0x06001F15 RID: 7957 RVA: 0x003A3EDC File Offset: 0x003A22DC
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

//// Token: 0x17000BA5 RID: 2981
//// (get) Token: 0x06001F16 RID: 7958 RVA: 0x003A3EE8 File Offset: 0x003A22E8
//// (set) Token: 0x06001F17 RID: 7959 RVA: 0x003A3EFC File Offset: 0x003A22FC
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

//// Token: 0x17000BA6 RID: 2982
//// (get) Token: 0x06001F18 RID: 7960 RVA: 0x003A3F08 File Offset: 0x003A2308
//// (set) Token: 0x06001F19 RID: 7961 RVA: 0x003A3F1C File Offset: 0x003A231C
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

//// Token: 0x17000BA7 RID: 2983
//// (get) Token: 0x06001F1A RID: 7962 RVA: 0x003A3F28 File Offset: 0x003A2328
//// (set) Token: 0x06001F1B RID: 7963 RVA: 0x003A3F3C File Offset: 0x003A233C
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

//// Token: 0x17000BA8 RID: 2984
//// (get) Token: 0x06001F1C RID: 7964 RVA: 0x003A3F48 File Offset: 0x003A2348
//// (set) Token: 0x06001F1D RID: 7965 RVA: 0x003A3F5C File Offset: 0x003A235C
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

//// Token: 0x17000BA9 RID: 2985
//// (get) Token: 0x06001F1E RID: 7966 RVA: 0x003A3F68 File Offset: 0x003A2368
//// (set) Token: 0x06001F1F RID: 7967 RVA: 0x003A3F7C File Offset: 0x003A237C
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
