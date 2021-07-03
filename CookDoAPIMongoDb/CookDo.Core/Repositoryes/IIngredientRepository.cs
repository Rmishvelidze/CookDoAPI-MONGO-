using CookDo.Core.Models;
using System.Collections.Generic;

namespace CookDo.Core
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetIngredients();
    }
}
