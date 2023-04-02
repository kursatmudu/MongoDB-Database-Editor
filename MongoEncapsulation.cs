using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDatabaseEdit
{
    public class MongoEncapsulation
    {
        public ObjectId _id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public BsonDocument Cookies { get; set; }
        public bool complete { get; set; }
    }
}
