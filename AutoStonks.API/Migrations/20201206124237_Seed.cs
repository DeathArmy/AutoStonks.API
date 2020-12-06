using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoStonks.API.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Adverts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Renault" },
                    { 2, "BMW" },
                    { 3, "Mercedes-Benz" },
                    { 4, "Audi" },
                    { 5, "Alfa Roemo" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 22, "ABS" },
                    { 21, "Światła do jazdy dziennej" },
                    { 20, "Doświetlanie zakrętów" },
                    { 19, "Czujnik zmierzchu" },
                    { 18, "Czujnik deszczu" },
                    { 17, "Podgrzewana przednia szyba" },
                    { 16, "Podgrzewana tylna szyba" },
                    { 15, "Podgrzewane lusterka" },
                    { 14, "Skórzana tapicerka" },
                    { 13, "Światła przeciwmgielne" },
                    { 12, "Kamera cofania" },
                    { 10, "Czujniki parkowania (przód + tył)" },
                    { 9, "Klimatyzacja automatyczna czterostrefowa" },
                    { 8, "Klimatyzacja automatyczna trzystrefowa" },
                    { 7, "Klimatyzacja automatyczna dwustrefowa" },
                    { 6, "Klimatyzacja automatyczna" },
                    { 5, "Klimatyzacja manualna" },
                    { 4, "Elektrycznie sterowane szyby (przód)" },
                    { 3, "Elektrycznie sterowane szyby (przód + tył)" },
                    { 2, "Elektrycznie sterowane lusterka" },
                    { 1, "ESR" },
                    { 11, "Czujniki parkowania (tył)" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "EnforcePasswordChange", "IsActive", "LastPasswordChange", "Password", "Role", "Salt", "Username" },
                values: new object[,]
                {
                    { 2, "kontotestowe@gmail.com", false, true, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "qwerty", "U", "0", "kontoTestowe" },
                    { 1, "napewnoniehandlarz@gmail.com", false, true, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "qwerty", "A", "0", "NaPewnoNieHandlarz" },
                    { 3, "deatharmy@gmail.com", false, true, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "qwerty", "U", "0", "deatharmy" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Clio" },
                    { 2, 1, "Megane" },
                    { 3, 2, "Seria 3" },
                    { 4, 2, "Seria 5" },
                    { 5, 5, "159" }
                });

            migrationBuilder.InsertData(
                table: "Generations",
                columns: new[] { "Id", "ModelId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "III" },
                    { 2, 1, "IV" },
                    { 3, 2, "III" },
                    { 4, 4, "E36" },
                    { 5, 4, "E46" },
                    { 6, 5, "" }
                });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CarProductionDate", "Condition", "CreationDate", "Description", "Displacement", "DriveType", "ExpiryDate", "FirstRegistrationDate", "Fuel", "GenerationId", "HasBeenCrashed", "Horsepower", "IsPromoted", "Location", "Mileage", "ModificationDate", "PhoneNumber", "PlateNumber", "Price", "State", "TransmissionType", "UserId", "VIN", "VisitCount" },
                values: new object[] { 1, new DateTime(2008, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "opis ogłoszenia, stan igła", 1461, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, true, 106, false, "Poznań", 210000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "600200400", "CIN 74582", 9950.0, 1, 2, 2, "VKFR1H1236578", 0 });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CarProductionDate", "Condition", "CreationDate", "Description", "Displacement", "DriveType", "ExpiryDate", "FirstRegistrationDate", "Fuel", "GenerationId", "HasBeenCrashed", "Horsepower", "IsPromoted", "Location", "Mileage", "ModificationDate", "PhoneNumber", "PlateNumber", "Price", "State", "TransmissionType", "UserId", "VIN", "VisitCount" },
                values: new object[] { 2, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "opis ogłoszenia, stan igła", 1461, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, false, 106, false, "Bydgoszcz", 110000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "600200800", "CBY 74582", 19950.0, 1, 2, 3, "VKFR1H1236578", 0 });

            migrationBuilder.InsertData(
                table: "AdvertEquipment",
                columns: new[] { "AdvertId", "EquipmentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AdvertEquipment",
                keyColumns: new[] { "AdvertId", "EquipmentId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Adverts");
        }
    }
}
