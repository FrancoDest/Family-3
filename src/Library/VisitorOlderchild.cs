namespace Library
{
    public class VisitorOlderchild: IVisitor
    {   
        public int OlderSonAge=0;
        public string OlderSonName;
        public void Visit(Node node)
        {
            foreach(Node child in node.Children)
            {
                if (OlderSonAge<child.Person.Age)
                {
                    OlderSonAge=child.Person.Age;
                    OlderSonName=child.Person.Name;
                }
            }
        }
    }
}