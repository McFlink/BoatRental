using BoatRental.Data;

namespace BoatRental.Models
{
    public class Boat
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal PricePerDay { get; set; }
        public string? Location { get; set; } // Coordinates
        public string? PostalCode { get; set; }
        public int? LockCombination { get; set; }
        public int? UserId { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? ImageName { get; set; }

        // Navigation
        public ApplicationUser? CurrentRenter { get; set; }
    }
}
