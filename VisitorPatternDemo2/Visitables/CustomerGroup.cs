using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public class CustomerGroup : IVisitable
    {
        public CustomerGroup()
        {
            customers = new List<Customer>();
        }

        private List<Customer> customers;

        public void accept(IVisitor visitor)
        {
            foreach(var customer in customers)
            {
                customer.accept(visitor);
            }
        }

        public void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
