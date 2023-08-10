using FW.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FW.Db.Configurations
{
    public class SetWordConfiguration : IEntityTypeConfiguration<SetWord>
    {
        public void Configure(EntityTypeBuilder<SetWord> builder)
        {
            builder
                .HasKey(sw => new {sw.SetId, sw.WordId });

            builder
                .HasOne(sw => sw.Set)
                .WithMany(s => s.Words)
                .HasForeignKey(sw => sw.SetId)
                .IsRequired();

            builder
                .HasOne(sw => sw.Word)
                .WithOne(w => w.Set)
                .IsRequired();
        }
    }
}
