using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    interface IAnimal
    {
        GenderType Gender { get; set; }
        int Id { get; }
        string Name { get; set; }

        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();
    }
}
