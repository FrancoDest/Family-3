using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perdon por la originalidad en los nombres, si tengo hijos espero que mi pareja tenga buena creatividad (chiste para romper el hielo)
            Node n1 = new Node("Raul",70);
            Node n2 = new Node("Raula",40);
            Node n3 = new Node("Rauliño",38);
            Node n4 = new Node("Rauliña",31);
            Node n5 = new Node("Raula Jr",20);
            Node n6 = new Node ("Rauliño Jr",19);
            Node n7 = new Node("Rauliña Jr",10);
            Node n8 = new Node("Rauliña Jr Jr",1);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n7.AddChildren(n8);

            VisitorAgeCalculator sumadeedades = new VisitorAgeCalculator();
            n1.AcceptVisitor(sumadeedades);
            Printer.print(sumadeedades);

            VisitorOlderchild Hijomayor = new VisitorOlderchild();
            n1.AcceptVisitor(Hijomayor);
            Printer.print(Hijomayor);

            VisitorLongerName Nombremaslargo = new VisitorLongerName();
            n1.AcceptVisitor(Nombremaslargo);
            Printer.print(Nombremaslargo);
        }
    }
}
