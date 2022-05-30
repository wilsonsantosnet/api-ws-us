using Microsoft.AspNetCore.Mvc;
using Sample_api_users.Model;
using System.Linq;


namespace Sample_api_users.Controllers
{
    /// <summary>
    /// Devolve informações do Dispositivo
    /// </summary>
    [Route("")]
    [ApiController]
    public class NoContentController : ControllerBase
    {

        

        [HttpGet]
        public IActionResult Index()
        {
            return new NoContentResult();
        }

    }
}
