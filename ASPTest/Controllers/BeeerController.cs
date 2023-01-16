using ASPTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPTest.Controllers
{
    //https://localhost:7266/api/beer
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeerController : ControllerBase
    {

        private readonly IBeerService _beerService;

        public BeerController(IBeerService service)
        {

            _beerService = service;

        }


        //https://localhost:7266/api/beer/get
        [HttpGet]
        public IActionResult Get() => Ok(_beerService.Get());


        //https://localhost:7266/api/beer/getbyid/3
        [HttpGet ("{id}")]
        public IActionResult GetById(int Id)
        {
            var beer = _beerService.Get(Id);

            if(beer == null)    
               return NotFound();

            return Ok(beer);

        }



    }
}
