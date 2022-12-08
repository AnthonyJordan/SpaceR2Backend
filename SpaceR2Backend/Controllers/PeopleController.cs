using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SpaceR2Backend.DAOs;

namespace SpaceR2Backend.Controllers
{
    [Route("api/People")]
    [ApiController]
    public class PeopleController : Controller
    {
        private readonly PeopleDAO DAO;

        public PeopleController(PeopleDAO DAO)
        {
            this.DAO = DAO;
        }

        [HttpGet]
        public string GetPeople()
        {
            return JsonConvert.SerializeObject(Ok(DAO.GetPeople()));
        }

    }
}
