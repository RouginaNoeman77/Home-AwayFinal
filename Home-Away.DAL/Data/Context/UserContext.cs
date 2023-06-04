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
        base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<User_Answer>()
        //    .HasAlternateKey(c => new { c.QuestionsId, c.UserId });

        //modelBuilder.Entity<User>()
        //     .HasMany(u => u.OwnedProperties)
        //     .WithOne(p => p.Owner)
        //     .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<Admin>()
        //    .HasMany(u => u.ApprovedProperties)
        //    .WithOne(p => p.Admin)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(u => u.Choices)
        //    .WithMany()
        //    .HasForeignKey(u => u.ChoicesId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(u => u.Questions)
        //    .WithOne()
        //    .HasForeignKey(u => u.QuestionsId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<Choices>()
        //    .HasOne(p => p.Questions)
        //    .WithMany(p=>p.)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<Images>()
        //   .HasOne(p => p.Property)
        //   .WithMany(i => i.Images)
        //   .HasForeignKey(p => p.PropertyId);

        modelBuilder.Entity<Images>()
            .HasAlternateKey(c => new { c.PropertyId, c.Id});

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(ua => ua.Questions)
        //    .WithMany(q => q.UsersAnswer)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(ua => ua.User)
        //    .WithMany(q => q.UsersAnswer)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(ua => ua.)
        //    .WithMany(q => q.UsersAnswer)
        //    .OnDelete(DeleteBehavior.Restrict);

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

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(ua => ua.User)
        //    .WithMany(c => c.UsersAnswer)
        //    .HasForeignKey(ua => ua.UserId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<User_Answer>()
        //    .HasOne(ua => ua.Questions)
        //    .WithMany(q => q.UsersAnswer)
        //    .HasForeignKey(ua => ua.QuestionsId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //Trial in the discriminator----------
        //modelBuilder.Entity<User>()
        //   .HasDiscriminator<string>("EntityType")
        //   .HasValue<User>("User")
        //   .HasValue<Admin>("Admin");

        //-----------





    }



}
