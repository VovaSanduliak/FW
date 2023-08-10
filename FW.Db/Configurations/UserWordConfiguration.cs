using FW.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FW.Db.Configurations
{
    class UserWordConfiguration : IEntityTypeConfiguration<UserWord>
    {
        public void Configure(EntityTypeBuilder<UserWord> builder)
        {
            builder
                .HasKey(uw => new { uw.UserId, uw.WordId });

            builder
                .HasOne(uw => uw.User)
                .WithMany(u => u.Words)
                .HasForeignKey(uw => uw.UserId)
                .IsRequired();
        }


    }
}
