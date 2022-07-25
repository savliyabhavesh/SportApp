using App.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YashAksh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Apply Schema Changes
            UpdateSchema();
            #endregion

            #region Checking Expiry
            CheckExpiry();
            #endregion
            Application.Run(new Login());
        }

        private static void UpdateSchema()
        {
            try
            {
                App.DbUp.MSAccess.DbUp dbUp = new App.DbUp.MSAccess.DbUp(Module1.conn.ConnectionString);
                dbUp.DBChanges(Application.StartupPath + "\\Scripts");
                dbUp = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private static async void CheckExpiry()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string ApiUrl = "";
                string strName = "";
                string strMobileNo = "";
                string strRemark = "";
                string cmdText = "select * from Settings";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    ApiUrl = oleDbDataReader["s_Api_Url"].ToString();
                    strName = oleDbDataReader["Name"].ToString();
                    strMobileNo = oleDbDataReader["MobileNo"].ToString();
                    strRemark = oleDbDataReader["Remark"].ToString();
                    App.Service.BaseService.APIUrl = ApiUrl;
                    Algo.License.License license = new Algo.License.License();
                    ///Task.Run(async () =>
                    //{
                    LicensesService licensesService = new LicensesService();
                    try
                    {
                        var licenses = licensesService.GetLicenses();

                        foreach (var Key in licenses)
                        {
                            var response = Algo.License.License.CheckExpiry(App.Service.BaseService.APIUrl, Key.Value).ContinueWith(c =>
                            {
                                if (c.Result.result)
                                {
                                    LicensesService licensesServiceDel = new LicensesService();
                                    //Truncate Table
                                    licensesServiceDel.RemoveLicense("Delete from License");
                                    Environment.Exit(Environment.ExitCode);
                                }
                            });

                        }
                    }
                    catch (Exception ex) 
                    {
                        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    }
                    finally
                    { licensesService = null; }
                    //});
                }

            }
            catch (Exception e)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), e.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }
    }
}
