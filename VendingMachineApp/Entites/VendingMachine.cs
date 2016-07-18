using System.Collections.Generic;
using System.Linq;
using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class VendingMachine : IVendingMachine
    {
        private readonly string _model;
        private readonly string _manufacturer;
        private readonly List<Beverage> _beverages;

        private Beverage _selectedBeverage;
        private bool _allowed;

        public VendingMachine(string model, string manufacturer, 
            List<Beverage> beverages)
        {
            _model = model;
            _manufacturer = manufacturer;
            _beverages = beverages;
        }

        // Display Items on Screen
        public List<Beverage> DisplayBeverages()
        {
            return _beverages.ToList();
        } 

        public Beverage SelectAnItem(int beverageId)
        {
           _selectedBeverage = _beverages.FirstOrDefault(p => p.Id == beverageId);
            return _selectedBeverage;
        }

        public bool InsertCoin(float amount)
        {
            if (amount < _selectedBeverage.Price)
            {
                return false;
            }
            _allowed = true;
            return _allowed;
        }

        public string Buy()
        {
            return _allowed ? "Finished" : "Select a beverage";
        }
    }
}