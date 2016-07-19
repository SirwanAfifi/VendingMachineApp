using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class WhiteCoffeeWithOneSugar : IRecipe
    {
        public void Prepare()
        {
            throw new System.NotImplementedException();
        }
        public string Name { get; set; } = "White Coffee with 1 sugar";
        public float Price { get; set; } = 2000;
        public override string ToString()
        {
            return "White Coffee with 1 sugar";
        }
    }
}