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
    public class ContractController : Controller
    {
        private readonly DataContext _context;

        public ContractController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ContractController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Contract>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Contract>>> GetContracts()
        {
            var contracts = await _context.Contracts.ToListAsync();
            return Ok(contracts);
        }

        // GET api/<ContractController>/5
        [HttpGet("{id}")]
        public async Task<Contract> GetContractByIdAsync(int id)
        {
              return  await _context.Contracts.FirstOrDefaultAsync(m => m.ContractId == id);  
        }

        // POST api/<ContractController>
        [HttpPost]
        public async Task<ActionResult<Contract>> AddContract(Contract contract)
        {
            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetContracts), new { id = contract.ContractId }, contract);
        }

        // PUT api/<ContractController>/5
        [HttpPut("{id}")]
        public async Task UpdateContract(int id, Contract contract)
        {
           _context.Contracts.Update(contract);
           await _context.SaveChangesAsync();   

        }

        // DELETE api/<ContractController>/5
        [HttpDelete("{id}")]
        public async Task DeleteContract(int id)
        {
            var contract = await GetContractByIdAsync(id);
            if (contract != null)
            {
                _context.Contracts.Remove(contract);
            }

            await _context.SaveChangesAsync();
        }
    }
    }

