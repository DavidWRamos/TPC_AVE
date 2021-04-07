using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace tpc05
{
    class Program
    {
        static void Main(string[] args)
        {
            FirestoreDb db = FirestoreDb.Create("fire-students-d5305");
            QuerySnapshot query = db.Collection("students").GetSnapshotAsync().Result;
            foreach(DocumentSnapshot doc in query) {
                Console.Write('{');
                Dictionary<string, object> map = doc.ToDictionary();
                foreach(var pair in map) {
                    Console.Write($"{pair.Key} : {pair.Value},");
                }
                Console.Write("\b");
                Console.WriteLine('}');
            }
        }
    }
}
