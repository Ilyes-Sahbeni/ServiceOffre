using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceOffre.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Intitule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Societe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbrPostes = table.Column<int>(type: "int", nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offre", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offre");
        }
    }
}
