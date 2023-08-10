using FW.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FW.Db.Configurations
{
    public class UserSetConfiguration : IEntityTypeConfiguration<UserSet>
    {
        public void Configure(EntityTypeBuilder<UserSet> builder)
        {
            builder
                .HasKey(us => new { us.UserId, us.SetId });

            builder
                .HasOne(us => us.User)
                .WithMany(u => u.Sets)
                .HasForeignKey(us => us.UserId)
                .IsRequired();
        }  
    }
}
