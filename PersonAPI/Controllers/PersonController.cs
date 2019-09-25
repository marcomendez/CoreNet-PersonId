using Microsoft.AspNetCore.Mvc;
using PersonAPI.Models;
using System.Collections.Generic;

namespace PersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET api/Person
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Welcome", "Cabrones" };
        }

        //Get
        [HttpGet]
        [Route("getpeople")]
        public ActionResult<IEnumerable<Person>> GetPeople()
        {
            List<Person> people = new List<Person>
            {
                new Person( 1,"Marco", 15),
                new Person( 2,"Pedro", 35),
                new Person( 3,"Juan", 25)
            };
            return people;
        }

    }
}