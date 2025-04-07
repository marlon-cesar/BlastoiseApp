namespace BlastoiseApp.Domain.DTOs.Pokemons
{
	public class CreatePokemonDTO
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public int Code { get; set; }
		[Required]
		public bool Active { get; set; }
	}
}
