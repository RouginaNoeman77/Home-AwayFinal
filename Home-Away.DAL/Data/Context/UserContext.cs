using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Home_Away.DAL;

public class UserContext : IdentityDbContext
{
    public DbSet<User> _users;
    public DbSet<Admin> _admins;
    public UserContext(DbContextOptions<UserContext> options):base(options)
    {
         
    }

    //so as to make 2 primarykeys
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Images>()
            .HasAlternateKey(c => new { c.PropertyId, c.Id});

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
            new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
             
                Owner = 1,
                EntryDate = DateTime.Now,
                TotalMoneySpent = 1000.00m,
                ProfileImage = "path/to/profile-image.jpg",
                AcountState = 1
            },
            new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Jane",
                LastName = "Smith",
                Gender = "Female",
                
                Owner = 0,
                EntryDate = DateTime.Now,
                TotalMoneySpent = 1500.50m,
                ProfileImage = "path/to/profile-image.jpg",
                AcountState = 1
            },
            new User
            {   Id = Guid.NewGuid().ToString(),
                FirstName = "Mike",
                LastName = "Johnson",
                Gender = "Male",
               
                Owner = 1,
                EntryDate = DateTime.Now,
                TotalMoneySpent = 750.25m,
                ProfileImage = "path/to/profile-image.jpg",
                AcountState = 0
            }
        );
    }

}
