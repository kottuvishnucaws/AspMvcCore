using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspMvcCore.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace AspMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDataController : ControllerBase
    {
        private static List<Student_Info> student;

        // GET: api/StudentData
        [HttpGet]
        public IEnumerable<Student_Info> Get()
        {
            GetStudent().Wait();

            return student;
        }

        // GET: api/StudentData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StudentData
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Student_Info info = JsonConvert.DeserializeObject<Student_Info>(value);

            InsertStudentData(info).Wait();
        }

        // PUT: api/StudentData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
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
            await collection.InsertOneAsync(document);
        }
    }
}
