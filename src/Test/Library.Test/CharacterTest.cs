using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class CharacterTests
    {
        //En el test AddSpellTestWizard estamos comprobando que cuando se llama a el metodo AddSpell
        //sea un Mago quien lo pueda usar. En este caso el test se da con un mago, por lo que se agrega
        //el Spell a una lista.

        [Test]
        public void AddSpellTestWizard()
        {
            Character P1 = new Character("Raziel", "WiZaRD", 0, 20);
            Spell fireball = new Spell("Fireball", 40, 0, "Lanza una bola de fuego");
            P1.AddSpell(fireball);
            Assert.IsNotEmpty(P1.BookOfSpells);
        }


        //En el caso del test AddSpellTestNonWizard, queremos commprobar que si un personaje que 
        //no es un mago quiere guardar en su armamento un Spell esto no sea posible. Esto se 
        //comprueba viendo si la lista continua vacia luego del uso del metodo.
        [Test]
        public void AddSpellTestNonWizard()
        {
            Character P1 = new Character("Edmond", "Caballero", 40, 40);
            Spell fireball = new Spell("Fireball", 40, 0, "Lanza una bola de fuego");
            P1.AddSpell(fireball);
            Assert.IsEmpty(P1.BookOfSpells);
        }
        
        //En el test Attack estamos probando la logica del ataque. Que un personaje dañe a otro
        //con sus valores predeterminados.
        [Test]
        public void AttackTest()
        {
            Character P1 = new Character("Edmond", "Caballero", 40, 40);
            Character P2 = new Character("Raziel", "WiZaRD", 0, 20);
            P2.ReceiveAttack(P1.Attack());
            Assert.AreEqual(80, P2.Health);
        }
        
        //En este test probamos que un mago pueda usar el metodo UseSpell.
        [Test]
        public void UseSpellTest()
        {
            Spell spell1 = new Spell("First Spell",40,60,"Makes someone laugh a lot");
            Character P2 = new Character("Raziel", "WiZaRD", 0, 20);
            Assert.AreEqual(0, P2.UseSpell(spell1));
        }

        //En este test probamos que si se le pasa por parametro un valor de ataque
        //la vida del personaje atacado se reducira.
        [Test]
        public void ReceiveAttackTest()
        {
            Character elf = new Character("Juan","Elf",30,50);
            elf.ReceiveAttack(80);
            int expected = 70;
            Assert.AreEqual(expected,elf.Health);
        }

        //Se esta comprobando que, luego de que un personaje fue atacado. Al usar el metodo
        //Cure la vida de este volvera a ser 100.
        [Test]
        public void CureTest()
        {
            Character elf = new Character("Juan","Elf",40,50);
            elf.ReceiveAttack(200);
            elf.Cure();
            int expected = 100;
            Assert.AreEqual(expected,elf.Health);
        }

        //En este test se prueba que si un personaje es atacado y su vida es menor a 0.
        //Entonces la salud del personaje se iguala a 0.
        [Test]
        public void HealthTest()
        {
            Character elf = new Character("Juan","Elf",40,50);
            elf.ReceiveAttack(200);
            int expected = 0;
            Assert.AreEqual(expected,elf.Health);
        }
    }


}
