using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : IVisitable
    {
        private List<Node> children = new List<Node>();
        public Person Person;

        public ReadOnlyCollection<Node> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int age)
        {
            this.Person = new Person(name,age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);

        }
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
