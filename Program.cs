using System;

namespace KebabExo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab miam = new Kebab(new string[4] { "salade", "tomate", "ognion", "viande" }, new string[1] { "algerienne" });
            Kebab beurk = new Kebab(new string[4] { "salade", "concombre", "épinard", "carotte" }, new string[2] { "ketchup", "mayonnaise" });
            Kebab meh = new Kebab(new string[4] { "salade", "poisson", "ketchup", "tomate" }, new string[1] { "ketchup" });

            Console.WriteLine("miam isVegeterian ? " + miam.isVegeterian());
            Console.WriteLine("beurk isVegeterian ? " + beurk.isVegeterian());
            Console.WriteLine("meh isPesceterian ? " + meh.isPesceterian());
        }
    }
}
