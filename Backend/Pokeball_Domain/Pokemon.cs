using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeball_Domain
{
    public class Pokemon : BaseResult<Pokemon>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Base_Experience { get; set; }
        public int Height { get; set; }
        public bool isDefault { get; set; }
        public int Weight { get; set; }
        //public List<Ability> Abilities { get; set; }
        //public List<Move> Moves { get; set; }
        //public List<Type> Types { get; set; }
        //public List<Stats> Stats { get; set; }
    }
}