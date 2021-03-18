using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nutrition.Models
{
    public class Recipe : Meal
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<FoodModel> ingredients;

        public List<FoodModel> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        private int preparationTime;

        public int PreparationTime
        {
            get { return preparationTime; }
            set { preparationTime = value; }
        }

        

        public Recipe()
        {

        }
    }
}
