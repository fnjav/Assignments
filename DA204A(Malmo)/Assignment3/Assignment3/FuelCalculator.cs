// Filip Andersson Vestman  23/10-17
using System.Threading;

namespace Assignment3
{
    public class FuelCalculator
    {
        public double CurrReading { get; set; }
        public double FuelAmount { get; set; }
        public double PrevReading { get; set; }
        public double UnitPrice { get; set; }

        /// <summary>
        /// Calculates kilometer per liter
        /// </summary>
        /// <returns>Kilometer per liter</returns>
        public double CalcConsumptionKilometerPerLiter()
        {
            return (CurrReading - PrevReading) / FuelAmount;

        }

        /// <summary>
        /// Calculates consumption per metric mile
        /// </summary>
        /// <returns>Consumption per metric mile</returns>
        public double CalcConsumptionPerMetricMile()
        {
            const double kmToMileFactor = 0.621371192;
            return CalcFuelConsumptionPerKm() / kmToMileFactor;
        }

        /// <summary>
        /// Calculates cost per km
        /// </summary>
        /// <returns>Cost per km</returns>
        public double CalcCostPerKm()
        {
            return CalcFuelConsumptionPerKm() * UnitPrice;
        }

        /// <summary>
        /// Calculates fuel consumption per km
        /// </summary>
        /// <returns>Fuel consumption per km</returns>
        public double CalcFuelConsumptionPerKm()
        {
            return FuelAmount / (CurrReading - PrevReading);
        }

        /// <summary>
        /// Calculates fuel consumption, liter per swedish mil
        /// </summary>
        /// <returns>Fuel consumption in liter per swedish mil</returns>
        public double CalcFuelConsumptionPerSweMil()
        {
            return CalcFuelConsumptionPerKm() * 10;
        }

        /// <summary>
        /// Validates the values
        /// </summary>
        /// <returns></returns>
        public bool GetValidateOdometerValues()
        {
            return CurrReading > PrevReading && PrevReading >= 0 && FuelAmount >= 0 && UnitPrice >= 0;
        }
    }
}
