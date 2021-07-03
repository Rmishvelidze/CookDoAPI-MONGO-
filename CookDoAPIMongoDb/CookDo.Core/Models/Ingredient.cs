using MongoDB.Bson.Serialization.Attributes;

namespace CookDo.Core.Models
{
    public class Ingredient
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
