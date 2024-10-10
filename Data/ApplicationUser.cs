using BoatRental.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BoatRental.Data
{
    public class ApplicationUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        [Required]
        public override string? PhoneNumber { get; set; } // Required annotation but nullable string because has to follow base implementation of Identity's PhoneNumber column which is nullable. This will make the PhoneNumber field to be required.
        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>(); // Virtual makes EF use lazy loading, e. g only loading when their acutally needed.
    }
}
