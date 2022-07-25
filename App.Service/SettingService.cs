using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using App.Service.Data;


namespace App.Service
{
    public class SettingService : IDisposable
    {
        public void Dispose()
        {
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
