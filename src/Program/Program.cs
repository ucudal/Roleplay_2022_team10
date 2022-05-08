using System;

namespace RoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            Spell spell = new Spell();
            book.addSpellToBook(spell);
            Wizard gandalf = new Wizard("Gandalf");
            Staff Staff = new Staff();
            gandalf.addElement(Staff);
            SpellsBook SpellsBook = new SpellsBook();
            gandalf.addElement(SpellsBook);

            Dwarf gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            gimli.addElement(axe);
            gimli.addElement(helmet);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue()}");

            gimli.ReceiveAttack(gandalf.AttackValue());

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
