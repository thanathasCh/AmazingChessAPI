using AmazingCheeAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace AmazingCheeAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserScore> UserScores { get; set; }
        public DbSet<GameHistory> GameHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameHistory>()
                        .HasOne(x => x.Player1)
                        .WithMany()
                        .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<GameHistory>()
                        .HasOne(x => x.Player2)
                        .WithMany()
                        .OnDelete(DeleteBehavior.Restrict);
            
            base.OnModelCreating(modelBuilder);
        }
        
    }
}