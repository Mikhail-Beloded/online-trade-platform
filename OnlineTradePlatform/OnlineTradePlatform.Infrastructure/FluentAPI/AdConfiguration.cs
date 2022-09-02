using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Infrastructure.FluentAPI
{
    public class AdConfiguration : IEntityTypeConfiguration<Ad>
    {
        public void Configure(EntityTypeBuilder<Ad> builder)
        {
            builder.HasOne<User>(x => x.User)
                   .WithMany(y => y.Ads);
        }
    }
}
