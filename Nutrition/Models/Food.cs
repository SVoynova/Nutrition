using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nutrition.Models
{
    public class Food
    {
        public int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string serving;
        public string Serving
        {
            get { return serving; }
            set { serving = value; }
        }

        public int caloriesPerServing;
        public int CaloriesPerServing
        {
            get { return caloriesPerServing; }
            set { caloriesPerServing = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int totalCalories;
        public int TotalCalories
        {
            get { return totalCalories; }
            set { totalCalories = CaloriesPerServing * Quantity; }
        }


        public int protein;
        public int Protein
        {
            get { return protein; }
            set { protein = value; }
        }

        private int carbohydrates;
        public int Carbohydrates
        {
            get { return carbohydrates; }
            set { carbohydrates = value; }
        }

        private int fat;
        public int Fat
        {
            get { return fat; }
            set { fat = value; }
        }

        private int fibre;
        public int Fibre
        {
            get { return fibre; }
            set { fibre = value; }
        }

        private int sugars;

        public int Sugars
        {
            get { return sugars; }
            set { sugars = value; }
        }

        private int sodium;

        public int Sodium
        {
            get { return sodium; }
            set { sodium = value; }
        }


        private int potassium;
        public int Potassium
        {
            get { return potassium; }
            set { potassium = value; }
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

        public Food()
        {

        }

    }
}