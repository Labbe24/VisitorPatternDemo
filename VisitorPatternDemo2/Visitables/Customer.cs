using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public class Customer
    {
        private string name;
        private List<Order> orders;

        public void accept(IVisitor visitor)
        {

        }
    }
}
