using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using UniversityWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace UniversityWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student(){ Id=1, Name = "Carlos", LastName= "Gomez"},
            new Student(){ Id=1, Name = "Carlos", LastName= "Moscoso"},
            new Student(){ Id=2, Name = "Juan", LastName= "Gonzalez"},
            new Student(){ Id=3, Name = "Arturo", LastName= "Aguirre"},
            new Student(){ Id=4, Name = "Laura", LastName= "Petri"},
        };

        // GET: api/Student/{name}
        [HttpGet("{name}",Name= "GetStudent")]
        public List<Student> GetByName(string name)
        {
            return _students.Where(student => student.Name == name).ToList();
        }

        // GET api/Student/5
        [HttpGet("{id:int}", Name = "GetById")]
        public List<Student> Get(int id)
        {
            return _students.Where(student => student.Id == id).ToList();
        }

        // POST api/<Student>
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (student.Name == "")
                return StatusCode(400);
            else
                return StatusCode(201);
        }

        // PUT api/<Student>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            try
            {
                if (student.Id == 0 || id > _students.Count)
                    return StatusCode(400);
                else
                    return StatusCode(201);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPatch(template: "{id}")]
        public IActionResult PatchName(int id, String name)
        {
            try
            { 
                if (name == "" || id == 0 || id > _students.Count) 
                    return StatusCode(400);
                else 
                    return StatusCode(200);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<Student>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id == 0 || id>_students.Count)
                    return StatusCode(400);
                else
                    return StatusCode(201);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
