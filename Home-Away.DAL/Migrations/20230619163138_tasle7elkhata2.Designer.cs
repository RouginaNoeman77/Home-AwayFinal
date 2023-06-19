﻿// <auto-generated />
using System;
using Home_Away.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230619163138_tasle7elkhata2")]
    partial class tasle7elkhata2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Home_Away.DAL.Choices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionsId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionsId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("Home_Away.DAL.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("PropertyId", "Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Home_Away.DAL.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AverageRating")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfAddingProperty")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBathrooms")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfFloors")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Property");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main Street",
                            AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953",
                            Area = "Beachside",
                            AverageRating = 4.5m,
                            Capacity = 8,
                            Category = "Vacation Rental",
                            DateOfAddingProperty = new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4004),
                            Description = "A stunning villa with breathtaking views",
                            NumberOfBathrooms = 3,
                            NumberOfFloors = 2,
                            NumberOfRooms = 4,
                            OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954",
                            PricePerNight = 500.00m,
                            Region = "Coastal",
                            State = "Pending",
                            Title = "Luxurious Villa",
                            Type = "Villa"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 Main Street",
                            AdminId = "e6f12e7d-f393-4990-a6f6-ae8ffc1f4f12",
                            Area = "Beachside",
                            AverageRating = 4.5m,
                            Capacity = 8,
                            Category = "Vacation Rental",
                            DateOfAddingProperty = new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4021),
                            Description = "A stunning Apartment with breathtaking views",
                            NumberOfBathrooms = 3,
                            NumberOfFloors = 2,
                            NumberOfRooms = 4,
                            OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b954",
                            PricePerNight = 500.00m,
                            Region = "Coastal",
                            State = "Pending",
                            Title = "Luxurious Apartment",
                            Type = "Apartment"
                        },
                        new
                        {
                            Id = 3,
                            Address = "123 Main Street",
                            AdminId = "7c35a0d9-5f65-4274-ad98-9741489bd6e8",
                            Area = "DessertSide",
                            AverageRating = 4.5m,
                            Capacity = 8,
                            Category = "Vacation Rental",
                            DateOfAddingProperty = new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4032),
                            Description = "A stunning Camp with breathtaking views",
                            NumberOfBathrooms = 3,
                            NumberOfFloors = 2,
                            NumberOfRooms = 4,
                            OwnerId = "489ce88b-026c-4b20-9c8b-8dd897b3707a",
                            PricePerNight = 500.00m,
                            Region = "Coastal",
                            State = "Pending",
                            Title = "Amazing Camp",
                            Type = "Camp"
                        },
                        new
                        {
                            Id = 4,
                            Address = "123 Main Street",
                            AdminId = "fbef741d-ad99-46cd-9e35-4f606638b953",
                            Area = "Beachside",
                            AverageRating = 4.5m,
                            Capacity = 8,
                            Category = "Vacation Rental",
                            DateOfAddingProperty = new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4042),
                            Description = "A stunning House with breathtaking views",
                            NumberOfBathrooms = 3,
                            NumberOfFloors = 2,
                            NumberOfRooms = 4,
                            OwnerId = "fbef741d-ad99-46cd-9e35-4f606638b951",
                            PricePerNight = 500.00m,
                            Region = "Coastal",
                            State = "Pending",
                            Title = "Luxurious House",
                            Type = "House"
                        });
                });

            modelBuilder.Entity("Home_Away.DAL.Questions", b =>
                {
                    b.Property<int>("QuestionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionsId"));

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionsId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Home_Away.DAL.Reservations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("date");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("date");

                    b.Property<string>("ReservationState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateFromAdmin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateFromOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Home_Away.DAL.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("date");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Home_Away.DAL.User_Answer", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("QuestionsId")
                        .HasColumnType("int");

                    b.Property<string>("UserAnswers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "QuestionsId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("User_Answer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Home_Away.DAL.Admin", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("DateOfBirth")
                                .HasColumnName("Admin_DateOfBirth");

                            t.Property("FirstName")
                                .HasColumnName("Admin_FirstName");

                            t.Property("Gender")
                                .HasColumnName("Admin_Gender");

                            t.Property("LastName")
                                .HasColumnName("Admin_LastName");
                        });

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Home_Away.DAL.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("AcountState")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Owner")
                        .HasColumnType("int");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalMoneySpent")
                        .HasColumnType("decimal(10,2)");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("Home_Away.DAL.Choices", b =>
                {
                    b.HasOne("Home_Away.DAL.Questions", "Questions")
                        .WithMany("choices")
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Home_Away.DAL.Images", b =>
                {
                    b.HasOne("Home_Away.DAL.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Home_Away.DAL.Property", b =>
                {
                    b.HasOne("Home_Away.DAL.Admin", "Admin")
                        .WithMany("ApprovedProperties")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Home_Away.DAL.User", "Owner")
                        .WithMany("OwnedProperties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Home_Away.DAL.Reservations", b =>
                {
                    b.HasOne("Home_Away.DAL.Admin", "Admin")
                        .WithMany("ApprovedReservations")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Home_Away.DAL.Property", "Property")
                        .WithMany("Reservations")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Home_Away.DAL.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");

                    b.Navigation("Admin");

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Home_Away.DAL.Reviews", b =>
                {
                    b.HasOne("Home_Away.DAL.Admin", "Admin")
                        .WithMany("ApprovedReviews")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Home_Away.DAL.Property", "Property")
                        .WithMany("Reviews")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Home_Away.DAL.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId");

                    b.Navigation("Admin");

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Home_Away.DAL.User_Answer", b =>
                {
                    b.HasOne("Home_Away.DAL.Questions", "Questions")
                        .WithMany("UsersAnswer")
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Home_Away.DAL.User", "User")
                        .WithMany("UsersAnswer")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Questions");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Home_Away.DAL.Property", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Home_Away.DAL.Questions", b =>
                {
                    b.Navigation("UsersAnswer");

                    b.Navigation("choices");
                });

            modelBuilder.Entity("Home_Away.DAL.Admin", b =>
                {
                    b.Navigation("ApprovedProperties");

                    b.Navigation("ApprovedReservations");

                    b.Navigation("ApprovedReviews");
                });

            modelBuilder.Entity("Home_Away.DAL.User", b =>
                {
                    b.Navigation("OwnedProperties");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");

                    b.Navigation("UsersAnswer");
                });
#pragma warning restore 612, 618
        }
    }
}
