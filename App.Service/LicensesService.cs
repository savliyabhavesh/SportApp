using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Service.Data;
using Dapper;

namespace App.Service
{
    public class LicensesService : IDisposable
    {
        public void Dispose()
        {
        }

        public IDictionary<int, string> GetLicenses()
        {
            IDictionary<int, string> licensekey = new Dictionary<int, string>();
            try
            {
                string cmdText = $"select * from License where SystemName like '{Environment.MachineName}'";
                int i = 1;
                using (BaseRepository repo = new BaseRepository())
                {
                    DataTable response;
                    response = repo.Get(cmdText);
                    foreach (DataRow row in response.Rows)
                    {
                        licensekey.Add(i, row["LicenseKey"].ToString());
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return licensekey;
        }

        public void RemoveLicense(string query)
        {
            try
            {
                using (BaseRepository repo = new BaseRepository())
                {
                    repo.ExecuteScalar(query,null,CommandType.Text);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public IDictionary<int, string> GetLicensesExpityDate()
        {
            IDictionary<int, string> licensekey = new Dictionary<int, string>();
            try
            {
                if (BaseService.conn.State == ConnectionState.Closed)
                {
                    BaseService.conn.Open();
                }
                string cmdText = $"select * from License where SystemName like '{Environment.MachineName}'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, BaseService.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                int i = 1;
                while (oleDbDataReader.Read())
                {
                    licensekey.Add(i, oleDbDataReader["ExpiryDate"].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaseService.conn.Close();
            }
            return licensekey;
        }

        public DataTable GetAllLicenses(string filter = "")
        {
            using (BaseRepository repo = new BaseRepository())
            {
                var response = repo.Get($"Select *  from License {filter}");
                return response;
            }
        }

        public void RemoveLicese()
        {
            using (BaseRepository repo = new BaseRepository())
            {
                var response = repo.ExecuteScalar("Delete From License", null, CommandType.Text);
            }
        }
        public void Update(string query)
        {
            using (BaseRepository repo = new BaseRepository())
            {
                var response = repo.ExecuteScalar(query, null, CommandType.Text);
            }
        }
    }
}
