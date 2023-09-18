using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Context.Repo
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }
            modelBuilder.Entity<Cities>();
            modelBuilder.Entity<CitySearch>();
            modelBuilder.Entity<CitiesWeatherForecast>();
            modelBuilder.Entity<AirportWeatherForecast>();

            modelBuilder.Entity<Log>();
            modelBuilder.Entity<Airport>().HasData(
                new Airport { Id = 1, ICAO = "SBAX", AirportName = "Romeu Zema Airport", City = "Araxa" },
                new Airport { Id = 2, ICAO = "SBAT", AirportName = "Piloto Osvaldo Marques Dias Airport", City = "Alta Floresta" },
                new Airport { Id = 3, ICAO = "SWRP", AirportName = "Aripuanã Airport", City = "Aripuana" },
                new Airport { Id = 4, ICAO = "SBAR", AirportName = "Santa Maria Airport", City = "Aracaju" },
                new Airport { Id = 5, ICAO = "SNAL", AirportName = "Arapiraca Airport", City = "Arapiraca" },
                new Airport { Id = 6, ICAO = "SBAQ", AirportName = "Araraquara Airport", City = "Araracuara" },
                new Airport { Id = 7, ICAO = "SBAU", AirportName = "Araçatuba Airport", City = "Aracatuba" },
                new Airport { Id = 8, ICAO = "SBHT", AirportName = "Altamira Airport", City = "Altamira" },
                new Airport { Id = 9, ICAO = "SWGN", AirportName = "Araguaína Airport", City = "Araguaina" },
                new Airport { Id = 10, ICAO = "SBBT", AirportName = "Chafei Amsei Airport", City = "Barretos" },
                new Airport { Id = 11, ICAO = "SBBU", AirportName = "Bauru Airport", City = "Bauru" },
                new Airport { Id = 12, ICAO = "SWBC", AirportName = "Barcelos Airport", City = "Barcelos" },
                new Airport { Id = 13, ICAO = "SBBE", AirportName = "Val de Cans/Júlio Cezar Ribeiro International Airport", City = "Belem" },
                new Airport { Id = 14, ICAO = "SBBI", AirportName = "Bacacheri Airport", City = "Curitiba" },
                new Airport { Id = 15, ICAO = "SBBG", AirportName = "Comandante Gustavo Kraemer Airport", City = "Bage" },
                new Airport { Id = 16, ICAO = "SBBP", AirportName = "Estadual Arthur Siqueira Airport", City = "Braganca Paulista" },
                new Airport { Id = 17, ICAO = "SSBL", AirportName = "Blumenau Airport", City = "BLUMENAU" },
                new Airport { Id = 18, ICAO = "SBPS", AirportName = "Porto Seguro Airport", City = "Porto Seguro" },
                new Airport { Id = 19, ICAO = "SNBR", AirportName = "Barreiras Airport", City = "Barreiras" },
                new Airport { Id = 20, ICAO = "SBBR", AirportName = "Presidente Juscelino Kubistschek International Airport", City = "Brasilia" },
                new Airport { Id = 21, ICAO = "SBBV", AirportName = "Atlas Brasil Cantanhede Airport", City = "Boa Vista" },
                new Airport { Id = 22, ICAO = "SBVH", AirportName = "Brigadeiro Camarão Airport", City = "Vilhena" },
                new Airport { Id = 23, ICAO = "SNVS", AirportName = "Breves Airport", City = "Breves" },
                new Airport { Id = 24, ICAO = "SJDB", AirportName = "Bonito Airport", City = "Bointo" },
                new Airport { Id = 25, ICAO = "SBBZ", AirportName = "Umberto Modiano Airport", City = "Buzios" },
                new Airport { Id = 26, ICAO = "SBCA", AirportName = "Cascavel Airport", City = "Cascavel" },
                new Airport { Id = 27, ICAO = "SWCA", AirportName = "Carauari Airport", City = "Carauari" },
                new Airport { Id = 28, ICAO = "SNRU", AirportName = "Caruaru Airport", City = "Caruaru" },
                new Airport { Id = 29, ICAO = "SBCP", AirportName = "Bartolomeu Lisandro Airport", City = "Campos" },
                new Airport { Id = 31, ICAO = "SSCK", AirportName = "Concórdia Airport", City = "Concordia" },
                new Airport { Id = 32, ICAO = "SBCM", AirportName = "Diomício Freitas Airport", City = "Criciuma" },
                new Airport { Id = 33, ICAO = "SWKC", AirportName = "Cáceres Airport", City = "Caceres" },
                new Airport { Id = 34, ICAO = "SBAA", AirportName = "Conceição do Araguaia Airport", City = "Conceicao Do Araguaia" },
                new Airport { Id = 35, ICAO = "SBCB", AirportName = "Cabo Frio Airport", City = "Cabo Frio" },
                new Airport { Id = 36, ICAO = "SBCD", AirportName = "Caçador Airport", City = "Cacador" },
                new Airport { Id = 37, ICAO = "SJHG", AirportName = "Confresa Airport", City = "Confresa" },
                new Airport { Id = 38, ICAO = "SBCY", AirportName = "Marechal Rondon Airport", City = "Cuiaba" },
                new Airport { Id = 39, ICAO = "SBSP", AirportName = "Congonhas – Deputado Freitas Nobre Airport", City = "Sao Paulo" },
                new Airport { Id = 40, ICAO = "SBCG", AirportName = "Campo Grande Airport", City = "Campo Grande" },
                new Airport { Id = 41, ICAO = "SWKO", AirportName = "Coari Airport", City = "Coari" },
                new Airport { Id = 42, ICAO = "SBCJ", AirportName = "Carajás Airport", City = "Parauapebas" },
                new Airport { Id = 43, ICAO = "SBCI", AirportName = "Brig. Lysias Augusto Rodrigues Airport", City = "Carolina" },
                new Airport { Id = 44, ICAO = "SBCN", AirportName = "Nelson Ribeiro Guimarães Airport", City = "Caldas Novas" },
                new Airport { Id = 45, ICAO = "SBCR", AirportName = "Corumbá International Airport", City = "Corumba" },
                new Airport { Id = 46, ICAO = "SNKE", AirportName = "Santana do Araguaia Airport", City = "Santana do Araguaia" },
                new Airport { Id = 47, ICAO = "SBCF", AirportName = "Tancredo Neves International Airport", City = "Belo Horizonte" },
                new Airport { Id = 48, ICAO = "SDAM", AirportName = "Amarais Airport", City = "Campinas" },
                new Airport { Id = 49, ICAO = "SBKG", AirportName = "Presidente João Suassuna Airport", City = "Campina Grande" },
                new Airport { Id = 50, ICAO = "SBCV", AirportName = "Caravelas Airport", City = "Caravelas" },
                new Airport { Id = 51, ICAO = "SBCT", AirportName = "Afonso Pena Airport", City = "Curitiba" },
                new Airport { Id = 52,ICAO = "SBCX",AirportName = "Hugo Cantergiani Regional Airport",City ="Caxias Do Sul" },
                new Airport { Id = 53, ICAO = "SBCZ", AirportName = "Cruzeiro do Sul Airport", City = "Cruzeiro do Sul" },
                new Airport { Id = 54, ICAO = "SNDV", AirportName = "Brigadeiro Cabral Airport", City = "Divinopolis" },
                new Airport { Id = 55, ICAO = "SWDM", AirportName = "Diamantino Airport", City = "Diamantino" },
                new Airport { Id = 56, ICAO = "SSDO", AirportName = "Dourados Airport", City = "Dourados" },
                new Airport { Id = 57, ICAO = "SNDT", AirportName = "Diamantina Airport", City = "Diamantina" },
                new Airport { Id = 58, ICAO = "SSER", AirportName = "Erechim Airport", City = "Erechim" },
                new Airport { Id = 59, ICAO = "SWEI", AirportName = "Eirunepé Airport", City = "Eirunepe" },
                new Airport { Id = 60, ICAO = "SWOB", AirportName = "Fonte Boa Airport", City = "Fonte Boa" },
                new Airport { Id = 61, ICAO = "SSFB", AirportName = "Francisco Beltrão Airport", City = "Francisco Beltrao" },
                new Airport { Id = 62, ICAO = "SBFN", AirportName = "Fernando de Noronha Airport", City = "Fernando Do Noronha" },
                new Airport { Id = 63, ICAO = "SNQG", AirportName = "Cangapara Airport", City = "Floriano" },
                new Airport { Id = 64, ICAO = "SBFL", AirportName = "Hercílio Luz International Airport", City = "Florianopolis" },
                new Airport { Id = 65, ICAO = "SBFZ", AirportName = "Pinto Martins International Airport", City = "Fortaleza" },
                new Airport { Id = 66, ICAO = "SIMK", AirportName = "Franca Airport", City = "Franca" },
                new Airport { Id = 67, ICAO = "SBNM", AirportName = "Santo Ângelo Airport", City = "Santo Angelo" },
                new Airport { Id = 68, ICAO = "SBGL", AirportName = "Rio Galeão – Tom Jobim International Airport", City = "Rio De Janeiro" },
                new Airport { Id = 69, ICAO = "SNGI", AirportName = "Guanambi Airport", City = "Guanambi" },
                new Airport { Id = 70, ICAO = "SBGU", AirportName = "Tancredo Thomas de Faria Airport", City = "Guarapuava" },
                new Airport { Id = 71, ICAO = "SWGI", AirportName = "Gurupi Airport", City = "Gurupi" },
                new Airport { Id = 72, ICAO = "SBGR", AirportName = "Guarulhos – Governador André Franco Montoro International Airport", City = "Sao Paulo" },
                new Airport { Id = 73, ICAO = "SNGA", AirportName = "Guarapari Airport", City = "Guarapari" },
                new Airport { Id = 74, ICAO = "SBGV", AirportName = "Coronel Altino Machado de Oliveira Airport", City = "Governador Valadares" },
                new Airport { Id = 75, ICAO = "SBGO", AirportName = "Santa Genoveva Airport", City = "Goiania" },
                new Airport { Id = 76, ICAO = "SWHT", AirportName = "Humaitá Airport", City = "Humaita" },
                new Airport { Id = 77, ICAO = "SBFI", AirportName = "Cataratas International Airport", City = "Foz Do Iguacu" },
                new Airport { Id = 78, ICAO = "SBIZ", AirportName = "Prefeito Renato Moreira Airport", City = "Imperatriz" },
                new Airport { Id = 79, ICAO = "SBIL", AirportName = "Bahia – Jorge Amado Airport", City = "Ilheus" },
                new Airport { Id = 80, ICAO = "SBIP", AirportName = "Usiminas Airport", City = "Ipatinga" },
                new Airport { Id = 81, ICAO = "SWTP", AirportName = "Tapuruquara Airport", City = "Santa Isabel do Rio Negro" },
                new Airport { Id = 82, ICAO = "SBIH", AirportName = "Itaituba Airport", City = "Itaituba" },
                new Airport { Id = 83, ICAO = "SDUN", AirportName = "Itaperuna Airport", City = "Itaperuna" },
                new Airport { Id = 84, ICAO = "SDZY", AirportName = "Zona da Mata Regional Airport", City = "Juiz de Fora" },
                new Airport { Id = 85, ICAO = "SSJA", AirportName = "Santa Terezinha Airport", City = "Joacaba" },
                new Airport { Id = 86, ICAO = "SBJF", AirportName = "Francisco de Assis Airport", City = "Juiz De Fora" },
                new Airport { Id = 87, ICAO = "SBJU", AirportName = "Orlando Bezerra de Menezes Airport", City = "Juazeiro Do Norte" },
                new Airport { Id = 88, ICAO = "SWJN", AirportName = "Juína Airport", City = "Juina" },
                new Airport { Id = 89, ICAO = "SSVV", AirportName = "Comandante Ariston Pessoa Airport", City = "Jericoacoara" },
                new Airport { Id = 90, ICAO = "SBJV", AirportName = "Lauro Carneiro de Loyola Airport", City = "Joinville" },
                new Airport { Id = 91, ICAO = "SBJP", AirportName = "Presidente Castro Pinto International Airport", City = "Joao Pessoa" },
                new Airport { Id = 92, ICAO = "SWJI", AirportName = "Ji-Paraná Airport", City = "Ji-Paraná" },
                new Airport { Id = 93, ICAO = "SWJU", AirportName = "Juruena Airport", City = "Juruena" },
                new Airport { Id = 94, ICAO = "SJTC", AirportName = "Bauru – Arealva Airport", City = "Bauru" },
                new Airport { Id = 95, ICAO = "SIZX", AirportName = "Inácio Luís do Nascimento Airport", City = "Juara" },
                new Airport { Id = 96, ICAO = "SBLP", AirportName = "Bom Jesus da Lapa Airport", City = "Bom Jesus Da Lapa" },
                new Airport { Id = 97, ICAO = "SWLB", AirportName = "Lábrea Airport", City = "Labrea" },
                new Airport { Id = 98, ICAO = "SBLO", AirportName = "Governador José Richa Airport", City = "Londrina" },
                new Airport { Id = 99, ICAO = "SBLE", AirportName = "Coronel Horácio de Mattos Airport", City = "Lençóis" },
                new Airport { Id = 100, ICAO = "SBLN", AirportName = "Lins Airport", City = "Lins" },
                new Airport { Id = 101, ICAO = "SWFE", AirportName = "Fazenda Colen Airport", City = "Lucas do Rio Verde" },
                new Airport { Id = 102, ICAO = "SBMA", AirportName = "João Correa da Rocha Airport", City = "Maraba" },
                new Airport { Id = 103, ICAO = "SBEG", AirportName = "Eduardo Gomes International Airport", City = "Manaus" },
                new Airport { Id = 104, ICAO = "SNZA", AirportName = "Maués Airport", City = "Maues" },
                new Airport { Id = 105, ICAO = "SBMO", AirportName = "Zumbi dos Palmares Airport", City = "Maceio" },
                new Airport { Id = 106, ICAO = "SWMW", AirportName = "Monte Dourado Airport", City = "Almeirim" },
                new Airport { Id = 107, ICAO = "SBML", AirportName = "Frank Miloye Milenkowichi–Marília State Airport", City = "Marília" },
                new Airport { Id = 108, ICAO = "SBMK", AirportName = "Mário Ribeiro Airport", City = "Montes Claros" },
                new Airport { Id = 109, ICAO = "SWAM", AirportName = "Monterey Regional Airport", City = "Monte Alegre" },
                new Airport { Id = 110, ICAO = "SNMU", AirportName = "Dix-Sept Rosado Airport", City = "Mossoro" },
                new Airport { Id = 111, ICAO = "SNMU", AirportName = "Mavi Gema Airport", City = "Caravelas" },
                new Airport { Id = 112, ICAO = "SBMW", AirportName = "Mauá Airport", City = "Maua" },
                new Airport { Id = 113, ICAO = "SBNT", AirportName = "Governador Aluízio Alves International Airport", City = "Natal" },
                new Airport { Id = 114, ICAO = "SBUA", AirportName = "Ourilandia do Norte Airport", City = "Ourilandia do Norte" },
                new Airport { Id = 115, ICAO = "SWNZ", AirportName = "Presidente João Batista Figueiredo Airport", City = "Mirai" },
                new Airport { Id = 116, ICAO = "SBNF", AirportName = "Ministro Victor Konder International Airport", City = "Navegantes" },
                new Airport { Id = 117, ICAO = "SBHT", AirportName = "Senadora Eunice Micheles Airport", City = "Sao Paulo De Olivenca" },
                new Airport { Id = 118, ICAO = "SWMW", AirportName = "Oriximiná Airport", City = "Oriximina" },
                new Airport { Id = 119, ICAO = "SWTP", AirportName = "North Canaan Airport", City = "North Canaan" },
                new Airport { Id = 120, ICAO = "SBTC", AirportName = "Osvaldo Vieira International Airport", City = "Osvaldo Vieira" },
                new Airport { Id = 121, ICAO = "SBPF", AirportName = "Lauro Kurtz Airport", City = "Passo Fundo" },
                new Airport { Id = 122, ICAO = "SBPF", AirportName = "Lauro Kurtz Airport", City = "Passo Fundo" },
                new Airport { Id = 123, ICAO = "SBPB", AirportName = "Parnaíba-Prefeito Dr. João Silva Filho International Airport", City = "Parnaiba" },
                new Airport { Id = 124, ICAO = "SNVS", AirportName = "Parintins Airport", City = "Parintins" },
                new Airport { Id = 125, ICAO = "SBBH", AirportName = "Pampulha – Carlos Drummond de Andrade Airport", City = "Belo Horizonte" },
                new Airport { Id = 126, ICAO = "SBPP", AirportName = "Ponta Porã International Airport", City = "Ponta Pora" },
                new Airport { Id = 127, ICAO = "SBPJ", AirportName = "Brigadeiro Lysias Rodrigues Airport", City = "Palmas" },
                new Airport { Id = 128, ICAO = "SNZA", AirportName = "Senador Nilo Coelho Airport", City = "Petrolina" },
                new Airport { Id = 129, ICAO = "SNPD", AirportName = "Patos de Minas Airport", City = "Patos De Minas" },
                new Airport { Id = 130, ICAO = "SNPL", AirportName = "Senador Petronio Portella Airport", City = "Picos" },
                new Airport { Id = 131, ICAO = "SBDN", AirportName = "Viracopos International Airport", City = "Campinas" },
                new Airport { Id = 132, ICAO = "SBDN", AirportName = "Viracopos International Airport", City = "Campinas" },
                new Airport { Id = 133, ICAO = "SNPA", AirportName = "Presidente Prudente Airport", City = "Presidente Prudente" },
                new Airport { Id = 134, ICAO = "SBPR", AirportName = "Presidente Castro Pinto Airport", City = "Praca" },
                new Airport { Id = 135, ICAO = "SBNF", AirportName = "São Carlos Airport", City = "Sao Carlos" },
                new Airport { Id = 136, ICAO = "SBRP", AirportName = "Leite Lopes Airport", City = "Ribeirao Preto" },
                new Airport { Id = 137, ICAO = "SNRP", AirportName = "Raramuri Airport", City = "Raramuri" },
                new Airport { Id = 138, ICAO = "SWRB", AirportName = "Plácido de Castro Airport", City = "Rio Branco" },
                new Airport { Id = 139, ICAO = "SBRF", AirportName = "Guararapes-Gilberto Freyre International Airport", City = "Recife" },
                new Airport { Id = 140, ICAO = "SBSM", AirportName = "Santa Maria Airport", City = "Santa Maria" },
                new Airport { Id = 141, ICAO = "SWEK", AirportName = "Rainforest Airport", City = "Rioja" },
                new Airport { Id = 142, ICAO = "SBGL", AirportName = "Rio de Janeiro–Galeão International Airport", City = "Rio De Janeiro" },
                new Airport { Id = 143, ICAO = "SWTP", AirportName = "Maestro Marinho Franco Airport", City = "Rondonopolis" },
                new Airport { Id = 144, ICAO = "SBRK", AirportName = "Islas Malvinas International Airport", City = "Rosario" },
                new Airport { Id = 145, ICAO = "SBRJ", AirportName = "Santos Dumont Airport", City = "Rio De Janeiro" },
                new Airport { Id = 146, ICAO = "SBSL", AirportName = "Marechal Cunha Machado International Airport", City = "Sao Luiz" },
                new Airport { Id = 147, ICAO = "SNAM", AirportName = "Sorriso Airport", City = "Sorriso" },
                new Airport { Id = 148, ICAO = "SBRJ", AirportName = "Base Aérea de Santos Airport", City = "Santos" },
                new Airport { Id = 149, ICAO = "SBSN", AirportName = "Maestro Wilson Fonseca Airport", City = "Santarem" },
                new Airport { Id = 150, ICAO = "SNTF", AirportName = "Santa Cruz do Xingu Airport", City = "Santa Cruz Do Xingu" },
                new Airport { Id = 151, ICAO = "SWSI", AirportName = "São Félix do Xingu Airport", City = "Sao Felix Do Xingu" },
                new Airport { Id = 152, ICAO = "SNBR", AirportName = "Serra do Cabral Airport", City = "Sao Luiz Gonzaga" },
                new Airport { Id = 153, ICAO = "SNBR", AirportName = "Trombetas Airport", City = "Trombetas" },
                new Airport { Id = 154, ICAO = "SBTD", AirportName = "Toledo Airport", City = "Toledo" },
                new Airport { Id = 155, ICAO = "SBTU", AirportName = "Tucuruí Airport", City = "Tucurui" },
                new Airport { Id = 156, ICAO = "SBUR", AirportName = "Mário de Almeida Franco Airport", City = "Uberaba" },
                new Airport { Id = 157, ICAO = "SDUB", AirportName = "Ubatuba Airport", City = "Ubatuba" },
                new Airport { Id = 158, ICAO = "SBUL", AirportName = "Ten. Cel. Aviador César Bombonato Airport", City = "Uberlandia" },
                new Airport { Id = 159, ICAO = "SSUM", AirportName = "Umuarama Airport", City = "Umuarama" },
                new Airport { Id = 160, ICAO = "SBTC", AirportName = "Hotel Transamérica Airport", City = "Una" },
                new Airport { Id = 161, ICAO = "SBUG", AirportName = "Rubem Berta Airport", City = "Uruguaiana" },
                new Airport { Id = 162, ICAO = "SBVG", AirportName = "Major Brigadeiro Trompowsky Airport", City = "Varginha" },
                new Airport { Id = 163, ICAO = "SNVB", AirportName = "Valença Airport", City = "Valenca" },
                new Airport { Id = 164, ICAO = "SBKP", AirportName = "Viracopos International Airport", City = "Campinas" },
                new Airport { Id = 165, ICAO = "SBQV", AirportName = "Vitória da Conquista Airport", City = "Vitória Da Conquista" },
                new Airport { Id = 166, ICAO = "SBVT", AirportName = "Eurico de Aguiar Salles Airport", City = "Vitoria" },
                new Airport { Id = 167, ICAO = "SWVC", AirportName = "Vila Rica Airport", City = "Vila Rica" },
                new Airport { Id = 168, ICAO = "SBCH", AirportName = "Serafin Enoss Bertaso Airport", City = "Chapeco" });

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<CitySearch> CitiesSearch { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<CitiesWeatherForecast> CitiesWeatherForecast { get; set; }
        public DbSet<AirportWeatherForecast> AirportWeatherForecast { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}
