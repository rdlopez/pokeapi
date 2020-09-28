using System.Threading.Tasks;

namespace Pokeball_Services.ContractServices
{
    public interface IPKHttpClient
    {
        string GetAll(string identifier);
    }
}
