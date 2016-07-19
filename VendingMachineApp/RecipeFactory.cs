using VendingMachineApp.Entites;
using VendingMachineApp.Interfaces;

namespace VendingMachineApp
{
    public class RecipeFactory
    {
        public static IRecipe GetRecipe(int item)
        {
            switch (item)
            {
                case 1:
                    return new HotChocolate();
                case 2:
                    return new WhiteCoffeeWithOneSugar();
                case 3:
                    return new LemonTea();
                case 4:
                    return new IcedCoffee();
                default:
                    return new HotChocolate();
            }
        }
    }
}