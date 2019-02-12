using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1
{
    public class Sort
    {
        public static void main()
        {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var collection = client.GetDatabase("csharpnew").GetCollection<BsonDocument>("testing");
            BsonDocument doc = new BsonDocument();
            //For sort() we'll be using builders:
            var builder = Builders<BsonDocument>.Sort;
            var sorting = builder.Ascending("age");
            //Projection to filder out fields
            var builder_projection = Builders<BsonDocument>.Projection;
            var projectioncfg = builder_projection.Exclude("_id").Include("age");
            //Filter
            var builder_filter = Builders<BsonDocument>.Filter;
            var filter_query = builder_filter.Gt("age", 30);
            //Find() cambia de doc a filter_query para hacer Filter
            //Filter needs to be put on  Find() whereas Project is giving separate method.
            List<BsonDocument> list_docs = collection.Find(filter_query).Sort(sorting).ToList();
            foreach (var docx in list_docs)
            {
                Console.WriteLine(docx);
            }
            Console.ReadKey();
        }
    }
}

