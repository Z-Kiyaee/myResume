using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resume.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class changethenameofmyLanguagestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_myLanguages",
                table: "myLanguages");

            migrationBuilder.RenameTable(
                name: "myLanguages",
                newName: "MyLanguages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyLanguages",
                table: "MyLanguages",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyLanguages",
                table: "MyLanguages");

            migrationBuilder.RenameTable(
                name: "MyLanguages",
                newName: "myLanguages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_myLanguages",
                table: "myLanguages",
                column: "Id");
        }
    }
}
