using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("/people")]
        public IActionResult GetPeople()
        {
            var operations = PersonOperations.GetPeople();
            return View("PeopleList", operations);
        }

        [HttpGet("/getperson/{paadh}")]
        public IActionResult GetPerson(string paadh) {

            var found = PersonOperations.SearchOne(paadh);
            return View("SearchOne",found);

            }
        [HttpGet("/people/ofAge/{startAge}/{endAge}")]
        public IActionResult GetPeopleWithingAge(int startAge , int endAge)
        
        {
            var res = PersonOperations.SearchInAge(startAge,endAge);
            return View("GetPeopleWithingAge", res);
        
        }
        }
    }

