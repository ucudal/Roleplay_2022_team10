using NUnit.Framework;
using RolePlay;

namespace Test.Library
{


    public class DwarfAttack
    {

        [Test]
        public void DwarfAttackDwarf()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 100, 12);
            Dwarf happy = new Dwarf("HappyDwarf", 100, 7);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Dwarf_Attack_Dwarf(gruñon, happy);
            Assert.AreEqual(88, happy.Health);
        }

        [Test]
        public void DwarfAttackElf()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 100, 12);
            Elf harry = new Elf("Ferb", 100, 11);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Dwarf_Attack_Elf(gruñon, harry);
            Assert.AreEqual(88, harry.Health);
        }

        [Test]
        public void DwarfAttackWizard()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 100, 12);
            Wizard harry = new Wizard("Harry Potter", 100, 15);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Dwarf_Attack_Wizard(gruñon, harry);

            Assert.AreEqual(88, harry.Health);
        }



        
    }
}