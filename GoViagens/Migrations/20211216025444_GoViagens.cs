using Microsoft.EntityFrameworkCore.Migrations;

namespace GoViagens.Migrations
{
    public partial class GoViagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preço = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promocao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePromocao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDesconto = table.Column<double>(type: "float", nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promocao_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promocao_DestinoId",
                table: "Promocao",
                column: "DestinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promocao");

            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
