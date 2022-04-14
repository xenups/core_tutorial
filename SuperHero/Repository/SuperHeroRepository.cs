using Microsoft.EntityFrameworkCore;
using SuperHero.DataLayer;
using SuperHero.Domains;

namespace SuperHero.Repositories
{
    public class SuperHeroRepository : ISuperHerosRepository
    {
        private SuperHeroContext context;
        public SuperHeroRepository(SuperHeroContext superHeroContext)
        {
            this.context = superHeroContext;
        }

        public Task CreateSuperHeroAsync(SuperHeroDomain item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSuperHeroAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SuperHeroDomain> GetSuperHeroAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SuperHeroDomain>> GetSuperHerosAsync()
        {
            return await context.SuperHero.ToListAsync();
        }

        public Task UpdateSuperHeroAsync(SuperHeroDomain item)
        {
            throw new NotImplementedException();
        }
    }
}