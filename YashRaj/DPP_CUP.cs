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
using System.Threading;

namespace YashAksh
{
    // Token: 0x0200003D RID: 61
    //[DesignerGenerated]
    public partial class DPP_CUP : Form
    {
        // Token: 0x06000A5C RID: 2652 RVA: 0x002EA4F0 File Offset: 0x002E88F0
        public DPP_CUP()
        {
            //base.KeyDown += this.DPP_CUP_KeyDown;
            //base.Activated += this.DPP_CUP_Activated;
            //base.Load += this.DPP_CUP_Load;
            this.InitializeComponent();
        }

        // Token: 0x06000B2A RID: 2858 RVA: 0x002EE994 File Offset: 0x002ECD94
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT        m_id, m_checked FROM(CupTrans) WHERE        (m_checked = 0) AND (m_id = " + Conversions.ToString(Module1.IDCUP) + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    string cmdText2 = "SELECT        m_id, COUNT(m_team) AS Expr1, M_Tem_Out, m_checked FROM(CupTrans) GROUP BY m_id, M_Tem_Out, m_checked HAVING        (m_id = " + Conversions.ToString(Module1.IDCUP) + ") AND (M_Tem_Out = 0) AND (m_checked = 0)";
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    if (oleDbDataReader2.Read())
                    {
                        this.Button2.Enabled = true;
                        this.Button3.Enabled = true;
                    }
                    else
                    {
                        this.Button2.Enabled = false;
                        this.Button3.Enabled = false;
                    }
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

        // Token: 0x06000B2B RID: 2859 RVA: 0x002EEA90 File Offset: 0x002ECE90
        private void DPP_CUP_Load(object sender, EventArgs e)
        {
            try
            {

                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(118, 33);
                    txtrate.Location = new Point(10, 33);

                    Label12.Text = "Amount";
                    Label11.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.txtid.Text = Conversions.ToString(Module1.IDCUP);
                this.txtnu.Text = Module1.decimalnumberformat;
                this.Panel5.Hide();

                this.txtpartyname.Text = Conversions.ToString(Module1.name1);
                this.CheckBox1.Checked = true;
                this.CheckBox1.Hide();
                this.listvieColumname();
                this.listlode();
                this.lastcheckposition();
                this.all_CUP_Lode();
                this.lod_newPartyname();
                this.Decleard();
                this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B2C RID: 2860 RVA: 0x002EEBB8 File Offset: 0x002ECFB8
        public void lod_newPartyname()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"])).ToString();
                    this.txtpartyname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"])).ToString();
                    this.cmbostus.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"])).ToString();
                    //this.smatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])).ToString();
                    //this.amatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])).ToString();
                    //this.tmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])).ToString();
                    //this.txtcomionhary.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[5])).ToString();
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

        // Token: 0x06000B2D RID: 2861 RVA: 0x002EED70 File Offset: 0x002ED170
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtpartyname.SelectionStart <= 1)
                        {
                            this.txtpartyname.Text = "";
                            return;
                        }
                        if (this.txtpartyname.SelectionLength == 0)
                        {
                            text = this.txtpartyname.Text.Substring(0, this.txtpartyname.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtpartyname.Text.Substring(0, this.txtpartyname.SelectionStart - 1);
                        }
                    }
                    else if (this.txtpartyname.SelectionLength == 0)
                    {
                        text = this.txtpartyname.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtpartyname.Text.Substring(0, this.txtpartyname.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtpartyname.FindString(text);
                    if (num != -1)
                    {
                        this.txtpartyname.SelectedText = "";
                        this.txtpartyname.SelectedIndex = num;
                        this.txtpartyname.SelectionStart = text.Length;
                        this.txtpartyname.SelectionLength = this.txtpartyname.Text.Length;
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

        // Token: 0x06000B2E RID: 2862 RVA: 0x002EEECC File Offset: 0x002ED2CC
        public void listlode()
        {
            checked
            {
                try
                {

                    this.DataGridView3.Rows.Clear();
                    string cmdText = string.Concat(new string[]
                    {
                        "SELECT m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, m_team5, m_team6, m_team7, m_team8, m_team9, m_team10, m_team11, m_team12, m_team13, m_team14, m_team15, m_modify, m_dt1, m_checked, m_s_share, Stus, M_Tem_Out, M_chk, modify_time, modify_date FROM CupTrans WHERE (m_id = ",
                        this.txtid.Text,
                        ") AND (m_party = '",
                        this.txtpartyname.Text,
                        "') ORDER BY m_eid DESC"
                    });
                    DataTable dtbcup = new DataTable();
                    using (CupService cupService = new CupService())
                    {
                        dtbcup = cupService.Get(cmdText);
                    }

                    this.DataGridView3.Rows.Add(dtbcup.Rows.Count);
                    for (int num = 0; num < dtbcup.Rows.Count; num++)
                    {
                        this.DataGridView3.Rows[num].Cells[1].Value = dtbcup.Rows[num]["m_eid"].ToString();
                        if (Module1.isratefirst == true)
                        {
                            this.DataGridView3.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_amt"].ToString()), this.txtnu.Text);
                            this.DataGridView3.Columns[3].HeaderText = "Amount";
                            this.DataGridView3.Rows[num].Cells[2].Value = Strings.Format(Conversion.Val(dtbcup.Rows[num]["m_rate"].ToString()), "0.0000");
                            this.DataGridView3.Columns[2].HeaderText = "Rate";
                        }
                        else
                        {
                            this.DataGridView3.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_amt"].ToString()), this.txtnu.Text);
                            this.DataGridView3.Rows[num].Cells[3].Value = Strings.Format(Conversion.Val(dtbcup.Rows[num]["m_rate"].ToString()), "0.0000");
                        }

                        this.DataGridView3.Rows[num].Cells[4].Value = dtbcup.Rows[num]["m_team"].ToString();
                        this.DataGridView3.Rows[num].Cells[5].Value = dtbcup.Rows[num]["m_mode"].ToString();
                        this.DataGridView3.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(dtbcup.Rows[num]["m_time"].ToString()), DateFormat.LongTime);
                        this.DataGridView3.Rows[num].Cells[7].Value = Strings.FormatDateTime(Conversions.ToDate(dtbcup.Rows[num]["m_dt"].ToString()), DateFormat.ShortDate);
                        this.DataGridView3.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team1"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team2"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team3"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team4"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team5"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team6"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team7"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team8"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[16].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team9"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[17].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team10"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[18].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team11"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[19].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team12"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[20].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team13"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[21].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team14"].ToString()), this.txtnu.Text);
                        this.DataGridView3.Rows[num].Cells[22].Value = Module1.SetNumFormat(Conversion.Val(dtbcup.Rows[num]["m_team15"].ToString()), this.txtnu.Text);

                        this.DataGridView3.Rows[num].Cells[23].Value = dtbcup.Rows[num]["modify_time"].ToString();
                        this.DataGridView3.Rows[num].Cells[24].Value = dtbcup.Rows[num]["modify_date"].ToString();

                        this.DataGridView3.Rows[num].Cells[4].Value = dtbcup.Rows[num]["m_team"].ToString();
                        this.DataGridView3.Rows[num].Cells[5].Value = dtbcup.Rows[num]["m_mode"].ToString();

                        if (Operators.CompareString(dtbcup.Rows[num]["m_checked"].ToString(), "1", false) == 0)
                        {
                            this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                            //this.DataGridView3.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                        }
                        else if (Operators.CompareString(dtbcup.Rows[num]["M_chk"].ToString(), "1", false) == 0)
                        {
                            this.DataGridView3.Rows[num].Cells[0].Value = true;
                            this.DataGridView3.Rows[num].DefaultCellStyle.BackColor = Color.LimeGreen;
                            this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if (Operators.CompareString(dtbcup.Rows[num]["m_modify"].ToString(), "1", false) == 0)
                        {
                            this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.CompareString(dtbcup.Rows[num]["M_Tem_Out"].ToString(), "1", false) == 0)
                        {
                            this.DataGridView3.Rows[num].DefaultCellStyle.ForeColor = Color.Fuchsia;
                        }
                    }

                    this.Label4.Text = "TOTAL ENTRY : " + Conversions.ToString(dtbcup.Rows.Count);
                    dtbcup.Dispose();
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x06000B2F RID: 2863 RVA: 0x002F10A0 File Offset: 0x002EF4A0
        public void all_CUP_Lode()
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
                    this.DataGridView1.Columns[0].HeaderText = oleDbDataReader[5].ToString();
                    this.DataGridView1.Columns[1].HeaderText = oleDbDataReader[6].ToString();
                    this.DataGridView1.Columns[2].HeaderText = oleDbDataReader[7].ToString();
                    this.DataGridView1.Columns[3].HeaderText = oleDbDataReader[8].ToString();
                    this.DataGridView1.Columns[4].HeaderText = oleDbDataReader[9].ToString();
                    this.DataGridView1.Columns[5].HeaderText = oleDbDataReader[10].ToString();
                    this.DataGridView1.Columns[6].HeaderText = oleDbDataReader[11].ToString();
                    this.DataGridView1.Columns[7].HeaderText = oleDbDataReader[12].ToString();
                    this.DataGridView1.Columns[8].HeaderText = oleDbDataReader[13].ToString();
                    this.DataGridView1.Columns[9].HeaderText = oleDbDataReader[14].ToString();
                    this.DataGridView1.Columns[10].HeaderText = oleDbDataReader[15].ToString();
                    this.DataGridView1.Columns[11].HeaderText = oleDbDataReader[16].ToString();
                    this.DataGridView1.Columns[12].HeaderText = oleDbDataReader[17].ToString();
                    this.DataGridView1.Columns[13].HeaderText = oleDbDataReader[18].ToString();
                    this.DataGridView1.Columns[14].HeaderText = oleDbDataReader[19].ToString();
                    this.DataGridView2.Columns[0].HeaderText = oleDbDataReader[5].ToString();
                    this.DataGridView2.Columns[1].HeaderText = oleDbDataReader[6].ToString();
                    this.DataGridView2.Columns[2].HeaderText = oleDbDataReader[7].ToString();
                    this.DataGridView2.Columns[3].HeaderText = oleDbDataReader[8].ToString();
                    this.DataGridView2.Columns[4].HeaderText = oleDbDataReader[9].ToString();
                    this.DataGridView2.Columns[5].HeaderText = oleDbDataReader[10].ToString();
                    this.DataGridView2.Columns[6].HeaderText = oleDbDataReader[11].ToString();
                    this.DataGridView2.Columns[7].HeaderText = oleDbDataReader[12].ToString();
                    this.DataGridView2.Columns[8].HeaderText = oleDbDataReader[13].ToString();
                    this.DataGridView2.Columns[9].HeaderText = oleDbDataReader[14].ToString();
                    this.DataGridView2.Columns[10].HeaderText = oleDbDataReader[15].ToString();
                    this.DataGridView2.Columns[11].HeaderText = oleDbDataReader[16].ToString();
                    this.DataGridView2.Columns[12].HeaderText = oleDbDataReader[17].ToString();
                    this.DataGridView2.Columns[13].HeaderText = oleDbDataReader[18].ToString();
                    this.DataGridView2.Columns[14].HeaderText = oleDbDataReader[19].ToString();
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

        // Token: 0x06000B30 RID: 2864 RVA: 0x002F1578 File Offset: 0x002EF978
        public void listvieColumname()
        {
            try
            {
                this.DataGridView1.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                    ""
                });
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtid.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.DataGridView3.Columns[8].HeaderText = oleDbDataReader[5].ToString();
                    this.DataGridView3.Columns[9].HeaderText = oleDbDataReader[6].ToString();
                    this.DataGridView3.Columns[10].HeaderText = oleDbDataReader[7].ToString();
                    this.DataGridView3.Columns[11].HeaderText = oleDbDataReader[8].ToString();
                    this.DataGridView3.Columns[12].HeaderText = oleDbDataReader[9].ToString();
                    this.DataGridView3.Columns[13].HeaderText = oleDbDataReader[10].ToString();
                    this.DataGridView3.Columns[14].HeaderText = oleDbDataReader[11].ToString();
                    this.DataGridView3.Columns[15].HeaderText = oleDbDataReader[12].ToString();
                    this.DataGridView3.Columns[16].HeaderText = oleDbDataReader[13].ToString();
                    this.DataGridView3.Columns[17].HeaderText = oleDbDataReader[14].ToString();
                    this.DataGridView3.Columns[18].HeaderText = oleDbDataReader[15].ToString();
                    this.DataGridView3.Columns[19].HeaderText = oleDbDataReader[16].ToString();
                    this.DataGridView3.Columns[20].HeaderText = oleDbDataReader[17].ToString();
                    this.DataGridView3.Columns[21].HeaderText = oleDbDataReader[18].ToString();
                    this.DataGridView3.Columns[22].HeaderText = oleDbDataReader[19].ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[5])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[6])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[7])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[8])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[9])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[10])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[11])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[12])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[13])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[14])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[15])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[16])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[17])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[18])).ToString();
                    this.txtteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[19])).ToString();
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

        // Token: 0x06000B31 RID: 2865 RVA: 0x002F1AD0 File Offset: 0x002EFED0
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listlode();
                this.dadagrid2_lode();
                this.lastcheckposition();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B32 RID: 2866 RVA: 0x002F1B18 File Offset: 0x002EFF18
        public void dadagrid2_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView2.Rows.Clear();
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.SCup, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9, SUM(CupTrans.m_team10)  AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15,  CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_id FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.SCup, CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_id HAVING (PartyMaster.PartyName = '",
                    this.txtpartyname.Text,
                    "') AND (CupTrans.m_checked <> 1) AND (CupTrans.M_Tem_Out <> 1) AND (CupTrans.m_id = ",
                    this.txtid.Text,
                    ")"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(oleDbDataReader["SCup"].ToString());
                    int index = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])), this.txtnu.Text);
                    double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])) * Conversion.Val(num) / 100;
                    num2 = Conversion.Val(num2) - Conversion.Val(num2) - Conversion.Val(num2);
                    double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])) * Conversion.Val(num) / 100;
                    num3 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
                    double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])) * Conversion.Val(num) / 100;
                    num4 = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
                    double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])) * Conversion.Val(num) / 100;
                    num5 = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                    double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])) * Conversion.Val(num) / 100;
                    num6 = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);
                    double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])) * Conversion.Val(num) / 100;
                    num7 = Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7);
                    double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])) * Conversion.Val(num) / 100;
                    num8 = Conversion.Val(num8) - Conversion.Val(num8) - Conversion.Val(num8);
                    double num9 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])) * Conversion.Val(num) / 100;
                    num9 = Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9);
                    double num10 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])) * Conversion.Val(num) / 100;
                    num10 = Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10);
                    double num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])) * Conversion.Val(num) / 100;
                    num11 = Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11);
                    double num12 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])) * Conversion.Val(num) / 100;
                    num12 = Conversion.Val(num12) - Conversion.Val(num12) - Conversion.Val(num12);
                    double num13 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])) * Conversion.Val(num) / 100;
                    num13 = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                    double num14 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])) * Conversion.Val(num) / 100;
                    num14 = Conversion.Val(num14) - Conversion.Val(num14) - Conversion.Val(num14);
                    double num15 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])) * Conversion.Val(num) / 100;
                    num15 = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                    double num16 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])) * Conversion.Val(num) / 100;
                    num16 = Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
                    int index2 = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index2].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num2), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                    this.DataGridView2.Rows[index2].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num16), this.txtnu.Text);
                    int index3 = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index3].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num2) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num3) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr2"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr3"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num5) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr4"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num6) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr5"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num7) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr6"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num8) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr7"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num9) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr8"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num10) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr9"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num11) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr10"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num12) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr11"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num13) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr12"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num14) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr13"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num15) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr14"])), this.txtnu.Text);
                    this.DataGridView2.Rows[index3].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num16) + Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr15"])), this.txtnu.Text);
                }
                int num17 = 0;
                checked
                {
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[0].Cells[num17].Value, 0, false))
                        {
                            this.DataGridView2.Rows[0].Cells[num17].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[0].Cells[num17].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[1].Cells[num17].Value, 0, false))
                        {
                            this.DataGridView2.Rows[1].Cells[num17].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[1].Cells[num17].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[2].Cells[num17].Value, 0, false))
                        {
                            this.DataGridView2.Rows[2].Cells[num17].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[2].Cells[num17].Style.ForeColor = Color.Green;
                        }
                        num17++;
                    }
                    while (num17 <= 14);
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

        // Token: 0x06000B33 RID: 2867 RVA: 0x002F30AC File Offset: 0x002F14AC
        private void Button6_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    int num = 0;
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[0].Cells[num].Value, 0, false))
                        {
                            this.DataGridView1.Rows[0].Cells[num].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[0].Cells[num].Style.ForeColor = Color.Green;
                        }
                        num++;
                    }
                    while (num <= 14);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
        }

        // Token: 0x06000B34 RID: 2868 RVA: 0x002F3170 File Offset: 0x002F1570
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = string.Concat(new string[]
                {
                    "select n.Team1,n.Name,n.Type,n.Date1,n.Sr_No,c.m_eid,c.m_amt,c.m_rate,c.m_team,c.m_mode,c.m_party from Newmatch n,CupTrans c where n.Sr_No=",
                    Conversions.ToString(Module1.IDCUP),
                    " and c.m_id=",
                    Conversions.ToString(Module1.IDCUP),
                    " and c.m_party='",
                    this.txtpartyname.Text,
                    "' and m_checked=0"
                });
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);

                //Add RPT
                //CupDPP cupDPP = new CupDPP();
                //cupDPP.SetDataSource(dataTable);
                //cupDPP.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\CupDPP.rpt");
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

        // Token: 0x06000B35 RID: 2869 RVA: 0x002F3274 File Offset: 0x002F1674
        private void Button5_Click(object sender, EventArgs e)
        {
            MyProject.Forms.CUP.Activate();
            this.Close();
        }

        // Token: 0x06000B36 RID: 2870 RVA: 0x002F32D0 File Offset: 0x002F16D0
        private void txtpartyname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                this.AutoComplete(ref comboBox, e, false);
                sender = comboBox;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B37 RID: 2871 RVA: 0x002F32F4 File Offset: 0x002F16F4
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmodify.Text, "", false) != 0)
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
                        this.txtmodify.Text,
                        " and m_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Can not edit this record?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = string.Concat(new string[]
                        {
                            "Select * from CupTrans  where  m_id=",
                            this.txtid.Text,
                            " and m_eid= ",
                            this.txtmodify.Text,
                            " and m_checked=0"
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        if (oleDbDataReader2.Read())
                        {
                            this.Panel5.Show();
                            this.txtmodify.Text = oleDbDataReader2[2].ToString();
                            this.txtpage.Text = oleDbDataReader2[3].ToString();
                            this.txtamount.Text = oleDbDataReader2[4].ToString();
                            this.txtrate.Text = oleDbDataReader2[5].ToString();
                            this.txtteam.Text = oleDbDataReader2[6].ToString();
                            this.txtmode.Text = oleDbDataReader2[7].ToString();
                            this.txtparty.Text = oleDbDataReader2[8].ToString();
                            this.cmbostus.Text = oleDbDataReader2["Stus"].ToString();
                            this.txttime.Text = oleDbDataReader2["m_time"].ToString();
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

        // Token: 0x06000B38 RID: 2872 RVA: 0x002F3570 File Offset: 0x002F1970
        public void K_AND_L_Value()
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

        // Token: 0x06000B39 RID: 2873 RVA: 0x002F3708 File Offset: 0x002F1B08
        public void Horse()
        {
            try
            {
                if (Operators.CompareString(this.DataGridView3.Columns[8].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtK.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[9].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtK.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView3.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView3.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtK.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B3A RID: 2874 RVA: 0x002F6F40 File Offset: 0x002F5340
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = string.Concat(new string[]
                {
                    "Select * from CupTrans  where  m_id=",
                    this.txtid.Text,
                    " and m_eid= ",
                    this.txtmodify.Text,
                    " and m_checked=1"
                });
                using (CupService cupService1 = new CupService())
                {
                    DataTable response;
                    response = cupService1.Get(cmdText);
                    if (response.Rows.Count > 0)
                    {
                        Interaction.MsgBox("Connot edit this record", MsgBoxStyle.OkOnly, null);
                        return;
                    }
                }

                cmdText = string.Concat(new string[]
               {
                        "delete from CupTrans  where  m_id=",
                        this.txtid.Text,
                        " and m_eid= ",
                        this.txtmodify.Text,
                        " "
               });
                using (CupService cupService2 = new CupService())
                {
                    cupService2.Update(cmdText);
                }
                this.K_AND_L_Value();
                this.Horse();
                cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO CupTrans(m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, m_team5, m_team6, m_team7, m_team8, m_team9, m_team10, m_team11, m_team12, m_team13, m_team14, m_team15, m_modify, m_dt1, m_checked, m_s_share, Stus, M_Tem_Out, M_chk) VALUES(" + this.txtid.Text + "," + this.txtmodify.Text + ",'" + this.txtpage.Text + "'," + this.txtamount.Text + ",'" + this.txtrate.Text + "','" + this.txtteam.Text + "','" + this.txtmode.Text + "','" + this.txtparty.Text + "','" + Conversions.ToString(DateAndTime.Now.Date) + "','" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "','", this.h1), "','"), this.h2), "','"), this.h3), "','"), this.h4), "','"), this.h5), "','"), this.h6), "','"), this.h7), "','"), this.h8), "','"), this.h9), "','"), this.h10), "','"), this.h11), "','"), this.h12), "','"), this.h13), "','"), this.h14), "','"), this.h15), "',1,'"), this.txttime.Text), "',0,'0','"), this.cmbostus.Text), "',0,0)"));
                using (CupService cupService = new CupService())
                {
                    cupService.Update(cmdText);
                }
                this.txtpartyname.Text = this.txtparty.Text;
                bindGrid();

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private async void bindGrid()
        {
            this.listlode();
            this.dadagrid2_lode();
            this.lastcheckposition();
            this.Panel5.Hide();
        }

        // Token: 0x06000B3B RID: 2875 RVA: 0x002F7368 File Offset: 0x002F5768
        private void txtparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbostus.SelectedIndex = this.txtparty.SelectedIndex;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B3C RID: 2876 RVA: 0x002F7380 File Offset: 0x002F5780
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Operators.CompareString(this.txtmodify.Text, null, false) != 0)
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
                        this.txtmodify.Text,
                        " and m_checked=1"
                        });
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            Interaction.MsgBox("Con not Delete this record ", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            Module1.conn.Close();
                            string cmdText2 = $"update CupTrans set m_checked=1, modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where m_id={this.txtid.Text} and m_eid={this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText2);
                            }
                            bindGrid();
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

        // Token: 0x06000B3D RID: 2877 RVA: 0x002F74FC File Offset: 0x002F58FC
        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel5.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B3E RID: 2878 RVA: 0x002F7518 File Offset: 0x002F5918
        public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtparty.SelectionStart <= 1)
                        {
                            this.txtparty.Text = "";
                            return;
                        }
                        if (this.txtparty.SelectionLength == 0)
                        {
                            text = this.txtparty.Text.Substring(0, this.txtparty.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart - 1);
                        }
                    }
                    else if (this.txtparty.SelectionLength == 0)
                    {
                        text = this.txtparty.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtparty.FindString(text);
                    if (num != -1)
                    {
                        this.txtparty.SelectedText = "";
                        this.txtparty.SelectedIndex = num;
                        this.txtparty.SelectionStart = text.Length;
                        this.txtparty.SelectionLength = this.txtparty.Text.Length;
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

        // Token: 0x06000B3F RID: 2879 RVA: 0x002F7674 File Offset: 0x002F5A74
        private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtparty = this.txtparty;
                this.AutoComplete11(ref txtparty, e, false);
                this.txtparty = txtparty;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B41 RID: 2881 RVA: 0x002F76B4 File Offset: 0x002F5AB4
        private void txtpartyname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                try
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        this.listlode();
                        this.dadagrid2_lode();
                        this.lastcheckposition();
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
            }
        }

        // Token: 0x06000B42 RID: 2882 RVA: 0x002F7744 File Offset: 0x002F5B44
        private void DPP_CUP_KeyDown(object sender, KeyEventArgs e)
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
            }
        }

        // Token: 0x06000B43 RID: 2883 RVA: 0x002F7798 File Offset: 0x002F5B98
        private void DPP_CUP_Activated(object sender, EventArgs e)
        {
            this.txtpartyname.Focus();
        }

        // Token: 0x06000B44 RID: 2884 RVA: 0x002F77A8 File Offset: 0x002F5BA8
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
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

                        double num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0, num12 = 0, num13 = 0, num14 = 0, num15 = 0, num16 = 0, num17 = 0;

                        for (int i = 0; i <= this.DataGridView3.Rows.Count - 1; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[0].Value, true, false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[11].Value));
                                    num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[12].Value));
                                    num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[13].Value));
                                    num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[14].Value));
                                    num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[15].Value));
                                    num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[16].Value));
                                    num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[17].Value));
                                    num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[18].Value));
                                    num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[19].Value));
                                    num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[20].Value));
                                    num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[21].Value));
                                    num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[22].Value));
                                }
                            }
                        }
                        this.DataGridView1.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num16), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, true, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = $"UPDATE CupTrans SET M_chk = 1 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.DataGridView3.CurrentRow.Cells[1].Value.ToString()}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
                            }

                            this.DataGridView3.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, false, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = $"UPDATE CupTrans SET M_chk = 0 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.DataGridView3.CurrentRow.Cells[1].Value.ToString()}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
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
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        public void lastcheckposition()
        {
            try
            {
                double num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0, num12 = 0, num13 = 0, num14 = 0, num15 = 0, num16 = 0, num17 = 0;
                for (int i = 0; i <= this.DataGridView3.Rows.Count - 1; i++)
                {
                    unchecked
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[0].Value, true, false))
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[8].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[9].Value));
                            num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[10].Value));
                            num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[11].Value));
                            num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[12].Value));
                            num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[13].Value));
                            num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[14].Value));
                            num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[15].Value));
                            num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[16].Value));
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[17].Value));
                            num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[18].Value));
                            num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[19].Value));
                            num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[20].Value));
                            num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[21].Value));
                            num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[22].Value));

                            this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGreen;
                        }
                    }
                }
                this.DataGridView1.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num16), this.txtnu.Text);
                this.DataGridView1.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B45 RID: 2885 RVA: 0x002F8130 File Offset: 0x002F6530
        private void Button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    double num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0, num12 = 0, num13 = 0, num14 = 0, num15 = 0, num16 = 0, num17 = 0;
                    for (int i = 0; i <= this.DataGridView3.Rows.Count - 1; i++)
                    {
                        this.DataGridView3.Rows[i].Cells[0].Value = true;
                        unchecked
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[0].Value, true, false))
                            {
                                num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[8].Value));
                                num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[9].Value));
                                num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[10].Value));
                                num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[11].Value));
                                num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[12].Value));
                                num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[13].Value));
                                num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[14].Value));
                                num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[15].Value));
                                num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[16].Value));
                                num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[17].Value));
                                num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[18].Value));
                                num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[19].Value));
                                num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[20].Value));
                                num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[21].Value));
                                num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[22].Value));
                                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE CupTrans SET M_chk = 1 WHERE (CupTrans.m_id = " + this.txtid.Text + ") AND (CupTrans.m_eid = ", this.DataGridView3.Rows[i].Cells[1].Value), ")"));
                                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                oleDbCommand.ExecuteNonQuery();
                                this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGreen;
                            }
                        }
                    }
                    this.DataGridView1.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num16), this.txtnu.Text);
                    this.DataGridView1.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
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

        // Token: 0x06000B46 RID: 2886 RVA: 0x002F8990 File Offset: 0x002F6D90
        private void DataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView3.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000B47 RID: 2887 RVA: 0x002F8A1C File Offset: 0x002F6E1C
        private void DataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView3.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView3.CurrentRow.Cells[0].Value = true;
                        }

                        double num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0, num12 = 0, num13 = 0, num14 = 0, num15 = 0, num16 = 0, num17 = 0;
                        for (int i = 0; i <= this.DataGridView3.Rows.Count - 1; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[0].Value, true, false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[11].Value));
                                    num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[12].Value));
                                    num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[13].Value));
                                    num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[14].Value));
                                    num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[15].Value));
                                    num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[16].Value));
                                    num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[17].Value));
                                    num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[18].Value));
                                    num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[19].Value));
                                    num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[20].Value));
                                    num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[21].Value));
                                    num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[i].Cells[22].Value));
                                }
                            }
                        }
                        this.DataGridView1.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num16), this.txtnu.Text);
                        this.DataGridView1.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, true, false))
                        {
                            string cmdText = $"UPDATE CupTrans SET M_chk = 1 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
                            }
                            this.DataGridView3.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, false, false))
                        {
                            string cmdText = $"UPDATE CupTrans SET M_chk = 0 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
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
        }

        // Token: 0x0400046B RID: 1131
        private object h1;

        // Token: 0x0400046C RID: 1132
        private object h2;

        // Token: 0x0400046D RID: 1133
        private object h3;

        // Token: 0x0400046E RID: 1134
        private object h4;

        // Token: 0x0400046F RID: 1135
        private object h5;

        // Token: 0x04000470 RID: 1136
        private object h6;

        // Token: 0x04000471 RID: 1137
        private object h7;

        // Token: 0x04000472 RID: 1138
        private object h8;

        // Token: 0x04000473 RID: 1139
        private object h9;

        // Token: 0x04000474 RID: 1140
        private object h10;

        // Token: 0x04000475 RID: 1141
        private object h11;

        // Token: 0x04000476 RID: 1142
        private object h12;

        // Token: 0x04000477 RID: 1143
        private object h13;

        // Token: 0x04000478 RID: 1144
        private object h14;

        // Token: 0x04000479 RID: 1145
        private object h15;

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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtmode.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtmode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtparty.Focus();
                    this.txtparty.SelectAll();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtparty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.Button11.Focus();
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
                    this.txtrate.Text = Module1.SetNumFormat(Conversion.Val(this.txtrate.Text), this.txtnu.Text);
                }
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
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), Module1.decimalnumberformat);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
    }
}
