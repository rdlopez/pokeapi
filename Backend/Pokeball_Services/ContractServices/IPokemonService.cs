using Pokeball_Domain;

namespace Pokeball_Services.ContractServices
{
    public interface IPokemonService
    {
        BaseResult<Pokemon> GetAll(string identifier = "pokemon");
        Pokemon GetById(int id, string identifier = "pokemon");
    }
}