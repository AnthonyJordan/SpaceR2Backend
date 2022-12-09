using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    /// <inheritdoc />
    public partial class fixedrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchServiceProvider_LaunchServiceProviderId",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Mission_MissionId",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Pad_PadId",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Rocket_RocketId",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Status_StatusId",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Pad_Location_LocationId",
                table: "Pad");

            migrationBuilder.DropForeignKey(
                name: "FK_Rocket_Configuration_ConfigurationId",
                table: "Rocket");

            migrationBuilder.EnsureSchema(
                name: "PD");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Status",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Rocket",
                newName: "Rocket",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "People",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Pad",
                newName: "Pad",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Orbit",
                newName: "Orbit",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "NasaPoD",
                newName: "NasaPoD",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Mission",
                newName: "Mission",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Location",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "LaunchServiceProvider",
                newName: "LaunchServiceProvider",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Launches",
                newName: "Launches",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Configuration",
                newName: "Configuration",
                newSchema: "PD");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchServiceProvider_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches",
                column: "LaunchServiceProviderId",
                principalSchema: "PD",
                principalTable: "LaunchServiceProvider",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Mission_MissionId",
                schema: "PD",
                table: "Launches",
                column: "MissionId",
                principalSchema: "PD",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Pad_PadId",
                schema: "PD",
                table: "Launches",
                column: "PadId",
                principalSchema: "PD",
                principalTable: "Pad",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Rocket_RocketId",
                schema: "PD",
                table: "Launches",
                column: "RocketId",
                principalSchema: "PD",
                principalTable: "Rocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Status_StatusId",
                schema: "PD",
                table: "Launches",
                column: "StatusId",
                principalSchema: "PD",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Pad_Location_LocationId",
                schema: "PD",
                table: "Pad",
                column: "LocationId",
                principalSchema: "PD",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Rocket_Configuration_ConfigurationId",
                schema: "PD",
                table: "Rocket",
                column: "ConfigurationId",
                principalSchema: "PD",
                principalTable: "Configuration",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchServiceProvider_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Mission_MissionId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Pad_PadId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Rocket_RocketId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Status_StatusId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Pad_Location_LocationId",
                schema: "PD",
                table: "Pad");

            migrationBuilder.DropForeignKey(
                name: "FK_Rocket_Configuration_ConfigurationId",
                schema: "PD",
                table: "Rocket");

            migrationBuilder.RenameTable(
                name: "Status",
                schema: "PD",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "Rocket",
                schema: "PD",
                newName: "Rocket");

            migrationBuilder.RenameTable(
                name: "People",
                schema: "PD",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "Pad",
                schema: "PD",
                newName: "Pad");

            migrationBuilder.RenameTable(
                name: "Orbit",
                schema: "PD",
                newName: "Orbit");

            migrationBuilder.RenameTable(
                name: "NasaPoD",
                schema: "PD",
                newName: "NasaPoD");

            migrationBuilder.RenameTable(
                name: "Mission",
                schema: "PD",
                newName: "Mission");

            migrationBuilder.RenameTable(
                name: "Location",
                schema: "PD",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "LaunchServiceProvider",
                schema: "PD",
                newName: "LaunchServiceProvider");

            migrationBuilder.RenameTable(
                name: "Launches",
                schema: "PD",
                newName: "Launches");

            migrationBuilder.RenameTable(
                name: "Configuration",
                schema: "PD",
                newName: "Configuration");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchServiceProvider_LaunchServiceProviderId",
                table: "Launches",
                column: "LaunchServiceProviderId",
                principalTable: "LaunchServiceProvider",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Mission_MissionId",
                table: "Launches",
                column: "MissionId",
                principalTable: "Mission",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Pad_PadId",
                table: "Launches",
                column: "PadId",
                principalTable: "Pad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Rocket_RocketId",
                table: "Launches",
                column: "RocketId",
                principalTable: "Rocket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Status_StatusId",
                table: "Launches",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pad_Location_LocationId",
                table: "Pad",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rocket_Configuration_ConfigurationId",
                table: "Rocket",
                column: "ConfigurationId",
                principalTable: "Configuration",
                principalColumn: "Id");
        }
    }
}
