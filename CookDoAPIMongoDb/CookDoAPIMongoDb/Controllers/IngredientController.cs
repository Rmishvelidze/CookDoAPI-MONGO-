using CookDo.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CookDoAPIMongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientController(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        // GET: api/<IngredientController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ingredientRepository.GetIngredients());
        }

        // GET api/<IngredientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IngredientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IngredientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IngredientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
