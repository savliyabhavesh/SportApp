using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using App.Service;
using YashAksh.My;

namespace YashAksh
{
    // Token: 0x02000057 RID: 87
    //[DesignerGenerated]
    public partial class MatchBOOKPOPUP : Form
    {
        // Token: 0x0600172E RID: 5934 RVA: 0x00271514 File Offset: 0x0026F914
        public MatchBOOKPOPUP()
        {
            //base.Load += this.MatchBOOKPOPUP_Load;
            this.txtnu = new TextBox();
            //this.txtmodify = new TextBox();
            this.InitializeComponent();
        }

        private void MatchBOOKPOPUP_Activated(object sender, EventArgs e)
        {
            this.Decliar_New();
        }

        // Token: 0x06001769 RID: 5993 RVA: 0x00272A1C File Offset: 0x00270E1C
        private void MatchBOOKPOPUP_Load(object sender, EventArgs e)
        {
            try
            {
                this.Panel3.Visible = false;
                this.TextBox1.Text = Conversions.ToString(Module1.matchbooklist);
                this.txtnu.Text = Module1.decimalnumberformat;
                this.listviewaddalldata();
                this.my_Positions();
                Module1.ismatchbookpopupopen = true;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void MatchBOOKPOPUP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Module1.ismatchbookpopupopen = false;
        }


        // Token: 0x0600176A RID: 5994 RVA: 0x00272A58 File Offset: 0x00270E58
        public void listviewaddalldata()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox1.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.DataGridView1.Columns[1].HeaderText = Conversions.ToString(oleDbDataReader[2]);
                    this.DataGridView1.Columns[2].HeaderText = Conversions.ToString(oleDbDataReader[3]);
                    this.DataGridView1.Columns[3].HeaderText = Conversions.ToString(oleDbDataReader[7]);
                    this.DataGridView1.Columns[4].HeaderText = Conversions.ToString(oleDbDataReader[8]);

                    this.DataGridView3.Columns[8].HeaderText = oleDbDataReader["horse1"].ToString();
                    this.DataGridView3.Columns[9].HeaderText = oleDbDataReader["horse2"].ToString();
                    this.DataGridView3.Columns[10].HeaderText = oleDbDataReader["horse3"].ToString();
                    this.DataGridView3.Columns[11].HeaderText = oleDbDataReader["horse4"].ToString();
                    this.Label1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader[2], " VS "), oleDbDataReader[3]), "  "), " ( "), oleDbDataReader[4]), " ) "), oleDbDataReader[1]));
                }
                Module1.conn.Close();
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

        // Token: 0x0600176B RID: 5995 RVA: 0x00272D80 File Offset: 0x00271180
        public void my_Positions()
        {
            try
            {
                Size size = new Size(732, 659);
                this.Size = size;
                int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
                int y = 0; //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600176D RID: 5997 RVA: 0x00272F2C File Offset: 0x0027132C
        public void Decliar_New()
        {
            try
            {
                if (Operators.CompareString(this.TextBox1.Text, null, false) == 0)
                {
                    this.TextBox1.Text= Conversions.ToString(Module1.matchbooklist);
                }
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.Status, MatchTrans.m_id, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_checked, PartyMaster.PartyName FROM (PartyMaster INNER JOIN MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) GROUP BY PartyMaster.SMatchCommi, PartyMaster.SMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.TParty, PartyMaster.TMatch, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.PartyName HAVING MatchTrans.m_checked=0 AND MatchTrans.m_id = " + this.TextBox1.Text + " ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["SMatchCommi"].ToString());
                    double num2 = Convert.ToDouble(oleDbDataReader["SMatch"].ToString());

                    string text = oleDbDataReader["AParty"].ToString();
                    string text2 = oleDbDataReader["TParty"].ToString();

                    double num5 = Convert.ToDouble(oleDbDataReader["Expr1"].ToString());
                    double num6 = Convert.ToDouble(oleDbDataReader["Expr2"].ToString());
                    double num7 = Convert.ToDouble(oleDbDataReader["Expr3"].ToString());
                    double num8 = Convert.ToDouble(oleDbDataReader["Expr4"].ToString());

                    //double num9 = Conversion.Val(num3) + Conversion.Val(num4);

                    //double num10 = Conversion.Val(num5) * Conversion.Val(0) / 100 - Conversion.Val(num5);
                    //double num11 = Conversion.Val(num6) * Conversion.Val(0) / 100 - Conversion.Val(num6);
                    //double num12 = Conversion.Val(num7) * Conversion.Val(0) / 100 - Conversion.Val(num7);
                    //double num13 = Conversion.Val(num8) * Conversion.Val(0) / 100 - Conversion.Val(num8);

                    //double num17 = 0;
                    ////double num20 = 0;
                    //if (num10 < 0.0)
                    //{
                    //	double num14 = Conversion.Val(num10) * Conversion.Val(num) / 100;
                    //	double num15 = Conversion.Val(num10) + Conversion.Val(num14) - Conversion.Val(num14) - Conversion.Val(num14);
                    //	double num16 = Conversion.Val(num15) * Conversion.Val(num2) / 100 - Conversion.Val(num15);
                    //	num17 = num16;
                    //	//double num18 = Conversion.Val(num16) * Conversion.Val(num9) / 100 - Conversion.Val(num16);
                    //	//double num19 = Conversion.Val(num16) * Conversion.Val(num3) / 100;
                    //	//num20 += Convert.ToDouble(Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19));
                    //	//double num21 = 0;
                    //	//num21 += Convert.ToDouble(Conversion.Val(num18) - Conversion.Val(num18) - Conversion.Val(num18));
                    //}
                    //else
                    //{
                    //	double num22 = Conversion.Val(num10) * Conversion.Val(num2) / 100 - Conversion.Val(num10);
                    //	num17 = num22;
                    //	//double num23 = Conversion.Val(num22) * Conversion.Val(num9) / 100 - Conversion.Val(num22);
                    //	//double num24 = Conversion.Val(num23) * Conversion.Val(num3) / 100;
                    //	//num20 += Convert.ToDouble(Conversion.Val(num24) - Conversion.Val(num24) - Conversion.Val(num24));
                    //	//double num21 = 0;
                    //	//num21 += Convert.ToDouble(Conversion.Val(num23) - Conversion.Val(num23) - Conversion.Val(num23));
                    //}
                    //double num28 = 0;
                    ////double num31 = 0;
                    //if (num11 < 0.0)
                    //{
                    //	double num25 = Conversion.Val(num11) * Conversion.Val(num) / 100;
                    //	double num26 = Conversion.Val(num11) + Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25);
                    //	double num27 = Conversion.Val(num26) * Conversion.Val(num2) / 100 - Conversion.Val(num26);
                    //	num28 = num27;
                    //	//double num29 = Conversion.Val(num27) * Conversion.Val(num9) / 100 - Conversion.Val(num27);
                    //	//double num30 = Conversion.Val(num27) * Conversion.Val(num3) / 100;
                    //	//num31 += Convert.ToDouble(Conversion.Val(num30) - Conversion.Val(num30) - Conversion.Val(num30));
                    //	//double num32 = 0;
                    //	//num32 += Convert.ToDouble(Conversion.Val(num29) - Conversion.Val(num29) - Conversion.Val(num29));
                    //}
                    //else
                    //{
                    //	double num33 = Conversion.Val(num11) * Conversion.Val(num2) / 100 - Conversion.Val(num11);
                    //	num28 = num33;
                    //	//double num34 = Conversion.Val(num33) * Conversion.Val(num9) / 100 - Conversion.Val(num33);
                    //	//double num35 = Conversion.Val(num33) * Conversion.Val(num3) / 100;
                    //	//num31 += Convert.ToDouble(Conversion.Val(num35) - Conversion.Val(num35) - Conversion.Val(num35));
                    //	//double num32 = 0;
                    //	//num32 += Convert.ToDouble(Conversion.Val(num34) - Conversion.Val(num34) - Conversion.Val(num34));
                    //}
                    //double num39 = 0;
                    ////double num42 = 0;
                    //if (num12 < 0.0)
                    //{
                    //	double num36 = Conversion.Val(num12) * Conversion.Val(num) / 100;
                    //	double num37 = Conversion.Val(num12) + Conversion.Val(num36) - Conversion.Val(num36) - Conversion.Val(num36);
                    //	double num38 = Conversion.Val(num37) * Conversion.Val(num2) / 100 - Conversion.Val(num37);
                    //	num39 = num38;
                    //	//double num40 = Conversion.Val(num38) * Conversion.Val(num9) / 100 - Conversion.Val(num38);
                    //	//double num41 = Conversion.Val(num38) * Conversion.Val(num3) / 100;
                    //	//num42 += Convert.ToDouble(Conversion.Val(num41) - Conversion.Val(num41) - Conversion.Val(num41));
                    //	//double num43 = 0;
                    //	//num43 += Convert.ToDouble(Conversion.Val(num40) - Conversion.Val(num40) - Conversion.Val(num40));
                    //}
                    //else
                    //{
                    //	double num44 = Conversion.Val(num12) * Conversion.Val(num2) / 100 - Conversion.Val(num12);
                    //	num39 = num44;
                    //	//double num45 = Conversion.Val(num44) * Conversion.Val(num9) / 100 - Conversion.Val(num44);
                    //	//double num46 = Conversion.Val(num44) * Conversion.Val(num3) / 100;
                    //	//num42 += Convert.ToDouble(Conversion.Val(num46) - Conversion.Val(num46) - Conversion.Val(num46));
                    //	//double num43 = 0;
                    //	//num43 += Convert.ToDouble(Conversion.Val(num45) - Conversion.Val(num45) - Conversion.Val(num45));
                    //}
                    //double num50 = 0;
                    ////double num53 = 0;
                    //if (num13 < 0.0)
                    //{
                    //	double num47 = Conversion.Val(num13) * Conversion.Val(num) / 100;
                    //	double num48 = Conversion.Val(num13) + Conversion.Val(num47) - Conversion.Val(num47) - Conversion.Val(num47);
                    //	double num49 = Conversion.Val(num48) * Conversion.Val(num2) / 100 - Conversion.Val(num48);
                    //	//num50 = num49;
                    //	//double num51 = Conversion.Val(num49) * Conversion.Val(num9) / 100 - Conversion.Val(num49);
                    //	//double num52 = Conversion.Val(num49) * Conversion.Val(num3) / 100;
                    //	//num53 += Convert.ToDouble(Conversion.Val(num52) - Conversion.Val(num52) - Conversion.Val(num52));
                    //	//double num54 = 0;
                    //	//num54 += Convert.ToDouble(Conversion.Val(num51) - Conversion.Val(num51) - Conversion.Val(num51));
                    //}
                    //else
                    //{
                    //	double num55 = Conversion.Val(num13) * Conversion.Val(num2) / 100 - Conversion.Val(num13);
                    //	num50 = num55;
                    //	//double num56 = Conversion.Val(num55) * Conversion.Val(num9) / 100 - Conversion.Val(num55);
                    //	//double num57 = Conversion.Val(num55) * Conversion.Val(num3) / 100;
                    //	//num53 += Convert.ToDouble(Conversion.Val(num57) - Conversion.Val(num57) - Conversion.Val(num57));
                    //	//double num54 = 0;
                    //	//num54 += Convert.ToDouble(Conversion.Val(num56) - Conversion.Val(num56) - Conversion.Val(num56));
                    //}

                    string cmdText2 = string.Concat(new string[]
                    {
                        "SELECT m_id, M_chk, m_party FROM MatchTrans WHERE (m_checked = 0) AND (m_id = ",
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
                        //this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
                        //this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num28), this.txtnu.Text);
                        //this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num39), this.txtnu.Text);
                        //this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num50), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                        this.DataGridView1.Rows[index].Cells[5].Value = true;
                        this.DataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LimeGreen;
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        int index2 = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index2].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                        //this.DataGridView1.Rows[index2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
                        //this.DataGridView1.Rows[index2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num28), this.txtnu.Text);
                        //this.DataGridView1.Rows[index2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num39), this.txtnu.Text);
                        //this.DataGridView1.Rows[index2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num50), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                        this.DataGridView1.Rows[index2].Cells[5].Value = false;
                    }
                }

                this.AGENT_TOTAL();
                this.THIRDPARTY_TOTAL();

                checked
                {
                    for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
                    {
                        int num60 = i + 1;
                        int num61 = this.DataGridView1.Rows.Count - 1;
                        int num62 = num60;
                        if (num62 <= num61 && Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, this.DataGridView1.Rows[num62].Cells[0].Value, false))
                        {
                            DataGridViewCell dataGridViewCell;

                            dataGridViewCell = this.DataGridView1.Rows[i].Cells[1];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[num62].Cells[1].Value)));
                            dataGridViewCell.Value = Module1.SetNumFormat(Conversion.Val(dataGridViewCell.Value), this.txtnu.Text);

                            dataGridViewCell = this.DataGridView1.Rows[i].Cells[2];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[num62].Cells[2].Value)));
                            dataGridViewCell.Value = Module1.SetNumFormat(Conversion.Val(dataGridViewCell.Value), this.txtnu.Text);

                            dataGridViewCell = this.DataGridView1.Rows[i].Cells[3];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[num62].Cells[3].Value)));
                            dataGridViewCell.Value = Module1.SetNumFormat(Conversion.Val(dataGridViewCell.Value), this.txtnu.Text);

                            dataGridViewCell = this.DataGridView1.Rows[i].Cells[4];
                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[num62].Cells[4].Value)));
                            dataGridViewCell.Value = Module1.SetNumFormat(Conversion.Val(dataGridViewCell.Value), this.txtnu.Text);

                            this.DataGridView1.Rows.RemoveAt(num62);
                        }
                    }

                    //double num21 = 0;
                    //double num32 = 0;
                    //double num43 = 0;
                    //double num54 = 0;

                    //for (int j = 0; j <= this.DataGridView1.Rows.Count - 1; j++)
                    //{
                    //	unchecked
                    //	{
                    //		if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[j].Cells[0].Value, null, false))
                    //		{
                    //			this.DataGridView1.Rows[j].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[1].Value)), this.txtnu.Text);
                    //			this.DataGridView1.Rows[j].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[2].Value)), this.txtnu.Text);
                    //			this.DataGridView1.Rows[j].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[3].Value)), this.txtnu.Text);
                    //			this.DataGridView1.Rows[j].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[4].Value)), this.txtnu.Text);
                    //			num21 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[1].Value));
                    //			num32 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[2].Value));
                    //			num43 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[3].Value));
                    //			num54 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[j].Cells[4].Value));
                    //		}
                    //	}
                    //}
                    this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows.Add(new object[]
                    {
                        "TOTAL :",
                        Module1.exp1_matchbook_total,
                        Module1.exp2_matchbook_total,
                        Module1.exp3_matchbook_total,
                        Module1.exp4_matchbook_total,
						//Module1.SetNumFormat(Conversion.Val(num21), this.txtnu.Text),
						//Module1.SetNumFormat(Conversion.Val(num32), this.txtnu.Text),
						//Module1.SetNumFormat(Conversion.Val(num43), this.txtnu.Text),
						//Module1.SetNumFormat(Conversion.Val(num54), this.txtnu.Text),
						false
                    });

                    for (int k = 0; k <= this.DataGridView1.Rows.Count - 1; k++)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[k].Cells[0].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[k].Cells[1].Value, 0, false))
                            {
                                this.DataGridView1.Rows[k].Cells[1].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[k].Cells[1].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[k].Cells[2].Value, 0, false))
                            {
                                this.DataGridView1.Rows[k].Cells[2].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[k].Cells[2].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[k].Cells[3].Value, 0, false))
                            {
                                this.DataGridView1.Rows[k].Cells[3].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[k].Cells[3].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[k].Cells[4].Value, 0, false))
                            {
                                this.DataGridView1.Rows[k].Cells[4].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView1.Rows[k].Cells[4].Style.ForeColor = Color.Green;
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
                DataGridView1.ClearSelection();
                Module1.conn.Close();
            }
        }

        // Token: 0x0600176E RID: 5998 RVA: 0x00274754 File Offset: 0x00272B54
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
                        "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4) AS Expr4, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch FROM (PartyMaster INNER JOIN  MatchTrans ON PartyMaster.PartyName = MatchTrans.m_party) WHERE(MatchTrans.m_checked <> 1) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.AMatch, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatch, PartyMaster.TParty, PartyMaster.TMatch HAVING (MatchTrans.m_id = ",
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
                            double num = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num2 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])) - Conversion.Val(num);
                            double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"])) - Conversion.Val(num2);
                            double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"])) - Conversion.Val(num3);
                            double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"])) - Conversion.Val(num4);
                            if (Operators.CompareString(oleDbDataReader2["AParty"].ToString(), text.ToString(), false) == 0)
                            {
                                num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["AMatch"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["AMatch"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["AMatch"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["AMatch"])) / 100);
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

        // Token: 0x0600176F RID: 5999 RVA: 0x00274D60 File Offset: 0x00273160
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
                            double num = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num2 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["SMatch"])) / 100);
                            double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])) - Conversion.Val(num);
                            double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"])) - Conversion.Val(num2);
                            double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"])) - Conversion.Val(num3);
                            double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"])) - Conversion.Val(num4);
                            if (Operators.CompareString(oleDbDataReader2["TParty"].ToString(), text2.ToString(), false) == 0)
                            {
                                num9 += Convert.ToDouble(Conversion.Val(num5) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["TMatch"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(num6) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["TMatch"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(num7) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["TMatch"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(num8) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["TMatch"])) / 100);
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

        // Token: 0x06001770 RID: 6000 RVA: 0x0027536C File Offset: 0x0027376C
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Panel3.Visible)
                {
                    this.Panel3.Visible = false;
                }
                else if (!this.Panel3.Visible)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001771 RID: 6001 RVA: 0x0027539C File Offset: 0x0027379C
        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Panel3.Visible = true;
                this.All_DPP_SHWO();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001772 RID: 6002 RVA: 0x002753EC File Offset: 0x002737EC
        public void All_DPP_SHWO()
        {
            checked
            {
                try
                {
                    this.DataGridView3.Rows.Clear();
                    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT id, m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, Modify, m_checked, M_chk FROM MatchTrans WHERE (m_id = " + this.TextBox1.Text + ") AND (m_party = '", this.DataGridView1.CurrentRow.Cells[0].Value), "') ORDER BY m_eid DESC"));
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        while (oleDbDataReader.Read())
                        {
                            int num = this.DataGridView3.Rows.Add();
                            this.DataGridView3.Rows[num].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                            this.DataGridView3.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[3].Value = oleDbDataReader["m_rate"].ToString();
                            this.DataGridView3.Rows[num].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                            this.DataGridView3.Rows[num].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                            this.DataGridView3.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                            this.DataGridView3.Rows[num].Cells[7].Value = oleDbDataReader["m_dt"].ToString();
                            this.DataGridView3.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);

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
                            }
                            else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Modify"], "1", false))
                            {
                                this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                            }

                            //if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["m_checked"], "1", false))
                            //{
                            //	int num = this.DataGridView3.Rows.Add();
                            //	this.DataGridView3.Rows[num].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                            //	this.DataGridView3.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num].Cells[3].Value = oleDbDataReader["m_rate"].ToString();
                            //	this.DataGridView3.Rows[num].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                            //	this.DataGridView3.Rows[num].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                            //	this.DataGridView3.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                            //	this.DataGridView3.Rows[num].Cells[7].Value = oleDbDataReader["m_dt"].ToString();
                            //	this.DataGridView3.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                            //	double num2 = (double)(num + 1);
                            //}
                            //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                            //{
                            //	int num3 = this.DataGridView3.Rows.Add();
                            //	this.DataGridView3.Rows[num3].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                            //	this.DataGridView3.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num3].Cells[3].Value = oleDbDataReader["m_rate"].ToString();
                            //	this.DataGridView3.Rows[num3].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                            //	this.DataGridView3.Rows[num3].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                            //	this.DataGridView3.Rows[num3].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                            //	this.DataGridView3.Rows[num3].Cells[7].Value = oleDbDataReader["m_dt"].ToString();
                            //	this.DataGridView3.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num3].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num3].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num3].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num3].Cells[0].Value = true;
                            //	this.DataGridView3.Rows[num3].DefaultCellStyle.BackColor = Color.LimeGreen;
                            //	this.DataGridView3.Rows[num3].DefaultCellStyle.ForeColor = Color.White;
                            //	double num2 = (double)(num3 + 1);
                            //}
                            //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Modify"], "1", false))
                            //{
                            //	int num4 = this.DataGridView3.Rows.Add();
                            //	this.DataGridView3.Rows[num4].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                            //	this.DataGridView3.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num4].Cells[3].Value = oleDbDataReader["m_rate"].ToString();
                            //	this.DataGridView3.Rows[num4].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                            //	this.DataGridView3.Rows[num4].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                            //	this.DataGridView3.Rows[num4].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                            //	this.DataGridView3.Rows[num4].Cells[7].Value = oleDbDataReader["m_dt"].ToString();
                            //	this.DataGridView3.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num4].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num4].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num4].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num4].DefaultCellStyle.ForeColor = Color.Blue;
                            //	double num2 = (double)(num4 + 1);
                            //}
                            //else
                            //{
                            //	int num5 = this.DataGridView3.Rows.Add();
                            //	this.DataGridView3.Rows[num5].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                            //	this.DataGridView3.Rows[num5].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num5].Cells[3].Value = oleDbDataReader["m_rate"].ToString();
                            //	this.DataGridView3.Rows[num5].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                            //	this.DataGridView3.Rows[num5].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                            //	this.DataGridView3.Rows[num5].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                            //	this.DataGridView3.Rows[num5].Cells[7].Value = oleDbDataReader["m_dt"].ToString();
                            //	this.DataGridView3.Rows[num5].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num5].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num5].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                            //	this.DataGridView3.Rows[num5].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                            //	double num2 = (double)(num5 + 1);
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
        }

        // Token: 0x06001773 RID: 6003 RVA: 0x00276168 File Offset: 0x00274568
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
        //		Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        // Token: 0x06001774 RID: 6004 RVA: 0x002761F4 File Offset: 0x002745F4
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, true, false))
                    {
                        this.DataGridView3.CurrentRow.Cells[0].Value = false;
                    }
                    else
                    {
                        this.DataGridView3.CurrentRow.Cells[0].Value = true;
                    }
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, true, false))
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = $"UPDATE MatchTrans SET M_chk = 1 WHERE m_id = {this.TextBox1.Text} AND m_eid = {this.DataGridView3.CurrentRow.Cells[1].Value}";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText);
                        }
                        this.DataGridView3.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, false, false))
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = $"UPDATE MatchTrans SET M_chk = 0 WHERE m_id = {this.TextBox1.Text} AND m_eid = {this.DataGridView3.CurrentRow.Cells[1].Value}";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText);
                        }
                        this.DataGridView3.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void MatchBOOKPOPUP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                MyProject.Forms.Match.Activate();
            }
        }

        // Token: 0x040009E1 RID: 2529
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x040009E2 RID: 2530
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;

        // Token: 0x040009E3 RID: 2531
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;

        // Token: 0x040009E4 RID: 2532
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;

        // Token: 0x040009E6 RID: 2534
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;

        // Token: 0x040009E7 RID: 2535
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;

        // Token: 0x040009E8 RID: 2536
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;

        // Token: 0x040009E9 RID: 2537
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;

        // Token: 0x040009EA RID: 2538
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;

        // Token: 0x040009EB RID: 2539
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;

        // Token: 0x040009EC RID: 2540
        [AccessedThroughProperty("Column6")]
        private DataGridViewCheckBoxColumn _Column6;

        // Token: 0x040009ED RID: 2541
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x040009EE RID: 2542
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x040009EF RID: 2543
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;

        // Token: 0x040009F0 RID: 2544
        [AccessedThroughProperty("DataGridView3")]
        private DataGridView _DataGridView3;

        // Token: 0x040009F1 RID: 2545
        [AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
        private DataGridViewCheckBoxColumn _DataGridViewCheckBoxColumn1;

        // Token: 0x040009F2 RID: 2546
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

        // Token: 0x040009F3 RID: 2547
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;

        // Token: 0x040009F4 RID: 2548
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;

        // Token: 0x040009F5 RID: 2549
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;

        // Token: 0x040009F6 RID: 2550
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;

        // Token: 0x040009F7 RID: 2551
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;

        // Token: 0x040009F8 RID: 2552
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;

        // Token: 0x040009F9 RID: 2553
        [AccessedThroughProperty("Column15")]
        private DataGridViewTextBoxColumn _Column15;

        // Token: 0x040009FA RID: 2554
        [AccessedThroughProperty("Column16")]
        private DataGridViewTextBoxColumn _Column16;

        // Token: 0x040009FB RID: 2555
        [AccessedThroughProperty("Column17")]
        private DataGridViewTextBoxColumn _Column17;

        // Token: 0x040009FC RID: 2556
        [AccessedThroughProperty("Column19")]
        private DataGridViewTextBoxColumn _Column19;

        // Token: 0x040009FD RID: 2557
        private TextBox txtnu;

        // Token: 0x040009FE RID: 2558
        //public TextBox txtmodify;
    }
}
