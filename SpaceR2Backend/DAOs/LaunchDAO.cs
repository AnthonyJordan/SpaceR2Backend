using Hangfire;
using Microsoft.EntityFrameworkCore;
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
            
               // List<Launch> DBLaunches = context.Launches.ToList();
                /*              if (DBLaunches != null)
                              {
                                  context.Database.ExecuteSql($"DELETE FROM Launches;");
                                  context.Database.ExecuteSql($"DELETE FROM Configuration;");
                                  context.Database.ExecuteSql($"DELETE FROM LauncheServiceProvider;");
                                  context.Database.ExecuteSql($"DELETE FROM Location;");
                                  context.Database.ExecuteSql($"DELETE FROM Mission;");
                                  context.Database.ExecuteSql($"DELETE FROM Orbit;");
                                  context.Database.ExecuteSql($"DELETE FROM Pad;");
                                  context.Database.ExecuteSql($"DELETE FROM Rocket;");
                                  context.Database.ExecuteSql($"DELETE FROM Status;");
                                  context.SaveChanges();
                              }*/


                foreach (Launch launch in Launches)
                {
                    using (var context = new Context())
                    {
                  
                    var entity = context.Launches.Add(launch);
                    if (context.Statuses.ToList().Contains(launch.Status))
                    {
                        entity.Reference("Status").TargetEntry.State = EntityState.Modified;
                    }
                    if (context.LaunchServiceProviders.ToList().Contains(launch.LaunchServiceProvider))
                    {
                        entity.Reference("LaunchServiceProvider").TargetEntry.State = EntityState.Modified;
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
    }
}
