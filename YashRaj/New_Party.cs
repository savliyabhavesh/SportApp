using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using App.Service;
using App.Service.Data;

namespace YashAksh
{
    //[DesignerGenerated]
    public partial class New_Party : Form
    {
        double chkopbal = 0;
        string oldpartyname = "";
        public New_Party()
        {
            this.InitializeComponent();
        }

        private void New_Party_Activated(object sender, EventArgs e)
        {
            try
            {
                this.txtPartyName.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void New_Party_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtdate.Hide();
                this.CapitalAll();
                this.AutoId();
                this.BindCombo();
                this.Reset();
                this.ModifyParty();

                if (cmbAParty.Text != "")
                {
                    this.EnableDisableAgentTextBox(true);
                }
                else
                {
                    this.EnableDisableAgentTextBox(false);
                }

                if (cmbTParty.Text != "")
                {
                    this.EnableDisableThirdPartyTextBox(true);
                }
                else
                {
                    this.EnableDisableThirdPartyTextBox(false);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void ModifyParty()
        {
            try
            {
                if (Module1.modifypartyid != 0 && Module1.modifypartyname != "")
                {
                    this.txtId.Text = Module1.modifypartyid.ToString();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "Select * from PartyMaster where Id = " + this.txtId.Text + "";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        txtPartyName.Text = Conversions.ToString(oleDbDataReader["PartyName"]);
                        oldpartyname = Conversions.ToString(oleDbDataReader["PartyName"]);

                        cmbStatus.Text = Conversions.ToString(oleDbDataReader["Status"]);
                        if (Conversions.ToString(oleDbDataReader["Status"]) == "Regular")
                        {
                            rbGive.Checked = true;
                        }
                        else if (Conversions.ToString(oleDbDataReader["Status"]) == "Booky")
                        {
                            rbTake.Checked = true;
                        }

                        this.chkopbal = Conversion.Val(oleDbDataReader["OpeningBalance"]);
                        txtOpeningBal.Text = Conversion.Val(oleDbDataReader["BalanceLimit"]) != 0 ? Conversions.ToString(oleDbDataReader["BalanceLimit"]) : "0";
                        cmbMatchCommiType.Text = Conversions.ToString(oleDbDataReader["MatchCommiType"]);
                        txtRate.Text = Conversion.Val(oleDbDataReader["Rate"]) > 0 ? Conversions.ToString(oleDbDataReader["Rate"]) : "0";

                        txtSMatch.Text = Conversion.Val(oleDbDataReader["SMatch"]) != 0 ? Conversions.ToString(oleDbDataReader["SMatch"]) : "0";
                        txtSSession.Text = Conversion.Val(oleDbDataReader["SSession"]) != 0 ? Conversions.ToString(oleDbDataReader["SSession"]) : "0";
                        txtSAbandon.Text = Conversion.Val(oleDbDataReader["SAbandon"]) != 0 ? Conversions.ToString(oleDbDataReader["SAbandon"]) : "0";
                        txtSTie.Text = Conversion.Val(oleDbDataReader["STie"]) != 0 ? Conversions.ToString(oleDbDataReader["STie"]) : "0";
                        txtSCup.Text = Conversion.Val(oleDbDataReader["SCup"]) != 0 ? Conversions.ToString(oleDbDataReader["SCup"]) : "0";
                        txtSMatchCommi.Text = Conversion.Val(oleDbDataReader["SMatchCommi"]) != 0 ? Conversions.ToString(oleDbDataReader["SMatchCommi"]) : "0";
                        txtSSessionCommi.Text = Conversion.Val(oleDbDataReader["SSessionCommi"]) != 0 ? Conversions.ToString(oleDbDataReader["SSessionCommi"]) : "0";

                        cmbAParty.Text = oleDbDataReader["AParty"] != System.DBNull.Value ? Conversions.ToString(oleDbDataReader["AParty"]) : "";
                        txtAMatch.Text = Conversion.Val(oleDbDataReader["AMatch"]) != 0 ? Conversions.ToString(oleDbDataReader["AMatch"]) : "0";
                        txtASession.Text = Conversion.Val(oleDbDataReader["ASession"]) != 0 ? Conversions.ToString(oleDbDataReader["ASession"]) : "0";
                        txtAAbandon.Text = Conversion.Val(oleDbDataReader["AAbandon"]) != 0 ? Conversions.ToString(oleDbDataReader["AAbandon"]) : "0";
                        txtATie.Text = Conversion.Val(oleDbDataReader["ATie"]) != 0 ? Conversions.ToString(oleDbDataReader["ATie"]) : "0";
                        txtACup.Text = Conversion.Val(oleDbDataReader["ACup"]) != 0 ? Conversions.ToString(oleDbDataReader["ACup"]) : "0";
                        txtAMatchCommi.Text = Conversion.Val(oleDbDataReader["AMatchCommi"]) != 0 ? Conversions.ToString(oleDbDataReader["AMatchCommi"]) : "0";
                        txtASessionCommi.Text = Conversion.Val(oleDbDataReader["ASessionCommi"]) != 0 ? Conversions.ToString(oleDbDataReader["ASessionCommi"]) : "0";

                        cmbTParty.Text = oleDbDataReader["TParty"] != System.DBNull.Value ? Conversions.ToString(oleDbDataReader["TParty"]) : "";
                        txtTMatch.Text = Conversion.Val(oleDbDataReader["TMatch"]) != 0 ? Conversions.ToString(oleDbDataReader["TMatch"]) : "0";
                        txtTSession.Text = Conversion.Val(oleDbDataReader["TSession"]) != 0 ? Conversions.ToString(oleDbDataReader["TSession"]) : "0";
                        txtTAbandon.Text = Conversion.Val(oleDbDataReader["TAbandon"]) != 0 ? Conversions.ToString(oleDbDataReader["TAbandon"]) : "0";
                        txtTTie.Text = Conversion.Val(oleDbDataReader["TTie"]) != 0 ? Conversions.ToString(oleDbDataReader["TTie"]) : "0";
                        txtTCup.Text = Conversion.Val(oleDbDataReader["TCup"]) != 0 ? Conversions.ToString(oleDbDataReader["TCup"]) : "0";
                        txtTMatchCommi.Text = Conversion.Val(oleDbDataReader["TMatchCommi"]) != 0 ? Conversions.ToString(oleDbDataReader["TMatchCommi"]) : "0";
                        txtTSessionCommi.Text = Conversion.Val(oleDbDataReader["TSessionCommi"]) != 0 ? Conversions.ToString(oleDbDataReader["TSessionCommi"]) : "0";


                    }
                    cmbStatus.Focus();
                    //txtPartyName.Enabled = false;
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtPartyName.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please enter Party Name?", MsgBoxStyle.OkOnly, null);
                    this.txtPartyName.Focus();
                }
                else if (Operators.CompareString(this.cmbStatus.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please select Staus?", MsgBoxStyle.OkOnly, null);
                    this.cmbStatus.Focus();
                }
                else if (Operators.CompareString(this.cmbMatchCommiType.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please select Match Commission?", MsgBoxStyle.OkOnly, null);
                    this.cmbMatchCommiType.Focus();
                }
                else if (Operators.CompareString(this.cmbMatchCommiType.Text, "Per Peti", false) == 0 && Operators.CompareString(this.txtRate.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please enter Rate?", MsgBoxStyle.OkOnly, null);
                    this.txtRate.Focus();
                }

                else
                {
                    this.SetAllTextboxValue00();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select * from PartyMaster where PartyName = '" + this.txtPartyName.Text + "'";
                    //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    DataTable response;
                    using (BaseRepository repo = new BaseRepository())
                    {
                        response = repo.Get(cmdText);
                    }
                    if (response.Rows.Count > 0)
                    //if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Party Name Already Exist..?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        Module1.conn.Close();
                        string cmdText2 = $"INSERT INTO PartyMaster ([Id], [PartyName], [Status], [BalanceLimit], [MatchCommiType], [Rate], SMatch, SSession, SAbandon, STie, SCup, SMatchCommi, SSessionCommi, AParty, AMatch, ASession, AAbandon, ATie, ACup, AMatchCommi, ASessionCommi, TParty, TMatch, TSession, TAbandon, TTie, TCup, TMatchCommi, TSessionCommi, EntryDate, EntryTime ) VALUES ({this.txtId.Text},'{this.txtPartyName.Text.ToUpper()}','{this.cmbStatus.Text}',{this.txtOpeningBal.Text},'{this.cmbMatchCommiType.Text}',{this.txtRate.Text},{this.txtSMatch.Text},{this.txtSSession.Text},{this.txtSAbandon.Text},{this.txtSTie.Text},{this.txtSCup.Text},{this.txtSMatchCommi.Text},{this.txtSSessionCommi.Text},'{this.cmbAParty.Text.ToUpper()}',{this.txtAMatch.Text},{this.txtASession.Text},{this.txtAAbandon.Text},{this.txtATie.Text},{this.txtACup.Text},{this.txtAMatchCommi.Text},{this.txtASessionCommi.Text},'{this.cmbTParty.Text.ToUpper()}',{this.txtTMatch.Text},{this.txtTSession.Text},{this.txtTAbandon.Text},{this.txtTTie.Text},{this.txtTCup.Text},{this.txtTMatchCommi.Text},{this.txtTSessionCommi.Text},'{this.txtdate.Text}','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                        using (PartyMasterService partyMasterService = new PartyMasterService())
                        {
                            partyMasterService.Update(cmdText2);
                        }

                        if (Conversion.Val(txtOpeningBal.Text) != 0)
                        {
                            string cmdText32 = $"INSERT INTO Trans ([tns_party], [tns_Amount], [tns_Remark], [tns_MatchID], [tns_dt], [tns_Type], [tns_Vid], [tns_Monday], [tns_Sessionid], [tns_ModifyID], [tns_Monday_Final], [tns_Hawala], [tns_chk], [tns_time]) VALUES ('{this.txtPartyName.Text.ToUpper()}',{this.txtOpeningBal.Text},'Opening Balance',0,'{this.txtdate.Text}','BALANCE','0','0',0,0,'No','','0','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText32);
                            }
                        }
                        cmdText = $"UPDATE tb_MYID SET tb_PID = {this.txtId.Text}";
                        using (SettingService settingService = new SettingService())
                        {
                            settingService.Update(cmdText);
                        }
                        Interaction.MsgBox("Record saved..?", MsgBoxStyle.OkOnly, null);
                        this.Reset();
                        this.AutoId();
                        this.BindCombo();
                    }

                    //object right = "Monday Final " + Conversions.ToString(DateTime.Now.Date);
                    //string cmdText3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk) VALUES('" + this.txtPartyName.Text + "',0.00,'", right), "','0','"), DateTime.Now.Date), "','Monday Settlement','0','0','0',0,'Yes','','0')"));
                    //OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                    //oleDbCommand3.ExecuteNonQuery();                    
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtPartyName.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please enter Party Name?", MsgBoxStyle.OkOnly, null);
                    this.txtPartyName.Focus();
                }
                else if (Operators.CompareString(this.cmbStatus.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please select Staus?", MsgBoxStyle.OkOnly, null);
                    this.cmbStatus.Focus();
                }
                else if (Operators.CompareString(this.cmbMatchCommiType.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please select Match Commission?", MsgBoxStyle.OkOnly, null);
                    this.cmbMatchCommiType.Focus();
                }
                else if (Operators.CompareString(this.cmbMatchCommiType.Text, "Per Peti", false) == 0 && Operators.CompareString(this.txtRate.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please enter Rate?", MsgBoxStyle.OkOnly, null);
                    this.txtRate.Focus();
                }

                else
                {
                    this.SetAllTextboxValue00();
                    Module1.conn.Close();
                    string cmdText = "select * from PartyMaster where PartyName = '" + this.txtPartyName.Text + "' And Id <>" + this.txtId.Text.ToString() + "";
                    //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);

                    //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    DataTable response;
                    using (BaseRepository repo = new BaseRepository())
                    {
                        response = repo.Get(cmdText);
                    }
                    if (response.Rows.Count > 0)

                    //if (oleDbDataReader.Read() && oldpartyname != txtPartyName.Text)
                    {
                        Interaction.MsgBox("Party Name Already Exist..?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = $"UPDATE PartyMaster SET [PartyName]='{this.txtPartyName.Text.ToUpper()}', [Status]='{this.cmbStatus.Text}', [BalanceLimit]={this.txtOpeningBal.Text}, [MatchCommiType]='{this.cmbMatchCommiType.Text}', [Rate]={this.txtRate.Text}, SMatch={this.txtSMatch.Text}, SSession={this.txtSSession.Text}, SAbandon={this.txtSAbandon.Text}, STie={this.txtSTie.Text}, SCup={this.txtSCup.Text}, SMatchCommi={this.txtSMatchCommi.Text}, SSessionCommi={this.txtSSessionCommi.Text}, AParty='{this.cmbAParty.Text.ToUpper()}', AMatch={this.txtAMatch.Text}, ASession={this.txtASession.Text}, AAbandon={this.txtAAbandon.Text}, ATie={this.txtATie.Text}, ACup={this.txtACup.Text}, AMatchCommi={this.txtAMatchCommi.Text}, ASessionCommi={this.txtASessionCommi.Text}, TParty='{this.cmbTParty.Text.ToUpper()}', TMatch={this.txtTMatch.Text}, TSession={this.txtTSession.Text}, TAbandon={this.txtTAbandon.Text}, TTie={this.txtTTie.Text}, TCup={this.txtTCup.Text}, TMatchCommi={this.txtTMatchCommi.Text}, TSessionCommi={this.txtTSessionCommi.Text}, UpdateDate='{this.txtdate.Text}', UpdateTime='{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' WHERE Id={this.txtId.Text.ToString()}";
                        Module1.conn.Close();
                        using (PartyMasterService partyMasterService = new PartyMasterService())
                        {
                            partyMasterService.Update(cmdText2);
                        }

                        ////// Update Party name In All Table
                        if (oldpartyname != txtPartyName.Text)
                        {
                            string cmdUpdateText = "";
                            OleDbCommand oleDbUpdateCommand;

                            cmdUpdateText = $"update Abdntie set Party_Name = '{txtPartyName.Text}' where Party_Name = '{oldpartyname}'  ";
                            string cmdUpdateText1 = $"update BadlaTrn set party = '{txtPartyName.Text}' where party = '{oldpartyname}'  ";
                            string cmdUpdateText2 = $"update CupTrans set m_party = '{txtPartyName.Text}' where m_party = '{oldpartyname}'  ";
                            string cmdUpdateText3 = $"update MatchTrans set m_party = '{txtPartyName.Text}' where m_party = '{oldpartyname}'  ";
                            string cmdUpdateText4 = $"update MatchTrans1 set m_party = '{txtPartyName.Text}' where m_party = '{oldpartyname}'  ";
                            string cmdUpdateText5 = $"update SessionTrans set s_party = '{txtPartyName.Text}' where s_party = '{oldpartyname}'  ";
                            string cmdUpdateText6 = $"update temptbl set tns_party = '{txtPartyName.Text}' where tns_party = '{oldpartyname}'  ";
                            string cmdUpdateText7 = $"update Trans set tns_party = '{txtPartyName.Text}',tns_Amount = '{txtOpeningBal.Text}' where tns_party = '{oldpartyname}'  ";
                            string cmdUpdateText8 = $"update PartyMaster set AParty = '{txtPartyName.Text}' where AParty = '{oldpartyname}'  ";
                            string cmdUpdateText9 = $"update PartyMaster set TParty = '{txtPartyName.Text}' where TParty = '{oldpartyname}'  ";
                            Module1.conn.Close();
                            using (PartyMasterService partyMasterService = new PartyMasterService())
                            {
                                partyMasterService.Update(cmdUpdateText);
                                partyMasterService.Update(cmdUpdateText1);
                                partyMasterService.Update(cmdUpdateText2);
                                partyMasterService.Update(cmdUpdateText3);
                                partyMasterService.Update(cmdUpdateText4);
                                partyMasterService.Update(cmdUpdateText5);
                                partyMasterService.Update(cmdUpdateText6);
                                partyMasterService.Update(cmdUpdateText7);
                                partyMasterService.Update(cmdUpdateText8);
                                partyMasterService.Update(cmdUpdateText9);
                            }
                        }

                        if (Conversion.Val(txtOpeningBal.Text) != 0)
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }
                            string str = "select * from Trans where tns_party = '" + this.txtPartyName.Text + "' AND tns_Type='BALANCE' ";
                            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(str, Module1.conn);
                            DataTable dt = new DataTable();
                            oleDbDataAdapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                string cmdText32 = $"INSERT INTO Trans ([tns_party], [tns_Amount], [tns_Remark], [tns_MatchID], [tns_dt], [tns_Type], [tns_Vid], [tns_Monday], [tns_Sessionid], [tns_ModifyID], [tns_Monday_Final], [tns_Hawala], [tns_chk], [tns_time]) VALUES ('{this.txtPartyName.Text.ToUpper()}',{this.txtOpeningBal.Text},'Opening Balance',0,'{this.txtdate.Text}','BALANCE','0','0',0,0,'No','','0','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                                Module1.conn.Close();
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdText32);
                                }
                            }
                            else
                            {
                                string cmdUpdateText = $"update Trans set tns_party = '{txtPartyName.Text}',tns_Amount = '{txtOpeningBal.Text}' where tns_party = '{oldpartyname}'  ";
                                Module1.conn.Close();
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdUpdateText);
                                }
                            }

                        }
                        else
                        {
                            string cmdUpdateText7 = $"update Trans set tns_party = '{txtPartyName.Text}',tns_Amount = '{txtOpeningBal.Text}' where tns_party = '{oldpartyname}'  ";
                            Module1.conn.Close();
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdUpdateText7);
                            }
                        }
                        Interaction.MsgBox("Record Updated..?", MsgBoxStyle.OkOnly, null);
                        this.Close();
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

        private void Reset()
        {
            try
            {
                this.cmbStatus.Text = "Regular";
                this.cmbMatchCommiType.Text = "No Commission";

                this.txtPartyName.Focus();
                this.txtPartyName.Text = "";
                this.txtOpeningBal.Text = "";
                this.txtRate.Text = "";
                this.txtSMatch.Text = "";
                this.txtSSession.Text = "";
                this.txtSAbandon.Text = "";
                this.txtSTie.Text = "";
                this.txtSCup.Text = "";
                this.txtSMatchCommi.Text = "";
                this.txtSSessionCommi.Text = "";

                this.cmbAParty.Text = "";
                this.txtAMatch.Text = "";
                this.txtASession.Text = "";
                this.txtAAbandon.Text = "";
                this.txtATie.Text = "";
                this.txtACup.Text = "";
                this.txtAMatchCommi.Text = "";
                this.txtASessionCommi.Text = "";

                this.cmbTParty.Text = "";
                this.txtTMatch.Text = "";
                this.txtTSession.Text = "";
                this.txtTAbandon.Text = "";
                this.txtTTie.Text = "";
                this.txtTCup.Text = "";
                this.txtTMatchCommi.Text = "";
                this.txtTSessionCommi.Text = "";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public void AutoId()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(tb_PID) from tb_MYID";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.txtId.Text = "1";
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        this.txtId.Text = Conversions.ToString(num);
                    }

                    //string cmdText = "select max(Id) from PartyMaster";
                    //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    //if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    //{
                    //	this.txtId.Text = "1";
                    //}
                    //else
                    //{
                    //	int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                    //	num++;
                    //	this.txtId.Text = Conversions.ToString(num);
                    //}
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

        public void CapitalAll()
        {
            try
            {
                this.txtPartyName.CharacterCasing = CharacterCasing.Upper;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public IEnumerable<Control> GetAllControlsOfType(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControlsOfType(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);

        }

        public void SetAllTextboxValue00()
        {
            try
            {
                IEnumerable<Control> allTxtBxs = GetAllControlsOfType(this, typeof(TextBox));
                foreach (TextBox txt in allTxtBxs)
                {
                    if (txt.Text == "")
                        txt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public void BindCombo()
        {
            try
            {
                this.cmbAParty.Items.Clear();
                this.cmbTParty.Items.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.cmbAParty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                    this.cmbTParty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
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

        public void AutoCompleteAgent(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.cmbAParty.SelectionStart <= 1)
                        {
                            this.cmbAParty.Text = "";
                            return;
                        }
                        if (this.cmbAParty.SelectionLength == 0)
                        {
                            text = this.cmbAParty.Text.Substring(0, this.cmbAParty.Text.Length - 1);
                        }
                        else
                        {
                            text = this.cmbAParty.Text.Substring(0, this.cmbAParty.SelectionStart - 1);
                        }
                    }
                    else if (this.cmbAParty.SelectionLength == 0)
                    {
                        text = this.cmbAParty.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.cmbAParty.Text.Substring(0, this.cmbAParty.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.cmbAParty.FindString(text);
                    if (num != -1)
                    {
                        this.cmbAParty.SelectedText = "";
                        this.cmbAParty.SelectedIndex = num;
                        this.cmbAParty.SelectionStart = text.Length;
                        this.cmbAParty.SelectionLength = this.cmbAParty.Text.Length;
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

        public void AutoCompleteThirdParty(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.cmbTParty.SelectionStart <= 1)
                        {
                            this.cmbTParty.Text = "";
                            return;
                        }
                        if (this.cmbTParty.SelectionLength == 0)
                        {
                            text = this.cmbTParty.Text.Substring(0, this.cmbTParty.Text.Length - 1);
                        }
                        else
                        {
                            text = this.cmbTParty.Text.Substring(0, this.cmbTParty.SelectionStart - 1);
                        }
                    }
                    else if (this.cmbTParty.SelectionLength == 0)
                    {
                        text = this.cmbTParty.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.cmbTParty.Text.Substring(0, this.cmbTParty.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.cmbTParty.FindString(text);
                    if (num != -1)
                    {
                        this.cmbTParty.SelectedText = "";
                        this.cmbTParty.SelectedIndex = num;
                        this.cmbTParty.SelectionStart = text.Length;
                        this.cmbTParty.SelectionLength = this.cmbTParty.Text.Length;
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

        public void EnableDisableAgentTextBox(bool flg)
        {
            try
            {
                txtAMatch.Enabled = flg;
                txtASession.Enabled = flg;
                txtAAbandon.Enabled = flg;
                txtATie.Enabled = flg;
                txtACup.Enabled = flg;
                txtASessionCommi.Enabled = flg;
                if (flg == true && cmbMatchCommiType.Text == "No Commission")
                {
                    txtAMatchCommi.Enabled = false;
                }
                else
                {
                    txtAMatchCommi.Enabled = flg;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void EnableDisableThirdPartyTextBox(bool flg)
        {
            try
            {
                txtTMatch.Enabled = flg;
                txtTSession.Enabled = flg;
                txtTAbandon.Enabled = flg;
                txtTTie.Enabled = flg;
                txtTCup.Enabled = flg;
                txtTSessionCommi.Enabled = flg;
                if (flg == true && cmbMatchCommiType.Text == "No Commission")
                {
                    txtTMatchCommi.Enabled = false;
                }
                else
                {
                    txtTMatchCommi.Enabled = flg;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void cmbAParty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox cmb = this.cmbAParty;
                this.AutoCompleteAgent(ref cmb, e, false);
                this.cmbAParty = cmb;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void cmbAParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (txtAMatch.Enabled == true)
                    {
                        this.txtAMatch.Focus();
                    }
                    else
                    {
                        this.cmbTParty.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void cmbAParty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbAParty.Text != "")
                {
                    this.EnableDisableAgentTextBox(true);
                }
                else
                {
                    txtAMatch.Text = "";
                    txtASession.Text = "";
                    txtAAbandon.Text = "";
                    txtATie.Text = "";
                    txtACup.Text = "";
                    txtAMatchCommi.Text = "";
                    txtASessionCommi.Text = "";
                    this.EnableDisableAgentTextBox(false);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void cmbTParty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox cmb = this.cmbTParty;
                this.AutoCompleteThirdParty(ref cmb, e, false);
                this.cmbTParty = cmb;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void cmbTParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (txtTMatch.Enabled == true)
                    {
                        this.txtTMatch.Focus();
                    }
                    else
                    {
                        if (btnSave.Visible == true)
                        {
                            btnSave.Focus();
                        }
                        else
                        {
                            btnUpdate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void cmbTParty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbTParty.Text != "")
                {
                    this.EnableDisableThirdPartyTextBox(true);
                }
                else
                {
                    txtTMatch.Text = "";
                    txtTSession.Text = "";
                    txtTAbandon.Text = "";
                    txtTTie.Text = "";
                    txtTCup.Text = "";
                    txtTMatchCommi.Text = "";
                    txtTSessionCommi.Text = "";
                    this.EnableDisableThirdPartyTextBox(false);
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
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void All_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{TAB}");
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void cmbMatchCommiType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtRate.Text = "";
                this.txtSMatchCommi.Text = "";
                this.txtAMatchCommi.Text = "";
                this.txtTMatchCommi.Text = "";

                if (cmbMatchCommiType.Text == "No Commission")
                {
                    this.txtSMatchCommi.Enabled = false;
                    this.txtAMatchCommi.Enabled = false;
                    this.txtTMatchCommi.Enabled = false;
                }
                else
                {
                    this.txtSMatchCommi.Enabled = true;
                    if (cmbAParty.Text != "")
                        this.txtAMatchCommi.Enabled = true;
                    else
                        this.txtAMatchCommi.Enabled = false;

                    if (cmbTParty.Text != "")
                        this.txtTMatchCommi.Enabled = true;
                    else
                        this.txtTMatchCommi.Enabled = false;
                }

                if (cmbMatchCommiType.Text == "Per Peti")
                {
                    this.txtRate.Enabled = true;
                    this.lblSMatchCommi.Text = "₹";
                    this.lblAMatchCommi.Text = "₹";
                    this.lblTMatchCommi.Text = "₹";
                }
                else
                {
                    this.txtRate.Enabled = false;
                    this.lblSMatchCommi.Text = "%";
                    this.lblAMatchCommi.Text = "%";
                    this.lblTMatchCommi.Text = "%";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtOpeningBal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtOpeningBal.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        this.txtOpeningBal.Text = Module1.SetNumFormat(Conversion.Val(this.txtOpeningBal.Text), Module1.decimalnumberformat);
                    }
                    cmbMatchCommiType.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
}

private void txtOpeningBal_Leave(object sender, EventArgs e)
{
    if (this.txtOpeningBal.Text != "")
    {
        try
        {
            this.txtOpeningBal.Text = Module1.SetNumFormat(Conversion.Val(this.txtOpeningBal.Text), Module1.decimalnumberformat);
        }
        catch (Exception ex)
        {
            App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        }
    }
}

private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
{
    try
    {
        if (cmbStatus.Text == "Regular")
        {
            rbGive.Checked = true;
            cmbAParty.Enabled = true;
            if (cmbAParty.Text != "")
            {
                this.EnableDisableAgentTextBox(true);
            }
            else
            {
                this.EnableDisableAgentTextBox(false);
            }

            cmbTParty.Enabled = true;
            if (cmbTParty.Text != "")
            {
                this.EnableDisableThirdPartyTextBox(true);
            }
            else
            {
                this.EnableDisableThirdPartyTextBox(false);
            }
        }
        else if (cmbStatus.Text == "Booky")
        {
            rbTake.Checked = true;
        }
        //else if (cmbStatus.Text == "Booky")
        //{
        //    rbTake.Checked = true;
        //    cmbAParty.Text = "";
        //    cmbAParty.Enabled = false;

        //    txtAMatch.Text = "";
        //    txtASession.Text = "";
        //    txtAAbandon.Text = "";
        //    txtATie.Text = "";
        //    txtACup.Text = "";
        //    txtAMatchCommi.Text = "";
        //    txtASessionCommi.Text = "";
        //    this.EnableDisableAgentTextBox(false);

        //    cmbTParty.Text = "";
        //    cmbTParty.Enabled = false;
        //    txtTMatch.Text = "";
        //    txtTSession.Text = "";
        //    txtTAbandon.Text = "";
        //    txtTTie.Text = "";
        //    txtTCup.Text = "";
        //    txtTMatchCommi.Text = "";
        //    txtTSessionCommi.Text = "";
        //    this.EnableDisableThirdPartyTextBox(false);
        //}
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
    }
}

private void txtRate_Leave(object sender, EventArgs e)
{
    try
    {
        if (this.txtRate.Text != "")
        {
            string text = this.txtRate.Text;
            double num = (double)text.IndexOf(".");
            if (num < 0.0)
            {
                this.txtRate.Text = this.txtRate.Text.Replace(this.txtRate.Text, "." + this.txtRate.Text);
            }
        }
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
    }
}

private void New_Party_Deactivate(object sender, EventArgs e)
{
    try
    {
        Module1.modifypartyid = 0;
        Module1.modifypartyname = "";
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
    }
}

private void New_Party_FormClosing(object sender, FormClosingEventArgs e)
{
    try
    {
        Module1.modifypartyid = 0;
        Module1.modifypartyname = "";
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
    }
}

private void txtPartyName_KeyDown(object sender, KeyEventArgs e)
{
    try
    {
        if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
        {
            if (Operators.CompareString(this.txtPartyName.Text, null, false) == 0)
            {
                this.Focus();
            }
            else
            {
                cmbStatus.Focus();
            }
        }
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
    }
}

private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
{
    try
    {
        if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
        {
            if (Operators.CompareString(this.cmbStatus.Text, null, false) == 0)
            {
                this.Focus();
            }
            else
            {
                txtOpeningBal.Focus();
            }
        }
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
    }
}

private void cmbMatchCommiType_KeyDown(object sender, KeyEventArgs e)
{
    try
    {
        if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
        {
            if (Operators.CompareString(this.cmbMatchCommiType.Text, null, false) == 0)
            {
                this.Focus();
            }
            else
            {
                if (txtRate.Enabled == true)
                {
                    txtRate.Focus();
                }
                else
                {
                    txtSMatch.Focus();
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

private void txtRate_KeyDown(object sender, KeyEventArgs e)
{
    try
    {
        if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab)
        {
            if (Operators.CompareString(this.txtRate.Text, null, false) == 0)
            {
                this.Focus();
            }
            else
            {
                txtSMatch.Focus();
            }
        }
    }
    catch (Exception ex)
    {
        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
    }
}

private void txtOpeningBal_KeyPress(object sender, KeyPressEventArgs e)
{
    try
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
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
