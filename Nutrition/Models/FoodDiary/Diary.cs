using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nutrition.Models
{
    public class Diary
    {
        public int Id { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Breakfast entry 
        /// </summary>
        private List<FoodModel> breakfastItems;
        public List<FoodModel> BreakfastItems
        {
            get { return breakfastItems; }
            set { breakfastItems = value; }
        }

        /// <summary>
        /// Calories consumed for meal
        /// </summary>
        private int breakfastCalories;
        public int BreakfastCalories
        {
            get { return breakfastCalories; }
            set { breakfastCalories = value; }
        }

        /// <summary>
        /// Amount of protein contained in the meal
        /// </summary>
        public int breakfastProtein;
        public int BreakfastProtein
        {
            get { return breakfastProtein; }
            set { breakfastProtein = value; }
        }

        /// <summary>
        /// Carbohydrates contained in the meal
        /// </summary>
        private int breakfastCarbohydrates;
        public int BreakfastCarbohydrates
        {
            get { return breakfastCarbohydrates; }
            set { breakfastCarbohydrates = value; }
        }

        /// <summary>
        /// Fats contained in the meal
        /// </summary>
        private int breakfastFat;
        public int BreakfastFat
        {
            get { return breakfastFat; }
            set { breakfastFat = value; }
        }

        /// <summary>
        /// Fibre contained in the meal
        /// </summary>
        private int breakfastFibre;
        public int BreakfastFibre
        {
            get { return breakfastFibre; }
            set { breakfastFibre = value; }
        }

        /// <summary>
        /// Sugars contained in the meal
        /// </summary>
        private int breakfastSugars;
        public int BreakfastSugars
        {
            get { return breakfastSugars; }
            set { breakfastSugars = value; }
        }

        /// <summary>
        /// Sodium contained in the meal
        /// </summary>
        private int breakfastSodium;
        public int BreakfastSodium
        {
            get { return breakfastSodium; }
            set { breakfastSodium = value; }
        }

        /// <summary>
        /// Potassium contained in the meal
        /// </summary>
        private int breakfastPotassium;
        public int BreakfastPotassium
        {
            get { return breakfastPotassium; }
            set { breakfastPotassium = value; }
        }

        /// <summary>
        /// Cholesterol contained in the meal
        /// </summary>
        private int breakfastCholesterol;
        public int BreakfastCholesterol
        {
            get { return breakfastCholesterol; }
            set { breakfastCholesterol = value; }
        }

        /// <summary>
        /// Vitamin A contained in the meal
        /// </summary>
        private int breakfastVitaminA;
        public int BreakfastVitaminA
        {
            get { return breakfastVitaminA; }
            set { breakfastVitaminA = value; }
        }

        /// <summary>
        /// Vatamin C contained in the meal
        /// </summary>
        private int breakfastVitaminC;
        public int BreakfastVitaminC
        {
            get { return breakfastVitaminC; }
            set { breakfastVitaminC = value; }
        }

        /// <summary>
        /// Calcium contained in the meal
        /// </summary>
        private int breakfastCalcium;
        public int BreakfastCalcium
        {
            get { return breakfastCalcium; }
            set { breakfastCalcium = value; }
        }


        /// <summary>
        /// Lunch entry 
        /// </summary>
        private List<FoodModel> lunchItems;
        public List<FoodModel> LunchItems
        {
            get { return lunchItems; }
            set { lunchItems = value; }
        }

        /// <summary>
        /// Calories consumed for meal
        /// </summary>
        private int lunchCalories;
        public int LunchCalories
        {
            get { return lunchCalories; }
            set { lunchCalories = value; }
        }

        /// <summary>
        /// Amount of protein contained in the meal
        /// </summary>
        public int lunchProtein;
        public int LunchProtein
        {
            get { return lunchProtein; }
            set { lunchProtein = value; }
        }

        /// <summary>
        /// Carbohydrates contained in the meal
        /// </summary>
        private int lunchCarbohydrates;
        public int LunchCarbohydrates
        {
            get { return lunchCarbohydrates; }
            set { lunchCarbohydrates = value; }
        }
        /// <summary>
        /// Fats contained in the meal
        /// </summary>
        private int lunchFat;
        public int LunchFat
        {
            get { return lunchFat; }
            set { lunchFat = value; }
        }

        /// <summary>
        /// Fibre contained in the meal
        /// </summary>
        private int lunchFibre;
        public int LunchFibre
        {
            get { return lunchFibre; }
            set { lunchFibre = value; }
        }

        /// <summary>
        /// Sugars contained in the meal
        /// </summary>
        private int lunchSugars;
        public int LunchSugars
        {
            get { return lunchSugars; }
            set { lunchSugars = value; }
        }

        /// <summary>
        /// Sodium contained in the meal
        /// </summary>>
        private int lunchSodium;
        public int LunchSodium
        {
            get { return lunchSodium; }
            set { lunchSodium = value; }
        }

        /// <summary>
        /// Potassium contained in the meal
        /// </summary>>
        private int lunchPotassium;
        public int LunchPotassium
        {
            get { return lunchPotassium; }
            set { lunchPotassium = value; }
        }

        /// <summary>
        /// Cholesterol contained in the meal
        /// </summary>>
        private int lunchCholesterol;
        public int LunchCholesterol
        {
            get { return lunchCholesterol; }
            set { lunchCholesterol = value; }
        }

        /// <summary>
        /// Vatamin A contained in the meal
        /// </summary>
        private int lunchVitaminA;
        public int LunchVitaminA
        {
            get { return lunchVitaminA; }
            set { lunchVitaminA = value; }
        }

        /// <summary>
        /// Vatamin C contained in the meal
        /// </summary>
        private int lunchVitaminC;
        public int LunchVitaminC
        {
            get { return lunchVitaminC; }
            set { lunchVitaminC = value; }
        }

        /// <summary>
        /// Calcium contained in the meal
        /// </summary>
        private int lunchCalcium;
        public int LunchCalcium
        {
            get { return lunchCalcium; }
            set { lunchCalcium = value; }
        }


        /// <summary>
        /// Dinner entry 
        /// </summary>
        private List<FoodModel> dinnerItems;
        public List<FoodModel> DinnerItems
        {
            get { return dinnerItems; }
            set { dinnerItems = value; }
        }

        /// <summary>
        /// Calories consumed for meal
        /// </summary>
        private int dinnerCalories;
        public int DinnerCalories
        {
            get { return dinnerCalories; }
            set { dinnerCalories = value; }
        }

        /// <summary>
        /// Amount of protein contained in the meal
        /// </summary>
        public int dinnerProtein;
        public int DinnerProtein
        {
            get { return dinnerProtein; }
            set { dinnerProtein = value; }
        }

        /// <summary>
        /// Carbohydrates contained in the meal
        /// </summary>
        private int dinnerCarbohydrates;
        public int DinnerCarbohydrates
        {
            get { return dinnerCarbohydrates; }
            set { dinnerCarbohydrates = value; }
        }

        /// <summary>
        /// Fats contained in the meal
        /// </summary>
        private int dinnerFat;
        public int DinnerFat
        {
            get { return dinnerFat; }
            set { dinnerFat = value; }
        }

        /// <summary>
        /// Fibre contained in the meal
        /// </summary>
        private int dinnerFibre;
        public int DinnerFibre
        {
            get { return dinnerFibre; }
            set { dinnerFibre = value; }
        }

        /// <summary>
        /// Sugars contained in the meal
        /// </summary>
        private int dinnerSugars;
        public int DinnerSugars
        {
            get { return dinnerSugars; }
            set { dinnerSugars = value; }
        }

        /// <summary>
        /// Sodium contained in the meal
        /// </summary>>
        private int dinnerSodium;
        public int DinnerSodium
        {
            get { return dinnerSodium; }
            set { dinnerSodium = value; }
        }

        /// <summary>
        /// Potassium contained in the meal
        /// </summary>>
        private int dinnerPotassium;
        public int DinnerPotassium
        {
            get { return dinnerPotassium; }
            set { dinnerPotassium = value; }
        }

        /// <summary>
        /// Cholesterol contained in the meal
        /// </summary>>
        private int dinnerCholesterol;
        public int DinnerCholesterol
        {
            get { return dinnerCholesterol; }
            set { dinnerCholesterol = value; }
        }

        /// <summary>
        /// Vatamin A contained in the meal
        /// </summary>
        private int dinnerVitaminA;
        public int DinnerVitaminA
        {
            get { return dinnerVitaminA; }
            set { dinnerVitaminA = value; }
        }

        /// <summary>
        /// Vatamin C contained in the meal
        /// </summary>
        private int dinnerVitaminC;
        public int DinnerVitaminC
        {
            get { return dinnerVitaminC; }
            set { dinnerVitaminC = value; }
        }

        /// <summary>
        /// Calcium contained in the meal
        /// </summary>
        private int dinnerCalcium;
        public int DinnerCalcium
        {
            get { return dinnerCalcium; }
            set { dinnerCalcium = value; }
        }


        /// <summary>
        /// Snacks entry 
        /// </summary>
        private List<FoodModel> snacksItems;
        public List<FoodModel> SnacksItems
        {
            get { return snacksItems; }
            set { snacksItems = value; }
        }

        /// <summary>
        /// Calories consumed for meal
        /// </summary>
        private int snacksCalories;
        public int SnacksCalories
        {
            get { return snacksCalories; }
            set { snacksCalories = value; }
        }

        /// <summary>
        /// Amount of protein contained in the meal
        /// </summary>
        public int snacksProtein;
        public int SnacksProtein
        {
            get { return snacksProtein; }
            set { snacksProtein = value; }
        }

        /// <summary>
        /// Carbohydrates contained in the meal
        /// </summary>
        private int snacksCarbohydrates;
        public int SnacksCarbohydrates
        {
            get { return snacksCarbohydrates; }
            set { snacksCarbohydrates = value; }
        }

        /// <summary>
        /// Fats contained in the meal
        /// </summary>
        private int snacksFat;
        public int SnacksFat
        {
            get { return snacksFat; }
            set { snacksFat = value; }
        }

        /// <summary>
        /// Fibre contained in the meal
        /// </summary>
        private int snacksFibre;
        public int SnacksFibre
        {
            get { return snacksFibre; }
            set { snacksFibre = value; }
        }

        /// <summary>
        /// Sugars contained in the meal
        /// </summary>>
        private int snacksSugars;
        public int SnacksSugars
        {
            get { return snacksSugars; }
            set { snacksSugars = value; }
        }

        /// <summary>
        /// Sodium contained in the meal
        /// </summary>>
        private int snacksSodium;
        public int SnacksSodium
        {
            get { return snacksSodium; }
            set { snacksSodium = value; }
        }

        /// <summary>
        /// Potassium contained in the meal
        /// </summary>>
        private int snacksPotassium;
        public int SnacksPotassium
        {
            get { return snacksPotassium; }
            set { snacksPotassium = value; }
        }

        /// <summary>
        /// Cholesterol contained in the meal
        /// </summary>>
        private int snacksCholesterol;
        public int SnacksCholesterol
        {
            get { return snacksCholesterol; }
            set { snacksCholesterol = value; }
        }

        /// <summary>
        /// Vatamin A contained in the meal
        /// </summary>
        private int snacksVitaminA;
        public int SnacksVitaminA
        {
            get { return snacksVitaminA; }
            set { snacksVitaminA = value; }
        }

        /// <summary>
        /// Vatamin C contained in the meal
        /// </summary>
        private int snacksVitaminC;
        public int SnacksVitaminC
        {
            get { return snacksVitaminC; }
            set { snacksVitaminC = value; }
        }

        /// <summary>
        /// Calcium contained in the meal
        /// </summary>
        private int snacksCalcium;
        public int SnacksCalcium
        {
            get { return snacksCalcium; }
            set { snacksCalcium = value; }
        }
        

        /// <summary>
        /// Water entry in litres 
        /// </summary>
        private int water;
        public int Water
        {
            get { return water; }
            set { water = value; }
        }

        /*

        /// <summary>
        /// A method which is used to add a food item in the breakfast section.
        /// </summary>
        /// <param name="food">The food item which to be added in the breakfast entry.</param>
        /// <returns>Message that the food has been added.</returns>
        public string AddFoodToMeal(FoodModel food)
        {
            BreakfastItems.Add(food);
            BreakfastCalories += food.TotalCalories;
            return food.Name + "\nadded!";
        }


        

        /*
        /// <summary>
        /// Calories consumed for breakfast 
        /// </summary>
        private int totalCalories;
        public int TotalCalories
        {
            get { return totalCalories; }
            set { totalCalories = 
                    breakfast.MealCalories +
                    lunch.MealCalories +
                    dinner.MealCalories +
                    snacks.MealCalories; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int totalProtein;
        public int TotalProtein
        {
            get { return totalProtein; }
            set { totalProtein = 
                    breakfast.MealProtein +
                    lunch.MealProtein + 
                    dinner.MealProtein + 
                    snacks.MealProtein; }
        }

        private int totalCarbohydrates;
        public int TotalCarbohydrates
        {
            get { return totalCarbohydrates; }
            set { totalCarbohydrates = 
                    breakfast.MealCarbohydrates + 
                    lunch.MealCarbohydrates + 
                    dinner.MealCarbohydrates + 
                    snacks.MealCarbohydrates; }
        }

        private int totalFat;
        public int TotalFat
        {
            get { return totalFat; }
            set 
            {
                totalFat =
                  breakfast.MealFat +
                  lunch.MealFat +
                  dinner.MealFat +
                  snacks.MealFat;
            }
        }

        private int totalFibre;
        public int TotalFibre
        {
            get { return totalFibre; }
            set { totalFibre =
                    breakfast.MealFibre +
                    lunch.MealFibre +
                    dinner.MealFibre +
                    snacks.MealFibre;
            }
        }

        private int totalSugars;
        public int TotalSugars
        {
            get { return totalSugars; }
            set { totalSugars =
                    breakfast.MealSugars +
                    lunch.MealSugars +
                    dinner.MealSugars +
                    snacks.MealSugars;
            }
        }

        private int totalSodium;
        public int TotalSodium
        {
            get { return totalSodium; }
            set { totalSodium =
                    breakfast.MealSodium +
                    lunch.MealSodium +
                    dinner.MealSodium +
                    snacks.MealSodium;
            }
        }


        private int totalPotassium;
        public int TotalPotassium
        {
            get { return totalPotassium; }
            set { totalPotassium =
                    breakfast.Potassium +
                    lunch.Potassium +
                    dinner.Potassium+
                    snacks.Potassium;
            }
        }


        private int totalCholesterol;
        public int TotalCholesterol
        {
            get { return totalCholesterol; }
            set { totalCholesterol =
                    breakfast.Cholesterol +
                    lunch.Cholesterol +
                    dinner.Cholesterol +
                    snacks.Cholesterol;
            }
        }


        private int totalVitaminA;
        public int TotalVitaminA
        {
            get { return totalVitaminA; }
            set { totalVitaminA =
                    breakfast.VitaminA +
                    lunch.VitaminA +
                    dinner.VitaminA +
                    snacks.VitaminA;
            }
        }


        private int totalVitaminC;
        public int TotalVitaminC
        {
            get { return totalVitaminC; }
            set { totalVitaminC =
                    BreakfastVitaminC +
                    LunchVitaminC +
                    DinnerVitaminC+
                    SnacksVitaminC;
            }
        }

        
        private int totalCalcium;
        public int TotalCalcium
        {
            get { return totalCalcium; }
            set { totalCalcium =
                    breakfast.Calcium +
                    lunch.Calcium +
                    dinner.Calcium +
                    snacks.Calcium;
            }
        }
        */
        public Diary()
        {

        }
    }
}
