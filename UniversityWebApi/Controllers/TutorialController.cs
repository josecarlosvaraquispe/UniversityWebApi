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
    public class TutorialController : ControllerBase
    {
        // GET: api/Tutorial
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "GetTutorial")]
        public Tutorial GetTutorial(int id)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Id = id;
            tutorial.Title = "Tutorial " + id.ToString();
            tutorial.Year = 2023;
            tutorial.Description = "Description of tutorial " + id.ToString();
            
            return tutorial;
        }

        // POST: api/Tutorial
        [HttpPost]
        public void Create(Tutorial tut)
        {
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Update(int id, Tutorial tut)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
