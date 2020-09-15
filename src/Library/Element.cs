using System;

namespace Library
{
    public class Element
    {
        public string Name {set; get;}
        public int Defence {set; get;}
        public int Damage {set; get;}
        
        public Element(string name, int defence, int damage)
        {
            this.Name = name;
            this.Defence = defence;
            this.Damage = damage;
        }
    }
}