using System.Collections.Generic;
using VendingMachineApp.Entites;
using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Tests
{
    public class VendingMachinTestHelper
    {
        public static VendingMachine VendingMachine()
        {
            var machine = new VendingMachine("Test", "Iran",
                new List<IRecipe>
            {
                new HotChocolate(),
                new WhiteCoffeeWithOneSugar(),
                new LemonTea(),
                new IcedCoffee()
            });
            return machine;
        }
    }
}