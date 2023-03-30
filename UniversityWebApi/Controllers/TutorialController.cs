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
        private static List<Tutorial> Tutorials = new List<Tutorial>()
        {
            new Tutorial(){ Id=1, Title = "Tutorial 1", Year= 1995, Description= "Descripcion 1"},
            new Tutorial(){ Id=1, Title = "Tutorial 2", Year= 1990, Description= "Descripcion 2"},
            new Tutorial(){ Id=2, Title = "Tutorial 3", Year= 1999, Description= "Descripcion 3"},
            new Tutorial(){ Id=3, Title = "Tutorial 4", Year= 2005, Description= "Descripcion 4"},
            new Tutorial(){ Id=4, Title = "Tutorial 5", Year= 2008, Description= "Descripcion 5"},
        };
        // GET: api/Tutorial
        [HttpGet("{title}", Name = "GetbyTitle")]
        public List<Tutorial> GetbyTitle(string title)
        {
            return Tutorials.Where(tutorial => tutorial.Title == title).ToList();
        }

        // GET: api/Tutorial/5
        [HttpGet("{id:int}", Name = "GetTutorial")]
        public Tutorial Get(int id)
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
        public IActionResult Create(Tutorial tut)
        {
            if (tut.Title == "")
                return StatusCode(400);
            else
                return StatusCode(201);
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Tutorial tutorial)
        {
            if (tutorial.Id == 0)
                return StatusCode(400);
            else
                return StatusCode(201);
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
