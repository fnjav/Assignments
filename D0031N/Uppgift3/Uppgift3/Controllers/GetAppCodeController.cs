using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Uppgift3.Controllers
{
    [Produces("application/json")]
    [Route("api/GetAppCode")]
    public class GetAppCodeController : Controller
    {
        private Dictionary<string, string> _courses; // fake db

        /// <summary>
        /// Returns registration code or "invalid"
        /// </summary>
        /// <param name="course">Course</param>
        /// <param name="term">Term</param>
        /// <returns>Registration code or "invalid"</returns>
        [HttpGet]
        public string Get(string course, string term)
        {
            InitializeDictionary();

            try
            {
                return _courses[course] + $":{term}";
            }
            catch (Exception)
            {
                return "invalid";
            }
        }

        /// <summary>
        /// Initializes dictionary with courses and their registration code
        /// </summary>
        private void InitializeDictionary()
        {
            _courses = new Dictionary<string, string>
            {
                { "D0031N", "LTU-1" },
                { "D0023E", "LTU-2" },
                { "D0005N", "LTU-3" },
                { "D0006N", "LTU-4" },
                { "I0015N", "LTU-5" }
            };
        }
    }
}