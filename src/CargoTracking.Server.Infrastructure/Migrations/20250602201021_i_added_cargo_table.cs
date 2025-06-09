using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTracking.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class i_added_cargo_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyCargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sender_FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sender_LastName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sender_Ssn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient_Ssn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoInformation_cargoType = table.Column<int>(type: "int", nullable: false),
                    CargoInformation_weight = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeleteUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCargos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyCargos");
        }
    }
}
