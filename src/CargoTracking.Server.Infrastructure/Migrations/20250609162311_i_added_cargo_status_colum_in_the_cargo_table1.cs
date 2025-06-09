using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTracking.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class i_added_cargo_status_colum_in_the_cargo_table1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cargoStatusEnum",
                table: "MyCargos",
                newName: "cargoStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cargoStatus",
                table: "MyCargos",
                newName: "cargoStatusEnum");
        }
    }
}
