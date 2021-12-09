using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeCreator creatorCoffee = new CoffeeCreator("Coffee", 220, 100, new string[] { "CoffeeBeans" });

            // Not entirely sure what this specific tea is made of
            CoffeeCreator creatorTe = new CoffeeCreator("Te", 200, 80, new string[] { "Te" });

            Console.WriteLine(creatorCoffee.functionality().ToString("0.00") + " Coffee cups were poured");
            Console.WriteLine(creatorTe.functionality().ToString("0.00") + " Tea cups were poured");
        }
    }
}
