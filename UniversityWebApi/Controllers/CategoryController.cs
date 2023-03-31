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
    public class CategoryController : ControllerBase
    {
        private static List<Category> categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Category1", Description = "This is the category 1.", Quantity = 4},
            new Category() { Id = 2, Name = "Category2", Description = "This is the category 2.", Quantity = 5},
            new Category() { Id = 3, Name = "Category3", Description = "This is the category 3.", Quantity = 2},
            new Category() { Id = 4, Name = "Category4", Description = "This is the category 4.", Quantity = 1},
            new Category() { Id = 5, Name = "Category5", Description = "This is the category 5.", Quantity = 6},
            new Category() { Id = 6, Name = "Category6", Description = "This is the category 6.", Quantity = 4},
            new Category() { Id = 7, Name = "Category7", Description = "This is the category 7.", Quantity = 3},
        };

        // GET: api/Category/{name}
        [HttpGet("{name}", Name = "GetbyName")]
        public List<Category> GetbyName(string name)
        {
            return categories.Where(category => category.Name == name).ToList();
            //return categories.Where(category => String.Equals(category.Name, name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        
        // GET: api/Category/5
        [HttpGet("{id:int}", Name = "GetCategory")]
        public Category GetCategory(int id)
        {
            Category category = new Category();
            category.Id = id;
            category.Name = "Category " + id.ToString();
            category.Description = "Description of category " + id.ToString();

            return category;
        }

        // POST: api/Category
        [HttpPost]
        public IActionResult Post(Category category)
        {
            if (category.Name == "")
                return StatusCode(400);
            else
            {
                return StatusCode(201);
            }
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            try
            {
                if (category.Id == 0 || id > categories.Count)
                    return StatusCode(400);
                else
                {
                    return StatusCode(201);
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id == 0 || id > categories.Count)
                    return StatusCode(400);
                else
                {
                    return StatusCode(201);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
