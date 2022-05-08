using NUnit.Framework;
using RolePlay;

namespace Test.Library
{
    public class WizardAttackTest
    {

        [Test]
        public void WizardAttackDwarfTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 100, 12);
            Wizard harry = new Wizard("Harry Potter", 100, 15);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Wizard_Attack_Dwarf(harry, gruñon);
            Assert.AreEqual(85, gruñon.Health);
        }

        [Test]
        public void WizardAttackElfTest()
        {
            Elf ferb = new Elf("Ferb", 100, 11);
            Wizard harry = new Wizard("Harry Potter", 100, 15);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Wizard_Attack_Elf(harry, ferb);
            Assert.AreEqual(85, ferb.Health);
        }

        [Test]
        public void WizardAttackWizardTest()
        {
            Wizard voldemord = new Wizard("Voldemord", 100, 21);
            Wizard harry = new Wizard("Harry Potter", 100, 15);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Wizard_Attack_Wizard(voldemord, harry);
            Assert.AreEqual(79, harry.Health);
        }



    }
}