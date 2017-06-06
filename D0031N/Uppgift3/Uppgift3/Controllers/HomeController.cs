using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uppgift3.Models;

namespace Uppgift3.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult RegisterResult()
        {
            return View();
        }

        public IActionResult Weather()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Registers result to the database
        /// </summary>
        /// <param name="ideal">Ideal of student</param>
        /// <param name="kurskod">Course code</param>
        /// <param name="termin">Term</param>
        /// <param name="provnummer">Exam number</param>
        /// <param name="betyg">Grade to be submitted</param>
        /// <returns></returns>
        public string RegisterResultButtonClick(string ideal, string kurskod, string termin, string provnummer, string betyg)
        {
            var apiHandler = new ApiHandler(ideal, kurskod, termin, provnummer, betyg);
            return apiHandler.ToString();
        }

        /// <summary>
        /// Shows weather
        /// </summary>
        /// <param name="stad">City of choice</param>
        /// <returns>String with times and temperature</returns>
        public string ShowWeatherButtonClick(string stad)
        {
            var weatherHandler = new WeatherHandler(stad);
            return weatherHandler.ToString();
        }
    }
}
