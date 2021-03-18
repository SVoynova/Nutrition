using Microsoft.EntityFrameworkCore.Migrations;

namespace Nutrition.Data.Migrations
{
    public partial class diarysetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCalcium",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalCalories",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalCarbohydrates",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalCholesterol",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalFat",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalFibre",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalPotassium",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalProtein",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalSodium",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalSugars",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalVitaminA",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "TotalVitaminC",
                table: "Diary");

            migrationBuilder.AddColumn<int>(
                name: "DiaryId",
                table: "Food",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastCalcium",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastCalories",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastCarbohydrates",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastCholesterol",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastFat",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastFibre",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastPotassium",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastProtein",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastSodium",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastSugars",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastVitaminA",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakfastVitaminC",
                table: "Diary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Food_DiaryId",
                table: "Food",
                column: "DiaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Diary_DiaryId",
                table: "Food",
                column: "DiaryId",
                principalTable: "Diary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Diary_DiaryId",
                table: "Food");

            migrationBuilder.DropIndex(
                name: "IX_Food_DiaryId",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "DiaryId",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "BreakfastCalcium",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastCalories",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastCarbohydrates",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastCholesterol",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastFat",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastFibre",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastPotassium",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastProtein",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastSodium",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastSugars",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastVitaminA",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "BreakfastVitaminC",
                table: "Diary");

            migrationBuilder.AddColumn<int>(
                name: "TotalCalcium",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCalories",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCarbohydrates",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCholesterol",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalFat",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalFibre",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPotassium",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalProtein",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalSodium",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalSugars",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalVitaminA",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalVitaminC",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
