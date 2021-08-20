using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Pakistan", ShortName = "PK"},
                new Country { Id = 2, Name = "Iran", ShortName = "IR" },
                new Country { Id = 3, Name = "Afghanistan", ShortName = "AFG" }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, CountryId = 1, Name = "HotelPak", Rating = 5 },
                new Hotel { Id = 2, CountryId = 1, Name = "HotelPak2", Rating = 5 },
                new Hotel { Id = 3, CountryId = 2, Name = "HotelIR", Rating = 5 },
                new Hotel { Id = 4, CountryId = 3, Name = "HotelAFG", Rating = 5 }
                );
        }
    }
}
