using Domain;
using Microsoft.EntityFrameworkCore;

namespace RssFeed.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Domain.RssFeed> RssFeed { get; set; }
        public DbSet<UserData> UserData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: "dbo");
            modelBuilder.Entity<Domain.RssFeed>();
            modelBuilder.Entity<UserData>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
