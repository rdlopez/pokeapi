using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pokeball_Domain;
using Pokeball_Services.ContractServices;

namespace Pokeball_Game_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly ILogger<PokemonController> _logger;
        private readonly IPokemonService _pokemonService;

        public PokemonController(ILogger<PokemonController> logger, IPokemonService pokemonService)
        {
            _logger = logger;
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pokemonService.GetAll());
        }
    }
}