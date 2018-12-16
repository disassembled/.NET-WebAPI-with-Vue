using API.Entities;
using API.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public class GameRepository : IGameRepository
    {
        private APIContext _context;

        public GameRepository(APIContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> GetAll()
        {
            return _context.Games;
        }

        public Game Get(int id)
        {
            return _context.Games.SingleOrDefault(g => g.Id == id);
        }

        public Game Create(Game game)
        {
            _context.Games.Add(game);
            return game;
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
