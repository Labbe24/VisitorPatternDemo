using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public class Item : IVisitable
    {
        public Item(string name)
        {
            this.name = name;
        }

        private string name;
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
