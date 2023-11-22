using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsyncController : ControllerBase
    {
        public AsyncController()
        {
            System.IO.File.WriteAllText(@"SomeFile.txt","aur bhai ne history likh di malum kya wild card entry aaj winner \n down to earth banda hai down to earth  \n arre ankit bhai ke aage koi bol sakta hai kya");
        }
        [HttpGet("/async")]
        public async Task<string> ReadFile()
        {
            using (StreamReader streamReader = new StreamReader(@"SomeFile.txt"))
            { return await streamReader.ReadToEndAsync(); }
        }
    }
        
}
