using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoStonks.API.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Renault" },
                    { 2, "BMW" },
                    { 3, "Mercedes-Benz" },
                    { 4, "Audi" },
                    { 5, "Alfa Romeo" },
                    { 6, "Opel" },
                    { 7, "Volkswagen" },
                    { 8, "Toyota" },
                    { 9, "Ford" },
                    { 10, "Polonez" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 40, "MP3" },
                    { 39, "Kurtyny powietrzne" },
                    { 38, "Komputer pokładowy" },
                    { 37, "Klimatyzacja manualna" },
                    { 36, "Klimtayzacja dwustrefowa" },
                    { 31, "Hak" },
                    { 34, "Klimatyzacja automatyczna" },
                    { 33, "Kamera cofania" },
                    { 32, "Isofix" },
                    { 41, "Nawigacja GPS" },
                    { 35, "Klimatyzacja czterostrefowa" },
                    { 42, "Ogranicznik prędkości" },
                    { 47, "Podgrzewane tylne siedzenia" },
                    { 44, "Podgrzewana przednia szyba" },
                    { 45, "Podgrzewane lusterka boczne" },
                    { 46, "Podgrzewane przednie siedzenia" },
                    { 30, "Gniazdo USB" },
                    { 48, "Szyberdach" },
                    { 49, "Światła do jazdy dziennej" },
                    { 50, "Światła LED" },
                    { 51, "Światła przecwmgielne" },
                    { 52, "Światła Xenonowe" },
                    { 53, "Tapicerka skórzana" },
                    { 54, "Tapicerka welurowa" },
                    { 55, "Tempomat" },
                    { 43, "Ogrzewanie postojowe" },
                    { 29, "Gniazdo SD" },
                    { 24, "Elektrochromatyczne lusterko wsteczne" },
                    { 27, "ESP (stabilizacja toru jazdy)" },
                    { 1, "ABS" },
                    { 2, "CD" },
                    { 3, "Centralny zamek" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Elektryczne szyby przednia" },
                    { 5, "Elektrycznie ustawiane lusterka" },
                    { 6, "Immobilizer" },
                    { 7, "Poduszka powietrzna kierowcy" },
                    { 8, "Poduszka powietrzna pasażera" },
                    { 9, "Radio fabryczne" },
                    { 10, "Wspomaganie kierownicy" },
                    { 11, "Alarm" },
                    { 12, "Alufelgi" },
                    { 28, "Gniazdo AUX" },
                    { 13, "ASR (kontrola trakcji)" },
                    { 15, "Asysten pasa ruchu" },
                    { 16, "Bluetooth" },
                    { 17, "Czujnik deszczu" },
                    { 18, "Czujnik martwego pola" },
                    { 19, "Czujnik zmierzchu" },
                    { 20, "Czujniki prakowania przednie" },
                    { 21, "Czujniki parkowania tylne" },
                    { 22, "Dach panoramiczny" },
                    { 23, "Elektrochromatyczne lusterka boczne" },
                    { 56, "Wielofunkcyjna kierownica" },
                    { 25, "Elektryczne szyby tylne" },
                    { 26, "Elektrycznie ustawiane fotele" },
                    { 14, "Asystent parkowania" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "EnforcePasswordChange", "IsActive", "LastPasswordChange", "Password", "Role", "Salt", "Username" },
                values: new object[] { 1, "napewnoniehandlarz@gmail.com", false, true, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "츊း뤮䷔뛦熜뀹獳㴗༫暸쨥櫆됈", "A", "⣶刌䅦윽璅ꚮ�闏ⵁ堣帠䳀�壨瘶晤", "admin" });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Clio" },
                    { 26, 9, "Sierra" },
                    { 25, 9, "Escort" },
                    { 24, 8, "Yaris" },
                    { 23, 7, "Bora" },
                    { 22, 7, "Golf" },
                    { 21, 7, "Passat" },
                    { 20, 6, "Insignia" },
                    { 19, 6, "Vectra" },
                    { 18, 6, "Corsa" },
                    { 17, 5, "Brera" },
                    { 16, 5, "156" },
                    { 15, 5, "147" },
                    { 14, 5, "159" },
                    { 13, 4, "A8" },
                    { 12, 4, "A6" },
                    { 11, 4, "A4" },
                    { 10, 3, "Klasa E" },
                    { 9, 3, "Klasa C" },
                    { 8, 2, "Seria 7" },
                    { 7, 2, "Seria 5" },
                    { 6, 2, "Seria 3" },
                    { 5, 1, "Captur" },
                    { 4, 1, "Scenic" },
                    { 3, 1, "Laguna" },
                    { 2, 1, "Megane" },
                    { 27, 9, "Focus" },
                    { 28, 10, "Caro" }
                });

            migrationBuilder.InsertData(
                table: "Generations",
                columns: new[] { "Id", "ModelId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "III (2005-2012)" },
                    { 20, 15, "I (2000-2010)" },
                    { 21, 16, "I (1999-2006)" },
                    { 22, 17, "I (2005-2010)" },
                    { 23, 18, "C (2000-2006)" },
                    { 24, 18, "D (2006-2014)" },
                    { 25, 19, "C (2002-2008)" },
                    { 19, 14, "I (2005-2012)" },
                    { 26, 20, "A (2008-2017)" },
                    { 28, 21, "B5 FL (2000-2005)" },
                    { 29, 22, "V (2003-2009)" },
                    { 30, 23, "V (2003-2009)" },
                    { 31, 24, "Jetta IV (1998-2005)" },
                    { 32, 25, "Mk7 (1995-1999)" },
                    { 33, 26, "Mk2 (1987-1993)" },
                    { 27, 21, "B5 (1996-2000)" },
                    { 34, 27, "Mk4 (2018-)" },
                    { 18, 13, "D3 (2002-2010)" },
                    { 16, 11, "B7 (2004-2007)" },
                    { 2, 1, "IV (2012-2018)" },
                    { 3, 1, "V (2019-)" },
                    { 4, 2, "III (2008-2016)" },
                    { 5, 2, "IV (2016-)" },
                    { 6, 3, "III (2007-2015)" },
                    { 7, 4, "III (2009-2013)" },
                    { 17, 12, "C6 (2004-2011)" },
                    { 8, 4, "I (2013-2019)" },
                    { 10, 5, "E46 (1998-2007)" },
                    { 11, 6, "E39 (1996-2003)" },
                    { 12, 8, "E38 (1994-2001)" },
                    { 13, 9, "W203 (2000-2007)" },
                    { 14, 10, "W124 (1993-1997)" },
                    { 15, 11, "B6 (2000-2004)" },
                    { 9, 5, "E36 (1990-1999)" },
                    { 35, 28, "I (1978-1991)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
