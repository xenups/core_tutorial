using SuperHero.Domains;

namespace SuperHero.Repositories
{
    public interface ISuperHerosRepository
    {
        Task<SuperHeroDomain> GetSuperHeroAsync(Guid id);
        Task<IEnumerable<SuperHeroDomain>> GetSuperHerosAsync();

        Task CreateSuperHeroAsync(SuperHeroDomain item);
        Task UpdateSuperHeroAsync(SuperHeroDomain item);
        Task DeleteSuperHeroAsync(Guid id);
    }
}