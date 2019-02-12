using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;

namespace ConsoleApp1
{
    public class BulkWrite
    {
        public static void main() {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var collection = client.GetDatabase("csharpnew").GetCollection<BsonDocument>("testing");

            //insert Models
            BsonDocument doc1 = new BsonDocument().Add("name", "John");
            doc1.Add("lastname", "Carl");
            doc1.Add("age", 102);
            doc1.Add("country","USA");

            BsonDocument doc2 = new BsonDocument().Add("name", "Jean");
            doc2.Add("lastname", "Carles");
            doc2.Add("age", 101);
            doc2.Add("country","France");

            BsonDocument doc3 = new BsonDocument().Add("name", "George");
            doc3.Add("lastname", "Neitor");
            doc3.Add("age", 11);
            doc3.Add("country", "Brazil");

            var insertModel1 = new InsertOneModel<BsonDocument>(doc1);
            var insertModel2 = new InsertOneModel<BsonDocument>(doc2);
            var insertModel3 = new InsertOneModel<BsonDocument>(doc3);

            //update Models

            BsonDocument doc3_filter = new BsonDocument();
            doc3_filter.Add("lastname","Galan1");
            BsonDocument doc3_update = new BsonDocument();
            doc3_update.Add("Age", 18);
            BsonDocument doc3_update_action = new BsonDocument();
            doc3_update_action.Add("$set", doc3_update);

            var updateModel1 = new UpdateOneModel<BsonDocument>(doc3_filter, doc3_update_action);
            //delete Models

            BsonDocument doc1_filter_delete = new BsonDocument();
            doc1_filter_delete.Add("age",11);
            var deleteOneModel = new DeleteOneModel<BsonDocument>(doc1_filter_delete);

            var writeModels = new WriteModel<BsonDocument>[]
            {
                insertModel1,insertModel2,insertModel3,deleteOneModel
            };
            collection.BulkWrite(writeModels);
        }
    }
}
