using System;
using VisitorPatternDemo2.Visitables;
using VisitorPatternDemo2.Visitors;

//https://www.oodesign.com/visitor-pattern.html

namespace VisitorPatternDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Bruce Wayne");
            Customer customer2 = new Customer("Peter Parker");
            Customer customer3 = new Customer("Iron Man");

            customer1.addOrder(new Order("Batmobile", "Wheels"));

            Order order1 = new Order("Weapons");
            order1.addItem(new Item("Batarang"));
            order1.addItem(new Item("Pocket Explosive"));
            order1.addItem(new Item("Tazer"));
            customer1.addOrder(order1);

            Order order2 = new Order("Equipment");
            order2.addItem(new Item("Web Shooter"));
            order2.addItem(new Item("Costume"));
            customer2.addOrder(order2);
            
            Order order3 = new Order("Armored suit");
            order3.addItem(new Item("Omnibeam"));
            order3.addItem(new Item("Pentabeam"));
            order3.addItem(new Item("Sensor Array"));
            customer3.addOrder(order3);

            CustomerGroup cg = new CustomerGroup();
            cg.addCustomer(customer1);
            cg.addCustomer(customer2);
            cg.addCustomer(customer3);

            GeneralReport visitor = new GeneralReport();
            cg.accept(visitor);
            visitor.displayResults();
        }
    }
}
