using System;

namespace KebabExo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab beurk = new Kebab(new string[5] { "salade", "tomate", "ognion", "viande", "ketchup" });
            Kebab miam = new Kebab(new string[4] { "salade", "concombre", "épinard", "carotte" });
            Kebab meh = new Kebab(new string[4] { "salade", "poisson", "ketchup", "tomate" });
            Kebab 

            Console.WriteLine("miam isVegeterian ? " + miam.isVegeterian());
            Console.WriteLine("beurk isVegeterian ? " + beurk.isVegeterian());
            Console.WriteLine("meh isPesceterian ? " + meh.isPesceterian());
        }
    }
}
