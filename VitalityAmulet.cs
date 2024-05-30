using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class VitalityAmulet : Artifact
    {
        //vitality amulet is a child of artifact, increases the heal amount of a Hero
        public VitalityAmulet(string name) : base(name, "IncreaseHealHealth", 50)
        {
            Name = name;
        }
    }
}
