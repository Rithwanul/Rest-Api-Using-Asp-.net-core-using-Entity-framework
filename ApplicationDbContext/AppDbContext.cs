using Microsoft.EntityFrameworkCore;
using Commander.Models;

namespace Commander.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}