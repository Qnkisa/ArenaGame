using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Shield : Artifact
    {
        //long sword is a child of artifact, decreases the damage the hero is taking when attacked
        public Shield(string name) : base(name, "ReduceEnemyAttackDamage", 50)
        {
            Name = name;
        }
    }
}
