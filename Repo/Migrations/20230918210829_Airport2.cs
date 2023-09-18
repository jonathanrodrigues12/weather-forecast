using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repo.Migrations
{
    public partial class Airport2 : Migration
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

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, "Romeu Zema Airport", "Araxa", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7420), false, "SBAX", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7428) },
                    { 2L, "Piloto Osvaldo Marques Dias Airport", "Alta Floresta", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7432), false, "SBAT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7433) },
                    { 3L, "Aripuanã Airport", "Aripuana", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7434), false, "SWRP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7435) },
                    { 4L, "Santa Maria Airport", "Aracaju", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7436), false, "SBAR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7436) },
                    { 5L, "Arapiraca Airport", "Arapiraca", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7438), false, "SNAL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7438) },
                    { 6L, "Araraquara Airport", "Araracuara", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7439), false, "SBAQ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7440) },
                    { 7L, "Araçatuba Airport", "Aracatuba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7441), false, "SBAU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7441) },
                    { 8L, "Altamira Airport", "Altamira", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7442), false, "SBHT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7442) },
                    { 9L, "Araguaína Airport", "Araguaina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7443), false, "SWGN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7443) },
                    { 10L, "Chafei Amsei Airport", "Barretos", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7444), false, "SBBT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7444) },
                    { 11L, "Bauru Airport", "Bauru", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7445), false, "SBBU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7445) },
                    { 12L, "Barcelos Airport", "Barcelos", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7446), false, "SWBC", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7446) },
                    { 13L, "Val de Cans/Júlio Cezar Ribeiro International Airport", "Belem", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7447), false, "SBBE", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7447) },
                    { 14L, "Bacacheri Airport", "Curitiba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7448), false, "SBBI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7448) },
                    { 15L, "Comandante Gustavo Kraemer Airport", "Bage", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7449), false, "SBBG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7450) },
                    { 16L, "Estadual Arthur Siqueira Airport", "Braganca Paulista", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7450), false, "SBBP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7451) },
                    { 17L, "Blumenau Airport", "BLUMENAU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7451), false, "SSBL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7452) },
                    { 18L, "Porto Seguro Airport", "Porto Seguro", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7452), false, "SBPS", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7453) },
                    { 19L, "Barreiras Airport", "Barreiras", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7453), false, "SNBR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7454) },
                    { 20L, "Presidente Juscelino Kubistschek International Airport", "Brasilia", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7455), false, "SBBR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7455) },
                    { 21L, "Atlas Brasil Cantanhede Airport", "Boa Vista", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7457), false, "SBBV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7457) },
                    { 22L, "Brigadeiro Camarão Airport", "Vilhena", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7459), false, "SBVH", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7459) },
                    { 23L, "Breves Airport", "Breves", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7460), false, "SNVS", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7460) },
                    { 24L, "Bonito Airport", "Bointo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7461), false, "SJDB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7461) },
                    { 25L, "Umberto Modiano Airport", "Buzios", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7462), false, "SBBZ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7463) },
                    { 26L, "Cascavel Airport", "Cascavel", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7463), false, "SBCA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7464) },
                    { 27L, "Carauari Airport", "Carauari", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7464), false, "SWCA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7465) },
                    { 28L, "Caruaru Airport", "Caruaru", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7466), false, "SNRU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7466) },
                    { 29L, "Bartolomeu Lisandro Airport", "Campos", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7467), false, "SBCP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7467) },
                    { 31L, "Concórdia Airport", "Concordia", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7468), false, "SSCK", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7469) },
                    { 32L, "Diomício Freitas Airport", "Criciuma", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7470), false, "SBCM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7470) },
                    { 33L, "Cáceres Airport", "Caceres", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7471), false, "SWKC", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7471) },
                    { 34L, "Conceição do Araguaia Airport", "Conceicao Do Araguaia", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7472), false, "SBAA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7472) },
                    { 35L, "Cabo Frio Airport", "Cabo Frio", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7473), false, "SBCB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7473) },
                    { 36L, "Caçador Airport", "Cacador", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7474), false, "SBCD", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7474) },
                    { 37L, "Confresa Airport", "Confresa", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7476), false, "SJHG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7477) },
                    { 38L, "Marechal Rondon Airport", "Cuiaba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7477), false, "SBCY", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7478) },
                    { 39L, "Congonhas – Deputado Freitas Nobre Airport", "Sao Paulo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7479), false, "SBSP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7480) },
                    { 40L, "Campo Grande Airport", "Campo Grande", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7480), false, "SBCG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7481) },
                    { 41L, "Coari Airport", "Coari", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7482), false, "SWKO", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7482) },
                    { 42L, "Carajás Airport", "Parauapebas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7484), false, "SBCJ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7484) },
                    { 43L, "Brig. Lysias Augusto Rodrigues Airport", "Carolina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7486), false, "SBCI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7486) }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 44L, "Nelson Ribeiro Guimarães Airport", "Caldas Novas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7487), false, "SBCN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7487) },
                    { 45L, "Corumbá International Airport", "Corumba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7488), false, "SBCR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7488) },
                    { 46L, "Santana do Araguaia Airport", "Santana do Araguaia", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7489), false, "SNKE", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7489) },
                    { 47L, "Tancredo Neves International Airport", "Belo Horizonte", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7490), false, "SBCF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7490) },
                    { 48L, "Amarais Airport", "Campinas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7491), false, "SDAM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7491) },
                    { 49L, "Presidente João Suassuna Airport", "Campina Grande", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7492), false, "SBKG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7493) },
                    { 50L, "Caravelas Airport", "Caravelas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7494), false, "SBCV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7494) },
                    { 51L, "Afonso Pena Airport", "Curitiba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7495), false, "SBCT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7495) },
                    { 52L, "Hugo Cantergiani Regional Airport", "Caxias Do Sul", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7496), false, "SBCX", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7496) },
                    { 53L, "Cruzeiro do Sul Airport", "Cruzeiro do Sul", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7497), false, "SBCZ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7497) },
                    { 54L, "Brigadeiro Cabral Airport", "Divinopolis", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7499), false, "SNDV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7499) },
                    { 55L, "Diamantino Airport", "Diamantino", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7500), false, "SWDM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7500) },
                    { 56L, "Dourados Airport", "Dourados", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7501), false, "SSDO", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7501) },
                    { 57L, "Diamantina Airport", "Diamantina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7502), false, "SNDT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7502) },
                    { 58L, "Erechim Airport", "Erechim", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7504), false, "SSER", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7505) },
                    { 59L, "Eirunepé Airport", "Eirunepe", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7505), false, "SWEI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7506) },
                    { 60L, "Fonte Boa Airport", "Fonte Boa", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7507), false, "SWOB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7507) },
                    { 61L, "Francisco Beltrão Airport", "Francisco Beltrao", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7508), false, "SSFB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7509) },
                    { 62L, "Fernando de Noronha Airport", "Fernando Do Noronha", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7510), false, "SBFN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7510) },
                    { 63L, "Cangapara Airport", "Floriano", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7511), false, "SNQG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7512) },
                    { 64L, "Hercílio Luz International Airport", "Florianopolis", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7512), false, "SBFL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7513) },
                    { 65L, "Pinto Martins International Airport", "Fortaleza", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7513), false, "SBFZ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7514) },
                    { 66L, "Franca Airport", "Franca", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7514), false, "SIMK", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7515) },
                    { 67L, "Santo Ângelo Airport", "Santo Angelo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7516), false, "SBNM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7516) },
                    { 68L, "Rio Galeão – Tom Jobim International Airport", "Rio De Janeiro", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7517), false, "SBGL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7517) },
                    { 69L, "Guanambi Airport", "Guanambi", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7518), false, "SNGI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7518) },
                    { 70L, "Tancredo Thomas de Faria Airport", "Guarapuava", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7519), false, "SBGU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7519) },
                    { 71L, "Gurupi Airport", "Gurupi", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7520), false, "SWGI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7520) },
                    { 72L, "Guarulhos – Governador André Franco Montoro International Airport", "Sao Paulo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7521), false, "SBGR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7521) },
                    { 73L, "Guarapari Airport", "Guarapari", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7522), false, "SNGA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7522) },
                    { 74L, "Coronel Altino Machado de Oliveira Airport", "Governador Valadares", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7523), false, "SBGV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7524) },
                    { 75L, "Santa Genoveva Airport", "Goiania", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7524), false, "SBGO", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7525) },
                    { 76L, "Humaitá Airport", "Humaita", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7525), false, "SWHT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7526) },
                    { 77L, "Cataratas International Airport", "Foz Do Iguacu", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7526), false, "SBFI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7527) },
                    { 78L, "Prefeito Renato Moreira Airport", "Imperatriz", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7528), false, "SBIZ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7529) },
                    { 79L, "Bahia – Jorge Amado Airport", "Ilheus", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7529), false, "SBIL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7530) },
                    { 80L, "Usiminas Airport", "Ipatinga", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7559), false, "SBIP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7560) },
                    { 81L, "Tapuruquara Airport", "Santa Isabel do Rio Negro", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7561), false, "SWTP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7561) },
                    { 82L, "Itaituba Airport", "Itaituba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7562), false, "SBIH", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7562) },
                    { 83L, "Itaperuna Airport", "Itaperuna", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7563), false, "SDUN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7564) },
                    { 84L, "Zona da Mata Regional Airport", "Juiz de Fora", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7564), false, "SDZY", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7565) },
                    { 85L, "Santa Terezinha Airport", "Joacaba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7565), false, "SSJA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7566) }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 86L, "Francisco de Assis Airport", "Juiz De Fora", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7566), false, "SBJF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7567) },
                    { 87L, "Orlando Bezerra de Menezes Airport", "Juazeiro Do Norte", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7568), false, "SBJU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7568) },
                    { 88L, "Juína Airport", "Juina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7569), false, "SWJN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7569) },
                    { 89L, "Comandante Ariston Pessoa Airport", "Jericoacoara", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7570), false, "SSVV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7570) },
                    { 90L, "Lauro Carneiro de Loyola Airport", "Joinville", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7571), false, "SBJV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7572) },
                    { 91L, "Presidente Castro Pinto International Airport", "Joao Pessoa", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7572), false, "SBJP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7573) },
                    { 92L, "Ji-Paraná Airport", "Ji-Paraná", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7574), false, "SWJI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7574) },
                    { 93L, "Juruena Airport", "Juruena", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7575), false, "SWJU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7575) },
                    { 94L, "Bauru – Arealva Airport", "Bauru", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7576), false, "SJTC", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7576) },
                    { 95L, "Inácio Luís do Nascimento Airport", "Juara", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7577), false, "SIZX", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7577) },
                    { 96L, "Bom Jesus da Lapa Airport", "Bom Jesus Da Lapa", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7578), false, "SBLP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7578) },
                    { 97L, "Lábrea Airport", "Labrea", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7579), false, "SWLB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7580) },
                    { 98L, "Governador José Richa Airport", "Londrina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7580), false, "SBLO", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7581) },
                    { 99L, "Coronel Horácio de Mattos Airport", "Lençóis", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7581), false, "SBLE", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7582) },
                    { 100L, "Lins Airport", "Lins", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7583), false, "SBLN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7583) },
                    { 101L, "Fazenda Colen Airport", "Lucas do Rio Verde", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7585), false, "SWFE", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7585) },
                    { 102L, "João Correa da Rocha Airport", "Maraba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7586), false, "SBMA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7586) },
                    { 103L, "Eduardo Gomes International Airport", "Manaus", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7587), false, "SBEG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7587) },
                    { 104L, "Maués Airport", "Maues", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7588), false, "SNZA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7588) },
                    { 105L, "Zumbi dos Palmares Airport", "Maceio", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7589), false, "SBMO", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7589) },
                    { 106L, "Monte Dourado Airport", "Almeirim", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7590), false, "SWMW", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7590) },
                    { 107L, "Frank Miloye Milenkowichi–Marília State Airport", "Marília", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7591), false, "SBML", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7591) },
                    { 108L, "Mário Ribeiro Airport", "Montes Claros", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7592), false, "SBMK", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7593) },
                    { 109L, "Monterey Regional Airport", "Monte Alegre", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7593), false, "SWAM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7594) },
                    { 110L, "Dix-Sept Rosado Airport", "Mossoro", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7594), false, "SNMU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7595) },
                    { 111L, "Mavi Gema Airport", "Caravelas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7595), false, "SNMU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7596) },
                    { 112L, "Mauá Airport", "Maua", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7601), false, "SBMW", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7601) },
                    { 113L, "Governador Aluízio Alves International Airport", "Natal", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7602), false, "SBNT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7602) },
                    { 114L, "Ourilandia do Norte Airport", "Ourilandia do Norte", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7603), false, "SBUA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7603) },
                    { 115L, "Presidente João Batista Figueiredo Airport", "Mirai", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7604), false, "SWNZ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7604) },
                    { 116L, "Ministro Victor Konder International Airport", "Navegantes", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7605), false, "SBNF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7606) },
                    { 117L, "Senadora Eunice Micheles Airport", "Sao Paulo De Olivenca", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7608), false, "SBHT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7608) },
                    { 118L, "Oriximiná Airport", "Oriximina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7609), false, "SWMW", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7609) },
                    { 119L, "North Canaan Airport", "North Canaan", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7610), false, "SWTP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7610) },
                    { 120L, "Osvaldo Vieira International Airport", "Osvaldo Vieira", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7611), false, "SBTC", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7612) },
                    { 121L, "Lauro Kurtz Airport", "Passo Fundo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7612), false, "SBPF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7613) },
                    { 122L, "Lauro Kurtz Airport", "Passo Fundo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7613), false, "SBPF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7614) },
                    { 123L, "Parnaíba-Prefeito Dr. João Silva Filho International Airport", "Parnaiba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7614), false, "SBPB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7615) },
                    { 124L, "Parintins Airport", "Parintins", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7616), false, "SNVS", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7617) },
                    { 125L, "Pampulha – Carlos Drummond de Andrade Airport", "Belo Horizonte", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7617), false, "SBBH", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7618) },
                    { 126L, "Ponta Porã International Airport", "Ponta Pora", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7619), false, "SBPP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7619) },
                    { 127L, "Brigadeiro Lysias Rodrigues Airport", "Palmas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7620), false, "SBPJ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7620) }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "Id", "AirportName", "City", "CreatedOn", "Deleted", "ICAO", "UpdatedOn" },
                values: new object[,]
                {
                    { 128L, "Senador Nilo Coelho Airport", "Petrolina", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7621), false, "SNZA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7621) },
                    { 129L, "Patos de Minas Airport", "Patos De Minas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7622), false, "SNPD", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7622) },
                    { 130L, "Senador Petronio Portella Airport", "Picos", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7623), false, "SNPL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7623) },
                    { 131L, "Viracopos International Airport", "Campinas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7624), false, "SBDN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7624) },
                    { 132L, "Viracopos International Airport", "Campinas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7625), false, "SBDN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7625) },
                    { 133L, "Presidente Prudente Airport", "Presidente Prudente", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7626), false, "SNPA", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7627) },
                    { 134L, "Presidente Castro Pinto Airport", "Praca", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7627), false, "SBPR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7628) },
                    { 135L, "São Carlos Airport", "Sao Carlos", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7629), false, "SBNF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7630) },
                    { 136L, "Leite Lopes Airport", "Ribeirao Preto", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7630), false, "SBRP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7631) },
                    { 137L, "Raramuri Airport", "Raramuri", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7631), false, "SNRP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7632) },
                    { 138L, "Plácido de Castro Airport", "Rio Branco", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7633), false, "SWRB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7633) },
                    { 139L, "Guararapes-Gilberto Freyre International Airport", "Recife", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7634), false, "SBRF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7634) },
                    { 140L, "Santa Maria Airport", "Santa Maria", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7635), false, "SBSM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7635) },
                    { 141L, "Rainforest Airport", "Rioja", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7636), false, "SWEK", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7636) },
                    { 142L, "Rio de Janeiro–Galeão International Airport", "Rio De Janeiro", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7637), false, "SBGL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7637) },
                    { 143L, "Maestro Marinho Franco Airport", "Rondonopolis", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7638), false, "SWTP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7638) },
                    { 144L, "Islas Malvinas International Airport", "Rosario", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7639), false, "SBRK", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7639) },
                    { 145L, "Santos Dumont Airport", "Rio De Janeiro", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7640), false, "SBRJ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7640) },
                    { 146L, "Marechal Cunha Machado International Airport", "Sao Luiz", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7641), false, "SBSL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7642) },
                    { 147L, "Sorriso Airport", "Sorriso", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7642), false, "SNAM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7643) },
                    { 148L, "Base Aérea de Santos Airport", "Santos", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7643), false, "SBRJ", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7644) },
                    { 149L, "Maestro Wilson Fonseca Airport", "Santarem", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7644), false, "SBSN", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7645) },
                    { 150L, "Santa Cruz do Xingu Airport", "Santa Cruz Do Xingu", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7646), false, "SNTF", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7646) },
                    { 151L, "São Félix do Xingu Airport", "Sao Felix Do Xingu", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7647), false, "SWSI", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7647) },
                    { 152L, "Serra do Cabral Airport", "Sao Luiz Gonzaga", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7648), false, "SNBR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7648) },
                    { 153L, "Trombetas Airport", "Trombetas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7649), false, "SNBR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7649) },
                    { 154L, "Toledo Airport", "Toledo", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7650), false, "SBTD", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7650) },
                    { 155L, "Tucuruí Airport", "Tucurui", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7651), false, "SBTU", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7651) },
                    { 156L, "Mário de Almeida Franco Airport", "Uberaba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7652), false, "SBUR", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7652) },
                    { 157L, "Ubatuba Airport", "Ubatuba", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7653), false, "SDUB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7653) },
                    { 158L, "Ten. Cel. Aviador César Bombonato Airport", "Uberlandia", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7654), false, "SBUL", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7654) },
                    { 159L, "Umuarama Airport", "Umuarama", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7655), false, "SSUM", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7656) },
                    { 160L, "Hotel Transamérica Airport", "Una", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7656), false, "SBTC", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7657) },
                    { 161L, "Rubem Berta Airport", "Uruguaiana", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7657), false, "SBUG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7658) },
                    { 162L, "Major Brigadeiro Trompowsky Airport", "Varginha", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7659), false, "SBVG", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7659) },
                    { 163L, "Valença Airport", "Valenca", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7660), false, "SNVB", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7660) },
                    { 164L, "Viracopos International Airport", "Campinas", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7661), false, "SBKP", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7661) },
                    { 165L, "Vitória da Conquista Airport", "Vitória Da Conquista", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7662), false, "SBQV", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7662) },
                    { 166L, "Eurico de Aguiar Salles Airport", "Vitoria", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7663), false, "SBVT", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7663) },
                    { 167L, "Vila Rica Airport", "Vila Rica", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7664), false, "SWVC", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7664) },
                    { 168L, "Serafin Enoss Bertaso Airport", "Chapeco", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7665), false, "SBCH", new DateTime(2023, 9, 18, 18, 8, 28, 926, DateTimeKind.Local).AddTicks(7665) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airport");
        }
    }
}
