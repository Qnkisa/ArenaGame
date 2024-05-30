using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class LongSword : Artifact
    {
        //long sword is a child of artifact, increases the damage of hero
        public LongSword(string name) : base(name, "DealExtraDamage", 70)
        {
            Name = name;
        }
    }
}
