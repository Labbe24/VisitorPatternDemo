using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo1.Visitables;

namespace VisitorPatternDemo1.Visitors
{
    public interface IVisitor
    {
        void visit(BronzeMembership bronzeMembership);
        void visit(SilverMembership silverMembership);
        void visit(GoldMembership goldMembership);
    }
}
