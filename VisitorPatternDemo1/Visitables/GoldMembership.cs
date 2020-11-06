using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo1.Visitors;

namespace VisitorPatternDemo1.Visitables
{
    public class GoldMembership : Membership
    {
        public override void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
