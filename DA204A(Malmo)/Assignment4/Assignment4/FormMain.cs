using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Filip Andersson Vestman
// 12/11-2017

namespace Assignment4
{
    public partial class FormMain : Form
    {
        private const int _maxIngredients = 50;
        private const int _maxRecipes = 200;
        private Recipe _currentRecipe = new Recipe(_maxIngredients);
        private Recipe _ingredientsRecipe = new Recipe(_maxIngredients); // Used for ingredients only
        private RecipeManager _recipeManager = new RecipeManager(_maxRecipes);

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
            AcceptButton = btnAddRecipe;
        }

        /// <summary>
        /// Resets GUI to default values
        /// </summary>
        private void InitializeGUI()
        {
            cmbCategory.SelectedIndex = 0;
            txtDescription.Text = "";
            txtNameOfRecipe.Text = "";
        }

        /// <summary>
        /// Adds recipe to recipe manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNameOfRecipe.Text))
            {
                AddRecipe();
                UpdateList();
                InitializeGUI();
                _ingredientsRecipe = new Recipe(_maxIngredients);
            }
        }

        /// <summary>
        /// Creates a new recipe and adds it to recipe manager
        /// </summary>
        private void AddRecipe()
        {
            _currentRecipe = new Recipe(_maxIngredients); // Prevents editing another recipe instead of adding
            _ingredientsRecipe.Ingredients.CopyTo(_currentRecipe.Ingredients, 0);
            UpdateRecipe();
            _recipeManager.Add(_currentRecipe);
            _currentRecipe = new Recipe(_maxIngredients); // Prevents using the same recipe for other tasks

        }

        /// <summary>
        /// Updates current recipe
        /// </summary>
        private void UpdateRecipe()
        {
            _currentRecipe.Name = txtNameOfRecipe.Text;
            _currentRecipe.FoodCategory = (FoodCategory)cmbCategory.SelectedIndex;
            _currentRecipe.Description = txtDescription.Text;
        }

        /// <summary>
        /// Shows values of recipe in the GUI
        /// </summary>
        private void RecipeToGUI(Recipe recipe)
        {
            txtNameOfRecipe.Text = recipe.Name;
            txtDescription.Text = recipe.Description;
            cmbCategory.SelectedIndex = (int)recipe.FoodCategory;
        }

        /// <summary>
        /// Updates ListBox
        /// </summary>
        private void UpdateList()
        {
            lstRecipes.Items.Clear();

            var recipeList = _recipeManager.RecipeListToString();

            foreach (var recipe in recipeList)
                lstRecipes.Items.Add(recipe);
        }

        /// <summary>
        /// currentRecipe = selected recipe and shows it in GUI
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ingredientsRecipe = new Recipe(_maxIngredients);

            if (lstRecipes.SelectedIndex >= 0)
            {
                _currentRecipe = _recipeManager.GetRecipe(FindRecipeName());
                var recipe = _recipeManager.GetRecipe(FindRecipeName());
                RecipeToGUI(recipe);
            }
        }

        /// <summary>
        /// Find the name of the recipe
        /// </summary>
        /// <returns></returns>
        private string FindRecipeName()
        {
            var tmp = lstRecipes.SelectedItem.ToString();

            var name = tmp.Split(' ');

            return name[0];
        }

        /// <summary>
        /// Updates recipe and updates the list
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            _currentRecipe.Ingredients = _ingredientsRecipe.Ingredients;
            UpdateRecipe();
            UpdateList();
        }

        /// <summary>
        /// Deletes recipe from _recipeManager, updates the list and creates a new recipe for _currentRecipe
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _recipeManager.Delete(_currentRecipe);
            UpdateList();
            _currentRecipe = new Recipe(_maxIngredients);
        }

        /// <summary>
        /// Opens modify ingredients form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnModifyIngredients_Click(object sender, EventArgs e)
        {
            _ingredientsRecipe = new Recipe(_maxIngredients);
            _currentRecipe.Ingredients.CopyTo(_ingredientsRecipe.Ingredients, 0);
            var formIngredient = new FormIngredient(_ingredientsRecipe);
            formIngredient.ShowDialog();
            UpdateList();
        }

        /// <summary>
        /// Resets current recipe to a new one
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            _currentRecipe = new Recipe(_maxIngredients);
            InitializeGUI();
        }
    }
}