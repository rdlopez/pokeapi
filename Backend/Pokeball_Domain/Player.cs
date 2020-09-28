using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeball_Domain
{
    public class Player : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
