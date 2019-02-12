using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
namespace ConsoleApp1
{
    public class DemoSet1
    {
        public static void main() {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            // List databases
            var db_list = client.ListDatabases().ToList();
            foreach(var db in db_list)
            {
                Console.WriteLine(db.ToJson());
            }
            // List Documents in a Collection
            var collection = client.GetDatabase("csharpnew").GetCollection<BsonDocument>("testing");
            var doc_list = collection.Find(new BsonDocument()).ToList();
            foreach (var doc in doc_list) {
                Console.WriteLine(doc.ToJson());
            }
            // Creating a new DB and Collection
            // client.GetDatabase("csharpnew").CreateCollection("testing");

            Console.ReadKey();
        }
    }
}
