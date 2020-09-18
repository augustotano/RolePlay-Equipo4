using System;

namespace Library
{
    /*
        SINGLE RESPONSABILITY PRINCIPLE - SRP
        Se establece que cada clase debe tener responsabilidad sobre una parte de la funcionalidad
        proporcionada por el software. Los metodos y atributos de la clase deben estar 
        alineados con esa responsabillidad. 

        "Una clase debe tener solo una razon para cambiar"

        En el caso de querer cambiar como se representan los elementos del juego, la clase 
        Element es quien se debe modifiicar. Siendo esta la unica razon de cambio.
    */
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