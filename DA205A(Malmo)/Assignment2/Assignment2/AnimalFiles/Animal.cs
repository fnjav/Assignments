using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public GenderType Gender { get; set; }
        public int Id { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of animal</param>
        public Animal(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Returns id, name, age and gender of the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return $"{Id,-5}" +
                $"{Name,-20}" +
                $"{Age,-10}" +
                $"{Gender.ToString(),-10}";
        }

        /// <summary>
        /// Returns Eater Type
        /// </summary>
        /// <returns>EaterType</returns>
        public abstract EaterType GetEaterType();

        /// <summary>
        /// Returns food schedule
        /// </summary>
        /// <returns>FoodSchedule</returns>
        public abstract FoodSchedule GetFoodSchedule();

        /// <summary>
        /// Returns species as string
        /// </summary>
        /// <returns>Species</returns>
        public abstract string GetSpecies();

    }
}
