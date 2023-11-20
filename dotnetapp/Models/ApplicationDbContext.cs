using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Player> Players{get; set;}
        public virtual DbSet<Team> Teams{get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for other entities as needed
    }
}
