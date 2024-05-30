namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }

        //adding an artifact property
        public Artifact Artifact { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
        }

        public virtual int Attack()
        {
            int baseDamage = (Strength * Random.Shared.Next(80, 121)) / 100;

            //Checking if artifact exists and if it is a long sword, we increase the hero attack damage
            if (Artifact != null && Artifact is LongSword)
            {
                baseDamage += longSword.SpecialAbilityPoints;
            }

            return baseDamage;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;

            //Checking if artifact exists and if it is a shield, then reflecting some incoming damage
            if (Artifact != null && Artifact is Shield)
            {
                incomingDamage -= shield.SpecialAbilityPoints;
                if (incomingDamage < 0)
                {
                    incomingDamage = 0;
                }
            }

            Health -= incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            //Checking if artifact exists and if it is a vitality amulet we heal for more
            if (Artifact != null && Artifact is VitalityAmulet)
            {
                value += Artifact.SpecialAbilityPoints;
            }
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }

        protected void EquipArtifact(Artifact artifact)
        {
            //Equiping artifact if we don't have one already
            if (Artifact == null)
            {
                Artifact = artifact;
            }
        }
    }
}
