using Hangfire;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.database;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.DAOs
{
    public class PoDDAO : DAO
    {
        public PoDDAO(IConfiguration configuration, HttpClient httpClient) : base(configuration, httpClient)
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
        public async Task SaveNasaPodFromAPI()
        {
            try
            {
                JToken response = JToken.Parse(await _httpClient.GetStringAsync("https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY"));
                NasaPoDModel NasaPoD = response.ToObject<NasaPoDModel>();
                SavePoD(NasaPoD);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            
        }
        
    }
}
