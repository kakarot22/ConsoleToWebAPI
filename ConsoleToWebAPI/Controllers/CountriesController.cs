using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase // we create this contrtoller to learn model binder concept
    {
        [BindProperty] // if you dont use bind property attribute then it does not work
        public string Name { get; set; }

        [BindProperty] 
        public int Population { get; set; }

        [BindProperty] 
        public int Area { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {this.Name}, Popluation = {this.Population}, Area = {this.Area}");
        }
    }
}
