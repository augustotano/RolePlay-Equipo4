using System;
using System.Collections.Generic;

namespace Library
{
    /* EXPERT 
       Por el patron expert deberiamos mirar que clase tiene la informacion necesaria 
       para hacer la logica del juego.

       En este caso la clase Character tiene toda la informacion necesaria (valores de daño, ataque, vida)
       para poder representar una pelea en el juego.

    */
    public class Character
    {

        //Metodo constructor de un personaje, tiene por parametro la informacion necesaria para representar a un personaje
        public Character(string name, string type, int basicAttack, int basicDefense)
        {
            this.Name = name;
            this.Type = type;
            this.BasicAttack = basicAttack;
            this.BasicDefense = basicDefense;
            this.Elements = new List<Element>();
            this.BookOfSpells = new List<Spell>();
        }
    
    
        public string Name {get; set;}
        public string Type {get; set;}
        public int BasicAttack {get; set;}
        public int BasicDefense {get; set;}
        public List<Element> Elements {get; set;}
        public List<Spell> BookOfSpells {get; set;}
        private int health = 100;
        public int Health
        {
            get{return health;}
            set
            {
                if(value < 0)
                {
                    health = 0;
                    Console.WriteLine($"{this.Name} was slain.");
                }
                else
                {
                    health = value;
                }
            }
        }
        
        //Este metodo permite que un personaje recupere su vida original.
        public void Cure()
        {
            this.health = 100;
        }   
        

        //Metodo que agrega los Elementos que un personaje puede usar para atacar o defenderse 
         public void AttachObject(Element element)
        {
            this.Elements.Add(element);
        }

        //Metodo que elimina Elementos de una lista que guarda los items de un personaje
        public void RemoveElement(Element element)
        {
            this.Elements.Remove(element);
        }
         
        //Este metodo agrega un Spell a una lista llamada BookOfSpells, en el caso de que la use 
        //un mago. En caso contrario no se le permitira.
        public void AddSpell(Spell spell)
        {
            if(this.Type.ToUpper() == "WIZARD")
            {
                this.BookOfSpells.Add(spell);
            }
            else
            {
                Console.WriteLine("You're not a wizard Harry");
            }
        }

        //En este metodo, se le permite a un mago poder usar de un Spell para defenderse o atacar.
        //En el caso de querer usar un Spell que no tiene, no se le permitira hacer nada.
        public int UseSpell(Spell spell)
        {
            if(this.BookOfSpells.Contains(spell))
            {
                Console.WriteLine(spell.SpellDescription);

                if (spell.SpellAttack > 0)
                {
                    return spell.SpellAttack;
                }
                else if (spell.SpellDefense > 0)
                {
                    return spell.SpellDefense;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("You do not know this spell.");
                return 0;
            }
        }            
        
        //En este metodo, se agrega a un totalPoder el daño que hace todos los elementos que estan guardados
        //en la lista de armamento que tiene el personaje. Retorna el daño total que produce todos sus items.
        public int Attack()
        {
            int totalPower = this.BasicAttack;

            foreach (Element element in this.Elements)
            {
                totalPower += element.Damage;
            }
            
            return totalPower;
        }

        //En este metodo, por parametro sabemos el valor de ataque que tendra el personaje. A ese valor 
        //le restamos el total de defensa que tiene en la lista de armamento. Esta resta cambiara la salud 
        //del personaje.
        public void ReceiveAttack(int damage)
        {
            int totalDefence = this.BasicDefense;
            foreach (Element element in this.Elements)
            {
                totalDefence += element.Defence;
            }
            int totalDamage = damage - totalDefence;
            this.Health -= totalDamage;
        }
    }
}
