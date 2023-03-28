using Microsoft.AspNetCore.Mvc;
using UniversityWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        // GET: api/<TutorialController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TutorialController>/5
        [HttpGet("{id}")]
        public Tutorial GetById(int id)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Id = id;
            tutorial.Title = "Tutorial " + id.ToString();
            tutorial.year = id;
            tutorial.Description = "Description " + id.ToString();

            return tutorial;
        }

        // POST api/<TutorialController>
        [HttpPost]
        public void Create(Tutorial tut)
        {

        }

        // PUT api/<TutorialController>/5
        [HttpPut("{id}")]
        public void Update(int id, Tutorial tut)
        {
        }

        // DELETE api/<TutorialController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
