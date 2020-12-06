﻿// <auto-generated />
using System;
using AutoStonks.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoStonks.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AutoStonks.API.Models.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CarProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Displacement")
                        .HasColumnType("int");

                    b.Property<int>("DriveType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FirstRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fuel")
                        .HasColumnType("int");

                    b.Property<int>("GenerationId")
                        .HasColumnType("int");

                    b.Property<bool>("HasBeenCrashed")
                        .HasColumnType("bit");

                    b.Property<int>("Horsepower")
                        .HasColumnType("int");

                    b.Property<bool>("IsPromoted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("TransmissionType")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenerationId");

                    b.HasIndex("UserId");

                    b.ToTable("Adverts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarProductionDate = new DateTime(2008, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Condition = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "opis ogłoszenia, stan igła",
                            Displacement = 1461,
                            DriveType = 0,
                            ExpiryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstRegistrationDate = new DateTime(2008, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            GenerationId = 1,
                            HasBeenCrashed = true,
                            Horsepower = 106,
                            IsPromoted = false,
                            Location = "Poznań",
                            Mileage = 210000,
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "600200400",
                            PlateNumber = "CIN 74582",
                            Price = 9950.0,
                            State = 1,
                            TransmissionType = 2,
                            UserId = 2,
                            VIN = "VKFR1H1236578",
                            VisitCount = 0
                        },
                        new
                        {
                            Id = 2,
                            CarProductionDate = new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Condition = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "opis ogłoszenia, stan igła",
                            Displacement = 1461,
                            DriveType = 1,
                            ExpiryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstRegistrationDate = new DateTime(2006, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            GenerationId = 4,
                            HasBeenCrashed = false,
                            Horsepower = 106,
                            IsPromoted = false,
                            Location = "Bydgoszcz",
                            Mileage = 110000,
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "600200800",
                            PlateNumber = "CBY 74582",
                            Price = 19950.0,
                            State = 1,
                            TransmissionType = 2,
                            UserId = 3,
                            VIN = "VKFR1H1236578",
                            VisitCount = 0
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.AdvertEquipment", b =>
                {
                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasKey("AdvertId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("AdvertEquipment");

                    b.HasData(
                        new
                        {
                            AdvertId = 1,
                            EquipmentId = 1
                        },
                        new
                        {
                            AdvertId = 1,
                            EquipmentId = 2
                        },
                        new
                        {
                            AdvertId = 1,
                            EquipmentId = 3
                        },
                        new
                        {
                            AdvertId = 1,
                            EquipmentId = 4
                        },
                        new
                        {
                            AdvertId = 1,
                            EquipmentId = 5
                        },
                        new
                        {
                            AdvertId = 2,
                            EquipmentId = 3
                        },
                        new
                        {
                            AdvertId = 2,
                            EquipmentId = 4
                        },
                        new
                        {
                            AdvertId = 2,
                            EquipmentId = 5
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Renault"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Alfa Roemo"
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ESR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Elektrycznie sterowane lusterka"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Elektrycznie sterowane szyby (przód + tył)"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Elektrycznie sterowane szyby (przód)"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Klimatyzacja manualna"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Klimatyzacja automatyczna"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Klimatyzacja automatyczna dwustrefowa"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Klimatyzacja automatyczna trzystrefowa"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Klimatyzacja automatyczna czterostrefowa"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Czujniki parkowania (przód + tył)"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Czujniki parkowania (tył)"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Kamera cofania"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Światła przeciwmgielne"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Skórzana tapicerka"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Podgrzewane lusterka"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Podgrzewana tylna szyba"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Podgrzewana przednia szyba"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Czujnik deszczu"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Czujnik zmierzchu"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Doświetlanie zakrętów"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Światła do jazdy dziennej"
                        },
                        new
                        {
                            Id = 22,
                            Name = "ABS"
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.Generation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Generations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModelId = 1,
                            Name = "III"
                        },
                        new
                        {
                            Id = 2,
                            ModelId = 1,
                            Name = "IV"
                        },
                        new
                        {
                            Id = 3,
                            ModelId = 2,
                            Name = "III"
                        },
                        new
                        {
                            Id = 4,
                            ModelId = 4,
                            Name = "E36"
                        },
                        new
                        {
                            Id = 5,
                            ModelId = 4,
                            Name = "E46"
                        },
                        new
                        {
                            Id = 6,
                            ModelId = 5,
                            Name = ""
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Name = "Clio"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            Name = "Megane"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            Name = "Seria 3"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            Name = "Seria 5"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 5,
                            Name = "159"
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GenerationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenerationId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<int>("DurationInDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentInitiation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaymentTermination")
                        .HasColumnType("datetime2");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("AutoStonks.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EnforcePasswordChange")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastPasswordChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "napewnoniehandlarz@gmail.com",
                            EnforcePasswordChange = false,
                            IsActive = true,
                            LastPasswordChange = new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "qwerty",
                            Role = "A",
                            Salt = "0",
                            Username = "NaPewnoNieHandlarz"
                        },
                        new
                        {
                            Id = 2,
                            EmailAddress = "kontotestowe@gmail.com",
                            EnforcePasswordChange = false,
                            IsActive = true,
                            LastPasswordChange = new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "qwerty",
                            Role = "U",
                            Salt = "0",
                            Username = "kontoTestowe"
                        },
                        new
                        {
                            Id = 3,
                            EmailAddress = "deatharmy@gmail.com",
                            EnforcePasswordChange = false,
                            IsActive = true,
                            LastPasswordChange = new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "qwerty",
                            Role = "U",
                            Salt = "0",
                            Username = "deatharmy"
                        });
                });

            modelBuilder.Entity("AutoStonks.API.Models.Advert", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Generation", "Generation")
                        .WithMany()
                        .HasForeignKey("GenerationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoStonks.API.Models.User", "User")
                        .WithMany("Adverts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Generation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutoStonks.API.Models.AdvertEquipment", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Advert", "Advert")
                        .WithMany("AdvertEquipments")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoStonks.API.Models.Equipment", "Equipment")
                        .WithMany("AdvertEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Generation", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Model", "Model")
                        .WithMany("Generations")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Model", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Package", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Generation", "Generation")
                        .WithMany("Versions")
                        .HasForeignKey("GenerationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Generation");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Payment", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Advert", "Advert")
                        .WithMany("Payments")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Photo", b =>
                {
                    b.HasOne("AutoStonks.API.Models.Advert", "Advert")
                        .WithMany("Photos")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Advert", b =>
                {
                    b.Navigation("AdvertEquipments");

                    b.Navigation("Payments");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Equipment", b =>
                {
                    b.Navigation("AdvertEquipments");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Generation", b =>
                {
                    b.Navigation("Versions");
                });

            modelBuilder.Entity("AutoStonks.API.Models.Model", b =>
                {
                    b.Navigation("Generations");
                });

            modelBuilder.Entity("AutoStonks.API.Models.User", b =>
                {
                    b.Navigation("Adverts");
                });
#pragma warning restore 612, 618
        }
    }
}
