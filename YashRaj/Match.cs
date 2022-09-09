using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;
using App.Service;
using System.Linq;

namespace YashAksh
{

    [DesignerGenerated]
    public partial class Match : Form
    {
        string formstate = "";
        public bool ismodify = false;
        private double Yes1;
        private double No1;
        public Match()
        {
            this.InitializeComponent();
        }

        private void Match_Activated(object sender, EventArgs e)
        {
            try
            {

                if (Module1.isratefirst == true)
                {
                    txtrate.Focus();
                    txtrate.SelectAll();
                }
                else
                {
                    txtamount.Focus();
                    txtamount.SelectAll();
                }
                this.Refresh1_All();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
        public void Match_Load(object sender, EventArgs e)
        {
            try
            {

                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(100, 28);
                    txtrate.Location = new Point(8, 28);

                    Label12.Text = "Amount";
                    Label11.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.CheckBox5.Hide();
                this.testnu.Text = Conversions.ToString(Module1.machid);
                this.testnu.Hide();

                this.Button5.Hide();
                this.Button1.Hide();
                this.btnOk.Show();

                this.TextBox6.Hide();

                Size size = new Size(630, 659);
                this.Size = size;
                int x = 0;
                int y = 0;
                //Solve Error
                //int x = (-(((Screen.PrimaryScreen.WorkingArea.Width == 0) > false) ? 1 : 0)) ? 1 : 0;
                //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;

                this.CheckBox2.Hide();
                this.hidetextbox();
                this.txtnu.Text = Module1.decimalnumberformat;
                this.MaximizeBox = false;
                this.WindowState = FormWindowState.Normal;

                if (Operators.CompareString(this.testnu.Text, "", false) == 0)
                {
                    MessageBox.Show("Record No");
                }
                else
                {
                    this.all_lode();
                }
                this.lod_newPartyname();
                this.Decleard();
                //this.Refresh1_All();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public async Task GridRowGenerate()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                if (Module1.isntposition == true)
                {
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            "NT"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            ""
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            "RG"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            "BK"
                    });
                    this.DataGridView2.Rows[1].Height = 5;
                    this.DataGridView2.Rows[1].DefaultCellStyle.BackColor = Color.Gray;

                }
                else
                {
                    this.DataGridView2.Rows.Add(new object[]
                     {
                            "RG"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            "BK"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            ""
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                            "NT"
                    });
                    this.DataGridView2.Rows[2].Height = 5;
                    this.DataGridView2.Rows[2].DefaultCellStyle.BackColor = Color.Gray;
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        public void Decleard()
        {
            try
            {
                if (this.testnu.Text != "")
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select * from Newmatch where Sr_No=" + this.testnu.Text + " and Result='Declared'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        this.btnmodify.Enabled = false;
                        this.btndelete.Enabled = false;
                        this.txtpartiname.Enabled = false;
                    }
                    else
                    {
                        this.btnmodify.Enabled = true;
                        this.btndelete.Enabled = true;
                        this.txtpartiname.Enabled = true;
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

        public async Task Net_Postion()
        {
            try
            {
                if (Module1.isntposition == true)
                {
                    this.DataGridView2.Rows[0].Cells[1].Value = Conversion.Val(this.DataGridView2.Rows[2].Cells[1].Value) + Conversion.Val(this.DataGridView2.Rows[3].Cells[1].Value);
                    this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[0].Cells[1].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[2].Value = Conversion.Val(this.DataGridView2.Rows[2].Cells[2].Value) + Conversion.Val(this.DataGridView2.Rows[3].Cells[2].Value);
                    this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[0].Cells[2].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[3].Value = Conversion.Val(this.DataGridView2.Rows[2].Cells[3].Value) + Conversion.Val(this.DataGridView2.Rows[3].Cells[3].Value);
                    this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[0].Cells[3].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[4].Value = Conversion.Val(this.DataGridView2.Rows[2].Cells[4].Value) + Conversion.Val(this.DataGridView2.Rows[3].Cells[4].Value);
                    this.DataGridView2.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[0].Cells[4].Value), this.txtnu.Text);

                    Module1.exp1_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[0].Cells[1].Value);
                    Module1.exp2_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[0].Cells[2].Value);
                    Module1.exp3_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[0].Cells[3].Value);
                    Module1.exp4_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[0].Cells[4].Value);

                    double num;
                    if (Conversion.Val(this.DataGridView2.Rows[0].Cells[2].Value) != 0)
                    {
                        num = Conversion.Val(this.DataGridView2.Rows[0].Cells[1].Value) / Conversion.Val(this.DataGridView2.Rows[0].Cells[2].Value);
                        this.lbl1.Text = Strings.Format(Math.Abs(num), "0.0000");
                    }
                    else
                    {
                        this.lbl1.Text = "";
                    }

                    if (Conversion.Val(this.DataGridView2.Rows[0].Cells[1].Value) != 0)
                    {
                        num = Conversion.Val(this.DataGridView2.Rows[0].Cells[2].Value) / Conversion.Val(this.DataGridView2.Rows[0].Cells[1].Value);
                        this.lbl2.Text = Strings.Format(Math.Abs(num), "0.0000");
                    }
                    else
                    {
                        this.lbl2.Text = "";
                    }
                }
                else
                {
                    this.DataGridView2.Rows[3].Cells[1].Value = Conversion.Val(this.DataGridView2.Rows[0].Cells[1].Value) + Conversion.Val(this.DataGridView2.Rows[1].Cells[1].Value);
                    this.DataGridView2.Rows[3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[3].Cells[1].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[3].Cells[2].Value = Conversion.Val(this.DataGridView2.Rows[0].Cells[2].Value) + Conversion.Val(this.DataGridView2.Rows[1].Cells[2].Value);
                    this.DataGridView2.Rows[3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[3].Cells[2].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[3].Cells[3].Value = Conversion.Val(this.DataGridView2.Rows[0].Cells[3].Value) + Conversion.Val(this.DataGridView2.Rows[1].Cells[3].Value);
                    this.DataGridView2.Rows[3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[3].Cells[3].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[3].Cells[4].Value = Conversion.Val(this.DataGridView2.Rows[0].Cells[4].Value) + Conversion.Val(this.DataGridView2.Rows[1].Cells[4].Value);
                    this.DataGridView2.Rows[3].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(this.DataGridView2.Rows[3].Cells[4].Value), this.txtnu.Text);

                    Module1.exp1_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[3].Cells[1].Value);
                    Module1.exp2_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[3].Cells[2].Value);
                    Module1.exp3_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[3].Cells[3].Value);
                    Module1.exp4_matchbook_total = Conversions.ToString(this.DataGridView2.Rows[3].Cells[4].Value);

                    double num;
                    if (Conversion.Val(this.DataGridView2.Rows[3].Cells[2].Value) != 0)
                    {
                        num = Conversion.Val(this.DataGridView2.Rows[3].Cells[1].Value) / Conversion.Val(this.DataGridView2.Rows[3].Cells[2].Value);
                        this.lbl1.Text = Strings.Format(Math.Abs(num), "0.0000");
                    }
                    else
                    {
                        this.lbl1.Text = "";
                    }

                    if (Conversion.Val(this.DataGridView2.Rows[3].Cells[1].Value) != 0)
                    {
                        num = Conversion.Val(this.DataGridView2.Rows[3].Cells[2].Value) / Conversion.Val(this.DataGridView2.Rows[3].Cells[1].Value);
                        this.lbl2.Text = Strings.Format(Math.Abs(num), "0.0000");
                    }
                    else
                    {
                        this.lbl2.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        public void Regular_All_Tems()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                //string cmdText = "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.PartyName HAVING (MatchTrans.m_checked <> 1) AND (MatchTrans.m_id = " + this.testnu.Text + ") AND (PartyMaster.Status= 'Regular') AND (PartyMaster.MatchCommiType='Match Total Minus') ORDER BY PartyMaster.PartyName";
                string cmdText = string.Concat(new string[]
                {
                    "SELECT * FROM (",
                    "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.PartyName, PartyMaster.MatchCommiType HAVING (MatchTrans.m_checked <> 1) AND (MatchTrans.m_id = " + this.testnu.Text + ") AND (PartyMaster.Status= 'Regular') AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus'))",
                    " UNION ALL ",
                    "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked <> 1) AND (MatchTrans.m_id = " + this.testnu.Text + ") AND (PartyMaster.Status= 'Regular') AND (PartyMaster.MatchCommiType='Entry Wise')",
                    ") ORDER BY PartyName"
                });

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double smatch = Convert.ToDouble(oleDbDataReader["SMatch"]);
                    double amatch = Convert.ToDouble(oleDbDataReader["AMatch"]);
                    double tmatch = Convert.ToDouble(oleDbDataReader["TMatch"]);
                    double num4 = Conversion.Val(amatch) + Conversion.Val(tmatch);
                    double smatchcommi = Convert.ToDouble(oleDbDataReader["SMatchCommi"]);
                    double amatchcommi = Convert.ToDouble(oleDbDataReader["AMatchCommi"]);
                    double tmatchcommi = Convert.ToDouble(oleDbDataReader["TMatchCommi"]);
                    double totalcommi = Conversion.Val(smatchcommi) + Conversion.Val(amatchcommi) + Conversion.Val(tmatchcommi);

                    this.Rtotal1 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    this.Rtotal2 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    this.Rtotal3 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    this.Rtotal4 = Convert.ToDouble(oleDbDataReader["Expr4"]);

                    int index = this.DataGridView5.Rows.Add();
                    double num6 = Conversion.Val(this.Rtotal1) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal1);
                    double num7 = Conversion.Val(this.Rtotal2) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal2);
                    double num8 = Conversion.Val(this.Rtotal3) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal3);
                    double num9 = Conversion.Val(this.Rtotal4) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal4);

                    if (num6 < 0.0)
                    {
                        double num10 = Conversion.Val(num6) * Conversion.Val(totalcommi) / 100;
                        double num11 = Conversion.Val(num6) + Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10);
                        double num12 = Conversion.Val(num11) * Conversion.Val(smatch) / 100 - Conversion.Val(num11);
                        double num13 = Conversion.Val(num12) * Conversion.Val(num4) / 100 - num12;
                        this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                    }
                    else
                    {
                        double num14 = Conversion.Val(num6) * Conversion.Val(smatch) / 100 - Conversion.Val(num6);
                        double num15 = Conversion.Val(num14) * Conversion.Val(num4) / 100 - num14;
                        this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                    }

                    if (num7 < 0.0)
                    {
                        double num16 = Conversion.Val(num7) * Conversion.Val(totalcommi) / 100;
                        double num17 = Conversion.Val(num7) + Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
                        double num18 = Conversion.Val(num17) * Conversion.Val(smatch) / 100 - Conversion.Val(num17);
                        double num19 = Conversion.Val(num18) * Conversion.Val(num4) / 100 - num18;
                        this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19);
                    }
                    else
                    {
                        double num20 = Conversion.Val(num7) * Conversion.Val(smatch) / 100 - Conversion.Val(num7);
                        double num21 = Conversion.Val(num20) * Conversion.Val(num4) / 100 - num20;
                        this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num21) - Conversion.Val(num21) - Conversion.Val(num21);
                    }

                    if (num8 < 0.0)
                    {
                        double num22 = Conversion.Val(num8) * Conversion.Val(totalcommi) / 100;
                        double num23 = Conversion.Val(num8) + Conversion.Val(num22) - Conversion.Val(num22) - Conversion.Val(num22);
                        double num24 = Conversion.Val(num23) * Conversion.Val(smatch) / 100 - Conversion.Val(num23);
                        double num25 = Conversion.Val(num24) * Conversion.Val(num4) / 100 - num24;
                        this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25);
                    }
                    else
                    {
                        double num26 = Conversion.Val(num8) * Conversion.Val(smatch) / 100 - Conversion.Val(num8);
                        double num27 = Conversion.Val(num26) * Conversion.Val(num4) / 100 - num26;
                        this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num27) - Conversion.Val(num27) - Conversion.Val(num27);
                    }

                    if (num9 < 0.0)
                    {
                        double num28 = Conversion.Val(num9) * Conversion.Val(totalcommi) / 100;
                        double num29 = Conversion.Val(num9) + Conversion.Val(num28) - Conversion.Val(num28) - Conversion.Val(num28);
                        double num30 = Conversion.Val(num29) * Conversion.Val(smatch) / 100 - Conversion.Val(num29);
                        double num31 = Conversion.Val(num30) * Conversion.Val(num4) / 100 - num30;
                        this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num31) - Conversion.Val(num31) - Conversion.Val(num31);
                    }
                    else
                    {
                        double num32 = Conversion.Val(num9) * Conversion.Val(smatch) / 100 - Conversion.Val(num9);
                        double num33 = Conversion.Val(num32) * Conversion.Val(num4) / 100 - num32;
                        this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num33) - Conversion.Val(num33) - Conversion.Val(num33);
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
                this.Per_Peti_All_Tems("Regular");
                Module1.conn.Close();
            }
        }

        public void Regular_Total()
        {
            checked
            {
                try
                {
                    double num = 0.0;
                    for (int i = 0; i <= this.DataGridView5.RowCount - 1; i++)
                    {
                        unchecked
                        {
                            num += Convert.ToDouble(this.DataGridView5.Rows[i].Cells[0].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                    }

                    double num4 = 0.0;
                    for (int j = 0; j <= this.DataGridView5.RowCount - 1; j++)
                    {
                        unchecked
                        {
                            num4 += Convert.ToDouble(this.DataGridView5.Rows[j].Cells[1].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    }

                    double num7 = 0.0;
                    for (int k = 0; k <= this.DataGridView5.RowCount - 1; k++)
                    {
                        unchecked
                        {
                            num7 += Convert.ToDouble(this.DataGridView5.Rows[k].Cells[2].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                    }

                    double num10 = 0.0;
                    for (int l = 0; l <= this.DataGridView5.RowCount - 1; l++)
                    {
                        unchecked
                        {
                            num10 += Convert.ToDouble(this.DataGridView5.Rows[l].Cells[3].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        public void Booky_All_Tems()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                OleDbConnection oleDbConnection = new OleDbConnection();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                //string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, SUM(PartyMaster.SMatchCommi) AS SMatchCommi, SUM(PartyMaster.SMatch) AS SMatch, SUM(PartyMaster.AMatch) AS AMatch, SUM(PartyMaster.TMatch) AS TMatch, MatchTrans.m_id,  MatchTrans.m_eid, MatchTrans.m_page, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_eid, MatchTrans.m_page, MatchTrans.m_checked HAVING (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = " + this.testnu.Text + ") AND (PartyMaster.Status= 'Booky')";
                string cmdText = string.Concat(new string[]
                {
                    "SELECT * FROM (",
                    "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.PartyName, PartyMaster.MatchCommiType HAVING (MatchTrans.m_checked <> 1) AND (MatchTrans.m_id = " + this.testnu.Text + ") AND (PartyMaster.Status= 'Booky') AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus'))",
                    " UNION ALL ",
                    "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.TMatchCommi, PartyMaster.Status, MatchTrans.m_id, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked <> 1) AND (MatchTrans.m_id = " + this.testnu.Text + ") AND (PartyMaster.Status= 'Booky') AND (PartyMaster.MatchCommiType='Entry Wise')",
                    ") ORDER BY PartyName"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double smatch = Convert.ToDouble(oleDbDataReader["SMatch"]);
                    double amatch = Convert.ToDouble(oleDbDataReader["AMatch"]);
                    double tmatch = Convert.ToDouble(oleDbDataReader["TMatch"]);
                    double num4 = Conversion.Val(amatch) + Conversion.Val(tmatch);
                    double smatchcommi = Convert.ToDouble(oleDbDataReader["SMatchCommi"]);
                    double amatchcommi = Convert.ToDouble(oleDbDataReader["AMatchCommi"]);
                    double tmatchcommi = Convert.ToDouble(oleDbDataReader["TMatchCommi"]);
                    double totalcommi = Conversion.Val(smatchcommi) + Conversion.Val(amatchcommi) + Conversion.Val(tmatchcommi);

                    this.Rtotal1 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    this.Rtotal2 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    this.Rtotal3 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    this.Rtotal4 = Convert.ToDouble(oleDbDataReader["Expr4"]);

                    int index = this.DataGridView5.Rows.Add();
                    double num6 = Conversion.Val(this.Rtotal1) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal1);
                    double num7 = Conversion.Val(this.Rtotal2) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal2);
                    double num8 = Conversion.Val(this.Rtotal3) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal3);
                    double num9 = Conversion.Val(this.Rtotal4) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal4);

                    if (num6 > 0.0)
                    {
                        double num10 = Conversion.Val(num6) * Conversion.Val(totalcommi) / 100;
                        double num11 = Conversion.Val(num6) + Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10);
                        double num12 = Conversion.Val(num11) * Conversion.Val(smatch) / 100 - Conversion.Val(num11);
                        double num13 = Conversion.Val(num12) * Conversion.Val(num4) / 100 - num12;
                        this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                    }
                    else
                    {
                        double num14 = Conversion.Val(num6) * Conversion.Val(smatch) / 100 - Conversion.Val(num6);
                        double num15 = Conversion.Val(num14) * Conversion.Val(num4) / 100 - num14;
                        this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                    }
                    if (num7 > 0.0)
                    {
                        double num16 = Conversion.Val(num7) * Conversion.Val(totalcommi) / 100;
                        double num17 = Conversion.Val(num7) + Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
                        double num18 = Conversion.Val(num17) * Conversion.Val(smatch) / 100 - Conversion.Val(num17);
                        double num19 = Conversion.Val(num18) * Conversion.Val(num4) / 100 - num18;
                        this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19);
                    }
                    else
                    {
                        double num20 = Conversion.Val(num7) * Conversion.Val(smatch) / 100 - Conversion.Val(num7);
                        double num21 = Conversion.Val(num20) * Conversion.Val(num4) / 100 - num20;
                        this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num21) - Conversion.Val(num21) - Conversion.Val(num21);
                    }
                    if (num8 > 0.0)
                    {
                        double num22 = Conversion.Val(num8) * Conversion.Val(totalcommi) / 100;
                        double num23 = Conversion.Val(num8) + Conversion.Val(num22) - Conversion.Val(num22) - Conversion.Val(num22);
                        double num24 = Conversion.Val(num23) * Conversion.Val(smatch) / 100 - Conversion.Val(num23);
                        double num25 = Conversion.Val(num24) * Conversion.Val(num4) / 100 - num24;
                        this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25);
                    }
                    else
                    {
                        double num26 = Conversion.Val(num8) * Conversion.Val(smatch) / 100 - Conversion.Val(num8);
                        double num27 = Conversion.Val(num26) * Conversion.Val(num4) / 100 - num26;
                        this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num27) - Conversion.Val(num27) - Conversion.Val(num27);
                    }
                    if (num9 > 0.0)
                    {
                        double num28 = Conversion.Val(num9) * Conversion.Val(totalcommi) / 100;
                        double num29 = Conversion.Val(num9) + Conversion.Val(num28) - Conversion.Val(num28) - Conversion.Val(num28);
                        double num30 = Conversion.Val(num29) * Conversion.Val(smatch) / 100 - Conversion.Val(num29);
                        double num31 = Conversion.Val(num30) * Conversion.Val(num4) / 100 - num30;
                        this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num31) - Conversion.Val(num31) - Conversion.Val(num31);
                    }
                    else
                    {
                        double num32 = Conversion.Val(num9) * Conversion.Val(smatch) / 100 - Conversion.Val(num9);
                        double num33 = Conversion.Val(num32) * Conversion.Val(num4) / 100 - num32;
                        this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num33) - Conversion.Val(num33) - Conversion.Val(num33);
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
                this.Per_Peti_All_Tems("Booky");
                Module1.conn.Close();
            }
        }

        public void Booky_Total()
        {
            checked
            {
                try
                {
                    double num3 = 0;
                    for (int i = 0; i <= this.DataGridView5.RowCount - 1; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(this.DataGridView5.Rows[i].Cells[0].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    }

                    double num6 = 0;
                    for (int j = 0; j <= this.DataGridView5.RowCount - 1; j++)
                    {
                        unchecked
                        {
                            num6 += Convert.ToDouble(this.DataGridView5.Rows[j].Cells[1].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                    }

                    double num9 = 0;
                    for (int k = 0; k <= this.DataGridView5.RowCount - 1; k++)
                    {
                        unchecked
                        {
                            num9 += Convert.ToDouble(this.DataGridView5.Rows[k].Cells[2].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                    }

                    double num12 = 0;
                    for (int l = 0; l <= this.DataGridView5.RowCount - 1; l++)
                    {
                        unchecked
                        {
                            num12 += Convert.ToDouble(this.DataGridView5.Rows[l].Cells[3].Value);
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        public void Per_Peti_All_Tems(string sta)
        {
            try
            {
                string cmdText = string.Concat(new string[]
                {
                "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatch, PartyMaster.SMatchCommi, PartyMaster.AMatch, PartyMaster.AMatchCommi, PartyMaster.TMatch, PartyMaster.TMatchCommi, MatchTrans.m_rate, MatchTrans.m_amt, PartyMaster.Rate FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) ",
                "WHERE (MatchTrans.m_id = ",
                this.testnu.Text,
                ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.Status = '",
                sta,
                "') AND (PartyMaster.MatchCommiType = 'Per Peti') "
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    string status = Conversions.ToString(oleDbDataReader["Status"]);
                    double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["SMatch"]));
                    double amatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["AMatch"]));
                    double tmatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(oleDbDataReader["TMatch"]));

                    double totalld = amatch + tmatch;

                    double smatchcommi = Conversion.Val(oleDbDataReader["SMatchCommi"]);
                    double amatchcommi = Conversion.Val(oleDbDataReader["AMatchCommi"]);
                    double tmatchcommi = Conversion.Val(oleDbDataReader["TMatchCommi"]);
                    double totalcommi = smatchcommi + amatchcommi + tmatchcommi;
                    double m_rate = Conversion.Val(oleDbDataReader["m_rate"]);
                    double p_rate = Conversion.Val(oleDbDataReader["Rate"]);
                    double m_amt = Conversion.Val(oleDbDataReader["m_amt"]);

                    double totalamt_afterselfld = m_amt - (m_amt * smatch);
                    double totalamt_aftertotalld = (totalamt_afterselfld) - (totalamt_afterselfld * totalld);

                    double exp1 = Conversion.Val(oleDbDataReader["Expr1"]);
                    double exp2 = Conversion.Val(oleDbDataReader["Expr2"]);
                    double exp3 = Conversion.Val(oleDbDataReader["Expr3"]);
                    double exp4 = Conversion.Val(oleDbDataReader["Expr4"]);

                    double exp1_selfld = 0, exp1_afterldcommi = 0;
                    double exp2_selfld = 0, exp2_afterldcommi = 0;
                    double exp3_selfld = 0, exp3_afterldcommi = 0;
                    double exp4_selfld = 0, exp4_afterldcommi = 0;

                    int index = this.DataGridView5.Rows.Add();

                    exp1_selfld = exp1 - (exp1 * smatch);
                    exp1_afterldcommi = exp1_selfld - (exp1_selfld * totalld);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp1 != 0)
                    {
                        double num = (Conversion.Val(totalamt_aftertotalld) / Conversion.Val(100000)) * Conversion.Val(totalcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num));

                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp1_afterldcommi = Conversion.Val(Operators.AddObject(exp1_afterldcommi, num));
                        }
                    }
                    this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(exp1_afterldcommi);

                    exp2_selfld = exp2 - (exp2 * smatch);
                    exp2_afterldcommi = exp2_selfld - (exp2_selfld * totalld);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp2 != 0)
                    {
                        double num = (Conversion.Val(totalamt_aftertotalld) / Conversion.Val(100000)) * Conversion.Val(totalcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp2_afterldcommi = Conversion.Val(Operators.AddObject(exp2_afterldcommi, num));
                        }
                    }
                    this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(exp2_afterldcommi);

                    exp3_selfld = exp3 - (exp3 * smatch);
                    exp3_afterldcommi = exp3 - (exp3 * totalld);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp3 != 0)
                    {
                        double num = (Conversion.Val(totalamt_aftertotalld) / Conversion.Val(100000)) * Conversion.Val(totalcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp3_afterldcommi = Conversion.Val(Operators.AddObject(exp3_afterldcommi, num));
                        }
                    }
                    this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(exp3_afterldcommi);

                    exp4_selfld = exp4 - (exp4 * smatch);
                    exp4_afterldcommi = exp4 - (exp4 * totalld);
                    if (Operators.ConditionalCompareObjectGreaterEqual(m_rate, p_rate, false) && exp4 != 0)
                    {
                        double num = (Conversion.Val(totalamt_aftertotalld) / Conversion.Val(100000)) * Conversion.Val(totalcommi);
                        if (Operators.CompareString(status, "Regular", false) == 0)
                        {
                            exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num));
                        }
                        if (Operators.CompareString(status, "Booky", false) == 0)
                        {
                            exp4_afterldcommi = Conversion.Val(Operators.AddObject(exp4_afterldcommi, num));
                        }
                    }
                    this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(exp4_afterldcommi);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public async Task listboxlode()
        {
            checked
            {
                try
                {
                    this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    //if (Module1.conn.State == ConnectionState.Closed)
                    //{
                    //    Module1.conn.Open();
                    //}

                    string selectCommandText = "";
                    if (Module1.isamountfirst == true)
                    {
                        selectCommandText = "SELECT m_eid AS Sr_No, m_amt AS Amount, m_rate AS Rate, m_team AS Favour, m_mode AS Mode, m_party AS [Party Name], m_team1  , m_team2 , m_team3 , m_team4 , m_time AS [Time], m_page AS Page_No, m_dt AS [Date], m_checked, Modify, M_chk, modify_time, modify_date FROM MatchTrans WHERE(m_id = " + this.testnu.Text + ") ORDER BY m_eid DESC";
                    }
                    if (Module1.isratefirst == true)
                    {
                        selectCommandText = "SELECT m_eid AS Sr_No, m_rate AS Rate, m_amt AS Amount, m_team AS Favour, m_mode AS Mode, m_party AS [Party Name], m_team1  , m_team2 , m_team3 , m_team4 , m_time AS [Time], m_page AS Page_No, m_dt AS [Date], m_checked, Modify, M_chk, modify_time, modify_date FROM MatchTrans WHERE(m_id = " + this.testnu.Text + ") ORDER BY m_eid DESC";
                    }
                    DataTable dtbMatch = new DataTable();
                    using (CupService cupService = new CupService())
                    {
                        Module1.conn.Close();
                        dtbMatch = cupService.Get(selectCommandText);
                    }
                    //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                    //DataSet dataSet = new DataSet();
                    //oleDbDataAdapter.Fill(dataSet, "Table");
                    this.DataGridView1.AutoGenerateColumns = true;
                    this.DataGridView1.DataSource = dtbMatch;
                    //this.DataGridView1.DataMember = "Table";

                    this.DataGridView1.Columns[6].HeaderText = this.Te1;
                    this.DataGridView1.Columns[7].HeaderText = this.Te2;
                    this.DataGridView1.Columns[8].HeaderText = this.Te3;
                    this.DataGridView1.Columns[9].HeaderText = this.Te4;
                   
                    //if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, null, false) == 0)
                    //{
                    if (this.DataGridView1.Columns[8].HeaderText.ToString() == "DRW")
                        this.DataGridView1.Columns[8].Visible = true;
                    else
                        this.DataGridView1.Columns[8].Visible = false;
                    //}
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, null, false) == 0)
                    {
                        this.DataGridView1.Columns[9].Visible = false;
                    }

                    this.DataGridView1.Columns[6].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView1.Columns[7].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView1.Columns[8].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView1.Columns[9].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView1.Columns["Amount"].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView1.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["Rate"].DefaultCellStyle.Format = "0.0000";
                    this.DataGridView1.Columns["Favour"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["Mode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["Party Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["m_team1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["m_team2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["m_team3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["m_team4"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView1.Columns["Page_No"].Visible = false;

                    this.DataGridView1.Columns["Sr_No"].Width = 30;
                    this.DataGridView1.Columns["Amount"].Width = 90;
                    this.DataGridView1.Columns["Rate"].Width = 65;
                    this.DataGridView1.Columns["Favour"].Width = 60;
                    this.DataGridView1.Columns["Mode"].Width = 30;
                    this.DataGridView1.Columns[10].Width = 90;
                    this.DataGridView1.Columns[11].Width = 20;
                    this.DataGridView1.Columns[12].Width = 90;
                    this.DataGridView1.Columns[6].Width = 90;
                    this.DataGridView1.Columns[7].Width = 90;
                    this.DataGridView1.Columns[8].Width = 90;
                    this.DataGridView1.Columns[9].Width = 90;
                    this.DataGridView1.Columns["Time"].Width = 100;

                    this.DataGridView1.Columns["modify_time"].HeaderText = "Modify Time";
                    this.DataGridView1.Columns["modify_date"].HeaderText = "Modify Date";
                    this.DataGridView1.Columns["modify_time"].Width = 100;
                    this.DataGridView1.Columns["modify_date"].Width = 90;

                    this.DataGridView1.Columns["Party Name"].Width = 140;
                    this.DataGridView1.Columns["Page_No"].Visible = false;
                    this.DataGridView1.Columns[13].Visible = false;
                    this.DataGridView1.Columns[14].Visible = false;
                    this.DataGridView1.Columns[15].Visible = false;

                    for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
                    {
                        if (Convert.ToDouble(this.DataGridView1.Rows[i].Cells[13].Value.ToString()) == 1.0)
                        {
                            this.DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            //this.DataGridView1.Rows[i].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                        }
                        else if (Convert.ToDouble(this.DataGridView1.Rows[i].Cells[14].Value.ToString()) == 1.0)
                        {
                            this.DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Convert.ToDouble(this.DataGridView1.Rows[i].Cells[15].Value.ToString()) == 1.0)
                        {
                            this.DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Lime;
                        }
                    }
                    this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void all_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Newmatch where Sr_No=" + this.testnu.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.cmbteam.Items.Clear();
                    this.Label1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", oleDbDataReader[4]), " )"), "  "), oleDbDataReader[2]), " "), "  VS  "), "  "), oleDbDataReader[3]), " "), oleDbDataReader[1]));
                    this.DataGridView2.Columns[1].HeaderText = oleDbDataReader[5].ToString();
                    this.DataGridView2.Columns[2].HeaderText = oleDbDataReader[6].ToString();
                    this.DataGridView2.Columns[3].HeaderText = oleDbDataReader[7].ToString();
                    this.DataGridView2.Columns[4].HeaderText = oleDbDataReader[8].ToString();

                    if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, "", false) == 0)
                    {
                        this.DataGridView2.Columns[3].Visible = false;
                    }
                    if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, "", false) == 0)
                    {
                        this.DataGridView2.Columns[4].Visible = false;
                    }

                    this.DataGridView3.Columns[0].HeaderText = oleDbDataReader[5].ToString();
                    this.DataGridView3.Columns[1].HeaderText = oleDbDataReader[6].ToString();
                    this.DataGridView3.Columns[2].HeaderText = oleDbDataReader[7].ToString();
                    this.DataGridView3.Columns[3].HeaderText = oleDbDataReader[8].ToString();
                    this.DataGridView3.Columns[4].HeaderText = oleDbDataReader[9].ToString();

                    this.cmbteam.Items.Add(oleDbDataReader[5].ToString());
                    this.cmbteam.Items.Add(oleDbDataReader[6].ToString());
                    this.Team1 = oleDbDataReader[5].ToString();
                    this.Team2 = oleDbDataReader[6].ToString();
                    this.Te1 = oleDbDataReader[5].ToString();
                    this.Te2 = oleDbDataReader[6].ToString();
                    if (Operators.CompareString(oleDbDataReader[7].ToString(), null, false) == 0)
                    {
                        this.Te3 = "";
                    }
                    else
                    {
                        this.cmbteam.Items.Add(oleDbDataReader[7].ToString());
                        this.Team3 = oleDbDataReader[7].ToString();
                        this.Te3 = oleDbDataReader[7].ToString();
                    }
                    if (Operators.CompareString(oleDbDataReader[8].ToString(), null, false) == 0)
                    {
                        this.Te4 = "";
                    }
                    else
                    {
                        this.cmbteam.Items.Add(oleDbDataReader[8].ToString());
                        this.Team4 = oleDbDataReader[8].ToString();
                        this.Te4 = oleDbDataReader[8].ToString();
                    }
                }
                if (Operators.CompareString(this.DataGridView3.Columns[2].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[2].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView3.Columns[3].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[3].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView3.Columns[4].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[4].Visible = false;
                }
                //this.cmbteam.Items.Add("L/F");
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
                MyProject.Forms.Match_Report.Show();

                MyProject.Forms.Declear_New_Sesstions.Close();
                MyProject.Forms.New_Session.Close();
                MyProject.Forms.Form3_SESSION.Close();
                MyProject.Forms.MatchBOOKPOPUP.Close();
                MyProject.Forms.Session_Report.Close();

                Module1.machid = 0;
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btndpp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(Module1.name1, "", false))
                {
                    DPP_Match dPP_Match = new DPP_Match();
                    dPP_Match.MdiParent = this.MdiParent;
                    dPP_Match.WindowState = FormWindowState.Maximized;
                    dPP_Match.Show();
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
                Agent_match agent_Match = new Agent_match();
                agent_Match.MdiParent = this.MdiParent;
                agent_Match.WindowState = FormWindowState.Maximized;
                agent_Match.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Name information?", MsgBoxStyle.OkOnly, null);
                        this.txtpartiname.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                    {
                        Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Team information?", MsgBoxStyle.OkOnly, null);
                        this.cmbteam.Focus();
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Mode information?", MsgBoxStyle.OkOnly, null);
                        this.ComboBox2.Focus();
                    }
                    else
                    {

                        this.sr_NoAuto();
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = "SELECT Id, PartyName, Status FROM PartyMaster WHERE (PartyName = '" + this.txtpartiname.Text + "')";
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            this.ComboBox2_Leave(RuntimeHelpers.GetObjectValue(sender), e);
                            Module1.conn.Close();
                            cmdText = $"INSERT INTO MatchTrans (m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, Status, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, Modify, m_checked, M_P, M_chk)VALUES({this.testnu.Text},{this.txtsrno.Text},'{this.txtpage.Text}',{this.txtamount.Text},'{this.txtrate.Text}','{this.cmbteam.Text}','{this.ComboBox2.Text}','{this.txtpartiname.Text}','N','{this.txtdate.Text}','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}',{this.txtpak.Text},{this.txtend.Text},{this.txtsut.Text},{this.txtind.Text},'0','0','0',0)";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(cmdText);
                            }
                            if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                            {
                                this.txtsut.Text = "0";
                            }
                            if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                            {
                                this.txtind.Text = "0";
                            }

                            //this.GridRowGenerate();

                            //this.listboxlode();
                            //this.TOTAL_ALL();
                            //this.Net_Postion();
                            //this.Colore();
                            //this.sr_NoAuto();
                            //this.Partposion1();
                            //this.Agent2();
                            //this.Agent1();


                            this.Refresh1_All();
                            this.Partposion1();
                            this.MY_BALANCE_LIMIT();
                            //this.sr_NoAuto();
                        }
                        else
                        {
                            this.txtpartiname.Text = null;
                            this.txtpartiname.Focus();
                        }

                        if (Module1.ismatchbookpopupopen == true)
                        {
                            // MyProject.Forms.MatchBOOKPOPUP.Activate();
                            MyProject.Forms.MatchBOOKPOPUP.Decliar_New();
                        }

                        this.txtpartiname.Text = null;
                        this.lblOP.Text = "0";

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                            this.txtrate.SelectAll();
                        }
                        else
                        {
                            this.txtamount.Focus();
                            this.txtamount.SelectAll();
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
                }
            }
        }

        public async Task sr_NoAuto()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(m_eid) from MatchTrans where m_id=" + this.testnu.Text + "";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.txtsrno.Text = "1";
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        this.txtsrno.Text = Conversions.ToString(num);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Match->Sr_NoAuto", ex.Message);
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        private void ComboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                Module1.mode1 = 0;
                Module1.mode2 = 0;
                if (Operators.CompareString(this.DataGridView2.Columns[1].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        Module1.mode1 = Convert.ToDouble(this.txtpak.Text);
                        Module1.mode2 = Convert.ToDouble(this.txtend.Text);
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(-Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtend.Text = this.txtamount.Text;
                        this.txtind.Text = this.txtamount.Text;
                        this.txtsut.Text = this.txtamount.Text;
                        Module1.mode1 = Convert.ToDouble(this.txtpak.Text);
                        Module1.mode2 = Convert.ToDouble(this.txtend.Text);
                    }
                }
                else if (Operators.CompareString(this.DataGridView2.Columns[2].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, this.cmbteam.Text, false) == 0)
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
                if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, null, false) == 0)
                {
                    this.txtsut.Text = "0.00";
                }
                if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, null, false) == 0)
                {
                    this.txtind.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        public void lod_newPartyname()
        {
            try
            {
                this.Cmboid.Items.Clear();
                this.txtpartiname.Items.Clear();
                this.ComboBox1.Items.Clear();
                this.ComboBox3.Items.Clear();

                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from PartyMaster ORDER BY PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    this.Cmboid.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[0]));
                    this.txtpartiname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                    if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), "", false) != 0)
                    {
                        this.ComboBox1.Items.Add(oleDbDataReader["AParty"].ToString());
                        this.ComboBox3.Items.Add(oleDbDataReader["AParty"].ToString());
                    }
                    if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), "", false) != 0)
                    {
                        this.ComboBox1.Items.Add(oleDbDataReader["TParty"].ToString());
                        this.ComboBox3.Items.Add(oleDbDataReader["TParty"].ToString());
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

        //private void txtpartiname_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Label7.Text = "Party Position Of   " + this.txtpartiname.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //    }
        //}

        public void hidetextbox()
        {
            try
            {
                this.TextBox4.Hide();
                this.TextBox5.Hide();
                this.Cmboid.Hide();
                this.PTextBox7.Hide();
                this.ATextBox5.Hide();
                this.STextBox4.Hide();
                this.txtR.Hide();
                this.txtD.Hide();
                this.txtB.Hide();
                this.Label2.Hide();
                this.Label24.Hide();
                this.txtind.Hide();
                this.txtsut.Hide();
                this.TextBox6.Hide();
                this.txtdate.Hide();
                this.txttime.Hide();
                this.txtsrno.Hide();
                this.txtpak.Hide();
                this.txtend.Hide();
                this.txtsut.Hide();
                this.Label22.Hide();
                this.Label23.Hide();
                this.Label24.Hide();
                this.cmbostus.Hide();
                this.txtmpar.Hide();
                this.subtotal.Hide();
                this.smatch.Hide();
                this.amatch.Hide();
                this.pmatch.Hide();
                this.id.Hide();
                this.txtdemo.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void txtpartiname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtpartiname = this.txtpartiname;
                this.AutoComplete(ref txtpartiname, e, false);
                this.txtpartiname = txtpartiname;
                if (Operators.CompareString(this.txtpartiname.Text, null, false) != 0)
                {
                    Module1.name1 = this.txtpartiname.Text;
                    this.Partposion1();
                   // this.Customer_OpningBalance();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        //private void Match_MouseEnter(object sender, EventArgs e)
        //{
        //	try
        //	{
        //		Size size = new Size(630, 659);
        //		this.Size = size;
        //	}
        //	catch (Exception ex)
        //	{
        //		Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                //MyProject.Forms.fromAbn.MdiParent = this.MdiParent;
                //MyProject.Forms.fromAbn.WindowState = FormWindowState.Maximized;
                //MyProject.Forms.fromAbn.Show();

                fromAbn fromAbn = new fromAbn();
                fromAbn.MdiParent = this.MdiParent;
                fromAbn.Show();

                //this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001703 RID: 5891 RVA: 0x00373328 File Offset: 0x00371728
        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double)this.modify == 1)
                {
                    Interaction.MsgBox("cannot edit Record..?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "select * from MatchTrans where m_id=",
                        this.testnu.Text,
                        " and m_eid=",
                        Conversions.ToString(this.deleteno),
                        " "
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        this.btnOk.Hide();
                        this.ismodify = true;
                        this.Button5.Show();
                        this.Button1.Show();
                        this.id.Text = Conversions.ToString(oleDbDataReader[0]);
                        this.testnu.Text = Conversions.ToString(oleDbDataReader[1]);
                        this.txtsrno.Text = Conversions.ToString(oleDbDataReader[2]);
                        this.txtpage.Text = Conversions.ToString(oleDbDataReader[3]);
                        this.txtamount.Text = Conversions.ToString(oleDbDataReader[4]);
                        this.txtrate.Text = Conversions.ToString(oleDbDataReader[5]);
                        this.cmbteam.Text = Conversions.ToString(oleDbDataReader[6]);
                        this.ComboBox2.Text = Conversions.ToString(oleDbDataReader[7]);
                        this.txtpartiname.Text = Conversions.ToString(oleDbDataReader[8]);
                        this.cmbostus.Text = Conversions.ToString(oleDbDataReader[9]);
                        this.txtdate.Text = Conversions.ToString(oleDbDataReader[10]);
                        this.txttime.Text = Conversions.ToString(oleDbDataReader[11]);
                        this.txtpak.Text = Conversions.ToString(oleDbDataReader[12]);
                        this.txtend.Text = Conversions.ToString(oleDbDataReader[13]);
                        this.txtsut.Text = Conversions.ToString(oleDbDataReader[14]);
                        this.txtind.Text = Conversions.ToString(oleDbDataReader[15]);
                        this.txtmpar.Text = Conversions.ToString(oleDbDataReader[17]);

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                            this.txtrate.SelectAll();
                        }
                        else
                        {
                            this.txtamount.Focus();
                            this.txtamount.SelectAll();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        int value = Conversions.ToInteger("1");
                        if ((double)this.modify == 1)
                        {
                            Interaction.MsgBox("Can not delete record", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            string cmdText = $"Update MatchTrans Set m_checked={Conversions.ToString(value)}, Modify='0', modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where m_id={this.testnu.Text} and m_eid={Conversions.ToString(this.deleteno)}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(cmdText);
                            }

                            int num = 1;
                            do
                            {
                                if (Module1.isntposition == true)
                                {
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[0].Cells[num].Value, "", false))
                                    {
                                        this.DataGridView2.Rows[0].Cells[num].Value = "0" + this.txtnu.Text;
                                    }
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[2].Cells[num].Value, "", false))
                                    {
                                        this.DataGridView2.Rows[2].Cells[num].Value = "0" + this.txtnu.Text;
                                    }
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[3].Cells[num].Value, "", false))
                                    {
                                        this.DataGridView2.Rows[3].Cells[num].Value = "0" + this.txtnu.Text;
                                    }
                                    num++;
                                }
                                else
                                {
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[3].Cells[num].Value, "", false))
                                    {
                                        this.DataGridView2.Rows[3].Cells[num].Value = "0" + this.txtnu.Text;
                                    }
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[0].Cells[num].Value, "", false))
                                    {
                                        this.DataGridView2.Rows[0].Cells[num].Value = "0" + this.txtnu.Text;
                                    }
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[1].Cells[num].Value, "", false))
                                    {
                                        this.DataGridView2.Rows[1].Cells[num].Value = "0" + this.txtnu.Text;
                                    }
                                    num++;
                                }
                            }
                            while (num <= 4);
                            this.Refresh1_All();
                            if (Module1.ismatchbookpopupopen == true)
                            {
                                //MyProject.Forms.MatchBOOKPOPUP.Activate();
                                MyProject.Forms.MatchBOOKPOPUP.Decliar_New();
                            }

                            //this.sr_NoAuto();
                            //this.txtamount.Focus();
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

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                {
                    this.deleteno = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this.modify = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[13].Value);
                    Module1.name1 = RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[5].Value);
                    this.Partposion1();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //MessageBox.Show("Sorry? Close Match ", "Confrm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(Module1.name1, "", false))
                {
                    formstate = this.WindowState.ToString();
                    MyProject.Forms.DPP_Match.MdiParent = this.MdiParent;
                    MyProject.Forms.DPP_Match.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.DPP_Match.Show();

                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel2.BackColor = Color.Transparent;
                this.btnOk.Show();
                this.Button5.Hide();
                this.Button1.Hide();
                this.txtpage.Text = "1";
                this.txtamount.Text = null;
                this.txtrate.Text = null;
                this.cmbteam.Text = null;
                this.ComboBox2.Text = null;
                this.txtpartiname.Text = null;
                this.lblOP.Text = "0";
                this.cmbostus.Text = null;
                this.txtdate.Text = null;
                this.txttime.Text = null;
                this.txtpak.Text = null;
                this.txtend.Text = null;
                this.txtsut.Text = null;
                this.txtind.Text = null;
                this.txtmpar.Text = null;

                if (Module1.isratefirst == true)
                {
                    this.txtrate.Focus();
                }
                else
                {
                    this.txtamount.Focus();
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                this.ismodify = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Name information?", MsgBoxStyle.OkOnly, null);
                    this.txtpartiname.Focus();
                }
                else if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                    this.txtamount.Focus();
                }
                else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                {
                    Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                    this.txtamount.Focus();
                }
                else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                    this.txtrate.Focus();
                }
                else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                {
                    Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                    this.txtrate.Focus();
                }
                else if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Team information?", MsgBoxStyle.OkOnly, null);
                    this.cmbteam.Focus();
                }
                else if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Mode information?", MsgBoxStyle.OkOnly, null);
                    this.ComboBox2.Focus();
                }
                else
                {
                    string cmdText = "SELECT Id, PartyName, Status FROM PartyMaster WHERE (PartyName = '" + this.txtpartiname.Text + "')";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        this.ComboBox2_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                        string cmdText2 = $"UPDATE MatchTrans SET m_page = '{this.txtpage.Text}', m_amt = {this.txtamount.Text}, m_rate = {this.txtrate.Text}, m_team = '{this.cmbteam.Text}', m_mode = '{this.ComboBox2.Text}', m_party = '{this.txtpartiname.Text}', modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', m_team1 =  {this.txtpak.Text}, m_team2 = {this.txtend.Text}, m_team3 = {this.txtsut.Text}, m_team4 = {this.txtind.Text}, Modify = '1' WHERE MatchTrans.m_id = {this.testnu.Text} AND MatchTrans.m_eid = {Conversions.ToString(this.deleteno)}";
                        using (MatchService matchService = new MatchService())
                        {
                            Module1.conn.Close();
                            matchService.Update(cmdText2);
                        }
                        this.btnOk.Show();
                        this.Button5.Hide();
                        this.Button1.Hide();
                        //this.DataGridView2.Rows.Clear();
                        //this.DataGridView2.Rows.Add(new object[]
                        //{
                        //	"NT"
                        //});
                        //this.DataGridView2.Rows.Add(new object[]
                        //{
                        //	"RG"
                        //});
                        //this.DataGridView2.Rows.Add(new object[]
                        //{
                        //	"BK"
                        //});

                        //this.GridRowGenerate();

                        this.Refresh1_All();
                        this.Partposion1();
                        //this.sr_NoAuto();
                        this.MY_BALANCE_LIMIT();
                    }
                    else
                    {
                        this.txtpartiname.Text = null;
                        this.txtpartiname.Focus();
                    }

                    if (Module1.ismatchbookpopupopen == true)
                    {
                        MyProject.Forms.MatchBOOKPOPUP.Activate();
                    }

                    this.txtamount.Clear();
                    //this.txtrate.Clear();
                    this.txtpartiname.Text = null;
                    this.lblOP.Text = "0";


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
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
                this.ismodify = false;
            }
        }

        public async Task Colore()
        {
            checked
            {
                try
                {
                    for (int i = 0; i <= this.DataGridView2.RowCount - 1; i++)
                    {
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

                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[4].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[4].Style.ForeColor = Color.Green;
                        }
                        this.DataGridView2.Font = new Font("Arial Black", 16);
                        this.DataGridView2.Rows[i].DefaultCellStyle.Font = new Font("Arial Black", 16);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Match->Colore", ex.Message);
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
        }

        public async Task Partposion1()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView3.Rows.Clear();
                this.DataGridView3.Rows.Add();
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.SMatchCommi, PartyMaster.SMatch, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_id, MatchTrans.m_checked FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, PartyMaster.SMatchCommi, PartyMaster.SMatch, MatchTrans.m_id, MatchTrans.m_checked HAVING (MatchTrans.m_id =",
                    this.testnu.Text,
                    ") AND (PartyMaster.PartyName ='",
                    Module1.name1.ToString(),
                    "') AND (MatchTrans.m_checked <> 1)"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num14 = 0;
                double num19 = 0;
                double num24 = 0;
                double num29 = 0;
                while (oleDbDataReader.Read())
                {
                    num14 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    num19 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    num24 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    num29 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                }

                this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(num14, this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(num19, this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(num24, this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(num29, this.txtnu.Text);
                this.postions_Colur();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                App.Utility.ErrorLog.LogError("Match->Partposion1", ex.Message);
            }
            finally
            {
                this.DataGridView3.ClearSelection();
                Module1.conn.Close();
            }
        }

        public void postions_Colur()
        {
            try
            {
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = "SELECT Newmatch.Sr_No, left(Newmatch.Date1, 10) as Date1, Newmatch.Team1, Newmatch.Name, Newmatch.Type, MatchTrans.m_eid, MatchTrans.m_page, MatchTrans.m_amt, MatchTrans.m_rate, MatchTrans.m_team, MatchTrans.m_mode, MatchTrans.m_party, MatchTrans.m_checked FROM (Newmatch INNER JOIN MatchTrans ON Newmatch.Sr_No = MatchTrans.m_id) WHERE (MatchTrans.m_checked = 0) AND (Newmatch.Sr_No = " + this.testnu.Text + ") ORDER BY MatchTrans.m_eid DESC";
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);

                //Add RPT
                //Matchreport matchreport = new Matchreport();
                //matchreport.SetDataSource(dataTable);
                //matchreport.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\Matchreport.rpt");
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

        private void txtamount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtamount.Text != "")
                {
                    try
                    {
                        this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }            	
        }


        public async Task TOTAL_ALL()
        {
            try
            {
                this.Regular_All_Tems();
                this.Regular_Total();
                this.Booky_All_Tems();
                this.Booky_Total();
                DataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Match->Total_All", ex.Message);
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtpage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtpage.Text, null, false) != 0)
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                        if (Module1.isamountfirst == true)
                        {
                            this.txtrate.SelectAll();
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

        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                        if (Module1.isratefirst == true)
                        {
                            this.txtamount.SelectAll();
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

        private void cmbteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.NumPad1)
                {
                    this.cmbteam.Text = this.Team1.ToString();
                }
                else if (e.KeyCode == Keys.NumPad2)
                {
                    this.cmbteam.Text = this.Team2.ToString();
                }
                //else if (e.KeyCode == Keys.NumPad3)
                //{
                //	this.cmbteam.Text = this.Team3.ToString();
                //}
                //else if (e.KeyCode == Keys.NumPad4)
                //{
                //	this.cmbteam.Text = this.Team4.ToString();
                //}

                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void MY_BALANCE_LIMIT()
        {
            try
            {
                double BalanceLimit = 0;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string cmdText1 = "SELECT PartyMaster.PartyName, PartyMaster.BalanceLimit FROM PartyMaster WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
                OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                while (oleDbDataReader1.Read())
                {
                    BalanceLimit = Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader1["BalanceLimit"]));
                }
                if (BalanceLimit > 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    double num = 0.0;
                    double sessionAmount = 0.0;
                    double numCell0 = 0.0;
                    double numCell1 = 0.0;
                    double numCell2 = 0.0;
                    double numCell3 = 0.0;
                    double nuCellFinal = 0.0;
                    double finalsessionamount = 0;
                    double FinalBalanceLimit = 0;

                    string cmdText = "SELECT SUM(tns_Amount) AS ClosingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtpartiname.Text + "') GROUP BY tns_Party ";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        num += Convert.ToDouble(oleDbDataReader["ClosingBalanceAmount"]);
                    }

                    FinalBalanceLimit = BalanceLimit + num;

                    /// Start - For Session Balance Limit
                    string strsessionlimit = "SELECT Newmatch.Sr_No FROM Newmatch WHERE Result <> 'Declared'";
                    OleDbCommand oleDbCommandSessionLimit = new OleDbCommand(strsessionlimit, Module1.conn);
                    OleDbDataReader oleDbReaderSessionLimit = oleDbCommandSessionLimit.ExecuteReader();
                    while (oleDbReaderSessionLimit.Read())
                    {
                        int match_id = 0;
                        match_id = Conversions.ToInteger(oleDbReaderSessionLimit["Sr_No"]);
                        bool isvalid = false;

                        string str1 = "SELECT Sr_No FROM ewSession WHERE Match_ID = " + match_id + " AND Result <> 'Declared' ";
                        OleDbCommand oleDbSes = new OleDbCommand(str1, Module1.conn);
                        OleDbDataReader oleDbReaderSes = oleDbSes.ExecuteReader();
                        while (oleDbReaderSes.Read())
                        {
                            int ses_id = 0;
                            ses_id = Conversions.ToInteger(oleDbReaderSes["Sr_No"]);

                            string str = "SELECT s_party, Min(S_RUN) as MinRun, Max(S_RUN) as MaxRun FROM (SessionTrans) WHERE (s_party = '" + this.txtpartiname.Text + "') AND (s_checked = 0) AND (Session_ID = " + ses_id + ") GROUP BY s_party HAVING Min(S_RUN) > 0 AND Max(S_RUN) > 0";
                            OleDbCommand oleDbCommandBal = new OleDbCommand(str, Module1.conn);
                            OleDbDataReader oleDbReaderBal = oleDbCommandBal.ExecuteReader();
                            while (oleDbReaderBal.Read())
                            {
                                isvalid = true;
                                int MinRun = Conversions.ToInteger(oleDbReaderBal["MinRun"] == null ? 0 : oleDbReaderBal["MinRun"]);
                                int MaxRun = Conversions.ToInteger(oleDbReaderBal["MaxRun"] == null ? 0 : oleDbReaderBal["MaxRun"]);

                                if (MinRun > 0 && MaxRun > 0)
                                {
                                    GenrateGridRow_From_To((MinRun - 1), (MaxRun + 1));
                                }
                            }

                            string cmdTextSession = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SSession, PartyMaster.SSessionCommi, PartyMaster.ASession, PartyMaster.ASessionCommi, PartyMaster.TSession, PartyMaster.TSessionCommi, SessionTrans.S_Sr_No, SessionTrans.s_checked, SessionTrans.Session_ID, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.S_RUN, SessionTrans.s_amt, SessionTrans.s_rate, SessionTrans.s_mod, SessionTrans.s_bild, SessionTrans.Comission FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') AND (SessionTrans.s_checked = 0) AND (SessionTrans.Session_ID = " + ses_id + ") ";
                            OleDbCommand oleDbCommandSession = new OleDbCommand(cmdTextSession, Module1.conn);
                            OleDbDataReader oleDbDataReaderSession = oleDbCommandSession.ExecuteReader();
                            while (oleDbDataReaderSession.Read())
                            {
                                double after_selfld = Convert.ToDouble(oleDbDataReaderSession["SSession"]);
                                double after_totalld = Convert.ToDouble(Operators.AddObject(oleDbDataReaderSession["ASession"], oleDbDataReaderSession["TSession"]));
                                double totalcommi = Convert.ToDouble(oleDbDataReaderSession["SSessionCommi"]) + Convert.ToDouble(oleDbDataReaderSession["ASessionCommi"]) + Convert.ToDouble(oleDbDataReaderSession["TSessionCommi"]);

                                string comm = Conversions.ToString(oleDbDataReaderSession["Comission"]);
                                string status = Conversions.ToString(oleDbDataReaderSession["Status"]);
                                double run = Convert.ToDouble(oleDbDataReaderSession["S_RUN"]) - 1;
                                double amt = Convert.ToDouble(oleDbDataReaderSession["s_amt"]);
                                double rate = Convert.ToDouble(oleDbDataReaderSession["s_rate"]);

                                double yes = Convert.ToDouble(oleDbDataReaderSession["s_yes"]);
                                double no = Convert.ToDouble(oleDbDataReaderSession["s_no"]);

                                double num9 = Conversion.Val(yes) * Conversion.Val(after_selfld) / 100 - yes;
                                double num10 = Conversion.Val(no) * Conversion.Val(after_selfld) / 100 - no;
                                double num11 = num9 - num9 - num9;
                                double num12 = num10 - num10 - num10;
                                double num13 = Conversion.Val(num9) * Conversion.Val(after_totalld) / 100 - num9;
                                double num14 = Conversion.Val(num10) * Conversion.Val(after_totalld) / 100 - num10;

                                if (comm == "YES")
                                {
                                    double commamt = 0;
                                    if (num13 > num14)
                                    {
                                        commamt = num14 - num14 - num14;
                                    }
                                    else
                                    {
                                        commamt = num14;
                                    }

                                    if (status == "Booky")
                                    {
                                        if (num13 > 0)
                                        {
                                            this.Yes1 = Conversion.Val(num13) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.Yes1 = Conversion.Val(num13) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }

                                        if (num14 > 0)
                                        {
                                            this.No1 = Conversion.Val(num14) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.No1 = Conversion.Val(num14) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                    }
                                    else if (status == "Regular")
                                    {
                                        if (num13 > 0)
                                        {
                                            this.Yes1 = Conversion.Val(num13) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.Yes1 = Conversion.Val(num13) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }

                                        if (num14 > 0)
                                        {
                                            this.No1 = Conversion.Val(num14) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.No1 = Conversion.Val(num14) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                    }
                                }
                                else
                                {
                                    this.Yes1 = Conversion.Val(num13);
                                    this.No1 = Conversion.Val(num14);
                                }

                                checked
                                {
                                    for (int i = 0; i <= this.dataGridView8.Rows.Count - 1; i++)
                                    {
                                        if (Operators.ConditionalCompareObjectGreater(this.dataGridView8.Rows[i].Cells[0].Value, run, false))
                                        {
                                            if (Operators.CompareString(status, "Regular", false) == 0)
                                            {
                                                DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[3];
                                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
                                            }
                                            else if (Operators.CompareString(status, "Booky", false) == 0)
                                            {
                                                DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[4];
                                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
                                            }
                                        }
                                        else if (Operators.CompareString(status, "Regular", false) == 0)
                                        {
                                            DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[3];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
                                        }
                                        else if (Operators.CompareString(status, "Booky", false) == 0)
                                        {
                                            DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[4];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
                                        }
                                        this.dataGridView8.Rows[i].Cells[1].Value = Strings.Format(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dataGridView8.Rows[i].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.dataGridView8.Rows[i].Cells[4].Value))), this.txtnu.Text);
                                    }
                                }

                                this.dataGridView8.Columns[0].Width = 51;
                                this.dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                                if (dataGridView8.Rows.Count > 0)
                                {
                                    DataTable dt = new DataTable();
                                    dt.Columns.Add("RUN", typeof(int));
                                    dt.Columns.Add("NP", typeof(double));
                                    dt.Columns.Add("DM", typeof(double));
                                    dt.Columns.Add("RG", typeof(double));
                                    dt.Columns.Add("BK", typeof(double));

                                    foreach (DataGridViewRow row in dataGridView8.Rows)
                                    {
                                        dt.Rows.Add();
                                        foreach (DataGridViewCell cell in row.Cells)
                                        {
                                            if (cell.Value != null)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                                            }
                                            else
                                            {
                                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = (0).ToString();
                                            }
                                        }
                                    }
                                    finalsessionamount = dt.AsEnumerable().Max(row => Convert.ToDouble(row["RG"]));
                                }
                            }
                            if (isvalid == true)
                            {
                                sessionAmount += finalsessionamount;
                            }
                        }
                    }
                    /// End - For Session Balance Limit


                    ////Start - For Match Balance LImit
                    string cmdTextMatch = string.Concat(new string[]
                    {
                    "SELECT * FROM (",
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatchCommi, PartyMaster.SMatch HAVING (PartyMaster.PartyName = '",
                    this.txtpartiname.Text,
                    "') AND (MatchTrans.m_id IN (SELECT DISTINCT Sr_No FROM Newmatch WHERE Result <> 'Declared') ",
                    //this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus')) ",
                    " UNION ALL ",
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) WHERE (PartyMaster.PartyName = '",
                    this.txtpartiname.Text,
                    "') AND (MatchTrans.m_id IN (SELECT DISTINCT Sr_No FROM Newmatch WHERE Result <> 'Declared') ",
                    //this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('Entry Wise')) ",
                    ") ORDER BY PartyMaster.PartyName"
                    });
                    OleDbCommand oleDbCommandMatch = new OleDbCommand(cmdTextMatch, Module1.conn);
                    OleDbDataReader oleDbDataReaderMatch = oleDbCommandMatch.ExecuteReader();
                    while (oleDbDataReaderMatch.Read())
                    {
                        string status = Conversions.ToString(oleDbDataReaderMatch["Status"]);
                        double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderMatch["SMatch"])));
                        double smatchcommi = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderMatch["SMatchCommi"])));

                        double exp1 = Conversion.Val(oleDbDataReaderMatch["Expr1"]);
                        double exp2 = Conversion.Val(oleDbDataReaderMatch["Expr2"]);
                        double exp3 = Conversion.Val(oleDbDataReaderMatch["Expr3"]);
                        double exp4 = Conversion.Val(oleDbDataReaderMatch["Expr4"]);

                        double exp1_total = 0, exp1_selfld = 0, exp1_afterldcommi = 0;
                        double exp2_total = 0, exp2_selfld = 0, exp2_afterldcommi = 0;
                        double exp3_total = 0, exp3_selfld = 0, exp3_afterldcommi = 0;
                        double exp4_total = 0, exp4_selfld = 0, exp4_afterldcommi = 0;

                        exp1_total = exp1;
                        exp1_selfld = exp1 * smatch;
                        exp1_selfld = (exp1 * smatch) - (exp1 * smatch) - (exp1 * smatch);
                        exp1_afterldcommi = exp1 - (exp1 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp1_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
                            exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp1_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
                            exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num1));
                        }
                        numCell0 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell0)), Conversion.Val(exp1_afterldcommi)), this.txtnu.Text));

                        exp2_total = exp2;
                        exp2_selfld = exp2 * smatch;
                        exp2_selfld = (exp2 * smatch) - (exp2 * smatch) - (exp2 * smatch);
                        exp2_afterldcommi = exp2 - (exp2 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp2_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
                            exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp2_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
                            exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num1));
                        }
                        numCell1 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell1)), Conversion.Val(exp2_afterldcommi)), this.txtnu.Text));

                        exp3_total = exp3;
                        exp3_selfld = exp3 * smatch;
                        exp3_selfld = (exp3 * smatch) - (exp3 * smatch) - (exp3 * smatch);
                        exp3_afterldcommi = exp3 - (exp3 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp3_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
                            exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp3_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
                            exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num1));
                        }
                        numCell2 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell2)), Conversion.Val(exp3_afterldcommi)), this.txtnu.Text));

                        exp4_total = exp4;
                        exp4_selfld = exp4 * smatch;
                        exp4_selfld = (exp4 * smatch) - (exp4 * smatch) - (exp4 * smatch);
                        exp4_afterldcommi = exp4 - (exp4 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp4_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
                            exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp4_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
                            exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num1));
                        }
                        numCell3 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell3)), Conversion.Val(exp4_afterldcommi)), this.txtnu.Text));
                    }
                    ////End - For Match Balance LImit
                    nuCellFinal = Math.Max(numCell0, Math.Max(numCell1, numCell2));


                    this.Hours1 = Conversion.Val(nuCellFinal) + Conversion.Val(sessionAmount);
                    if (Hours1 > FinalBalanceLimit)
                    {
                        double limit = Hours1 - FinalBalanceLimit;
                        Balance_Message balance_Message = new Balance_Message();
                        balance_Message.BalanceLimit = Module1.SetNumFormat(Conversion.Val(limit), this.txtnu.Text);
                        balance_Message.ShowDialog();
                        this.txtpartiname.Text = null;

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

        //private async Task GenrateGridRow(int run)
        //{
        //    try
        //    {
        //        this.datagridmen.Rows.Clear();
        //        int num = 0;
        //        int num2 = (int)(Math.Round(unchecked(run + 0.0)) - 1);
        //        for (int i = num; i <= num2; i++)
        //        {
        //            this.datagridmen.Columns[0].Width = 50;
        //            int index = this.datagridmen.Rows.Add();
        //            this.datagridmen.Rows[index].Cells[0].Value = i;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        App.Utility.ErrorLog.LogError("Form3_SESSION->GenerateGridRow", ex.Message);
        //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //    }
        //}

        private async Task GenrateGridRow_From_To(int from, int to)
        {
            try
            {
                this.dataGridView8.Rows.Clear();                
                for (int i = from; i <= to; i++)
                {
                    this.dataGridView8.Columns[0].Width = 50;
                    int index = this.dataGridView8.Rows.Add();
                    this.dataGridView8.Rows[index].Cells[0].Value = i;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Form3_SESSION->GenerateGridRow", ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Button3.Text = "&Full Screen";
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Button3.Text = "&Haf-Screen";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void Match_Max_Mini()
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Button3.Text = "&Full Screen";
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Button3.Text = "&Haf-Screen";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
        public void Match_Max_MiniDPS()
        {
            try
            {
                formstate = this.WindowState.ToString();
                if (formstate == FormWindowState.Maximized.ToString())
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Button3.Text = "&Full Screen";
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Button3.Text = "&Haf-Screen";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtpage_Enter(object sender, EventArgs e)
        {
            try
            {
                NewLateBinding.LateCall(sender, null, "SelectAll", new object[0], null, null, null, true);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Module1.mode1 = 0;
                Module1.mode2 = 0;
                if (Operators.CompareString(this.DataGridView2.Columns[1].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        Module1.mode1 = Convert.ToDouble(this.txtpak.Text);
                        Module1.mode2 = Convert.ToDouble(this.txtend.Text);
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(-Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtend.Text = this.txtamount.Text;
                        this.txtind.Text = this.txtamount.Text;
                        this.txtsut.Text = this.txtamount.Text;
                        Module1.mode1 = Convert.ToDouble(this.txtpak.Text);
                        Module1.mode2 = Convert.ToDouble(this.txtend.Text);
                    }
                }
                else if (Operators.CompareString(this.DataGridView2.Columns[2].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, this.cmbteam.Text, false) == 0)
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
                else if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, this.cmbteam.Text, false) == 0)
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
                if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, null, false) == 0)
                {
                    this.txtsut.Text = "0.00";
                }
                if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, null, false) == 0)
                {
                    this.txtind.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private async Task Refresh1_All()
        {
            try
            {
                if (Module1.chkmatchbook == true)
                {
                    this.testnu.Text = Conversions.ToString(Module1.machid);
                }
                //this.testnu.Text = Conversions.ToString(Module1.machid);
                await this.sr_NoAuto();
                await this.GridRowGenerate();

                await this.TOTAL_ALL();
                await this.Net_Postion();
                await this.Colore();

                await this.Agent1();
                await this.Agent2();

                this.listboxlode();

                if (Module1.isratefirst == true)
                {
                    this.txtrate.Focus();
                    this.txtrate.SelectAll();
                }
                else
                {
                    this.txtamount.Focus();
                    this.txtamount.SelectAll();
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Match->Refresh1_All", ex.Message);
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //private void cmbteam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //	try
        //	{
        //		if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
        //		{
        //			this.Focus();
        //		}
        //	}
        //	catch (Exception ex)
        //	{
        //		Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        public void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.lod_newPartyname();
                this.Decleard();
                this.Refresh1_All();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void AutoComplete_Agent1(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.ComboBox1.SelectionStart <= 1)
                        {
                            this.ComboBox1.Text = "";
                            return;
                        }
                        if (this.ComboBox1.SelectionLength == 0)
                        {
                            text = this.ComboBox1.Text.Substring(0, this.ComboBox1.Text.Length - 1);
                        }
                        else
                        {
                            text = this.ComboBox1.Text.Substring(0, this.ComboBox1.SelectionStart - 1);
                        }
                    }
                    else if (this.ComboBox1.SelectionLength == 0)
                    {
                        text = this.ComboBox1.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.ComboBox1.Text.Substring(0, this.ComboBox1.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.ComboBox1.FindString(text);
                    if (num != -1)
                    {
                        this.ComboBox1.SelectedText = "";
                        this.ComboBox1.SelectedIndex = num;
                        this.ComboBox1.SelectionStart = text.Length;
                        this.ComboBox1.SelectionLength = this.ComboBox1.Text.Length;
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

        public void AutoComplete_Agent2(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.ComboBox3.SelectionStart <= 1)
                        {
                            this.ComboBox3.Text = "";
                            return;
                        }
                        if (this.ComboBox3.SelectionLength == 0)
                        {
                            text = this.ComboBox3.Text.Substring(0, this.ComboBox3.Text.Length - 1);
                        }
                        else
                        {
                            text = this.ComboBox3.Text.Substring(0, this.ComboBox3.SelectionStart - 1);
                        }
                    }
                    else if (this.ComboBox3.SelectionLength == 0)
                    {
                        text = this.ComboBox3.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.ComboBox3.Text.Substring(0, this.ComboBox3.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.ComboBox3.FindString(text);
                    if (num != -1)
                    {
                        this.ComboBox3.SelectedText = "";
                        this.ComboBox3.SelectedIndex = num;
                        this.ComboBox3.SelectionStart = text.Length;
                        this.ComboBox3.SelectionLength = this.ComboBox3.Text.Length;
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

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox comboBox = this.ComboBox1;
                this.AutoComplete_Agent1(ref comboBox, e, false);
                this.ComboBox1 = comboBox;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    this.ComboBox1.Text = null;
                    this.ComboBox1.Focus();
                }
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.ComboBox1.Text, null, false) != 0)
                    {
                        this.Agent1();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void ComboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox comboBox = this.ComboBox3;
                this.AutoComplete_Agent2(ref comboBox, e, false);
                this.ComboBox3 = comboBox;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void ComboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    this.ComboBox3.Text = null;
                    this.ComboBox3.Focus();
                }
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.ComboBox3.Text, null, false) != 0)
                    {
                        this.Agent2();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        public async Task Agent1()
        {
            if (this.ComboBox1.Text == "")
                return;
            
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView4.Rows.Clear();
                this.DataGridView4.Rows.Add();
                string cmdText = string.Concat(new string[]
                {
                    "SELECT * FROM (",
                    "SELECT PartyMaster.SMatchCommi, PartyMaster.AMatchCommi, PartyMaster.TMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, MatchTrans.m_id, PartyMaster.Status, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.AMatchCommi, PartyMaster.TMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, MatchTrans.m_checked, MatchTrans.m_id, PartyMaster.Status, PartyMaster.MatchCommiType HAVING (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = ",
                    this.testnu.Text.ToString(),
                    ") AND (PartyMaster.AParty = '",
                    this.ComboBox1.Text,
                    "' OR PartyMaster.TParty = '",
                    this.ComboBox1.Text,
                    "') AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus'))",
                    " UNION ALL ",
                    "SELECT PartyMaster.SMatchCommi, PartyMaster.AMatchCommi, PartyMaster.TMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.PartyName, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, MatchTrans.m_id, PartyMaster.Status, PartyMaster.MatchCommiType FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked = 0) AND (MatchTrans.m_id = ",
                    this.testnu.Text.ToString(),
                    ") AND (PartyMaster.AParty = '",
                    this.ComboBox1.Text,
                    "' OR PartyMaster.TParty = '",
                    this.ComboBox1.Text,
                    "') AND (PartyMaster.MatchCommiType IN ('Entry Wise'))",
                    ") ORDER BY PartyName"
                });

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

                double num501 = 0, num502 = 0, num503 = 0, num504 = 0;
                while (oleDbDataReader.Read())
                {

                    double smatch = Convert.ToDouble(oleDbDataReader["SMatch"].ToString());
                    double amatch = Convert.ToDouble(oleDbDataReader["AMatch"].ToString());
                    double tmatch = Convert.ToDouble(oleDbDataReader["TMatch"].ToString());

                    double smatchcommi = Convert.ToDouble(oleDbDataReader["SMatchCommi"].ToString());
                    double amatchcommi = Convert.ToDouble(oleDbDataReader["AMatchCommi"].ToString());
                    double tmatchcommi = Convert.ToDouble(oleDbDataReader["TMatchCommi"].ToString());
                    double totalcommi = Conversion.Val(smatchcommi) + Conversion.Val(amatchcommi) + Conversion.Val(tmatchcommi);

                    string party = oleDbDataReader["PartyName"].ToString();
                    string aparty = oleDbDataReader["AParty"].ToString();
                    string tparty = oleDbDataReader["TParty"].ToString();
                    string status = oleDbDataReader["Status"].ToString();

                    double num9 = 0, num10 = 0, num11 = 0, num12 = 0;
                    num9 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    num10 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    num11 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    num12 = Convert.ToDouble(oleDbDataReader["Expr4"]);

                    double afterldamt1 = 0, afterldamt2 = 0, afterldamt3 = 0, afterldamt4 = 0;
                    afterldamt1 = Conversion.Val(num9) - (Conversion.Val(num9) * Conversion.Val(smatch) / 100);
                    afterldamt2 = Conversion.Val(num10) - (Conversion.Val(num10) * Conversion.Val(smatch) / 100);
                    afterldamt3 = Conversion.Val(num11) - (Conversion.Val(num11) * Conversion.Val(smatch) / 100);
                    afterldamt4 = Conversion.Val(num12) - (Conversion.Val(num12) * Conversion.Val(smatch) / 100);

                    if (Operators.CompareString(status, "Booky", false) == 0)
                    {
                        if (Operators.CompareString(aparty, null, false) != 0)
                        {
                            if (num9 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt1) * Conversion.Val(amatchcommi) / 100;
                                num501 = Conversion.Val(num111);
                            }
                            else
                            {                                
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(amatch) / 100;
                                num501 = Conversion.Val(num101);
                            }

                            if (num10 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt2) * Conversion.Val(amatchcommi) / 100;
                                num502 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(amatch) / 100;
                                num502 = Conversion.Val(num101);
                            }

                            if (num11 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt3) * Conversion.Val(amatchcommi) / 100;
                                num503 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(amatch) / 100;
                                num503 = Conversion.Val(num101);
                            }

                            if (num12 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt4) * Conversion.Val(amatchcommi) / 100;
                                num504 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(amatch) / 100;
                                num504 = Conversion.Val(num101);
                            }
                        }

                        if (Operators.CompareString(tparty, null, false) != 0)
                        {
                            if (num9 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt1) * Conversion.Val(tmatchcommi) / 100;
                                num501 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(tmatch) / 100;
                                num501 = Conversion.Val(num101);
                            }

                            if (num10 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt2) * Conversion.Val(tmatchcommi) / 100;
                                num502 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(tmatch) / 100;
                                num502 = Conversion.Val(num101);
                            }

                            if (num11 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt3) * Conversion.Val(tmatchcommi) / 100;
                                num503 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(tmatch) / 100;
                                num503 = Conversion.Val(num101);
                            }

                            if (num12 < 0)
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt4) * Conversion.Val(tmatchcommi) / 100;
                                num504 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(tmatch) / 100;
                                num504 = Conversion.Val(num101);
                            }
                        }
                    }

                    if (Operators.CompareString(status, "Regular", false) == 0)
                    {
                        if (Operators.CompareString(aparty, null, false) != 0)
                        {
                            if (num9 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt1) * Conversion.Val(amatchcommi) / 100;
                                num501 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(amatch) / 100;
                                num501 = Conversion.Val(num101);
                            }

                            if (num10 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt2) * Conversion.Val(amatchcommi) / 100;
                                num502 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(amatch) / 100;
                                num502 = Conversion.Val(num101);
                            }

                            if (num11 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt3) * Conversion.Val(amatchcommi) / 100;
                                num503 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(amatch) / 100;
                                num503 = Conversion.Val(num101);
                            }

                            if (num12 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(amatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt4) * Conversion.Val(amatchcommi) / 100;
                                num504 = Conversion.Val(num111);                                
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(amatch) / 100;
                                num504 = Conversion.Val(num101);
                            }
                        }

                        if (Operators.CompareString(tparty, null, false) != 0)
                        {
                            if (num9 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt1) * Conversion.Val(tmatchcommi) / 100;
                                num501 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt1) * Conversion.Val(tmatch) / 100;
                                num501 = Conversion.Val(num101);
                            }

                            if (num10 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt2) * Conversion.Val(tmatchcommi) / 100;
                                num502 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt2) * Conversion.Val(tmatch) / 100;
                                num502 = Conversion.Val(num101);
                            }

                            if (num11 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt3) * Conversion.Val(tmatchcommi) / 100;
                                num503 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt3) * Conversion.Val(tmatch) / 100;
                                num503 = Conversion.Val(num101);
                            }

                            if (num12 > 0)
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(tmatch) / 100;
                                double num111 = Conversion.Val(num101) + Conversion.Val(afterldamt4) * Conversion.Val(tmatchcommi) / 100;
                                num504 = Conversion.Val(num111);
                            }
                            else
                            {
                                double num101 = Conversion.Val(afterldamt4) * Conversion.Val(tmatch) / 100;
                                num504 = Conversion.Val(num101);
                            }
                        }
                    }

                    double num13 = Convert.ToDouble(this.DataGridView4.Rows[0].Cells[0].Value);
                    double num14 = Convert.ToDouble(this.DataGridView4.Rows[0].Cells[1].Value);
                    double num15 = Convert.ToDouble(this.DataGridView4.Rows[0].Cells[2].Value);
                    double num16 = Convert.ToDouble(this.DataGridView4.Rows[0].Cells[3].Value);

                    this.DataGridView4.Rows[0].Cells[0].Value = Module1.SetNumFormat((Conversion.Val(num13) + Conversion.Val(num501)), this.txtnu.Text);
                    this.DataGridView4.Rows[0].Cells[1].Value = Module1.SetNumFormat((Conversion.Val(num14) + Conversion.Val(num502)), this.txtnu.Text);
                    this.DataGridView4.Rows[0].Cells[2].Value = Module1.SetNumFormat((Conversion.Val(num15) + Conversion.Val(num503)), this.txtnu.Text);
                    this.DataGridView4.Rows[0].Cells[3].Value = Module1.SetNumFormat((Conversion.Val(num16) + Conversion.Val(num504)), this.txtnu.Text);
                }


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
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataGridView4.ClearSelection();
                Module1.conn.Close();
            }
        }

        public async Task Agent2()
        {
            if (this.ComboBox3.Text == "")
                return;
            
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView7.Rows.Clear();
                this.DataGridView7.Rows.Add();
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, MAX(PartyMaster.SMatchCommi) AS SMatchCommi, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE (MatchTrans.m_checked <> 1) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch HAVING (MatchTrans.m_id = ",
                    this.testnu.Text.ToString(),
                    ") AND (PartyMaster.AParty = '",
                    this.ComboBox3.Text,
					//"' OR PartyMaster.PartyName = '",
					//this.ComboBox3.Text,
					"' OR PartyMaster.TParty = '",
                    this.ComboBox3.Text,
                    "')"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num9 = 0, num10 = 0, num11 = 0, num12 = 0, smatchcommi = 0;

                while (oleDbDataReader.Read())
                {
                    smatchcommi = Conversion.Val(oleDbDataReader["SMatchCommi"]);

                    double num = Convert.ToDouble(Conversion.Val(oleDbDataReader["Expr1"]) * Conversion.Val(oleDbDataReader["SMatch"]) / 100);
                    double num2 = Convert.ToDouble(Conversion.Val(oleDbDataReader["Expr2"]) * Conversion.Val(oleDbDataReader["SMatch"]) / 100);
                    double num3 = Convert.ToDouble(Conversion.Val(oleDbDataReader["Expr3"]) * Conversion.Val(oleDbDataReader["SMatch"]) / 100);
                    double num4 = Convert.ToDouble(Conversion.Val(oleDbDataReader["Expr4"]) * Conversion.Val(oleDbDataReader["SMatch"]) / 100);

                    double num5 = Conversion.Val(oleDbDataReader["Expr1"]) - Conversion.Val(num);
                    double num6 = Conversion.Val(oleDbDataReader["Expr2"]) - Conversion.Val(num2);
                    double num7 = Conversion.Val(oleDbDataReader["Expr3"]) - Conversion.Val(num3);
                    double num8 = Conversion.Val(oleDbDataReader["Expr4"]) - Conversion.Val(num4);

                    if (Operators.CompareString(oleDbDataReader["PartyName"].ToString(), this.ComboBox3.Text, false) == 0)
                    {
                        num9 += num;
                        num10 += num2;
                        num11 += num3;
                        num12 += num4;
                    }
                    if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), this.ComboBox3.Text, false) == 0)
                    {
                        num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(oleDbDataReader["TMatch"]) / 100);
                        num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(oleDbDataReader["TMatch"]) / 100);
                        num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(oleDbDataReader["TMatch"]) / 100);
                        num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(oleDbDataReader["TMatch"]) / 100);
                    }
                    if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), this.ComboBox3.Text, false) == 0)
                    {
                        num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(oleDbDataReader["AMatch"]) / 100);
                        num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(oleDbDataReader["AMatch"]) / 100);
                        num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(oleDbDataReader["AMatch"]) / 100);
                        num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(oleDbDataReader["AMatch"]) / 100);
                    }

                }
                double num13 = Convert.ToDouble(this.DataGridView7.Rows[0].Cells[0].Value);
                double num14 = Convert.ToDouble(this.DataGridView7.Rows[0].Cells[1].Value);
                double num15 = Convert.ToDouble(this.DataGridView7.Rows[0].Cells[2].Value);
                double num16 = Convert.ToDouble(this.DataGridView7.Rows[0].Cells[3].Value);

                this.DataGridView7.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num13) + Conversion.Val(num9), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num14) + Conversion.Val(num10), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num15) + Conversion.Val(num11), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num16) + Conversion.Val(num12), this.txtnu.Text);

                if (Operators.ConditionalCompareObjectLess(this.DataGridView7.Rows[0].Cells[0].Value, 0, false))
                {
                    this.DataGridView7.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView7.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView7.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView7.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView7.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView7.Rows[0].Cells[2].Value, 0, false))
                {
                    this.DataGridView7.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView7.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView7.Rows[0].Cells[3].Value, 0, false))
                {
                    this.DataGridView7.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView7.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataGridView7.ClearSelection();
                Module1.conn.Close();
            }
        }

        public void Customer_OpningBalance()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                double num = 0.0;
                double num1 = 0.0;
                this.lblOP.Text = "0";

                string cmdText = "SELECT SUM(tns_Amount) AS ClosingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtpartiname.Text + "') GROUP BY tns_Party ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    num += Convert.ToDouble(oleDbDataReader["ClosingBalanceAmount"]);
                }

                //string cmdText = "SELECT PartyMaster.PartyName, SUM(Trans.tns_Amount) AS Expr1 FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) GROUP BY PartyMaster.PartyName, Trans.tns_chk, Trans.tns_Type HAVING (Trans.tns_chk = '0') AND (Trans.tns_Type <> 'Monday Settlement') AND (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
                //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                //while (oleDbDataReader.Read())
                //{
                //	num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
                //}
                string cmdText1 = "SELECT PartyMaster.PartyName,  PartyMaster.BalanceLimit FROM PartyMaster WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
                OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                while (oleDbDataReader1.Read())
                {
                    num1 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader1["BalanceLimit"]));
                }

                this.lblOP.Text = Module1.SetNumFormat(Conversion.Val(num - num1), this.txtnu.Text);
                if (Convert.ToDouble(this.lblOP.Text) < 0.0)
                {
                    this.lblOP.ForeColor = Color.Red;
                }
                else
                {
                    this.lblOP.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                Module1.matchbooklist = Conversions.ToInteger(this.testnu.Text);
                MyProject.Forms.MatchBOOKPOPUP.my_Positions();
                MyProject.Forms.MatchBOOKPOPUP.MdiParent = this.MdiParent;
                MyProject.Forms.MatchBOOKPOPUP.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtpartiname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (ismodify == false)
                    {
                        if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                        {
                            this.Focus();
                        }
                        else
                        {
                            btnOk.Focus();
                        }
                    }
                    else
                    {
                        this.Button1.Focus();
                    }
                }

                if (e.KeyCode == Keys.Back)
                {
                    this.txtpartiname.Text = null;
                    this.txtpartiname.Focus();
                }

                if (e.KeyCode == Keys.Escape)
                {
                    try
                    {
                        MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                        MyProject.Forms.Session_Report.Show();

                        MyProject.Forms.Match_Report.MdiParent = this.MdiParent;
                        MyProject.Forms.Match_Report.Show();

                        Module1.machid = 0;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                    }
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
                Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                    }
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            Module1.machid = 0;
        }

        // Token: 0x040009BB RID: 2491
        private double BalanceAmount;

        // Token: 0x040009BC RID: 2492
        private double Hours1;

        // Token: 0x040009BD RID: 2493
        private double Hours2;

        // Token: 0x040009C3 RID: 2499
        private double Rtotal1;

        // Token: 0x040009C4 RID: 2500
        private double Rtotal2;

        // Token: 0x040009C5 RID: 2501
        private double Rtotal3;

        // Token: 0x040009C6 RID: 2502
        private double Rtotal4;

        // Token: 0x040009D5 RID: 2517
        private int deleteno;

        // Token: 0x040009D6 RID: 2518
        private int modify;

        // Token: 0x040009D7 RID: 2519
        public string Team1;

        // Token: 0x040009D8 RID: 2520
        public string Team2;

        // Token: 0x040009D9 RID: 2521
        public string Team3;

        // Token: 0x040009DA RID: 2522
        public string Team4;

        // Token: 0x040009DB RID: 2523
        private string Te1;

        // Token: 0x040009DC RID: 2524
        private string Te2;

        // Token: 0x040009DD RID: 2525
        private string Te3;

        // Token: 0x040009DE RID: 2526
        private string Te4;

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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Match_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    //Form3_SESSION form3_SESSION = new Form3_SESSION();
                    //form3_SESSION.Activate();
                    MyProject.Forms.Form3_SESSION.Activate();
                }
                if (e.Control && e.KeyCode == Keys.M)
                {
                    if (Module1.isratefirst == true)
                    {
                        txtrate.Focus();
                        txtrate.SelectAll();
                    }
                    else
                    {
                        txtamount.Focus();
                        txtamount.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Match_Shown(object sender, EventArgs e)
        {
            this.Refresh1_All();
        }

        private void txtpartiname_Leave(object sender, EventArgs e)
        {
            if (this.txtpartiname.Text != "")
            {
                bool itemExists = false;
                foreach (var item in this.txtpartiname.Items)
                {
                    if (item.Equals(this.txtpartiname.Text))
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    this.txtpartiname.Text = "";
                    this.txtpartiname.Focus();
                }
            }
        }

    }
}
