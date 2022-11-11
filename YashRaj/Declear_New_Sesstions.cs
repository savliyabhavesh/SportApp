using System;
using System.Collections;
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
    // Token: 0x0200003B RID: 59
    //[DesignerGenerated]
    public partial class Declear_New_Sesstions : Form
    {
         string strTime = "";
        // Token: 0x0600090F RID: 2319 RVA: 0x002DAA8C File Offset: 0x002D8E8C
        public Declear_New_Sesstions()
        {
            this.txtdate = new TextBox();
            this.InitializeComponent();
        }

        // Token: 0x0600097F RID: 2431 RVA: 0x002E0434 File Offset: 0x002DE834
        private void Declear_New_Sesstions_Activated(object sender, EventArgs e)
        {
            this.txtrun.Focus();
        }

        // Token: 0x06000980 RID: 2432 RVA: 0x002E0444 File Offset: 0x002DE844
        private void Declear_New_Sesstions_Load(object sender, EventArgs e)
        {
            try
            {
                int Matchid = 0;
                this._my_Positions();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from ewSession where Sr_No=" + Conversions.ToString(Module1.nehaid) + "";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Label2.Text = Conversions.ToString(oleDbDataReader[1]) + " - " + Conversions.ToString(oleDbDataReader[3]);
                    this.txtdate.Text = oleDbDataReader["Dt"].ToString();
                    Matchid = Convert.ToInt32(oleDbDataReader["Match_ID"]);
                }
                else
                {
                    Interaction.MsgBox("Record No", MsgBoxStyle.OkOnly, null);
                }


                string cmdText1 = "Select * from Newmatch where Sr_No=" + Conversions.ToString(Matchid) + "";
                OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
                OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                if (oleDbDataReader1.Read())
                {
                    //if (Convert.ToString(oleDbDataReader1["Type"]) == "TEST")
                    //{
                    //    this.txtdate.Text = Conversions.ToString(DateAndTime.Now.Date);
                    //}
                    
                    strTime = oleDbDataReader1["entry_time"].ToString();                 
                    if (strTime == "")
                    {
                        strTime = Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime);
                    }
                }
                this.txtrun.Focus();
                this.txtrun.Focus();
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

        // Token: 0x06000976 RID: 2422 RVA: 0x002DCA38 File Offset: 0x002DAE38
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridMen.Rows.Clear();
                this.DataGridView1.Rows.Clear();
                this.DataSelf.Rows.Clear();
                this.DataAgent.Rows.Clear();
                this.DataThirdParty.Rows.Clear();
                this.DataCommision.Rows.Clear();

                double num = Convert.ToDouble(this.txtrun.Text) - 1;
                checked
                {
                    int num2 = (int)Math.Round(num);
                    int num3 = (int)Math.Round(unchecked(num + 3));
                    for (int i = num2; i <= num3; i++)
                    {
                        int index = this.DataGridMen.Rows.Add();
                        this.DataGridMen.Rows[index].Cells[0].Value = i;
                    }

                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "SELECT PartyMaster.PartyName, SessionTrans.S_Sr_No, SessionTrans.Session_ID, SessionTrans.s_checked, PartyMaster.Status, PartyMaster.SSession, PartyMaster.SSessionCommi, PartyMaster.AParty,PartyMaster.ASession, PartyMaster.ASessionCommi, PartyMaster.TParty, PartyMaster.TSession, PartyMaster.TSessionCommi FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) GROUP BY PartyMaster.PartyName, SessionTrans.S_Sr_No, SessionTrans.Session_ID, SessionTrans.s_checked, PartyMaster.Status, PartyMaster.SSession, PartyMaster.SSessionCommi, PartyMaster.AParty,PartyMaster.ASession, PartyMaster.ASessionCommi, PartyMaster.TParty, PartyMaster.TSession, PartyMaster.TSessionCommi HAVING (SessionTrans.S_Sr_No = " + Module1.sessionid + ") AND (SessionTrans.Session_ID = " + Module1.nehaid + ") AND (SessionTrans.s_checked <> 1)";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        string status = oleDbDataReader["Status"].ToString();
                        string party = oleDbDataReader["PartyName"].ToString();
                        string aparty = oleDbDataReader["AParty"].ToString();
                        string tparty = oleDbDataReader["TParty"].ToString();

                        double ssession = Convert.ToDouble(oleDbDataReader["SSession"]);
                        double asession = Convert.ToDouble(oleDbDataReader["ASession"]);
                        double tsession = Convert.ToDouble(oleDbDataReader["TSession"]);

                        double ssessioncommi = Convert.ToDouble(oleDbDataReader["SSessionCommi"]);
                        double asessioncommi = Convert.ToDouble(oleDbDataReader["ASessionCommi"]);
                        double tsessioncommi = Convert.ToDouble(oleDbDataReader["TSessionCommi"]);
                        double totalcommi = ssessioncommi + asessioncommi + tsessioncommi;

                        string cmdText2 = "SELECT id, S_Sr_No, s_eid, s_rate, s_amt, S_RUN, s_bild, s_mod, s_party, s_yes, s_no, s_checked, M_chk, Session_ID, Comission FROM (SessionTrans) WHERE (S_Sr_No = " + Module1.sessionid + ") AND (Session_ID = " + Module1.nehaid + ") AND (s_party = '" + party + "') AND (s_checked <> 1)";
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();

                        while (oleDbDataReader2.Read())
                        {
                            string comm = Conversions.ToString(oleDbDataReader2["Comission"]);
                            double amt = 0;
                            double num8 = 0;
                            double num17 = 0;
                            double num18 = 0;
                            unchecked
                            {
                                amt = Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["s_amt"]));
                                num8 = Convert.ToDouble(oleDbDataReader2["S_RUN"]) - 1;

                                num17 = Convert.ToDouble(Operators.SubtractObject(Operators.SubtractObject(oleDbDataReader2["s_yes"], oleDbDataReader2["s_yes"]), oleDbDataReader2["s_yes"]));
                                num18 = Convert.ToDouble(Operators.SubtractObject(Operators.SubtractObject(oleDbDataReader2["s_no"], oleDbDataReader2["s_no"]), oleDbDataReader2["s_no"]));
                            }

                            double num19 = Convert.ToDouble(Operators.AddObject(Operators.AddObject(num8, oleDbDataReader2["s_bild"]), 2));
                            for (int i = 0; i <= this.DataGridMen.Rows.Count - 1; i++)
                            {
                                if (Operators.ConditionalCompareObjectGreater(this.DataGridMen.Rows[i].Cells[0].Value, num8, false))
                                {
                                    if (Operators.CompareString(status, "Regular", false) == 0)
                                    {
                                        DataGridViewCell dataGridViewCell = this.DataGridMen.Rows[i].Cells[1];
                                        dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(num17));
                                        if (comm == "YES")
                                        {
                                            DataGridViewCell dataGridViewCell_2 = this.DataGridMen.Rows[i].Cells[2];
                                            dataGridViewCell_2.Value = Operators.AddObject(dataGridViewCell_2.Value, Conversion.Val(amt));
                                        }
                                    }
                                    else if (Operators.CompareString(status, "Booky", false) == 0)
                                    {
                                        DataGridViewCell dataGridViewCell = this.DataGridMen.Rows[i].Cells[1];
                                        dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(num17));
                                        if (comm == "YES")
                                        {
                                            DataGridViewCell dataGridViewCell_2 = this.DataGridMen.Rows[i].Cells[2];
                                            dataGridViewCell_2.Value = Operators.AddObject(dataGridViewCell_2.Value, Conversion.Val(amt));
                                        }
                                    }
                                }
                                else if (Operators.CompareString(status, "Regular", false) == 0)
                                {
                                    DataGridViewCell dataGridViewCell = this.DataGridMen.Rows[i].Cells[1];
                                    dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(num18));
                                    if (comm == "YES")
                                    {
                                        DataGridViewCell dataGridViewCell_2 = this.DataGridMen.Rows[i].Cells[2];
                                        dataGridViewCell_2.Value = Operators.AddObject(dataGridViewCell_2.Value, Conversion.Val(amt));
                                    }
                                }
                                else if (Operators.CompareString(status, "Booky", false) == 0)
                                {
                                    DataGridViewCell dataGridViewCell = this.DataGridMen.Rows[i].Cells[1];
                                    dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(num18));
                                    if (comm == "YES")
                                    {
                                        DataGridViewCell dataGridViewCell_2 = this.DataGridMen.Rows[i].Cells[2];
                                        dataGridViewCell_2.Value = Operators.AddObject(dataGridViewCell_2.Value, Conversion.Val(amt));
                                    }
                                }
                            }
                        }

                        double num28 = 0;
                        double commamt = 0;
                        for (int i = 0; i <= this.DataGridMen.Rows.Count - 1; i++)
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridMen.Rows[i].Cells[0].Value, this.txtrun.Text, false))
                            {
                                num28 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMen.Rows[i].Cells[1].Value)));
                                commamt = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMen.Rows[i].Cells[2].Value)));
                            }
                        }

                        int index2 = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[index2].Cells[0].Value = party;
                        this.DataGridView1.Rows[index2].Cells[1].Value = num28;
                        this.DataGridView1.Rows[index2].Cells[2].Value = this.Label2.Text;

                        double selfld = Conversion.Val(num28) * Conversion.Val(ssession) / 100;
                        double after_selfld = Conversion.Val(selfld) - Conversion.Val(num28);
                        after_selfld = Conversion.Val(after_selfld) - Conversion.Val(after_selfld) - Conversion.Val(after_selfld);

                        double selfldcommamt = Conversion.Val(commamt) * Conversion.Val(ssession) / 100;
                        double after_selfldcomm = Conversion.Val(selfldcommamt) - Conversion.Val(commamt);
                        after_selfldcomm = Conversion.Val(after_selfldcomm);

                        if (status == "Booky")
                        {
                            unchecked
                            {
                                int index3 = this.DataSelf.Rows.Add();
                                this.DataSelf.Rows[index3].Cells[0].Value = party;
                                this.DataSelf.Rows[index3].Cells[1].Value = Conversion.Val(selfld) - Conversion.Val(selfld) - Conversion.Val(selfld);
                                this.DataSelf.Rows[index3].Cells[2].Value = "As Self LD - " + this.Label2.Text;

                                int index12 = this.DataCommision.Rows.Add();
                                this.DataCommision.Rows[index12].Cells[0].Value = party;
                                double selfcommi = Conversion.Val(after_selfldcomm) * Conversion.Val(ssessioncommi) / 100;
                                this.DataCommision.Rows[index12].Cells[1].Value = Conversion.Val(selfcommi);
                                this.DataCommision.Rows[index12].Cells[2].Value = "Commi on session of LD  -" + party + "-" + this.Label2.Text;

                                if (Operators.CompareString(aparty, null, false) != 0)
                                {
                                    int index4 = this.DataAgent.Rows.Add();
                                    this.DataAgent.Rows[index4].Cells[0].Value = aparty;
                                    double agentld = (Conversion.Val(after_selfld) * Conversion.Val(asession) / 100) + (Conversion.Val(after_selfldcomm) * Conversion.Val(asessioncommi) / 100);
                                    this.DataAgent.Rows[index4].Cells[1].Value = Conversion.Val(agentld);// - Conversion.Val(agentld) - Conversion.Val(agentld);
                                    this.DataAgent.Rows[index4].Cells[2].Value = "As Agent of -   " + party + " - " + this.Label2.Text;

                                    int index13 = this.DataCommision.Rows.Add();
                                    this.DataCommision.Rows[index13].Cells[0].Value = aparty;
                                    double agentcommi = (Conversion.Val(after_selfldcomm) * Conversion.Val(asession) / 100) * Conversion.Val(totalcommi) / 100;
                                    if (agentcommi > 0)
                                    {
                                        agentcommi = Conversion.Val(agentcommi) - Conversion.Val(agentcommi) - Conversion.Val(agentcommi);
                                    }
                                    else
                                    {
                                        agentcommi = Conversion.Val(agentcommi);
                                    }
                                    this.DataCommision.Rows[index13].Cells[1].Value = Conversion.Val(agentcommi);
                                    this.DataCommision.Rows[index13].Cells[2].Value = "Commi on session of LD - " + party + "-" + this.Label2.Text;
                                }
                                if (Operators.CompareString(tparty, null, false) != 0)
                                {
                                    int index5 = this.DataThirdParty.Rows.Add();
                                    this.DataThirdParty.Rows[index5].Cells[0].Value = tparty;
                                    double thirdpartyld = (Conversion.Val(after_selfld) * Conversion.Val(tsession) / 100) + (Conversion.Val(after_selfldcomm) * Conversion.Val(tsessioncommi) / 100);
                                    this.DataThirdParty.Rows[index5].Cells[1].Value = Conversion.Val(thirdpartyld);// - Conversion.Val(thirdpartyld) - Conversion.Val(thirdpartyld);
                                    this.DataThirdParty.Rows[index5].Cells[2].Value = "As ThirdParty of -   " + party + " - " + this.Label2.Text;

                                    int index14 = this.DataCommision.Rows.Add();
                                    this.DataCommision.Rows[index14].Cells[0].Value = tparty;
                                    double thirdpartycommi = (Conversion.Val(after_selfldcomm) * Conversion.Val(tsession) / 100) * Conversion.Val(totalcommi) / 100;
                                    if (thirdpartycommi > 0)
                                    {
                                        thirdpartycommi = Conversion.Val(thirdpartycommi) - Conversion.Val(thirdpartycommi) - Conversion.Val(thirdpartycommi);
                                    }
                                    else
                                    {
                                        thirdpartycommi = Conversion.Val(thirdpartycommi);
                                    }
                                    this.DataCommision.Rows[index14].Cells[1].Value = Conversion.Val(thirdpartycommi);
                                    this.DataCommision.Rows[index14].Cells[2].Value = "Comm on session of LD - " + party + "-" + this.Label2.Text;
                                }
                            }
                        }
                        else if (status == "Regular")
                        {
                            unchecked
                            {
                                int index3 = this.DataSelf.Rows.Add();
                                this.DataSelf.Rows[index3].Cells[0].Value = party;
                                this.DataSelf.Rows[index3].Cells[1].Value = Conversion.Val(selfld) - Conversion.Val(selfld) - Conversion.Val(selfld);
                                this.DataSelf.Rows[index3].Cells[2].Value = "As Self LD - " + this.Label2.Text;

                                int index12 = this.DataCommision.Rows.Add();
                                this.DataCommision.Rows[index12].Cells[0].Value = party;
                                double selfcommi = Conversion.Val(after_selfldcomm) * Conversion.Val(ssessioncommi) / 100;
                                this.DataCommision.Rows[index12].Cells[1].Value = Conversion.Val(selfcommi) - Conversion.Val(selfcommi) - Conversion.Val(selfcommi);
                                this.DataCommision.Rows[index12].Cells[2].Value = "Commi on session of LD  -" + party + "-" + this.Label2.Text;

                                if (Operators.CompareString(aparty, null, false) != 0)
                                {
                                    int index4 = this.DataAgent.Rows.Add();
                                    this.DataAgent.Rows[index4].Cells[0].Value = aparty;
                                    double agentld = (Conversion.Val(after_selfld) * Conversion.Val(asession) / 100) + (Conversion.Val(after_selfldcomm) * Conversion.Val(asessioncommi) / 100);
                                    this.DataAgent.Rows[index4].Cells[1].Value = Conversion.Val(agentld) - Conversion.Val(agentld) - Conversion.Val(agentld);
                                    this.DataAgent.Rows[index4].Cells[2].Value = "As Agent of -   " + party + " - " + this.Label2.Text;

                                    int index13 = this.DataCommision.Rows.Add();
                                    this.DataCommision.Rows[index13].Cells[0].Value = aparty;
                                    double agentcommi = (Conversion.Val(after_selfldcomm) * Conversion.Val(asession) / 100) * Conversion.Val(totalcommi) / 100;
                                    if (agentcommi > 0)
                                    {
                                        agentcommi = Conversion.Val(agentcommi) - Conversion.Val(agentcommi) - Conversion.Val(agentcommi);
                                    }
                                    else
                                    {
                                        agentcommi = Conversion.Val(agentcommi);
                                    }
                                    this.DataCommision.Rows[index13].Cells[1].Value = Conversion.Val(agentcommi);
                                    this.DataCommision.Rows[index13].Cells[2].Value = "Commi on session of LD - " + party + "-" + this.Label2.Text;
                                }
                                if (Operators.CompareString(tparty, null, false) != 0)
                                {
                                    int index5 = this.DataThirdParty.Rows.Add();
                                    this.DataThirdParty.Rows[index5].Cells[0].Value = tparty;
                                    double thirdpartyld = (Conversion.Val(after_selfld) * Conversion.Val(tsession) / 100) + (Conversion.Val(after_selfldcomm) * Conversion.Val(tsessioncommi) / 100);
                                    this.DataThirdParty.Rows[index5].Cells[1].Value = Conversion.Val(thirdpartyld) - Conversion.Val(thirdpartyld) - Conversion.Val(thirdpartyld);
                                    this.DataThirdParty.Rows[index5].Cells[2].Value = "As ThirdParty of -   " + party + " - " + this.Label2.Text;

                                    int index14 = this.DataCommision.Rows.Add();
                                    this.DataCommision.Rows[index14].Cells[0].Value = tparty;
                                    double thirdpartycommi = (Conversion.Val(after_selfldcomm) * Conversion.Val(tsession) / 100) * Conversion.Val(totalcommi) / 100;
                                    if (thirdpartycommi > 0)
                                    {
                                        thirdpartycommi = Conversion.Val(thirdpartycommi) - Conversion.Val(thirdpartycommi) - Conversion.Val(thirdpartycommi);
                                    }
                                    else
                                    {
                                        thirdpartycommi = Conversion.Val(thirdpartycommi);
                                    }
                                    this.DataCommision.Rows[index14].Cells[1].Value = Conversion.Val(thirdpartycommi);
                                    this.DataCommision.Rows[index14].Cells[2].Value = "Comm on session of LD - " + party + "-" + this.Label2.Text;
                                }
                            }
                        }

                        this.DataGridMen.Rows.Clear();
                        num = Convert.ToDouble(this.txtrun.Text) - 4.0;

                        int num44 = (int)Math.Round(num);
                        int num45 = (int)Math.Round(unchecked(num + 7.0));
                        for (int i = num44; i <= num45; i++)
                        {
                            this.DataGridMen.Columns[0].Width = 50;
                            int index15 = this.DataGridMen.Rows.Add();
                            this.DataGridMen.Rows[index15].Cells[0].Value = i;
                        }
                    }


                    /// Start - Added For Badla Transaction
                    string cmdText5 = "select PartyMaster.PartyName,PartyMaster.SSession, PartyMaster.AParty,PartyMaster.ASession, PartyMaster.TParty, PartyMaster.TSession from(PartyMaster inner join BadlaTrn on PartyMaster.PartyName = BadlaTrn.party) where (s_id = " + Module1.nehaid + ") and (m_id = " + Module1.sessionid + ") group by PartyMaster.PartyName,PartyMaster.SSession, PartyMaster.AParty,PartyMaster.ASession, PartyMaster.TParty, PartyMaster.TSession order by PartyMaster.PartyName";
                    OleDbCommand oleDbCommand5 = new OleDbCommand(cmdText5, Module1.conn);
                    OleDbDataReader oleDbDataReader5 = oleDbCommand5.ExecuteReader();
                    while (oleDbDataReader5.Read())
                    {
                        string party = oleDbDataReader5["PartyName"].ToString();
                        string aparty = oleDbDataReader5["AParty"].ToString();
                        string tparty = oleDbDataReader5["TParty"].ToString();

                        double ssession = Convert.ToDouble(oleDbDataReader5["SSession"]);
                        double asession = Convert.ToDouble(oleDbDataReader5["ASession"]);
                        double tsession = Convert.ToDouble(oleDbDataReader5["TSession"]);

                        string strbadla = "select run,type,party,sum(amt) as amount from BadlaTrn where (run = " + Convert.ToDouble(this.txtrun.Text) + ") and (party = '" + party + "') and (s_id = " + Module1.nehaid + ") and (m_id = " + Module1.sessionid + ") group by run,type,party ";
                        OleDbCommand oleDbCommandBadla = new OleDbCommand(strbadla, Module1.conn);
                        OleDbDataReader oleDbDataReaderBadla = oleDbCommandBadla.ExecuteReader();
                        while (oleDbDataReaderBadla.Read())
                        {
                            string badlatype = Conversions.ToString(oleDbDataReaderBadla["type"]);
                            double badlaamt = Convert.ToDouble(oleDbDataReaderBadla["amount"]);
                            badlaamt = Conversion.Val(badlaamt) - Conversion.Val(badlaamt) - Conversion.Val(badlaamt);

                            int indexbadla2 = this.DataGridView1.Rows.Add();
                            this.DataGridView1.Rows[indexbadla2].Cells[0].Value = party;
                            this.DataGridView1.Rows[indexbadla2].Cells[1].Value = Conversion.Val(badlaamt);
                            this.DataGridView1.Rows[indexbadla2].Cells[2].Value = "Badla  - " + this.Label2.Text;

                            double selfld = Conversion.Val(badlaamt) * Conversion.Val(ssession) / 100;
                            double afterselfld = Conversion.Val(selfld) - Conversion.Val(badlaamt);

                            int indexbadla3 = this.DataSelf.Rows.Add();
                            this.DataSelf.Rows[indexbadla3].Cells[0].Value = party;
                            this.DataSelf.Rows[indexbadla3].Cells[1].Value = Conversion.Val(selfld) - Conversion.Val(selfld) - Conversion.Val(selfld);
                            this.DataSelf.Rows[indexbadla3].Cells[2].Value = "As Badla Self LD - " + this.Label2.Text;

                            if (Operators.CompareString(aparty, null, false) != 0)
                            {
                                int indexbadla4 = this.DataAgent.Rows.Add();
                                this.DataAgent.Rows[indexbadla4].Cells[0].Value = aparty;
                                this.DataAgent.Rows[indexbadla4].Cells[1].Value = (Conversion.Val(afterselfld) * Conversion.Val(asession) / 100);
                                this.DataAgent.Rows[indexbadla4].Cells[2].Value = "As Badla Agent LD of -   " + party + " - " + this.Label2.Text;
                            }
                            if (Operators.CompareString(tparty, null, false) != 0)
                            {
                                int indexbadla5 = this.DataThirdParty.Rows.Add();
                                this.DataThirdParty.Rows[indexbadla5].Cells[0].Value = tparty;
                                this.DataThirdParty.Rows[indexbadla5].Cells[1].Value = (Conversion.Val(afterselfld) * Conversion.Val(tsession) / 100);
                                this.DataThirdParty.Rows[indexbadla5].Cells[2].Value = "As Badla ThirdParty LD of -   " + party + " - " + this.Label2.Text;
                            }
                        }
                    }
                    /// End - Added For Badla Transaction


                    this.Session_Total();
                    this.save_all1();
                    this.save_all2();
                    this.save_all3();
                    this.save_all4();
                    this.save_all5();
                    this.save_all6();

                    string cmdText3 = $"update ewSession set Result='Declared', Remark='{ this.txtrun.Text }' where Sr_No={ Conversions.ToString(Module1.nehaid) } and Match_ID={ Module1.sessionid }"; //Conversions.ToString(Operators.ConcatenateObject("update ewSession set Result='Declared', Remark='" + this.txtrun.Text + "' where Sr_No=" + Conversions.ToString(Module1.nehaid) + " and Match_ID=", Module1.sessionid));
                    using (SessionService sessionService = new SessionService())
                    {
                        sessionService.Update(cmdText3);
                    }
                        this.Close();


                    ////MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                    ////MyProject.Forms.Session_Report.Show();
                    ////this.Close();

                    ////if (Operators.CompareString(Module1.sessiondelc, "1", false) == 0)
                    ////{
                    ////	MyProject.Forms.All_Session.MdiParent = this.MdiParent;
                    ////	MyProject.Forms.All_Session.WindowState = FormWindowState.Maximized;
                    ////	MyProject.Forms.All_Session.Show();
                    ////	this.Close();
                    ////}
                    ////else
                    ////{
                    ////	MyProject.Forms.Session_Report.sessionrept();
                    ////	MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                    ////	MyProject.Forms.Session_Report.Show();
                    ////	this.Close();
                    ////}
                    ////Module1.sessiondelc = null;
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

        // Token: 0x06000977 RID: 2423 RVA: 0x002DEE80 File Offset: 0x002DD280
        public void _my_Positions()
        {
            try
            {
                Size size = new Size(732, 659);
                this.Size = size;
                int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
                int y = 1; //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000978 RID: 2424 RVA: 0x002DEF1C File Offset: 0x002DD31C
        public void Session_Total()
        {
            try
            {
                this.DataSHRI.Rows.Clear();
                this.DataSHRI.Rows.Add();
                this.DataSHRI.Rows.Add();
                this.DataSHRI.Rows.Add();
                this.DataSHRI.Rows.Add();
                this.DataSHRI.Rows.Add();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select PartyName from PartyMaster where Id=1";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                string text2 = "";
                while (oleDbDataReader.Read())
                {
                    text2 = Conversions.ToString(oleDbDataReader["PartyName"]);
                }
                int num = 0;
                double num13 = 0;
                checked
                {
                    int num2 = this.DataGridView1.RowCount - 1;
                    double num3 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[1].Value, null, false))
                            {
                                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[1].Value, "0", false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[1].Value));
                                }
                            }
                        }
                    }
                    this.DataSHRI.Rows[0].Cells[1].Value = unchecked(Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3));
                    this.DataSHRI.Rows[0].Cells[0].Value = text2.ToString();
                    this.DataSHRI.Rows[0].Cells[2].Value = this.Label2.Text;
                    double num4 = 0.0;
                    int num5 = 0;
                    int num6 = this.DataSelf.RowCount - 1;
                    for (int j = num5; j <= num6; j++)
                    {
                        unchecked
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.DataSelf.Rows[j].Cells[1].Value, null, false))
                            {
                                num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataSelf.Rows[j].Cells[1].Value));
                            }
                        }
                    }
                    this.DataSHRI.Rows[1].Cells[1].Value = unchecked(Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4));
                    this.DataSHRI.Rows[1].Cells[0].Value = text2;
                    this.DataSHRI.Rows[1].Cells[2].Value = "As an Self Agent -" + this.Label2.Text;
                    double num7 = 0.0;
                    int num8 = 0;
                    int num9 = this.DataAgent.RowCount - 1;
                    for (int k = num8; k <= num9; k++)
                    {
                        unchecked
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.DataAgent.Rows[k].Cells[1].Value, null, false))
                            {
                                num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataAgent.Rows[k].Cells[1].Value));
                            }
                        }
                    }
                    this.DataSHRI.Rows[2].Cells[1].Value = unchecked(Conversion.Val(num7) - Conversion.Val(num7) - Conversion.Val(num7));
                    this.DataSHRI.Rows[2].Cells[0].Value = text2;
                    this.DataSHRI.Rows[2].Cells[2].Value = "As an Agent of  -" + this.Label2.Text;
                    double num10 = 0.0;
                    int num11 = 0;
                    int num12 = this.DataThirdParty.RowCount - 1;
                    for (int l = num11; l <= num12; l++)
                    {
                        unchecked
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.DataThirdParty.Rows[l].Cells[1].Value, null, false))
                            {
                                num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataThirdParty.Rows[l].Cells[1].Value));
                            }
                        }
                    }
                    this.DataSHRI.Rows[3].Cells[1].Value = unchecked(Conversion.Val(num10) - Conversion.Val(num10) - Conversion.Val(num10));
                    this.DataSHRI.Rows[3].Cells[0].Value = text2;
                    this.DataSHRI.Rows[3].Cells[2].Value = "As an ThirdParty of -" + this.Label2.Text;
                    num13 = 0.0;
                    int num14 = 0;
                    int num15 = this.DataCommision.RowCount - 1;
                    for (int m = num14; m <= num15; m++)
                    {
                        unchecked
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.DataCommision.Rows[m].Cells[0].Value, null, false))
                            {
                                num13 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataCommision.Rows[m].Cells[1].Value));
                            }
                        }
                    }
                }
                this.DataSHRI.Rows[4].Cells[1].Value = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                this.DataSHRI.Rows[4].Cells[0].Value = text2;
                this.DataSHRI.Rows[4].Cells[2].Value = "Comm Session of - " + this.Label2.Text;
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

        // Token: 0x06000979 RID: 2425 RVA: 0x002DF648 File Offset: 0x002DDA48
        public void save_all1()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{RuntimeHelpers.GetObjectValue(Module1.sessionid)},'{this.txtdate.Text}','Session','',0,{Module1.nehaid},'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                finally
                {
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

        // Token: 0x0600097A RID: 2426 RVA: 0x002DF888 File Offset: 0x002DDC88
        public void save_all2()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataSelf.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{RuntimeHelpers.GetObjectValue(Module1.sessionid)},'{this.txtdate.Text}','Session','',0,{Module1.nehaid},'No','{strTime}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                finally
                {
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

        // Token: 0x0600097B RID: 2427 RVA: 0x002DFAC8 File Offset: 0x002DDEC8
        public void save_all3()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataAgent.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{RuntimeHelpers.GetObjectValue(Module1.sessionid)},'{this.txtdate.Text}','Session','',0,{Module1.nehaid},'No','{strTime}')";
                            
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                finally
                {
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

        // Token: 0x0600097C RID: 2428 RVA: 0x002DFD08 File Offset: 0x002DE108
        public void save_all4()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataThirdParty.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, 0, false))
                            {
                                string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{RuntimeHelpers.GetObjectValue(Module1.sessionid)},'{this.txtdate.Text}','Session','',0,{Module1.nehaid},'No','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdText);
                                }
                            }
                        }
                    }
                }
                finally
                {
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

        // Token: 0x0600097D RID: 2429 RVA: 0x002DFF6C File Offset: 0x002DE36C
        public void save_all5()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataCommision.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, 0, false))
                            {
                                string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{RuntimeHelpers.GetObjectValue(Module1.sessionid)},'{this.txtdate.Text}','Session','',0,{Module1.nehaid},'No','{strTime}')";
                                
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdText);
                                }
                            }
                        }
                    }
                }
                finally
                {
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

        // Token: 0x0600097E RID: 2430 RVA: 0x002E01D0 File Offset: 0x002DE5D0
        public void save_all6()
        {
            try
            {
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataSHRI.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, 0, false))
                            {
                                
                                string cmdText = $"insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_Monday_Final,tns_time) values('{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)}',{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)},'{RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)}',{RuntimeHelpers.GetObjectValue(Module1.sessionid)},'{this.txtdate.Text}','Session','',0,{Module1.nehaid},'No','{strTime}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdText);
                                }
                            }
                        }
                    }
                }
                finally
                {
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
                
        // Token: 0x06000981 RID: 2433 RVA: 0x002E0558 File Offset: 0x002DE958
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Token: 0x040003AD RID: 941
        private TextBox txtdate;

        private void txtrun_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtrun.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        Save.Focus();
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





