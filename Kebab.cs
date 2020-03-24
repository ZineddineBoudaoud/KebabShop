using System;
using System.Collections.Generic;
using System.Text;

namespace KebabExo
{
    class Kebab
    {
        public string[] ingredients;

        public Kebab(string[] ingredients)
        {
            this.ingredients = ingredients;
        }

        public bool isVegeterian()
        {
            foreach (string ingredient in ingredients)
            {
                if(ingredient.Equals("viande") || ingredient.Equals("poulet"))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
