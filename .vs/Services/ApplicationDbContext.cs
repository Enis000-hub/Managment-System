using HardwareStore.Models;
using Microsoft.EntityFrameworkCore;

namespace HardwareStore.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
