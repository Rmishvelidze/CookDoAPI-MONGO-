using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookDo.Core.Models
{
    class Ingredient
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
