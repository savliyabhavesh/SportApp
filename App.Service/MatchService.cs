using App.Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class MatchService : IDisposable
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
