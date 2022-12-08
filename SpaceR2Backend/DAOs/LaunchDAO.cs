using Hangfire;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.database;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.DAOs
{
    public class LaunchDAO : DAO
    {
        public LaunchDAO(IConfiguration configuration) : base(configuration)
        {
            RecurringJob.AddOrUpdate("Launches", () => SaveLaunchesFromAPI(), Cron.Hourly);
        }

        public List<Launch> GetLaunches()
        {
            using (var context = new Context())
            {
                var output = context.Launches.ToList();
                return output;
            }
        }

        public async Task SaveLaunchesFromAPI()
        {
            HttpClient httpClient = new HttpClient();
            string dateTime= DateTime.Now.ToString("s");
            JObject respone = JObject.Parse(await httpClient.GetStringAsync($"https://ll.thespacedevs.com/2.2.0/launch/?limit=10&ordering=window_start&window_start__gt={dateTime}"));
            List<JToken> JTokens = respone["results"].Children().ToList();
            List<Launch> Launches = new List<Launch>();
            foreach (JToken JToken in JTokens)
            {
                Launches.Add(JToken.ToObject<Launch>());
            }
            SaveLaunches(Launches);
        }

        public void SaveLaunches(List<Launch> Launches)
        {
            using (var context = new Context())
            {
                List<Launch> DBLaunches= context.Launches.ToList();
                if (DBLaunches != null)
                {
                    context.Launches.RemoveRange(DBLaunches);
                }         
            }

            foreach (Launch launch in Launches)
            {
                using (var context = new Context())
                {
/*
                    context.Launches.Add(launch);
                    context.SaveChanges();*/
                }
            }
        }
    }
}
