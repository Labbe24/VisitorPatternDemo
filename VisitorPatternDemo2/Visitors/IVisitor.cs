using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitables;

namespace VisitorPatternDemo2.Visitors
{
    public interface IVisitor
    {
        void visit(Customer customer);
        void visit(Order order);
        void visit(Item item);
    }
}
