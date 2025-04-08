using BlastoiseApp.Domain.DTOs.Pokemons;
using System.Threading.Tasks;

namespace BlastoiseApp.Web.Controllers
{
	public class PokemonController : Controller
	{
		private readonly IPokemonService _pokemonService;

		public PokemonController(IPokemonService pokemonService)
		{
			_pokemonService = pokemonService;
		}

		public async Task<IActionResult> Index()
		{
			var pokemons = await _pokemonService.GetAllAsync();

			return View(pokemons);
		}

		public IActionResult Create()
		{
			var model = new CreatePokemonDTO() { Active = true };

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreatePokemonDTO model)
		{
			if (!ModelState.IsValid)
				return View(model);

			var (success, errorMessage) = await _pokemonService.CreateAsync(model);

			if(!success)
				return View(model);

			return RedirectToAction("Index");
		}


		public async Task<IActionResult> Edit(int id)
		{
			var model = await _pokemonService.GetByIdAsync(id);

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(UpdatePokemonDTO model)
		{
			if (!ModelState.IsValid)
				return View(model);

			var (success, errorMessage) = await _pokemonService.UpdateAsync(model);

			if(!success)
				return View(model);

			return RedirectToAction("Index");
		}


		public async Task<IActionResult> Delete(int id)
		{
			var (success, errorMessage) = await _pokemonService.DeleteByIdAsync(id);

			return RedirectToAction("Index");
		}

	}
}
