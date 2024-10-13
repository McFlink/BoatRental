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
                Name = "Blå faran",
                Description = "En klassisk Smögen 45:a som är 4,5 meter och riktigt stabil!",
                PricePerDay = 300,
                IsAvailable = true,
                UserId = null, // Inte uthyrd
                Location = null, // Lämnas null vid seed
                PostalCode = null // Lämnas null vid seed
            },
            new Boat
            {
                Id = 2,
                Name = "Röda Blixten",
                Description = "En Ockelbo på 4,2 meter, perfekt för 2 personer",
                PricePerDay = 350,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            },
            new Boat
            {
                Id = 3,
                Name = "Crecent 415",
                Description = "Crecent 415 är som namnet antyder 4,15m lång och en av det mest populära båtarna att fiska i. Lätt och stabil.",
                PricePerDay = 350,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            },
            new Boat
            {
                Id = 4,
                Name = "Onda katten",
                Description = "Denna pärla är vår minsta modell i nuläget, som sträcker 3,7m och passar en till två personer.",
                PricePerDay = 400,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            },
            new Boat
            {
                Id = 5,
                Name = "Tandfen",
                Description = "Fin och lätt som en tandfe, den här båten ligger på 3,9 meter men är extremt stabil för sin längd",
                PricePerDay = 250,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            });
        }
    }
}
