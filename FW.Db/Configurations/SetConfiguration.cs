using FW.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FW.Db.Configurations
{
    public class SetConfiguration : IEntityTypeConfiguration<Set>
    {
        public void Configure(EntityTypeBuilder<Set> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .HasMany(s => s.Words)
                .WithOne(sw => sw.Set);
        }
    }
}
