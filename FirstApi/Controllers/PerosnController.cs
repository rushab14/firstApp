using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("/api/get")]
        public List<Person> GetPerson()
        {
            return PersonOperations.GetPeople();
        }
        [HttpPost("/api/create")]
        public IActionResult CreatePerson(Person p)
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
                PersonOperations.Delete(aadh);
                return Ok("deletion successful");
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }

  
}
