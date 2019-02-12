using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1
{
    public class DropDBandCollection
    {
        public static void main() {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            //to dropDatabase, we need to call the client
            client.DropDatabase("csarph");
            //dropCollection if there only 1 collection, it might delete the whole DB and we need to call the dropCollection() on the DB
            //var db = client.GetDatabase("NECTOR");
            //db.DropCollection("droptest");
        }
    }
}
