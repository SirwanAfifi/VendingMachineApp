namespace VendingMachineApp.Interfaces
{
    public interface IRecipe
    {
        /// <summary>
        /// Each concrete class has its own implementation for preparing the beverage
        /// </summary>
        void Prepare();
        string Name { get; set; }
        float Price { get; set; } 
    }
}