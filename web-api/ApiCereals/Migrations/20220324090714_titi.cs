using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCereals.Migrations
{
    public partial class titi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Carbo",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fiber",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Potass",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Protein",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "toto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Sodium",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sugars",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitamins",
                table: "toto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Carbo",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Potass",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Sugars",
                table: "toto");

            migrationBuilder.DropColumn(
                name: "Vitamins",
                table: "toto");
        }
    }
}
