using Entities.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "NG"
                },
                new Country
                {
                    Id = 2,
                    Name = "Philippines",
                    ShortName = "PH"
                },
                new Country
                {
                    Id = 3,
                    Name = "Japan",
                    ShortName = "JPN"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel 1",
                    Address = "Address 1",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel 2",
                    Address = "Address 2",
                    CountryId = 2,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel 3",
                    Address = "Address 3",
                    CountryId = 3,
                    Rating = 3.5
                }
            );
        }
    }
}
