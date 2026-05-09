using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _01MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        // GET: api/<MessageWallController>
        [HttpGet]
        public IEnumerable<string> Get(string fName = "", string lname = "")  //displays first and last name ====== api/MessageWall?fName=Dhruv&lName=Sharma
        {
            List<String> output = new List<string>
            {
                "Hello Sir",
                "Your very Intillegent"
            };
            if (string.IsNullOrWhiteSpace(fName) == false)
            {
                output.Add(fName);
            }

            if (string.IsNullOrWhiteSpace(lname) == false)
            {
                output.Add(lname);
            }

            return output;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
