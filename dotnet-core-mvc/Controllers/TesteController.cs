using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_mvc.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        // GET: api/Teste
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
