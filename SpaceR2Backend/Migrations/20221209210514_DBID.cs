using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    /// <inheritdoc />
    public partial class DBID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Launches",
                schema: "PD",
                table: "Launches");

            migrationBuilder.AddColumn<int>(
                name: "DBID",
                schema: "PD",
                table: "Launches",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launches",
                schema: "PD",
                table: "Launches",
                column: "DBID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Launches",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "DBID",
                schema: "PD",
                table: "Launches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launches",
                schema: "PD",
                table: "Launches",
                column: "Id");
        }
    }
}
