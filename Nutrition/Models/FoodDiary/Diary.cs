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

        //закуската започва от тук
        //написала съм и къде свършва по-долу
        //копирай всичко това 
        //постави го 3 пъти 
        //и промени имената 1вия път - за lunch, 2- dinner, 3 - snacks

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
        /// 
        /// </summary>
        public int breakfastProtein;
        public int BreakfastProtein
        {
            get { return breakfastProtein; }
            set { breakfastProtein = value; }
        }

        private int breakfastCarbohydrates;
        public int BreakfastCarbohydrates
        {
            get { return breakfastCarbohydrates; }
            set { breakfastCarbohydrates = value; }
        }

        private int breakfastFat;
        public int BreakfastFat
        {
            get { return breakfastFat; }
            set { breakfastFat = value; }
        }

        private int breakfastFibre;
        public int BreakfastFibre
        {
            get { return breakfastFibre; }
            set { breakfastFibre = value; }
        }

        private int breakfastSugars;
        public int BreakfastSugars
        {
            get { return breakfastSugars; }
            set { breakfastSugars = value; }
        }

        private int breakfastSodium;
        public int BreakfastSodium
        {
            get { return breakfastSodium; }
            set { breakfastSodium = value; }
        }


        private int breakfastPotassium;
        public int BreakfastPotassium
        {
            get { return breakfastPotassium; }
            set { breakfastPotassium = value; }
        }


        private int breakfastcholesterol;
        public int BreakfastCholesterol
        {
            get { return breakfastcholesterol; }
            set { breakfastcholesterol = value; }
        }


        private int breakfastvitaminA;
        public int BreakfastVitaminA
        {
            get { return breakfastvitaminA; }
            set { breakfastvitaminA = value; }
        }


        private int breakfastvitaminC;
        public int BreakfastVitaminC
        {
            get { return breakfastvitaminC; }
            set { breakfastvitaminC = value; }
        }


        private int breakfastcalcium;
        public int BreakfastCalcium
        {
            get { return breakfastcalcium; }
            set { breakfastcalcium = value; }
        }

        //закуската свършва тук





        //слагай ги над това



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
