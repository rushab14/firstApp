using EmpMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpMVC.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet("/employee")]
        public IActionResult GetEmployee()
        {
            var operations = EmpOperations.GetAllEmployees();
            return View("EmpList", operations);
        }

        [HttpGet("/employee/{aadh}")]
        public IActionResult GetEmployee(string aadh)
        {

            var found = EmpOperations.Search(aadh);
            return View("Search", found);

        }
        
        [HttpGet("/createEmployee")]
        public IActionResult Create()
        {
            return View("create", new Emp());
        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Emp e)
        {
            EmpOperations.CreateEmp(e);
            return View("EmpList", EmpOperations.GetAllEmployees());
        }
        [HttpGet("/edit/{aadh}")]
        public IActionResult Edit(string paadh)
        {
            var found = EmpOperations.Search(paadh);
            return View("Edit", found);
        }
        [HttpPost("/edit/{aadh}")]
        public IActionResult Edit(string aadh, [FromForm] Emp e)

        {
            var found = EmpOperations.Search(aadh);
            found.Email = e.Email;
            found.Age = e.Age;
            found.Name = e.Name;
            return View("EmpList", EmpOperations.GetAllEmployees());
        }

        [HttpGet("/getempfromdb")]
        public IActionResult GetFromDb()
        {
            var found = emplib.employee.Get();
            return View("empdbview", found);
        }
    }
}
