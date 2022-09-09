using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Infrastructure.FluentAPI
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany<Ad>(x => x.Ads)
                   .WithOne(y => y.User);
        }
    }
}
