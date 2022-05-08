using NUnit.Framework;
using RolePlay;

namespace Test.Library
{
    public class ElfAttackTest
    {
        [Test]
        public void ElfAttackDwarftTest()
        {
            Dwarf gruñon = new Dwarf("Gruñon", 100, 12);
            Elf harry = new Elf("Ferb", 100, 11);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Elf_Attack_Dwarf(harry, gruñon);
            Assert.AreEqual(89, gruñon.Health);
        }

        [Test]
        public void ElfAttackWizardTest()
        {

        }

        [Test]
        public void ElfAttackElfTest()
        {
            Elf ferb = new Elf("Ferb", 100, 11);
            Elf manuel = new Elf("Manuel", 100, 15);

            GameLogic gameLogic = new GameLogic();
            gameLogic.Elf_Attack_Elf(manuel, ferb);
            Assert.AreEqual(85, ferb.Health);
        }
    }
}