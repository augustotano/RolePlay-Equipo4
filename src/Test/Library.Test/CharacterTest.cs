using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class CharacterTests
    {

        [Test]
        public void AddSpellTestWizard()
        {
            Character P1 = new Character("Raziel", "WiZaRD", 0, 20);
            Spell fireball = new Spell("Fireball", 40, 0, "Lanza una bola de fuego");
            P1.AddSpell(fireball);
            Assert.IsNotEmpty(P1.bookOfSpells);
        }

        [Test]
        public void AddSpellTestNonWizard()
        {
            Character P1 = new Character("Edmond", "Caballero", 40, 40);
            Spell fireball = new Spell("Fireball", 40, 0, "Lanza una bola de fuego");
            P1.AddSpell(fireball);
            Assert.IsEmpty(P1.bookOfSpells);
        }
        
        [Test]
        public void AttackTest()
        {
            Character P1 = new Character("Edmond", "Caballero", 40, 40);
            Character P2 = new Character("Raziel", "WiZaRD", 0, 20);
            P2.ReceiveAttack(P1.Attack());
            Assert.AreEqual(80, P2.Health);
        }
        
        [Test]
        public void UseSpellTest()
        {
            Spell spell1 = new Spell("First Spell",40,60,"Makes someone laugh a lot");
            Character P2 = new Character("Raziel", "WiZaRD", 0, 20);
            Assert.AreEqual(0, P2.UseSpell(spell1));
        }

    }


}
