using FW.Db.EF;
using FW.Db.Entities;

namespace FW.Db.DbInitialize
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            SeedSets(dbContext);
            SeedUsers(dbContext);
            SeedWords(dbContext);
        }

        private static void SeedUsers(AppDbContext dbContext)
        {
            if (dbContext.Users.Any()) return;

            User[] users = new User[]
            {
                new User
                {
                    Name = "AdminTest",
                },
                new User
                {
                    Name = "UserTest",
                }
            };

            dbContext.Users.AddRange(users);
            dbContext.SaveChanges();
        }

        private static void SeedSets(AppDbContext dbContext)
        {
            if (dbContext.Sets.Any()) return;

            Set[] sets = new Set[]
            {
                new Set
                {
                    Name = "Family",
                },
                new Set
                {
                    Name = "Holiday",
                }
            };

            dbContext.Sets.AddRange(sets);
            dbContext.SaveChanges();

        }

        private static void SeedWords(AppDbContext dbContext)
        {
            if (dbContext.Words.Any()) return;

            Word[] words = new Word[]
            {
                new Word
                {
                    Name = "I",
                    Translate = "Я",
                },
                new Word
                {
                    Name = "You",
                    Translate = "Ти",
                }
            };

            dbContext.Words.AddRange(words);
            dbContext.SaveChanges();
        }
    }
}
