using System;
using System.Collections.Generic;

namespace Library
{
    public class Character
    {
        public Character(string name, string type, int basicAttack, int basicDefense)
        {
            this.Name = name;
            this.Type = type;
            this.BasicAttack = basicAttack;
            this.BasicDefense = basicDefense;
            elements = new List<Element>();
            bookOfSpells = new List<Spell>();
        }
    
    
        public string Name {get; set;}
        public string Type {get; set;}
        public int BasicAttack {get; set;}
        public int BasicDefense {get; set;}
        private List<Element> elements;
        private List<Spell> bookOfSpells;
        private int health = 100;
        public int Health
        {
            get{return health;}
            set
            {
                if(value < 0)
                {
                    Console.WriteLine($"{this.Name} was slain.");
                }
                else
                {
                    health = value;
                }
            }
        }
    }
}