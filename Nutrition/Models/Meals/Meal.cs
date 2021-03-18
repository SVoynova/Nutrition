using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nutrition.Models
{
    public class Meal
    {
        public int Id { get; set; }


        /// <summary>
        /// Breakfast entry 
        /// </summary>
        private List<FoodModel> mealItems;
        public List<FoodModel> MealItems
        {
            get { return mealItems; }
            set { mealItems = value; }
        }

        /// <summary>
        /// Calories consumed for meal
        /// </summary>
        private int mealCalories;
        public int MealCalories
        {
            get { return mealCalories; }
            set { mealCalories = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int mealProtein;
        public int MealProtein
        {
            get { return mealProtein; }
            set { mealProtein = value; }
        }

        private int mealCarbohydrates;
        public int MealCarbohydrates
        {
            get { return mealCarbohydrates; }
            set { mealCarbohydrates = value; }
        }

        private int mealFat;
        public int MealFat
        {
            get { return mealFat; }
            set { mealFat = value; }
        }

        private int mealFibre;
        public int MealFibre
        {
            get { return mealFibre; }
            set { mealFibre = value; }
        }

        private int mealSugars;

        public int MealSugars
        {
            get { return mealSugars; }
            set { mealSugars = value; }
        }

        private int mealSodium;

        public int MealSodium
        {
            get { return mealSodium; }
            set { mealSodium = value; }
        }


        private int mealPotassium;
        public int Potassium
        {
            get { return mealPotassium; }
            set { mealPotassium = value; }
        }


        private int cholesterol;
        public int Cholesterol
        {
            get { return cholesterol; }
            set { cholesterol = value; }
        }


        private int vitaminA;
        public int VitaminA
        {
            get { return vitaminA; }
            set { vitaminA = value; }
        }


        private int vitaminC;
        public int VitaminC
        {
            get { return vitaminC; }
            set { vitaminC = value; }
        }


        private int calcium;
        public int Calcium
        {
            get { return calcium; }
            set { calcium = value; }
        }

        /// <summary>
        /// A method which is used to add a food item in the breakfast section.
        /// </summary>
        /// <param name="food">The food item which to be added in the breakfast entry.</param>
        /// <returns>Message that the food has been added.</returns>
        public string AddFoodToMeal(FoodModel food)
        {
            MealItems.Add(food);
            //MealCalories += food.TotalCalories;
            return food.Name + "\nadded!";
        }

        


    }
}
