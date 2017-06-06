using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Enums;

namespace Assignment1.AnimalFiles
{
    public abstract class Animal
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


    }
}
