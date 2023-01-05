using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.Controllers
{
    [Route("api/ISSLocation")]
    [ApiController]
    public class ISSLocationController : Controller
    {
        private HttpClient _httpClient;
        private static ISSLocation _ISSLocation = new ISSLocation();
       
        public ISSLocationController(HttpClient httpClient) {
            RecurringJob.AddOrUpdate("ISSLocation", () => GetLocationFromAPI(), "0/5 * * ? * *");
            _httpClient = httpClient;
        }

        [NonAction]
        public async Task GetLocationFromAPI()
        {
            try
            {
                JToken response = JToken.Parse(await _httpClient.GetStringAsync("http://api.open-notify.org/iss-now.json"));
                _ISSLocation = response["iss_position"].ToObject<ISSLocation>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [HttpGet]
        public string GetISSLocation() 
        {
            return JsonConvert.SerializeObject(Ok(_ISSLocation));
        }
    }
}
