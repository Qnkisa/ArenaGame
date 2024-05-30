using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        //mage is a child class of hero, can reflect an attack and get bonus damage
        private const int ReflectDamageChance = 15;
        private const int BonusSpellDamageChance = 10;

        public Mage() : this("Sus Mage")
        {

        }

        public Mage(string name) : base(name)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(ReflectDamageChance))
            {
                //Reflecting the attack of the enemy
                incomingDamage = 0;
            }

            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseDamage = base.Attack();

            if (ThrowDice(BonusSpellDamageChance))
            {
                baseDamage = (int)(baseDamage * 1.2); // Increasing the damage if we get bonus
            }

            return baseDamage;
        }
    }
}
