using Dapper;
using Hangfire;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.Models;
using System.Data;

namespace SpaceR2Backend.DAOs
{
    public class PoDDAO : DAO
    {
        public PoDDAO(IConfiguration configuration) : base(configuration)
        {
            RecurringJob.AddOrUpdate("NasaPoD", () => SaveNasaPodFromAPI(), Cron.Daily);
        }

        public NasaPoDModel LoadPoD()
        {
            using IDbConnection cnn = new SqliteConnection(LoadConnectionString());
            var output = cnn.Query<NasaPoDModel>("SELECT * FROM NasaPoD", new { id = 1 });
            return (NasaPoDModel)output.First();
        }

        public void SavePoD(NasaPoDModel nasaPoD)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE NasaPoD SET copyright = @copyright, url = @url, hdurl = @hdurl, title = @title, explanation = @explanation WHERE id = 1", nasaPoD);
            }
        }
        //todo: HttpClient DI and move demo key to config
        public async Task SaveNasaPodFromAPI()
        {
            HttpClient httpClient = new HttpClient();
            JToken respone = JToken.Parse(await httpClient.GetStringAsync("https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY"));
            NasaPoDModel NasaPoD = respone.ToObject<NasaPoDModel>();
            SavePoD(NasaPoD);
        }
        
    }
}
