using Microsoft.EntityFrameworkCore;
using SuperHero.Domains;

namespace SuperHero.DataLayer
{
    public class SuperHeroContext : DbContext
    {
        public SuperHeroContext(DbContextOptions<SuperHeroContext> options) : base(options)

        {
        }

        public DbSet<SuperHeroDomain> SuperHero { get; set; }
    }
}
