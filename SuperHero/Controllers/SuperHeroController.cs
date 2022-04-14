using Microsoft.AspNetCore.Mvc;
using SuperHero.DTOs;
using SuperHero.Repositories;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHerosRepository repository;

        public SuperHeroController(ISuperHerosRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<SuperHeroDTO>> GetSuperHerosAsync()
        {
            var superHeros = (await repository.GetSuperHerosAsync()).Select(SuperHero => SuperHero.AsDTO());
            return superHeros;
        }
    }
}
