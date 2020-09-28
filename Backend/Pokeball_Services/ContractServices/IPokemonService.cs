using Pokeball_Domain;
using System.Collections.Generic;

namespace Pokeball_Services.ContractServices
{
    public interface IPokemonService
    {
        BaseResult<Pokemon> GetAll(string identifier = "pokemon");
    }
}