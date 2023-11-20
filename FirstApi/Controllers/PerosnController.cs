using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IApiLogger _logger;
        public PersonController(IApiLogger logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/get")]
        public List<Person> GetPerson()
        {
            _logger.Log("started logging  ");
            _logger.Log(" get method api was called");
            return PersonOperations.GetPeople();
        }
        [HttpPost("/api/create")]
        public IActionResult CreatePerson([FromForm] Person p)
        {
            PersonOperations.CreateNew(p);
            return Created($"Person with aadhaar {p.Aadhar} is created",p);
        }
        [HttpPut("/api/update")]
        public IActionResult UpdatePerson(string aadh ,Person p )
        {
            try
            {
                PersonOperations.Update(aadh, p);
                return Ok("updated successfully");
            }
            catch (Exception e)
            {
             return   NotFound(e.Message);
            }

        }
        [HttpDelete("/api/delete")]
        public IActionResult DeletePerson(string aadh)
        {
            try
            {
                _logger.Log("DeletePerson() api was successull");
                PersonOperations.Delete(aadh);
                return Ok("deletion successful");
            }
            catch(Exception e)
            {
                _logger.Log("DeletePerson() api was unsuccessull");

                return NotFound(e.Message);
            }
        }

    }

  
}
