using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    /// <inheritdoc />
    public partial class LaunchAndPeopleModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NasaPoD",
                table: "NasaPoD");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "NasaPoD");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "NasaPoD",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NasaPoD",
                table: "NasaPoD",
                column: "title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NasaPoD",
                table: "NasaPoD");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "NasaPoD",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "NasaPoD",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NasaPoD",
                table: "NasaPoD",
                column: "Id");
        }
    }
}
