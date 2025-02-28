// See https://aka.ms/new-console-template for more information

using System;
using DecoratorPatterN;

namespace Decorator_Pattern_BSE23059
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} -> ${coffee.GetCost()}");

            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} -> ${coffee.GetCost()}");

            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} -> ${coffee.GetCost()}");
        }
    }
}
