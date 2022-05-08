using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTest
    {
        [Test]
        public void ArcherAddElement()
        {

            Archer Tauriel = new Archer("Tauriel");
            Bow bow = new Bow();
            Sword sword = new Sword();
            Helmet helmet = new Helmet();
            Tauriel.addElement(bow);
            Tauriel.addElement(sword);
            Tauriel.addElement(helmet);

            Dwarf Gruñon = new Dwarf("Gruñon");
            Axe axe = new Axe();
            Armor armor = new Armor();
            Shield shield = new Shield();
            Gruñon.addElement(axe);
            Gruñon.addElement(armor);  
            Gruñon.addElement(shield);

            Assert.AreEqual(50,Tauriel.AttackValue());
            Assert.AreEqual(18,Tauriel.DefenseValue());
            Assert.AreEqual(25,Gruñon.AttackValue());
            Assert.AreEqual(39,Gruñon.DefenseValue());

        }

        [Test]
        public void ArcherAttack()
        {
         
            Archer Tauriel = new Archer("Tauriel");
            Bow bow = new Bow();
            Sword sword = new Sword();
            Helmet helmet = new Helmet();
            Tauriel.addElement(bow);
            Tauriel.addElement(sword);
            Tauriel.addElement(helmet);

            Dwarf Gruñon = new Dwarf("Gruñon");
            Axe axe = new Axe();
            Armor armor = new Armor();
            Shield shield = new Shield();
            Gruñon.addElement(axe);
            Gruñon.addElement(armor);  
            Gruñon.addElement(shield);

            Gruñon.ReceiveAttack(Tauriel.AttackValue());

            Assert.AreEqual(89,Gruñon.Health);

        }
        [Test]
        public void Heal()
        {
         
            Archer Tauriel = new Archer("Tauriel");
            Bow bow = new Bow();
            Sword sword = new Sword();
            Helmet helmet = new Helmet();
            Tauriel.addElement(bow);
            Tauriel.addElement(sword);
            Tauriel.addElement(helmet);

            Dwarf Gruñon = new Dwarf("Gruñon");
            Axe axe = new Axe();
            Armor armor = new Armor();
            Shield shield = new Shield();
            Gruñon.addElement(axe);
            Gruñon.addElement(armor);  
            Gruñon.addElement(shield);

            Gruñon.ReceiveAttack(Tauriel.AttackValue());
            Gruñon.Cure();

            Assert.AreEqual(100,Gruñon.Health);

        }
    }
}