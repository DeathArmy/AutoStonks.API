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
            //User Seed
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    EmailAddress = "napewnoniehandlarz@gmail.com",
                    Role = 'A',
                    Password = "츊း뤮䷔뛦熜뀹獳㴗༫暸쨥櫆됈",
                    Salt = "⣶刌䅦윽璅ꚮ�闏ⵁ堣帠䳀�壨瘶晤",
                    LastPasswordChange = new DateTime(2021, 02, 01),
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
                    Name = "Alfa Romeo"
                },
                new Brand
                {
                    Id = 6,
                    Name = "Opel"
                },
                new Brand
                {
                    Id = 7,
                    Name = "Volkswagen"
                },
                new Brand
                {
                    Id = 8,
                    Name = "Toyota"
                },
                new Brand
                {
                    Id = 9,
                    Name = "Ford"
                },
                new Brand
                {
                    Id = 10,
                    Name = "Polonez"
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
                    BrandId = 1,
                    Name = "Laguna"
                },
                new Model
                {
                    Id = 4,
                    BrandId = 1,
                    Name = "Scenic"
                },
                new Model
                {
                    Id = 5,
                    BrandId = 1,
                    Name = "Captur"
                },
                new Model
                {
                    Id = 6,
                    BrandId = 2,
                    Name = "Seria 3"
                },
                new Model
                {
                    Id = 7,
                    BrandId = 2,
                    Name = "Seria 5"
                },
                new Model
                {
                    Id = 8,
                    BrandId = 2,
                    Name = "Seria 7"
                },
                new Model
                {
                    Id = 9,
                    BrandId = 3,
                    Name = "Klasa C"
                },
                new Model
                {
                    Id = 10,
                    BrandId = 3,
                    Name = "Klasa E"
                },
                new Model
                {
                    Id = 11,
                    BrandId = 4,
                    Name = "A4"
                },
                new Model
                {
                    Id = 12,
                    BrandId = 4,
                    Name = "A6"
                },
                new Model
                {
                    Id = 13,
                    BrandId = 4,
                    Name = "A8"
                },
                new Model
                {
                    Id = 14,
                    BrandId = 5,
                    Name = "159"
                },
                new Model
                {
                    Id = 15,
                    BrandId = 5,
                    Name = "147"
                },
                new Model
                {
                    Id = 16,
                    BrandId = 5,
                    Name = "156"
                },
                new Model
                {
                    Id = 17,
                    BrandId = 5,
                    Name = "Brera"
                },
                new Model
                {
                    Id = 18,
                    BrandId = 6,
                    Name = "Corsa"
                },
                new Model
                {
                    Id = 19,
                    BrandId = 6,
                    Name = "Vectra"
                },
                new Model
                {
                    Id = 20,
                    BrandId = 6,
                    Name = "Insignia"
                },
                new Model
                {
                    Id = 21,
                    BrandId = 7,
                    Name = "Passat"
                },
                new Model
                {
                    Id = 22,
                    BrandId = 7,
                    Name = "Golf"
                },
                new Model
                {
                    Id = 23,
                    BrandId = 7,
                    Name = "Bora"
                },
                new Model
                {
                    Id = 24,
                    BrandId = 8,
                    Name = "Yaris"
                },
                new Model
                {
                    Id = 25,
                    BrandId = 9,
                    Name = "Escort"
                },
                new Model
                {
                    Id = 26,
                    BrandId = 9,
                    Name = "Sierra"
                },
                new Model
                {
                    Id = 27,
                    BrandId = 9,
                    Name = "Focus"
                },
                new Model
                {
                    Id = 28,
                    BrandId = 10,
                    Name = "Caro"
                }
                );

            //Generation Seed
            modelBuilder.Entity<Generation>().HasData(
                new Generation
                {
                    Id = 1,
                    ModelId = 1,
                    Name = "III (2005-2012)"
                },
                new Generation
                {
                    Id = 2,
                    ModelId = 1,
                    Name = "IV (2012-2018)"
                },
                new Generation
                {
                    Id = 3,
                    ModelId = 1,
                    Name = "V (2019-)"
                },
                new Generation
                {
                    Id = 4,
                    ModelId = 2,
                    Name = "III (2008-2016)"
                },
                new Generation
                {
                    Id = 5,
                    ModelId = 2,
                    Name = "IV (2016-)"
                },
                new Generation
                {
                    Id = 6,
                    ModelId = 3,
                    Name = "III (2007-2015)"
                },
                new Generation
                {
                    Id = 7,
                    ModelId = 4,
                    Name = "III (2009-2013)"
                },
                new Generation
                {
                    Id = 8,
                    ModelId = 4,
                    Name = "I (2013-2019)"
                },
                new Generation
                {
                    Id = 9,
                    ModelId = 5,
                    Name = "E36 (1990-1999)"
                },
                new Generation
                {
                    Id = 10,
                    ModelId = 5,
                    Name = "E46 (1998-2007)"
                },
                new Generation
                {
                    Id = 11,
                    ModelId = 6,
                    Name = "E39 (1996-2003)"
                },
                new Generation
                {
                    Id = 12,
                    ModelId = 8,
                    Name = "E38 (1994-2001)"
                },
                new Generation
                {
                    Id = 13,
                    ModelId = 9,
                    Name = "W203 (2000-2007)"
                },
                new Generation
                {
                    Id = 14,
                    ModelId = 10,
                    Name = "W124 (1993-1997)"
                },
                new Generation
                {
                    Id = 15,
                    ModelId = 11,
                    Name = "B6 (2000-2004)"
                },
                new Generation
                {
                    Id = 16,
                    ModelId = 11,
                    Name = "B7 (2004-2007)"
                },
                new Generation
                {
                    Id = 17,
                    ModelId = 12,
                    Name = "C6 (2004-2011)"
                },
                new Generation
                {
                    Id = 18,
                    ModelId = 13,
                    Name = "D3 (2002-2010)"
                },
                new Generation
                {
                    Id = 19,
                    ModelId = 14,
                    Name = "I (2005-2012)"
                },
                new Generation
                {
                    Id = 20,
                    ModelId = 15,
                    Name = "I (2000-2010)"
                },
                new Generation
                {
                    Id = 21,
                    ModelId = 16,
                    Name = "I (1999-2006)"
                },
                new Generation
                {
                    Id = 22,
                    ModelId = 17,
                    Name = "I (2005-2010)"
                },
                new Generation
                {
                    Id = 23,
                    ModelId = 18,
                    Name = "C (2000-2006)"
                },
                new Generation
                {
                    Id = 24,
                    ModelId = 18,
                    Name = "D (2006-2014)"
                },
                new Generation
                {
                    Id = 25,
                    ModelId = 19,
                    Name = "C (2002-2008)"
                },
                new Generation
                {
                    Id = 26,
                    ModelId = 20,
                    Name = "A (2008-2017)"
                },
                new Generation
                {
                    Id = 27,
                    ModelId = 21,
                    Name = "B5 (1996-2000)"
                },
                new Generation
                {
                    Id = 28,
                    ModelId = 21,
                    Name = "B5 FL (2000-2005)"
                },
                new Generation
                {
                    Id = 29,
                    ModelId = 22,
                    Name = "V (2003-2009)"
                },
                new Generation
                {
                    Id = 30,
                    ModelId = 23,
                    Name = "V (2003-2009)"
                },
                new Generation
                {
                    Id = 31,
                    ModelId = 24,
                    Name = "Jetta IV (1998-2005)"
                },
                new Generation
                {
                    Id = 32,
                    ModelId = 25,
                    Name = "Mk7 (1995-1999)"
                },
                new Generation
                {
                    Id = 33,
                    ModelId = 26,
                    Name = "Mk2 (1987-1993)"
                },
                new Generation
                {
                    Id = 34,
                    ModelId = 27,
                    Name = "Mk4 (2018-)"
                },
                new Generation
                {
                    Id = 35,
                    ModelId = 28,
                    Name = "I (1978-1991)"
                }
                );

            //Equipment Seed
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    Id = 1,
                    Name = "ABS"
                },
                new Equipment
                {
                    Id = 2,
                    Name = "CD"
                },
                new Equipment
                {
                    Id = 3,
                    Name = "Centralny zamek"
                },
                new Equipment
                {
                    Id = 4,
                    Name = "Elektryczne szyby przednia"
                },
                new Equipment
                {
                    Id = 5,
                    Name = "Elektrycznie ustawiane lusterka"
                },
                new Equipment
                {
                    Id = 6,
                    Name = "Immobilizer"
                },
                new Equipment
                {
                    Id = 7,
                    Name = "Poduszka powietrzna kierowcy"
                },
                new Equipment
                {
                    Id = 8,
                    Name = "Poduszka powietrzna pasażera"
                },
                new Equipment
                {
                    Id = 9,
                    Name = "Radio fabryczne"
                },
                new Equipment
                {
                    Id = 10,
                    Name = "Wspomaganie kierownicy"
                },
                new Equipment
                {
                    Id = 11,
                    Name = "Alarm"
                },
                new Equipment
                {
                    Id = 12,
                    Name = "Alufelgi"
                },
                new Equipment
                {
                    Id = 13,
                    Name = "ASR (kontrola trakcji)"
                },
                new Equipment
                {
                    Id = 14,
                    Name = "Asystent parkowania"
                },
                new Equipment
                {
                    Id = 15,
                    Name = "Asysten pasa ruchu"
                },
                new Equipment
                {
                    Id = 16,
                    Name = "Bluetooth"
                },
                new Equipment
                {
                    Id = 17,
                    Name = "Czujnik deszczu"
                },
                new Equipment
                {
                    Id = 18,
                    Name = "Czujnik martwego pola"
                },
                new Equipment
                {
                    Id = 19,
                    Name = "Czujnik zmierzchu"
                },
                new Equipment
                {
                    Id = 20,
                    Name = "Czujniki prakowania przednie"
                },
                new Equipment
                {
                    Id = 21,
                    Name = "Czujniki parkowania tylne"
                },
                new Equipment
                {
                    Id = 22,
                    Name = "Dach panoramiczny"
                },
                new Equipment
                {
                    Id = 23,
                    Name = "Elektrochromatyczne lusterka boczne"
                },
                new Equipment
                {
                    Id = 24,
                    Name = "Elektrochromatyczne lusterko wsteczne"
                },
                new Equipment
                {
                    Id = 25,
                    Name = "Elektryczne szyby tylne"
                },
                new Equipment
                {
                    Id = 26,
                    Name = "Elektrycznie ustawiane fotele"
                },
                new Equipment
                {
                    Id = 27,
                    Name = "ESP (stabilizacja toru jazdy)"
                },
                new Equipment
                {
                    Id = 28,
                    Name = "Gniazdo AUX"
                },
                new Equipment
                {
                    Id = 29,
                    Name = "Gniazdo SD"
                },
                new Equipment
                {
                    Id = 30,
                    Name = "Gniazdo USB"
                },
                new Equipment
                {
                    Id = 31,
                    Name = "Hak"
                },
                new Equipment
                {
                    Id = 32,
                    Name = "Isofix"
                },
                new Equipment
                {
                    Id = 33,
                    Name = "Kamera cofania"
                },
                new Equipment
                {
                    Id = 34,
                    Name = "Klimatyzacja automatyczna"
                },
                new Equipment
                {
                    Id = 35,
                    Name = "Klimatyzacja czterostrefowa"
                },
                new Equipment
                {
                    Id = 36,
                    Name = "Klimtayzacja dwustrefowa"
                },
                new Equipment
                {
                    Id = 37,
                    Name = "Klimatyzacja manualna"
                },
                new Equipment
                {
                    Id = 38,
                    Name = "Komputer pokładowy"
                },
                new Equipment
                {
                    Id = 39,
                    Name = "Kurtyny powietrzne"
                },
                new Equipment
                {
                    Id = 40,
                    Name = "MP3"
                },
                new Equipment
                {
                    Id = 41,
                    Name = "Nawigacja GPS"
                },
                new Equipment
                {
                    Id = 42,
                    Name = "Ogranicznik prędkości"
                },
                new Equipment
                {
                    Id = 43,
                    Name = "Ogrzewanie postojowe"
                },
                new Equipment
                {
                    Id = 44,
                    Name = "Podgrzewana przednia szyba"
                },
                new Equipment
                {
                    Id = 45,
                    Name = "Podgrzewane lusterka boczne"
                },
                new Equipment
                {
                    Id = 46,
                    Name = "Podgrzewane przednie siedzenia"
                },
                new Equipment
                {
                    Id = 47,
                    Name = "Podgrzewane tylne siedzenia"
                },
                new Equipment
                {
                    Id = 48,
                    Name = "Szyberdach"
                },
                new Equipment
                {
                    Id = 49,
                    Name = "Światła do jazdy dziennej"
                },
                new Equipment
                {
                    Id = 50,
                    Name = "Światła LED"
                },
                new Equipment
                {
                    Id = 51,
                    Name = "Światła przecwmgielne"
                },
                new Equipment
                {
                    Id = 52,
                    Name = "Światła Xenonowe"
                },
                new Equipment
                {
                    Id = 53,
                    Name = "Tapicerka skórzana"
                },
                new Equipment
                {
                    Id = 54,
                    Name = "Tapicerka welurowa"
                },
                new Equipment
                {
                    Id = 55,
                    Name = "Tempomat"
                },
                new Equipment
                {
                    Id = 56,
                    Name = "Wielofunkcyjna kierownica"
                }
                );
        }
    }
}
