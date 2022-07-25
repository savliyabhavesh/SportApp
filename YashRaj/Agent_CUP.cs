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
using YashAksh.My;
using App.Service;

namespace YashAksh
{
    // Token: 0x0200000A RID: 10
    //[DesignerGenerated]
    public partial class Agent_CUP : Form
    {
        // Token: 0x06000266 RID: 614 RVA: 0x0028B67C File Offset: 0x00289A7C
        public Agent_CUP()
        {
            this.a = 0.0;
            this.InitializeComponent();
        }


        // Token: 0x06000368 RID: 872 RVA: 0x002905DC File Offset: 0x0028E9DC
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT m_id, m_checked FROM CupTrans WHERE (m_checked = 0) AND (m_id = " + Conversions.ToString(Module1.IDCUP) + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    string cmdText2 = "SELECT m_id, COUNT(m_team) AS Expr1, M_Tem_Out, m_checked FROM CupTrans GROUP BY m_id, M_Tem_Out, m_checked HAVING (m_id = " + Conversions.ToString(Module1.IDCUP) + ") AND (M_Tem_Out = 0) AND (m_checked = 0)";
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

        // Token: 0x06000369 RID: 873 RVA: 0x002906D8 File Offset: 0x0028EAD8
        private void Agent_CUP_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtid.Text = Conversions.ToString(Module1.IDCUP);
                this.txtnu.Text = Module1.decimalnumberformat;
                this.Panel5.Hide();
                this.ComboBox1.Focus();
                this.CheckBox1.Checked = true;
                this.CheckBox1.Hide();
                this.listvieColumname();
                this.listlode();
                this.all_CUP_Lode();
                this.lod_newPartyname();
                this.Decleard();
                this.ComboBox1.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600036A RID: 874 RVA: 0x002907F4 File Offset: 0x0028EBF4
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
                this.ComboBox1.Items.Clear();
                while (oleDbDataReader.Read())
                {
                    this.ComboBox1.Items.Add(oleDbDataReader["PartyName"].ToString());
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

        // Token: 0x0600036B RID: 875 RVA: 0x002908B4 File Offset: 0x0028ECB4
        public void listlode()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                if (Operators.CompareString(this.ComboBox1.Text, null, false) != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "SELECT PartyMaster.PartyName, PartyMaster.TParty, CupTrans.id, CupTrans.m_id, CupTrans.m_eid, CupTrans.m_page, CupTrans.m_amt, CupTrans.m_rate, CupTrans.m_team, CupTrans.m_mode, CupTrans.m_party, CupTrans.m_dt, CupTrans.m_time, CupTrans.m_team1, CupTrans.m_team2, CupTrans.m_team3, CupTrans.m_team4, CupTrans.m_team5, CupTrans.m_team6, CupTrans.m_team7, CupTrans.m_team8,CupTrans.m_team9, CupTrans.m_team10, CupTrans.m_team11, CupTrans.m_team12, CupTrans.m_team13, CupTrans.m_team14, CupTrans.m_team15, CupTrans.m_modify, CupTrans.m_dt1,CupTrans.m_checked, CupTrans.m_s_share, CupTrans.Stus, CupTrans.M_Tem_Out, CupTrans.M_chk, PartyMaster.TMatch, PartyMaster.AParty, PartyMaster.AMatch, PartyMaster.SMatch FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) WHERE (PartyMaster.AParty = '",
                        this.ComboBox1.Text,
                        "') AND (CupTrans.m_id = ",
                        this.txtid.Text,
                        ") OR (PartyMaster.PartyName = '",
                        this.ComboBox1.Text,
                        "') OR (PartyMaster.TParty = '",
                        this.ComboBox1.Text,
                        "')ORDER BY CupTrans.m_eid DESC"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
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
                    double num18 = 0;
                    double num19 = 0;
                    double num20 = 0;
                    while (oleDbDataReader.Read())
                    {
                        if (Operators.CompareString(oleDbDataReader["m_id"].ToString(), this.txtid.Text, false) == 0)
                        {
                            checked
                            {
                                if (Operators.CompareString(oleDbDataReader["m_checked"].ToString(), "1", false) == 0)
                                {
                                    int num = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[num].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                                    this.DataGridView5.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_rate"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                                    this.DataGridView5.Rows[num].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                                    this.DataGridView5.Rows[num].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                                    this.DataGridView5.Rows[num].Cells[7].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_dt"].ToString()), DateFormat.ShortDate);
                                    this.DataGridView5.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team5"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team6"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team7"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team8"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[16].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team9"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[17].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team10"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[18].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team11"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[19].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team12"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[20].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team13"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[21].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team14"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].Cells[22].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team15"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                                    this.a = (double)(num + 1);
                                }
                                else if (Operators.CompareString(oleDbDataReader["M_chk"].ToString(), "1", false) == 0)
                                {
                                    int num2 = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[num2].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                                    this.DataGridView5.Rows[num2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_rate"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                                    this.DataGridView5.Rows[num2].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                                    this.DataGridView5.Rows[num2].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                                    this.DataGridView5.Rows[num2].Cells[7].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_dt"].ToString()), DateFormat.ShortDate);
                                    this.DataGridView5.Rows[num2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team5"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team6"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team7"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team8"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[16].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team9"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[17].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team10"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[18].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team11"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[19].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team12"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[20].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team13"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[21].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team14"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[22].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team15"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num2].Cells[0].Value = true;
                                    this.DataGridView5.Rows[num2].DefaultCellStyle.BackColor = Color.LimeGreen;
                                    this.DataGridView5.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
                                    this.a = (double)(num2 + 1);
                                }
                                else if (Operators.CompareString(oleDbDataReader["M_Tem_Out"].ToString(), "1", false) == 0)
                                {
                                    int num3 = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[num3].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                                    this.DataGridView5.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_rate"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                                    this.DataGridView5.Rows[num3].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                                    this.DataGridView5.Rows[num3].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                                    this.DataGridView5.Rows[num3].Cells[7].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_dt"].ToString()), DateFormat.ShortDate);
                                    this.DataGridView5.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team5"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team6"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team7"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team8"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[16].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team9"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[17].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team10"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[18].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team11"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[19].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team12"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[20].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team13"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[21].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team14"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].Cells[22].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team15"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num3].DefaultCellStyle.ForeColor = Color.Fuchsia;
                                    this.a = (double)(num3 + 1);
                                }
                                else if (Operators.CompareString(oleDbDataReader["m_modify"].ToString(), "1", false) == 0)
                                {
                                    int num4 = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[num4].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                                    this.DataGridView5.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_rate"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                                    this.DataGridView5.Rows[num4].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                                    this.DataGridView5.Rows[num4].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                                    this.DataGridView5.Rows[num4].Cells[7].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_dt"].ToString()), DateFormat.ShortDate);
                                    this.DataGridView5.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team5"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team6"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team7"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team8"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[16].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team9"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[17].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team10"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[18].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team11"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[19].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team12"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[20].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team13"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[21].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team14"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].Cells[22].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team15"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num4].DefaultCellStyle.ForeColor = Color.Blue;
                                    this.a = (double)(num4 + 1);
                                }
                                else
                                {
                                    int num5 = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[num5].Cells[1].Value = oleDbDataReader["m_eid"].ToString();
                                    this.DataGridView5.Rows[num5].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_amt"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_rate"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[4].Value = oleDbDataReader["m_team"].ToString();
                                    this.DataGridView5.Rows[num5].Cells[5].Value = oleDbDataReader["m_mode"].ToString();
                                    this.DataGridView5.Rows[num5].Cells[6].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_time"].ToString()), DateFormat.LongTime);
                                    this.DataGridView5.Rows[num5].Cells[7].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["m_dt"].ToString()), DateFormat.ShortDate);
                                    this.DataGridView5.Rows[num5].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team1"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team2"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team3"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team4"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team5"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team6"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team7"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[15].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team8"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[16].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team9"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[17].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team10"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[18].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team11"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[19].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team12"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[20].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team13"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[21].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team14"].ToString()), this.txtnu.Text);
                                    this.DataGridView5.Rows[num5].Cells[22].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["m_team15"].ToString()), this.txtnu.Text);
                                    this.a = (double)(num5 + 1);
                                }
                            }
                            if (Operators.CompareString(oleDbDataReader["M_Tem_Out"].ToString(), "1", false) != 0)
                            {
                                if (Operators.CompareString(oleDbDataReader["m_checked"].ToString(), "1", false) != 0)
                                {
                                    if (Operators.CompareString(oleDbDataReader["PartyName"].ToString(), this.ComboBox1.Text, false) == 0)
                                    {
                                        num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num16 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num17 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num18 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num19 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                        num20 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"])) / 100);
                                    }
                                    if (Operators.CompareString(oleDbDataReader["TParty"].ToString(), this.ComboBox1.Text, false) == 0)
                                    {
                                        num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num16 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num17 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num18 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num19 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                        num20 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"])) / 100);
                                    }
                                    if (Operators.CompareString(oleDbDataReader["AParty"].ToString(), this.ComboBox1.Text, false) == 0)
                                    {
                                        num6 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team1"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num7 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team2"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num8 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team3"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num9 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team4"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num10 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team5"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num11 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team6"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num12 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team7"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num13 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team8"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num14 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team9"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num15 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team10"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num16 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team11"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num17 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team12"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num18 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team13"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num19 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team14"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                        num20 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["m_team15"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"])) / 100);
                                    }
                                }
                            }
                        }
                    }
                    this.Label4.Text = "TOTAL ENTRY : " + Conversions.ToString(this.a);
                    this.DataGridView2.Rows.Clear();
                    this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows.Add();
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
                    num16 = Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
                    num17 = Conversion.Val(num17) - Conversion.Val(num17) - Conversion.Val(num17);
                    num18 = Conversion.Val(num18) - Conversion.Val(num18) - Conversion.Val(num18);
                    num19 = Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19);
                    num20 = Conversion.Val(num20) - Conversion.Val(num20) - Conversion.Val(num20);
                    this.DataGridView2.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num7), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num8), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num9), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num10), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num11), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num12), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num13), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num14), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num15), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num16), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num17), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num18), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num19), this.txtnu.Text);
                    this.DataGridView2.Rows[1].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num20), this.txtnu.Text);
                    int num21 = 0;
                    checked
                    {
                        do
                        {
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[1].Cells[num21].Value, 0, false))
                            {
                                this.DataGridView2.Rows[1].Cells[num21].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView2.Rows[1].Cells[num21].Style.ForeColor = Color.Green;
                            }
                            num21++;
                        }
                        while (num21 <= 14);
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

        // Token: 0x0600036C RID: 876 RVA: 0x00293EA0 File Offset: 0x002922A0
        public void all_CUP_Lode()
        {
            try
            {
                this.DataGridView1.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
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

        // Token: 0x0600036D RID: 877 RVA: 0x00294408 File Offset: 0x00292808
        public void listvieColumname()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtid.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.DataGridView5.Columns[8].HeaderText = oleDbDataReader[5].ToString();
                    this.DataGridView5.Columns[9].HeaderText = oleDbDataReader[6].ToString();
                    this.DataGridView5.Columns[10].HeaderText = oleDbDataReader[7].ToString();
                    this.DataGridView5.Columns[11].HeaderText = oleDbDataReader[8].ToString();
                    this.DataGridView5.Columns[12].HeaderText = oleDbDataReader[9].ToString();
                    this.DataGridView5.Columns[13].HeaderText = oleDbDataReader[10].ToString();
                    this.DataGridView5.Columns[14].HeaderText = oleDbDataReader[11].ToString();
                    this.DataGridView5.Columns[15].HeaderText = oleDbDataReader[12].ToString();
                    this.DataGridView5.Columns[16].HeaderText = oleDbDataReader[13].ToString();
                    this.DataGridView5.Columns[17].HeaderText = oleDbDataReader[14].ToString();
                    this.DataGridView5.Columns[18].HeaderText = oleDbDataReader[15].ToString();
                    this.DataGridView5.Columns[19].HeaderText = oleDbDataReader[16].ToString();
                    this.DataGridView5.Columns[20].HeaderText = oleDbDataReader[17].ToString();
                    this.DataGridView5.Columns[21].HeaderText = oleDbDataReader[18].ToString();
                    this.DataGridView5.Columns[22].HeaderText = oleDbDataReader[19].ToString();
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

        // Token: 0x0600036E RID: 878 RVA: 0x00294918 File Offset: 0x00292D18
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listlode();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600036F RID: 879 RVA: 0x0029495C File Offset: 0x00292D5C
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
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

        // Token: 0x06000370 RID: 880 RVA: 0x00294AB8 File Offset: 0x00292EB8
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                CUP cUP = new CUP();
                cUP.MdiParent = this.MdiParent;
                cUP.WindowState = FormWindowState.Maximized;
                cUP.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000371 RID: 881 RVA: 0x00294B14 File Offset: 0x00292F14
        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox comboBox = this.ComboBox1;
                this.AutoComplete(ref comboBox, e, false);
                this.ComboBox1 = comboBox;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000372 RID: 882 RVA: 0x00294B3C File Offset: 0x00292F3C
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
                        "Select * from CupTrans where  m_id=",
                        this.txtid.Text,
                        " and m_eid= ",
                        this.txtmodify.Text,
                        " and m_checked=1"
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
                            "Select * from CupTrans where  m_id=",
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
                            this.txtmodify.Text = Conversions.ToString(oleDbDataReader2[2]);
                            this.txtpage.Text = Conversions.ToString(oleDbDataReader2[3]);
                            this.txtamount.Text = Conversions.ToString(oleDbDataReader2[4]);
                            this.txtrate.Text = Conversions.ToString(oleDbDataReader2[5]);
                            this.txtteam.Text = Conversions.ToString(oleDbDataReader2[6]);
                            this.txtmode.Text = Conversions.ToString(oleDbDataReader2[7]);
                            this.txtparty.Text = Conversions.ToString(oleDbDataReader2[8]);
                            this.cmbostus.Text = Conversions.ToString(oleDbDataReader2["Stus"]);
                            this.txttime.Text = Conversions.ToString(oleDbDataReader2["m_time"]);
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

        // Token: 0x06000373 RID: 883 RVA: 0x00294DB8 File Offset: 0x002931B8
        private void Button11_Click(object sender, EventArgs e)
        {
            try
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
                    this.txtmodify.Text,
                    " and m_checked=1"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    Interaction.MsgBox("Connot edit this record", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    cmdText = $"delete from CupTrans where m_id= {this.txtid.Text} and m_eid= {this.txtmodify.Text}";
                    using (CupService cupService = new CupService())
                    {
                        cupService.Update(cmdText);
                    }
                        this.K_AND_L_Value();
                    this.Horse();
                    cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO CupTrans(m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, m_team5, m_team6, m_team7, m_team8, m_team9, m_team10, m_team11, m_team12, m_team13, m_team14, m_team15, m_modify, m_dt1, m_checked, m_s_share, Stus, M_Tem_Out, M_chk) VALUES(" + this.txtid.Text + "," + this.txtmodify.Text + ",'" + this.txtpage.Text + "'," + this.txtamount.Text + ",'" + this.txtrate.Text + "','" + this.txtteam.Text + "','" + this.txtmode.Text + "','" + this.txtparty.Text + "','" + Conversions.ToString(DateAndTime.Now.Date) + "','" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "','", this.h1), "','"), this.h2), "','"), this.h3), "','"), this.h4), "','"), this.h5), "','"), this.h6), "','"), this.h7), "','"), this.h8), "','"), this.h9), "','"), this.h10), "','"), this.h11), "','"), this.h12), "','"), this.h13), "','"), this.h14), "','"), this.h15), "',1,'"), this.txttime.Text), "',0,'0','"), this.cmbostus.Text), "',0,0)"));
                    using (CupService cupService1 = new CupService())
                    {
                        cupService1.Update(cmdText);
                    }
                        this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.Panel5.Hide();
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

        // Token: 0x06000374 RID: 884 RVA: 0x002951C8 File Offset: 0x002935C8
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

        // Token: 0x06000375 RID: 885 RVA: 0x00295360 File Offset: 0x00293760
        public void Horse()
        {
            try
            {
                if (Operators.CompareString(this.DataGridView5.Columns[8].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtK.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[9].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtK.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtK.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
                    {
                        this.h15 = "0";
                    }
                    else
                    {
                        this.h15 = this.txtL.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, this.txtteam.Text, false) == 0)
                {
                    this.h1 = this.txtL.Text;
                    this.h2 = this.txtL.Text;
                    if (Operators.CompareString(this.DataGridView5.Columns[10].HeaderText, "", false) == 0)
                    {
                        this.h3 = "0";
                    }
                    else
                    {
                        this.h3 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[11].HeaderText, "", false) == 0)
                    {
                        this.h4 = "0";
                    }
                    else
                    {
                        this.h4 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[12].HeaderText, "", false) == 0)
                    {
                        this.h5 = "0";
                    }
                    else
                    {
                        this.h5 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[13].HeaderText, "", false) == 0)
                    {
                        this.h6 = "0";
                    }
                    else
                    {
                        this.h6 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[14].HeaderText, "", false) == 0)
                    {
                        this.h7 = "0";
                    }
                    else
                    {
                        this.h7 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[15].HeaderText, "", false) == 0)
                    {
                        this.h8 = "0";
                    }
                    else
                    {
                        this.h8 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[16].HeaderText, "", false) == 0)
                    {
                        this.h9 = "0";
                    }
                    else
                    {
                        this.h9 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[17].HeaderText, "", false) == 0)
                    {
                        this.h10 = "0";
                    }
                    else
                    {
                        this.h10 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[18].HeaderText, "", false) == 0)
                    {
                        this.h11 = "0";
                    }
                    else
                    {
                        this.h11 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[19].HeaderText, "", false) == 0)
                    {
                        this.h12 = "0";
                    }
                    else
                    {
                        this.h12 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[20].HeaderText, "", false) == 0)
                    {
                        this.h13 = "0";
                    }
                    else
                    {
                        this.h13 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[21].HeaderText, "", false) == 0)
                    {
                        this.h14 = "0";
                    }
                    else
                    {
                        this.h14 = this.txtL.Text;
                    }
                    if (Operators.CompareString(this.DataGridView5.Columns[22].HeaderText, "", false) == 0)
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

        // Token: 0x06000376 RID: 886 RVA: 0x00298B98 File Offset: 0x00296F98
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

        // Token: 0x06000377 RID: 887 RVA: 0x00298BB4 File Offset: 0x00296FB4
        private void Button3_Click(object sender, EventArgs e)
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
                        "Select * from CupTrans where m_id=",
                        this.txtid.Text,
                        " and m_eid= ",
                        this.txtmodify.Text,
                        " and m_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Connot Delete this record", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = $"update CupTrans set m_checked=1 where m_id= {this.txtid.Text}  and m_eid={this.txtmodify.Text}";
                        using (CupService cupService = new CupService())
                        {
                            cupService.Update(cmdText2);
                        }
                            this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

        // Token: 0x06000378 RID: 888 RVA: 0x00298D34 File Offset: 0x00297134
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    if (Operators.CompareString(this.ComboBox1.Text, null, false) != 0)
                    {
                        this.ListView2.Items.Clear();
                        mareport mareport = new mareport();
                        DataSet dataSet = new DataSet();
                        dataSet.Tables.Add("ListViewData");
                        DataColumnCollection columns = dataSet.Tables[0].Columns;
                        columns.Add("Sr_No", Type.GetType("System.String"));
                        columns.Add("Amount", Type.GetType("System.String"));
                        columns.Add("Rate", Type.GetType("System.String"));
                        columns.Add("Favour", Type.GetType("System.String"));
                        columns.Add("Mode", Type.GetType("System.String"));
                        columns.Add("name", Type.GetType("System.String"));
                        int num = 0;
                        int num2 = this.DataGridView5.Rows.Count - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            DataRow dataRow = dataSet.Tables[0].NewRow();
                            dataRow[0] = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[1].Value);
                            dataRow[1] = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[2].Value);
                            dataRow[2] = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[3].Value);
                            dataRow[3] = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[4].Value);
                            dataRow[4] = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[5].Value);
                            dataRow[5] = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[6].Value);
                            dataSet.Tables[0].Rows.Add(dataRow);
                        }
                        mareport.SetDataSource(dataSet);
                        mareport.PrintToPrinter(0, false, 0, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000379 RID: 889 RVA: 0x00298F9C File Offset: 0x0029739C
        public void listlode_print()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600037A RID: 890 RVA: 0x00298FEC File Offset: 0x002973EC
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

        // Token: 0x0600037B RID: 891 RVA: 0x00299148 File Offset: 0x00297548
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

        // Token: 0x0600037C RID: 892 RVA: 0x00299160 File Offset: 0x00297560
        public void dadagrid2_lode1()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows.Add();
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "SELECT PartyName, SMatch, AParty, AMatch, TParty, TMatch FROM PartyMaster GROUP BY PartyName, SMatch, AParty, AMatch, TParty, TMatch HAVING (TParty = '" + this.ComboBox1.Text + "')";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT PartyMaster.PartyName, PartyMaster.SMatch, SUM(CupTrans.m_team1) AS Expr1, SUM(CupTrans.m_team2) AS Expr2, SUM(CupTrans.m_team3) AS Expr3, SUM(CupTrans.m_team4) AS Expr4, SUM(CupTrans.m_team5) AS Expr5, SUM(CupTrans.m_team6) AS Expr6, SUM(CupTrans.m_team7) AS Expr7, SUM(CupTrans.m_team8) AS Expr8, SUM(CupTrans.m_team9) AS Expr9, SUM(CupTrans.m_team10)  AS Expr10, SUM(CupTrans.m_team11) AS Expr11, SUM(CupTrans.m_team12) AS Expr12, SUM(CupTrans.m_team13) AS Expr13, SUM(CupTrans.m_team14) AS Expr14, SUM(CupTrans.m_team15) AS Expr15, CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_id FROM (PartyMaster INNER JOIN CupTrans ON PartyMaster.PartyName = CupTrans.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.SMatch, CupTrans.m_checked, CupTrans.M_Tem_Out, CupTrans.m_id HAVING (PartyMaster.PartyName = '", oleDbDataReader["PartyName"]), "') AND (CupTrans.m_checked <> 1) AND (CupTrans.M_Tem_Out <> 1) AND (CupTrans.m_id = "), this.txtid.Text), ")"));
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        while (oleDbDataReader2.Read())
                        {
                            double num = Convert.ToDouble(oleDbDataReader2["SMatch"]);
                            double num2 = Convert.ToDouble(oleDbDataReader["TMatch"]);
                            double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"]));
                            double num4 = Conversion.Val(num2) * Conversion.Val(num3) / 100;
                            double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"]));
                            double num6 = Conversion.Val(num2) * Conversion.Val(num5) / 100;
                            double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"]));
                            double num8 = Conversion.Val(num2) * Conversion.Val(num7) / 100;
                            double num9 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"]));
                            double num10 = Conversion.Val(num2) * Conversion.Val(num9) / 100;
                            double num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr5"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr5"]));
                            double num12 = Conversion.Val(num2) * Conversion.Val(num11) / 100;
                            double num13 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr6"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr6"]));
                            double num14 = Conversion.Val(num2) * Conversion.Val(num13) / 100;
                            double num15 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr7"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr7"]));
                            double num16 = Conversion.Val(num2) * Conversion.Val(num15) / 100;
                            double num17 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr8"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr8"]));
                            double num18 = Conversion.Val(num2) * Conversion.Val(num17) / 100;
                            double num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr9"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr9"]));
                            double num20 = Conversion.Val(num2) * Conversion.Val(num19) / 100;
                            double num21 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr10"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr10"]));
                            double num22 = Conversion.Val(num2) * Conversion.Val(num21) / 100;
                            double num23 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr11"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr11"]));
                            double num24 = Conversion.Val(num2) * Conversion.Val(num23) / 100;
                            double num25 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr12"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr12"]));
                            double num26 = Conversion.Val(num2) * Conversion.Val(num25) / 100;
                            double num27 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr13"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr13"]));
                            double num28 = Conversion.Val(num2) * Conversion.Val(num27) / 100;
                            double num29 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr14"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr14"]));
                            double num30 = Conversion.Val(num2) * Conversion.Val(num29) / 100;
                            double num31 = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr15"])) * Conversion.Val(num) / 100 - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr15"]));
                            double num32 = Conversion.Val(num2) * Conversion.Val(num31) / 100;
                            this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[0].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr2"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[1].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr3"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[2].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr4"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[3].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr5"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[4].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr6"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[5].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr7"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[6].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr8"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[7].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr9"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[8].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr10"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[9].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr11"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[10].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr12"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[11].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr13"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[12].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr14"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[13].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[0].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr15"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[14].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num4) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[0].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num6) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[1].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num8) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[2].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num10) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[3].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num12) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[4].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num14) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[5].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num16) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[6].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[7].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num20) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[8].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num22) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[9].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num24) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[10].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num26) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[11].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num28) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[12].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num30) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[13].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[1].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num32) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[14].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3) + Conversion.Val(num4) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[0].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5) + Conversion.Val(num6) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[1].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7) + Conversion.Val(num8) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[2].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9) + Conversion.Val(num10) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[3].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num11) - Conversion.Val(num11) - Conversion.Val(num11) + Conversion.Val(num12) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[4].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13) + Conversion.Val(num14) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[5].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15) + Conversion.Val(num16) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[6].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(num17) - Conversion.Val(num17) - Conversion.Val(num17) + Conversion.Val(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[7].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19) + Conversion.Val(num20) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[8].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(num21) - Conversion.Val(num21) - Conversion.Val(num21) + Conversion.Val(num22) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[9].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[10].Value = Module1.SetNumFormat(Conversion.Val(num23) - Conversion.Val(num23) - Conversion.Val(num23) + Conversion.Val(num24) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[10].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[11].Value = Module1.SetNumFormat(Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25) + Conversion.Val(num26) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[11].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[12].Value = Module1.SetNumFormat(Conversion.Val(num27) - Conversion.Val(num27) - Conversion.Val(num27) + Conversion.Val(num28) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[12].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[13].Value = Module1.SetNumFormat(Conversion.Val(num29) - Conversion.Val(num29) - Conversion.Val(num29) + Conversion.Val(num30) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[13].Value)), this.txtnu.Text);
                            this.DataGridView2.Rows[2].Cells[14].Value = Module1.SetNumFormat(Conversion.Val(num31) - Conversion.Val(num31) - Conversion.Val(num31) + Conversion.Val(num32) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[14].Value)), this.txtnu.Text);
                        }
                    }
                    int num33 = 0;
                    checked
                    {
                        do
                        {
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[0].Cells[num33].Value, 0, false))
                            {
                                this.DataGridView2.Rows[0].Cells[num33].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView2.Rows[0].Cells[num33].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[1].Cells[num33].Value, 0, false))
                            {
                                this.DataGridView2.Rows[1].Cells[num33].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView2.Rows[1].Cells[num33].Style.ForeColor = Color.Green;
                            }
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[2].Cells[num33].Value, 0, false))
                            {
                                this.DataGridView2.Rows[2].Cells[num33].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView2.Rows[2].Cells[num33].Style.ForeColor = Color.Green;
                            }
                            num33++;
                        }
                        while (num33 <= 14);
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
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600037D RID: 893 RVA: 0x0029B134 File Offset: 0x00299534
        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.listlode();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600037E RID: 894 RVA: 0x0029B180 File Offset: 0x00299580
        private void Agent_CUP_Activated(object sender, EventArgs e)
        {
            try
            {
                this.ComboBox1.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600037F RID: 895 RVA: 0x0029B190 File Offset: 0x00299590
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView5.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView5.CurrentRow.Cells[0].Value = true;
                        }
                        int num = 0;
                        int num2 = this.DataGridView5.Rows.Count - 1;
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
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[i].Cells[0].Value, true, false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[11].Value));
                                    num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[12].Value));
                                    num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[13].Value));
                                    num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[14].Value));
                                    num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[15].Value));
                                    num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[16].Value));
                                    num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[17].Value));
                                    num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[18].Value));
                                    num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[19].Value));
                                    num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[20].Value));
                                    num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[21].Value));
                                    num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[22].Value));
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
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, true, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = $"UPDATE CupTrans SET M_chk = 1 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
                            }
                                this.DataGridView5.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, false, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = $"UPDATE CupTrans SET M_chk = 0 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
                            }
                                this.DataGridView5.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
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

        // Token: 0x06000380 RID: 896 RVA: 0x0029BB18 File Offset: 0x00299F18
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
                    int num = 0;
                    int num2 = this.DataGridView5.Rows.Count - 1;
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
                        this.DataGridView5.Rows[i].Cells[0].Value = true;
                        unchecked
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[i].Cells[0].Value, true, false))
                            {
                                num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                                num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                                num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[10].Value));
                                num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[11].Value));
                                num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[12].Value));
                                num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[13].Value));
                                num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[14].Value));
                                num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[15].Value));
                                num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[16].Value));
                                num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[17].Value));
                                num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[18].Value));
                                num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[19].Value));
                                num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[20].Value));
                                num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[21].Value));
                                num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[22].Value));
                                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE CupTrans SET M_chk = 1 WHERE (CupTrans.m_id = " + this.txtid.Text + ") AND (CupTrans.m_eid = ", this.DataGridView5.Rows[i].Cells[1].Value), ")"));
                                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                oleDbCommand.ExecuteNonQuery();
                                this.DataGridView5.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
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

        // Token: 0x06000381 RID: 897 RVA: 0x0029C378 File Offset: 0x0029A778
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView5.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000382 RID: 898 RVA: 0x0029C404 File Offset: 0x0029A804
        private void DataGridView5_KeyDown(object sender, KeyEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        this.DataGridView1_Click(RuntimeHelpers.GetObjectValue(sender), e);
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView5.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView5.CurrentRow.Cells[0].Value = true;
                        }
                        int num = 0;
                        int num2 = this.DataGridView5.Rows.Count - 1;
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
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[i].Cells[0].Value, true, false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[8].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[9].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[10].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[11].Value));
                                    num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[12].Value));
                                    num8 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[13].Value));
                                    num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[14].Value));
                                    num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[15].Value));
                                    num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[16].Value));
                                    num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[17].Value));
                                    num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[18].Value));
                                    num14 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[19].Value));
                                    num15 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[20].Value));
                                    num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[21].Value));
                                    num17 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[22].Value));
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
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, true, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = $"UPDATE CupTrans SET M_chk = 1 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
                            }
                                this.DataGridView5.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[0].Value, false, false))
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string cmdText = $"UPDATE CupTrans SET M_chk = 0 WHERE CupTrans.m_id = {this.txtid.Text} AND CupTrans.m_eid = {this.txtmodify.Text}";
                            using (CupService cupService = new CupService())
                            {
                                cupService.Update(cmdText);
                            }
                                this.DataGridView5.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
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

        // Token: 0x04000110 RID: 272
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x04000111 RID: 273
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000112 RID: 274
        [AccessedThroughProperty("Button5")]
        private Button _Button5;

        // Token: 0x04000113 RID: 275
        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        // Token: 0x04000114 RID: 276
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000115 RID: 277
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x04000116 RID: 278
        [AccessedThroughProperty("btnshow")]
        private Button _btnshow;

        // Token: 0x04000117 RID: 279
        [AccessedThroughProperty("txtpartyname")]
        private ComboBox _txtpartyname;

        // Token: 0x04000118 RID: 280
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x04000119 RID: 281
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;

        // Token: 0x0400011A RID: 282
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x0400011B RID: 283
        [AccessedThroughProperty("txtparsent")]
        private TextBox _txtparsent;

        // Token: 0x0400011C RID: 284
        [AccessedThroughProperty("pmatch")]
        private ComboBox _pmatch;

        // Token: 0x0400011D RID: 285
        [AccessedThroughProperty("amatch")]
        private ComboBox _amatch;

        // Token: 0x0400011E RID: 286
        [AccessedThroughProperty("smatch")]
        private ComboBox _smatch;

        // Token: 0x0400011F RID: 287
        [AccessedThroughProperty("txtid")]
        private TextBox _txtid;

        // Token: 0x04000120 RID: 288
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000121 RID: 289
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;

        // Token: 0x04000122 RID: 290
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;

        // Token: 0x04000123 RID: 291
        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;

        // Token: 0x04000124 RID: 292
        [AccessedThroughProperty("txtnu")]
        private TextBox _txtnu;

        // Token: 0x04000125 RID: 293
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;

        // Token: 0x04000126 RID: 294
        [AccessedThroughProperty("txtcomihary")]
        private ComboBox _txtcomihary;

        // Token: 0x04000127 RID: 295
        [AccessedThroughProperty("txtmodify")]
        private TextBox _txtmodify;

        // Token: 0x04000128 RID: 296
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;

        // Token: 0x04000129 RID: 297
        [AccessedThroughProperty("Button13")]
        private Button _Button13;

        // Token: 0x0400012A RID: 298
        [AccessedThroughProperty("txtparty")]
        private ComboBox _txtparty;

        // Token: 0x0400012B RID: 299
        [AccessedThroughProperty("Button11")]
        private Button _Button11;

        // Token: 0x0400012C RID: 300
        [AccessedThroughProperty("txtmode")]
        private ComboBox _txtmode;

        // Token: 0x0400012D RID: 301
        [AccessedThroughProperty("txtteam")]
        private ComboBox _txtteam;

        // Token: 0x0400012E RID: 302
        [AccessedThroughProperty("txtrate")]
        private TextBox _txtrate;

        // Token: 0x0400012F RID: 303
        [AccessedThroughProperty("txtamount")]
        private TextBox _txtamount;

        // Token: 0x04000130 RID: 304
        [AccessedThroughProperty("txtpage")]
        private TextBox _txtpage;

        // Token: 0x04000131 RID: 305
        [AccessedThroughProperty("Label15")]
        private Label _Label15;

        // Token: 0x04000132 RID: 306
        [AccessedThroughProperty("Label14")]
        private Label _Label14;

        // Token: 0x04000133 RID: 307
        [AccessedThroughProperty("Label13")]
        private Label _Label13;

        // Token: 0x04000134 RID: 308
        [AccessedThroughProperty("Label12")]
        private Label _Label12;

        // Token: 0x04000135 RID: 309
        [AccessedThroughProperty("Label11")]
        private Label _Label11;

        // Token: 0x04000136 RID: 310
        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        // Token: 0x04000137 RID: 311
        [AccessedThroughProperty("cmbostus")]
        private ComboBox _cmbostus;

        // Token: 0x04000138 RID: 312
        [AccessedThroughProperty("txtL")]
        private TextBox _txtL;

        // Token: 0x04000139 RID: 313
        [AccessedThroughProperty("txtK")]
        private TextBox _txtK;

        // Token: 0x0400013A RID: 314
        [AccessedThroughProperty("txttime")]
        private DateTimePicker _txttime;

        // Token: 0x0400013B RID: 315
        [AccessedThroughProperty("ListView2")]
        private ListView _ListView2;

        // Token: 0x0400013C RID: 316
        [AccessedThroughProperty("ColumnHeader14")]
        private ColumnHeader _ColumnHeader14;

        // Token: 0x0400013D RID: 317
        [AccessedThroughProperty("ColumnHeader15")]
        private ColumnHeader _ColumnHeader15;

        // Token: 0x0400013E RID: 318
        [AccessedThroughProperty("ColumnHeader16")]
        private ColumnHeader _ColumnHeader16;

        // Token: 0x0400013F RID: 319
        [AccessedThroughProperty("ColumnHeader17")]
        private ColumnHeader _ColumnHeader17;

        // Token: 0x04000140 RID: 320
        [AccessedThroughProperty("ColumnHeader18")]
        private ColumnHeader _ColumnHeader18;

        // Token: 0x04000141 RID: 321
        [AccessedThroughProperty("ColumnHeader27")]
        private ColumnHeader _ColumnHeader27;

        // Token: 0x04000142 RID: 322
        [AccessedThroughProperty("Panel4")]
        private Panel _Panel4;

        // Token: 0x04000143 RID: 323
        [AccessedThroughProperty("DataGridView3")]
        private DataGridView _DataGridView3;

        // Token: 0x04000144 RID: 324
        [AccessedThroughProperty("Column16")]
        private DataGridViewTextBoxColumn _Column16;

        // Token: 0x04000145 RID: 325
        [AccessedThroughProperty("DataGridView4")]
        private DataGridView _DataGridView4;

        // Token: 0x04000146 RID: 326
        [AccessedThroughProperty("DataGridViewTextBoxColumn16")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn16;

        // Token: 0x04000147 RID: 327
        [AccessedThroughProperty("DataGridViewTextBoxColumn17")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn17;

        // Token: 0x04000148 RID: 328
        [AccessedThroughProperty("DataGridViewTextBoxColumn18")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn18;

        // Token: 0x04000149 RID: 329
        [AccessedThroughProperty("DataGridViewTextBoxColumn19")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn19;

        // Token: 0x0400014A RID: 330
        [AccessedThroughProperty("DataGridViewTextBoxColumn20")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn20;

        // Token: 0x0400014B RID: 331
        [AccessedThroughProperty("DataGridViewTextBoxColumn21")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn21;

        // Token: 0x0400014C RID: 332
        [AccessedThroughProperty("DataGridViewTextBoxColumn22")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn22;

        // Token: 0x0400014D RID: 333
        [AccessedThroughProperty("DataGridViewTextBoxColumn23")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn23;

        // Token: 0x0400014E RID: 334
        [AccessedThroughProperty("DataGridViewTextBoxColumn24")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn24;

        // Token: 0x0400014F RID: 335
        [AccessedThroughProperty("DataGridViewTextBoxColumn25")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn25;

        // Token: 0x04000150 RID: 336
        [AccessedThroughProperty("DataGridViewTextBoxColumn26")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn26;

        // Token: 0x04000151 RID: 337
        [AccessedThroughProperty("DataGridViewTextBoxColumn27")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn27;

        // Token: 0x04000152 RID: 338
        [AccessedThroughProperty("DataGridViewTextBoxColumn28")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn28;

        // Token: 0x04000153 RID: 339
        [AccessedThroughProperty("DataGridViewTextBoxColumn29")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn29;

        // Token: 0x04000154 RID: 340
        [AccessedThroughProperty("DataGridViewTextBoxColumn30")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn30;

        // Token: 0x04000155 RID: 341
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;

        // Token: 0x04000156 RID: 342
        [AccessedThroughProperty("DataGridView2")]
        private DataGridView _DataGridView2;

        // Token: 0x04000157 RID: 343
        [AccessedThroughProperty("Column17")]
        private DataGridViewTextBoxColumn _Column17;

        // Token: 0x04000158 RID: 344
        [AccessedThroughProperty("Column18")]
        private DataGridViewTextBoxColumn _Column18;

        // Token: 0x04000159 RID: 345
        [AccessedThroughProperty("Column19")]
        private DataGridViewTextBoxColumn _Column19;

        // Token: 0x0400015A RID: 346
        [AccessedThroughProperty("Column20")]
        private DataGridViewTextBoxColumn _Column20;

        // Token: 0x0400015B RID: 347
        [AccessedThroughProperty("Column21")]
        private DataGridViewTextBoxColumn _Column21;

        // Token: 0x0400015C RID: 348
        [AccessedThroughProperty("Column22")]
        private DataGridViewTextBoxColumn _Column22;

        // Token: 0x0400015D RID: 349
        [AccessedThroughProperty("Column23")]
        private DataGridViewTextBoxColumn _Column23;

        // Token: 0x0400015E RID: 350
        [AccessedThroughProperty("Column24")]
        private DataGridViewTextBoxColumn _Column24;

        // Token: 0x0400015F RID: 351
        [AccessedThroughProperty("Column25")]
        private DataGridViewTextBoxColumn _Column25;

        // Token: 0x04000160 RID: 352
        [AccessedThroughProperty("Column26")]
        private DataGridViewTextBoxColumn _Column26;

        // Token: 0x04000161 RID: 353
        [AccessedThroughProperty("Column27")]
        private DataGridViewTextBoxColumn _Column27;

        // Token: 0x04000162 RID: 354
        [AccessedThroughProperty("Column28")]
        private DataGridViewTextBoxColumn _Column28;

        // Token: 0x04000163 RID: 355
        [AccessedThroughProperty("Column29")]
        private DataGridViewTextBoxColumn _Column29;

        // Token: 0x04000164 RID: 356
        [AccessedThroughProperty("Column30")]
        private DataGridViewTextBoxColumn _Column30;

        // Token: 0x04000165 RID: 357
        [AccessedThroughProperty("Column31")]
        private DataGridViewTextBoxColumn _Column31;

        // Token: 0x04000166 RID: 358
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;

        // Token: 0x04000167 RID: 359
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;

        // Token: 0x04000168 RID: 360
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;

        // Token: 0x04000169 RID: 361
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;

        // Token: 0x0400016A RID: 362
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;

        // Token: 0x0400016B RID: 363
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;

        // Token: 0x0400016C RID: 364
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;

        // Token: 0x0400016D RID: 365
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;

        // Token: 0x0400016E RID: 366
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;

        // Token: 0x0400016F RID: 367
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;

        // Token: 0x04000170 RID: 368
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;

        // Token: 0x04000171 RID: 369
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;

        // Token: 0x04000172 RID: 370
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;

        // Token: 0x04000173 RID: 371
        [AccessedThroughProperty("Column13")]
        private DataGridViewTextBoxColumn _Column13;

        // Token: 0x04000174 RID: 372
        [AccessedThroughProperty("Column14")]
        private DataGridViewTextBoxColumn _Column14;

        // Token: 0x04000175 RID: 373
        [AccessedThroughProperty("Column15")]
        private DataGridViewTextBoxColumn _Column15;

        // Token: 0x04000176 RID: 374
        [AccessedThroughProperty("Panel6")]
        private Panel _Panel6;

        // Token: 0x04000177 RID: 375
        [AccessedThroughProperty("DataGridView5")]
        private DataGridView _DataGridView5;

        // Token: 0x04000178 RID: 376
        [AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
        private DataGridViewCheckBoxColumn _DataGridViewCheckBoxColumn1;

        // Token: 0x04000179 RID: 377
        [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

        // Token: 0x0400017A RID: 378
        [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

        // Token: 0x0400017B RID: 379
        [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

        // Token: 0x0400017C RID: 380
        [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

        // Token: 0x0400017D RID: 381
        [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

        // Token: 0x0400017E RID: 382
        [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

        // Token: 0x0400017F RID: 383
        [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

        // Token: 0x04000180 RID: 384
        [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

        // Token: 0x04000181 RID: 385
        [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

        // Token: 0x04000182 RID: 386
        [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

        // Token: 0x04000183 RID: 387
        [AccessedThroughProperty("DataGridViewTextBoxColumn11")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

        // Token: 0x04000184 RID: 388
        [AccessedThroughProperty("DataGridViewTextBoxColumn12")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;

        // Token: 0x04000185 RID: 389
        [AccessedThroughProperty("DataGridViewTextBoxColumn13")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;

        // Token: 0x04000186 RID: 390
        [AccessedThroughProperty("DataGridViewTextBoxColumn14")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;

        // Token: 0x04000187 RID: 391
        [AccessedThroughProperty("DataGridViewTextBoxColumn15")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;

        // Token: 0x04000188 RID: 392
        [AccessedThroughProperty("DataGridViewTextBoxColumn31")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn31;

        // Token: 0x04000189 RID: 393
        [AccessedThroughProperty("DataGridViewTextBoxColumn32")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn32;

        // Token: 0x0400018A RID: 394
        [AccessedThroughProperty("DataGridViewTextBoxColumn33")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn33;

        // Token: 0x0400018B RID: 395
        [AccessedThroughProperty("DataGridViewTextBoxColumn34")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn34;

        // Token: 0x0400018C RID: 396
        [AccessedThroughProperty("DataGridViewTextBoxColumn35")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn35;

        // Token: 0x0400018D RID: 397
        [AccessedThroughProperty("DataGridViewTextBoxColumn36")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn36;

        // Token: 0x0400018E RID: 398
        [AccessedThroughProperty("DataGridViewTextBoxColumn37")]
        private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn37;

        // Token: 0x0400018F RID: 399
        private object h1;

        // Token: 0x04000190 RID: 400
        private object h2;

        // Token: 0x04000191 RID: 401
        private object h3;

        // Token: 0x04000192 RID: 402
        private object h4;

        // Token: 0x04000193 RID: 403
        private object h5;

        // Token: 0x04000194 RID: 404
        private object h6;

        // Token: 0x04000195 RID: 405
        private object h7;

        // Token: 0x04000196 RID: 406
        private object h8;

        // Token: 0x04000197 RID: 407
        private object h9;

        // Token: 0x04000198 RID: 408
        private object h10;

        // Token: 0x04000199 RID: 409
        private object h11;

        // Token: 0x0400019A RID: 410
        private object h12;

        // Token: 0x0400019B RID: 411
        private object h13;

        // Token: 0x0400019C RID: 412
        private object h14;

        // Token: 0x0400019D RID: 413
        private object h15;

        // Token: 0x0400019E RID: 414
        private double a;
    }
}
