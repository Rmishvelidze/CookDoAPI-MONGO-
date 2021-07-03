using CookDo.Core.Models;
using MongoDB.Driver;

namespace CookDo.Core
{
    public interface IDbClient
    {
        IMongoCollection<Ingredient> GetIngredientsCollection();
    }
}
