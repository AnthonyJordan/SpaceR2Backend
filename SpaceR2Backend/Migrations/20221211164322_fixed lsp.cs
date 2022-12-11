using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    /// <inheritdoc />
    public partial class fixedlsp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchServiceProviders_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropTable(
                name: "LaunchServiceProviders",
                schema: "PD");

            migrationBuilder.RenameColumn(
                name: "LaunchServiceProviderId",
                schema: "PD",
                table: "Launches",
                newName: "Launch_Service_ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches",
                newName: "IX_Launches_Launch_Service_ProviderId");

            migrationBuilder.CreateTable(
                name: "Launch_Service_Providers",
                schema: "PD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launch_Service_Providers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Launch_Service_Providers_Launch_Service_ProviderId",
                schema: "PD",
                table: "Launches",
                column: "Launch_Service_ProviderId",
                principalSchema: "PD",
                principalTable: "Launch_Service_Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Launch_Service_Providers_Launch_Service_ProviderId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropTable(
                name: "Launch_Service_Providers",
                schema: "PD");

            migrationBuilder.RenameColumn(
                name: "Launch_Service_ProviderId",
                schema: "PD",
                table: "Launches",
                newName: "LaunchServiceProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_Launch_Service_ProviderId",
                schema: "PD",
                table: "Launches",
                newName: "IX_Launches_LaunchServiceProviderId");

            migrationBuilder.CreateTable(
                name: "LaunchServiceProviders",
                schema: "PD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchServiceProviders", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchServiceProviders_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches",
                column: "LaunchServiceProviderId",
                principalSchema: "PD",
                principalTable: "LaunchServiceProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
