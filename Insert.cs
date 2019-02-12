using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1
{
    public class Insert
    {
        public static void main()
        {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var collection = client.GetDatabase("csharpnew").GetCollection<BsonDocument>("testing");
            // insertOne()

            BsonDocument doc = new BsonDocument().Add("name", "LXXXXcas");
            doc.Add("lastname","Lanzalone");
            doc.Add("age",32);

            //collection.InsertOne(doc);
            // insertMany()

            BsonDocument doc1 = new BsonDocument().Add("name", "X21C1Wan");
            doc1.Add("lastname", "Zinzu");
            doc1.Add("age", 30);

            BsonDocument doc2 = new BsonDocument().Add("name", "JX41341uan");
            doc2.Add("lastname", "Ca");
            doc2.Add("age", 34);

            BsonDocument doc3 = new BsonDocument().Add("name", "Car36576487456los");
            doc3.Add("lastname", "Menemeitor");
            doc3.Add("age", 30);

            var list_docs = new List<BsonDocument>();
            list_docs.Add(doc1);
            list_docs.Add(doc2);
            list_docs.Add(doc3);
            collection.InsertMany(list_docs);
        }
    }
}
