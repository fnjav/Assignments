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
    public partial class FormIngredient : Form
    {
        private int _selectedIndex = -1;
        public Recipe Recipe { get; private set; }


        /// <summary>
        /// Returns selected item as string
        /// </summary>
        private string SelectedItemToString => lstIngredients.SelectedItem.ToString();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="recipe">Recipe</param>
        public FormIngredient(Recipe recipe)
        {
            InitializeComponent();
            Recipe = recipe;
            UpdateGUI();
            this.Text = "Modify ingredients";
            AcceptButton = btnAdd;
        }

        /// <summary>
        /// Updates GUI
        /// </summary>
        private void UpdateGUI()
        {
            lblNum.Text = Recipe.CurrentNumOfIngredients.ToString();
            UpdateButtons();
            UpdateList();
        }

        /// <summary>
        /// Updates ListBox
        /// </summary>
        private void UpdateList()
        {
            lstIngredients.Items.Clear();
            foreach (var ingredient in Recipe.Ingredients)
            {
                if (!string.IsNullOrEmpty(ingredient))
                    lstIngredients.Items.Add(ingredient);
            }
        }

        /// <summary>
        /// Adds ingredient and calls UpdateGUI
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Recipe.AddIngredient(txtIngredient.Text);
            txtIngredient.Text = string.Empty;
            UpdateGUI();
        }

        /// <summary>
        /// Updates selected index and calls UpdateButtons
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = lstIngredients.SelectedIndex;
            UpdateButtons();

        }

        /// <summary>
        /// Enables/disables Edit and Delete buttons
        /// </summary>
        private void UpdateButtons()
        {
            if (_selectedIndex >= 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Deletes ingredient
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Recipe.DeleteIngredient(SelectedItemToString);
            UpdateGUI();
        }

        /// <summary>
        /// Edits ingredient
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var formEdit = new FormEdit();
            var dialogResult = formEdit.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var index = Recipe.Ingredients
                .Where(i => i != null)
                .FirstOrDefault(i => i.Equals(SelectedItemToString));


                Recipe.Ingredients[_selectedIndex] = formEdit.Value;
                UpdateGUI();
            }


        }

    }
}
