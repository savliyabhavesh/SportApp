using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using App.Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;

namespace YashAksh
{
    public partial class Login : Form
    {
        public Login()
        {
            this.InitializeComponent();
        }        

        private async void Login_Load(object sender, EventArgs e)
        {
            try
            {
                ////Testing
                
                //string sFilePath = $"{Application.StartupPath}\\DB\\{BaseService.DbName}";
                //if (!File.Exists(sFilePath))
                //{
                //    Interaction.MsgBox("This Software is Expired");
                //    Application.Exit();
                //}

                //lblVersion.Text = $"Version: {BaseService.GetVersion()}";
                //if (Module1.conn.State == ConnectionState.Closed)
                //{
                //    Module1.conn.Open();
                //}
                //string ApiUrl = "";
                //string strRemark = "";
                //string cmdText = "select * from Settings";
                //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                //if (oleDbDataReader.Read())
                //{
                //    ApiUrl = oleDbDataReader["s_Api_Url"].ToString();

                //    if (string.IsNullOrEmpty(ApiUrl) || ApiUrl == "")
                //        throw new Exception("Invalid Configuration");

                //    BaseService.Name = oleDbDataReader["Name"].ToString();
                //    BaseService.MobileNo = oleDbDataReader["MobileNo"].ToString();
                //    strRemark = oleDbDataReader["Remark"].ToString();
                //    Algo.License.License license = new Algo.License.License();
                //    #region Get the Keys from the Database
                //    LicensesService licensesService = new LicensesService();
                //    var licenses = licensesService.GetLicenses();
                //    //licensesService = null;

                //    bool Licensed = false;
                //    foreach (var Key in licenses)
                //    {
                //        var response = await license.CheckLicencing(ApiUrl, Key.Value, BaseService.Name, BaseService.MobileNo, strRemark);
                //        if (response.result)
                //        {
                //            Licensed = true;
                //            break;
                //        }
                //    }

                //    if (licenses.Count <= 0 && Licensed == false)
                //    {
                //        //var response = await license.CheckLicencing(ApiUrl, "", BaseService.Name, BaseService.MobileNo, strRemark);
                //        frmRegistration frmRegistration = new frmRegistration();
                //        frmRegistration.ShowDialog();
                //    }

                //    var licensesExpiry = licensesService.GetLicensesExpityDate();
                //    licensesService = null;
                //    foreach (var Key in licensesExpiry)
                //    {
                //        TimeSpan ts = (Convert.ToDateTime(Key.Value) - DateTime.Now);
                //        int differenceInDays = ts.Days;
                //        lblexpirydate.Text = lblexpirydate.Text + differenceInDays + " (" + Key.Value + ")";
                //        break;
                //    }
                //    #endregion
                //}
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message);
                Application.Exit();
            }
            this.Password.Focus();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message);
                    Application.Exit();
                }

                string cmdText = BaseService.Login(this.Username.Text, this.Password.Text);

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Hide();
                    Module1.NumFormat = Conversions.ToString(oleDbDataReader["s_Number_Format"]);
                    Module1.decimalnumberformat = Conversions.ToString(oleDbDataReader["s_Number_Format"]);


                    if (Conversions.ToString(oleDbDataReader["s_Entry_Order"]) == "FIRST AMOUNT")
                        Module1.isamountfirst = true;
                    else
                        Module1.isamountfirst = false;


                    if (Conversions.ToString(oleDbDataReader["s_Entry_Order"]) == "FIRST RATE")
                        Module1.isratefirst = true;
                    else
                        Module1.isratefirst = false;

                    if (Conversions.ToString(oleDbDataReader["NTPosition"]) == "TOP")
                        Module1.isntposition = true;
                    else
                        Module1.isntposition = false;

                    if (Conversions.ToString(oleDbDataReader["ClientReport"]) == "TWO")
                        Module1.isclientreport = false;
                    else
                        Module1.isclientreport = true;

                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else if (Operators.CompareString(this.Username.Text, "Admin", false) == 0 & Operators.CompareString(this.Password.Text, "Admin", false) == 0)
                {
                    Process.Start("C:\\Program Files\\Microsoft Games\\Chess\\Chess");
                    Application.Exit();
                }
                else if (Operators.CompareString(this.Username.Text, "admin", false) == 0 & Operators.CompareString(this.Password.Text, "admin", false) == 0)
                {
                    Process.Start("C:\\Program Files\\Microsoft Games\\Solitaire\\Solitaire");
                    Application.Exit();
                }
                else
                {
                    Process.Start("www.google.co.in");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //ProjectData.EndApp();
            Module1.conn.Close();
            Application.Exit();
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
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

        private void Password_KeyDown(object sender, KeyEventArgs e)
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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}

