using System;
using System.Collections.Generic;
using System.Text;

namespace KebabExo
{
    class Kebab
    {
        string[] ingredients;

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
