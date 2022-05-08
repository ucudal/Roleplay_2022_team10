using NUnit.Framework;
using RolePlay;
using System.Collections.Generic;

namespace Test.Library
{
    public class GetTotalAttacksTest
    {
        Bow arco = new Bow("arco");
        BreastPlate pechera = new BreastPlate("pechera");
        Helmet casco = new Helmet("casco");
        InfinityGems gemas = new InfinityGems("gemas");
        Knife cuchillo = new Knife("cuchillo");
        Shield escudo = new Shield("escudo");
        Shotgun escopeta = new Shotgun("escopeta");
        Sword espada = new Sword("espada");

        [Test]
        public void VerifyTotalDamage_Dwarf()
        {
            Dwarf enano = new Dwarf("El petiso", 100, 100);
            enano.AddElement(arco);
            enano.AddElement(pechera);
            enano.AddElement(casco);
            enano.AddElement(gemas);
            enano.AddElement(cuchillo);
            enano.AddElement(escudo);
            enano.AddElement(escopeta);
            enano.AddElement(espada);
            
            int totalDamage = 600; 
            Assert.AreEqual(totalDamage,enano.TotalDamage());
        }

        public void VerifyTotalDamage_Elf()
        {
            Elf elfo = new Elf("El alto", 100, 100);
            elfo.AddElement(arco);
            elfo.AddElement(pechera);
            elfo.AddElement(casco);
            elfo.AddElement(gemas);
            elfo.AddElement(cuchillo);
            elfo.AddElement(escudo);
            elfo.AddElement(escopeta);
            elfo.AddElement(espada);
            
            int totalDamage = 600; 
            Assert.AreEqual(totalDamage,elfo.TotalDamage());
        }

        public void VerifyTotalDamage_Wizard()
        {
            Wizard mago = new Wizard("El mago Jacinto", 100, 100);
            mago.AddElement(arco);
            mago.AddElement(pechera);
            mago.AddElement(casco);
            mago.AddElement(gemas);
            mago.AddElement(cuchillo);
            mago.AddElement(escudo);
            mago.AddElement(escopeta);
            mago.AddElement(espada);
            
            int totalDamage = 600; 
            Assert.AreEqual(totalDamage,mago.TotalDamage());
        }
    }
}