using Microsoft.AspNet.Mvc;

namespace Microservice1.Controllers
{
    [Route("api/Estoque")]
    public class EstoqueController : Controller
    {
        [HttpGet]
        public dynamic Get()
        {
            return new { microservice = "Produtos em estoque" };
        }
    }
}
