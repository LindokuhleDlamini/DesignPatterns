using System;

namespace DesignPatterns.CommandPattern
{
    public class Stock
    {
        protected string _name;

        protected int _quantity;

        public Stock(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine("Stock "+_name+" quantity of "+_quantity+ " Bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock " + _name + " quantity of " + _quantity + " Sold");
        }

    }
}
