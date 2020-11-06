using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public class Customer : IVisitable
    {
        public Customer(string name)
        {
            this.name = name;
            orders = new List<Order>();
        }

        private string name;
        private List<Order> orders;

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
            foreach (var order in orders)
            {
                order.accept(visitor);
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void addOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
