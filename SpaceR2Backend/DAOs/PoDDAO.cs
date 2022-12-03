using Dapper;
using Microsoft.Data.Sqlite;
using SpaceR2Backend.Models;
using System.Data;

namespace SpaceR2Backend.DAOs
{
    public class PoDDAO : DAO
    {
        public PoDDAO(IConfiguration configuration) : base(configuration)
        {
        }

        public NasaPoDModel LoadPoD()
        {
            using IDbConnection cnn = new SqliteConnection(LoadConnectionString());
            var output = cnn.Query<NasaPoDModel>("select id = @id", new { id = 1 });
            return (NasaPoDModel)output;
        }

        public void SavePoD(NasaPoDModel nasaPoD)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("update NasaPoD (copyright, url, hdurl, title, explanation) values (@copyright, @url, @hdurl, @title, @explnation) where id = 1", nasaPoD);
            }
        }
    }
}
