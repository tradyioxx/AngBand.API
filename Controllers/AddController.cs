using AngBand.Core2;
using Microsoft.AspNetCore.Mvc;

namespace AngBang.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        [HttpGet]
        public long Get(int x, int y)
        {
            var addition = new Addition(x, y);
            return addition.Resultat;
        }
    }
}
