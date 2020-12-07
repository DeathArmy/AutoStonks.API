using AutoStonks.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Advert Seed
            modelBuilder.Entity<Advert>().HasData(
                new Advert
                {
                    Id = 1,
                    UserId = 2,
                    IsPromoted = false,
                    Title = "Igła!!",
                    Description = "opis ogłoszenia, stan igła",
                    VIN = "VKFR1H1236578",
                    FirstRegistrationDate = new DateTime(2008, 5, 30),
                    PlateNumber = "CIN 74582",
                    State = States.Active,
                    Price = 9950,
                    Mileage = 210000,
                    CarProductionDate = new DateTime(2008, 3, 10),
                    Fuel = FuelType.Diesel,
                    Condition = ConditionState.Undamaged,
                    Horsepower = 106,
                    Displacement = 1461,
                    Location = "Poznań",
                    HasBeenCrashed = true,
                    TransmissionType = TransmissionTypes.Manual,
                    DriveType = DriveTypes.FWD,
                    VisitCount = 0,
                    GenerationId = 1,
                    PhoneNumber = "600200400"
                },
                new Advert
                {
                    Id = 2,
                    UserId = 3,
                    IsPromoted = false,
                    Title = "Alfa Romejoo",
                    Description = "opis ogłoszenia, stan igła",
                    VIN = "VKFR1H1236578",
                    FirstRegistrationDate = new DateTime(2006, 12, 10),
                    PlateNumber = "CBY 74582",
                    State = States.Active,
                    Price = 19950,
                    Mileage = 110000,
                    CarProductionDate = new DateTime(2006, 1, 1),
                    Fuel = FuelType.Diesel,
                    Condition = ConditionState.Undamaged,
                    Horsepower = 106,
                    Displacement = 1461,
                    Location = "Bydgoszcz",
                    HasBeenCrashed = false,
                    TransmissionType = TransmissionTypes.Manual,
                    DriveType = DriveTypes.RWD,
                    VisitCount = 0,
                    GenerationId = 4,
                    PhoneNumber = "600200800"
                }
                );

            //User Seed
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "NaPewnoNieHandlarz",
                    EmailAddress = "napewnoniehandlarz@gmail.com",
                    Role = 'A',
                    Password = "qwerty",
                    Salt = "0",
                    LastPasswordChange = new DateTime(2020, 12, 6),
                    EnforcePasswordChange = false,
                    IsActive = true,
                },
                new User
                {
                    Id = 2,
                    Username = "kontoTestowe",
                    EmailAddress = "kontotestowe@gmail.com",
                    Role = 'U',
                    Password = "qwerty",
                    Salt = "0",
                    LastPasswordChange = new DateTime(2020, 12, 6),
                    EnforcePasswordChange = false,
                    IsActive = true,
                },
                new User
                {
                    Id = 3,
                    Username = "deatharmy",
                    EmailAddress = "deatharmy@gmail.com",
                    Role = 'U',
                    Password = "qwerty",
                    Salt = "0",
                    LastPasswordChange = new DateTime(2020, 12, 6),
                    EnforcePasswordChange = false,
                    IsActive = true,
                }
                );

            //Brand Seed
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Renault"
                },
                new Brand
                {
                    Id = 2,
                    Name = "BMW"
                },
                new Brand
                {
                    Id = 3,
                    Name = "Mercedes-Benz"
                },
                new Brand
                {
                    Id = 4,
                    Name = "Audi"
                },
                new Brand
                {
                    Id = 5,
                    Name = "Alfa Roemo"
                }
                );

            //Model Seed
            modelBuilder.Entity<Model>().HasData(
                new Model
                {
                    Id = 1,
                    BrandId = 1,
                    Name = "Clio"
                },
                new Model
                {
                    Id = 2,
                    BrandId = 1,
                    Name = "Megane"
                },
                new Model
                {
                    Id = 3,
                    BrandId = 2,
                    Name = "Seria 3"
                },
                new Model
                {
                    Id = 4,
                    BrandId = 2,
                    Name = "Seria 5"
                },
                new Model
                {
                    Id = 5,
                    BrandId = 5,
                    Name = "159"
                }
                );

            //Generation Seed
            modelBuilder.Entity<Generation>().HasData(
                new Generation
                {
                    Id = 1,
                    ModelId = 1,
                    Name = "III"
                },
                new Generation
                {
                    Id = 2,
                    ModelId = 1,
                    Name = "IV"
                },
                new Generation
                {
                    Id = 3,
                    ModelId = 2,
                    Name = "III"
                },
                new Generation
                {
                    Id = 4,
                    ModelId = 4,
                    Name = "E36"
                },
                new Generation
                {
                    Id = 5,
                    ModelId = 4,
                    Name = "E46"
                },
                new Generation
                {
                    Id = 6,
                    ModelId = 5,
                    Name = ""
                }
                );

            //Equipment Seed
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    Id = 1,
                    Name = "ESR"
                },
                new Equipment
                {
                    Id = 2,
                    Name = "Elektrycznie sterowane lusterka"
                },
                new Equipment
                {
                    Id = 3,
                    Name = "Elektrycznie sterowane szyby (przód + tył)"
                },
                new Equipment
                {
                    Id = 4,
                    Name = "Elektrycznie sterowane szyby (przód)"
                },
                new Equipment
                {
                    Id = 5,
                    Name = "Klimatyzacja manualna"
                },
                new Equipment
                {
                    Id = 6,
                    Name = "Klimatyzacja automatyczna"
                },
                new Equipment
                {
                    Id = 7,
                    Name = "Klimatyzacja automatyczna dwustrefowa"
                },
                new Equipment
                {
                    Id = 8,
                    Name = "Klimatyzacja automatyczna trzystrefowa"
                },
                new Equipment
                {
                    Id = 9,
                    Name = "Klimatyzacja automatyczna czterostrefowa"
                },
                new Equipment
                {
                    Id = 10,
                    Name = "Czujniki parkowania (przód + tył)"
                },
                new Equipment
                {
                    Id = 11,
                    Name = "Czujniki parkowania (tył)"
                },
                new Equipment
                {
                    Id = 12,
                    Name = "Kamera cofania"
                },
                new Equipment
                {
                    Id = 13,
                    Name = "Światła przeciwmgielne"
                },
                new Equipment
                {
                    Id = 14,
                    Name = "Skórzana tapicerka"
                },
                new Equipment
                {
                    Id = 15,
                    Name = "Podgrzewane lusterka"
                },
                new Equipment
                {
                    Id = 16,
                    Name = "Podgrzewana tylna szyba"
                },
                new Equipment
                {
                    Id = 17,
                    Name = "Podgrzewana przednia szyba"
                },
                new Equipment
                {
                    Id = 18,
                    Name = "Czujnik deszczu"
                },
                new Equipment
                {
                    Id = 19,
                    Name = "Czujnik zmierzchu"
                },
                new Equipment
                {
                    Id = 20,
                    Name = "Doświetlanie zakrętów"
                },
                new Equipment
                {
                    Id = 21,
                    Name = "Światła do jazdy dziennej"
                },
                new Equipment
                {
                    Id = 22,
                    Name = "ABS"
                }
                );

            //AdvertEquipment Seed
            modelBuilder.Entity<AdvertEquipment>().HasData(
                new AdvertEquipment
                {
                    AdvertId = 1,
                    EquipmentId = 1
                },
                new AdvertEquipment
                {
                    AdvertId = 1,
                    EquipmentId = 2
                },
                new AdvertEquipment
                {
                    AdvertId = 1,
                    EquipmentId = 3
                },
                new AdvertEquipment
                {
                    AdvertId = 1,
                    EquipmentId = 4
                },
                new AdvertEquipment
                {
                    AdvertId = 1,
                    EquipmentId = 5
                },
                new AdvertEquipment
                {
                    AdvertId = 2,
                    EquipmentId = 3
                },
                new AdvertEquipment
                {
                    AdvertId = 2,
                    EquipmentId = 4
                },
                new AdvertEquipment
                {
                    AdvertId = 2,
                    EquipmentId = 5
                }
                );
        }
    }
}
