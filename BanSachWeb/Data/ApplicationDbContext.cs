using BanSachWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BanSachWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; } 
    }
}
