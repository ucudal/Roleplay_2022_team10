using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IElement
    {
        public Spell[] Spells { get; set; }
        
        public int AttackValue()
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue();
                }
                return value;
            }
        

        public int DefenseValue()
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue();
                }
                return value;
            }
        }
}

