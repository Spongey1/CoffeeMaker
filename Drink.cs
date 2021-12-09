using System.Collections.Generic;

namespace Coffee
{
    public class Drink
    {
        // Properties of a Drink
        protected string nameOfDrink { get; set; }
        protected float literOfWater { get; set; }
        protected float cupLiqudLimit { get; set; }
        protected string[] ingredients { get; set; }

        // Constructor to pass on the properties inside of this class, to the derived class
        public Drink(string nameOfDrink, float literOfWater, float cupLiqudLimit, string[] ingredient)
        {
            this.nameOfDrink = nameOfDrink;
            this.literOfWater = literOfWater;
            this.cupLiqudLimit = cupLiqudLimit;
            this.ingredients = ingredients;
        }
    }
}