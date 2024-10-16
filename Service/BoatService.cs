using BoatRental.Data;
using BoatRental.Interface;
using BoatRental.Models;
using Microsoft.EntityFrameworkCore;

namespace BoatRental.Service
{
    public class BoatService : IBoatService
    {
        private readonly ApplicationDbContext context;

        public BoatService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Boat>> GetBoatsAsync()
        {
            return await context.Boats.ToListAsync();
        }

        public async Task<Boat> GetBoatById(int id)
        {
            return await context.Boats.SingleOrDefaultAsync(b => b.Id == id);
        }
    }
}
