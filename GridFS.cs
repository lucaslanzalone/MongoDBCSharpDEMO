using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;

namespace ConsoleApp1
{
    public class GridFS
    {
        public static void main() {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var db = client.GetDatabase("csharpnew");
            var bucket = new GridFSBucket(db);
            byte[] file_content_bytes = System.IO.File.ReadAllBytes("C:/Users/Lucas/Desktop/UDEMY and stuff/Emoji/monkaS.png");
            bucket.UploadFromBytes("monkaS", file_content_bytes);
        }
    }
}
