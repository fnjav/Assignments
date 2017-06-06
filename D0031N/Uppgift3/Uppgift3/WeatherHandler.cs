using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Uppgift3
{
    public class WeatherHandler
    {
        private readonly string _city;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="city">City of choice</param>
        public WeatherHandler(string city)
        {
            _city = city;
        }

        /// <summary>
        /// Returns result as a string
        /// </summary>
        /// <returns>Result</returns>
        public override string ToString()
        {
            return GetTemperature();
        }

        /// <summary>
        /// Hardcoded URL of each city
        /// </summary>
        /// <returns>URL of the xml</returns>
        private string GetURL()
        {
            switch (_city)
            {
                case "Lulea":
                    return "http://www.yr.no/place/sweden/norrbotten/lule%C3%A5/forecast.xml";
                case "Karlstad":
                    return "http://www.yr.no/place/sweden/v%C3%A4rmland/karlstad/forecast.xml";
                case "Stockholm":
                    return "http://www.yr.no/place/sweden/stockholm/stockholm/forecast.xml";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the weather for the city of choice
        /// </summary>
        /// <returns>Result</returns>
        private string GetTemperature()
        {
            var url = GetURL();
            var xml = XDocument.Load(url);

            var search = xml.XPathSelectElements("/weatherdata/forecast/tabular//time");

            var result = search.Select(e => new
            {
                From = FixDateAndTime(e.Attribute("from").Value),
                To = FixDateAndTime(e.Attribute("to").Value),
                TemperatureUnit = e.Element("temperature").Attribute("unit").Value,
                TemperatureValue = e.Element("temperature").Attribute("value").Value,
            }).ToList();

            var output = $"Data taken from {url}\n\n";
            foreach (var item in result)
            {
                output += $"Från {item.From} till {item.To} är det {item.TemperatureValue} grader {item.TemperatureUnit} i {_city}\n";
            }

            return output;
        }

        /// <summary>
        /// Fixes formatting
        /// </summary>
        /// <param name="time">String to be fixed</param>
        /// <returns>More pretty string</returns>
        private string FixDateAndTime(string time)
        {
            var newTime = time.Substring(0, 10);
            newTime += " " + time.Substring(11, 5);
            return newTime;
        }
    }
}
