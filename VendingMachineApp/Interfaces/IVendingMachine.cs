using System.Collections.Generic;
using VendingMachineApp.Entites;

namespace VendingMachineApp.Interfaces
{
    public interface IVendingMachine
    {
        List<Beverage> DisplayBeverages();
        Beverage SelectAnItem(int beverageId);
        bool InsertCoin(float amount);
        string Buy();
    }
}