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

        public bool isVegeterian()
        {
            foreach (string ingredient in ingredients)
            {
                if(ingredient.Equals("viande") || ingredient.Equals("poulet") || ingredient.Equals("poisson") || ingredient.Equals("crevette"))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isPesceterian()
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

        public Kebab sansOgnion()
        {
            foreach (string ingredient in ingredients)
            {
                if(ingredient.Equals("ognion"))
                {
                    
                }
            }
            return this;
        }

        public Kebab supplementFromage()
        {
            bool hasCheese = false;
            foreach (string ingredient in ingredients)
            {
                if(ingredient.Equals("fromage"))
                {
                    hasCheese = true;
                }
            }
            
            if(hasCheese)
            {
                ingredients[ingredients.Length - 1] = "fromage";
                
            }
            return this;
        }

        public int countCheese()
        {
            int count = 0;
            foreach (string ingredient in ingredients)
            {
                if(ingredient.Equals("fromage"))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
