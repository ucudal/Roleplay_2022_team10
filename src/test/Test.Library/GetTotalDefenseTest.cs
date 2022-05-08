using NUnit.Framework;
using System.Collections.Generic;
using RolePlay;

namespace Test.Library
{
    public class GetTotalDefenseTest
    {
        [Test]
        public void DwarfDefense()
        {
            Dwarf dwarf1 = new Dwarf ("Grunge",50,100);
            Shield item1 = new Shield ("Shield");
            dwarf1.AddElement(item1);
            Assert.AreEqual(150,dwarf1.TotalDefense());
            
        }
        
        [Test]
        public void ElfDefense()
        {
            Elf elf1 = new Elf ("Amil",100,50);
            Shield item1 = new Shield ("Shield");
            BreastPlate item2 = new BreastPlate ("BreastPlate");
            elf1.AddElement(item1);
            elf1.AddElement(item2);
            Assert.AreEqual(300,elf1.TotalDefense());
            
        }
        
        [Test]
        public void WizardDefense()
        {
            Wizard wizard1 = new Wizard ("Adil",150,50);
            Shield item1 = new Shield ("Shield");
            Helmet item2 = new Helmet ("Helmet");
            wizard1.AddElement(item1);
            wizard1.AddElement(item2);
            Assert.AreEqual (350,wizard1.TotalDefense());
            
        }
    }
}