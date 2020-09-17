using System;

namespace Library
{
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