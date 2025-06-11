using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College_Event_System_Final.Migrations
{
    /// <inheritdoc />
    public partial class AddEventRegistrationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRegistrations_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrations_EventId",
                table: "EventRegistrations",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventRegistrations");
        }
    }
}
