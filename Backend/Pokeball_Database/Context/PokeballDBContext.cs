using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Pokeball_Domain;

namespace Pokeball_Database.Context
{
    public class PokeballDBContext : DbContext
    {
        #region Constructor
        public PokeballDBContext(DbContextOptions<PokeballDBContext> options, IConfiguration configuration)
               : base(options)
        {
        }

        #endregion

        #region Properties
        public DbSet<Player> Players  { get; set; }

        #endregion
    }
}