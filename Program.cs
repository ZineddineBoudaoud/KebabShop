using System;

namespace KebabExo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab beurk = new Kebab();
            Kebab miam = new Kebab();

            miam.ingredients = new string[5] { "salade", "tomate", "ognion", "viande", "ketchup" };
            beurk.ingredients = new string[4] { "salade", "concombre", "épinard", "carotte" };

            Console.WriteLine("miam isVegeterian ? " + miam.isVegeterian());
            Console.WriteLine("beurk isVegeterian ? " + beurk.isVegeterian());
        }
    }
}
