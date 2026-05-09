using _02WebAPI_MiniProj.Modals;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _02WebAPI_MiniProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonAddressController : ControllerBase
    {
        ///CREATED LOGGER FOR POST
        private ILogger<PersonAddressController> _logger;
        public PersonAddressController(ILogger<PersonAddressController> logger)
        {
            _logger = logger;
        }

        // GET: api/<PersonAddress>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonAddress>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonAddress>

        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        [HttpPost("person")]
        public void PersonPost([FromBody] PersonModal values)
        {
            _logger.LogInformation("Hello {FirstName} {LastName} is active {IsActive}", values.FirstName, values.LastName , values.IsActive);
        }

        [HttpPost("address")]
        public void AddressPost([FromBody] AddressModal values)
        {
            _logger.LogInformation("Lives in {State} {City} {Street} {Pincode}" , values.State , values.City , values.Street , values.Pincode);
        }



        // PUT api/<PersonAddress>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonAddress>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
