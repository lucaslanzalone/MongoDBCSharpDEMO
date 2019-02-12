using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1
{
    public class runcommand
    {
        public static void main(){
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var db = client.GetDatabase("csharpnew");
            var bsonO = new BsonDocument("collStats", "testing");
            var result = db.RunCommand((Command<BsonDocument>)bsonO);
            Console.Write(result.ToJson());
            Console.ReadKey();
        }
    }
}
