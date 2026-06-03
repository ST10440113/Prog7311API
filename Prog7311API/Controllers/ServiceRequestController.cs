using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prog7311API.Data;
using Prog7311API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prog7311API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ServiceRequestController : Controller
    {
        private readonly DataContext _context;

        public ServiceRequestController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ServiceRequestController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ServiceRequest>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ServiceRequest>>> GetServiceRequests()
        {
            var serviceRequests = await _context.ServiceRequests.ToListAsync();
            return Ok(serviceRequests);
        }
        // GET api/<ServiceRequestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ServiceRequestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServiceRequestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServiceRequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
