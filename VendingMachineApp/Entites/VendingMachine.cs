using System.Collections.Generic;
using System.Linq;
using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class VendingMachine : IVendingMachine
    {
        private readonly string _model;
        private readonly string _manufacturer;
        private readonly List<IRecipe> _recipes;

        private IRecipe _selectedRecipe;
        private bool _allowed;

        public VendingMachine(string model, string manufacturer, 
            List<IRecipe> beverages)
        {
            _model = model;
            _manufacturer = manufacturer;
            _recipes = beverages;
        }

        // Display Items on Screen
        public List<IRecipe> DisplayBeverages()
        {
            return _recipes.ToList();
        } 

        public IRecipe SelectAnItem(int item)
        {
            _selectedRecipe = RecipeFactory.GetRecipe(item);
            return _selectedRecipe;
        }

        public bool InsertCoin(float amount)
        {
            if (amount < _selectedRecipe.Price)
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