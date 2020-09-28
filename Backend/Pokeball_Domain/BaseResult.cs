using System.Collections.Generic;

namespace Pokeball_Domain
{
    public class BaseResult<T> where T : class
    {
        public List<T> Results { get; set; }
    }
}