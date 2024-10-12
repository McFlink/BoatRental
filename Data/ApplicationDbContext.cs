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
                Name = "Bl� faran",
                Description = "En klassisk Sm�gen 45:a som �r 4,5 meter och riktigt stabil!",
                PricePerDay = 300,
                IsAvailable = true,
                UserId = null, // Inte uthyrd
                Location = null, // L�mnas null vid seed
                PostalCode = null // L�mnas null vid seed
            },
            new Boat
            {
                Id = 2,
                Name = "R�da Blixten",
                Description = "En Ockelbo p� 4,2 meter, perfekt f�r 2 personer",
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
                Description = "Crecent 415 �r som namnet antyder 4,15m l�ng och en av det mest popul�ra b�tarna att fiska i. L�tt och stabil.",
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
                Description = "Denna p�rla �r v�r minsta modell i nul�get, som str�cker 3,7m och passar en till tv� personer.",
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
                Description = "Fin och l�tt som en tandfe, den h�r b�ten ligger p� 3,9 meter men �r extremt stabil f�r sin l�ngd",
                PricePerDay = 250,
                IsAvailable = true,
                UserId = null,
                Location = null,
                PostalCode = null
            });
        }
    }
}
