using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class LemonTea : IRecipe
    {
        public void Prepare()
        {
            throw new System.NotImplementedException();
        }
        public string Name { get; set; } = "Lemon Tea";
        public float Price { get; set; }
        public override string ToString()
        {
            return "Lemon Tea";
        }
    }
}