namespace BlastoiseApp.Domain.Entities.Pokemons
{
	public class Pokemon : BaseEntity
	{
		public Pokemon(string name, int code)
		{
			Name = name;
			Code = code;
		}
		[MaxLength(100)]
		public string Name { get; private set; } = null!;
		public int Code { get; private set; }
	}
}
