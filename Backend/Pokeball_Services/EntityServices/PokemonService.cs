using Newtonsoft.Json;
using Pokeball_Domain;
using Pokeball_Services.ContractServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokeball_Services.EntityServices
{
    public class PokemonService : IPokemonService
    {
        private readonly IPKHttpClient client;
        public PokemonService(IPKHttpClient httpClient)
        {
            client = httpClient;
        }
        public BaseResult<Pokemon> GetAll(string identifier)
        {
            var result = client.GetAll(identifier);
            return JsonConvert.DeserializeObject<BaseResult<Pokemon>>(result);
        }
        public Pokemon GetById(int id, string identifier)
        {
            var result = client.GetById(identifier, id);
            return JsonConvert.DeserializeObject<Pokemon>(result);
        }
    }
}