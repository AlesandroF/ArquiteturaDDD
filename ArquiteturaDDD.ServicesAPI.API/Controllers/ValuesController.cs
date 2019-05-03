using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArquiteturaDDD.ServicesAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "testando", "testando" };
        }
    }
}