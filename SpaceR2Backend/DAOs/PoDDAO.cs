using Dapper;
using Hangfire;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
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
            var output = cnn.Query<NasaPoDModel>("select id = @id", new { id = 1 });
            Console.WriteLine(output);
            return (NasaPoDModel)output;
        }

        public void SavePoD(NasaPoDModel nasaPoD)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("update NasaPoD (copyright, url, hdurl, title, explanation) values (@copyright, @url, @hdurl, @title, @explnation) where id = 1", nasaPoD);
            }
        }
        //todo: HttpClient DI
        public async Task SaveNasaPodFromAPI()
        {
            HttpClient httpClient = new HttpClient();
            string respone = await httpClient.GetStringAsync("https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY");
            NasaPoDModel NasaPoD = JsonConvert.DeserializeObject<NasaPoDModel>(respone);
            SavePoD(NasaPoD);
            Console.WriteLine(NasaPoD);
        }
        
    }
}
