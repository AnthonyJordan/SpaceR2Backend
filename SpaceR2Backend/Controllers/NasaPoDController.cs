using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SpaceR2Backend.DAOs;
using SpaceR2Backend.Models;
using System.Web.Helpers;
using System.Web.Http.Results;

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
        public string GetNasaPoD()
        {
            return JsonConvert.SerializeObject(Ok(DAO.LoadPoD()));
        }

    }
}
