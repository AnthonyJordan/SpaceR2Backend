using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SpaceR2Backend.DAOs;

namespace SpaceR2Backend.Controllers
{
    [Route("api/Launches")]
    [ApiController]
    public class LaunchController : Controller
    {
        private readonly LaunchDAO DAO;

        public LaunchController(LaunchDAO DAO)
        {
            this.DAO = DAO;
        }

        [HttpGet]
        public string GetLaunches()
        {
            return JsonConvert.SerializeObject(Ok(DAO.GetLaunches()));
        }
    }
}
