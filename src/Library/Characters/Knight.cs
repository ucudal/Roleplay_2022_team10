namespace RoleplayGame
{
    public class Knight : ICharacter
    {
        private int health = 100;

        public Knight(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IAttack Sword { get; set; }

        public IDefense Shield { get; set; }

        public IDefense Armor { get; set; }

        public int AttackValue()
        {
            return Sword.AttackValue();      
        }

        public int DefenseValue()
        {
            return Armor.DefenseValue() + Shield.DefenseValue();
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue() < power)
            {
                this.Health -= power - this.DefenseValue();
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}