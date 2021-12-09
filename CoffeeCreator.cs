using System;

namespace Coffee
{
    public class CoffeeCreator : Drink, IMachine
    {
        public CoffeeCreator(string nameOfDrink, float literOfWater, float cupLiqudLimit, string[] ingredient) : base(nameOfDrink, literOfWater, cupLiqudLimit, ingredient) { }

        public float functionality()
        {
            // Returns the amount of cups filled
            return literOfWater / cupLiqudLimit;
        }
    }
}