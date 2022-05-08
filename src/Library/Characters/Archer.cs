using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : ICharacter
    {
        private int health = 100;

        public List <IElement> elements = new List<IElement>();
        public List <IElement> Elements { get {return this.elements;} }

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public void addElement(IElement element)
        {
            Elements.Add(element);
        }

        public void removeElement(IElement element)
        {
            Elements.Remove(element);
        }

        public int AttackValue()
        {
            int Attack = 0;
            foreach (var item in Elements)
            {
                Attack += item.AttackValue();
            }
            return Attack;   
        }

        public int DefenseValue()
        {
            
            int Defense = 0;
            foreach (var item in Elements)
            {
                Defense += item.DefenseValue();
            }
            return Defense;   
            
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