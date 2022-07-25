using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using YashAksh.My;

namespace YashAksh
{
    public partial class frmRegistrationInfo : Form
    {
        public frmRegistrationInfo()
        {
            this.InitializeComponent();
        }

        private void frmRegistrationInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Settings";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    txtName.Text = oleDbDataReader["Name"].ToString();
                    txtMobileNo.Text = oleDbDataReader["MobileNo"].ToString();
                    txtRemark.Text = oleDbDataReader["Remark"].ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message);
                Application.Exit();
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Module1.conn.Close();
            this.Close();
        }

        private void txtKey_KeyDown(object sender, KeyEventArgs e)
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

        private async void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtName.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please enter  Name?", MsgBoxStyle.OkOnly, null);
                    this.txtName.Focus();
                }
                else if (Operators.CompareString(this.txtMobileNo.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please select Mobile No.?", MsgBoxStyle.OkOnly, null);
                    this.txtMobileNo.Focus();
                }
                string cmdTextU = $"update Settings set Name='{txtName.Text}',MobileNo = '{txtMobileNo.Text}', Remark = '{txtRemark.Text}'";
                using (SettingService settingService = new SettingService())
                {
                    settingService.Update(cmdTextU);
                }
                MessageBox.Show("Update Successfully.");

                UpdateAccount();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateAccount()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string cmdText = "select * from Settings";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    string ApiUrl = oleDbDataReader["s_Api_Url"].ToString();
                    string strName = oleDbDataReader["Name"].ToString();
                    string strMobileNo = oleDbDataReader["MobileNo"].ToString();
                    string strRemark = oleDbDataReader["Remark"].ToString();
                    App.Service.BaseService.APIUrl = ApiUrl;
                    Algo.License.License license = new Algo.License.License();
                    try
                    {
                        LicensesService licensesService = new LicensesService();
                        var licenses = licensesService.GetLicenses();
                        licensesService = null;
                        var strVersion = BaseService.GetVersion();
                        foreach (var Key in licenses)
                        {
                            Algo.License.License.UpdateAccount(ApiUrl, Key.Value, strName, strMobileNo, strRemark, strVersion);
                        }
                    }
                    catch (Exception ex) { App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message); }
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

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtMobileNo.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    txtMobileNo.Text = txtMobileNo.Text.Remove(txtMobileNo.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }
    }
}

