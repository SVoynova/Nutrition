using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nutrition.Models
{
    public class User
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// User's name
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// User's sex
        /// </summary>
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        /// <summary>
        /// User's age
        /// </summary>
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// User's height
        /// </summary>
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// User's current weight
        /// </summary>
        private int currentWeight;
        public int CurrentWeight
        {
            get { return currentWeight; }
            set { currentWeight = value; }
        }

        /// <summary>
        /// User's goal weight
        /// </summary>
        private int goalWeight;

        public int GoalWeight
        {
            get { return goalWeight; }
            set { goalWeight = value; }
        }

        /// <summary>
        /// User's activity level
        /// </summary>
        private string activityLevel;
        public string ActivityLevel
        {
            get { return activityLevel; }
            set { activityLevel = value; }
        }

        /// <summary>
        /// User's Basal Metabolict calculated using the Harris-Benedict equation
        /// </summary>
        private int bmr;
        public int BMR
        {
            get { return bmr; }
            set
            {
                int sexCoefficent = 0;
                switch (sex)
                {
                    case "female": sexCoefficent = -161; break;
                    case "male": sexCoefficent = 5; break;
                }
                bmr = (int)(10 * currentWeight + 6.25 * height - 5 * age + sexCoefficent);
            }
        }

        /// <summary>
        /// User's preference on the intensity of the plan
        /// </summary>
        private string intensityOfThePlan;

        public string IntensityOfThePlan
        {
            get { return intensityOfThePlan; }
            set { intensityOfThePlan = value; }
        }

        /// <summary>
        /// User's estimated daily calorie needs
        /// </summary>
        private int dailyCalorieNeeds;
        public int DailyCalorieNeeds
        {
            get { return dailyCalorieNeeds; }
            set
            {
                double activityCoefficient = 0;
                switch (intensityOfThePlan)
                {
                    case "Sedentary": activityCoefficient = 1.2; break;
                    case "Lightly active": activityCoefficient = 1.375; break;
                    case "Moderately active": activityCoefficient = 1.55; break;
                    case "Very active": activityCoefficient = 1.725; break;
                    case "Extra active": activityCoefficient = 1.9; break;
                }
                dailyCalorieNeeds = (int)(bmr * activityCoefficient);

            }
        }

        /*
        Calculating Daily Calorie Needs
        ________________________________
        Sedentary(little or no exercise) : Calorie-Calculation = BMR x 1.2
        Lightly active(light exercise/sports 1-3 days/week) : Calorie-Calculation = BMR x 1.375
        Moderately active(moderate exercise/sports 3-5 days/week) : Calorie-Calculation = BMR x 1.55
        Very active(hard exercise/sports 6-7 days a week) : Calorie-Calculation = BMR x 1.725
        Extra active(very hard exercise/sports & a physical job) : Calorie-Calculation = BMR x 1.9
        */


        /// <summary>
        /// The percentage of carbohydrates from the daily calorie needs
        /// </summary>
        private int carbohydratesPercentage;
        public int CarbohydratesPercentage
        {
            get { return carbohydratesPercentage; }
            set
            {
                carbohydratesPercentage = value;
            }
        }

        /// <summary>
        /// The daily consumtion of carbohydrates in grams, based on the percentage of daily carbohydrates
        /// </summary>
        private int carbohydrates;
        public int Carbohydrates
        {
            get { return carbohydrates; }
            set
            {
                carbohydrates = (carbohydratesPercentage / 100) * dailyCalorieNeeds / 4;
            }
        }

        /// <summary>
        /// The percentage of protein from the daily calorie needs
        /// </summary>
        private int proteinPercentage;
        public int ProteinPercentage
        {
            get { return proteinPercentage; }
            set { proteinPercentage = value; }
        }
        /// <summary>
        /// The daily consumtion of protein in grams, based on the percentage of daily protein
        /// </summary>
        private int protein;
        public int Protein
        {
            get { return protein; }
            set
            {
                protein = (proteinPercentage / 100) * dailyCalorieNeeds / 4;
            }
        }

        /// <summary>
        /// The percentage of fats from the daily calorie needs
        /// </summary>
        private int fatPercentage;
        public int FatPercentage
        {
            get { return fatPercentage; }
            set { fatPercentage = value; }
        }

        /// <summary>
        /// The daily consumtion of fats in grams, based on the percentage of daily fats
        /// </summary>
        private int fats;
        public int Fats
        {
            get { return fats; }
            set
            {
                fats = ((fatPercentage / 100) * dailyCalorieNeeds) / 9;
            }
        }

        private int dailyFibre;

        public int DailyFibre
        {
            get { return dailyFibre; }
            set { dailyFibre = value; }
        }

        private int dailySugars;

        public int DailySugars
        {
            get { return dailySugars; }
            set { dailySugars = value; }
        }

        private int dailySodium;

        public int DailySodium
        {
            get { return dailySodium; }
            set { dailySodium = value; }
        }

        private int dailyPotassium;

        public int DailyPotassium
        {
            get { return dailyPotassium; }
            set { dailyPotassium = value; }
        }

        private int dailyCholesterol;

        public int DailyCholesterol
        {
            get { return dailyCholesterol; }
            set { dailyCholesterol = value; }
        }

        private int dailyVitaminA;

        public int DailyVitaminA
        {
            get { return dailyVitaminA; }
            set { dailyVitaminA = value; }
        }

        private int dailyVitaminC;

        public int DailyVitaminC
        {
            get { return dailyVitaminC; }
            set { dailyVitaminC = value; }
        }

        private int dailyCalcium;

        public int DailyCalcium
        {
            get { return dailyCalcium; }
            set { dailyCalcium = value; }
        }

        private double dailyWater;
        public double DailyWater
        {
            get { return dailyWater; }
            set { dailyWater = 0.033 * CurrentWeight; }
        }

        public User()
        {
        
        }
    }
}

