using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Gandalf = new Character ("Gandalf", "Wizard", 40, 15);
            Spell Freeze = new Spell ("Freeze", 30, 0, "Congela al contrario y este pierde fuerza");
            Element MagicScepter = new Element ("Magic Scepter", 0, 40);
            Gandalf.AddSpell(Freeze);
            Gandalf.AttachObject(MagicScepter);

            Character Arthur = new Character("Arthur","King",30,20);
            Element Sword = new Element("Magic Sword",60,40);
            Element Shield = new Element("The Protector",50,60);
            Arthur.AttachObject(Sword);
            Arthur.AttachObject(Shield);
        }
    }
}
