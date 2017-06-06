using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Enums;
using System.Windows.Forms;
using Assignment2.AnimalFiles;

namespace Assignment2
{
    public partial class FormMain : Form
    {
        AnimalManager _animalManager = new AnimalManager();

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializes GUI
        /// </summary>
        private void InitializeGUI()
        {
            lblDescription.Text = string.Format("{0,-5}{1,-20}{2,-15}{3,-10}{4,-40}", "ID", "Name", "Age", "Gender", "Special Characteristics");
            lstGender.DataSource = Enum.GetNames(typeof(GenderType));
            lstCategory.DataSource = Enum.GetNames(typeof(CategoryType));
            lblFeedingResponse.Text = "";
            lblFeedingDetailedResponse.Text = "";
        }

        /// <summary>
        /// Updates GUI
        /// </summary>
        private void UpdateGUI()
        {
            lstRegisteredAnimals.DataSource = _animalManager.ToStringArray();
        }

        /// <summary>
        /// Updates Animal ListBox to the right category
        /// </summary>
        /// <param name="category">Category of animal</param>
        private void UpdateAnimalList(CategoryType category)
        {
            switch (category)
            {
                case CategoryType.Bird:
                    lstAnimal.DataSource = Enum.GetNames(typeof(BirdType));
                    break;
                case CategoryType.Insect:
                    lstAnimal.DataSource = Enum.GetNames(typeof(InsectType));
                    break;
                case CategoryType.Mammal:
                    lstAnimal.DataSource = Enum.GetNames(typeof(MammalType));
                    break;
                case CategoryType.Marine:
                    lstAnimal.DataSource = Enum.GetNames(typeof(MarineType));
                    break;
                case CategoryType.Reptile:
                    lstAnimal.DataSource = Enum.GetNames(typeof(ReptileType));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates category label
        /// </summary>
        /// <param name="category">Category to update for</param>
        private void UpdateCategory(CategoryType category)
        {
            var categoryDictionary = FillDictionaryWithCategories();
            grpAnimal.Text = category.ToString();
            lblSpecificCategory.Text = categoryDictionary[category];
        }

        /// <summary>
        /// Updates specific species label
        /// </summary>
        /// <param name="animal">Species to update for</param>
        private void UpdateSpecificAnimal(string animal)
        {
            var animalDictionary = FillDictionaryWithAnimals();
            lblSpecificAnimal.Text = animalDictionary[animal];

        }

        /// <summary>
        /// Returns a dictionary with categories
        /// </summary>
        /// <returns>Dictionary with categories and their description</returns>
        private Dictionary<CategoryType, string> FillDictionaryWithCategories()
        {
            return new Dictionary<CategoryType, string>
            {
                { CategoryType.Bird, "Wingspan"},
                { CategoryType.Insect, "Number of legs"},
                { CategoryType.Mammal, "Number of teeth"},
                { CategoryType.Marine, "Swim speed"},
                { CategoryType.Reptile, "Length of tongue"}
            };
        }

        /// <summary>
        /// Returns a dictionary with species
        /// </summary>
        /// <returns>Dictionary with species and their description</returns>
        private Dictionary<string, string> FillDictionaryWithAnimals()
        {
            return new Dictionary<string, string>
            {
                {"Dove", "Product" },
                {"Eagle", "Colour of beak" },
                {"Pelican", "Number of fish in throat pouch" },
                {"Bee", "Honey produced" },
                {"Butterfly", "Pattern" },
                {"Ant", "Colony" },
                {"Dog", "Tail length" },
                {"KillerWhale", "Kills" },
                {"Deer", "Sets of horns" },
                {"Wolf", "Howl" },
                {"Goldfish", "Memory span" },
                {"Shark", "Sharpness of teeth" },
                {"Frog", "Jump height" },
                {"Lizard", "Camouflage" },
                {"Snake", "Crawl speed" },
            };

        }


        /// <summary>
        /// Event handler for changing index
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnimalList((CategoryType)lstCategory.SelectedIndex);
            UpdateCategory((CategoryType)lstCategory.SelectedIndex);


        }

        /// <summary>
        /// Event handler for changing index
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void lstAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateSpecificAnimal(lstAnimal.SelectedItem.ToString());
        }

        /// <summary>
        /// Event handler for add button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateAnimal();
            UpdateGUI();
        }

        /// <summary>
        /// Starts the process of creating an animal
        /// </summary>
        private void CreateAnimal()
        {

            if (CheckInput())
                _animalManager.AddNewAnimal(txtName.Text,
                    double.Parse(txtAge.Text),
                    (GenderType)lstGender.SelectedIndex,
                    (CategoryType)lstCategory.SelectedIndex,
                    lstAnimal.SelectedValue.ToString(),
                    txtSpecificCategory.Text,
                    txtSpecificAnimal.Text);

            else
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Makes sure input is okey
        /// </summary>
        /// <returns>True if input is ok, false otherwise</returns>
        private bool CheckInput()
        {
            var success = double.TryParse(txtAge.Text, out var number);
            return (success
                && number > 0
                && !string.IsNullOrEmpty(txtName.Text)
                && !string.IsNullOrEmpty(txtSpecificCategory.Text)
                && !string.IsNullOrEmpty(txtSpecificAnimal.Text));
        }

        /// <summary>
        /// Event for index changing
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void lstRegisteredAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFeeding(lstRegisteredAnimals.SelectedIndex);
        }

        /// <summary>
        /// Updates feeding for the selected animal
        /// </summary>
        /// <param name="index">Index of the animal</param>
        private void UpdateFeeding(int index)
        {
            lblFeedingDetailedResponse.Text = _animalManager.GetSpecies(index); // Species
            lblFeedingResponse.Text = _animalManager.GetEaterType(index).ToString(); // Eater type
            lblFeedingDetailedResponse.Text += $"\n\n{_animalManager.GetFeedingSchedule(index).ToString()}"; // Detailed feeding
        }
    }
}
