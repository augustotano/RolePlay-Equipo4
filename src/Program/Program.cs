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

            Character Arthur = new Character("Arthur","King", 30, 20);
            Element Sword = new Element("Magic Sword", 40, 60);
            Element Shield = new Element("The Protector", 60, 15);
            Arthur.AttachObject(Sword);
            Arthur.AttachObject(Shield);

            Character Loki = new Character("Loki","Assassin", 50, 0);
            Element Dagger = new Element("Night's Fall", 0, 80);
            Element Cloak = new Element("Faceless' Cloak", 30, 0);
            Loki.AttachObject(Dagger);
            Loki.AttachObject(Cloak);

            Character Thorin = new Character("Thorin","Dwarf",47,20);
            Element Axe = new Element("The Executioner",10,80);
            Element Hammer = new Element("Mjölnir",5,85);
            Thorin.AttachObject(Axe);
            Thorin.AttachObject(Hammer);
        }
    }
}