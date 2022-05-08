using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class WizardTest
    {
        [Test]
        public void WizardAddElement()
        {
            Wizard wizard = new Wizard("Harry Potter");
            SpellsBook spellsBook = new SpellsBook();
            Spell spell = new Spell();
            Staff staff = new Staff();

            spellsBook.addSpellToBook(spell);
            wizard.addElement(staff);
            wizard.addElement(spellsBook);


            Assert.AreEqual(170, wizard.AttackValue());
            Assert.AreEqual(170, wizard.DefenseValue());
        }

        [Test]
        public void WizardAttack()
        {
            Wizard wizard = new Wizard("Harry Potter");
            Dwarf dwarf = new Dwarf("Richi");
            SpellsBook spellsBook = new SpellsBook();
            Spell spell = new Spell();

            spellsBook.addSpellToBook(spell);
            wizard.addElement(spellsBook);
            dwarf.ReceiveAttack(wizard.AttackValue());

            Assert.AreEqual(30, dwarf.Health);
        }

        public void WizardCure()
        {
            Wizard wizard = new Wizard("Harry Potter");
            Dwarf dwarf = new Dwarf("Richi");
            Sword sword = new Sword();
            
            dwarf.addElement(sword);
            wizard.ReceiveAttack(dwarf.AttackValue());
            wizard.Cure();

            Assert.AreEqual(100,wizard.Health);
        }
    }
}