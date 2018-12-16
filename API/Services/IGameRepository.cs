using API.Entities;
using System.Collections.Generic;

namespace API.Services
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();
        Game Get(int Id);
        Game Create(Game game);
        bool Save();
    }
}
