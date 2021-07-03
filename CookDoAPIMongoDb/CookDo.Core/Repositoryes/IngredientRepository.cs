using CookDo.Core.Models;
using System.Collections.Generic;

namespace CookDo.Core
{
    public class IngredientRepository : IIngredientRepository
    {
        public IngredientRepository(IDbClient dbClient)
        {
            dbClient.GetIngredientsCollection();
        }
        public List<Ingredient> GetIngredients()
        {
            return new List<Ingredient>
            {
                new Ingredient
                {
                    Name = "Test"
                }
            };

        }
    }
}
