using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class DbConnection : IDisposable
    {
        private string ConnectionString { get { return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {Environment.CurrentDirectory}\\DB\\{BaseService.DbName};Persist Security Info=False;Jet OLEDB:Database Password=s@h#u$b%h@108"; } }

        private IDbConnection dbConnection;

        public DbConnection()
        {
            //dbConnection = new OleDbConnection(ConnectionString);
            //if (dbConnection.State == ConnectionState.Closed)
            //    dbConnection.Open();
        }
        public IDbConnection GetConnection()
        {
            dbConnection = new OleDbConnection(ConnectionString);
            if (dbConnection.State == ConnectionState.Closed)
                dbConnection.Open();

            return dbConnection;
        }

        ~DbConnection()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
        }
    }
}
