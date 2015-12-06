using Microsoft.Data.Entity;

namespace TicketsSearch.Data.Models
{
    public class TicketsSearchDbContext : DbContext
    {
        public DbSet<Stantion> Stantions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stantion>(b =>
            {
                b.ToTable("Stantions");
            });
        }
    }
}
