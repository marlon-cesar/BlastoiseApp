using BlastoiseApp.Data.Contexts;
using BlastoiseApp.Data.Repositories.Common;
using BlastoiseApp.Domain.Entities.Pokemons;
using BlastoiseApp.Domain.Interfaces.Repositories;

namespace BlastoiseApp.Data.Repositories
{
    public class PokemonRepository : RepositoryBase<Pokemon>, IPokemonRepository
    {
        public PokemonRepository(BlastoiseAppDbContext context) : base(context)
        {
        }
    }
}
