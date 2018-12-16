using API.Models;
using API.Services;

namespace API
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using (var db = new APIContext())
            {
                if (db.Database.Exists())
                {
                    db.Database.ExecuteSqlCommand("DELETE FROM Games; DBCC CHECKIDENT (Games, RESEED, 0);");
                }

                db.Games.AddRange(GameProvider.GetGames());
                db.SaveChanges();
            }
        }
    }
}