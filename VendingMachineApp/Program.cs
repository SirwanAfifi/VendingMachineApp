using System;
using System.Collections.Generic;
using VendingMachineApp.Entites;

namespace VendingMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new VendingMachine("Test", "Iran", 
                new List<Beverage>
            {
                new Beverage(1, "Hot Chocolate", 500),
                new Beverage(2, "White Coffee with 1 sugar", 1000),
                new Beverage(3, "Lemon Tea", 5100),
                new Beverage(4, "Iced Coffee", 800)
            });

            var list = machine.DisplayBeverages();
            machine.SelectAnItem(2);
            var result = machine.InsertCoin(200);

            Console.ReadLine();
        }
    }
}
