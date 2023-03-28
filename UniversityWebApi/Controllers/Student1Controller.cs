using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityWebApi.Models;

namespace UniversityWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student1Controller : ControllerBase
    {
        // GET: api/Student1
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Student1/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            Student student = new Student();
            student.Id = id;
            student.Name = "Student " + id.ToString();
            
            return student;
        }

        // POST: api/Student1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student1/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
