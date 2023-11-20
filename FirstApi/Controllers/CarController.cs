using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;
using System.Security.Permissions;

namespace FirstApi.Controllers
{
    //[Security
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private IApiLogger apiLogger1;
        private ICarAccessories _accessories;
        private Car _car;
        public CarController(Car car,IApiLogger apiLogger, ICarAccessories icarAccessories)
        {

            apiLogger1 = apiLogger;
            _car = car;
            _accessories = icarAccessories;
        }
        [HttpGet("/drive")]
        public IActionResult Drive()
        {
            apiLogger1.Log("api : drive() was called");
            return Ok("Driving at 160 mph");
        }
    }
}
