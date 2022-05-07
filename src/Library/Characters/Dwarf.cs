namespace RoleplayGame
{
    public class Dwarf : ICharacter
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IAttack Axe { get; set; }

        public IDefense Shield { get; set; }

        public IDefense Helmet { get; set; }

        public int AttackValue()
        {
            return Axe.AttackValue();
        }

        public int DefenseValue()
        {
            return Shield.DefenseValue() + Helmet.DefenseValue();
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