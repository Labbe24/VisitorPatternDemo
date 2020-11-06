using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public class CustomerGroup
    {
        public CustomerGroup()
        {
            customers = new List<Customer>();
        }

        private List<Customer> customers;

        public void accept(IVisitor visitor)
        {
            
        }

        public void addCustomer(Customer customer)
        {

        }
    }
}
