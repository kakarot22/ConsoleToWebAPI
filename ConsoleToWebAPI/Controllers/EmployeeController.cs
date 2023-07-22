using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //public string GetEmployees1() // returning primitive data type
        //{
        //    return "All employees";
        //}

        //public EmployeeModel GetEmployees2() //returning one object
        //{
        //    return new EmployeeModel() { Id = 1, Name = "Employee1"};
        //}

        //public List<EmployeeModel> GetEmployees3() //returning a 'list' of objects
        //{
        //    return new List<EmployeeModel>()
        //    { new EmployeeModel() {Id = 1, Name = "Employee 1"}
        //    , new EmployeeModel() {Id = 2, Name = "Employee 2"}
        //    };
        //}
        [Route(" ")] //this is for all the emplpoyees
        public IEnumerable<EmployeeModel> GetEmployees4() //returning a 'list' of objects, when you are dealing with asynchronous programming then we can use IEnumerable
        {
            return new List<EmployeeModel>()
            { new EmployeeModel() {Id = 1, Name = "Employee 1"}
            , new EmployeeModel() {Id = 2, Name = "Employee 2"}
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployees5(int id) 
        {
            if(id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel>()
            { new EmployeeModel() {Id = 1, Name = "Employee 1"},
              new EmployeeModel() {Id = 2, Name = "Employee 2"}
            });
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployees6(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { Id = 1, Name = "Employee 1" };
        }

    }
}
