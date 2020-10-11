using Pokeball_Services.ContractServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pokeball_Services.UtilityServices
{
    public class PkHttpClient : IPKHttpClient
    {
        private readonly HttpClient httpClient;
        public PkHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string GetAll(string identifier) 
        {
            var result = this.httpClient.GetAsync(string.Format("https://pokeapi.co/api/v2/{0}", identifier)).Result;
            return result.Content.ReadAsStringAsync().Result;
        }
        public string GetById(string identifier,int id)
        {
            var result = this.httpClient.GetAsync(string.Format("https://pokeapi.co/api/v2/{0}/{1}", identifier, id)).Result;
            return result.Content.ReadAsStringAsync().Result;
        }
    }
}