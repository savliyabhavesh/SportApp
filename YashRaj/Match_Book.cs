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
    // Token: 0x02000054 RID: 84
    //[DesignerGenerated]
    public partial class Match_Book : Form
    {
        // Token: 0x060014DA RID: 5338 RVA: 0x003584B4 File Offset: 0x003568B4

        string strrpthead = "";
        public Match_Book()
        {
            //this.TeamFoumula = new TextBox();
            //this.txtid = new TextBox();

            this.txtnu = new TextBox();
            this.txtparsent = new TextBox();
            this.id = new TextBox();
            this.txtsrno = new TextBox();
            this.cmbostus = new TextBox();

            this.txttime = new TextBox();
            this.txtpak = new TextBox();
            this.txtend = new TextBox();
            this.txtsut = new TextBox();
            this.txtind = new TextBox();
            this.txtmpar = new TextBox();
            this.txtmodify = new TextBox();
            this.InitializeComponent();
        }

        // Token: 0x06001557 RID: 5463 RVA: 0x0035B63C File Offset: 0x00359A3C
        private void Match_Book_Load(object sender, EventArgs e)
        {
            try
            {

                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(103, 36);
                    txtrate.Location = new Point(13, 36);

                    Label12.Text = "Amount";
                    Label11.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.txtnu.Text = Module1.decimalnumberformat;
                this.DataGridView4.Rows.Add();
                this.WindowState = FormWindowState.Maximized;

                this.TextBox1.Text = Conversions.ToString(Module1.matchbooklist);
                this.listviewaddalldata();

                this.combolod();
                this.TextBox1.Hide();
                this.txtdate.Hide();
                this.Decliar_New();
                this.Decleard();
                this.Button4.Hide();
                this.Button5.Hide();
                this.ComboBox1.Hide();
                this.DataGridView1.ReadOnly = false;

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001559 RID: 5465 RVA: 0x0035B838 File Offset: 0x00359C38
        public void listviewaddalldata()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.cmbteam.Items.Clear();
                string cmdText = "Select* from Newmatch where Sr_No=" + this.TextBox1.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.cmbteam.Items.Add(oleDbDataReader["horse1"].ToString());
                    this.cmbteam.Items.Add(oleDbDataReader["horse2"].ToString());
                    if (Operators.CompareString(oleDbDataReader["horse3"].ToString(), null, false) != 0)
                    {
                        this.cmbteam.Items.Add(oleDbDataReader["horse3"].ToString());
                    }
                    if (Operators.CompareString(oleDbDataReader["horse4"].ToString(), null, false) != 0)
                    {
                        this.cmbteam.Items.Add(oleDbDataReader["horse4"].ToString());
                    }
                    this.DataGridView1.Columns[1].HeaderText = Conversions.ToString(oleDbDataReader[2]);
                    this.DataGridView1.Columns[2].HeaderText = Conversions.ToString(oleDbDataReader[3]);
                    this.DataGridView1.Columns[3].HeaderText = Conversions.ToString(oleDbDataReader[7]);
                    this.DataGridView1.Columns[4].HeaderText = Conversions.ToString(oleDbDataReader[8]);
                    this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[0].Cells[0].Value = "Name";
                    this.DataGridView2.Rows[0].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
                    this.DataGridView2.Rows[0].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
                    this.DataGridView2.Rows[0].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    this.DataGridView2.Rows[0].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
                    this.DataGridView3.Columns[8].HeaderText = oleDbDataReader["horse1"].ToString();
                    this.DataGridView3.Columns[9].HeaderText = oleDbDataReader["horse2"].ToString();
                    this.DataGridView3.Columns[10].HeaderText = oleDbDataReader["horse3"].ToString();
                    this.DataGridView3.Columns[11].HeaderText = oleDbDataReader["horse4"].ToString();
                    this.DataGridView4.Columns[0].HeaderText = oleDbDataReader["horse1"].ToString();
                    this.DataGridView4.Columns[1].HeaderText = oleDbDataReader["horse2"].ToString();
                    this.DataGridView4.Columns[2].HeaderText = oleDbDataReader["horse3"].ToString();
                    this.DataGridView4.Columns[3].HeaderText = oleDbDataReader["horse4"].ToString();
                    this.strrpthead = oleDbDataReader[2] + "   VS   " + oleDbDataReader[3] + "      " + "  ( " + oleDbDataReader[4] + " )";
                    this.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader[2], "   VS   "), oleDbDataReader[3]), "      "), "  ( "), oleDbDataReader[4]), " )      "), oleDbDataReader[1]));
                }
                Module1.conn.Close();
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows[1].Cells[0].Value = "-------------------------------------------------------------------------------";
                this.DataGridView2.Rows[1].Cells[1].Value = "---------------------------------------------------------------------------------";
                this.DataGridView2.Rows[1].Cells[2].Value = "----------------------------------------------------------------------------------";
                this.DataGridView2.Rows[1].Cells[3].Value = "-----------------------------------------------------------------------------------";
                this.DataGridView2.Rows[1].Cells[4].Value = "------------------------------------------------------------------------------------";
                if (Operators.CompareString(this.DataGridView1.Columns[3].HeaderText, null, false) == 0)
                {
                    this.DataGridView1.Columns[3].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView1.Columns[4].HeaderText, null, false) == 0)
                {
                    this.DataGridView1.Columns[4].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[10].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[11].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView4.Columns[3].HeaderText, null, false) == 0)
                {
                    this.DataGridView4.Columns[3].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView4.Columns[2].HeaderText, null, false) == 0)
                {
                    this.DataGridView4.Columns[2].Visible = false;
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

        // Token: 0x0600155A RID: 5466 RVA: 0x0035BEEC File Offset: 0x0035A2EC
        private void Button3_Click(object sender, EventArgs e)
        {
            //MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
            //MyProject.Forms.Match_Report.WindowState = FormWindowState.Maximized;
            //MyProject.Forms.Match_Report.Show();
            this.Close();
        }

        // Token: 0x0600155B RID: 5467 RVA: 0x0035BF28 File Offset: 0x0035A328
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                DataTable dataTable2 = dataTable;
                dataTable2.Columns.Add("pname");
                dataTable2.Columns.Add("t1");
                dataTable2.Columns.Add("t2");
                dataTable2.Columns.Add("t3");
                dataTable2.Columns.Add("t4");
                dataTable2.Columns.Add("mn");
                dataTable2.Columns.Add("p1");
                dataTable2.Columns.Add("p2");
                dataTable2.Columns.Add("p3");
                dataTable2.Columns.Add("p4");
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        dataTable.Rows.Add(new object[]
                        {
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[4].Value),
							//this.Label2.Text,
							this.strrpthead,
                            this.DataGridView1.Columns[1].HeaderText,
                            this.DataGridView1.Columns[2].HeaderText,
                            this.DataGridView1.Columns[3].HeaderText,
                            this.DataGridView1.Columns[4].HeaderText
                        });
                    }
                }
                finally
                {
                    Module1.conn.Close();
                }
                //Add RPT
                //bookprint bookprint = new bookprint();
                //bookprint.SetDataSource(dataTable);
                //bookprint.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\bookprint.rpt");
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

        // Token: 0x0600155C RID: 5468 RVA: 0x0035C1B8 File Offset: 0x0035A5B8
        public void Decliar_New()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.Status, MatchTrans.m_id, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.PartyName HAVING (MatchTrans.m_checked=0) AND (MatchTrans.m_id = " + this.TextBox1.Text + ") ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num21 = 0;
                double num32 = 0;
                double num43 = 0;
                double num54 = 0;
                while (oleDbDataReader.Read())
                {
                    double num = 0; //Convert.ToDouble(oleDbDataReader["SMatchCommi"].ToString());
                    double num2 = 0;
                    double num3 = 0;
                    double num4 = 0;
                    string text = oleDbDataReader["AParty"].ToString();
                    string text2 = oleDbDataReader["TParty"].ToString();
                    double num5 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    double num6 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    double num7 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    double num8 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num9 = Conversion.Val(num3) + Conversion.Val(num4);
                    double num10 = Conversion.Val(num5) * Conversion.Val(0) / 100 - Conversion.Val(num5);
                    double num11 = Conversion.Val(num6) * Conversion.Val(0) / 100 - Conversion.Val(num6);
                    double num12 = Conversion.Val(num7) * Conversion.Val(0) / 100 - Conversion.Val(num7);
                    double num13 = Conversion.Val(num8) * Conversion.Val(0) / 100 - Conversion.Val(num8);
                    double num17 = 0;
                    double num20 = 0;
                    if (num10 < 0.0)
                    {
                        double num14 = Conversion.Val(num10) * Conversion.Val(num) / 100;
                        double num15 = Conversion.Val(num10) + Conversion.Val(num14) - Conversion.Val(num14) - Conversion.Val(num14);
                        double num16 = Conversion.Val(num15) * Conversion.Val(num2) / 100 - Conversion.Val(num15);
                        num17 = num16;
                        double num18 = Conversion.Val(num16) * Conversion.Val(num9) / 100 - Conversion.Val(num16);
                        double num19 = Conversion.Val(num16) * Conversion.Val(num3) / 100;
                        num20 += Convert.ToDouble(Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19));
                        num21 += Convert.ToDouble(Conversion.Val(num18) - Conversion.Val(num18) - Conversion.Val(num18));
                    }
                    else
                    {
                        double num22 = Conversion.Val(num10) * Conversion.Val(num2) / 100 - Conversion.Val(num10);
                        num17 = num22;
                        double num23 = Conversion.Val(num22) * Conversion.Val(num9) / 100 - Conversion.Val(num22);
                        double num24 = Conversion.Val(num23) * Conversion.Val(num3) / 100;
                        num20 += Convert.ToDouble(Conversion.Val(num24) - Conversion.Val(num24) - Conversion.Val(num24));
                        num21 += Convert.ToDouble(Conversion.Val(num23) - Conversion.Val(num23) - Conversion.Val(num23));
                    }
                    double num28 = 0;
                    double num31 = 0;
                    if (num11 < 0.0)
                    {
                        double num25 = Conversion.Val(num11) * Conversion.Val(num) / 100;
                        double num26 = Conversion.Val(num11) + Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25);
                        double num27 = Conversion.Val(num26) * Conversion.Val(num2) / 100 - Conversion.Val(num26);
                        num28 = num27;
                        double num29 = Conversion.Val(num27) * Conversion.Val(num9) / 100 - Conversion.Val(num27);
                        double num30 = Conversion.Val(num27) * Conversion.Val(num3) / 100;
                        num31 += Convert.ToDouble(Conversion.Val(num30) - Conversion.Val(num30) - Conversion.Val(num30));
                        num32 += Convert.ToDouble(Conversion.Val(num29) - Conversion.Val(num29) - Conversion.Val(num29));
                    }
                    else
                    {
                        double num33 = Conversion.Val(num11) * Conversion.Val(num2) / 100 - Conversion.Val(num11);
                        num28 = num33;
                        double num34 = Conversion.Val(num33) * Conversion.Val(num9) / 100 - Conversion.Val(num33);
                        double num35 = Conversion.Val(num33) * Conversion.Val(num3) / 100;
                        num31 += Convert.ToDouble(Conversion.Val(num35) - Conversion.Val(num35) - Conversion.Val(num35));
                        num32 += Convert.ToDouble(Conversion.Val(num34) - Conversion.Val(num34) - Conversion.Val(num34));
                    }
                    double num39 = 0;
                    double num42 = 0;
                    if (num12 < 0.0)
                    {
                        double num36 = Conversion.Val(num12) * Conversion.Val(num) / 100;
                        double num37 = Conversion.Val(num12) + Conversion.Val(num36) - Conversion.Val(num36) - Conversion.Val(num36);
                        double num38 = Conversion.Val(num37) * Conversion.Val(num2) / 100 - Conversion.Val(num37);
                        num39 = num38;
                        double num40 = Conversion.Val(num38) * Conversion.Val(num9) / 100 - Conversion.Val(num38);
                        double num41 = Conversion.Val(num38) * Conversion.Val(num3) / 100;
                        num42 += Convert.ToDouble(Conversion.Val(num41) - Conversion.Val(num41) - Conversion.Val(num41));
                        num43 += Convert.ToDouble(Conversion.Val(num40) - Conversion.Val(num40) - Conversion.Val(num40));
                    }
                    else
                    {
                        double num44 = Conversion.Val(num12) * Conversion.Val(num2) / 100 - Conversion.Val(num12);
                        num39 = num44;
                        double num45 = Conversion.Val(num44) * Conversion.Val(num9) / 100 - Conversion.Val(num44);
                        double num46 = Conversion.Val(num44) * Conversion.Val(num3) / 100;
                        num42 += Convert.ToDouble(Conversion.Val(num46) - Conversion.Val(num46) - Conversion.Val(num46));
                        num43 += Convert.ToDouble(Conversion.Val(num45) - Conversion.Val(num45) - Conversion.Val(num45));
                    }
                    double num50 = 0;
                    double num53 = 0;
                    if (num13 < 0.0)
                    {
                        double num47 = Conversion.Val(num13) * Conversion.Val(num) / 100;
                        double num48 = Conversion.Val(num13) + Conversion.Val(num47) - Conversion.Val(num47) - Conversion.Val(num47);
                        double num49 = Conversion.Val(num48) * Conversion.Val(num2) / 100 - Conversion.Val(num48);
                        num50 = num49;
                        double num51 = Conversion.Val(num49) * Conversion.Val(num9) / 100 - Conversion.Val(num49);
                        double num52 = Conversion.Val(num49) * Conversion.Val(num3) / 100;
                        num53 += Convert.ToDouble(Conversion.Val(num52) - Conversion.Val(num52) - Conversion.Val(num52));
                        num54 += Convert.ToDouble(Conversion.Val(num51) - Conversion.Val(num51) - Conversion.Val(num51));
                    }
                    else
                    {
                        double num55 = Conversion.Val(num13) * Conversion.Val(num2) / 100 - Conversion.Val(num13);
                        num50 = num55;
                        double num56 = Conversion.Val(num55) * Conversion.Val(num9) / 100 - Conversion.Val(num55);
                        double num57 = Conversion.Val(num55) * Conversion.Val(num3) / 100;
                        num53 += Convert.ToDouble(Conversion.Val(num57) - Conversion.Val(num57) - Conversion.Val(num57));
                        num54 += Convert.ToDouble(Conversion.Val(num56) - Conversion.Val(num56) - Conversion.Val(num56));
                    }

                    string cmdText2 = string.Concat(new string[]
                    {
                        "SELECT m_id, M_chk, m_party FROM (MatchTrans) WHERE (m_checked = 0) AND (m_id = ",
                        this.TextBox1.Text,
                        ") AND (m_party = '",
                        oleDbDataReader["PartyName"].ToString(),
                        "')AND (M_chk=1)"
                    });
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    if (oleDbDataReader2.Read())
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num28), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num39), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num50), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[5].Value = true;
                        this.DataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LimeGreen;
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        int index2 = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index2].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        this.DataGridView1.Rows[index2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num28), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num39), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num50), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[5].Value = false;
                    }
                    num20 = 0.0;
                    num31 = 0.0;
                    num42 = 0.0;
                    num53 = 0.0;
                }
                this.AGENT_TOTAL();
                this.THIRDPARTY_TOTAL();

                Module1.machid = Conversions.ToInteger(this.TextBox1.Text);
                MyProject.Forms.Match.Show();
                this.DataGridView1.Rows.Add();
                this.DataGridView1.Rows.Add(new object[]
                {
                    "TOTAL :",
                    Module1.SetNumFormat(Conversion.Val(Module1.exp1_matchbook_total), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(Module1.exp2_matchbook_total), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(Module1.exp3_matchbook_total), this.txtnu.Text),
                    Module1.SetNumFormat(Conversion.Val(Module1.exp4_matchbook_total), this.txtnu.Text),
                    false
                });
                MyProject.Forms.Match.Close();
                Module1.chkmatchbook = false;

                //this.DataGridView1.Rows.Add();
                //this.DataGridView1.Rows.Add(new object[]
                //{
                //	"TOTAL :",
                //	Module1.SetNumFormat(Conversion.Val(num21), this.txtnu.Text),
                //	Module1.SetNumFormat(Conversion.Val(num32), this.txtnu.Text),
                //	Module1.SetNumFormat(Conversion.Val(num43), this.txtnu.Text),
                //	Module1.SetNumFormat(Conversion.Val(num54), this.txtnu.Text),
                //	false
                //});


                num21 = Convert.ToDouble("0.00");
                num32 = Convert.ToDouble("0.00");
                num43 = Convert.ToDouble("0.00");
                num54 = Convert.ToDouble("0.00");


                checked
                {
                    for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
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
                        }
                    }
                    this.DataGridView1.ReadOnly = false;
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

        // Token: 0x0600155D RID: 5469 RVA: 0x0035D4A8 File Offset: 0x0035B8A8
        public void AGENT_TOTAL()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT DISTINCT AParty FROM PartyMaster WHERE (AParty <> '')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    string cmdText2 = string.Concat(new string[]
                    {
                        "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)    AS Expr4, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE(MatchTrans.m_checked <> 1) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch HAVING        (MatchTrans.m_id = ",
                        this.TextBox1.Text,
                        ") AND (PartyMaster.AParty='",
                        oleDbDataReader["AParty"].ToString(),
                        "') "
                    });
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    string left = "";
                    double num9 = 0;
                    double num10 = 0;
                    double num11 = 0;
                    double num12 = 0;
                    while (oleDbDataReader2.Read())
                    {
                        left = "1";
                        string text = oleDbDataReader2["AParty"].ToString();
                        string text2 = oleDbDataReader2["TParty"].ToString();
                        if (Operators.CompareString(oleDbDataReader2["m_id"].ToString(), this.TextBox1.Text.ToString(), false) == 0)
                        {
                            double num = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr1"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num2 = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr2"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num3 = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr3"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num4 = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr4"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num5 = Conversion.Val(oleDbDataReader2["Expr1"]) - Conversion.Val(num);
                            double num6 = Conversion.Val(oleDbDataReader2["Expr2"]) - Conversion.Val(num2);
                            double num7 = Conversion.Val(oleDbDataReader2["Expr3"]) - Conversion.Val(num3);
                            double num8 = Conversion.Val(oleDbDataReader2["Expr4"]) - Conversion.Val(num4);
                            if (Operators.CompareString(oleDbDataReader2["AParty"].ToString(), text.ToString(), false) == 0)
                            {
                                num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(oleDbDataReader2["AMatch"]) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(oleDbDataReader2["AMatch"]) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(oleDbDataReader2["AMatch"]) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(oleDbDataReader2["AMatch"]) / 100);
                            }
                        }
                    }
                    if (Operators.CompareString(left, "1", false) == 0)
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader["AParty"].ToString();
                        this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num12) - Conversion.Val(num12) - Conversion.Val(num12), this.txtnu.Text);
                    }
                    left = "";
                    num9 = 0.0;
                    num10 = 0.0;
                    num11 = 0.0;
                    num12 = 0.0;
                    oleDbCommand2.Clone();
                    oleDbDataReader2.Close();
                }
                oleDbCommand.Clone();
                oleDbDataReader.Close();
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

        // Token: 0x0600155E RID: 5470 RVA: 0x0035DAB4 File Offset: 0x0035BEB4
        public void THIRDPARTY_TOTAL()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT DISTINCT TParty FROM PartyMaster WHERE (TParty <> '')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    string cmdText2 = string.Concat(new string[]
                    {
                        "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE(MatchTrans.m_checked <> 1) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch HAVING (MatchTrans.m_id = ",
                        this.TextBox1.Text,
                        ") AND (PartyMaster.TParty='",
                        oleDbDataReader["TParty"].ToString(),
                        "') "
                    });
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    string left = "";
                    double num9 = 0;
                    double num10 = 0;
                    double num11 = 0;
                    double num12 = 0;
                    while (oleDbDataReader2.Read())
                    {
                        left = "1";
                        string text = oleDbDataReader2["AParty"].ToString();
                        string text2 = oleDbDataReader2["TParty"].ToString();
                        if (Operators.CompareString(oleDbDataReader2["m_id"].ToString(), this.TextBox1.Text.ToString(), false) == 0)
                        {
                            double num = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr1"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num2 = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr2"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num3 = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr3"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num4 = Convert.ToDouble(Conversion.Val(oleDbDataReader2["Expr4"]) * Conversion.Val(oleDbDataReader2["SMatch"]) / 100);
                            double num5 = Conversion.Val(oleDbDataReader2["Expr1"]) - Conversion.Val(num);
                            double num6 = Conversion.Val(oleDbDataReader2["Expr2"]) - Conversion.Val(num2);
                            double num7 = Conversion.Val(oleDbDataReader2["Expr3"]) - Conversion.Val(num3);
                            double num8 = Conversion.Val(oleDbDataReader2["Expr4"]) - Conversion.Val(num4);
                            if (Operators.CompareString(oleDbDataReader2["TParty"].ToString(), text2.ToString(), false) == 0)
                            {
                                num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(oleDbDataReader2["TMatch"]) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(oleDbDataReader2["TMatch"]) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(oleDbDataReader2["TMatch"]) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(oleDbDataReader2["TMatch"]) / 100);
                            }
                        }
                    }
                    if (Operators.CompareString(left, "1", false) == 0)
                    {
                        int index = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader["TParty"].ToString();
                        this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num12) - Conversion.Val(num12) - Conversion.Val(num12), this.txtnu.Text);
                    }
                    left = "";
                    num9 = 0.0;
                    num10 = 0.0;
                    num11 = 0.0;
                    num12 = 0.0;
                    oleDbCommand2.Clone();
                    oleDbDataReader2.Close();
                }
                oleDbCommand.Clone();
                oleDbDataReader.Close();
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

        // Token: 0x06001560 RID: 5472 RVA: 0x0035E0C4 File Offset: 0x0035C4C4
        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.DataGridView4.Rows.Clear();
                this.DataGridView4.Rows.Add();
                //this.DataGridView4.Rows.Add();
                //this.DataGridView4.Rows.Add();
                this.All_DPP_SHWO();
                this.nptotal();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001561 RID: 5473 RVA: 0x0035E150 File Offset: 0x0035C550
        public void All_DPP_SHWO()
        {
            checked
            {
                try
                {
                    this.DataGridView3.Rows.Clear();
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                    {
                        this.DataGridView3.Rows.Clear();
                    }
                    else
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT id, m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, Modify, m_checked, M_chk, modify_time, modify_date FROM MatchTrans WHERE (m_id = " + this.TextBox1.Text + ") AND (m_party = '", this.DataGridView1.CurrentRow.Cells[0].Value), "') ORDER BY m_eid DESC"));
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        while (oleDbDataReader.Read())
                        {
                            int num = this.DataGridView3.Rows.Add();
                            this.DataGridView3.Rows[num].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                            if (Module1.isratefirst == true)
                            {
                                this.DataGridView3.Rows[num].Cells[3].Value = Module1.SetNumFormat(oleDbDataReader["m_amt"], this.txtnu.Text);
                                this.DataGridView3.Columns[3].HeaderText = "Amount";
                                this.DataGridView3.Rows[num].Cells[2].Value = oleDbDataReader["m_rate"].ToString();
                                this.DataGridView3.Columns[2].HeaderText = "Rate";
                            }
                            else
                            {
                                this.DataGridView3.Rows[num].Cells[2].Value = Module1.SetNumFormat(oleDbDataReader["m_amt"], this.txtnu.Text);
                                this.DataGridView3.Rows[num].Cells[3].Value = oleDbDataReader["m_rate"].ToString();
                            }

                            this.DataGridView3.Rows[num].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                            this.DataGridView3.Rows[num].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                            this.DataGridView3.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                            this.DataGridView3.Rows[num].Cells[7].Value = oleDbDataReader["m_dt"].ToString();
                            this.DataGridView3.Rows[num].Cells[8].Value = Module1.SetNumFormat(oleDbDataReader["m_team1"], this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[9].Value = Module1.SetNumFormat(oleDbDataReader["m_team2"], this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[10].Value = Module1.SetNumFormat(oleDbDataReader["m_team3"], this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[11].Value = Module1.SetNumFormat(oleDbDataReader["m_team4"], this.txtnu.Text);

                            this.DataGridView3.Rows[num].Cells[12].Value = oleDbDataReader["modify_time"].ToString();
                            this.DataGridView3.Rows[num].Cells[13].Value = oleDbDataReader["modify_date"].ToString();

                            //this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                            double num2 = (double)(num + 1);

                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["m_checked"], "1", false))
                            {
                                this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                                //this.DataGridView3.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                            }
                            else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                            {
                                this.DataGridView3.Rows[num].Cells[0].Value = true;
                                this.DataGridView3.Rows[num].DefaultCellStyle.BackColor = Color.LimeGreen;
                                this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.White;
                                num2 += 1;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Modify"], "1", false))
                            {
                                this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                                num2 += 1;
                            }
                            else
                            {
                                num2 += 1;
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
        }

        // Token: 0x06001562 RID: 5474 RVA: 0x0035EEDC File Offset: 0x0035D2DC
        public void nptotal()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT PartyMaster.PartyName, MatchTrans.m_id, MatchTrans.m_checked, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN  PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatchCommi, PartyMaster.SMatch HAVING (PartyMaster.PartyName = '", this.DataGridView1.CurrentRow.Cells[0].Value), "') AND (MatchTrans.m_id = "), this.TextBox1.Text), ") AND (MatchTrans.m_checked = 0)"));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.DataGridView4.Rows[0].Cells[0].Value = Module1.SetNumFormat(oleDbDataReader["Expr1"], this.txtnu.Text);
                    this.DataGridView4.Rows[0].Cells[1].Value = Module1.SetNumFormat(oleDbDataReader["Expr2"], this.txtnu.Text);
                    this.DataGridView4.Rows[0].Cells[2].Value = Module1.SetNumFormat(oleDbDataReader["Expr3"], this.txtnu.Text);
                    this.DataGridView4.Rows[0].Cells[3].Value = Module1.SetNumFormat(oleDbDataReader["Expr4"], this.txtnu.Text);

                    //double num = Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatchCommi"]));
                    //this.txtparsent.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])));
                    //this.DataGridView4.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]);
                    //this.DataGridView4.Rows[1].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)) * Conversion.Val(this.txtparsent.Text);
                    //this.DataGridView4.Rows[2].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value));
                    //this.DataGridView4.Rows[1].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value));
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[0].Value, 0, false))
                    //{
                    //	double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[0].Value)) * Conversion.Val(num);
                    //	this.DataGridView4.Rows[2].Cells[0].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[0].Value, num2);
                    //}
                    //this.DataGridView4.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[0].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[2].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[0].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[0].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"]);
                    //this.DataGridView4.Rows[1].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[1].Value)) * Conversion.Val(this.txtparsent.Text);
                    //this.DataGridView4.Rows[2].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value));
                    //this.DataGridView4.Rows[1].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value));
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[1].Value, 0, false))
                    //{
                    //	double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[1].Value)) * Conversion.Val(num);
                    //	this.DataGridView4.Rows[2].Cells[1].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[1].Value, num3);
                    //}
                    //this.DataGridView4.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[1].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[1].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[1].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[0].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"]);
                    //this.DataGridView4.Rows[1].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[2].Value)) * Conversion.Val(this.txtparsent.Text);
                    //this.DataGridView4.Rows[2].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value));
                    //this.DataGridView4.Rows[1].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value));
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[2].Value, 0, false))
                    //{
                    //	double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[2].Value)) * Conversion.Val(num);
                    //	this.DataGridView4.Rows[2].Cells[2].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[2].Value, num4);
                    //}
                    //this.DataGridView4.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[2].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[2].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[2].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[0].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"]);
                    //this.DataGridView4.Rows[1].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[3].Value)) * Conversion.Val(this.txtparsent.Text);
                    //this.DataGridView4.Rows[2].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value));
                    //this.DataGridView4.Rows[1].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value));
                    //if (!Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[2].Cells[3].Value, 0, false))
                    //{
                    //	double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[3].Value)) * Conversion.Val(num);
                    //	this.DataGridView4.Rows[2].Cells[3].Value = Operators.SubtractObject(this.DataGridView4.Rows[2].Cells[3].Value, num5);
                    //}
                    //this.DataGridView4.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[3].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[1].Cells[3].Value)), this.txtnu.Text);
                    //this.DataGridView4.Rows[2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[2].Cells[3].Value)), this.txtnu.Text);
                }
                try
                {
                    if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[0].Cells[0].Value, 0, false))
                    {
                        this.DataGridView4.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.DataGridView4.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                    }
                    if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[0].Cells[1].Value, 0, false))
                    {
                        this.DataGridView4.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.DataGridView4.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                    }
                    if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[0].Cells[2].Value, 0, false))
                    {
                        this.DataGridView4.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.DataGridView4.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                    }
                    if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[0].Cells[3].Value, 0, false))
                    {
                        this.DataGridView4.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.DataGridView4.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                    }
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[1].Cells[1].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[1].Cells[1].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[1].Cells[1].Style.ForeColor = Color.Green;
                    //}
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[1].Cells[2].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[1].Cells[2].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[1].Cells[2].Style.ForeColor = Color.Green;
                    //}
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[1].Cells[3].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[1].Cells[3].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[1].Cells[3].Style.ForeColor = Color.Green;
                    //}
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[2].Cells[0].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[2].Cells[0].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[2].Cells[0].Style.ForeColor = Color.Green;
                    //}
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[2].Cells[1].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[2].Cells[1].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[2].Cells[1].Style.ForeColor = Color.Green;
                    //}
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[2].Cells[2].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[2].Cells[2].Style.ForeColor = Color.Green;
                    //}
                    //if (Operators.ConditionalCompareObjectLessEqual(this.DataGridView4.Rows[2].Cells[3].Value, 0, false))
                    //{
                    //	this.DataGridView4.Rows[2].Cells[3].Style.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //	this.DataGridView4.Rows[2].Cells[3].Style.ForeColor = Color.Green;
                    //}
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
                MessageBox.Show(ex2.Message);
            }
            finally
            {
                DataGridView4.ClearSelection();
                Module1.conn.Close();
            }
        }

        // Token: 0x06001563 RID: 5475 RVA: 0x00360588 File Offset: 0x0035E988
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                if (this.TextBox1.Text != "" && this.txtmodify.Text != "")
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "select* from MatchTrans where m_id=",
                        this.TextBox1.Text,
                        " and m_eid=",
                        this.txtmodify.Text,
                        " and m_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("connot edit this Record", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = string.Concat(new string[]
                        {
                            "select* from MatchTrans where m_id=",
                            this.TextBox1.Text,
                            " and m_eid=",
                            this.txtmodify.Text,
                            " "
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        if (oleDbDataReader2.Read())
                        {
                            this.Panel6.Visible = true;
                            this.id.Text = Conversions.ToString(oleDbDataReader2[0]);
                            this.txtsrno.Text = Conversions.ToString(oleDbDataReader2[2]);
                            this.txtpage.Text = Conversions.ToString(oleDbDataReader2[3]);
                            this.txtamount.Text = Conversions.ToString(oleDbDataReader2[4]);
                            this.txtrate.Text = Conversions.ToString(oleDbDataReader2[5]);
                            this.cmbteam.Text = Conversions.ToString(oleDbDataReader2[6]);
                            this.ComboBox2.Text = Conversions.ToString(oleDbDataReader2[7]);
                            this.txtpartiname.Text = Conversions.ToString(oleDbDataReader2[8]);
                            this.cmbostus.Text = Conversions.ToString(oleDbDataReader2[9]);

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
                else
                {
                    Interaction.MsgBox("first select record then modify", MsgBoxStyle.OkOnly, null);
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

        //// Token: 0x06001564 RID: 5476 RVA: 0x003608C4 File Offset: 0x0035ECC4
        //private void DataGridView1_Click(object sender, EventArgs e)
        //{
        //	try
        //	{
        //		if (!Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[1].Value, null, false))
        //		{
        //			this.txtmodify.Text = this.DataGridView3.CurrentRow.Cells[1].Value.ToString();
        //		}
        //	}
        //	catch (Exception ex)
        //	{
        //		///Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        // Token: 0x06001565 RID: 5477 RVA: 0x00360950 File Offset: 0x0035ED50
        public void combolod()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.txtpartiname.Items.Clear();
                string cmdText = "SELECT Id, PartyName FROM PartyMaster WHERE (ID <> 1) ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txtpartiname.Items.Add(oleDbDataReader["PartyName"].ToString());
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

        // Token: 0x06001566 RID: 5478 RVA: 0x00360A10 File Offset: 0x0035EE10
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel6.Visible = false;
                this.txtmodify.Text = "";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001567 RID: 5479 RVA: 0x00360A20 File Offset: 0x0035EE20
        public void mod_K_L()
        {
            try
            {
                if (Operators.CompareString(this.DataGridView3.Columns[8].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView3.Columns[9].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, this.cmbteam.Text, false) == 0)
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
                if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, null, false) == 0)
                {
                    this.txtsut.Text = "0.00";
                }
                if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, null, false) == 0)
                {
                    this.txtind.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001568 RID: 5480 RVA: 0x003612E8 File Offset: 0x0035F6E8
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mod_K_L();
        }

        // Token: 0x06001569 RID: 5481 RVA: 0x003612F0 File Offset: 0x0035F6F0
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {

                //if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                if (this.TextBox1.Text != "" && this.txtmodify.Text != "")
                {
                    if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = string.Concat(new string[]
                        {
                        "select* from MatchTrans where m_id=",
                        this.TextBox1.Text,
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
                            string cmdText2 = $"Update MatchTrans Set m_checked=1, modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{ Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where m_id={this.TextBox1.Text} and m_eid={this.txtmodify.Text}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(cmdText2);
                            }
                            this.All_DPP_SHWO();
                            this.txtmodify.Text = "";
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("first select record then delete", MsgBoxStyle.OkOnly, null);
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

        // Token: 0x0600156A RID: 5482 RVA: 0x00361450 File Offset: 0x0035F850
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

        // Token: 0x0600156B RID: 5483 RVA: 0x003615AC File Offset: 0x0035F9AC
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

        // Token: 0x0600156D RID: 5485 RVA: 0x00361640 File Offset: 0x0035FA40
        public void Savedata_all()
        {
            try
            {
                string cmdText = $"UPDATE MatchTrans SET m_page = '{this.txtpage.Text}', m_amt = {this.txtamount.Text}, m_rate = {this.txtrate.Text}, m_team = '{this.cmbteam.Text}', m_mode = '{this.ComboBox2.Text}', m_party = '{this.txtpartiname.Text}', Status = 'N', modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', m_team1 = {this.txtpak.Text}, m_team2 = {this.txtend.Text}, m_team3 = {this.txtsut.Text}, m_team4 ={this.txtind.Text}, Modify = '1', m_checked = 0, M_P = '0', M_chk = 0 WHERE MatchTrans.m_id = {this.TextBox1.Text} AND MatchTrans.m_eid = {this.txtmodify.Text}";
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
        }

        // Token: 0x0600156E RID: 5486 RVA: 0x00361834 File Offset: 0x0035FC34
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

        // Token: 0x0600156F RID: 5487 RVA: 0x0036184C File Offset: 0x0035FC4C
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

        // Token: 0x06001570 RID: 5488 RVA: 0x003618DC File Offset: 0x0035FCDC
        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{Tab}");
                    if (Module1.isamountfirst == true)
                    {
                        this.txtrate.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001571 RID: 5489 RVA: 0x003618F4 File Offset: 0x0035FCF4
        private void txtpartiname_KeyDown(object sender, KeyEventArgs e)
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
            }
        }

        // Token: 0x06001572 RID: 5490 RVA: 0x0036190C File Offset: 0x0035FD0C
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select Remark,Result,Sr_No from Newmatch where Sr_No=" + this.TextBox1.Text + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Button1.Enabled = false;
                    this.Button6.Enabled = false;
                }
                else
                {
                    this.Button1.Enabled = true;
                    this.Button6.Enabled = true;
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

        // Token: 0x06001573 RID: 5491 RVA: 0x003619D4 File Offset: 0x0035FDD4
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                try
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[5].Value, true, false))
                    {
                        this.DataGridView1.CurrentRow.Cells[5].Value = false;
                        string cmdText = $"Update MatchTrans Set M_chk=0 where m_id={this.TextBox1.Text}  AND m_party = '{this.DataGridView1.CurrentRow.Cells[0].Value}'";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText);
                        }
                    }
                    else
                    {
                        this.DataGridView1.CurrentRow.Cells[5].Value = true;
                        string cmdText2 = $"Update MatchTrans Set M_chk=1 where m_id={this.TextBox1.Text}  AND m_party = '{this.DataGridView1.CurrentRow.Cells[0].Value}'";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText2);
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

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.mod_K_L();
                this.Savedata_all();
                this.Panel6.Hide();
                this.All_DPP_SHWO();
                this.txtmodify.Text = "";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void DataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.txtmodify.Text = Conversions.ToString(this.DataGridView3.CurrentRow.Cells[1].Value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }


        // Token: 0x04000903 RID: 2307
        private TextBox txtnu;

        // Token: 0x04000904 RID: 2308
        public string oc;

        // Token: 0x04000905 RID: 2309
        private TextBox txtparsent;

        // Token: 0x04000906 RID: 2310
        private TextBox id;

        // Token: 0x04000907 RID: 2311
        private TextBox txtsrno;

        // Token: 0x04000908 RID: 2312
        private TextBox cmbostus;

        // Token: 0x0400090A RID: 2314
        private TextBox txttime;

        // Token: 0x0400090B RID: 2315
        private TextBox txtpak;

        // Token: 0x0400090C RID: 2316
        private TextBox txtend;

        // Token: 0x0400090D RID: 2317
        private TextBox txtsut;

        // Token: 0x0400090E RID: 2318
        private TextBox txtind;

        // Token: 0x0400090F RID: 2319
        private TextBox txtmpar;

        // Token: 0x04000910 RID: 2320
        private TextBox txtmodify;

        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{Tab}");
                    if (Module1.isratefirst == true)
                    {
                        this.txtamount.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void cmbteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.ComboBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtpartiname.Focus();
                    this.txtpartiname.SelectAll();
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
            }
        }
    }
}
