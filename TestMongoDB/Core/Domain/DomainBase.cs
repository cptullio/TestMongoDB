using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMongoDB.Core.Domain
{
    public class DomainBase
    {
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
    }
}
