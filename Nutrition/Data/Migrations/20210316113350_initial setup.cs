using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nutrition.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Water = table.Column<int>(nullable: false),
                    TotalCalories = table.Column<int>(nullable: false),
                    TotalProtein = table.Column<int>(nullable: false),
                    TotalCarbohydrates = table.Column<int>(nullable: false),
                    TotalFat = table.Column<int>(nullable: false),
                    TotalFibre = table.Column<int>(nullable: false),
                    TotalSugars = table.Column<int>(nullable: false),
                    TotalSodium = table.Column<int>(nullable: false),
                    TotalPotassium = table.Column<int>(nullable: false),
                    TotalCholesterol = table.Column<int>(nullable: false),
                    TotalVitaminA = table.Column<int>(nullable: false),
                    TotalVitaminC = table.Column<int>(nullable: false),
                    TotalCalcium = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealCalories = table.Column<int>(nullable: false),
                    MealProtein = table.Column<int>(nullable: false),
                    MealCarbohydrates = table.Column<int>(nullable: false),
                    MealFat = table.Column<int>(nullable: false),
                    MealFibre = table.Column<int>(nullable: false),
                    MealSugars = table.Column<int>(nullable: false),
                    MealSodium = table.Column<int>(nullable: false),
                    Potassium = table.Column<int>(nullable: false),
                    Cholesterol = table.Column<int>(nullable: false),
                    VitaminA = table.Column<int>(nullable: false),
                    VitaminC = table.Column<int>(nullable: false),
                    Calcium = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    CurrentWeight = table.Column<int>(nullable: false),
                    GoalWeight = table.Column<int>(nullable: false),
                    ActivityLevel = table.Column<string>(nullable: true),
                    BMR = table.Column<int>(nullable: false),
                    IntensityOfThePlan = table.Column<string>(nullable: true),
                    DailyCalorieNeeds = table.Column<int>(nullable: false),
                    CarbohydratesPercentage = table.Column<int>(nullable: false),
                    Carbohydrates = table.Column<int>(nullable: false),
                    ProteinPercentage = table.Column<int>(nullable: false),
                    Protein = table.Column<int>(nullable: false),
                    FatPercentage = table.Column<int>(nullable: false),
                    Fats = table.Column<int>(nullable: false),
                    DailyFibre = table.Column<int>(nullable: false),
                    DailySugars = table.Column<int>(nullable: false),
                    DailySodium = table.Column<int>(nullable: false),
                    DailyPotassium = table.Column<int>(nullable: false),
                    DailyCholesterol = table.Column<int>(nullable: false),
                    DailyVitaminA = table.Column<int>(nullable: false),
                    DailyVitaminC = table.Column<int>(nullable: false),
                    DailyCalcium = table.Column<int>(nullable: false),
                    DailyWater = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Serving = table.Column<string>(nullable: true),
                    CaloriesPerServing = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TotalCalories = table.Column<int>(nullable: false),
                    Protein = table.Column<int>(nullable: false),
                    Carbohydrates = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    Fibre = table.Column<int>(nullable: false),
                    Sugars = table.Column<int>(nullable: false),
                    Sodium = table.Column<int>(nullable: false),
                    Potassium = table.Column<int>(nullable: false),
                    Cholesterol = table.Column<int>(nullable: false),
                    VitaminA = table.Column<int>(nullable: false),
                    VitaminC = table.Column<int>(nullable: false),
                    Calcium = table.Column<int>(nullable: false),
                    MealId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_Meal_MealId",
                        column: x => x.MealId,
                        principalTable: "Meal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_MealId",
                table: "Food",
                column: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diary");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Meal");
        }
    }
}
