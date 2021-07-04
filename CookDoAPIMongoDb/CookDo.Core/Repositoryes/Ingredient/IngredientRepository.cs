using CookDo.Core.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CookDo.Core
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly IMongoCollection<Ingredient> _ingredients;

        public IngredientRepository(IDbClient dbClient)
        {
            _ingredients = dbClient.GetIngredientsCollection();
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
            _ingredients.InsertOne(ingredient);
            return ingredient;
        }

        public void DeleteIngredient(string id)
        {
            _ingredients.DeleteOne(ingredient => ingredient.Id == id);
        }

        public Ingredient GetIngredient(string id) => _ingredients.Find(ingredient => ingredient.Id == id).First();

        public List<Ingredient> GetIngredients() => _ingredients.Find(ingredient => true).ToList();

        public Ingredient UpdateIngredient(Ingredient ingredient)
        {
            GetIngredient(ingredient.Id);
            _ingredients.ReplaceOne(i => i.Id == ingredient.Id, ingredient);
            return ingredient;
        }
    }
}
