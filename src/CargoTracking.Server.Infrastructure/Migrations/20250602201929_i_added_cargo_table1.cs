using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTracking.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class i_added_cargo_table1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_ZipCode",
                table: "MyCargos",
                newName: "DeliveryAddress_ZipCode");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "MyCargos",
                newName: "DeliveryAddress_Street");

            migrationBuilder.RenameColumn(
                name: "Address_State",
                table: "MyCargos",
                newName: "DeliveryAddress_State");

            migrationBuilder.RenameColumn(
                name: "Address_County",
                table: "MyCargos",
                newName: "DeliveryAddress_County");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "MyCargos",
                newName: "DeliveryAddress_City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeliveryAddress_ZipCode",
                table: "MyCargos",
                newName: "Address_ZipCode");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress_Street",
                table: "MyCargos",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress_State",
                table: "MyCargos",
                newName: "Address_State");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress_County",
                table: "MyCargos",
                newName: "Address_County");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress_City",
                table: "MyCargos",
                newName: "Address_City");
        }
    }
}
