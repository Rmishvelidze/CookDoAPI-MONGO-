using CookDo.Core.Models;
using System.Collections.Generic;

namespace CookDo.Core
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetIngredients();
        Ingredient AddIngredient(Ingredient ingredient);
        Ingredient GetIngredient(string id);
        void DeleteIngredient(string id);
        Ingredient UpdateIngredient(Ingredient ingredient);
    }
}
