using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nutrition.Models
{
    public class FoodModel
    {
        public int Id
        {
            get ;
            set ;
        }

        public string Name
        {
            get;
            set;
        }


        public string Serving
        {
            get;
            set;
        }

        public int CaloriesPerServing
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int Protein
        {
            get;
            set;
        }
        public int Carbohydrates
        {
            get;
            set;
        }

        public int Fat
        {
            get;
            set;
        }

        public int Fibre
        {
            get;
            set;
        }

        
        public int Sugars
        {
            get;
            set;
        }

        /*

        public int Sodium
        {
            get;
            set;
        }


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
        */

        public FoodModel()
        {

        }

    }
}