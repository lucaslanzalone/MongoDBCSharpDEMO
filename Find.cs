﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp1
{
    public class Find
    {
        public static void main()
        {
            var connectionString = "mongodb://192.168.1.126:27018";
            MongoClient client = new MongoClient(connectionString);
            var collection = client.GetDatabase("csharpnew").GetCollection<BsonDocument>("testing");
            BsonDocument doc = new BsonDocument();
            doc.Add("age", 30);
            List<BsonDocument> list_docs = collection.Find(doc).ToList();
            foreach (var docx in list_docs) 
            {
                Console.WriteLine(docx);
            }
            Console.ReadKey(); 
        }
    }
}
    
