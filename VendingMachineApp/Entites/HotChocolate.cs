using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class HotChocolate : IRecipe
    {
        public void Prepare()
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; set; } = "Hot Chocolate";

        public float Price { get; set; } = 5000;

        public override string ToString()
        {
            return "Hot Chocolate";
        }
    }
}