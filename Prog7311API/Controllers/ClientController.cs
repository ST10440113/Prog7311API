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
    public class ClientController : Controller
    {
        private readonly DataContext _context;

        public ClientController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<ClientController>
       
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Client>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return Ok(clients);
        }



        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<ActionResult<Client>> AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetClients), new { id = client.ClientId }, client);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
