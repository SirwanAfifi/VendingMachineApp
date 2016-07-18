using VendingMachineApp.Interfaces;

namespace VendingMachineApp.Entites
{
    public class Beverage : IBeverage
    {
        public int Id { get; }
        public string Name { get; }
        public float Price { get; }

        public Beverage(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}