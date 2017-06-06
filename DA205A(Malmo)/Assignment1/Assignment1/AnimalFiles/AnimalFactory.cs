using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Enums;

namespace Assignment1.AnimalFiles
{
    /// <summary>
    /// Factory for animals
    /// </summary>
    public class AnimalFactory
    {

        /// <summary>
        /// Creates a new animal
        /// </summary>
        /// <param name="category">Category</param>
        /// <param name="species">Species</param>
        /// <param name="id">id</param>
        /// <param name="categorySpecific">Characteristics of the category</param>
        /// <param name="speciesSpecific">Characteristics of the species</param>
        /// <returns>Animal of choice</returns>
        public static Animal CreateAnimal(CategoryType category, string species, int id, string categorySpecific, string speciesSpecific)
        {
            switch (category)
            {
                case CategoryType.Bird:
                    return CreateBird((BirdType)Enum.Parse(typeof(BirdType), species), id, categorySpecific, speciesSpecific);
                case CategoryType.Insect:
                    return CreateInsect((InsectType)Enum.Parse(typeof(InsectType), species), id, categorySpecific, speciesSpecific);
                case CategoryType.Mammal:
                    return CreateMammal((MammalType)Enum.Parse(typeof(MammalType), species), id, categorySpecific, speciesSpecific);
                case CategoryType.Marine:
                    return CreateMarine((MarineType)Enum.Parse(typeof(MarineType), species), id, categorySpecific, speciesSpecific);
                case CategoryType.Reptile:
                    return CreateReptile((ReptileType)Enum.Parse(typeof(ReptileType), species), id, categorySpecific, speciesSpecific);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Creates marine
        /// </summary>
        /// <param name="marine">Species</param>
        /// <param name="id">ID</param>
        /// <param name="marineSpecific">Marine characteristics</param>
        /// <param name="speciesSpecific">Species characteristics</param>
        /// <returns>New Marine</returns>
        private static Animal CreateMarine(MarineType marine, int id, string marineSpecific, string speciesSpecific)
        {
            switch (marine)
            {
                case MarineType.Goldfish:
                    return new Goldfish(id, marineSpecific, speciesSpecific);
                case MarineType.Shark:
                    return new Shark(id, marineSpecific, speciesSpecific);
                default:
                    return null;
            }

        }

        /// <summary>
        /// Creates insect
        /// </summary>
        /// <param name="insect">Species</param>
        /// <param name="id">ID</param>
        /// <param name="insectSpecific">Insect characteristics</param>
        /// <param name="speciesSpecific">Species characteristics</param>
        /// <returns>New Insect</returns>
        private static Animal CreateInsect(InsectType insect, int id, string insectSpecific, string speciesSpecific)
        {
            switch (insect)
            {
                case InsectType.Butterfly:
                    return new Butterfly(id, insectSpecific, speciesSpecific);
                case InsectType.Bee:
                    return new Bee(id, insectSpecific, speciesSpecific);
                case InsectType.Ant:
                    return new Ant(id, insectSpecific, speciesSpecific);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Creates Bird
        /// </summary>
        /// <param name="bird">Species</param>
        /// <param name="id">ID</param>
        /// <param name="birdSpecific">Bird characteristics</param>
        /// <param name="speciesSpecific">Species characteristics</param>
        /// <returns>New Bird</returns>
        private static Animal CreateBird(BirdType bird, int id, string birdSpecific, string speciesSpecific)
        {
            switch (bird)
            {
                case BirdType.Dove:
                    return new Dove(id, birdSpecific, speciesSpecific);
                case BirdType.Eagle:
                    return new Eagle(id, birdSpecific, speciesSpecific);
                case BirdType.Pelican:
                    return new Pelican(id, birdSpecific, speciesSpecific);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Creates Reptile
        /// </summary>
        /// <param name="reptile">Species</param>
        /// <param name="id">ID</param>
        /// <param name="reptileSpecific">Reptile characteristics</param>
        /// <param name="speciesSpecific">Species characteristics</param>
        /// <returns>New Reptile</returns>
        private static Animal CreateReptile(ReptileType reptile, int id, string reptileSpecific, string speciesSpecific)
        {
            switch (reptile)
            {
                case ReptileType.Frog:
                    return new Frog(id, reptileSpecific, speciesSpecific);
                case ReptileType.Lizard:
                    return new Lizard(id, reptileSpecific, speciesSpecific);
                case ReptileType.Snake:
                    return new Snake(id, reptileSpecific, speciesSpecific);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Creates Mammal
        /// </summary>
        /// <param name="mammal">Species</param>
        /// <param name="id">ID</param>
        /// <param name="mammalSpecific">Mammal characteristics</param>
        /// <param name="speciesSpecific">Species characteristics</param>
        /// <returns>New Mammal</returns>
        private static Animal CreateMammal(MammalType mammal, int id, string mammalSpecific, string speciesSpecific)
        {
            switch (mammal)
            {
                case MammalType.Dog:
                    return new Dog(id, mammalSpecific, speciesSpecific);
                case MammalType.Wolf:
                    return new Wolf(id, mammalSpecific, speciesSpecific);
                case MammalType.Deer:
                    return new Deer(id, mammalSpecific, speciesSpecific);
                case MammalType.KillerWhale:
                    return new KillerWhale(id, mammalSpecific, speciesSpecific);
                default:
                    return null;
            }
        }
    }
}
