using AngBand.Core;
using Microsoft.AspNetCore.Mvc;

namespace AngBang.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController : ControllerBase
    {
        [HttpGet]
        public long Get([FromQuery] int[] n)
        {
            var somme = new Somme(n);
            return somme.Resultat;

        }
    }
}
