using BoatRental.Models;

namespace BoatRental.Interface
{
    public interface IBoatService
    {
        Task<List<Boat>> GetBoatsAsync();
    }
}
