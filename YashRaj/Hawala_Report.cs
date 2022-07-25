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
//using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using App.Service;

namespace YashAksh
{

    [DesignerGenerated]
    public partial class Hawala_Report : Form
    {

        public Hawala_Report()
        {
            this.InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Hawala_Report_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.txtnu.Hide();
                this.txtnu.Text = Module1.decimalnumberformat;
                this.name_lode();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void name_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT Id,PartyName FROM PartyMaster ORDER BY PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.txtPartyName.Items.Clear();
                while (oleDbDataReader.Read())
                {
                    this.txtPartyName.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"])).ToString();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string fromdate = Conversions.ToDate(this.dtpFrom.Text).ToString("yyyy-MM-dd");
                string todate = Conversions.ToDate(this.dtpTo.Text).ToString("yyyy-MM-dd");

                //string cmdText = string.Concat(new string[]
                //{
                //    "SELECT T1.*,(SELECT tns_party FROM Trans T2 WHERE T2.tns_Type='DR' AND T2.tns_ModifyID=T1.tns_ModifyID) as DrParty FROM Trans T1 ",
                //    "WHERE (T1.tns_Type IN ('CR','DR')) AND (T1.tns_ModifyID<>0) AND (tns_dt>=#" + fromdate + "#) AND (tns_dt<=#" + todate + "#) ",
                //    txtPartyName.Text != "" ? "AND (T1.tns_party='"+ txtPartyName.Text +"') " : " ",
                //    chkDeleted.Checked == true ? "AND (T1.tns_chk='1') " : " ",
                //    "ORDER BY ID"
                //});

                string cmdText = string.Concat(new string[]
               {
                    "SELECT T1.*,(SELECT tns_party FROM Trans T2 WHERE T2.tns_Type='DR' AND T2.tns_ModifyID=T1.tns_ModifyID) as DrParty FROM Trans T1 ",
                    "WHERE (T1.tns_Type ='CR') AND (T1.tns_ModifyID<>0) AND (tns_dt>=#" + fromdate + "#) AND (tns_dt<=#" + todate + "#) ",
                    txtPartyName.Text != "" ? "AND (T1.tns_party='"+ txtPartyName.Text +"') " : " ",
                    chkDeleted.Checked == true ? "AND (T1.tns_chk='1') " : " ",
                    "ORDER BY ID"
               });

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_ModifyID"]);
                    this.DataGridView1.Rows[index].Cells[1].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["tns_dt"]), DateFormat.ShortDate);
                    this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_party"]);
                    this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"]), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["DrParty"]);
                    this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Remark"]);                    
                    this.DataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_date"]);
                    this.DataGridView1.Rows[index].Cells[7].Value = Strings.FormatDateTime(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_time"])), DateFormat.LongTime);
                    this.DataGridView1.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["modify_date"]);
                    this.DataGridView1.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["modify_time"]);

                    if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_chk"].ToString())) == 1.0)
                    {
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                        //this.DataGridView1.Rows[index].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                    }
                    else if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["modify"].ToString())) == 1.0)
                    {
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["chk"].ToString())) == 1.0)
                    {
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Lime;
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


        private void Hawala_Report_KeyDown(object sender, KeyEventArgs e)
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


        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                DataTable dataTable2 = dataTable;
                dataTable2.Columns.Add("Column1");
                dataTable2.Columns.Add("Column2");
                dataTable2.Columns.Add("Column3");
                dataTable2.Columns.Add("Column4");
                dataTable2.Columns.Add("Column5");
                dataTable2.Columns.Add("Column6");
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        dataTable.Rows.Add(new object[]
                        {
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Column1"].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Column2"].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Column3"].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Column4"].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Column5"].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Column6"].Value)
                        });
                    }
                }
                finally
                {
                }
                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\HReport.rpt");
                reportDocument.SetDataSource(dataTable);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtPartyName = this.txtPartyName;
                this.AutoComplete(ref txtPartyName, e, false);
                this.txtPartyName = txtPartyName;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtPartyName.SelectionStart <= 1)
                        {
                            this.txtPartyName.Text = "";
                            return;
                        }
                        if (this.txtPartyName.SelectionLength == 0)
                        {
                            text = this.txtPartyName.Text.Substring(0, this.txtPartyName.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtPartyName.Text.Substring(0, this.txtPartyName.SelectionStart - 1);
                        }
                    }
                    else if (this.txtPartyName.SelectionLength == 0)
                    {
                        text = this.txtPartyName.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtPartyName.Text.Substring(0, this.txtPartyName.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtPartyName.FindString(text);
                    if (num != -1)
                    {
                        this.txtPartyName.SelectedText = "";
                        this.txtPartyName.SelectedIndex = num;
                        this.txtPartyName.SelectionStart = text.Length;
                        this.txtPartyName.SelectionLength = this.txtPartyName.Text.Length;
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
    }
}
