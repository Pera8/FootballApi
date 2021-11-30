using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
namespace Repository
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //if (!options.IsConfigured)
            //{
            //    options.UseSqlServer("YourLocalConnectionStringShouldBeHere");
            //}
            //base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<FootballClub> FootballClubs { get; set; }
    }
}
