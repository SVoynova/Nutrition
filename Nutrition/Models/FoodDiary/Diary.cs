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

        Meal breakfast = new Meal();

        Meal lunch = new Meal();

        Meal dinner = new Meal();

        Meal snacks = new Meal();

        /// <summary>
        /// Water entry in litres 
        /// </summary>
        private int water;
        public int Water
        {
            get { return water; }
            set { water = value; }
        }

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
                    breakfast.VitaminC +
                    lunch.VitaminC +
                    dinner.VitaminC+
                    snacks.VitaminC;
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

        public Diary()
        {

        }
    }
}
