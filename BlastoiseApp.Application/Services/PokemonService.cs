namespace BlastoiseApp.Application.Services
{
	public class PokemonService : IPokemonService
	{
		private readonly IPokemonRepository _pokemonRepository;

		public PokemonService(IPokemonRepository pokemonRepository)
		{
			_pokemonRepository = pokemonRepository;
		}

		public async Task<List<PokemonListDTO>> GetAllActivesAsync()
		{
			var pokemons = await _pokemonRepository.SearchAsync(x => x.Active);

			return pokemons.Adapt<List<PokemonListDTO>>();
		}
	}
}
