using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speaker1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speaker2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speaker3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speaker4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}
