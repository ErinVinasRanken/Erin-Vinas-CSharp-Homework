using System;

namespace Homework12_03
{
    public class Game
    {
        private readonly string _name;
        private readonly string _publisher;
        private readonly decimal _price;

        public Game(string name, string publisher, decimal price)
        {
            _name = name;
            _publisher = publisher;
            _price = price;
        }

        public string GetName() => _name;
        public string GetPublisher() => _publisher;
        public decimal GetPrice() => _price;
    }
}
