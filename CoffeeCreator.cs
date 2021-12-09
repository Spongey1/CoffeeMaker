using System;

namespace Coffee
{
    public class CoffeeCreator : Drink, IMachine
    {
        public CoffeeCreator(string nameOfDrink, float literOfWater, float cupLiqudLimit, string[] ingredient) : base(nameOfDrink, literOfWater, cupLiqudLimit, ingredient) { }

        public float functionality()
        {
            return literOfWater / cupLiqudLimit;
        }
    }
}