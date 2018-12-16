using API.Entities;
using System;
using System.Collections.Generic;

namespace API.Services
{
    public static class GameProvider
    {
        public static List<Game> GetGames()
        {
            var games = new List<Game>
            {
                new Game { Platform = "PS4",     Title = "Tomb Raider" },
                new Game { Platform = "PS4",     Title = "Journey" },
                new Game { Platform = "XBox360", Title = "Bioshock" },
                new Game { Platform = "XBox360", Title = "Fallout New Vegas" },
                new Game { Platform = "PS4",     Title = "Dishonoured" },
                new Game { Platform = "PS4",     Title = "Assassin's Creed, Syndicate" },
                new Game { Platform = "XBox360", Title = "Batman, Arkham City GOTY" },
                new Game { Platform = "PS4",     Title = "Fallout 4" },
                new Game { Platform = "PS4",     Title = "Dragon Age Inquisition" },
                new Game { Platform = "XBox360", Title = "Portal 2" },
                new Game { Platform = "XBox360", Title = "Alan Wake" },
                new Game { Platform = "PS4",     Title = "The Last Of Us" },
                new Game { Platform = "XBox360", Title = "Spec Ops, The Line" },
            };

            var random = new Random();
            games.ForEach(g => g.Rating = random.Next(3,11));
            return games;
        }
    }
}
