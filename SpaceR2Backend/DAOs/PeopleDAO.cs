using Hangfire;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.database;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.DAOs
{
    public class PeopleDAO : DAO
    {

        public PeopleDAO(IConfiguration configuration, HttpClient httpClient) : base(configuration, httpClient)
        {
            RecurringJob.AddOrUpdate("People", () => SavePeopleFromAPI(), Cron.Daily);
        }

        public List<PersonModel> GetPeople()
        {
            using (var context = new Context())
            {
                var output = context.People.ToList();
                return output;
            }
        }

        public async Task SavePeopleFromAPI()
        {
            try
            {
                JObject respone = JObject.Parse(await _httpClient.GetStringAsync("http://api.open-notify.org/astros.json"));
                List<JToken> JTokens = respone["people"].Children().ToList();
                List<PersonModel> People = new List<PersonModel>();
                foreach (JToken JToken in JTokens)
                {
                    People.Add(JToken.ToObject<PersonModel>());
                }
                SavePeople(People);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SavePeople(List<PersonModel> People)
        {
            using (var context = new Context())
            {
                List<PersonModel> DBPeople = context.People.ToList();
                if (DBPeople != null)
                {
                    context.People.RemoveRange(DBPeople);
                }
                context.People.AddRange(People);
                context.SaveChanges();
            }
        }
    }
}
