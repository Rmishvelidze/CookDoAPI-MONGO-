using CookDo.Core;
using CookDo.Core.Models;
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
        [HttpGet("{id}", Name = "GetIngredient")]
        public IActionResult GetIngredient(string id)
        {
            return Ok(_ingredientRepository.GetIngredient(id));
        }

        // POST api/<IngredientController>
        [HttpPost]
        public IActionResult Post(Ingredient ingredient)
        {
            _ingredientRepository.AddIngredient(ingredient);
            return CreatedAtRoute("GetIngredient", new { id = ingredient.Id }, ingredient);
        }

        // PUT api/<IngredientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Ingredient ingredient)
        {
            return Ok(_ingredientRepository.UpdateIngredient(ingredient));
        }

        // DELETE api/<IngredientController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _ingredientRepository.DeleteIngredient(id);
            return NoContent();
        }
    }
}
