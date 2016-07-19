using System.Collections.Generic;
using VendingMachineApp.Entites;

namespace VendingMachineApp.Interfaces
{
    public interface IVendingMachine
    {
        List<IRecipe> DisplayBeverages();
        IRecipe SelectAnItem(int item);
        bool InsertCoin(float amount);
        string Buy();
    }
}