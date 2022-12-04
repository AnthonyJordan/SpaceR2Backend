using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceR2Backend.DAOs;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.Controllers
{
    [Route("api/NasaPOD")]
    [ApiController]
    public class NasaPoDController : ControllerBase
    {
        private readonly PoDDAO DAO;
        public NasaPoDController(PoDDAO poDDAO)
        {
            DAO = poDDAO;
        }
        [HttpGet]
        public ActionResult<NasaPoDModel> GetNasaPoD()
        {
            Console.WriteLine("test");
            return Ok(DAO.LoadPoD());
        }

    }
}
