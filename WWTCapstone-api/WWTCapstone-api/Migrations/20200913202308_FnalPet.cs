using Microsoft.EntityFrameworkCore.Migrations;

namespace WWTCapstone_api.Migrations
{
    public partial class FnalPet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodRoutine",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "PrefferedVet",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "VetPhoneNumber",
                table: "Pet");

            migrationBuilder.AddColumn<string>(
                name: "PreferredVet",
                table: "Pet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Routines",
                table: "Pet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VetPhoneNum",
                table: "Pet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreferredVet",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Routines",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "VetPhoneNum",
                table: "Pet");

            migrationBuilder.AddColumn<string>(
                name: "FoodRoutine",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrefferedVet",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VetPhoneNumber",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
