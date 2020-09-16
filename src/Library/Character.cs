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
        
         public void AttachObject(Element element)
        {
            elements.Add(element);
        }

        public void RemoveElement(Element element)
        {
            elements.Remove(element);
        }
         
        
        public void AddSpell(Spell spell)
        {
            if(this.Type.ToUpper() == "WIZARD")
            {
                this.bookOfSpells.Add(spell);
            }
            else{
                Console.WriteLine("You're not a wizard Harry");
            }
        }

        public int UseSpell(Spell spell)
        {
            if(spell in this.bookOfSpells)
            {
                Console.WriteLine(SpellDescription);

                if (spell.SpellAttack > 0)
                {
                    return SpellAttack;
                }
                else if (spell.SpellDefense > 0)
                {
                    return SpellDefense;
                }
                else
                {
                    return 0;
                }
            }
        }            
            
        public int Attack()
        {
            int totalPower = this.BasicAttack;

            foreach (Element element in this.elements)
            {
                totalPower += element.Damage;
            }
            
            return totalPower;
        }

        public void ReceiveAttack(int damage)
        {
            int totalDefence = this.BasicDefense;
            foreach (Element element in this.elements)
            {
                totalDefence += element.Defence;
            }
            
            this.health -= damage;
        }
    }
}
