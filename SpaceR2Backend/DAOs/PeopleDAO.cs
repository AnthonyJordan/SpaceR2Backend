using Hangfire;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.database;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.DAOs
{
    public class PeopleDAO : DAO
    {

        public PeopleDAO(IConfiguration configuration) : base(configuration)
        {
            //RecurringJob.AddOrUpdate("People", () => SavePeopleFromAPI(), Cron.Daily);
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
            HttpClient httpClient = new HttpClient();
       
        }
    }
}
