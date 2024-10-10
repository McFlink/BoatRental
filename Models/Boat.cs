using BoatRental.Data;

namespace BoatRental.Models
{
    public class Boat
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required decimal PricePerDay { get; set; }
        public required string Location { get; set; } // Coordinates
        public required string PostalCode { get; set; }
        public int? LockCombination { get; set; }
        public int UserId { get; set; }
        public bool IsAvailable { get; set; } = true;

        // Navigation
        public ApplicationUser? CurrentRenter { get; set; }
    }
}
