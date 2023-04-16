using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace random_numbers.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "numbers_table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    text = table.Column<string>(type: "TEXT", nullable: false),
                    number = table.Column<int>(type: "INTEGER", nullable: false),
                    found = table.Column<bool>(type: "INTEGER", nullable: false),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    date = table.Column<string>(type: "TEXT", nullable: true),
                    year = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_numbers_table", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "numbers_table");
        }
    }
}
