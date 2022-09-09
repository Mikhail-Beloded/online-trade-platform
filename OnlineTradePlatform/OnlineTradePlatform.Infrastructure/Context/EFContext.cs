using Microsoft.EntityFrameworkCore;
using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Infrastructure.FluentAPI;

namespace OnlineTradePlatform.Infrastructure.Context
{
    public class EFContext : DbContext
    {
        public EFContext()
        {

        }

        public EFContext(DbContextOptions<EFContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        DbSet<User> Users { get; set; }

        DbSet<Ad> Ads { get; set; }
    }
}
