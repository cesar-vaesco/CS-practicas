using Microsoft.AspNetCore.Mvc;

namespace NetCoreYouTube.Controllers
{
    //https://localhost:7014/cliente/listar
    [ApiController]
    [Route("[cliente]")]
    public class ClienteController : ControllerBase
    {


        [HttpGet]
        [Route("[saludar]")]
        public String Saludar()
        {
            return "Saludando";
        }

        /*
        [HttpGet]
        [Route("listar")] 
        public dynamic ListarClientes() 
        
        {
            return new
            { 
                Nombre = "César",
                Edad = 42
            }
            ;
        }
        */

        /*
        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente() { }
        */
    }
}
