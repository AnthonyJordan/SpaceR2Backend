using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    /// <inheritdoc />
    public partial class Newmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Family = table.Column<string>(type: "TEXT", nullable: true),
                    Fullname = table.Column<string>(name: "Full_name", type: "TEXT", nullable: true),
                    Variant = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaunchServiceProvider",
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
                    table.PrimaryKey("PK_LaunchServiceProvider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    countrycode = table.Column<string>(name: "country_code", type: "TEXT", nullable: true),
                    mapimage = table.Column<string>(name: "map_image", type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orbit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Abbrev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orbit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Craft = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Abbrev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rocket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConfigurationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rocket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rocket_Configuration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configuration",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Wikiurl = table.Column<string>(name: "Wiki_url", type: "TEXT", nullable: true),
                    Mapurl = table.Column<string>(name: "Map_url", type: "TEXT", nullable: true),
                    Mapimage = table.Column<string>(name: "Map_image", type: "TEXT", nullable: true),
                    Longitude = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<string>(type: "TEXT", nullable: true),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pad_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Launchdesignator = table.Column<string>(name: "Launch_designator", type: "TEXT", nullable: true),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    OrbitId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mission_Orbit_OrbitId",
                        column: x => x.OrbitId,
                        principalTable: "Orbit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Launches",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: true),
                    Lastupdated = table.Column<string>(name: "Last_updated", type: "TEXT", nullable: true),
                    Windowstart = table.Column<string>(name: "Window_start", type: "TEXT", nullable: true),
                    Windowend = table.Column<string>(name: "Window_end", type: "TEXT", nullable: true),
                    LaunchServiceProviderId = table.Column<int>(type: "INTEGER", nullable: true),
                    RocketId = table.Column<int>(type: "INTEGER", nullable: true),
                    MissionId = table.Column<int>(type: "INTEGER", nullable: true),
                    PadId = table.Column<int>(type: "INTEGER", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Launches_LaunchServiceProvider_LaunchServiceProviderId",
                        column: x => x.LaunchServiceProviderId,
                        principalTable: "LaunchServiceProvider",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Launches_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Launches_Pad_PadId",
                        column: x => x.PadId,
                        principalTable: "Pad",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Launches_Rocket_RocketId",
                        column: x => x.RocketId,
                        principalTable: "Rocket",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Launches_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Launches_LaunchServiceProviderId",
                table: "Launches",
                column: "LaunchServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_MissionId",
                table: "Launches",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_PadId",
                table: "Launches",
                column: "PadId");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_RocketId",
                table: "Launches",
                column: "RocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_StatusId",
                table: "Launches",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_OrbitId",
                table: "Mission",
                column: "OrbitId");

            migrationBuilder.CreateIndex(
                name: "IX_Pad_LocationId",
                table: "Pad",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rocket_ConfigurationId",
                table: "Rocket",
                column: "ConfigurationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Launches");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "LaunchServiceProvider");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Pad");

            migrationBuilder.DropTable(
                name: "Rocket");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Orbit");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Configuration");
        }
    }
}
