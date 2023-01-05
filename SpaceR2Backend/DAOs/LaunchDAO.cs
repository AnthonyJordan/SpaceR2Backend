using Hangfire;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.database;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.DAOs
{
    public class LaunchDAO : DAO
    {
        public LaunchDAO(IConfiguration configuration, HttpClient httpClient) : base(configuration, httpClient)
        {
            RecurringJob.AddOrUpdate("Launches", () => SaveLaunchesFromAPI(), Cron.Hourly);
        }

        public List<Launch> GetLaunches()
        {
            using (var context = new Context())
            {
                var output = context.Launches.Include(launch => launch.Status).Include(launch => launch.Launch_Service_Provider)
                    .Include(launch => launch.Rocket)?.ThenInclude(rocket => rocket.Configuration).Include(launch => launch.Mission)?
                    .ThenInclude(mission => mission.Orbit).Include(launch => launch.Pad)?.ThenInclude(pad => pad.Location).ToList();
                return output;
            }
        }

        public async Task SaveLaunchesFromAPI()
        {
            try
            {
                string dateTime = DateTime.Now.ToString("s");
                JObject response = JObject.Parse(await _httpClient.GetStringAsync($"https://ll.thespacedevs.com/2.2.0/launch/?limit=10&ordering=window_start&window_start__gt={dateTime}"));
                List<JToken> JTokens = response["results"].Children().ToList();
                List<Launch> Launches = new List<Launch>();
                foreach (JToken JToken in JTokens)
                {
                    Launches.Add(JToken.ToObject<Launch>());
                }
                SaveLaunches(Launches);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SaveLaunches(List<Launch> Launches)
        {

            ClearDatabase();


            foreach (Launch launch in Launches)
                {
                    using (var context = new Context())
                    {
                  
                    var entity = context.Launches.Add(launch);
                    if (context.Statuses.ToList().Contains(launch.Status))
                    {
                        entity.Reference("Status").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Launch_Service_Providers.ToList().Contains(launch.Launch_Service_Provider))
                    {
                        entity.Reference("Launch_Service_Provider").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Rockets.ToList().Contains(launch.Rocket))
                    {
                        entity.Reference("Rocket").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Missions.ToList().Contains(launch.Mission))
                    {
                        entity.Reference("Mission").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Pads.ToList().Contains(launch.Pad))
                    {
                        entity.Reference("Pad").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Locations.ToList().Contains(launch.Pad?.Location))
                    {
                        entity.Reference("Pad").TargetEntry.Reference("Location").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Configurations.ToList().Contains(launch.Rocket?.Configuration))
                    {
                        entity.Reference("Rocket").TargetEntry.Reference("Configuration").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.Orbits.ToList().Contains(launch.Mission?.Orbit))
                    {
                        entity.Reference("Mission").TargetEntry.Reference("Orbit").TargetEntry.State = EntityState.Modified;
                    }
                    context.SaveChanges();
                    }
                }
                
            
        }

        public void ClearDatabase()
        {
            using (var context = new Context())
            {
                List<Launch> DBLaunches = context.Launches.ToList();
                if (DBLaunches != null)
                {
                    context.Database.ExecuteSql($"DELETE FROM Launches;");
                    context.Database.ExecuteSql($"DELETE FROM Configurations;");
                    context.Database.ExecuteSql($"DELETE FROM Launch_Service_Providers;");
                    context.Database.ExecuteSql($"DELETE FROM Locations;");
                    context.Database.ExecuteSql($"DELETE FROM Missions;");
                    context.Database.ExecuteSql($"DELETE FROM Orbits;");
                    context.Database.ExecuteSql($"DELETE FROM Pads;");
                    context.Database.ExecuteSql($"DELETE FROM Rockets;");
                    context.Database.ExecuteSql($"DELETE FROM Statuses;");
                    context.SaveChanges();
                }
            }
        }
    }
}
