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
            set { totalCalories = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int totalProtein;
        public int TotalProtein
        {
            get { return totalProtein; }
            set { totalProtein = value; }
        }

        private int totalCarbohydrates;
        public int TotalCarbohydrates
        {
            get { return totalCarbohydrates; }
            set { totalCarbohydrates = value; }
        }

        private int totalFat;
        public int TotalFat
        {
            get { return totalFat; }
            set { totalFat = value; }
        }

        private int mealFibre;
        public int TotalFibre
        {
            get { return mealFibre; }
            set { mealFibre = value; }
        }

        private int totalSugars;

        public int TotalSugars
        {
            get { return totalSugars; }
            set { totalSugars = value; }
        }

        private int totalSodium;

        public int TotalSodium
        {
            get { return totalSodium; }
            set { totalSodium = value; }
        }


        private int totalPotassium;
        public int TotalPotassium
        {
            get { return totalPotassium; }
            set { totalPotassium = value; }
        }


        private int totalCholesterol;
        public int TotalCholesterol
        {
            get { return totalCholesterol; }
            set { totalCholesterol = value; }
        }


        private int totalVitaminA;
        public int TotalVitaminA
        {
            get { return totalVitaminA; }
            set { totalVitaminA = value; }
        }


        private int totalVitaminC;
        public int TotalVitaminC
        {
            get { return totalVitaminC; }
            set { totalVitaminC = value; }
        }


        private int totalCalcium;
        public int TotalCalcium
        {
            get { return totalCalcium; }
            set { totalCalcium = value; }
        }

        public Diary()
        {

        }
    }
}
