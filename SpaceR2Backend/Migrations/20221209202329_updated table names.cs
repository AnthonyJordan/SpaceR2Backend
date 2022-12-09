using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedtablenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Mission_Orbit_OrbitId",
                schema: "PD",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Pad_Location_LocationId",
                schema: "PD",
                table: "Pad");

            migrationBuilder.DropForeignKey(
                name: "FK_Rocket_Configuration_ConfigurationId",
                schema: "PD",
                table: "Rocket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                schema: "PD",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rocket",
                schema: "PD",
                table: "Rocket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pad",
                schema: "PD",
                table: "Pad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orbit",
                schema: "PD",
                table: "Orbit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mission",
                schema: "PD",
                table: "Mission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                schema: "PD",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaunchServiceProvider",
                schema: "PD",
                table: "LaunchServiceProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Configuration",
                schema: "PD",
                table: "Configuration");

            migrationBuilder.RenameTable(
                name: "Status",
                schema: "PD",
                newName: "Statuses",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Rocket",
                schema: "PD",
                newName: "Rockets",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Pad",
                schema: "PD",
                newName: "Pads",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Orbit",
                schema: "PD",
                newName: "Orbits",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Mission",
                schema: "PD",
                newName: "Missions",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Location",
                schema: "PD",
                newName: "Locations",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "LaunchServiceProvider",
                schema: "PD",
                newName: "LaunchServiceProviders",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Configuration",
                schema: "PD",
                newName: "Configurations",
                newSchema: "PD");

            migrationBuilder.RenameIndex(
                name: "IX_Rocket_ConfigurationId",
                schema: "PD",
                table: "Rockets",
                newName: "IX_Rockets_ConfigurationId");

            migrationBuilder.RenameIndex(
                name: "IX_Pad_LocationId",
                schema: "PD",
                table: "Pads",
                newName: "IX_Pads_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Mission_OrbitId",
                schema: "PD",
                table: "Missions",
                newName: "IX_Missions_OrbitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                schema: "PD",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rockets",
                schema: "PD",
                table: "Rockets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pads",
                schema: "PD",
                table: "Pads",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orbits",
                schema: "PD",
                table: "Orbits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Missions",
                schema: "PD",
                table: "Missions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                schema: "PD",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaunchServiceProviders",
                schema: "PD",
                table: "LaunchServiceProviders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configurations",
                schema: "PD",
                table: "Configurations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchServiceProviders_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches",
                column: "LaunchServiceProviderId",
                principalSchema: "PD",
                principalTable: "LaunchServiceProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Missions_MissionId",
                schema: "PD",
                table: "Launches",
                column: "MissionId",
                principalSchema: "PD",
                principalTable: "Missions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Pads_PadId",
                schema: "PD",
                table: "Launches",
                column: "PadId",
                principalSchema: "PD",
                principalTable: "Pads",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Rockets_RocketId",
                schema: "PD",
                table: "Launches",
                column: "RocketId",
                principalSchema: "PD",
                principalTable: "Rockets",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Statuses_StatusId",
                schema: "PD",
                table: "Launches",
                column: "StatusId",
                principalSchema: "PD",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Orbits_OrbitId",
                schema: "PD",
                table: "Missions",
                column: "OrbitId",
                principalSchema: "PD",
                principalTable: "Orbits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pads_Locations_LocationId",
                schema: "PD",
                table: "Pads",
                column: "LocationId",
                principalSchema: "PD",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Rockets_Configurations_ConfigurationId",
                schema: "PD",
                table: "Rockets",
                column: "ConfigurationId",
                principalSchema: "PD",
                principalTable: "Configurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchServiceProviders_LaunchServiceProviderId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Missions_MissionId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Pads_PadId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Rockets_RocketId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Statuses_StatusId",
                schema: "PD",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Orbits_OrbitId",
                schema: "PD",
                table: "Missions");

            migrationBuilder.DropForeignKey(
                name: "FK_Pads_Locations_LocationId",
                schema: "PD",
                table: "Pads");

            migrationBuilder.DropForeignKey(
                name: "FK_Rockets_Configurations_ConfigurationId",
                schema: "PD",
                table: "Rockets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                schema: "PD",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rockets",
                schema: "PD",
                table: "Rockets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pads",
                schema: "PD",
                table: "Pads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orbits",
                schema: "PD",
                table: "Orbits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Missions",
                schema: "PD",
                table: "Missions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                schema: "PD",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaunchServiceProviders",
                schema: "PD",
                table: "LaunchServiceProviders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Configurations",
                schema: "PD",
                table: "Configurations");

            migrationBuilder.RenameTable(
                name: "Statuses",
                schema: "PD",
                newName: "Status",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Rockets",
                schema: "PD",
                newName: "Rocket",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Pads",
                schema: "PD",
                newName: "Pad",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Orbits",
                schema: "PD",
                newName: "Orbit",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Missions",
                schema: "PD",
                newName: "Mission",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Locations",
                schema: "PD",
                newName: "Location",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "LaunchServiceProviders",
                schema: "PD",
                newName: "LaunchServiceProvider",
                newSchema: "PD");

            migrationBuilder.RenameTable(
                name: "Configurations",
                schema: "PD",
                newName: "Configuration",
                newSchema: "PD");

            migrationBuilder.RenameIndex(
                name: "IX_Rockets_ConfigurationId",
                schema: "PD",
                table: "Rocket",
                newName: "IX_Rocket_ConfigurationId");

            migrationBuilder.RenameIndex(
                name: "IX_Pads_LocationId",
                schema: "PD",
                table: "Pad",
                newName: "IX_Pad_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Missions_OrbitId",
                schema: "PD",
                table: "Mission",
                newName: "IX_Mission_OrbitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                schema: "PD",
                table: "Status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rocket",
                schema: "PD",
                table: "Rocket",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pad",
                schema: "PD",
                table: "Pad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orbit",
                schema: "PD",
                table: "Orbit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mission",
                schema: "PD",
                table: "Mission",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                schema: "PD",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaunchServiceProvider",
                schema: "PD",
                table: "LaunchServiceProvider",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configuration",
                schema: "PD",
                table: "Configuration",
                column: "Id");

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
                name: "FK_Mission_Orbit_OrbitId",
                schema: "PD",
                table: "Mission",
                column: "OrbitId",
                principalSchema: "PD",
                principalTable: "Orbit",
                principalColumn: "Id");

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
    }
}
