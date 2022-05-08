using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{

    
    public class DwarfTest
    {

        Dwarf gruñon = new Dwarf("Gruñon");
        Axe axe = new Axe();
        Shield shield = new Shield();
        Helmet helmet = new Helmet();


        [Test]
        public void addElements()
        {
            gruñon.addElement(axe);
            gruñon.addElement(shield);
            gruñon.addElement(helmet);

            Assert.AreEqual(25, gruñon.AttackValue());
            Assert.AreEqual(32, gruñon.DefenseValue());
        }

        [Test]
        public void removeElements()
        {
            gruñon.removeElement(shield);

            Assert.AreEqual(25, gruñon.AttackValue());
            Assert.AreEqual(18, gruñon.DefenseValue());
        }

        [Test]
        public void ReceiveAttack()
        {
            Archer archer = new Archer("archer");
            Bow bow = new Bow();
            archer.addElement(bow);
            Sword sword = new Sword();
            archer.addElement(sword);

            gruñon.ReceiveAttack(archer.AttackValue());

            Assert.AreEqual(82, gruñon.Health);
        }

        [Test]
        public void Cure()
        {
            gruñon.Cure();
            Assert.AreEqual(100, gruñon.Health);

        }

    }
}