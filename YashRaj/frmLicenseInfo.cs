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
using Newtonsoft.Json.Linq;

namespace YashAksh
{
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo()
        {
            this.InitializeComponent();
        }

        private void Session_Report_Load(object sender, EventArgs e)
        {
            try
            {
                this.AllLicense();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public void AllLicense()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string cmdText = "Select * from License ORDER BY id ";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index].Cells[0].Value = oleDbDataReader["id"].ToString();
                    this.DataGridView2.Rows[index].Cells[1].Value = oleDbDataReader["SystemName"].ToString();
                    this.DataGridView2.Rows[index].Cells[2].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["ExpiryDate"].ToString()), DateFormat.ShortDate);
                }

                if (this.DataGridView2.RowCount != 0)
                {
                    this.DataGridView2.Rows[0].Cells[1].Selected = true;
                    this.DataGridView2.Focus();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DataGridView2.RowCount != 0)
                {
                    if (Interaction.MsgBox("Do you want to delete this record", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }

                        string cmdText = $"DELETE from License where id= {this.DataGridView2.CurrentRow.Cells[0].Value}";
                        using (LicensesService licensesService = new LicensesService())
                        {
                            licensesService.Update(cmdText);
                        }
                        this.AllLicense();
                        if (this.DataGridView2.RowCount <= 0)
                        {
                            Application.Restart();
                        }
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
        public string _MYdate;

        private void btndeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DataGridView2.RowCount != 0)
                {
                    if (Interaction.MsgBox("Do you want to delete this record", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }

                        string cmdText = $"DELETE from License";
                        using (LicensesService licensesService = new LicensesService())
                        {
                            licensesService.Update(cmdText);
                        }
                        Application.Restart();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUpdateKey_Click(object sender, EventArgs e)
        {
            string strName = "";
            string strMobileNo = "";
            string strRemark = "";
            if (Module1.conn.State == ConnectionState.Closed)
            {
                Module1.conn.Open();
            }
            string cmdText = "select * from Settings";
            OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            if (oleDbDataReader.Read())
            {
                strName = oleDbDataReader["Name"].ToString();
                strMobileNo = oleDbDataReader["MobileNo"].ToString();
                strRemark = oleDbDataReader["Remark"].ToString();
            }
            var version = BaseService.GetVersion();
            var response = await Algo.License.License.UpdateKey(App.Service.BaseService.APIUrl, strName, strMobileNo, strRemark, version);
            if (response.result)
            {
                var strobjKey = JObject.FromObject(response.data);
                string strKey = Convert.ToString(strobjKey["Key"]);
                string strSystemName = Environment.MachineName;
                string cmdTextupdate = $"update License set LicenseKey = '{strKey}' where SystemName = '{strSystemName}'";
                using (LicensesService licensesService = new LicensesService())
                {
                    licensesService.Update(cmdTextupdate);
                }
                MessageBox.Show("Key Updated Successfully");
                Application.Restart();
            }
            else
            {
                MessageBox.Show(response.message, "Update Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

