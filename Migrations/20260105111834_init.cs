using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Elektronik ürünler", "Elektronik" },
                    { 2, "Bilgisayar ve aksesuarları", "Bilgisayar" },
                    { 3, "Akıllı telefonlar", "Telefon" },
                    { 4, "Beyaz eşya ve küçük ev aletleri", "Ev Aletleri" },
                    { 5, "Kitap ve dergiler", "Kitap" },
                    { 6, "Kadın ve erkek giyim", "Giyim" },
                    { 7, "Spor ve klasik ayakkabılar", "Ayakkabı" },
                    { 8, "Spor malzemeleri", "Spor" },
                    { 9, "Kozmetik ve kişisel bakım", "Kozmetik" },
                    { 10, "Çocuk oyuncakları", "Oyuncak" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
