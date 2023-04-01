namespace MiniProjectInheritance.Interfaces
{ 
    public interface IRentalable : IInventoryItem
    {
        void Rent();
        void ReturnRental();

    }
}