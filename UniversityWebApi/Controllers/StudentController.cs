using Microsoft.AspNetCore.Mvc;
using UniversityWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace UniversityWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<Student>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Student>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student student = new Student();
            student.Id = id;
            student.Name= "Student " + id.ToString();
            return student;
        }

        // POST api/<Student>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Student>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Student>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
