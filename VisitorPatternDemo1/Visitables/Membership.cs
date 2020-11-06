using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo1.Visitors;

namespace VisitorPatternDemo1.Visitables
{
    public abstract class Membership
    {
        private UInt16 monthlypayment;
        public UInt16 Monthlypaymeny
        {
            get { return monthlypayment; }
            set { monthlypayment = value; }
        }
        public abstract void accept(IVisitor visitor);
    }
}
