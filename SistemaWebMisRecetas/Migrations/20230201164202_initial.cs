using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Categoría = table.Column<string>(nullable: false),
                    Ingrediente = table.Column<string>(nullable: false),
                    Instruccion = table.Column<string>(nullable: false),
                    NombreAutor = table.Column<string>(maxLength: 50, nullable: false),
                    ApellidoAutor = table.Column<string>(maxLength: 50, nullable: false),
                    EdadAutor = table.Column<int>(nullable: false),
                    EmailAutor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
