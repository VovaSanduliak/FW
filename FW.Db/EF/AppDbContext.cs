using FW.Db.Configurations;
using FW.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace FW.Db.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: modelBuilder.ApplyConfigurationsFromAssembly
            modelBuilder.ApplyConfiguration(new SetConfiguration());
            modelBuilder.ApplyConfiguration(new SetWordConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserSetConfiguration());
            modelBuilder.ApplyConfiguration(new UserWordConfiguration());
            modelBuilder.ApplyConfiguration(new WordConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<SetWord> SetWords { get; set; }
        public DbSet<UserSet> UserSets { get; set; }
        public DbSet<UserWord> UserWords { get; set; }
    }
}
