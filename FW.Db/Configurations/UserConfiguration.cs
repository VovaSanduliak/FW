using FW.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FW.Db.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(u => u.Id);



            builder
                .HasMany(u => u.Sets)
                .WithOne(s => s.User);

            builder
                .HasMany(u => u.Words)
                .WithOne(w => w.User);
        }
    }
}
