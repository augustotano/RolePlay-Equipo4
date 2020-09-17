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

    }


}