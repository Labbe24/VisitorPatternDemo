using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo1.Visitables;

namespace VisitorPatternDemo1.Visitors
{
    public class Comedy : IVisitor
    {
        public void visit(BronzeMembership bronzeMembership)
        {
            bronzeMembership.Monthlypaymeny += 40;
        }
        public void visit(SilverMembership silverMembership)
        {
            silverMembership.Monthlypaymeny += 30;
        }
        public void visit(GoldMembership goldMembership)
        {
            goldMembership.Monthlypaymeny += 20;
        }
    }
}
