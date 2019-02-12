using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1
{
    public class Update
    {
        public static void main() {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var collection = client.GetDatabase("csharpnew").GetCollection<BsonDocument>("testing");
            //updateOne()
            //create filter and $set a value and it takes 2 arguments (var)
            var builder_filter = Builders<BsonDocument>.Filter.Eq("age",33);
            var builder_update = Builders<BsonDocument>.Update.Set("country","Earth");
            //to updateMany() change to collection.UpdateMany()
            collection.UpdateOne(builder_filter,builder_update);
            //deleteOne it takes 1 argument (var)instead of 2
            //var builder_filter_delete = Builders<BsonDocument>.Filter.Eq("name", "Tontexor");
            //to deleteMany() change to collection.deleteMany()
            //collection.DeleteMany(builder_filter_delete);

        }
    }
}
