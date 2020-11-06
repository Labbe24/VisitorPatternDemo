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
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
