using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Artifact
    {
        //base class for artifacts that enhance the heroes
        public Artifact(string name, string specialAbility, int specialAbilityPoints)
        {
            Name = name;
            SpecialAbility = specialAbility;
            SpecialAbilityPoints = specialAbilityPoints;
        }

        public string Name { get; private set; }
        public string SpecialAbility { get; private set; }
        public int SpecialAbilityPoints { get; private set; }

    }
}
