using Microsoft.EntityFrameworkCore.Migrations;

namespace Nutrition.Data.Migrations
{
    public partial class usersetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BMR",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CarbohydratesPercentage",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyCalcium",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyCalorieNeeds",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyCholesterol",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyFibre",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyPotassium",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailySodium",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailySugars",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyVitaminC",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyWater",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FatPercentage",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProteinPercentage",
                table: "User");

            migrationBuilder.AlterColumn<double>(
                name: "DailyVitaminA",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DailyVitaminA",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "BMR",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Carbohydrates",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarbohydratesPercentage",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyCalcium",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyCalorieNeeds",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyCholesterol",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyFibre",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyPotassium",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailySodium",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailySugars",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyVitaminC",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "DailyWater",
                table: "User",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "FatPercentage",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fats",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Protein",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProteinPercentage",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
