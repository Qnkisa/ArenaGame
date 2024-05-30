using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        //archer is a child class of hero, can dodge an attack and get a critical strike
        private const int DodgeChance = 20;
        private const int CriticalHitChance = 15;

        public Archer() : this("Sus Archer")
        {

        }

        public Archer(string name) : base(name)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(DodgeChance))
            {
                //Dodging the attack of the enemy
                incomingDamage = 0;
            }

            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseDamage = base.Attack();

            if (ThrowDice(CriticalHitChance))
            {
                baseDamage *= 2; // Doubling the damage if we crit
            }

            return baseDamage;
        }
    }
}
