using Dapper;
using Hangfire;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.database;
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
            using (var context = new Context()) {
                var output = context.NasaPoD.First();
                return (NasaPoDModel)output;
            }   
        }

        public void SavePoD(NasaPoDModel nasaPoD)
        {
            using (var context = new Context())
            {
                NasaPoDModel DBPod = context.NasaPoD.FirstOrDefault();
                if (DBPod != null)
                {
                    context.NasaPoD.Remove(DBPod);
                }
                context.NasaPoD.Add(nasaPoD);
                context.SaveChanges();
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
