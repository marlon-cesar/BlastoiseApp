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
            var pokemons = await _pokemonService.GetAllActivesAsync();

            return View(pokemons);
        }


    }
}
