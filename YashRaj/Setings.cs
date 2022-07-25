using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using App.Service;

namespace YashAksh
{
    public partial class Setings : Form
    {

        string OldCompanyAccountName = "";
        public Setings()
        {
            this.InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkLock.Checked == true)
                {
                    string sDirPath = Application.StartupPath + "\\DB";
                    string sFilePath = $"{Application.StartupPath}\\DB\\{BaseService.DbName}";

                    if (Directory.Exists(sDirPath) && File.Exists(sFilePath))
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(sFilePath, "Config.txt");
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(sDirPath, "Config");

                        Process[] _proceses = Process.GetProcessesByName("ShubhLabh");
                        foreach (Process proces in _proceses)
                        {
                            proces.Kill();
                        }
                        Application.Exit();
                    }
                }

                if (Operators.CompareString(this.txtCompanyAccount.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please Enter Company Account Name", MsgBoxStyle.OkOnly, null);
                    this.txtCompanyAccount.Focus();
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "Update Settings set s_Password='",
                        this.txtpassword.Text,
                        "',s_Username='ADMIN',s_Number_Format='",
                        this.cmbNumberFormat.Text == "FULL AMOUNT" ? "" : Conversions.ToString(this.cmbNumberFormat.Text),
                        "',s_Company_Account='",
                        Conversions.ToString(this.txtCompanyAccount.Text),
                        "',s_Entry_Order='",
                        Conversions.ToString(this.cmbEntryOrder.Text),
                        "',NTPosition='",
                        Conversions.ToString(this.cmbNTPosition.Text),
                        "',ClientReport='",
                        Conversions.ToString(this.cmbClinetReport.Text),
                        "' Where s_ID=1"
                    });
                    using (SettingService settingService = new SettingService())
                    {
                        settingService.Update(cmdText);
                    }

                    if (OldCompanyAccountName != Conversions.ToString(this.txtCompanyAccount.Text))
                    {
                        string str1 = $"UPDATE PartyMaster SET PartyName = '{Conversions.ToString(this.txtCompanyAccount.Text)}' WHERE Id=1 AND PartyName = '{OldCompanyAccountName}'";

                        string str2 = $"UPDATE Trans SET tns_Party = '{Conversions.ToString(this.txtCompanyAccount.Text)}' WHERE tns_Party = '{OldCompanyAccountName}'";
                        using (TransactionService transactionService = new TransactionService())
                        {
                            transactionService.Insert(str1);
                            transactionService.Insert(str2);
                        }
                    }

                    if (Conversion.Val(txtOpeningBalance.Text) != 0)
                    {
                        string str = "select * from Trans where tns_party = '" + this.txtCompanyAccount.Text + "' AND tns_Type='BALANCE' ";
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(str, Module1.conn);
                        DataTable dt = new DataTable();
                        oleDbDataAdapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            string cmdText32 = $"INSERT INTO Trans ([tns_party], [tns_Amount], [tns_Remark], [tns_MatchID], [tns_dt], [tns_Type], [tns_Vid], [tns_Monday], [tns_Sessionid], [tns_ModifyID], [tns_Monday_Final], [tns_Hawala], [tns_chk], [tns_time]) VALUES ('{this.txtCompanyAccount.Text.ToUpper()}',{this.txtOpeningBalance.Text}'Opening Balance','0','{this.txtdate.Text}','BALANCE',0,0,0,0,'No','','0','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}'";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText32);
                            }
                        }
                    }

                    Module1.NumFormat = this.cmbNumberFormat.Text == "FULL AMOUNT" ? "" : Conversions.ToString(this.cmbNumberFormat.Text);
                    Module1.decimalnumberformat = this.cmbNumberFormat.Text == "FULL AMOUNT" ? "" : Conversions.ToString(this.cmbNumberFormat.Text);

                    if (this.cmbEntryOrder.Text == "FIRST AMOUNT")
                        Module1.isamountfirst = true;
                    else
                        Module1.isamountfirst = false;


                    if (this.cmbEntryOrder.Text == "FIRST RATE")
                        Module1.isratefirst = true;
                    else
                        Module1.isratefirst = false;

                    if (this.cmbNTPosition.Text == "TOP")
                        Module1.isntposition = true;
                    else
                        Module1.isntposition = false;

                    if (this.cmbClinetReport.Text == "TWO")
                        Module1.isclientreport = false;
                    else
                        Module1.isclientreport = true;

                    MessageBox.Show("Record Saved");
                    this.Close();
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

        public void showall()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Settings where s_ID=1";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.txtpassword.Text = Conversions.ToString(oleDbDataReader["s_Password"]);

                    this.cmbNumberFormat.Text = Conversions.ToString(oleDbDataReader["s_Number_Format"]) == "" ? "FULL AMOUNT" : Conversions.ToString(oleDbDataReader["s_Number_Format"]);
                    this.cmbEntryOrder.Text = Conversions.ToString(oleDbDataReader["s_Entry_Order"]) == "" ? "FIRST AMOUNT" : Conversions.ToString(oleDbDataReader["s_Entry_Order"]);
                    this.cmbNTPosition.Text = Conversions.ToString(oleDbDataReader["NTPosition"]) == "" ? "TOP" : Conversions.ToString(oleDbDataReader["NTPosition"]);
                    this.cmbClinetReport.Text = Conversions.ToString(oleDbDataReader["NTPosition"]) == "" ? "TWO" : Conversions.ToString(oleDbDataReader["ClientReport"]);
                    this.txtCompanyAccount.Text = Conversions.ToString(oleDbDataReader["s_Company_Account"]);
                    this.OldCompanyAccountName = Conversions.ToString(oleDbDataReader["s_Company_Account"]);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setings_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                this.showall();
                this.txtdate.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtOpeningBalance_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtOpeningBalance.Text != "")
                {
                    this.txtOpeningBalance.Text = Module1.SetNumFormat(Conversion.Val(this.txtOpeningBalance.Text), Module1.decimalnumberformat);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void cmbNumberFormat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && Conversions.ToString(this.cmbNumberFormat.Text) != "")
                {
                    this.txtCompanyAccount.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtCompanyAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && Conversions.ToString(this.txtCompanyAccount.Text) != "")
                {
                    this.txtOpeningBalance.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtOpeningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && Conversion.Val(this.txtOpeningBalance.Text) != 0)
                {
                    this.txtpassword.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && Conversions.ToString(this.txtpassword.Text) != "")
                {
                    this.btnsave.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }
    }
}

