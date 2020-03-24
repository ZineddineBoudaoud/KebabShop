﻿using System;
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
    }
}
