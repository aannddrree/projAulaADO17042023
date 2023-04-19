using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {

        [HttpPost(Name = "Insert")]
        public bool Insert(Airplane airplane)
        {
            return new AirplaneService().Insert(airplane);
        }
    }
}
