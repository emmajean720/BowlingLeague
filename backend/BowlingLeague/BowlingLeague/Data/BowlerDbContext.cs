using Microsoft.EntityFrameworkCore;

namespace BowlingLeague.Data
{
    public class BowlerDbContext : DbContext
    {
        // Public constructor with DbContextOptions<BowlerDbContext>
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options)
            : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the foreign key relationship
            modelBuilder.Entity<Bowler>()
                .HasOne(b => b.Team)
                .WithMany(t => t.Bowlers)
                .HasForeignKey(b => b.TeamID);
        }
    }
}
