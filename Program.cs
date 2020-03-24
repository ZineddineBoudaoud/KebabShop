using System;

namespace KebabExo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab beurk = new Kebab(new string[5] { "salade", "tomate", "ognion", "viande", "ketchup" });
            Kebab miam = new Kebab(new string[4] { "salade", "concombre", "épinard", "carotte" });

            Console.WriteLine("miam isVegeterian ? " + miam.isVegeterian());
            Console.WriteLine("beurk isVegeterian ? " + beurk.isVegeterian());
        }
    }
}
