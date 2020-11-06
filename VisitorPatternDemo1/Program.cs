using System;
using VisitorPatternDemo1.Visitables;
using VisitorPatternDemo1.Visitors;

namespace VisitorPatternDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Membership bronze = new BronzeMembership();
            Membership silver = new SilverMembership();
            Membership gold = new GoldMembership();

            IVisitor visitor = new Thriller();
            bronze.accept(visitor);

            silver.accept(visitor);

            gold.accept(visitor);

            Console.WriteLine("Monthly payment: {0}", bronze.Monthlypaymeny);
            Console.WriteLine("Monthly payment: {0}", silver.Monthlypaymeny);
            Console.WriteLine("Monthly payment: {0}", gold.Monthlypaymeny);
        }
    }
}
