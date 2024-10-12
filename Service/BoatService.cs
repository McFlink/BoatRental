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
            var boats = await context.Boats.ToListAsync();
            return boats;
        }
    }
}
