using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public class Order : IVisitable
    {
        public Order(string name)
        {
            this.name = name;
            items = new List<Item>();
        }

        public Order(string name, string itemName)
        {
            this.name = name;
            items = new List<Item>();
            items.Add(new Item(itemName));
        }
        private string name;
        private List<Item> items;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
            foreach (var item in items)
            {
                item.accept(visitor);
            }
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }

    }
}
