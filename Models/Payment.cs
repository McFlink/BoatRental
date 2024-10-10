using BoatRental.Data;

namespace BoatRental.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public required DateTime PaymentDate { get; set; }
        public bool IsPaid { get; set; }
        public bool IsRefunded { get; set; }
        public int UserId { get; set; }
        public int RentalId { get; set; }

        // Navigation
        public ApplicationUser User { get; set; } = null!;
        public Rental Rental { get; set; } = null!;
    }
}
