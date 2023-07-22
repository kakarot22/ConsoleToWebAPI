using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(20)}")]
        public string GetById(int id)
        {
            return "Hello int " + id;
        }

        [Route("{id:minlength(7)}:alpha")]
        public string GetByString(string id)
        {
            return "Hello string " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByRegex(string id)
        {
            return "Hello regex " + id;
        }
    }
}
