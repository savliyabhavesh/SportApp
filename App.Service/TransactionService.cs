using App.Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class TransactionService : IDisposable
    {
        public void Dispose()
        {
        }

        public void Insert(string query)
        {
            using (BaseRepository repo = new BaseRepository())
            {
                var response = repo.ExecuteScalar(query, null, CommandType.Text);
            }
        }

        public DataTable Get(string query)
        {
            using (BaseRepository repo = new BaseRepository())
            {
                var response = repo.Get(query);
                return response;
            }
        }
    }
}
