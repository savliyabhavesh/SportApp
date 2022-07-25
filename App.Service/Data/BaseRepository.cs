using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace App.Service.Data
{
    public class BaseRepository : IDisposable
    {
        public DataTable Get(string query)
        {
            using (DbConnection conn = new DbConnection())
            {
                DataTable dt = new DataTable();
                using (IDbConnection db = conn.GetConnection())
                {
                    using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(query, db.ConnectionString))
                    {
                        oleDbDataAdapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public object ExecuteScalar(string sp, DynamicParameters parms = null, CommandType commandType = CommandType.StoredProcedure, int? commandTimeout = null)
        {
            using (DbConnection conn = new DbConnection())
            {
                using (IDbConnection db = conn.GetConnection())
                {
                    parms = (parms == null ? new DynamicParameters() : parms);
                    var obj = db.ExecuteScalar(sp, parms, commandType: commandType, commandTimeout: commandTimeout);
                    return obj;
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
