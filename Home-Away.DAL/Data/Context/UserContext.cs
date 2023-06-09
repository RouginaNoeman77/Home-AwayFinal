﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;

namespace Home_Away.DAL;

public class UserContext : IdentityDbContext
{
    public DbSet<User> _users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);

        base.OnModelCreating(modelBuilder);


        SeedAdmins(modelBuilder);


        SeedProperty(modelBuilder);


        base.OnModelCreating(modelBuilder);
    
        modelBuilder.Entity<Images>()
            .HasAlternateKey(c => new { c.PropertyId, c.Id });


        modelBuilder.Entity<Questions>()
            .HasMany(ua => ua.UsersAnswer)
            .WithOne(q => q.Questions)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>()
           .HasMany(ua => ua.UsersAnswer)
           .WithOne(q => q.User)
           .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User_Answer>()
            .HasKey(ua => new { ua.UserId, ua.QuestionsId });

    }


    private void SeedUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            // Existing entries
            new User
            {
                Id = "fbef741d-ad99-46cd-9e35-4f606638b951",
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
                UserName = "johndoe",
                PasswordHash = "password123",
                Owner = 1,

                EntryDate = new DateTime(),

                //EntryDate = DateTime.Now,

                TotalMoneySpent = 1000.00m,
                ProfileImage = "path/to/profile-image.jpg",

            },
            new User
            {
                Id = "fbef741d-ad99-46cd-9e35-4f606638b952",
                FirstName = "Jane",
                LastName = "Smith",
                Gender = "Female",
                UserName = "janesmith",
                PasswordHash = "pass456",
                Owner = 0,

                EntryDate = new DateTime(),



                TotalMoneySpent = 1500.50m,
                ProfileImage = "path/to/profile-image.jpg",

            },
            new User
            {
                Id = "fbef741d-ad99-46cd-9e35-4f606638b954",
                FirstName = "Mike",
                LastName = "Johnson",
                Gender = "Male",
                UserName = "mikejohn",
                PasswordHash = "mysecretpass",
                Owner = 1,

                EntryDate = new DateTime(),



                TotalMoneySpent = 750.25m,
                ProfileImage = "path/to/profile-image.jpg",

            });
    }
 




    private void SeedAdmins(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>().HasData(
            new Admin()
            {
                Id = "fbef741d-ad99-46cd-9e35-4f606638b953",
                UserName = "admin1@example.com",
                Email = "admin1@example.com",
                FirstName = "Admin",
                LastName = "1",
                Gender = "Male",
                HiringDate = DateTime.UtcNow,
                DateOfBirth = new DateTime(1990, 1, 1)
                

            },

            new Admin
            {
                Id = "fbef741d-ad99-46cd-9e35-4f606638b955",
                UserName = "admin2@example.com",
                Email = "admin2@example.com",
                FirstName = "Admin",
                LastName = "2",
                Gender = "Female",
                HiringDate = DateTime.UtcNow,
                DateOfBirth = new DateTime(1995, 5, 5)
            },

            new Admin
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin3@example.com",
                Email = "admin3@example.com",
                FirstName = "Admin",
                LastName = "3",
                Gender = "Male",
                HiringDate = DateTime.UtcNow,
                DateOfBirth = new DateTime(1985, 10, 10)
            }

            );


    }

    private void SeedProperty(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Property>().HasData(

            new Property
            {
                Id = 1,
                Title = "Luxurious Villa",
                Description = "A stunning villa with breathtaking views",
                Address = "123 Main Street",
                Type = "Villa",
                Region = "Coastal",
                Area = "Beachside",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 20,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            },
            new Property
            {
                Id = 2,
                Title = "Fancy Apartment",
                Description = "A stunning Apartment with breathtaking views",
                Address = "123 Main Street",
                Type = "Apartment",
                Region = "Tropical",
                Area = "Beachfront",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 8,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            },
            new Property
            {
                Id = 3,
                Title = "Luxurious House",
                Description = "A stunning house with breathtaking views",
                Address = "123 Main Street",
                Type = "House",
                Region = "Island",
                Area = "Seaside",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 10,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            },
            new Property
            {
                Id = 4,
                Title = "A comfy camp",
                Description = "A camp with breathtaking views",
                Address = "123 Main Street",
                Type = "Camp",
                Region = "Mediterranean",
                Area = "Coastline",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 4,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            }, new Property
            {
                Id = 5,
                Title = "Luxurious house",
                Description = "A stunning house with breathtaking views",
                Address = "123 Main Street",
                Type = "House",
                Region = "Secluded",
                Area = "Remote Beach",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 15,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            },
            new Property
            {
                Id = 6,
                Title = "Luxurious House",
                Description = "A stunning house with breathtaking views",
                Address = "123 Main Street",
                Type = "House",
                Region = "Island",
                Area = "Seaside",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 20,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            },
            new Property
            {
                Id = 7,
                Title = "Luxurious House",
                Description = "A stunning house with breathtaking views",
                Address = "123 Main Street",
                Type = "House",
                Region = "Island",
                Area = "Seaside",
                Category = "Vacation Rental",
                PricePerNight = 500.00m,
                Capacity = 5,
                NumberOfRooms = 4,
                NumberOfBathrooms = 3,
                NumberOfFloors = 2,
                DateOfAddingProperty = DateTime.Now,
                State = "Pending",
                AverageRating = 4.5m,
                OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954", // Set the OwnerId to the desired user's ID
                AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953" // Set the AdminId to the desired admin's ID

            }
            );


    }
}