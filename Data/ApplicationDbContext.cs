using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BoatRental.Models;
using System.Reflection.Emit;

namespace BoatRental.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed boat data
            builder.Entity<Boat>().HasData(
            new Boat
            {
                Id = 1,
                Description = "Bl� faran",
                PricePerDay = 300,
                IsAvailable = true,
                UserId = null, // Inte uthyrd
                Location = null, // L�mnas null vid seed
                PostalCode = null // L�mnas null vid seed
            },
            new Boat
            {
                Id = 2,
                Description = "R�da blixten",
                PricePerDay = 350,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            },
            new Boat
            {
                Id = 3,
                Description = "Crecent 415",
                PricePerDay = 350,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            },
            new Boat
            {
                Id = 4,
                Description = "Onda katten",
                PricePerDay = 400,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            },
            new Boat
            {
                Id = 5,
                Description = "Tandfen",
                PricePerDay = 250,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            });
        }
    }
}
