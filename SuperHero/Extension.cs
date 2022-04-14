using SuperHero.DTOs;
using SuperHero.Domains;

namespace SuperHero
{
    public static class Extensions
    {
        public static SuperHeroDTO AsDTO(this SuperHeroDomain item)
        {
            return new SuperHeroDTO
            {
                Id = item.Id,
                Name = item.Name,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Place = item.Place,
                CreatedCate = item.CreatedCate,
            };
        }
    }
}