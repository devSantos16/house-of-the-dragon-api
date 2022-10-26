using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace house_of_the_dragon_api.Migrations
{
    public partial class CreateTablesTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    idBook = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.idBook);
                });

            migrationBuilder.CreateTable(
                name: "Dragons",
                columns: table => new
                {
                    IdDragon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragons", x => x.IdDragon);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    IdHouse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    home = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.IdHouse);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    IdCharacter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birth = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseIdhouse = table.Column<int>(type: "int", nullable: false),
                    DragonIdDragon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.IdCharacter);
                    table.ForeignKey(
                        name: "FK_Characters_Dragons_DragonIdDragon",
                        column: x => x.DragonIdDragon,
                        principalTable: "Dragons",
                        principalColumn: "IdDragon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Houses_HouseIdhouse",
                        column: x => x.HouseIdhouse,
                        principalTable: "Houses",
                        principalColumn: "IdHouse",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksCaracters",
                columns: table => new
                {
                    IdBookCharacter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookIdBook = table.Column<int>(type: "int", nullable: false),
                    CharacterIdCharacter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksCaracters", x => x.IdBookCharacter);
                    table.ForeignKey(
                        name: "FK_BooksCaracters_Books_BookIdBook",
                        column: x => x.BookIdBook,
                        principalTable: "Books",
                        principalColumn: "idBook",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksCaracters_Characters_CharacterIdCharacter",
                        column: x => x.CharacterIdCharacter,
                        principalTable: "Characters",
                        principalColumn: "IdCharacter",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksCaracters_BookIdBook",
                table: "BooksCaracters",
                column: "BookIdBook");

            migrationBuilder.CreateIndex(
                name: "IX_BooksCaracters_CharacterIdCharacter",
                table: "BooksCaracters",
                column: "CharacterIdCharacter");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DragonIdDragon",
                table: "Characters",
                column: "DragonIdDragon");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HouseIdhouse",
                table: "Characters",
                column: "HouseIdhouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksCaracters");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Dragons");

            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
