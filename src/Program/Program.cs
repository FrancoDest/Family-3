using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deje que el arbol familiar sea con 1 padre solo para cada hijo, ya que no queria modificar mas de lo necesario la clase Node
            Node n1 = new Node("Maria",70);
            Node n2 = new Node("Mario",40);
            Node n3 = new Node("Mariana",38);
            Node n4 = new Node("Mariano",31);
            Node n5 = new Node("Mario Jr",20);
            Node n6 = new Node ("Mariano Jr",19);
            Node n7 = new Node("Mariana Jr",10);
            Node n8 = new Node("Mario Jr Jr",1);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n7.AddChildren(n8);

            VisitorAgeCalculator Sumadeedades = new VisitorAgeCalculator();
            n1.AcceptVisitor(Sumadeedades);
            Printer.print(Sumadeedades);

            VisitorOlderchild Hijomayor = new VisitorOlderchild();
            n1.AcceptVisitor(Hijomayor);
            Printer.print(Hijomayor);

            VisitorLongerName Nombremaslargo = new VisitorLongerName();
            n1.AcceptVisitor(Nombremaslargo);
            Printer.print(Nombremaslargo);
        }
    }
}
