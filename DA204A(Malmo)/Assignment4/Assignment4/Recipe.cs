using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Filip Andersson Vestman
// 12/11-2017

namespace Assignment4
{
    public class Recipe
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public string Description { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public int MaxNumOfIngredients { get; private set; }

        /// <summary>
        /// Returns current number of ingredients
        /// </summary>
        public int CurrentNumOfIngredients => Ingredients.Where(i => i != null).Count();

        /// <summary>
        /// Returns next vacant pos
        /// </summary>
        private int VacantPos => Array.FindIndex(Ingredients, i => i == null);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="max">Max number of ingredients</param>
        public Recipe(int max)
        {
            MaxNumOfIngredients = max;
            Ingredients = new String[max];
        }

        /// <summary>
        /// Resets to default values
        /// </summary>
        public void DefaultValues()
        {
            for (int i = 0; i < Ingredients.Length; i++)
                Ingredients[i] = null;

            Name = string.Empty;
            Description = string.Empty;
            FoodCategory = FoodCategory.Meat;
        }

        /// <summary>
        /// Adds ingredients to recipe as long as MaxNumOfIngredients isn't reached
        /// </summary>
        /// <param name="ingredients">Ingredients to add</param>
        /// <returns>True if add is successful, false otherwise</returns>
        public bool AddIngredient(params string[] ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                if (CurrentNumOfIngredients >= MaxNumOfIngredients || (string.IsNullOrWhiteSpace(ingredient)))
                    return false;
                if (!IngredientExists(ingredient))
                    Ingredients[VacantPos] = ingredient;
            }
            return true;
        }

        private bool IngredientExists(string newIngredient)
        {
            foreach (var ingredient in Ingredients)
            {
                if (ingredient != null)
                    if (ingredient.Equals(newIngredient))
                        return true;
            }
            return false;
        }



        /// <summary>
        /// Replaces old ingredient with new
        /// </summary>
        /// <param name="index">Index for ingredient</param>
        /// <param name="newIngredient"></param>
        /// <returns></returns>
        public bool ChangeIngredientAt(int index, string newIngredient)
        {
            if (!CheckIndex(index))
                return false;

            Ingredients[index] = newIngredient;
            return true;
        }

        /// <summary>
        /// Checks for valid index
        /// </summary>
        /// <param name="index">index of ingredient</param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            if (index > MaxNumOfIngredients - 1)
                return false;
            if (Ingredients[index] == null)
                return false;
            return true;
        }

        /// <summary>
        /// Deletes ingredient
        /// </summary>
        /// <param name="ingredient">name of ingredient</param>
        public void DeleteIngredient(string ingredient)
        {
            var index = Array.IndexOf(Ingredients, ingredient);
            Ingredients[index] = null;
        }


        /// <summary>
        /// Returns a string with all ingredients
        /// </summary>
        /// <returns>All ingredients</returns>
        public override string ToString()
        {
            var chars = Math.Min(Description.Length, 15);
            var descriptionText = Description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description";

            return $"{Name,-20} {CurrentNumOfIngredients,5} {FoodCategory.ToString(),16} {descriptionText,16}";
        }
    }
}
