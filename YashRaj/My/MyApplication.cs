using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace YashAksh.My
{
    //// Token: 0x02000002 RID: 2
    //[GeneratedCode("MyTemplate", "8.0.0.0")]
    //[EditorBrowsable(EditorBrowsableState.Never)]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        //// Token: 0x06000001 RID: 1 RVA: 0x00276448 File Offset: 0x00274848
        [STAThread]
        //[EditorBrowsable(EditorBrowsableState.Advanced)]
        //[DebuggerHidden]
        //[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        //// Token: 0x06000002 RID: 2 RVA: 0x00276480 File Offset: 0x00274880
        //[DebuggerStepThrough]
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            this.IsSingleInstance = false;
            this.EnableVisualStyles = false;
            this.SaveMySettingsOnExit = true;
            this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }
        // Token: 0x06000003 RID: 3 RVA: 0x002764A8 File Offset: 0x002748A8
        //[DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            //this.MainForm = MyProject.Forms.MY_HOME;

            //this.MainForm = MyProject.Forms.Form1;

            #region Apply Schema Changes
            UpdateSchema();
            #endregion

            #region Checking Expiry
            CheckExpiry();
            #endregion


            this.MainForm = MyProject.Forms.Login;
        }

        private void UpdateSchema()
        {
            try
            {
                App.DbUp.MSAccess.DbUp dbUp = new App.DbUp.MSAccess.DbUp(Module1.conn.ConnectionString);
                dbUp.DBChanges(Application.StartupPath + "\\Scripts");
                dbUp = null;
            }
            catch (Exception ex)
            { }
        }

        private async void CheckExpiry()
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
                    RegistryOperation registryOperation = new RegistryOperation();
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
                                    licensesServiceDel.RemoveLicense("Delete from License");
                                    Environment.Exit(Environment.ExitCode);
                                }
                                else
                                {
                                    var regiexpirydate = registryOperation.RetrieveValue();
                                    var regiexpirydate1 = Convert.ToDateTime(regiexpirydate[1]);
                                    //if (c.Result.data != null)
                                    //{
                                    //    var obj = JObject.FromObject(c.Result.data);
                                    //    var serverexpdate = Convert.ToDateTime(obj["ExpiryDate"]);
                                    //    if (regiexpirydate1 < serverexpdate)
                                    //    {
                                    //        LicensesService licensesServiceDel = new LicensesService();
                                    //        licensesServiceDel.RemoveLicense("Delete from License");
                                    //        Environment.Exit(Environment.ExitCode);
                                    //    }
                                    //}
                                    //else
                                    //{
                                    if (regiexpirydate1 < DateTime.Now)
                                    {
                                        LicensesService licensesServiceDel = new LicensesService();
                                        licensesServiceDel.RemoveLicense("Delete from License");
                                        Environment.Exit(Environment.ExitCode);
                                    }

                                    //}
                                }
                            });

                        }
                    }
                    catch (Exception ex) { }
                    finally
                    { licensesService = null; }
                    //});
                }

            }
            catch (Exception e)
            {
            }
            finally
            {
                Module1.conn.Close();
            }
        }
    }
}
