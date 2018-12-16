using API.Entities;
using API.Models;
using API.Services;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace API.Controllers
{
    public class GamesController : ApiController
    {
        private IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [ResponseType(typeof(IEnumerable<GameDto>))]
        public IHttpActionResult GetAllGames()
        {
            var repoGames = _gameRepository.GetAll();
            var dtoGames = Mapper.Map<IEnumerable<GameDto>>(repoGames);
            return Ok(dtoGames);
        }

        [ResponseType(typeof(GameDto))]
        public IHttpActionResult GetGame(int id)
        {
            var repoGame = _gameRepository.Get(id);
            if (repoGame == null)
            {
                return NotFound();
            }
            var dtoGame = Mapper.Map<GameDto>(repoGame);
            return Ok(dtoGame);
        }

        [ResponseType(typeof(GameDto))]
        public IHttpActionResult PostGame(GameCreateDto newGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var game = Mapper.Map<Game>(newGame);
            var gameCreated = _gameRepository.Create(game);
            if (!_gameRepository.Save())
            {
                return InternalServerError();
            }
            var gameResponse = Mapper.Map<GameDto>(gameCreated);
            return CreatedAtRoute("DefaultApi", new { id = gameResponse.Id }, gameResponse);
        }
    }
}
