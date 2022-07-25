using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using App.Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using YashAksh.My;
using App.Service;

namespace YashAksh
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            this.InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            lblSystemName.Text = Environment.MachineName;
            gpbKey.Visible = false;
            btnRegisterKey.Visible = false;
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
            //ProjectData.EndApp();
            Module1.conn.Close();
            Application.Exit();
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
                var Name = txtName.Text;
                var MobileNo = txtMobileNo.Text;
                var Remark = txtRemark.Text;
                Algo.License.License license = new Algo.License.License();
                var version = BaseService.GetVersion();
                var response = await license.CreateAccount(App.Service.BaseService.APIUrl, Name, MobileNo, Remark, version);
                if (response.result)
                {
                    Module1.conn.Close();
                    string cmdTextU = $"update Settings set Name='{txtName.Text}',MobileNo = '{txtMobileNo.Text}', Remark = '{txtRemark.Text}'";
                    using (SettingService settingService = new SettingService())
                    {
                        settingService.Update(cmdTextU);
                    }
                    MessageBox.Show("Registration Info Created");
                    gpbKey.Visible = true;
                    btnRegisterKey.Visible = true;
                }
                else
                {
                    MessageBox.Show(response.message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnRegisterKey_Click(object sender, EventArgs e)
        {
            try
            {
                var Key = txtKey.Text;
                var Name = txtName.Text;
                var MobileNo = txtMobileNo.Text;
                var Remark = txtRemark.Text;
                Algo.License.License license = new Algo.License.License();
                var responsekey = await license.CheckLicencing(App.Service.BaseService.APIUrl, Key, Name, MobileNo, Remark);
                if (responsekey.result)
                {
                    Module1.conn.Close();
                    var obj = JObject.FromObject(responsekey.data);
                    App.Utility.ErrorLog.LogError("Check ExpiryDate", Convert.ToDateTime(obj["ExpiryDate"]).ToString());
                    string cmdText = $"insert into License(SystemName,LicenseKey,ExpiryDate) values('{lblSystemName.Text}','{Key}','{Convert.ToDateTime(obj["ExpiryDate"])}')";
                    using (LicensesService licensesService = new LicensesService())
                    {
                        licensesService.Update(cmdText);
                    }
                    RegistryOperation registryOperation = new RegistryOperation();
                    registryOperation.StoreValue(Key, Convert.ToString(Convert.ToDateTime(obj["ExpiryDate"])).ToString());
                    MessageBox.Show("Registration Successful");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show(responsekey.message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}

