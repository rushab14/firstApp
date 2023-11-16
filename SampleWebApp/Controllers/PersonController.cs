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

        [HttpGet("/person/{paadh}")]
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
        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View("create", new Person());
        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Person p)
        {
            PersonOperations.CreateNew(p);
            return View("PeopleList", PersonOperations.GetPeople());
        }
        [HttpGet("/edit/{paadh}")]
        public IActionResult Edit(string paadh)
        {
            var found = PersonOperations.SearchOne(paadh);
            return View("Edit", found);
        }
        [HttpPost("/edit/{paadh}")]
        public IActionResult Edit(string paadh , [FromForm] Person p)

        {
            var found = PersonOperations.SearchOne(paadh);
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
            return View("PeopleList", PersonOperations.GetPeople());
        }
    }
}

