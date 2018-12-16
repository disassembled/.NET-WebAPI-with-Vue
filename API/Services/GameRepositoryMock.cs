using API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public class GameRepositoryMock : IGameRepository
    {
        private List<Game> _games;

        public GameRepositoryMock()
        {
            int newId = 0;
            _games = GameProvider.GetGames();
            _games.ForEach(g => g.Id = ++newId);
        }

        public IEnumerable<Game> GetAll()
        {
            return _games;
        }

        public Game Get(int id)
        {
            return _games.FirstOrDefault(g => g.Id == id);
        }

        public Game Create(Game game)
        {
            game.Id = _games.Max(g => g.Id) + 1;
            _games.Add(game);
            return game;
        }

        public bool Save()
        {
            return true;
        }
    }
}
