using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IElement
    {
        private List<Spell> spells = new List<Spell>();

        public List<Spell> Spells
        {
            get
            {
                return this.spells;
            }
        }

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


        public void addSpellToBook(Spell spell)
        {
            spells.Add(spell);
        }

        public void removeSpellToBook(Spell spell)
        {
            spells.Remove(spell);
        }
    }
}

