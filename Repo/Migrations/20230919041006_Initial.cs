using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ICAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirportWeatherForecast",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeIcao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtmosphericPressure = table.Column<int>(type: "int", nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wind = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WindDirection = table.Column<int>(type: "int", nullable: false),
                    Moisture = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConditionDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportWeatherForecast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdBrasilApi = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitiesSearch",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesSearch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    JsonContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitiesWeatherForecast",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitiesId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    min = table.Column<int>(type: "int", nullable: false),
                    max = table.Column<int>(type: "int", nullable: false),
                    IndexUv = table.Column<int>(type: "int", nullable: false),
                    ConditionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesWeatherForecast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitiesWeatherForecast_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, "Romeu Zema Airport", "Araxa", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2417), false, "SBAX", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2426) },
                    { 2L, "Piloto Osvaldo Marques Dias Airport", "Alta Floresta", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2429), false, "SBAT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2429) },
                    { 3L, "Aripuanã Airport", "Aripuana", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2431), false, "SWRP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2431) },
                    { 4L, "Santa Maria Airport", "Aracaju", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2432), false, "SBAR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2432) },
                    { 5L, "Arapiraca Airport", "Arapiraca", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2433), false, "SNAL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2433) },
                    { 6L, "Araraquara Airport", "Araracuara", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2434), false, "SBAQ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2434) },
                    { 7L, "Araçatuba Airport", "Aracatuba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2435), false, "SBAU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2436) },
                    { 8L, "Altamira Airport", "Altamira", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2436), false, "SBHT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2437) },
                    { 9L, "Araguaína Airport", "Araguaina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2437), false, "SWGN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2438) },
                    { 10L, "Chafei Amsei Airport", "Barretos", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2439), false, "SBBT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2439) },
                    { 11L, "Bauru Airport", "Bauru", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2440), false, "SBBU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2440) },
                    { 12L, "Barcelos Airport", "Barcelos", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2441), false, "SWBC", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2441) },
                    { 13L, "Val de Cans/Júlio Cezar Ribeiro International Airport", "Belem", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2442), false, "SBBE", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2442) },
                    { 14L, "Bacacheri Airport", "Curitiba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2443), false, "SBBI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2443) },
                    { 15L, "Comandante Gustavo Kraemer Airport", "Bage", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2444), false, "SBBG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2445) },
                    { 16L, "Estadual Arthur Siqueira Airport", "Braganca Paulista", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2445), false, "SBBP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2446) },
                    { 17L, "Blumenau Airport", "BLUMENAU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2446), false, "SSBL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2447) },
                    { 18L, "Porto Seguro Airport", "Porto Seguro", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2449), false, "SBPS", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2449) },
                    { 19L, "Barreiras Airport", "Barreiras", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2450), false, "SNBR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2451) },
                    { 20L, "Presidente Juscelino Kubistschek International Airport", "Brasilia", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2452), false, "SBBR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2453) },
                    { 21L, "Atlas Brasil Cantanhede Airport", "Boa Vista", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2453), false, "SBBV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2454) },
                    { 22L, "Brigadeiro Camarão Airport", "Vilhena", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2455), false, "SBVH", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2456) },
                    { 23L, "Breves Airport", "Breves", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2456), false, "SNVS", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2457) },
                    { 24L, "Bonito Airport", "Bointo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2458), false, "SJDB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2458) },
                    { 25L, "Umberto Modiano Airport", "Buzios", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2459), false, "SBBZ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2459) },
                    { 26L, "Cascavel Airport", "Cascavel", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2461), false, "SBCA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2461) },
                    { 27L, "Carauari Airport", "Carauari", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2462), false, "SWCA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2462) },
                    { 28L, "Caruaru Airport", "Caruaru", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2463), false, "SNRU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2463) },
                    { 29L, "Bartolomeu Lisandro Airport", "Campos", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2464), false, "SBCP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2464) },
                    { 31L, "Concórdia Airport", "Concordia", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2465), false, "SSCK", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2465) },
                    { 32L, "Diomício Freitas Airport", "Criciuma", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2466), false, "SBCM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2467) },
                    { 33L, "Cáceres Airport", "Caceres", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2467), false, "SWKC", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2468) },
                    { 34L, "Conceição do Araguaia Airport", "Conceicao Do Araguaia", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2468), false, "SBAA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2469) },
                    { 35L, "Cabo Frio Airport", "Cabo Frio", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2469), false, "SBCB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2470) },
                    { 36L, "Caçador Airport", "Cacador", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2470), false, "SBCD", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2471) },
                    { 37L, "Confresa Airport", "Confresa", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2472), false, "SJHG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2472) },
                    { 38L, "Marechal Rondon Airport", "Cuiaba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2473), false, "SBCY", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2473) },
                    { 39L, "Congonhas – Deputado Freitas Nobre Airport", "Sao Paulo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2474), false, "SBSP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2474) },
                    { 40L, "Campo Grande Airport", "Campo Grande", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2475), false, "SBCG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2475) },
                    { 41L, "Coari Airport", "Coari", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2476), false, "SWKO", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2476) },
                    { 42L, "Carajás Airport", "Parauapebas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2477), false, "SBCJ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2478) },
                    { 43L, "Brig. Lysias Augusto Rodrigues Airport", "Carolina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2478), false, "SBCI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2479) }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 44L, "Nelson Ribeiro Guimarães Airport", "Caldas Novas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2479), false, "SBCN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2480) },
                    { 45L, "Corumbá International Airport", "Corumba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2480), false, "SBCR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2481) },
                    { 46L, "Santana do Araguaia Airport", "Santana do Araguaia", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2482), false, "SNKE", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2482) },
                    { 47L, "Tancredo Neves International Airport", "Belo Horizonte", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2483), false, "SBCF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2483) },
                    { 48L, "Amarais Airport", "Campinas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2484), false, "SDAM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2484) },
                    { 49L, "Presidente João Suassuna Airport", "Campina Grande", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2485), false, "SBKG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2485) },
                    { 50L, "Caravelas Airport", "Caravelas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2487), false, "SBCV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2488) },
                    { 51L, "Afonso Pena Airport", "Curitiba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2489), false, "SBCT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2489) },
                    { 52L, "Hugo Cantergiani Regional Airport", "Caxias Do Sul", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2490), false, "SBCX", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2490) },
                    { 53L, "Cruzeiro do Sul Airport", "Cruzeiro do Sul", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2491), false, "SBCZ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2491) },
                    { 54L, "Brigadeiro Cabral Airport", "Divinopolis", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2492), false, "SNDV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2492) },
                    { 55L, "Diamantino Airport", "Diamantino", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2493), false, "SWDM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2493) },
                    { 56L, "Dourados Airport", "Dourados", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2494), false, "SSDO", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2495) },
                    { 57L, "Diamantina Airport", "Diamantina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2495), false, "SNDT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2496) },
                    { 58L, "Erechim Airport", "Erechim", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2497), false, "SSER", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2497) },
                    { 59L, "Eirunepé Airport", "Eirunepe", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2498), false, "SWEI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2499) },
                    { 60L, "Fonte Boa Airport", "Fonte Boa", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2501), false, "SWOB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2501) },
                    { 61L, "Francisco Beltrão Airport", "Francisco Beltrao", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2503), false, "SSFB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2504) },
                    { 62L, "Fernando de Noronha Airport", "Fernando Do Noronha", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2506), false, "SBFN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2506) },
                    { 63L, "Cangapara Airport", "Floriano", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2508), false, "SNQG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2508) },
                    { 64L, "Hercílio Luz International Airport", "Florianopolis", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2510), false, "SBFL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2510) },
                    { 65L, "Pinto Martins International Airport", "Fortaleza", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2511), false, "SBFZ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2512) },
                    { 66L, "Franca Airport", "Franca", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2513), false, "SIMK", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2513) },
                    { 67L, "Santo Ângelo Airport", "Santo Angelo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2543), false, "SBNM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2544) },
                    { 68L, "Rio Galeão – Tom Jobim International Airport", "Rio De Janeiro", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2545), false, "SBGL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2545) },
                    { 69L, "Guanambi Airport", "Guanambi", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2546), false, "SNGI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2546) },
                    { 70L, "Tancredo Thomas de Faria Airport", "Guarapuava", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2547), false, "SBGU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2547) },
                    { 71L, "Gurupi Airport", "Gurupi", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2548), false, "SWGI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2549) },
                    { 72L, "Guarulhos – Governador André Franco Montoro International Airport", "Sao Paulo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2549), false, "SBGR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2550) },
                    { 73L, "Guarapari Airport", "Guarapari", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2550), false, "SNGA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2551) },
                    { 74L, "Coronel Altino Machado de Oliveira Airport", "Governador Valadares", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2553), false, "SBGV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2553) },
                    { 75L, "Santa Genoveva Airport", "Goiania", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2554), false, "SBGO", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2554) },
                    { 76L, "Humaitá Airport", "Humaita", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2555), false, "SWHT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2555) },
                    { 77L, "Cataratas International Airport", "Foz Do Iguacu", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2556), false, "SBFI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2556) },
                    { 78L, "Prefeito Renato Moreira Airport", "Imperatriz", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2558), false, "SBIZ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2559) },
                    { 79L, "Bahia – Jorge Amado Airport", "Ilheus", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2560), false, "SBIL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2561) },
                    { 80L, "Usiminas Airport", "Ipatinga", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2561), false, "SBIP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2562) },
                    { 81L, "Tapuruquara Airport", "Santa Isabel do Rio Negro", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2564), false, "SWTP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2564) },
                    { 82L, "Itaituba Airport", "Itaituba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2566), false, "SBIH", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2566) },
                    { 83L, "Itaperuna Airport", "Itaperuna", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2567), false, "SDUN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2568) },
                    { 84L, "Zona da Mata Regional Airport", "Juiz de Fora", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2569), false, "SDZY", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2569) },
                    { 85L, "Santa Terezinha Airport", "Joacaba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2570), false, "SSJA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2570) }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 86L, "Francisco de Assis Airport", "Juiz De Fora", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2571), false, "SBJF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2572) },
                    { 87L, "Orlando Bezerra de Menezes Airport", "Juazeiro Do Norte", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2573), false, "SBJU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2573) },
                    { 88L, "Juína Airport", "Juina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2574), false, "SWJN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2575) },
                    { 89L, "Comandante Ariston Pessoa Airport", "Jericoacoara", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2576), false, "SSVV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2576) },
                    { 90L, "Lauro Carneiro de Loyola Airport", "Joinville", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2577), false, "SBJV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2577) },
                    { 91L, "Presidente Castro Pinto International Airport", "Joao Pessoa", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2578), false, "SBJP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2578) },
                    { 92L, "Ji-Paraná Airport", "Ji-Paraná", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2579), false, "SWJI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2579) },
                    { 93L, "Juruena Airport", "Juruena", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2580), false, "SWJU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2580) },
                    { 94L, "Bauru – Arealva Airport", "Bauru", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2581), false, "SJTC", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2581) },
                    { 95L, "Inácio Luís do Nascimento Airport", "Juara", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2582), false, "SIZX", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2583) },
                    { 96L, "Bom Jesus da Lapa Airport", "Bom Jesus Da Lapa", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2583), false, "SBLP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2584) },
                    { 97L, "Lábrea Airport", "Labrea", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2586), false, "SWLB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2586) },
                    { 98L, "Governador José Richa Airport", "Londrina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2587), false, "SBLO", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2587) },
                    { 99L, "Coronel Horácio de Mattos Airport", "Lençóis", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2588), false, "SBLE", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2588) },
                    { 100L, "Lins Airport", "Lins", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2589), false, "SBLN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2589) },
                    { 101L, "Fazenda Colen Airport", "Lucas do Rio Verde", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2590), false, "SWFE", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2591) },
                    { 102L, "João Correa da Rocha Airport", "Maraba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2591), false, "SBMA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2592) },
                    { 103L, "Eduardo Gomes International Airport", "Manaus", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2592), false, "SBEG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2593) },
                    { 104L, "Maués Airport", "Maues", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2593), false, "SNZA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2594) },
                    { 105L, "Zumbi dos Palmares Airport", "Maceio", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2594), false, "SBMO", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2595) },
                    { 106L, "Monte Dourado Airport", "Almeirim", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2596), false, "SWMW", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2596) },
                    { 107L, "Frank Miloye Milenkowichi–Marília State Airport", "Marília", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2597), false, "SBML", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2597) },
                    { 108L, "Mário Ribeiro Airport", "Montes Claros", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2599), false, "SBMK", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2599) },
                    { 109L, "Monterey Regional Airport", "Monte Alegre", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2600), false, "SWAM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2600) },
                    { 110L, "Dix-Sept Rosado Airport", "Mossoro", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2601), false, "SNMU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2601) },
                    { 111L, "Mavi Gema Airport", "Caravelas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2602), false, "SNMU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2603) },
                    { 112L, "Mauá Airport", "Maua", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2603), false, "SBMW", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2604) },
                    { 113L, "Governador Aluízio Alves International Airport", "Natal", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2604), false, "SBNT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2605) },
                    { 114L, "Ourilandia do Norte Airport", "Ourilandia do Norte", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2606), false, "SBUA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2607) },
                    { 115L, "Presidente João Batista Figueiredo Airport", "Mirai", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2607), false, "SWNZ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2608) },
                    { 116L, "Ministro Victor Konder International Airport", "Navegantes", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2609), false, "SBNF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2610) },
                    { 117L, "Senadora Eunice Micheles Airport", "Sao Paulo De Olivenca", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2610), false, "SBHT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2611) },
                    { 118L, "Oriximiná Airport", "Oriximina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2612), false, "SWMW", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2613) },
                    { 119L, "North Canaan Airport", "North Canaan", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2613), false, "SWTP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2614) },
                    { 120L, "Osvaldo Vieira International Airport", "Osvaldo Vieira", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2616), false, "SBTC", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2616) },
                    { 121L, "Lauro Kurtz Airport", "Passo Fundo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2617), false, "SBPF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2617) },
                    { 122L, "Lauro Kurtz Airport", "Passo Fundo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2619), false, "SBPF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2619) },
                    { 123L, "Parnaíba-Prefeito Dr. João Silva Filho International Airport", "Parnaiba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2620), false, "SBPB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2620) },
                    { 124L, "Parintins Airport", "Parintins", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2621), false, "SNVS", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2622) },
                    { 125L, "Pampulha – Carlos Drummond de Andrade Airport", "Belo Horizonte", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2623), false, "SBBH", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2624) },
                    { 126L, "Ponta Porã International Airport", "Ponta Pora", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2625), false, "SBPP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2625) },
                    { 127L, "Brigadeiro Lysias Rodrigues Airport", "Palmas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2626), false, "SBPJ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2626) }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 128L, "Senador Nilo Coelho Airport", "Petrolina", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2628), false, "SNZA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2628) },
                    { 129L, "Patos de Minas Airport", "Patos De Minas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2629), false, "SNPD", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2629) },
                    { 130L, "Senador Petronio Portella Airport", "Picos", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2630), false, "SNPL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2630) },
                    { 131L, "Viracopos International Airport", "Campinas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2632), false, "SBDN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2632) },
                    { 132L, "Viracopos International Airport", "Campinas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2633), false, "SBDN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2633) },
                    { 133L, "Presidente Prudente Airport", "Presidente Prudente", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2635), false, "SNPA", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2635) },
                    { 134L, "Presidente Castro Pinto Airport", "Praca", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2636), false, "SBPR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2636) },
                    { 135L, "São Carlos Airport", "Sao Carlos", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2637), false, "SBNF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2637) },
                    { 136L, "Leite Lopes Airport", "Ribeirao Preto", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2638), false, "SBRP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2639) },
                    { 137L, "Raramuri Airport", "Raramuri", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2639), false, "SNRP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2640) },
                    { 138L, "Plácido de Castro Airport", "Rio Branco", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2640), false, "SWRB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2641) },
                    { 139L, "Guararapes-Gilberto Freyre International Airport", "Recife", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2642), false, "SBRF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2642) },
                    { 140L, "Santa Maria Airport", "Santa Maria", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2643), false, "SBSM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2643) },
                    { 141L, "Rainforest Airport", "Rioja", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2644), false, "SWEK", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2644) },
                    { 142L, "Rio de Janeiro–Galeão International Airport", "Rio De Janeiro", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2645), false, "SBGL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2645) },
                    { 143L, "Maestro Marinho Franco Airport", "Rondonopolis", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2646), false, "SWTP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2646) },
                    { 144L, "Islas Malvinas International Airport", "Rosario", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2648), false, "SBRK", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2648) },
                    { 145L, "Santos Dumont Airport", "Rio De Janeiro", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2649), false, "SBRJ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2649) },
                    { 146L, "Marechal Cunha Machado International Airport", "Sao Luiz", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2650), false, "SBSL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2650) },
                    { 147L, "Sorriso Airport", "Sorriso", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2651), false, "SNAM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2651) },
                    { 148L, "Base Aérea de Santos Airport", "Santos", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2652), false, "SBRJ", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2653) },
                    { 149L, "Maestro Wilson Fonseca Airport", "Santarem", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2653), false, "SBSN", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2654) },
                    { 150L, "Santa Cruz do Xingu Airport", "Santa Cruz Do Xingu", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2654), false, "SNTF", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2655) },
                    { 151L, "São Félix do Xingu Airport", "Sao Felix Do Xingu", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2655), false, "SWSI", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2656) },
                    { 152L, "Serra do Cabral Airport", "Sao Luiz Gonzaga", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2657), false, "SNBR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2657) },
                    { 153L, "Trombetas Airport", "Trombetas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2658), false, "SNBR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2658) },
                    { 154L, "Toledo Airport", "Toledo", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2659), false, "SBTD", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2659) },
                    { 155L, "Tucuruí Airport", "Tucurui", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2660), false, "SBTU", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2660) },
                    { 156L, "Mário de Almeida Franco Airport", "Uberaba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2661), false, "SBUR", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2662) },
                    { 157L, "Ubatuba Airport", "Ubatuba", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2662), false, "SDUB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2663) },
                    { 158L, "Ten. Cel. Aviador César Bombonato Airport", "Uberlandia", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2663), false, "SBUL", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2664) },
                    { 159L, "Umuarama Airport", "Umuarama", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2665), false, "SSUM", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2665) },
                    { 160L, "Hotel Transamérica Airport", "Una", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2666), false, "SBTC", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2666) },
                    { 161L, "Rubem Berta Airport", "Uruguaiana", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2667), false, "SBUG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2667) },
                    { 162L, "Major Brigadeiro Trompowsky Airport", "Varginha", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2668), false, "SBVG", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2669) },
                    { 163L, "Valença Airport", "Valenca", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2669), false, "SNVB", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2670) },
                    { 164L, "Viracopos International Airport", "Campinas", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2670), false, "SBKP", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2671) },
                    { 165L, "Vitória da Conquista Airport", "Vitória Da Conquista", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2671), false, "SBQV", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2672) },
                    { 166L, "Eurico de Aguiar Salles Airport", "Vitoria", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2673), false, "SBVT", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2673) },
                    { 167L, "Vila Rica Airport", "Vila Rica", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2674), false, "SWVC", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2674) },
                    { 168L, "Serafin Enoss Bertaso Airport", "Chapeco", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2676), false, "SBCH", new DateTime(2023, 9, 19, 1, 10, 5, 851, DateTimeKind.Local).AddTicks(2676) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesWeatherForecast_CitiesId",
                table: "CitiesWeatherForecast",
                column: "CitiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropTable(
                name: "AirportWeatherForecast");

            migrationBuilder.DropTable(
                name: "CitiesSearch");

            migrationBuilder.DropTable(
                name: "CitiesWeatherForecast");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
