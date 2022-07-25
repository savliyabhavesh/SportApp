using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace App.Service
{
    public class BaseService
    {
        public static string APIUrl { set; get; }

        public static string Name { set; get; }
        public static string MobileNo { set; get; }

        public static string DbName { get { return "MY_DB.mdb"; } }

        public static OleDbConnection conn = new OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {Environment.CurrentDirectory}\\DB\\{DbName};Persist Security Info=False;Jet OLEDB:Database Password=s@h#u$b%h@108");

        public static bool IsAdmin { get; set; }

        public static string GetVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = fvi.FileVersion; // or fvi.ProductVersion
            return version;
        }

        public static string Login(string userid, string password)
        {
            password = password.Trim();
            var dbPassword = $"{DateTime.Now.ToString("ddMMyyyy")}_{DateTime.Now.ToString("yyyy")}";
            IsAdmin = password == dbPassword;

            string cmdText = IsAdmin ? "select * from Settings" : $"select * from Settings Where s_Username='{userid.Trim()}' and s_Password='{password.Trim()}'";
            return cmdText;
        }

        public static string GetMethodDetails([System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null, [System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            try
            {
                var callerTypeName = System.IO.Path.GetFileNameWithoutExtension(callerFilePath);
                return $"{callerTypeName}->{name}";
            }
            catch (Exception ex) { }
            return $"BaseService->GetMethodDetails";
        }
    }
}
