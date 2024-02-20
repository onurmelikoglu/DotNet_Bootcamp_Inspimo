using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SehirId",
                table: "Doktorlar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UlkeId",
                table: "Doktorlar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ulkeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulkeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UlkeId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirler_Ulkeler_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulkeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_SehirId",
                table: "Doktorlar",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_UlkeId",
                table: "Doktorlar",
                column: "UlkeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirler_UlkeId",
                table: "Sehirler",
                column: "UlkeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktorlar_Sehirler_SehirId",
                table: "Doktorlar",
                column: "SehirId",
                principalTable: "Sehirler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktorlar_Ulkeler_UlkeId",
                table: "Doktorlar",
                column: "UlkeId",
                principalTable: "Ulkeler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktorlar_Sehirler_SehirId",
                table: "Doktorlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Doktorlar_Ulkeler_UlkeId",
                table: "Doktorlar");

            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Ulkeler");

            migrationBuilder.DropIndex(
                name: "IX_Doktorlar_SehirId",
                table: "Doktorlar");

            migrationBuilder.DropIndex(
                name: "IX_Doktorlar_UlkeId",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "SehirId",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "UlkeId",
                table: "Doktorlar");
        }
    }
}
