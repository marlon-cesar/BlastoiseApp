using BlastoiseApp.Data.Mapping;
using BlastoiseApp.Domain.Entities.Pokemons;
using Microsoft.EntityFrameworkCore;

namespace BlastoiseApp.Data.Contexts
{
    public class BlastoiseAppDbContext : DbContext
    {
        public BlastoiseAppDbContext(DbContextOptions<BlastoiseAppDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PokemonMap());
        }
    }
}
