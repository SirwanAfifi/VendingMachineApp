namespace VendingMachineApp.Interfaces
{
    public interface IBeverage
    {
        int Id { get; }
        string Name { get; }
        float Price { get; }
    }
}