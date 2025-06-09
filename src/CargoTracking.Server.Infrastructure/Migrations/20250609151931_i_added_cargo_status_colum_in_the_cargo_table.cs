using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTracking.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class i_added_cargo_status_colum_in_the_cargo_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cargoStatusEnum",
                table: "MyCargos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cargoStatusEnum",
                table: "MyCargos");
        }
    }
}
