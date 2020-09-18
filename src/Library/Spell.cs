using System;

namespace Library
{
    /* SINGLE RESPONSABILITY PRINCIPLE - SRP
        Se establece que cada clase debe tener responsabilidad sobre una parte de la funcionalidad
        proporcionada por el software. Los metodos y atributos de la clase deben estar 
        alineados con esa responsabillidad. 

        "Una clase debe tener solo una razon para cambiar"

        En el caso de querer cambiar como se representan los hechizos del juego, la clase 
        Spell es quien se debe modifiicar. Siendo esta la unica razon de cambio.
    */
    public class Spell
    {
        public Spell(string name, int attack, int defense, string spellDescription)
        {
            this.SpellName = name;
            this.SpellAttack = attack;
            this.SpellDefense = defense;
            this.SpellDescription = spellDescription;
        }
        
        public string SpellName {get;set;}
        public int SpellAttack {get;set;}
        public int SpellDefense {get;set;}
        public string SpellDescription {get;set;}

    }
}