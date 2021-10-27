namespace Library
{
    public class VisitorLongerName: IVisitor
    {
        public int Longernamelength=0;
        public string Longername;

        public void Visit(Node node)
        {
            if (Longernamelength<(node.Person.Name).Length)
            {
                Longernamelength=(node.Person.Name).Length;
                Longername=node.Person.Name;
            }
            foreach(Node child in node.Children)
            {
                child.AcceptVisitor(this);
            }
        }
    }
}