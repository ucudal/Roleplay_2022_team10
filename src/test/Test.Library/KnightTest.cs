using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class KnightTest
    {
        [Test]
        public void KnightAddElement()
        {
            Knight Knight = new Knight("Dark Knight");
            Sword sword = new Sword();
            Armor armor = new Armor();

            Knight.addElement(sword);
            Knight.addElement(armor);

            Assert.AreEqual(30, Knight.AttackValue());
            Assert.AreEqual(25, Knight.DefenseValue());
        }

        [Test]
        public void KnightAttack()
        {
            Knight Knight = new Knight("Dark Knight");
            Sword sword = new Sword();
            Dwarf dwarf = new Dwarf("Richi");

            
            Knight.addElement(sword);
            dwarf.ReceiveAttack(Knight.AttackValue());

            Assert.AreEqual(70, dwarf.Health);
        }

        public void KnightCure()
        {
            Knight Knight = new Knight("Dark Knight");
            Dwarf dwarf = new Dwarf("Richi");
            Sword sword = new Sword();
            
            dwarf.addElement(sword);
            Knight.ReceiveAttack(dwarf.AttackValue());
            Knight.Cure();

            Assert.AreEqual(100,Knight.Health);
        }
    }
}