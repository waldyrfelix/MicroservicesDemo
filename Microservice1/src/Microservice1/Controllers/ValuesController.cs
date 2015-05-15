using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Microservice1.Controllers
{
    [Route("Estoque")]
    public class EstoqueController : Controller
    {
        [HttpGet]
        public dynamic Get()
        {
            return new { microservice = "Produtos em estoque" };
        }

    }
}
