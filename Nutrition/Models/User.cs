﻿using System;
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
        public string sex;
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
        /// User's preference on the intensity of the plan
        /// </summary>
        private string intensityOfThePlan;

        public string IntensityOfThePlan
        {
            get { return intensityOfThePlan; }
            set { intensityOfThePlan = value; }
        }

        /// <summary>
        /// User's Basal Metabolict calculated using the Harris-Benedict equation
        /// </summary>
        private int bmr; 
        public int BMR
        {
            get 
            {
                int sexCoefficent = 0;
                switch (sex)
                {
                    case "female": sexCoefficent = -161; break;
                    case "male": sexCoefficent = 5; break;
                }
                
                bmr = Convert.ToInt32((10 * currentWeight) + (6.25 * height) - (5 * age) + sexCoefficent);
                return bmr;
            }
        }


        /// <summary>
        /// User's estimated daily calorie needs
        /// </summary>
        private int dailyCalorieNeeds;
        public int DailyCalorieNeeds
        {
            get
            {
                double activityCoefficient = 0;
                switch (activityLevel)
                {
                    case "Sedentary": activityCoefficient = 1.2; break;
                    case "Lightly active": activityCoefficient = 1.375; break;
                    case "Moderately active": activityCoefficient = 1.55; break;
                    case "Very active": activityCoefficient = 1.725; break;
                    case "Extra active": activityCoefficient = 1.9; break; 
                }
                dailyCalorieNeeds = Convert.ToInt32(bmr * activityCoefficient);
                return dailyCalorieNeeds;
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
            
            get
            {
                carbohydratesPercentage = 50;
                return carbohydratesPercentage;
            }
        }

        /// <summary>
        /// The daily consumtion of carbohydrates in grams, based on the percentage of daily carbohydrates
        /// </summary>
        private int carbohydrates;
        public int Carbohydrates
        {
            get
            {
                carbohydrates = (carbohydratesPercentage / 100) * dailyCalorieNeeds / 4;
                return carbohydrates;
            }
        }

        /// <summary>
        /// The percentage of protein from the daily calorie needs
        /// </summary>
        private int proteinPercentage;
        public int ProteinPercentage
        {
            get 
            { 
                proteinPercentage = 30;
                return proteinPercentage;
            }
        }
        /// <summary>
        /// The daily consumtion of protein in grams, based on the percentage of daily protein
        /// </summary>
        private int protein;
        public int Protein
        {
            get
            {
                protein = (proteinPercentage / 100) * dailyCalorieNeeds / 4;
                return protein;
            }
        }

        /// <summary>
        /// The percentage of fats from the daily calorie needs
        /// </summary>
        private int fatPercentage;
        public int FatPercentage
        {
            get 
            { 
                fatPercentage = 20;
                return fatPercentage;
            }
        }

        /// <summary>
        /// The daily consumtion of fats in grams, based on the percentage of daily fats
        /// </summary>
        private int fats;
        public int Fats
        {
            get
            {
                fats = Convert.ToInt32(((fatPercentage / 100) * dailyCalorieNeeds) / 9);
                return fats;
            }
        }

        private int dailyFibre;

        public int DailyFibre
        {
            get 
            {
                dailyFibre = Convert.ToInt32(dailyCalorieNeeds * 0.014);
                return dailyFibre;
            }
        }

        private int dailySugars;

        public int DailySugars
        {
            get 
            {
                switch (sex)
                {
                    case "female": return 24; 
                    case "male": return 36;
                }
                return 0;
            }
        }

        private double dailySodium = 2.3;

        public double DailySodium
        {
            get 
            {
                return dailySodium; 
            }
        }

        private double dailyPotassium = 3.5;

        public double DailyPotassium
        {
            get 
            { 
                return dailyPotassium; 
            }
        }

        private double dailyCholesterol = 0.3;

        public double DailyCholesterol
        {
            get { return dailyCholesterol; }
        }

        private double dailyVitaminA ;

        public double DailyVitaminA
        {
            get 
            {
                switch (sex)
                {
                    case "female": return 0.0006;
                    case "male": return 0.0007;
                }
                return 0;
            }
            set { dailyVitaminA = value; }
        }

        private double dailyVitaminC;

        public double DailyVitaminC
        {
            get 
            {
                if (age > 16)
                {
                    switch (sex)
                    {
                        case "female": return 0.075;
                        case "male": return 0.09;
                    }
                }
                return 0.05; //for children 
            }
        }

        private double dailyCalcium = 0.6;

        public double DailyCalcium
        {
            get 
            { 
                return dailyCalcium; 
            }
        }

        private double dailyWater;
        public double DailyWater
        {
            get { return  0.033 * CurrentWeight; }
        }

        public User()
        {
        
        }
    }
}

