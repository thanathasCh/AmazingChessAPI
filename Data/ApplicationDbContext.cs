using AmazingChessAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace AmazingChessAPI.Data
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

            modelBuilder.Entity<User>()
                        .HasIndex(x => new {x.UserName, x.Email});

            base.OnModelCreating(modelBuilder);
        }
        
    }
}