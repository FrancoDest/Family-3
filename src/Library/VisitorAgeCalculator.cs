namespace Library
{
    public class VisitorAgeCalculator: IVisitor
    {
        public int Totalresult = 0;

        public void Visit(Node node)
        {
            this.Totalresult+=node.Person.Age;
            foreach(Node child in node.Children)
            {
                child.AcceptVisitor(this);
            }
        }
    }
}