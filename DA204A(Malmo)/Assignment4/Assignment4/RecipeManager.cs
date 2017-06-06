using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Filip Andersson Vestman
// 12/11-2017

namespace Assignment4
{
    public class RecipeManager
    {
        private Recipe[] _recipes;

        public int NumOfItems => _recipes.Where(r => r != null).Count();

        private int VacantPos => Array.FindIndex(_recipes, r => r == null);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="max">Max number of ingredients</param>
        public RecipeManager(int max)
        {
            _recipes = new Recipe[max];
        }

        /// <summary>
        /// Adds a recipe to the list
        /// </summary>
        /// <param name="recipe">Recipe to be added</param>
        /// <returns></returns>
        public bool Add(Recipe recipe)
        {
            if (RecipeExists(recipe.Name))
                return false;
            _recipes[VacantPos] = recipe;
            return true;
        }

        /// <summary>
        /// Deletes recipe
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public bool Delete(Recipe recipe)
        {
            var index = Array.FindIndex(_recipes, r => r == recipe);
            if (index < 0)
                return false;
            _recipes[index] = null;
            return true;
        }

        /// <summary>
        /// Add ingredients to a recipe
        /// </summary>
        /// <param name="name">Name of the recipe</param>
        /// <param name="ingredients">Ingredients for the recipe</param>
        /// <returns>Bool if succesful, false otherwise</returns>
        public bool Add(string name, string[] ingredients) // Används inte i programmet någonstans
        {
            if (!RecipeExists(name))
                return false;

            var recipe = _recipes
                .Where(r => r != null)
                .First(r => r.Name.Equals(name));

            foreach (var ingredient in ingredients)
            {
                if (!recipe.AddIngredient(ingredient))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Converts recipes to string
        /// </summary>
        /// <returns>Recipes</returns>
        public string[] RecipeListToString()
        {

            var recipeList = new string[NumOfItems];

            var count = 0;
            for (int i = 0; i < _recipes.Length; i++)
            {
                if (_recipes[i] != null) // Ifall det finns tomma platser i arrayen
                {
                    recipeList[count] = _recipes[i].ToString();
                    count++;
                    if (count >= NumOfItems)
                        break;
                }
            }
            return recipeList;
        }

        /// <summary>
        /// Checks if recipe exists with same name
        /// </summary>
        /// <param name="name">name of the recipe</param>
        /// <returns>true if it exists, false otherwise</returns>
        public bool RecipeExists(string name)
        {
            foreach (var recipe in _recipes)
            {
                if (recipe != null)
                    if (recipe.Name.Equals(name))
                        return true;
            }
            return false;
        }

        /// <summary>
        /// Find recipe from the array
        /// </summary>
        /// <param name="name">name of the recipe</param>
        /// <returns>The recipe with matching name or new recipe</returns>
        public Recipe GetRecipe(string name)
        {
            return _recipes
                .Where(r => r != null)
                .First(r => r.Name.Equals(name));
        }
    }
}
