using System;
using System.Collections.Generic;
using Assignment1.Enums;

namespace Assignment1.AnimalFiles
{
    /// <summary>
    /// Manages animals
    /// </summary>
    public class AnimalManager
    {
        private List<Animal> _animalList = new List<Animal>();
        private int _numberOfAnimals = 0;

        /// <summary>
        /// Information of each pet
        /// </summary>
        /// <returns>Array filled with information</returns>
        public string[] ToStringArray()
        {
            var animals = new string[_animalList.Count];

            for (int i = 0; i < _animalList.Count; i++)
            {
                animals[i] = _animalList[i].ToString();
            }

            return animals;
        }

        /// <summary>
        /// Ugly method for adding a new animal to the list, too many parameters
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="category">Category</param>
        /// <param name="species">Species</param>
        /// <param name="categorySpecific">Specific information for the category</param>
        /// <param name="animalSpecific">Specific information for the species</param>
        public void AddNewAnimal(string name, double age, GenderType gender, CategoryType category, string species, string categorySpecific, string animalSpecific)
        {
            var animal = AnimalFactory.CreateAnimal(category, species, ++_numberOfAnimals, categorySpecific, animalSpecific);
            animal.Name = name;
            animal.Age = age;
            animal.Gender = gender;
            _animalList.Add(animal);
        }




    }
}
