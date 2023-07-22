using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")] // treated as base URL
    public class ValuesController : ControllerBase
    { 
        //[Route("api/get-all")]
        [Route("~/api/get-all")] // doesnt depend on base URL
        public string GetAll()
        {
            return "Hello from get all";
        }

        //[Route("api/get-all-authors")]

        public string GetAllAuthors()
        {
            return "Hello from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "Hello from author " + id + " " + authorId;
        }

        //[Route("search")]
        
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "Hello from search";
        }
    }
}
