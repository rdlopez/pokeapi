using Dataplus.Database.Repositories;
using Pokeball_Database.Context;
using Pokeball_Database.RepositoriesContracts;
using Pokeball_Domain;

namespace Pokeball_Database.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepositsory
    {
        public PlayerRepository(PokeballDBContext dataplusDBContext)
            : base(dataplusDBContext)
        {
        }
    }
}
