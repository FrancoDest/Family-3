using System;
namespace Library
{
    public class Printer
    {
        //Cree la clase printer para no agregarle responsabilidades extras a los Visitor, intentando de que quede lo mas sencillo posible
        public static void print(VisitorAgeCalculator visitor)
        {
            Console.WriteLine($"La edad sumada de todos los miembros de la familia es {visitor.Totalresult}");
        }
        public static void print(VisitorOlderchild visitor)
        {
            Console.WriteLine($"El/La hij@ mayor es {visitor.OlderSonName} y tiene {visitor.OlderSonAge} años");
        }
        public static void print(VisitorLongerName visitor)
        {
            Console.WriteLine($"La persona con el nombre mas largo es {visitor.Longername} y su nombre tiene {visitor.Longernamelength} caracteres");
        }
    }
}