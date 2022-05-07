using System.Collections.Generic;
using System.Collections;

namespace RoleplayGame
{
    public interface ICharacter 
    {

        string Name { get; }

        //public List <IElement> elements = new List<IElement>(); no me deja :( public class triste
        public int AttackValue ();

        public int DefenseValue ();

        int Health { get; }

        public void ReceiveAttack(int power) {}

        public void Cure() {}

        

        

    }
}