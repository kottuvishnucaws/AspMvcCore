using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspMvcCore.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Data;

namespace AspMvc.Controllers
{
    public class HomeController : Controller
    {
        private static List<Student_Info> student;

        public IActionResult Index(Student_Info info)
        {
            if (info.Name != null)
            {
                InsertStudentData(info).Wait();
                ModelState.Clear();
                ViewBag.Success = "Submitted Successfully...!";
            }
            return View();
        }

        public IActionResult GetStudentData()
        {
            GetStudent().Wait();

            return View(student);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static async Task InsertStudentData(Student_Info info)
        {
            var connectionString = "mongodb://4a593693-0ee0-4-231-b9ee:aQ8k7s2fWWj3GY2AUuWLGB53YNYoYuAfXaWLgOAXTsuKPqv1YCHv4TUqc3sUUKc3eTj2Lf3yTyGGbIjFmvAE5Q==@4a593693-0ee0-4-231-b9ee.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("Vishnu");

            var collection = db.GetCollection<Student_Info>("MyData");

            var document = new Student_Info
            {
                Student_ID = info.Student_ID,
                Name = info.Name,
                Branch = info.Branch
            };
            ////For Inserting Many
            //var document2 = new Student_Info
            //{
            //    Student_ID = 3,
            //    Name = "VishnuKumar",
            //    Branch = "ece"
            //};

            //await collection.InsertManyAsync(new[] { document, document2 });
            await collection.InsertOneAsync(document);
        }

        static async Task GetStudent()
        {
            student = new List<Student_Info>();

            var connectionString = "mongodb://4a593693-0ee0-4-231-b9ee:aQ8k7s2fWWj3GY2AUuWLGB53YNYoYuAfXaWLgOAXTsuKPqv1YCHv4TUqc3sUUKc3eTj2Lf3yTyGGbIjFmvAE5Q==@4a593693-0ee0-4-231-b9ee.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("Vishnu");

            var collection = db.GetCollection<Student_Info>("MyData");

            using (var cursor = await collection.Find(new BsonDocument()).ToCursorAsync())
            {
                while (await cursor.MoveNextAsync()) //Cursor maintain the batch size here.
                {
                    foreach (var doc in cursor.Current)////represent the current document in the cursor
                    {
                        student.Add(doc);
                    }
                }
            }
        }
    }
}
