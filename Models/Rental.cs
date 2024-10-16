using BoatRental.Data;

namespace BoatRental.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime RentalStartTime { get; set; }
        public DateTime RentalEndTime { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime? CancellationTime { get; set; }
        public string UserId { get; set; }
        public int BoatId { get; set; }

        // Navigation
        public ApplicationUser User { get; set; }
        public Boat Boat { get; set; }
    }
}
