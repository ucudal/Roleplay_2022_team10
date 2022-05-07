using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : ICharacter, IAttack, IDefense
    {
        private int health = 100;

        public List <IElement> elements = new List<IElement>();
        public List <IElement> Elements { get {return this.elements;} }

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public IAttack Bow { get; set; }

        public IDefense Helmet { get; set; }

        public int AttackValue()
        {
            return Bow.AttackValue();
            
        }

        public int DefenseValue()
        {
            
            return Helmet.DefenseValue();
            
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