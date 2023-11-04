using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcCrud_Auth.Models;

namespace MvcCrud_Auth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().ToTable("Game");
            modelBuilder.Entity<GameSystem>().ToTable("Console");
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameSystem> GameSystems { get; set; }
    }
}