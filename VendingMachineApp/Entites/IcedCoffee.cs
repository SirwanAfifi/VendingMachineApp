using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class IcedCoffee : IRecipe
    {
        public void Prepare()
        {
            throw new System.NotImplementedException();
        }
        public string Name { get; set; } = "Iced Coffee";
        public float Price { get; set; }
        public override string ToString()
        {
            return "Iced Coffee";
        }
    }
}