using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")] // we are setting the base route
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null; // writing animals in the constructor so that we dont need to write animals again and again
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name = "Dog"},
                new AnimalModel() {Id = 2, Name = "Cat"}
            };
        }

        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {

            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimals2()
        {
            
            return Accepted("~/api/animals"); // returning url from api
        }

        [Route("test4")]
        public IActionResult GetAnimalsTest()
        {

            return LocalRedirectPermanent("~/api/animals"); // returning url from api
        }


        [Route("test2")]
        public IActionResult GetAnimals3()
        {
            //var animals = new List<AnimalModel>()
            //{
            //    new AnimalModel() {Id = 1, Name = "Dog"},
            //    new AnimalModel() {Id = 2, Name = "Cat"}
            //};

            return AcceptedAtAction("GetAnimals"); // returning GetAnimals URL
        }

        [Route("test3")]
        public IActionResult GetAnimals4()
        {
            

            return AcceptedAtRoute("All"); // returning GetAnimals URL using route name
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if(!name.Contains("ABC"))
            {
                return BadRequest();
            }

            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id) // this will get the created GetAnimals5
        {
            if( id == 0)
            {
                return BadRequest();
            }

            var animal = animals.FirstOrDefault(x => x.Id == id);

            if( animal == null)
            {
                return NotFound(); ;
            }

            return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult GetAnimals5(AnimalModel animal)
        {
            animals.Add(animal);

            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, animal); // in the created method we need to return URL, and this url is used to get the details of newly created record in the database 
        }

    }
}
 