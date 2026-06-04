using Microsoft.EntityFrameworkCore;
using Prog7311API.Models;

namespace Prog7311API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<ServiceRequest> ServiceRequest { get; set; }
    }
}
