using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet("/")]
        public string Default()
        {
            return $"Hi ";
        }
        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return Ok("Hi bro some scam thing this is");
        }
        [HttpGet("/simplegreet/{reet}")]
        public string SimpleGreet(string reet)
        {
            return $"Welcome to MCV(fake) , {reet}";
        }

        [HttpGet("/getnames")]
        public List<string> GetNames()
        {
            var names = new List<string>();
            names.Add("Ankit");
            names.Add("Shivam");
            return names;
        }

        [HttpGet("/add/{name}/{marks}/{ispassed?}")]
        public string AddData(string name, int marks , bool ispassed=true) 
        {
            return $"{name} has scored {marks} and has {ispassed}";
        }

        [HttpGet("/main")]
        public IActionResult GetIndexPage()
        {
            ViewBag.ReturnValue = "Data Passed from controller to view  is ";
            return View("MainPage");
        }
    }
}
