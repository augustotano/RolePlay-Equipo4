using System;

namespace Library
{
    public class Spell
    {
        private string SpellName {get;set;}
        private int SpellAttack {get;set;}
        private int SpellDefense {get;set;}
        private string SpellDescription {get;set;}

        public void Spell(string name, int attack, int defense, string description)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.description = description;
        }
    }
}