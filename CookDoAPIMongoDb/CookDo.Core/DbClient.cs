using CookDo.Core.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CookDo.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Ingredient> _ingredients;

        public DbClient(IOptions<CookDoDbConfig> cookDoConfig)
        {
            var client = new MongoClient(cookDoConfig.Value.Connection_String);
            var database = client.GetDatabase(cookDoConfig.Value.Database_Name);
            _ingredients = database.GetCollection<Ingredient>(cookDoConfig.Value.INGREDIENTS_COLLECTION_NAME);
        }

        public IMongoCollection<Ingredient> GetIngredientsCollection() => _ingredients;
    }
}
