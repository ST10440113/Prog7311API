using Microsoft.AspNetCore.Mvc;
using Prog7311API.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prog7311API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CurrencyController : Controller
    {
        private readonly DataContext _context;

        public CurrencyController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<CurrencyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CurrencyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CurrencyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CurrencyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CurrencyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
