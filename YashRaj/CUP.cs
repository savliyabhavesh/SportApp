using System;
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
    // Token: 0x02000011 RID: 17
    //[DesignerGenerated]

    public partial class CUP : Form
    {
        public bool ismodify = false;
        // Token: 0x060004D4 RID: 1236 RVA: 0x002A9BD4 File Offset: 0x002A7FD4
        public CUP()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000633 RID: 1587 RVA: 0x002B1840 File Offset: 0x002AFC40
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000634 RID: 1588 RVA: 0x002B199C File Offset: 0x002AFD9C
        private void CUP_Activated(object sender, EventArgs e)
        {
            try
            {
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
        }
        // Token: 0x06000635 RID: 1589 RVA: 0x002B19AC File Offset: 0x002AFDAC
        private void CUP_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.txtid.Text = Conversions.ToString(Module1.IDCUP);
                this.txtnu.Text = Module1.decimalnumberformat;

                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(113, 27);
                    txtrate.Location = new Point(5, 27);

                    Label12.Text = "Amount";
                    Label11.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.DATAGRID_LODE();
                this.all_CUP_Lode();
                this.datagrid2();
                this.lod_newPartyname();

                this.lod_gridallEntry();
                this.srno_cup();
                this.Button11.Hide();
                this.Button13.Hide();
                this.Decleard();
                this.Regular_all_Tems();
                this.Regular_Total_Tems();
                this.Booky_all_Tems();
                this.Booky_Total_Tems();
                this.Net_Position();
                this.set_color();

                this.DataGridView2.Columns[1].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[2].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[3].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[4].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[5].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[6].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[7].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[8].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[9].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[10].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[11].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[12].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[13].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[14].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView2.Columns[15].DefaultCellStyle.Format = Module1.NumFormat;

                this.DataGridView2.ClearSelection();

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000636 RID: 1590 RVA: 0x002B1D68 File Offset: 0x002B0168
        public void Net_Position()
        {
            checked
            {
                try
                {
                    int num = 1;
                    do
                    {
                        if (Module1.isntposition == true)
                        {
                            this.DataGridView2.Rows[0].Cells[num].Value = null;
                            num++;
                        }
                        else
                        {
                            this.DataGridView2.Rows[3].Cells[num].Value = null;
                            num++;
                        }
                    }
                    while (num <= 15);

                    double num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0, num12 = 0, num13 = 0, num14 = 0, num15 = 0, num16 = 0, num17 = 0, num18 = 0;

                    for (int i = 0; i <= this.DataGridView2.RowCount - 1; i++)
                    {
                        unchecked
                        {
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[1].Value));
                            num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[2].Value));
                            num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[3].Value));
                            num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[4].Value));
                            num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[5].Value));
                            num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[6].Value));
                            num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[7].Value));
                            num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[8].Value));
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[9].Value));
                            num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[10].Value));
                            num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[11].Value));
                            num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[12].Value));
                            num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[13].Value));
                            num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[14].Value));
                            num18 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[i].Cells[15].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[0].Cells[1].Value = num4;
                        this.DataGridView2.Rows[0].Cells[2].Value = num5;
                        this.DataGridView2.Rows[0].Cells[3].Value = num6;
                        this.DataGridView2.Rows[0].Cells[4].Value = num7;
                        this.DataGridView2.Rows[0].Cells[5].Value = num8;
                        this.DataGridView2.Rows[0].Cells[6].Value = num9;
                        this.DataGridView2.Rows[0].Cells[7].Value = num10;
                        this.DataGridView2.Rows[0].Cells[8].Value = num11;
                        this.DataGridView2.Rows[0].Cells[9].Value = num12;
                        this.DataGridView2.Rows[0].Cells[10].Value = num13;
                        this.DataGridView2.Rows[0].Cells[11].Value = num14;
                        this.DataGridView2.Rows[0].Cells[12].Value = num15;
                        this.DataGridView2.Rows[0].Cells[13].Value = num16;
                        this.DataGridView2.Rows[0].Cells[14].Value = num17;
                        this.DataGridView2.Rows[0].Cells[15].Value = num18;
                    }
                    else
                    {
                        this.DataGridView2.Rows[3].Cells[1].Value = num4;
                        this.DataGridView2.Rows[3].Cells[2].Value = num5;
                        this.DataGridView2.Rows[3].Cells[3].Value = num6;
                        this.DataGridView2.Rows[3].Cells[4].Value = num7;
                        this.DataGridView2.Rows[3].Cells[5].Value = num8;
                        this.DataGridView2.Rows[3].Cells[6].Value = num9;
                        this.DataGridView2.Rows[3].Cells[7].Value = num10;
                        this.DataGridView2.Rows[3].Cells[8].Value = num11;
                        this.DataGridView2.Rows[3].Cells[9].Value = num12;
                        this.DataGridView2.Rows[3].Cells[10].Value = num13;
                        this.DataGridView2.Rows[3].Cells[11].Value = num14;
                        this.DataGridView2.Rows[3].Cells[12].Value = num15;
                        this.DataGridView2.Rows[3].Cells[13].Value = num16;
                        this.DataGridView2.Rows[3].Cells[14].Value = num17;
                        this.DataGridView2.Rows[3].Cells[15].Value = num18;
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000638 RID: 1592 RVA: 0x002B23E8 File Offset: 0x002B07E8
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT m_id, m_checked FROM(CupTrans) WHERE (m_checked = 0) AND (m_id = " + Conversions.ToString(Module1.IDCUP) + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    string cmdText2 = "SELECT m_id, COUNT(m_team) AS Expr1, M_Tem_Out, m_checked FROM(CupTrans) GROUP BY m_id, M_Tem_Out, m_checked HAVING (m_id = " + Conversions.ToString(Module1.IDCUP) + ") AND (M_Tem_Out = 0) AND (m_checked = 0)";
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    if (oleDbDataReader2.Read())
                    {
                        this.Button5.Enabled = true;
                        this.Button7.Enabled = true;
                        this.btnOK.Enabled = true;
                        this.txtpartiname.Enabled = true;
                    }
                    else
                    {
                        this.Button5.Enabled = false;
                        this.Button7.Enabled = false;
                        this.btnOK.Enabled = false;
                        this.txtpartiname.Enabled = false;
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

        // Token: 0x06000639 RID: 1593 RVA: 0x002B2510 File Offset: 0x002B0910
        public void lod_gridallEntry()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView1.Rows.Clear();
                string cmdText = "Select * from CupTrans where m_id=" + this.txtid.Text + " ORDER BY m_eid DESC";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int num = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[num].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
                    if (Module1.isratefirst == true)
                    {
                        this.DataGridView1.Columns[2].HeaderText = "Amount";
                        this.DataGridView1.Rows[num].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text); //Strings.Format(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), "0.0000");
                        this.DataGridView1.Columns[1].HeaderText = "Rate";
                        this.DataGridView1.Rows[num].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    }
                    else
                    {
                        this.DataGridView1.Rows[num].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text); //Strings.Format(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), "0.0000");
                        this.DataGridView1.Rows[num].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    }

                    this.DataGridView1.Rows[num].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    this.DataGridView1.Rows[num].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    this.DataGridView1.Rows[num].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
                    this.DataGridView1.Rows[num].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[11]), this.txtnu.Text);
                    this.DataGridView1.Rows[num].Cells[7].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[12], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[8].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[13], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[9].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[14]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[14], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[10].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[15]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[15], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[11].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[16]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[16], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[12].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[17]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[17], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[13].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[18]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[18], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[14].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[19]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[19], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[15].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[20]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[20], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[16].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[21]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[21], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[17].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[22]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[22], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[18].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[23]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[23], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[19].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[24]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[24], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[20].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[25]), this.txtnu.Text); //Module1.SetNumFormat(Operators.ConcatenateObject(oleDbDataReader[25], this.txtnu.Text), "");
                    this.DataGridView1.Rows[num].Cells[21].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"]), DateFormat.LongTime);
                    this.DataGridView1.Rows[num].Cells[22].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
                    this.DataGridView1.Rows[num].Cells[23].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_dt"]), DateFormat.ShortDate);
                    this.DataGridView1.Rows[num].Cells[24].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["modify_time"]);
                    this.DataGridView1.Rows[num].Cells[25].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["modify_date"]);

                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["m_checked"], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                        //this.DataGridView1.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.LimeGreen;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["m_modify"], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["m_Tem_Out"], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Fuchsia;
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
                Module1.conn.Close();
            }
        }

        // Token: 0x0600063A RID: 1594 RVA: 0x002B42A0 File Offset: 0x002B26A0
        public void lod_newPartyname()
        {
            try
            {
                this.DataGridView4.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.txtpartiname.Items.Clear();
                string cmdText = "Select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "1", false))
                    {
                        //if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "2", false))
                        //{
                        //	if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "3", false))
                        //	{
                        //this.ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                        int index = this.DataGridView4.Rows.Add();
                        this.DataGridView4.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        this.txtpartiname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                        this.cmbostus.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"]));
                        if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), "", false) != 0)
                        {
                            this.ComboBox2.Items.Add(oleDbDataReader["AParty"].ToString());
                            this.ComboBox3.Items.Add(oleDbDataReader["AParty"].ToString());
                        }
                        if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), "", false) != 0)
                        {
                            this.ComboBox2.Items.Add(oleDbDataReader["TParty"].ToString());
                            this.ComboBox3.Items.Add(oleDbDataReader["TParty"].ToString());
                        }
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

        // Token: 0x0600063B RID: 1595 RVA: 0x002B456C File Offset: 0x002B296C
        public void DATAGRID_LODE()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                if (Module1.isntposition == true)
                {
                    this.DataGridView2.Rows.Add(new object[]
                    {
                "Net Total"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                ""
                    });
                    this.DataGridView2.Rows.Add(new object[]
                {
                "Regular"
                });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                "Booky"
                    });

                    this.DataGridView2.Rows[1].Height = 5;
                    this.DataGridView2.Rows[1].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    this.DataGridView2.Rows.Add(new object[]
                {
                "Regular"
                });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                "Booky"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                ""
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                "Net Total"
                    });

                    this.DataGridView2.Rows[2].Height = 5;
                    this.DataGridView2.Rows[2].DefaultCellStyle.BackColor = Color.Gray;
                }

                this.DataGridView3.Rows.Add(new object[]
                {
                ""
                });
                this.DataGridView3.Rows.Add(new object[]
                {
                ""
                });
                if (Module1.isntposition == true)
                {
                    this.DataGridView2.Rows[0].Cells[1].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[2].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[3].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[4].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[5].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[6].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[7].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[8].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[9].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[10].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[11].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[12].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[13].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[14].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[15].Value = "" + this.txtnu.Text;

                    this.DataGridView2.Rows[3].Cells[1].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[2].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[3].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[4].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[5].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[6].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[7].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[8].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[9].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[10].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[11].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[12].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[13].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[14].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[15].Value = "" + this.txtnu.Text;

                    this.DataGridView2.Rows[2].Cells[1].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[2].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[3].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[4].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[5].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[6].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[7].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[8].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[9].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[10].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[11].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[12].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[13].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[14].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[2].Cells[15].Value = "" + this.txtnu.Text;
                }
                else
                {
                    this.DataGridView2.Rows[3].Cells[1].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[2].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[3].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[4].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[5].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[6].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[7].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[8].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[9].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[10].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[11].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[12].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[13].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[14].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[3].Cells[15].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[1].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[2].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[3].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[4].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[5].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[6].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[7].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[8].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[9].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[10].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[11].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[12].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[13].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[14].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[0].Cells[15].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[1].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[2].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[3].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[4].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[5].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[6].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[7].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[8].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[9].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[10].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[11].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[12].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[13].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[14].Value = "" + this.txtnu.Text;
                    this.DataGridView2.Rows[1].Cells[15].Value = "" + this.txtnu.Text;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }

        }

        // Token: 0x0600063C RID: 1596 RVA: 0x002B5304 File Offset: 0x002B3704
        private void btnmatchreport_Click(object sender, EventArgs e)
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

        // Token: 0x0600063D RID: 1597 RVA: 0x002B5330 File Offset: 0x002B3730
        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                New_Party new_Party = new New_Party();
                new_Party.MdiParent = this.MdiParent;
                new_Party.WindowState = FormWindowState.Maximized;
                new_Party.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600063E RID: 1598 RVA: 0x002B5358 File Offset: 0x002B3758
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                this.DataGridView2.Rows.Clear();
                this.CUP_Load(RuntimeHelpers.GetObjectValue(sender), e);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600063F RID: 1599 RVA: 0x002B5388 File Offset: 0x002B3788
        private void Button8_Click(object sender, EventArgs e)
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

        // Token: 0x06000640 RID: 1600 RVA: 0x002B53B4 File Offset: 0x002B37B4
        private void CUP_KeyDown(object sender, KeyEventArgs e)
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

        // Token: 0x06000641 RID: 1601 RVA: 0x002B53C8 File Offset: 0x002B37C8
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
                    string cmdText = "Select * from Newmatch where Sr_No=" + this.txtid.Text + "";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        this.Label3.Text = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader[1].ToString()), DateFormat.ShortDate);
                        object right = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader[1].ToString()), DateFormat.ShortDate);
                        object left = oleDbDataReader[4].ToString();
                        object right2 = oleDbDataReader[5].ToString();
                        object right3 = oleDbDataReader[6].ToString();
                        this.DataGridView2.Columns[1].HeaderText = oleDbDataReader[5].ToString();
                        this.DataGridView2.Columns[2].HeaderText = oleDbDataReader[6].ToString();
                        this.DataGridView2.Columns[3].HeaderText = oleDbDataReader[7].ToString();
                        this.DataGridView2.Columns[4].HeaderText = oleDbDataReader[8].ToString();
                        this.DataGridView2.Columns[5].HeaderText = oleDbDataReader[9].ToString();
                        this.DataGridView2.Columns[6].HeaderText = oleDbDataReader[10].ToString();
                        this.DataGridView2.Columns[7].HeaderText = oleDbDataReader[11].ToString();
                        this.DataGridView2.Columns[8].HeaderText = oleDbDataReader[12].ToString();
                        this.DataGridView2.Columns[9].HeaderText = oleDbDataReader[13].ToString();
                        this.DataGridView2.Columns[10].HeaderText = oleDbDataReader[14].ToString();
                        this.DataGridView2.Columns[11].HeaderText = oleDbDataReader[15].ToString();
                        this.DataGridView2.Columns[12].HeaderText = oleDbDataReader[16].ToString();
                        this.DataGridView2.Columns[13].HeaderText = oleDbDataReader[17].ToString();
                        this.DataGridView2.Columns[14].HeaderText = oleDbDataReader[18].ToString();
                        this.DataGridView2.Columns[15].HeaderText = oleDbDataReader[19].ToString();
                        //this.DataGridView8.Columns[0].HeaderText = oleDbDataReader[5].ToString();
                        //this.DataGridView8.Columns[1].HeaderText = oleDbDataReader[6].ToString();
                        //this.DataGridView8.Columns[2].HeaderText = oleDbDataReader[7].ToString();
                        //this.DataGridView8.Columns[3].HeaderText = oleDbDataReader[8].ToString();
                        //this.DataGridView8.Columns[4].HeaderText = oleDbDataReader[9].ToString();
                        //this.DataGridView8.Columns[5].HeaderText = oleDbDataReader[10].ToString();
                        //this.DataGridView8.Columns[6].HeaderText = oleDbDataReader[11].ToString();
                        //this.DataGridView8.Columns[7].HeaderText = oleDbDataReader[12].ToString();
                        //this.DataGridView8.Columns[8].HeaderText = oleDbDataReader[13].ToString();
                        //this.DataGridView8.Columns[9].HeaderText = oleDbDataReader[14].ToString();
                        //this.DataGridView8.Columns[10].HeaderText = oleDbDataReader[15].ToString();
                        //this.DataGridView8.Columns[11].HeaderText = oleDbDataReader[16].ToString();
                        //this.DataGridView8.Columns[12].HeaderText = oleDbDataReader[17].ToString();
                        //this.DataGridView8.Columns[13].HeaderText = oleDbDataReader[18].ToString();
                        //this.DataGridView8.Columns[14].HeaderText = oleDbDataReader[19].ToString();
                        this.Label1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(left, "     "), right2), "   "), "VS"), "   "), right3), "    "), right));
                    }
                    int num = 1;
                    do
                    {
                        if (Operators.CompareString(this.DataGridView2.Columns[num].HeaderText, "", false) == 0)
                        {
                            this.DataGridView2.Columns[num].Visible = false;
                        }
                        else
                        {
                            this.DataGridView2.Columns[num].Visible = true;
                        }
                        num++;
                    }
                    while (num <= 15);
                    //int num2 = 0;
                    //do
                    //{
                    //	if (Operators.CompareString(this.DataGridView8.Columns[num2].HeaderText, "", false) == 0)
                    //	{
                    //		this.DataGridView8.Columns[num2].Visible = false;
                    //	}
                    //	else
                    //	{
                    //		this.DataGridView8.Columns[num2].Visible = true;
                    //	}
                    //	num2++;
                    //}
                    //while (num2 <= 14);
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

        // Token: 0x06000642 RID: 1602 RVA: 0x002B5A24 File Offset: 0x002B3E24
        public void datagrid2()
        {
            try
            {
                this.DataGridView1.Columns[6].HeaderText = this.DataGridView2.Columns[1].HeaderText;
                this.txtteam.Items.Add(this.DataGridView2.Columns[1].HeaderText);
                this.DataGridView1.Columns[7].HeaderText = this.DataGridView2.Columns[2].HeaderText;
                this.txtteam.Items.Add(this.DataGridView2.Columns[2].HeaderText);
                if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[8].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[8].HeaderText = this.DataGridView2.Columns[3].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[3].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[9].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[9].HeaderText = this.DataGridView2.Columns[4].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[4].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[5].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[10].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[10].HeaderText = this.DataGridView2.Columns[5].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[5].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[6].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[11].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[11].HeaderText = this.DataGridView2.Columns[6].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[6].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[7].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[12].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[12].HeaderText = this.DataGridView2.Columns[7].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[7].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[8].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[13].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[13].HeaderText = this.DataGridView2.Columns[8].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[8].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[9].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[14].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[14].HeaderText = this.DataGridView2.Columns[9].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[9].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[10].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[15].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[15].HeaderText = this.DataGridView2.Columns[10].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[10].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[11].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[16].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[16].HeaderText = this.DataGridView2.Columns[11].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[11].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[12].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[17].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[17].HeaderText = this.DataGridView2.Columns[12].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[12].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[13].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[18].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[18].HeaderText = this.DataGridView2.Columns[13].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[13].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[14].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[19].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[19].HeaderText = this.DataGridView2.Columns[14].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[14].HeaderText);
                }
                if (Operators.CompareString(this.DataGridView2.Columns[15].HeaderText, "", false) == 0)
                {
                    this.DataGridView1.Columns[20].Visible = false;
                }
                else
                {
                    this.DataGridView1.Columns[20].HeaderText = this.DataGridView2.Columns[15].HeaderText;
                    this.txtteam.Items.Add(this.DataGridView2.Columns[15].HeaderText);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000643 RID: 1603 RVA: 0x002B628C File Offset: 0x002B468C
        public void srno_cup()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(m_eid) from CupTrans where m_id=" + this.txtid.Text;
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.srid = Conversions.ToInteger("1");
                    }
                    else
                    {
                        this.srid = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        this.srid++;
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

        // Token: 0x06000644 RID: 1604 RVA: 0x002B635C File Offset: 0x002B475C
        private void btnK_L_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Convert.ToDouble(this.txtamount.Text) * Convert.ToDouble(this.txtrate.Text));
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text));
                    this.txtL.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Convert.ToDouble(this.txtamount.Text) * Convert.ToDouble(this.txtrate.Text));
                    this.txtL.Text = this.txtamount.Text;
                    this.txtL.Text = Conversions.ToString(Conversion.Val(this.txtL.Text) - Conversion.Val(this.txtL.Text) - Conversion.Val(this.txtL.Text));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000645 RID: 1605 RVA: 0x002B64F4 File Offset: 0x002B48F4
        private void txtmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnK_L_Click(RuntimeHelpers.GetObjectValue(sender), e);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000647 RID: 1607 RVA: 0x002B6508 File Offset: 0x002B4908
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                int index = this.DataGridView1.Rows.Add();
                this.DataGridView1.Rows[index].Cells[0].Value = this.srid;
                this.DataGridView1.Rows[index].Cells[1].Value = this.txtamount.Text;
                this.DataGridView1.Rows[index].Cells[2].Value = this.txtrate.Text;
                this.DataGridView1.Rows[index].Cells[3].Value = this.txtteam.Text;
                this.DataGridView1.Rows[index].Cells[4].Value = this.txtmode.Text;
                this.DataGridView1.Rows[index].Cells[5].Value = this.txtpartiname.Text;
                if (Operators.CompareString(this.DataGridView1.Columns[6].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtK.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[7].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtK.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtK.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtL.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.DataGridView1.Rows[index].Cells[6].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[7].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[8].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[9].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[10].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[11].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[12].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[13].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[14].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[15].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[16].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[17].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[18].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[19].Value = this.txtL.Text;
                    this.DataGridView1.Rows[index].Cells[20].Value = this.txtK.Text;
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtK.Text;
                    }
                }
                this.DataGridView1.Rows[index].Cells[21].Value = this.txttime.Text;
                this.DataGridView1.Rows[index].Cells[22].Value = this.txtpage.Text;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000648 RID: 1608 RVA: 0x002BC600 File Offset: 0x002BAA00
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Label3.Text = Conversions.ToString(DateTime.Now.Date);
                this.srno_cup();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO CupTrans(m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, m_team5, m_team6, m_team7, m_team8, m_team9, m_team10, m_team11, m_team12, m_team13, m_team14, m_team15, m_modify, m_dt1, m_checked, m_s_share, Stus, M_Tem_Out, M_chk) VALUES(" + this.txtid.Text + "," + Conversions.ToString(this.srid) + ",'" + this.txtpage.Text + "'," + this.txtamount.Text + ",'" + this.txtrate.Text + "','" + this.txtteam.Text + "','" + this.txtmode.Text + "','" + this.txtpartiname.Text + "','" + this.Label3.Text + "','" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "','", this.h1), "','"), this.h2), "','"), this.h3), "','"), this.h4), "','"), this.h5), "','"), this.h6), "','"), this.h7), "','"), this.h8), "','"), this.h9), "','"), this.h10), "','"), this.h11), "','"), this.h12), "','"), this.h13), "','"), this.h14), "','"), this.h15), "',0,'"), this.txttime.Text), "',0,'0','"), this.cmbostus.Text), "',0,0)"));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                oleDbCommand.ExecuteNonQuery();
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

        // Token: 0x06000649 RID: 1609 RVA: 0x002BC934 File Offset: 0x002BAD34
        public void save_databesh()
        {
            try
            {
                int index = this.DataGridView1.Rows.Add();
                if (Operators.CompareString(this.DataGridView1.Columns[6].HeaderText, "", false) == 0)
                {
                    this.h1 = "";
                }
                else
                {
                    this.h1 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
                }
                if (Operators.CompareString(this.DataGridView1.Columns[7].HeaderText, "", false) == 0)
                {
                    this.h2 = "";
                }
                else
                {
                    this.h2 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value);
                }
                if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                {
                    this.h3 = "";
                }
                else
                {
                    this.h3 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
                }
                this.h4 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[9].Value);
                this.h5 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[10].Value);
                this.h6 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[11].Value);
                this.h7 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[12].Value);
                this.h8 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[13].Value);
                this.h9 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[14].Value);
                this.h10 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[15].Value);
                this.h11 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[16].Value);
                this.h12 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[17].Value);
                this.h13 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[18].Value);
                this.h14 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[19].Value);
                this.h15 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[20].Value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600064A RID: 1610 RVA: 0x002BCC88 File Offset: 0x002BB088
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                    this.txtamount.Focus();
                }
                else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                    this.txtrate.Focus();
                }
                else if (Operators.CompareString(this.txtteam.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Team information?", MsgBoxStyle.OkOnly, null);
                    this.txtteam.Focus();
                }
                else if (Operators.CompareString(this.txtmode.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Mode information?", MsgBoxStyle.OkOnly, null);
                    this.txtmode.Focus();
                }
                else if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Party Name information?", MsgBoxStyle.OkOnly, null);
                    this.txtpartiname.Focus();
                }
                else if (Operators.CompareString(this.txtpartiname.Text, null, false) != 0)
                {
                    this.txttime.Text = Conversions.ToString(DateAndTime.Now);
                    this.btnK_L_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.btnsave_Click(RuntimeHelpers.GetObjectValue(sender), e);

                    this.lod_gridallEntry();
                    //this.Net_Position();
                    //this.Regular_Position();
                    //this.Booky_Position();
                    this.Regular_all_Tems();
                    this.Regular_Total_Tems();
                    this.Booky_all_Tems();
                    this.Booky_Total_Tems();
                    this.Net_Position();
                    this.set_color();

                    this.modifyid = 0;
                    this.txtrate.Text = "";
                    this.txtamount.Text = "";
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
            }
        }

        // Token: 0x0600064C RID: 1612 RVA: 0x002BE670 File Offset: 0x002BCA70
        private void set_color()
        {
            try
            {
                for (int i = 0; i <= this.DataGridView2.RowCount - 1; i++)
                {
                    for (int j = 1; j <= this.DataGridView2.ColumnCount - 1; j++)
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[j].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[j].Style.ForeColor = Color.Green;
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

        private void txtpartiname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtpartiname = this.txtpartiname;
                this.AutoComplete(ref txtpartiname, e, false);
                this.txtpartiname = txtpartiname;

                Module1.TotalAmount = 0.0;
                Module1.CustBalance = 0.0;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyName, SCup, ACup, TCup FROM PartyMaster WHERE (PartyName = '" + this.txtpartiname.Text + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                Module1.TotalAmount = 0.0;
                if (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(Operators.AddObject(Operators.AddObject(oleDbDataReader["SCup"], oleDbDataReader["ACup"]), oleDbDataReader["TCup"]));
                    if (Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                    {
                        double num2 = Convert.ToDouble(this.txtamount.Text) * Convert.ToDouble(this.txtrate.Text);
                        double num3 = num2 * 0.0 / 100;
                        double num4 = num2 - num3;
                        double num5 = num4 * num / 100;
                        double value = num4 - num5;
                        Module1.TotalAmount += Convert.ToDouble(value);
                    }
                    else if (Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                    {
                        double num6 = Convert.ToDouble(this.txtamount.Text);
                        double num7 = num6 * 0.0 / 100;
                        double num8 = num6 - num7;
                        double num9 = num8 * num / 100;
                        double value2 = num8 - num9;
                        Module1.TotalAmount += Convert.ToDouble(value2);
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


        // Token: 0x06000655 RID: 1621 RVA: 0x002C5BFC File Offset: 0x002C3FFC

        public void Hide_all_textbox()
        {
            try
            {
                this.txtid.Hide();
                this.cmbostus.Hide();
                this.txtL.Hide();
                this.txtK.Hide();
                this.Label8.Hide();
                this.Label6.Hide();
                this.txttime.Hide();
                this.txtdate.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000656 RID: 1622 RVA: 0x002C5CA4 File Offset: 0x002C40A4
        private void btndpp_Click(object sender, EventArgs e)
        {
            try
            {
                DPP_CUP dPP_CUP = new DPP_CUP();
                dPP_CUP.MdiParent = this.MdiParent;
                dPP_CUP.WindowState = FormWindowState.Maximized;
                dPP_CUP.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000657 RID: 1623 RVA: 0x002C5CE0 File Offset: 0x002C40E0
        private void btnagent_Click(object sender, EventArgs e)
        {
            try
            {
                Agent_CUP agent_CUP = new Agent_CUP();
                agent_CUP.MdiParent = this.MdiParent;
                agent_CUP.WindowState = FormWindowState.Maximized;
                agent_CUP.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //// Token: 0x0600065A RID: 1626 RVA: 0x002C724C File Offset: 0x002C564C
        //private void Timer1_Tick(object sender, EventArgs e)
        //{
        //	this.Timer1.Enabled = true;
        //	checked
        //	{
        //		if (this.ComboBox1.SelectedIndex < this.ComboBox1.Items.Count - 1)
        //		{
        //			this.ComboBox1.SelectedIndex = this.ComboBox1.SelectedIndex + 1;
        //		}
        //		else
        //		{
        //			this.Timer1.Enabled = false;
        //			this.Total_cup();
        //			this.btncolor_Click(RuntimeHelpers.GetObjectValue(sender), e);
        //		}
        //	}
        //}

        // Token: 0x0600065B RID: 1627 RVA: 0x002C72C0 File Offset: 0x002C56C0
        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                MyProject.Forms.DPP_CUP.MdiParent = this.MdiParent;
                MyProject.Forms.DPP_CUP.WindowState = FormWindowState.Maximized;
                MyProject.Forms.DPP_CUP.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600065C RID: 1628 RVA: 0x002C7330 File Offset: 0x002C5730
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {

                this.modifyid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                if (this.modifyid != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "Select * from CupTrans where m_id=",
                        this.txtid.Text,
                        " and m_eid= ",
                        Conversions.ToString(this.modifyid),
                        " and m_checked=1 "
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Cannot edit this record?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = string.Concat(new string[]
                        {
                            "Select * from CupTrans  where  m_id=",
                            this.txtid.Text,
                            " and m_eid= ",
                            Conversions.ToString(this.modifyid),
                            " and m_checked=0"
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        if (oleDbDataReader2.Read())
                        {
                            this.ismodify = true;
                            this.srid = Conversions.ToInteger(oleDbDataReader2[2]);
                            this.modifyid = Conversions.ToInteger(oleDbDataReader2[2]);
                            this.txtpage.Text = Conversions.ToString(oleDbDataReader2[3]);
                            this.txtamount.Text = Conversions.ToString(oleDbDataReader2[4]);
                            this.txtrate.Text = Conversions.ToString(oleDbDataReader2[5]);
                            this.txtteam.Text = Conversions.ToString(oleDbDataReader2[6]);
                            this.txtmode.Text = Conversions.ToString(oleDbDataReader2[7]);
                            this.txtpartiname.Text = Conversions.ToString(oleDbDataReader2[8]);
                            this.cmbostus.Text = Conversions.ToString(oleDbDataReader2["Stus"]);
                            this.txttime.Text = Conversions.ToString(oleDbDataReader2["m_time"]);
                            this.Button11.Show();
                            this.Button13.Show();
                            this.btnOK.Hide();
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

        // Token: 0x0600065D RID: 1629 RVA: 0x002C75D8 File Offset: 0x002C59D8
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = string.Concat(new string[]
                {
                    "select n.Team1,n.Name,n.Type,left(n.Date1,10) as Date1,n.Sr_No,c.m_eid,c.m_amt,c.m_rate,c.m_team,c.m_mode,c.m_party from Newmatch n,CupTrans c where n.Sr_No=",
                    Conversions.ToString(Module1.IDCUP),
                    " and c.m_id=",
                    Conversions.ToString(Module1.IDCUP),
                    "  and m_checked=0"
                });
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);

                //Add RPT
                //Cupreport cupreport = new Cupreport();
                //cupreport.SetDataSource(dataTable);
                //cupreport.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\Cupreport.rpt");
                reportDocument.SetDataSource(dataTable);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();
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

        // Token: 0x0600065E RID: 1630 RVA: 0x002C76C4 File Offset: 0x002C5AC4
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                {
                    Module1.name1 = RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[5].Value);
                    this.modifyid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600065F RID: 1631 RVA: 0x002C7770 File Offset: 0x002C5B70
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtpartiname.Text, null, false) != 0)
                {
                    string cmdText = $"delete from CupTrans where m_id={ this.txtid.Text } and m_eid={ Conversions.ToString(this.modifyid)}";
                    using (CupService cupService = new CupService())
                    {
                        cupService.Update(cmdText);
                    }

                    this.txttime.Text = Conversions.ToString(DateAndTime.TimeOfDay);
                    this.btnK_L_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);

                    string cmdText2 = $"INSERT INTO CupTrans(m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, m_team5, m_team6, m_team7, m_team8, m_team9, m_team10, m_team11, m_team12, m_team13, m_team14, m_team15, m_modify, m_dt1, m_checked, m_s_share, Stus, M_Tem_Out, M_chk,modify_date,modify_time) VALUES({this.txtid.Text},{Conversions.ToString(this.srid)},'{this.txtpage.Text}',{this.txtamount.Text},{this.txtrate.Text},'{this.txtteam.Text}','{this.txtmode.Text}','{this.txtpartiname.Text}','{this.Label3.Text}','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}','{this.h1}','{this.h2}','{this.h3}','{this.h4}','{this.h5}','{this.h6}','{this.h7}','{this.h8}','{this.h9}','{this.h10}','{this.h11}','{this.h12}','{this.h13}','{this.h14}','{this.h15}',1,'{this.txttime.Text}',0,'0','{this.cmbostus.Text}',0,0,'{Conversions.ToString(DateAndTime.Now.Date)}','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                    using (CupService cupService1 = new CupService())
                    {
                        cupService1.Update(cmdText2);
                    }
                    this.btnRefresh_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.lod_gridallEntry();
                    this.btnOK.Show();
                    this.Button11.Hide();
                    this.Button13.Hide();
                    this.Regular_all_Tems();
                    this.Regular_Total_Tems();
                    this.Booky_all_Tems();
                    this.Booky_Total_Tems();
                    this.Net_Position();
                    this.set_color();

                    this.ismodify = false;
                    this.modifyid = 0;
                    this.txtrate.Text = "";
                    this.txtamount.Text = "";
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
                this.ismodify = false;
            }
        }

        // Token: 0x06000660 RID: 1632 RVA: 0x002C7BE8 File Offset: 0x002C5FE8
        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnOK.Show();
                this.Button11.Hide();
                this.Button13.Hide();
                //this.Panel2.BackColor = Color.Transparent;

                this.ismodify = false;
                this.modifyid = 0;
                this.txtrate.Text = "";
                this.txtamount.Text = "";
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
            //this.txtmodifycup.Text = null;
        }

        // Token: 0x06000661 RID: 1633 RVA: 0x002C7C34 File Offset: 0x002C6034
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    this.modifyid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                    if (this.modifyid != 0)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = string.Concat(new string[]
                        {
                        "Select * from CupTrans  where  m_id=",
                        this.txtid.Text,
                        " and m_eid= ",
                        Conversions.ToString(this.modifyid),
                        " and m_checked=1"
                        });
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            Interaction.MsgBox("Can not delete this record?", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[5].Value);
                            this.modifyid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                            if (Operators.ConditionalCompareObjectEqual(objectValue, null, false))
                            {
                                Interaction.MsgBox("Select Record than Delete?", MsgBoxStyle.OkOnly, null);
                            }
                            else if (this.modifyid == 0)
                            {
                                Interaction.MsgBox("Select Record than Delete?", MsgBoxStyle.OkOnly, null);
                            }
                            else
                            {
                                Module1.conn.Close();
                                string cmdText2 = $"update CupTrans set m_checked=1, modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where m_id={this.txtid.Text} and m_eid={Conversions.ToString(this.modifyid)} and m_party='{objectValue}'";
                                using (CupService cupService = new CupService())
                                {
                                    cupService.Update(cmdText2);
                                }
                                //this.DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                                this.DataGridView1.Rows.Clear();
                                this.DataGridView2.Rows.Clear();
                                this.CUP_Load(RuntimeHelpers.GetObjectValue(sender), e);
                            }
                        }

                        this.modifyid = 0;
                        this.txtrate.Text = "";
                        this.txtamount.Text = "";
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

        // Token: 0x06000662 RID: 1634 RVA: 0x002C7E80 File Offset: 0x002C6280
        private void txtamount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text != "")
                {
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000663 RID: 1635 RVA: 0x002C7EB4 File Offset: 0x002C62B4
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

        // Token: 0x06000664 RID: 1636 RVA: 0x002C7F50 File Offset: 0x002C6350
        private void txtmode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtmode.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        this.txtpartiname.Focus();
                    }
                }
                if (e.KeyCode == Keys.NumPad1)
                {
                    this.txtmode.SelectedItem = "K";
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    this.txtmode.SelectedItem = "L";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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
                            this.btnOK.Focus();
                        }
                    }
                    else
                    {
                        this.Button11.Focus();
                    }
                }

                if (e.KeyCode == Keys.Back)
                {
                    this.txtpartiname.Text = null;
                    this.txtpartiname.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void Regular_all_Tems()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT CupTrans.m_id, PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SCup, PartyMaster.ACup, PartyMaster.TCup, CupTrans.m_party, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9,  SUM(CupTrans.m_team10) AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15, CupTrans.m_checked, CupTrans.M_Tem_Out FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY CupTrans.m_id, PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SCup, PartyMaster.ACup, PartyMaster.TCup, CupTrans.m_party, CupTrans.m_checked,CupTrans.M_Tem_Out HAVING (CupTrans.m_checked = 0) AND (CupTrans.m_id = " + this.txtid.Text + ") AND (PartyMaster.Status = 'Regular')AND (CupTrans.M_Tem_Out = 0)";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["SCup"]);
                    double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"]));
                    double num3 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    double num4 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    double num5 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    double num6 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num7 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    double num8 = Convert.ToDouble(oleDbDataReader["Expr6"]);
                    double num9 = Convert.ToDouble(oleDbDataReader["Expr7"]);
                    double num10 = Convert.ToDouble(oleDbDataReader["Expr8"]);
                    double num11 = Convert.ToDouble(oleDbDataReader["Expr9"]);
                    double num12 = Convert.ToDouble(oleDbDataReader["Expr10"]);
                    double num13 = Convert.ToDouble(oleDbDataReader["Expr11"]);
                    double num14 = Convert.ToDouble(oleDbDataReader["Expr12"]);
                    double num15 = Convert.ToDouble(oleDbDataReader["Expr13"]);
                    double num16 = Convert.ToDouble(oleDbDataReader["Expr14"]);
                    double num17 = Convert.ToDouble(oleDbDataReader["Expr15"]);

                    double num18 = Conversion.Val(num3) * Conversion.Val(num) / 100 - Conversion.Val(num3);
                    double num19 = Conversion.Val(num4) * Conversion.Val(num) / 100 - Conversion.Val(num4);
                    double num20 = Conversion.Val(num5) * Conversion.Val(num) / 100 - Conversion.Val(num5);
                    double num21 = Conversion.Val(num6) * Conversion.Val(num) / 100 - Conversion.Val(num6);
                    double num22 = Conversion.Val(num7) * Conversion.Val(num) / 100 - Conversion.Val(num7);
                    double num23 = Conversion.Val(num8) * Conversion.Val(num) / 100 - Conversion.Val(num8);
                    double num24 = Conversion.Val(num9) * Conversion.Val(num) / 100 - Conversion.Val(num9);
                    double num25 = Conversion.Val(num10) * Conversion.Val(num) / 100 - Conversion.Val(num10);
                    double num26 = Conversion.Val(num11) * Conversion.Val(num) / 100 - Conversion.Val(num11);
                    double num27 = Conversion.Val(num12) * Conversion.Val(num) / 100 - Conversion.Val(num12);
                    double num28 = Conversion.Val(num13) * Conversion.Val(num) / 100 - Conversion.Val(num13);
                    double num29 = Conversion.Val(num14) * Conversion.Val(num) / 100 - Conversion.Val(num14);
                    double num30 = Conversion.Val(num15) * Conversion.Val(num) / 100 - Conversion.Val(num15);
                    double num31 = Conversion.Val(num16) * Conversion.Val(num) / 100 - Conversion.Val(num16);
                    double num32 = Conversion.Val(num17) * Conversion.Val(num) / 100 - Conversion.Val(num17);

                    double num33 = Conversion.Val(num18) * Conversion.Val(num2) / 100 - Conversion.Val(num18);
                    double num34 = Conversion.Val(num19) * Conversion.Val(num2) / 100 - Conversion.Val(num19);
                    double num35 = Conversion.Val(num20) * Conversion.Val(num2) / 100 - Conversion.Val(num20);
                    double num36 = Conversion.Val(num21) * Conversion.Val(num2) / 100 - Conversion.Val(num21);
                    double num37 = Conversion.Val(num22) * Conversion.Val(num2) / 100 - Conversion.Val(num22);
                    double num38 = Conversion.Val(num23) * Conversion.Val(num2) / 100 - Conversion.Val(num23);
                    double num39 = Conversion.Val(num24) * Conversion.Val(num2) / 100 - Conversion.Val(num24);
                    double num40 = Conversion.Val(num25) * Conversion.Val(num2) / 100 - Conversion.Val(num25);
                    double num41 = Conversion.Val(num26) * Conversion.Val(num2) / 100 - Conversion.Val(num26);
                    double num42 = Conversion.Val(num27) * Conversion.Val(num2) / 100 - Conversion.Val(num27);
                    double num43 = Conversion.Val(num28) * Conversion.Val(num2) / 100 - Conversion.Val(num28);
                    double num44 = Conversion.Val(num29) * Conversion.Val(num2) / 100 - Conversion.Val(num29);
                    double num45 = Conversion.Val(num30) * Conversion.Val(num2) / 100 - Conversion.Val(num30);
                    double num46 = Conversion.Val(num31) * Conversion.Val(num2) / 100 - Conversion.Val(num31);
                    double num47 = Conversion.Val(num32) * Conversion.Val(num2) / 100 - Conversion.Val(num32);

                    int index = this.DataGridView5.Rows.Add();
                    this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num33);
                    this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num34);
                    this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num35);
                    this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num36);
                    this.DataGridView5.Rows[index].Cells[4].Value = Conversion.Val(num37);
                    this.DataGridView5.Rows[index].Cells[5].Value = Conversion.Val(num38);
                    this.DataGridView5.Rows[index].Cells[6].Value = Conversion.Val(num39);
                    this.DataGridView5.Rows[index].Cells[7].Value = Conversion.Val(num40);
                    this.DataGridView5.Rows[index].Cells[8].Value = Conversion.Val(num41);
                    this.DataGridView5.Rows[index].Cells[9].Value = Conversion.Val(num42);
                    this.DataGridView5.Rows[index].Cells[10].Value = Conversion.Val(num43);
                    this.DataGridView5.Rows[index].Cells[11].Value = Conversion.Val(num44);
                    this.DataGridView5.Rows[index].Cells[12].Value = Conversion.Val(num45);
                    this.DataGridView5.Rows[index].Cells[13].Value = Conversion.Val(num46);
                    this.DataGridView5.Rows[index].Cells[14].Value = Conversion.Val(num47);
                }
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

        // Token: 0x06000668 RID: 1640 RVA: 0x002C8B60 File Offset: 0x002C6F60
        public void Regular_Total_Tems()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView5.RowCount - 1;
                    double num3 = 0;
                    double num4 = 0;
                    double num5 = 0;
                    double num6 = 0;
                    double num7 = 0;
                    double num8 = 0;
                    double num9 = 0;
                    double num10 = 0;
                    double num11 = 0;
                    double num12 = 0;
                    double num13 = 0;
                    double num14 = 0;
                    double num15 = 0;
                    double num16 = 0;
                    double num17 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[0].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[1].Value));
                            num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[2].Value));
                            num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[3].Value));
                            num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[4].Value));
                            num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[5].Value));
                            num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[6].Value));
                            num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[7].Value));
                            num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                            num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[10].Value));
                            num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[11].Value));
                            num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[12].Value));
                            num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[13].Value));
                            num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[14].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[2].Value = Module1.SetNumFormat(num4, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[3].Value = Module1.SetNumFormat(num5, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[4].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[5].Value = Module1.SetNumFormat(num7, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[6].Value = Module1.SetNumFormat(num8, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[7].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[8].Value = Module1.SetNumFormat(num10, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[9].Value = Module1.SetNumFormat(num11, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[10].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[11].Value = Module1.SetNumFormat(num13, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[12].Value = Module1.SetNumFormat(num14, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[13].Value = Module1.SetNumFormat(num15, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[14].Value = Module1.SetNumFormat(num16, this.txtnu.Text);
                        this.DataGridView2.Rows[2].Cells[15].Value = Module1.SetNumFormat(num17, this.txtnu.Text);
                    }
                    else
                    {

                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(num4, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(num5, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[4].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[5].Value = Module1.SetNumFormat(num7, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[6].Value = Module1.SetNumFormat(num8, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[7].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[8].Value = Module1.SetNumFormat(num10, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[9].Value = Module1.SetNumFormat(num11, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[10].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[11].Value = Module1.SetNumFormat(num13, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[12].Value = Module1.SetNumFormat(num14, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[13].Value = Module1.SetNumFormat(num15, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[14].Value = Module1.SetNumFormat(num16, this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[15].Value = Module1.SetNumFormat(num17, this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x06000669 RID: 1641 RVA: 0x002C91F8 File Offset: 0x002C75F8
        public void Booky_all_Tems()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT CupTrans.m_id, PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SCup, PartyMaster.ACup, PartyMaster.TCup, CupTrans.m_party, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9,  SUM(CupTrans.m_team10) AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15, CupTrans.m_checked, CupTrans.M_Tem_Out FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY CupTrans.m_id, PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SCup, PartyMaster.ACup, PartyMaster.TCup, CupTrans.m_party, CupTrans.m_checked,CupTrans.M_Tem_Out HAVING (CupTrans.m_checked = 0) AND (CupTrans.m_id = " + this.txtid.Text + ") AND (PartyMaster.Status = 'Booky') AND (CupTrans.M_Tem_Out = 0)";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["SCup"]);
                    double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"]));
                    double num3 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    double num4 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    double num5 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    double num6 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num7 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    double num8 = Convert.ToDouble(oleDbDataReader["Expr6"]);
                    double num9 = Convert.ToDouble(oleDbDataReader["Expr7"]);
                    double num10 = Convert.ToDouble(oleDbDataReader["Expr8"]);
                    double num11 = Convert.ToDouble(oleDbDataReader["Expr9"]);
                    double num12 = Convert.ToDouble(oleDbDataReader["Expr10"]);
                    double num13 = Convert.ToDouble(oleDbDataReader["Expr11"]);
                    double num14 = Convert.ToDouble(oleDbDataReader["Expr12"]);
                    double num15 = Convert.ToDouble(oleDbDataReader["Expr13"]);
                    double num16 = Convert.ToDouble(oleDbDataReader["Expr14"]);
                    double num17 = Convert.ToDouble(oleDbDataReader["Expr15"]);
                    double num18 = Conversion.Val(num3) * Conversion.Val(num) / 100 - Conversion.Val(num3);
                    double num19 = Conversion.Val(num4) * Conversion.Val(num) / 100 - Conversion.Val(num4);
                    double num20 = Conversion.Val(num5) * Conversion.Val(num) / 100 - Conversion.Val(num5);
                    double num21 = Conversion.Val(num6) * Conversion.Val(num) / 100 - Conversion.Val(num6);
                    double num22 = Conversion.Val(num7) * Conversion.Val(num) / 100 - Conversion.Val(num7);
                    double num23 = Conversion.Val(num8) * Conversion.Val(num) / 100 - Conversion.Val(num8);
                    double num24 = Conversion.Val(num9) * Conversion.Val(num) / 100 - Conversion.Val(num9);
                    double num25 = Conversion.Val(num10) * Conversion.Val(num) / 100 - Conversion.Val(num10);
                    double num26 = Conversion.Val(num11) * Conversion.Val(num) / 100 - Conversion.Val(num11);
                    double num27 = Conversion.Val(num12) * Conversion.Val(num) / 100 - Conversion.Val(num12);
                    double num28 = Conversion.Val(num13) * Conversion.Val(num) / 100 - Conversion.Val(num13);
                    double num29 = Conversion.Val(num14) * Conversion.Val(num) / 100 - Conversion.Val(num14);
                    double num30 = Conversion.Val(num15) * Conversion.Val(num) / 100 - Conversion.Val(num15);
                    double num31 = Conversion.Val(num16) * Conversion.Val(num) / 100 - Conversion.Val(num16);
                    double num32 = Conversion.Val(num17) * Conversion.Val(num) / 100 - Conversion.Val(num17);
                    double num33 = Conversion.Val(num18) * Conversion.Val(num2) / 100 - Conversion.Val(num18);
                    double num34 = Conversion.Val(num19) * Conversion.Val(num2) / 100 - Conversion.Val(num19);
                    double num35 = Conversion.Val(num20) * Conversion.Val(num2) / 100 - Conversion.Val(num20);
                    double num36 = Conversion.Val(num21) * Conversion.Val(num2) / 100 - Conversion.Val(num21);
                    double num37 = Conversion.Val(num22) * Conversion.Val(num2) / 100 - Conversion.Val(num22);
                    double num38 = Conversion.Val(num23) * Conversion.Val(num2) / 100 - Conversion.Val(num23);
                    double num39 = Conversion.Val(num24) * Conversion.Val(num2) / 100 - Conversion.Val(num24);
                    double num40 = Conversion.Val(num25) * Conversion.Val(num2) / 100 - Conversion.Val(num25);
                    double num41 = Conversion.Val(num26) * Conversion.Val(num2) / 100 - Conversion.Val(num26);
                    double num42 = Conversion.Val(num27) * Conversion.Val(num2) / 100 - Conversion.Val(num27);
                    double num43 = Conversion.Val(num28) * Conversion.Val(num2) / 100 - Conversion.Val(num28);
                    double num44 = Conversion.Val(num29) * Conversion.Val(num2) / 100 - Conversion.Val(num29);
                    double num45 = Conversion.Val(num30) * Conversion.Val(num2) / 100 - Conversion.Val(num30);
                    double num46 = Conversion.Val(num31) * Conversion.Val(num2) / 100 - Conversion.Val(num31);
                    double num47 = Conversion.Val(num32) * Conversion.Val(num2) / 100 - Conversion.Val(num32);
                    int index = this.DataGridView5.Rows.Add();
                    this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num33);
                    this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num34);
                    this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num35);
                    this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num36);
                    this.DataGridView5.Rows[index].Cells[4].Value = Conversion.Val(num37);
                    this.DataGridView5.Rows[index].Cells[5].Value = Conversion.Val(num38);
                    this.DataGridView5.Rows[index].Cells[6].Value = Conversion.Val(num39);
                    this.DataGridView5.Rows[index].Cells[7].Value = Conversion.Val(num40);
                    this.DataGridView5.Rows[index].Cells[8].Value = Conversion.Val(num41);
                    this.DataGridView5.Rows[index].Cells[9].Value = Conversion.Val(num42);
                    this.DataGridView5.Rows[index].Cells[10].Value = Conversion.Val(num43);
                    this.DataGridView5.Rows[index].Cells[11].Value = Conversion.Val(num44);
                    this.DataGridView5.Rows[index].Cells[12].Value = Conversion.Val(num45);
                    this.DataGridView5.Rows[index].Cells[13].Value = Conversion.Val(num46);
                    this.DataGridView5.Rows[index].Cells[14].Value = Conversion.Val(num47);
                }
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

        // Token: 0x0600066A RID: 1642 RVA: 0x002C9D04 File Offset: 0x002C8104
        public void Booky_Total_Tems()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView5.RowCount - 1;
                    double num3 = 0;
                    double num4 = 0;
                    double num5 = 0;
                    double num6 = 0;
                    double num7 = 0;
                    double num8 = 0;
                    double num9 = 0;
                    double num10 = 0;
                    double num11 = 0;
                    double num12 = 0;
                    double num13 = 0;
                    double num14 = 0;
                    double num15 = 0;
                    double num16 = 0;
                    double num17 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[0].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[1].Value));
                            num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[2].Value));
                            num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[3].Value));
                            num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[4].Value));
                            num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[5].Value));
                            num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[6].Value));
                            num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[7].Value));
                            num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                            num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[10].Value));
                            num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[11].Value));
                            num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[12].Value));
                            num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[13].Value));
                            num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[14].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[2].Value = Module1.SetNumFormat(num4, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[3].Value = Module1.SetNumFormat(num5, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[4].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[5].Value = Module1.SetNumFormat(num7, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[6].Value = Module1.SetNumFormat(num8, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[7].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[8].Value = Module1.SetNumFormat(num10, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[9].Value = Module1.SetNumFormat(num11, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[10].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[11].Value = Module1.SetNumFormat(num13, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[12].Value = Module1.SetNumFormat(num14, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[13].Value = Module1.SetNumFormat(num15, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[14].Value = Module1.SetNumFormat(num16, this.txtnu.Text);
                        this.DataGridView2.Rows[3].Cells[15].Value = Module1.SetNumFormat(num17, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[2].Value = Module1.SetNumFormat(num4, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[3].Value = Module1.SetNumFormat(num5, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[4].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[5].Value = Module1.SetNumFormat(num7, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[6].Value = Module1.SetNumFormat(num8, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[7].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[8].Value = Module1.SetNumFormat(num10, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[9].Value = Module1.SetNumFormat(num11, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[10].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[11].Value = Module1.SetNumFormat(num13, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[12].Value = Module1.SetNumFormat(num14, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[13].Value = Module1.SetNumFormat(num15, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[14].Value = Module1.SetNumFormat(num16, this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[15].Value = Module1.SetNumFormat(num17, this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x0600066D RID: 1645 RVA: 0x002CB540 File Offset: 0x002C9940
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

        // Token: 0x0600066E RID: 1646 RVA: 0x002CB5A8 File Offset: 0x002C99A8
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

        // Token: 0x0600066F RID: 1647 RVA: 0x002CB644 File Offset: 0x002C9A44
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

        // Token: 0x06000670 RID: 1648 RVA: 0x002CB6D4 File Offset: 0x002C9AD4
        private void txtteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtteam.Text, null, false) == 0)
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

        // Token: 0x06000671 RID: 1649 RVA: 0x002CB744 File Offset: 0x002C9B44
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

        // Token: 0x06000672 RID: 1650 RVA: 0x002CB780 File Offset: 0x002C9B80
        public void balance_Limitset()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                double num = 0;
                string cmdText = "SELECT SUM(tns_Amount) AS ColsingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtpartiname.Text + "') GROUP BY tns_Party ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    num += Convert.ToDouble(oleDbDataReader["ColsingBalanceAmount"]);
                }

                //string cmdText = "SELECT SUM(tns_Amount) AS ColsingBalanceAmount, Trans.tns_Party, SUM(OP_BAL.Amount) AS OPAmount1 FROM (Trans LEFT OUTER JOIN OP_BAL ON Trans.tns_Party = OP_BAL.PartyName) WHERE        (Trans.tns_chk = '0') AND (Trans.tns_Type <> 'Monday Settlement') GROUP BY Trans.tns_Party HAVING        (Trans.tns_Party = '" + this.txtpartiname.Text + "')";
                //if (Module1.conn.State == ConnectionState.Closed)
                //{
                //	Module1.conn.Open();
                //}
                //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                //double num = 0;
                //while (oleDbDataReader.Read())
                //{
                //	num = Convert.ToDouble(oleDbDataReader["ColsingBalanceAmount"]);
                //}

                //string cmdText2 = "SELECT SUM(Amount) AS OP_Amount, PartyName FROM (OP_BAL) GROUP BY PartyName HAVING (PartyName = '" + this.txtpartiname.Text + "')";
                //oleDbCommand = new OleDbCommand(cmdText2, Module1.conn);
                //oleDbDataReader = oleDbCommand.ExecuteReader();
                //double num2 = 0;
                //while (oleDbDataReader.Read())
                //{
                //	num2 = Convert.ToDouble(oleDbDataReader["OP_Amount"]);
                //}

                double num3 = Conversion.Val(num); //+ Conversion.Val(num2);
                string cmdText3 = "SELECT PartyName, Status, SMatchCommi, SCup, SSession, ACup, ASession, TCup, TSession FROM PartyMaster WHERE (PartyName = '" + this.txtpartiname.Text + "')";
                oleDbCommand = new OleDbCommand(cmdText3, Module1.conn);
                oleDbDataReader = oleDbCommand.ExecuteReader();
                double num4 = 0;
                double num7 = 0;
                double num8 = 0;
                double num9 = 0;
                double num10 = 0;
                double num11 = 0;
                if (oleDbDataReader.Read())
                {
                    num4 = Convert.ToDouble(oleDbDataReader["SCup"]);
                    double num5 = Convert.ToDouble("0");
                    double num6 = Convert.ToDouble("0");
                    num7 = Conversion.Val(num5) + Conversion.Val(num6);
                    num8 = 0;//Convert.ToDouble(oleDbDataReader["SMatchCommi"]);
                    num9 = 0;//Convert.ToDouble(oleDbDataReader["Balance_Limit"]);
                    num10 = Convert.ToDouble(oleDbDataReader["SCup"]);
                    num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"]));
                }
                string cmdText4 = "SELECT Newmatch.Sr_No, Newmatch.Result, MatchTrans.m_party, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)AS Expr4, MatchTrans.m_checked FROM (Newmatch INNER JOIN MatchTrans ON Newmatch.Sr_No = MatchTrans.m_id) GROUP BY Newmatch.Sr_No, Newmatch.Result, MatchTrans.m_party, MatchTrans.m_checked HAVING (Newmatch.Result <> 'Declared') AND (MatchTrans.m_party = '" + this.txtpartiname.Text + "') AND (MatchTrans.m_checked <> 1)";
                oleDbCommand = new OleDbCommand(cmdText4, Module1.conn);
                oleDbDataReader = oleDbCommand.ExecuteReader();
                double num12 = 0;
                double num13 = 0;
                double num14 = 0;
                double num15 = 0;
                string text = "";
                string text2 = "";
                while (oleDbDataReader.Read())
                {
                    num12 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    num13 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    num14 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    num15 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num16 = Conversion.Val(num12) * Conversion.Val(0) / 100 - Conversion.Val(num12);
                    double num17 = Conversion.Val(num13) * Conversion.Val(0) / 100 - Conversion.Val(num13);
                    double num18 = Conversion.Val(num14) * Conversion.Val(0) / 100 - Conversion.Val(num14);
                    double num19 = Conversion.Val(num15) * Conversion.Val(0) / 100 - Conversion.Val(num15);
                    if (num16 < 0.0)
                    {
                        double num20 = Conversion.Val(num16) * Conversion.Val(num8) / 100;
                        double num21 = Conversion.Val(num16) + Conversion.Val(num20) - Conversion.Val(num20) - Conversion.Val(num20);
                        double num22 = Conversion.Val(num21) * Conversion.Val(num4) / 100 - Conversion.Val(num21);
                        double num23 = Conversion.Val(num22) * Conversion.Val(num7) / 100 - num22;
                        text = Conversions.ToString(Convert.ToDouble(text) + (Conversion.Val(num23) - Conversion.Val(num23) - Conversion.Val(num23)));
                    }
                    else
                    {
                        double num24 = Conversion.Val(num16) * Conversion.Val(num4) / 100 - Conversion.Val(num16);
                        double num25 = Conversion.Val(num24) * Conversion.Val(num7) / 100 - num24;
                        text = Conversions.ToString(Convert.ToDouble(text) + (Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25)));
                    }
                    if (num17 < 0.0)
                    {
                        double num26 = Conversion.Val(num17) * Conversion.Val(num8) / 100;
                        double num27 = Conversion.Val(num17) + Conversion.Val(num26) - Conversion.Val(num26) - Conversion.Val(num26);
                        double num28 = Conversion.Val(num27) * Conversion.Val(num4) / 100 - Conversion.Val(num27);
                        double num29 = Conversion.Val(num28) * Conversion.Val(num7) / 100 - num28;
                        text2 = Conversions.ToString(Convert.ToDouble(text2) + (Conversion.Val(num29) - Conversion.Val(num29) - Conversion.Val(num29)));
                    }
                    else
                    {
                        double num30 = Conversion.Val(num17) * Conversion.Val(num4) / 100 - Conversion.Val(num17);
                        double num31 = Conversion.Val(num30) * Conversion.Val(num7) / 100 - num30;
                        text2 = Conversions.ToString(Convert.ToDouble(text2) + (Conversion.Val(num31) - Conversion.Val(num31) - Conversion.Val(num31)));
                    }
                }
                string inputStr = Conversions.ToString(0);
                if (0.0 <= Convert.ToDouble(text))
                {
                    inputStr = text;
                }
                if (0.0 <= Convert.ToDouble(text2))
                {
                    inputStr = text2;
                }
                string cmdText5 = "SELECT        Newmatch.Sr_No, Newmatch.Result, CupTrans.m_party, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9, SUM(CupTrans.m_team10) AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15, CupTrans.M_Tem_Out, CupTrans.m_checked FROM            (Newmatch INNER JOIN CupTrans ON Newmatch.Sr_No = CupTrans.m_id)GROUP BY Newmatch.Sr_No, Newmatch.Result, CupTrans.m_party, CupTrans.M_Tem_Out, CupTrans.m_checked HAVING        (CupTrans.M_Tem_Out = 0) AND (CupTrans.m_checked <> 1) AND (CupTrans.m_party = '" + this.txtpartiname.Text + "')";
                oleDbCommand = new OleDbCommand(cmdText5, Module1.conn);
                oleDbDataReader = oleDbCommand.ExecuteReader();
                double num77 = 0;
                double num78 = 0;
                double num79 = 0;
                double num80 = 0;
                double num81 = 0;
                double num82 = 0;
                double num83 = 0;
                double num84 = 0;
                double num85 = 0;
                double num86 = 0;
                double num87 = 0;
                double num88 = 0;
                double num89 = 0;
                double num90 = 0;
                double num91 = 0;
                while (oleDbDataReader.Read())
                {
                    double num32 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    double num33 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    double num34 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    double num35 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num36 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    double num37 = Convert.ToDouble(oleDbDataReader["Expr6"]);
                    double num38 = Convert.ToDouble(oleDbDataReader["Expr7"]);
                    double num39 = Convert.ToDouble(oleDbDataReader["Expr8"]);
                    double num40 = Convert.ToDouble(oleDbDataReader["Expr9"]);
                    double num41 = Convert.ToDouble(oleDbDataReader["Expr10"]);
                    double num42 = Convert.ToDouble(oleDbDataReader["Expr11"]);
                    double num43 = Convert.ToDouble(oleDbDataReader["Expr12"]);
                    double num44 = Convert.ToDouble(oleDbDataReader["Expr13"]);
                    double num45 = Convert.ToDouble(oleDbDataReader["Expr14"]);
                    double num46 = Convert.ToDouble(oleDbDataReader["Expr15"]);
                    double num47 = Conversion.Val(num32) * Conversion.Val(num10) / 100 - Conversion.Val(num32);
                    double num48 = Conversion.Val(num33) * Conversion.Val(num10) / 100 - Conversion.Val(num33);
                    double num49 = Conversion.Val(num34) * Conversion.Val(num10) / 100 - Conversion.Val(num34);
                    double num50 = Conversion.Val(num35) * Conversion.Val(num10) / 100 - Conversion.Val(num35);
                    double num51 = Conversion.Val(num36) * Conversion.Val(num10) / 100 - Conversion.Val(num36);
                    double num52 = Conversion.Val(num37) * Conversion.Val(num10) / 100 - Conversion.Val(num37);
                    double num53 = Conversion.Val(num38) * Conversion.Val(num10) / 100 - Conversion.Val(num38);
                    double num54 = Conversion.Val(num39) * Conversion.Val(num10) / 100 - Conversion.Val(num39);
                    double num55 = Conversion.Val(num40) * Conversion.Val(num10) / 100 - Conversion.Val(num40);
                    double num56 = Conversion.Val(num41) * Conversion.Val(num10) / 100 - Conversion.Val(num41);
                    double num57 = Conversion.Val(num42) * Conversion.Val(num10) / 100 - Conversion.Val(num42);
                    double num58 = Conversion.Val(num43) * Conversion.Val(num10) / 100 - Conversion.Val(num43);
                    double num59 = Conversion.Val(num44) * Conversion.Val(num10) / 100 - Conversion.Val(num44);
                    double num60 = Conversion.Val(num45) * Conversion.Val(num10) / 100 - Conversion.Val(num45);
                    double num61 = Conversion.Val(num46) * Conversion.Val(num10) / 100 - Conversion.Val(num46);
                    double num62 = Conversion.Val(num47) * Conversion.Val(num11) / 100 - Conversion.Val(num47);
                    double num63 = Conversion.Val(num48) * Conversion.Val(num11) / 100 - Conversion.Val(num48);
                    double num64 = Conversion.Val(num49) * Conversion.Val(num11) / 100 - Conversion.Val(num49);
                    double num65 = Conversion.Val(num50) * Conversion.Val(num11) / 100 - Conversion.Val(num50);
                    double num66 = Conversion.Val(num51) * Conversion.Val(num11) / 100 - Conversion.Val(num51);
                    double num67 = Conversion.Val(num52) * Conversion.Val(num11) / 100 - Conversion.Val(num52);
                    double num68 = Conversion.Val(num53) * Conversion.Val(num11) / 100 - Conversion.Val(num53);
                    double num69 = Conversion.Val(num54) * Conversion.Val(num11) / 100 - Conversion.Val(num54);
                    double num70 = Conversion.Val(num55) * Conversion.Val(num11) / 100 - Conversion.Val(num55);
                    double num71 = Conversion.Val(num56) * Conversion.Val(num11) / 100 - Conversion.Val(num56);
                    double num72 = Conversion.Val(num57) * Conversion.Val(num11) / 100 - Conversion.Val(num57);
                    double num73 = Conversion.Val(num58) * Conversion.Val(num11) / 100 - Conversion.Val(num58);
                    double num74 = Conversion.Val(num59) * Conversion.Val(num11) / 100 - Conversion.Val(num59);
                    double num75 = Conversion.Val(num60) * Conversion.Val(num11) / 100 - Conversion.Val(num60);
                    double num76 = Conversion.Val(num61) * Conversion.Val(num11) / 100 - Conversion.Val(num61);
                    num77 += Conversion.Val(num62);
                    num78 += Conversion.Val(num63);
                    num79 += Conversion.Val(num64);
                    num80 += Conversion.Val(num65);
                    num81 += Conversion.Val(num66);
                    num82 += Conversion.Val(num67);
                    num83 += Conversion.Val(num68);
                    num84 += Conversion.Val(num69);
                    num85 += Conversion.Val(num70);
                    num86 += Conversion.Val(num71);
                    num87 += Conversion.Val(num72);
                    num88 += Conversion.Val(num73);
                    num89 += Conversion.Val(num74);
                    num90 += Conversion.Val(num75);
                    num91 += Conversion.Val(num76);
                }
                string inputStr2 = Conversions.ToString(0);
                if (0.0 <= num77)
                {
                    if (num77 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num77);
                    }
                }
                if (0.0 <= num78)
                {
                    if (num78 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num78);
                    }
                }
                if (0.0 <= num79)
                {
                    if (num79 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num79);
                    }
                }
                if (0.0 <= num80)
                {
                    if (num80 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num80);
                    }
                }
                if (0.0 <= num81)
                {
                    if (num81 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num81);
                    }
                }
                if (0.0 <= num82)
                {
                    if (num82 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num82);
                    }
                }
                if (0.0 <= num83)
                {
                    if (num83 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num83);
                    }
                }
                if (0.0 <= num84)
                {
                    if (num84 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num84);
                    }
                }
                if (0.0 <= num85)
                {
                    if (num85 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num85);
                    }
                }
                if (0.0 <= num86)
                {
                    if (num86 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num86);
                    }
                }
                if (0.0 <= num87)
                {
                    if (num87 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num87);
                    }
                }
                if (0.0 <= num88)
                {
                    if (num88 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num88);
                    }
                }
                if (0.0 <= num89)
                {
                    if (num89 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num89);
                    }
                }
                if (0.0 <= num90)
                {
                    if (num90 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num90);
                    }
                }
                if (0.0 <= num91)
                {
                    if (num91 != 0.0)
                    {
                        inputStr2 = Conversions.ToString(num91);
                    }
                }
                TextBox textBox = new TextBox();
                string cmdText6 = "SELECT ewSession.Sr_No, ewSession.Result, SessionTrans.s_rate, SessionTrans.s_amt, SessionTrans.S_RUN, SessionTrans.s_bild, SessionTrans.s_mod, SessionTrans.s_party, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.s_checked, PartyMaster.SSession, PartyMaster.ASession, PartyMaster.TSession, PartyMaster.Status,ewSession.Type, SessionTrans.id FROM ((ewSession INNER JOIN SessionTrans ON ewSession.Sr_No = SessionTrans.Session_ID) INNER JOIN PartyMaster ON SessionTrans.s_party = PartyMaster.PartyName) WHERE (ewSession.Result <> 'Declared') AND (SessionTrans.s_checked = 0) AND (SessionTrans.s_party = '" + this.txtpartiname.Text + "')ORDER BY SessionTrans.id";
                oleDbCommand = new OleDbCommand(cmdText6, Module1.conn);
                oleDbDataReader = oleDbCommand.ExecuteReader();
                double num94 = 0;
                double num95 = 0;
                while (oleDbDataReader.Read())
                {
                    num7 = Convert.ToDouble(oleDbDataReader["SSession"]);
                    double num92 = Convert.ToDouble(Operators.AddObject(oleDbDataReader["ASession"], oleDbDataReader["TSession"]));
                    double num93 = 0;
                    //if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Type"], "20-20", false))
                    //{
                    //	num93 = Convert.ToDouble(oleDbDataReader["C_20"]);
                    //}
                    //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Type"], "50-50", false))
                    //{
                    //	num93 = Convert.ToDouble(oleDbDataReader["C_50"]);
                    //}
                    //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Type"], "40-40", false))
                    //{
                    //	num93 = Convert.ToDouble(oleDbDataReader["C_40"]);
                    //}
                    //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Type"], "TEST", false))
                    //{
                    //	num93 = Convert.ToDouble(oleDbDataReader["C_Test"]);
                    //}
                    //else
                    //{
                    //	num93 = Convert.ToDouble("0.00");
                    //}
                    num94 = num93;
                    textBox.Text = Conversions.ToString(oleDbDataReader["Status"]);
                    num95 += Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_amt"])) * Conversion.Val(num93) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_amt"]));
                }
                num95 = Conversion.Val(num95) - Conversion.Val(num95) - Conversion.Val(num95);
                string inputStr3 = Conversions.ToString(0);
                if (0.0 <= num95)
                {
                    if (num95 != 0.0)
                    {
                        inputStr3 = Conversions.ToString(num95);
                    }
                }
                double num96 = 0;
                if (!Operators.ConditionalCompareObjectGreater(0, this.h1, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h1, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h1);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h2, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h2, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h2);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h3, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h3, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h3);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h4, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h4, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h4);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h5, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h5, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h5);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h6, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h6, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h6);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h7, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h7, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h7);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h8, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h8, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h8);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h9, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h9, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h9);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h10, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h10, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h10);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h11, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h11, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h11);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h12, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h12, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h12);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h13, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h13, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h13);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h14, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h14, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h14);
                    }
                }
                if (!Operators.ConditionalCompareObjectGreater(0, this.h15, false))
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.h15, 0, false))
                    {
                        num96 = Convert.ToDouble(this.h15);
                    }
                }
                num96 += Conversion.Val(this.txtamount.Text) * Conversion.Val(num94) / 100 - Conversion.Val(this.txtamount.Text);
                num96 = Conversion.Val(num96) - Conversion.Val(num96) - Conversion.Val(num96);
                string value = Conversions.ToString(0);
                if (0.0 <= num96)
                {
                    value = Conversions.ToString(num96);
                }
                num12 = Convert.ToDouble("0");
                num13 = Convert.ToDouble("0");
                num14 = Convert.ToDouble("0");
                num15 = Convert.ToDouble("0");
                if (num9 == 0.0)
                {
                    Module1.balancelimits = "NO";
                }
                else
                {
                    Module1.balancelimits = "Yes";
                    Module1.TotalAmount = Conversion.Val(num9) + Conversion.Val(num3) - Conversion.Val(inputStr) - Conversion.Val(inputStr2) - Conversion.Val(inputStr3);
                    Module1.CustBalance = Convert.ToDouble(value);
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

        // Token: 0x06000674 RID: 1652 RVA: 0x002CCF68 File Offset: 0x002CB368
        private void Agent_Total()
        {
            try
            {
                this.DataGridView6.Rows.Add();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.TParty, CupTrans.id, CupTrans.m_id, CupTrans.m_eid, CupTrans.m_page, CupTrans.m_amt, CupTrans.m_rate, CupTrans.m_team, CupTrans.m_mode, CupTrans.m_party, CupTrans.m_dt, CupTrans.m_time, CupTrans.m_team1, CupTrans.m_team2, CupTrans.m_team3, CupTrans.m_team4, CupTrans.m_team5, CupTrans.m_team6, CupTrans.m_team7, CupTrans.m_team8, CupTrans.m_team9, CupTrans.m_team10, CupTrans.m_team11, CupTrans.m_team12, CupTrans.m_team13, CupTrans.m_team14, CupTrans.m_team15, CupTrans.m_modify, CupTrans.m_dt1, CupTrans.m_checked, CupTrans.m_s_share, CupTrans.Stus, CupTrans.M_Tem_Out, CupTrans.M_chk, PartyMaster.TCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.SCup FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) WHERE (PartyMaster.AParty = '",
                    this.ComboBox2.Text,
                    "') AND (CupTrans.m_id = ",
                    this.txtid.Text,
                    ") OR (PartyMaster.PartyName = '",
                    this.ComboBox2.Text,
                    "') OR (PartyMaster.TParty = '",
                    this.ComboBox2.Text,
                    "') ORDER BY CupTrans.m_eid DESC"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num = 0;
                double num2 = 0;
                double num3 = 0;
                double num4 = 0;
                double num5 = 0;
                double num6 = 0;
                double num7 = 0;
                double num8 = 0;
                double num9 = 0;
                double num10 = 0;
                double num11 = 0;
                double num12 = 0;
                double num13 = 0;
                double num14 = 0;
                double num15 = 0;
                while (oleDbDataReader.Read())
                {
                    if (Operators.CompareString(oleDbDataReader["M_Tem_Out"].ToString(), "1", false) != 0)
                    {
                        if (Operators.CompareString(oleDbDataReader["m_checked"].ToString(), "1", false) != 0)
                        {
                            if (Operators.CompareString(oleDbDataReader["PartyName"].ToString(), this.ComboBox2.Text, false) == 0)
                            {
                                num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num2 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num3 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                            }
                            if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), this.ComboBox2.Text, false) == 0)
                            {
                                num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num2 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num3 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                            }
                            if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), this.ComboBox2.Text, false) == 0)
                            {
                                num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num2 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num3 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                            }
                        }
                    }
                }
                num = Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num);
                num2 = Conversion.Val(num2) - Conversion.Val(num2) - Conversion.Val(num2);
                num3 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
                num4 = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
                num5 = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                num6 = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
                num7 = Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7);
                num8 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
                num9 = Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9);
                num10 = Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10);
                num11 = Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11);
                num12 = Conversion.Val(num12) - Conversion.Val(num12) - Conversion.Val(num12);
                num13 = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                num14 = Conversion.Val(num14) - Conversion.Val(num14) - Conversion.Val(num14);
                num15 = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                this.DataGridView6.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num2), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                this.DataGridView6.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                int num16 = 0;
                checked
                {
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView6.Rows[0].Cells[num16].Value, 0, false))
                        {
                            this.DataGridView6.Rows[0].Cells[num16].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView6.Rows[0].Cells[num16].Style.ForeColor = Color.Green;
                        }
                        num16++;
                    }
                    while (num16 <= 14);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600067A RID: 1658 RVA: 0x002CE6C4 File Offset: 0x002CCAC4
        private void Agent_Total2()
        {
            try
            {
                this.DataGridView7.Rows.Add();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.TParty, CupTrans.id, CupTrans.m_id, CupTrans.m_eid, CupTrans.m_page, CupTrans.m_amt, CupTrans.m_rate, CupTrans.m_team, CupTrans.m_mode, CupTrans.m_party, CupTrans.m_dt, CupTrans.m_time, CupTrans.m_team1, CupTrans.m_team2, CupTrans.m_team3, CupTrans.m_team4, CupTrans.m_team5, CupTrans.m_team6, CupTrans.m_team7, CupTrans.m_team8, CupTrans.m_team9, CupTrans.m_team10, CupTrans.m_team11, CupTrans.m_team12, CupTrans.m_team13, CupTrans.m_team14, CupTrans.m_team15, CupTrans.m_modify, CupTrans.m_dt1, CupTrans.m_checked, CupTrans.m_s_share, CupTrans.Stus, CupTrans.M_Tem_Out, CupTrans.M_chk, PartyMaster.TCup, PartyMaster.AParty, PartyMaster.ACup, PartyMaster.SCup FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) WHERE (PartyMaster.AParty = '",
                    this.ComboBox3.Text,
                    "') AND (CupTrans.m_id = ",
                    this.txtid.Text,
                    ") OR (PartyMaster.PartyName = '",
                    this.ComboBox3.Text,
                    "') OR (PartyMaster.TParty = '",
                    this.ComboBox3.Text,
                    "') ORDER BY CupTrans.m_eid DESC"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num = 0;
                double num2 = 0;
                double num3 = 0;
                double num4 = 0;
                double num5 = 0;
                double num6 = 0;
                double num7 = 0;
                double num8 = 0;
                double num9 = 0;
                double num10 = 0;
                double num11 = 0;
                double num12 = 0;
                double num13 = 0;
                double num14 = 0;
                double num15 = 0;
                while (oleDbDataReader.Read())
                {
                    if (Operators.CompareString(oleDbDataReader["M_Tem_Out"].ToString(), "1", false) != 0)
                    {
                        if (Operators.CompareString(oleDbDataReader["m_checked"].ToString(), "1", false) != 0)
                        {
                            if (Operators.CompareString(oleDbDataReader["PartyName"].ToString(), this.ComboBox3.Text, false) == 0)
                            {
                                num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num2 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num3 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                                num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SCup"])) / 100);
                            }
                            if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), this.ComboBox3.Text, false) == 0)
                            {
                                num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num2 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num3 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                                num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["ACup"])) / 100);
                            }
                            if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), this.ComboBox3.Text, false) == 0)
                            {
                                num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num2 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num3 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                                num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TCup"])) / 100);
                            }
                        }
                    }
                }
                num = Conversion.Val(num) - Conversion.Val(num) - Conversion.Val(num);
                num2 = Conversion.Val(num2) - Conversion.Val(num2) - Conversion.Val(num2);
                num3 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
                num4 = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
                num5 = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                num6 = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
                num7 = Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7);
                num8 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
                num9 = Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9);
                num10 = Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10);
                num11 = Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11);
                num12 = Conversion.Val(num12) - Conversion.Val(num12) - Conversion.Val(num12);
                num13 = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                num14 = Conversion.Val(num14) - Conversion.Val(num14) - Conversion.Val(num14);
                num15 = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                this.DataGridView7.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num2), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                this.DataGridView7.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                int num16 = 0;
                checked
                {
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView7.Rows[0].Cells[num16].Value, 0, false))
                        {
                            this.DataGridView7.Rows[0].Cells[num16].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView7.Rows[0].Cells[num16].Style.ForeColor = Color.Green;
                        }
                        num16++;
                    }
                    while (num16 <= 14);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000676 RID: 1654 RVA: 0x002CE3BC File Offset: 0x002CC7BC
        public void AutoComplete_Agent1(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.ComboBox2.SelectionStart <= 1)
                        {
                            this.ComboBox2.Text = "";
                            return;
                        }
                        if (this.ComboBox2.SelectionLength == 0)
                        {
                            text = this.ComboBox2.Text.Substring(0, this.ComboBox2.Text.Length - 1);
                        }
                        else
                        {
                            text = this.ComboBox2.Text.Substring(0, this.ComboBox2.SelectionStart - 1);
                        }
                    }
                    else if (this.ComboBox2.SelectionLength == 0)
                    {
                        text = this.ComboBox2.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.ComboBox2.Text.Substring(0, this.ComboBox2.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.ComboBox2.FindString(text);
                    if (num != -1)
                    {
                        this.ComboBox2.SelectedText = "";
                        this.ComboBox2.SelectedIndex = num;
                        this.ComboBox2.SelectionStart = text.Length;
                        this.ComboBox2.SelectionLength = this.ComboBox2.Text.Length;
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

        // Token: 0x06000679 RID: 1657 RVA: 0x002CE568 File Offset: 0x002CC968
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

        // Token: 0x06000677 RID: 1655 RVA: 0x002CE518 File Offset: 0x002CC918
        private void ComboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox comboBox = this.ComboBox2;
                this.AutoComplete_Agent1(ref comboBox, e, false);
                this.ComboBox2 = comboBox;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000675 RID: 1653 RVA: 0x002CE360 File Offset: 0x002CC760
        private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.DataGridView6.Rows.Clear();
                    this.Agent_Total();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000678 RID: 1656 RVA: 0x002CE540 File Offset: 0x002CC940
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600067B RID: 1659 RVA: 0x002CFABC File Offset: 0x002CDEBC
        private void ComboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.DataGridView7.Rows.Clear();
                    this.Agent_Total2();

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

        // Token: 0x0600067C RID: 1660 RVA: 0x002CFB18 File Offset: 0x002CDF18
        //private void Disply_Party()
        //{
        //	try
        //	{
        //		if (Module1.conn.State == ConnectionState.Closed)
        //		{
        //			Module1.conn.Open();
        //		}
        //		this.DataGridView8.Rows.Clear();
        //		string cmdText = string.Concat(new string[]
        //		{
        //			"SELECT PartyMaster.PartyName, PartyMaster.SCup, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9, SUM(CupTrans.m_team10)  AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15,  CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_id FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.SCup, CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_id HAVING (PartyMaster.PartyName = '",
        //			this.txtpartiname.Text,
        //			"') AND (CupTrans.m_checked <> 1) AND (CupTrans.M_Tem_Out <> 1) AND (CupTrans.m_id = ",
        //			this.txtid.Text,
        //			")"
        //		});
        //		OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
        //		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
        //		while (oleDbDataReader.Read())
        //		{
        //			double num = Convert.ToDouble(oleDbDataReader["SCup"].ToString());
        //			double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])) * Conversion.Val(num) / 100;
        //			num2 = Conversion.Val(num2) - Conversion.Val(num2) - Conversion.Val(num2);
        //			double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])) * Conversion.Val(num) / 100;
        //			num3 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
        //			double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])) * Conversion.Val(num) / 100;
        //			num4 = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
        //			double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])) * Conversion.Val(num) / 100;
        //			num5 = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
        //			double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])) * Conversion.Val(num) / 100;
        //			num6 = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
        //			double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])) * Conversion.Val(num) / 100;
        //			num7 = Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7);
        //			double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])) * Conversion.Val(num) / 100;
        //			num8 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
        //			double num9 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])) * Conversion.Val(num) / 100;
        //			num9 = Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9);
        //			double num10 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])) * Conversion.Val(num) / 100;
        //			num10 = Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10);
        //			double num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])) * Conversion.Val(num) / 100;
        //			num11 = Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11);
        //			double num12 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])) * Conversion.Val(num) / 100;
        //			num12 = Conversion.Val(num12) - Conversion.Val(num12) - Conversion.Val(num12);
        //			double num13 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])) * Conversion.Val(num) / 100;
        //			num13 = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
        //			double num14 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])) * Conversion.Val(num) / 100;
        //			num14 = Conversion.Val(num14) - Conversion.Val(num14) - Conversion.Val(num14);
        //			double num15 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])) * Conversion.Val(num) / 100;
        //			num15 = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
        //			double num16 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])) * Conversion.Val(num) / 100;
        //			num16 = Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
        //			int index = this.DataGridView8.Rows.Add();
        //			this.DataGridView8.Rows[index].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num2) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num3) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num5) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num6) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num7) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num8) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num9) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num10) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num11) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num12) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num13) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num14) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num15) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])), this.txtnu.Text);
        //			this.DataGridView8.Rows[index].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num16) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])), this.txtnu.Text);
        //		}
        //		int num17 = 0;
        //		checked
        //		{
        //			do
        //			{
        //				if (Operators.ConditionalCompareObjectLess(this.DataGridView8.Rows[0].Cells[num17].Value, 0, false))
        //				{
        //					this.DataGridView8.Rows[0].Cells[num17].Style.ForeColor = Color.Red;
        //				}
        //				else
        //				{
        //					this.DataGridView8.Rows[0].Cells[num17].Style.ForeColor = Color.Green;
        //				}
        //				num17++;
        //			}
        //			while (num17 <= 14);
        //		}
        //	}
        //	catch (Exception ex)
        //	{
        //	}
        //}

        // Token: 0x040002DC RID: 732

        private int srid;

        // Token: 0x040002DD RID: 733
        private int modifyid;

        // Token: 0x040002DE RID: 734
        private object h1;

        // Token: 0x040002DF RID: 735
        private object h2;

        // Token: 0x040002E0 RID: 736
        private object h3;

        // Token: 0x040002E1 RID: 737
        private object h4;

        // Token: 0x040002E2 RID: 738
        private object h5;

        // Token: 0x040002E3 RID: 739
        private object h6;

        // Token: 0x040002E4 RID: 740
        private object h7;

        // Token: 0x040002E5 RID: 741
        private object h8;

        // Token: 0x040002E6 RID: 742
        private object h9;

        // Token: 0x040002E7 RID: 743
        private object h10;

        // Token: 0x040002E8 RID: 744
        private object h11;

        // Token: 0x040002E9 RID: 745
        private object h12;

        // Token: 0x040002EA RID: 746
        private object h13;

        // Token: 0x040002EB RID: 747
        private object h14;

        // Token: 0x040002EC RID: 748
        private object h15;

    }
}


