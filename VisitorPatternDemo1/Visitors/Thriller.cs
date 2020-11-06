using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo1.Visitables;

namespace VisitorPatternDemo1.Visitors
{
    public class Thriller : IVisitor
    {
        public void visit(BronzeMembership bronzeMembership)
        {
            bronzeMembership.Monthlypaymeny += 50;
        }
        public void visit(SilverMembership silverMembership)
        {
            silverMembership.Monthlypaymeny += 40;
        }
        public void visit(GoldMembership goldMembership)
        {
            goldMembership.Monthlypaymeny += 30;
        }
    }
}
