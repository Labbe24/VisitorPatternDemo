using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitables;

namespace VisitorPatternDemo2.Visitors
{
    public class GeneralReport : IVisitor
    {
        private int customersNo;
        private int ordersNo;
        private int itemsNo;

        public GeneralReport()
        {
            customersNo = 0;
            ordersNo = 0;
            itemsNo = 0;
        }
        public void visit(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine("- Name: {0}",customer.Name);
            customersNo++;
        }
        public void visit(Order order)
        {
            Console.WriteLine("-- Order: {0}", order.Name);
            ordersNo++;
        }
        public void visit(Item item)
        {
            Console.WriteLine("--- Item: {0}", item.Name);
            itemsNo++;
        }

        public void displayResults()
        {
            Console.WriteLine();
            Console.WriteLine("Number of customers: {0}", customersNo);
            Console.WriteLine("Number of orders: {0}", ordersNo);
            Console.WriteLine("Number of items: {0}", itemsNo);
        }
    }
}
