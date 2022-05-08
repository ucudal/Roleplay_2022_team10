using NUnit.Framework;
using RolePlay;

namespace Test.Library
{
    public class CharacterCureTest
    {

        [Test]
        public void DwarfCureTest()
        {
            Elf ben = new Elf("Ben", 100, 13);
            Dwarf pep = new Dwarf("Pep", 100, 12);
            GameLogic gameLogic = new GameLogic();

            gameLogic.Elf_Attack_Dwarf(ben, pep);
            gameLogic.Total_Health_Dwarf(pep);
            Assert.AreEqual(100, pep.Health);       
        }
        [Test]
        public void ElfCureTest()
        {
            Elf ben = new Elf("Ben", 100, 13);
            Dwarf pep = new Dwarf("Pep", 100, 12);
            GameLogic gameLogic = new GameLogic();

            gameLogic.Dwarf_Attack_Elf(pep, ben);
            gameLogic.Total_Health_Elf(ben);
            Assert.AreEqual(100, ben.Health);  
        }
        [Test]
        public void WizardCureTest()
        {
            Wizard max = new Wizard("Max", 100, 33);
            Dwarf pep = new Dwarf("Pep", 100, 12);
            GameLogic gameLogic = new GameLogic();

            gameLogic.Dwarf_Attack_Wizard(pep, max);
            gameLogic.Total_Health_Wizard(max);

            Assert.AreEqual(100, max.Health);
        }
    }
}