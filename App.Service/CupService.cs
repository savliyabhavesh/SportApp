using App.Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class CupService : IDisposable
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

        public DataTable Get(string query)
        {
            using (BaseRepository baseRepository = new BaseRepository())
            {
                return baseRepository.Get(query);
            }
        }
    }
}
