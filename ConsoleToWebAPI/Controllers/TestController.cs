using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public String Get1()
        {
            return "Hello World 1";
        }
        public String Get2()
        {
            return "Hello World 2";
        }
    }
}
