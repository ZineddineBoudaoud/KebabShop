using System;
using System.Collections.Generic;
using System.Text;

namespace KebabExo
{
    class Kebab
    {
        public string[] ingredients;
        public string[] sauces;

        public Kebab(string[] ingredients, string[] sauces)
        {
            this.ingredients = ingredients;
            this.sauces = sauces;
        }

        public bool isVegeterian
        {
            get
            {
                foreach (string ingredient in ingredients)
                {
                    if (ingredient.Equals("viande") || ingredient.Equals("poulet") || ingredient.Equals("poisson") || ingredient.Equals("crevette"))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public bool isPesceterian
        {
            get
            {
                foreach (string ingredient in ingredients)
                {
                    if (ingredient.Equals("viande") || ingredient.Equals("poulet"))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public Kebab sansOgnion()
        {
            bool hasOgnion = false;
            int i;
            for(i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Equals("ognion"))
                {
                    hasOgnion = true;
                    break;
                }
            }

            if(hasOgnion)
            {
                var tmp = new List<string>(ingredients);
                tmp.RemoveAt(i);
                ingredients = tmp.ToArray();
            }
            return this;
        }

        public Kebab GetsupplementFromage()
        {
            bool hasCheese = false;
            foreach (string ingredient in ingredients)
            {
                if (ingredient.Equals("fromage"))
                {
                    hasCheese = true;
                }
            }

            if (hasCheese)
            {
                ingredients[ingredients.Length - 1] = "fromage";

            }
            return this;
        }

        public int countCheese
        {
            get
            {
                int count = 0;
                foreach (string ingredient in ingredients)
                {
                    if (ingredient.Equals("fromage"))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int countOnion
        {
            get
            {
                int count = 0;
                foreach (string ingredient in ingredients)
                {
                    if (ingredient.Equals("ognion"))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
