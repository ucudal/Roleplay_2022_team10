using System.Collections.Generic;
using System.Collections;

namespace RoleplayGame
{
    public interface ICharacter 
    {

        string Name { get; }

        List <IElement> Elements { get; }
        public int AttackValue ();

        public int DefenseValue ();

        int Health { get; }

        public void ReceiveAttack(int power) {}

        public void Cure() {}

        

        

    }
}