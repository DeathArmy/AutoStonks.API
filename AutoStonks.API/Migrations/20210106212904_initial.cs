using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoStonks.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPasswordChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnforcePasswordChange = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Generations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generations_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPromoted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    CarProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fuel = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    Displacement = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBeenCrashed = table.Column<bool>(type: "bit", nullable: false),
                    TransmissionType = table.Column<int>(type: "int", nullable: false),
                    DriveType = table.Column<int>(type: "int", nullable: false),
                    VisitCount = table.Column<int>(type: "int", nullable: false),
                    GenerationId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_Generations_GenerationId",
                        column: x => x.GenerationId,
                        principalTable: "Generations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adverts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertEquipment",
                columns: table => new
                {
                    AdvertId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertEquipment", x => new { x.AdvertId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_AdvertEquipment_Adverts_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "Adverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertEquipment_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    PaymentInitiation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentTermination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationInDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Adverts_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "Adverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Adverts_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "Adverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Id", "CarProductionDate", "Condition", "CreationDate", "Description", "Displacement", "DriveType", "ExpiryDate", "FirstRegistrationDate", "Fuel", "GenerationId", "HasBeenCrashed", "Horsepower", "IsPromoted", "Location", "Mileage", "ModificationDate", "PhoneNumber", "PlateNumber", "Price", "State", "Title", "TransmissionType", "UserId", "VIN", "VisitCount" },
                values: new object[] { 1, new DateTime(2008, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "opis ogłoszenia, stan igła", 1461, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, true, 106, false, "Poznań", 210000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "600200400", "CIN 74582", 9950.0, 1, "Igła!!", 2, 2, "VKFR1H1236578", 0 });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CarProductionDate", "Condition", "CreationDate", "Description", "Displacement", "DriveType", "ExpiryDate", "FirstRegistrationDate", "Fuel", "GenerationId", "HasBeenCrashed", "Horsepower", "IsPromoted", "Location", "Mileage", "ModificationDate", "PhoneNumber", "PlateNumber", "Price", "State", "Title", "TransmissionType", "UserId", "VIN", "VisitCount" },
                values: new object[] { 2, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "opis ogłoszenia, stan igła", 1461, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, false, 106, false, "Bydgoszcz", 110000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "600200800", "CBY 74582", 19950.0, 1, "Alfa Romejoo", 2, 3, "VKFR1H1236578", 0 });

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

            migrationBuilder.CreateIndex(
                name: "IX_AdvertEquipment_EquipmentId",
                table: "AdvertEquipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_GenerationId",
                table: "Adverts",
                column: "GenerationId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UserId",
                table: "Adverts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Generations_ModelId",
                table: "Generations",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AdvertId",
                table: "Payments",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AdvertId",
                table: "Photos",
                column: "AdvertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertEquipment");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "Generations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
