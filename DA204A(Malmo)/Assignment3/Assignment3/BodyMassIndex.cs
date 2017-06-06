// Filip Andersson Vestman  29/10-17
namespace Assignment3
{
    public class BodyMassIndex
    {
        public double Height { get; set; } // as cm or inch
        public double Weight { get; set; } // as kg or lb
        public Unit Unit { get; set; }

        /// <summary>
        /// Calculates BMI
        /// </summary>
        /// <returns>BMI</returns>
        public double CalculateBMI()
        {
            if (Unit == Unit.Metric)
                return Weight / (Height * Height / 10000); // Height as meter
            return 703 * Weight / (Height * Height);
        }

        /// <summary>
        /// Decides category
        /// </summary>
        /// <returns>Category</returns>
        public string CalculateCategory()
        {
            var bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Underweight";
            if (bmi < 25)
                return "Normal weight";
            if (bmi < 30)
                return "Overweight (Pre-obesity)";
            if (bmi < 35)
                return "Obesity class I";
            if (bmi < 40)
                return "Obesity class  II";
            else
                return "Obesity class III";
        }

        /// <summary>
        /// Returns info message
        /// </summary>
        /// <returns>Info message</returns>
        public string InfoMessage()
        {
            return "Normal BMI is between 18.5 and 24.9.";
        }
    }
}
