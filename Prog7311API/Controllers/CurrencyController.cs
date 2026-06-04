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
       
    }
}
