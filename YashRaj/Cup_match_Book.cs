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
    // Token: 0x0200000E RID: 14
    //[DesignerGenerated]
    public partial class Cup_match_Book : Form
    {
        // Token: 0x060003E9 RID: 1001 RVA: 0x002A01E8 File Offset: 0x0029E5E8

        string strrpthead = "";
        public Cup_match_Book()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000420 RID: 1056 RVA: 0x002A16E4 File Offset: 0x0029FAE4
        private void Cup_match_Book_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.TextBox1.Hide();
                this.txtnu.Hide();
                this.CheckBox2.Hide();
                this.txtnu.Text = Module1.decimalnumberformat;
                this.TextBox1.Text = Conversions.ToString(Module1.IDCUP);
                this.all_CUP_Lode();
                this.Match_Books_Coup();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000421 RID: 1057 RVA: 0x002A1770 File Offset: 0x0029FB70
        public void Match_Books_Coup()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7,  SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9, SUM(CupTrans.m_team10) AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12,  SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15, CupTrans.m_checked, CupTrans.m_id FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, CupTrans.m_checked, CupTrans.m_id HAVING (CupTrans.m_checked <> 1) AND (CupTrans.m_id = " + this.TextBox1.Text + ") ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num3 = 0;
                double num5 = 0;
                double num7 = 0;
                double num9 = 0;
                double num11 = 0;
                double num13 = 0;
                double num15 = 0;
                double num17 = 0;
                double num19 = 0;
                double num21 = 0;
                double num23 = 0;
                double num25 = 0;
                double num27 = 0;
                double num29 = 0;
                double num31 = 0;
                while (oleDbDataReader.Read())
                {
                    double num = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"]));
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                    this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])), this.txtnu.Text);
                    this.DataGridView1.Rows[index].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])), this.txtnu.Text);
                    double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
                    num3 += Convert.ToDouble(Conversion.Val(num2) * Conversion.Val(num) / 100 - Conversion.Val(num2));
                    double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"]));
                    num5 += Convert.ToDouble(Conversion.Val(num4) * Conversion.Val(num) / 100 - Conversion.Val(num4));
                    double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"]));
                    num7 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(num) / 100 - Conversion.Val(num6));
                    double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"]));
                    num9 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(num) / 100 - Conversion.Val(num8));
                    double num10 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"]));
                    num11 += Convert.ToDouble(Conversion.Val(num10) * Conversion.Val(num) / 100 - Conversion.Val(num10));
                    double num12 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"]));
                    num13 += Convert.ToDouble(Conversion.Val(num12) * Conversion.Val(num) / 100 - Conversion.Val(num12));
                    double num14 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"]));
                    num15 += Convert.ToDouble(Conversion.Val(num14) * Conversion.Val(num) / 100 - Conversion.Val(num14));
                    double num16 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"]));
                    num17 += Convert.ToDouble(Conversion.Val(num16) * Conversion.Val(num) / 100 - Conversion.Val(num16));
                    double num18 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"]));
                    num19 += Convert.ToDouble(Conversion.Val(num18) * Conversion.Val(num) / 100 - Conversion.Val(num18));
                    double num20 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"]));
                    num21 += Convert.ToDouble(Conversion.Val(num20) * Conversion.Val(num) / 100 - Conversion.Val(num20));
                    double num22 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"]));
                    num23 += Convert.ToDouble(Conversion.Val(num22) * Conversion.Val(num) / 100 - Conversion.Val(num22));
                    double num24 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"]));
                    num25 += Convert.ToDouble(Conversion.Val(num24) * Conversion.Val(num) / 100 - Conversion.Val(num24));
                    double num26 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"]));
                    num27 += Convert.ToDouble(Conversion.Val(num26) * Conversion.Val(num) / 100 - Conversion.Val(num26));
                    double num28 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"]));
                    num29 += Convert.ToDouble(Conversion.Val(num28) * Conversion.Val(num) / 100 - Conversion.Val(num28));
                    double num30 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"]));
                    num31 += Convert.ToDouble(Conversion.Val(num30) * Conversion.Val(num) / 100 - Conversion.Val(num30));
                }
                this.DataGridView1.Rows.Add();
                this.DataGridView1.Rows.Add();
                this.DataGridView1.Rows.Add(new object[]
                {
                    "TOTAL",
                    Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num19), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num21), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num23), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num25), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num27), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num29), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(num31), this.txtnu.Text)
                });
                int num32 = 0;
                checked
                {
                    int num33 = this.DataGridView1.Rows.Count - 1;
                    for (int i = num32; i <= num33; i++)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[1].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[2].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[3].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[4].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[5].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[6].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[7].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[8].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[9].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[10].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[11].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[11].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[11].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[12].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[12].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[12].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[13].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[13].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[13].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[14].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[14].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[14].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[i].Cells[15].Value, 0, false))
                            {
                                this.DataGridView1.Rows[i].Cells[15].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[15].Style.ForeColor = Color.Green;
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

        // Token: 0x06000423 RID: 1059 RVA: 0x002A3114 File Offset: 0x002A1514
        public void all_CUP_Lode()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox1.Text + "";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        this.Label2.Text = Conversions.ToString(oleDbDataReader[1]);
                        object objectValue = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
                        object objectValue2 = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
                        object objectValue3 = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                        object objectValue4 = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                        this.DataGridView1.Columns[1].HeaderText = Conversions.ToString(oleDbDataReader[5]);
                        this.DataGridView1.Columns[2].HeaderText = Conversions.ToString(oleDbDataReader[6]);
                        this.DataGridView1.Columns[3].HeaderText = Conversions.ToString(oleDbDataReader[7]);
                        this.DataGridView1.Columns[4].HeaderText = Conversions.ToString(oleDbDataReader[8]);
                        this.DataGridView1.Columns[5].HeaderText = Conversions.ToString(oleDbDataReader[9]);
                        this.DataGridView1.Columns[6].HeaderText = Conversions.ToString(oleDbDataReader[10]);
                        this.DataGridView1.Columns[7].HeaderText = Conversions.ToString(oleDbDataReader[11]);
                        this.DataGridView1.Columns[8].HeaderText = Conversions.ToString(oleDbDataReader[12]);
                        this.DataGridView1.Columns[9].HeaderText = Conversions.ToString(oleDbDataReader[13]);
                        this.DataGridView1.Columns[10].HeaderText = Conversions.ToString(oleDbDataReader[14]);
                        this.DataGridView1.Columns[11].HeaderText = Conversions.ToString(oleDbDataReader[15]);
                        this.DataGridView1.Columns[12].HeaderText = Conversions.ToString(oleDbDataReader[16]);
                        this.DataGridView1.Columns[13].HeaderText = Conversions.ToString(oleDbDataReader[17]);
                        this.DataGridView1.Columns[14].HeaderText = Conversions.ToString(oleDbDataReader[18]);
                        this.DataGridView1.Columns[15].HeaderText = Conversions.ToString(oleDbDataReader[19]);
                        this.strrpthead = objectValue2 + "     " + objectValue3 + "   VS   " + objectValue4 + "    " + objectValue;
                        this.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue2, "     "), objectValue3), "   "), "VS"), "   "), objectValue4), "    "), objectValue));
                    }
                    int num = 1;
                    do
                    {
                        if (Operators.CompareString(this.DataGridView1.Columns[num].HeaderText, "", false) != 0)
                        {
                            this.DataGridView1.Columns[num].Visible = true;
                        }
                        num++;
                    }
                    while (num <= 15);
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

        // Token: 0x06000424 RID: 1060 RVA: 0x002A34D0 File Offset: 0x002A18D0
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cup_Report cup_Report = new Cup_Report();
                cup_Report.MdiParent = this.MdiParent;
                cup_Report.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000425 RID: 1061 RVA: 0x002A3538 File Offset: 0x002A1938
        private void Cup_match_Book_KeyDown(object sender, KeyEventArgs e)
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

        // Token: 0x06000426 RID: 1062 RVA: 0x002A354C File Offset: 0x002A194C
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable("DataTable8");
                dataTable.Columns.Add("CUP_INFO");
                dataTable.Columns.Add("Party_Name");
                dataTable.Columns.Add("1");
                dataTable.Columns.Add("2");
                dataTable.Columns.Add("3");
                dataTable.Columns.Add("4");
                dataTable.Columns.Add("5");
                dataTable.Columns.Add("6");
                dataTable.Columns.Add("7");
                dataTable.Columns.Add("8");
                dataTable.Columns.Add("9");
                dataTable.Columns.Add("10");
                dataTable.Columns.Add("11");
                dataTable.Columns.Add("12");
                dataTable.Columns.Add("13");
                dataTable.Columns.Add("14");
                dataTable.Columns.Add("15");
                dataTable.Columns.Add("16");
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        dataTable.Rows.Add(new object[]
                        {
							//this.Label2.Text,
							this.strrpthead,
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[4].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[7].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[8].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[9].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[10].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[11].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[12].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[13].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[14].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[15].Value)
                        });
                    }
                }
                finally
                {
                    Module1.conn.Close();
                }
                //Add RPT
                //cup_book cup_book = new cup_book();
                //cup_book.SetDataSource(dataTable);
                //cup_book.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\cup_book.rpt");
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

    }
}
