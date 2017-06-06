// Filip Andersson Vestman  29/10-17
using System.Collections.Generic;

namespace Assignment3
{

    public class CalorieCalculator
    {
        public int Age { get; set; }
        public double Height { get; set; } // as cm or inch
        public double Weight { get; set; } // as kg or lb
        public Activity Activity { get; set; }
        public Gender Gender { get; set; }
        public Unit Unit { get; set; }

        /// <summary>
        /// Calculates BMR
        /// </summary>
        /// <returns>BMR</returns>
        public double CalculateBMR()
        {
            double bmr;
            if (Unit == Unit.Metric)
                bmr = 10 * Weight + 6.25 * Height - 5 * Age;
            else
                bmr = 10 * (Weight / 2.2046226218) + 6.25 * (Height * 2.54) - 5 * Age;
            if (Gender == Gender.Female)
                return bmr - 161;
            return bmr + 5;
        }

        /// <summary>
        /// Builds output as a list of strings
        /// </summary>
        /// <param name="name">Name of the person</param>
        /// <param name="bmr">BMR</param>
        /// <returns>Result as a list</returns>
        public List<string> BuildOutput(string name, double bmr)
        {
            var intake = bmr * (double)Activity / 1000;
            return new List<string>
            {
                $"BMR RESULTS FOR {name.ToUpper()}",
                string.Empty,
                $"Your BMR (calories/day)\t\t\t{bmr,20:0.0}",
                $"Calories to maintain your weight\t{intake,20:0.0}",
                $"Calories to lose 0,5 kg per week\t{intake - 500,20:0.0}",
                $"Calories to lose 1 kg per week\t\t{intake - 1000,20:0.0}",
                $"Calories to gain 0.5 kg per week\t{intake + 500,20:0.0}",
                $"Calories to gain 1 kg per week\t\t{intake + 1000,20:0.0}",
                string.Empty,
                $"Losing more than 1000 calories per days is to be avoided."
            };
        }
    }
}
