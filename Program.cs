using System;

namespace KebabExo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab miam = new Kebab(new string[] { "salade", "tomate", "ognion", "viande" }, new string[] { "algerienne" });
            Kebab beurk = new Kebab(new string[] { "salade", "concombre", "épinard", "carotte" }, new string[] { "ketchup", "mayonnaise" });
            Kebab meh = new Kebab(new string[] { "salade", "poisson", "ketchup", "tomate" }, new string[] { "ketchup" });
            Kebab miammiam = new Kebab(new string[] { "salade", "tomate", "ognion", "fromage", "poulet" }, new string[] { "samourai" });

            Console.WriteLine("miam isVegeterian ? " + miam.isVegeterian());
            Console.WriteLine("beurk isVegeterian ? " + beurk.isVegeterian());
            Console.WriteLine("meh isPesceterian ? " + meh.isPesceterian());

            Console.WriteLine(miammiam.countCheese());
            miammiam.supplementFromage();
            Console.WriteLine(miammiam.countCheese());
        }
    }
}
