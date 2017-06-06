using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;

namespace Uppgift3
{
    public class ApiHandler
    {
        private readonly string _ideal;
        private readonly string _courseCode;
        private readonly string _term;
        private readonly string _examNumber;
        private readonly string _grade;
        private string _registrationCode;

        public ApiHandler(string ideal, string courseCode, string term, string examNumber, string grade)
        {
            _ideal = ideal;
            _courseCode = courseCode;
            _term = term;
            _examNumber = examNumber;
            _grade = grade;
        }

        /// <summary>
        /// Returns a string of result
        /// </summary>
        /// <returns>Result or "Invalid"</returns>
        public override string ToString()
        {
            if (GetAppCode())
                if (CheckStudOnCourse())
                {
                    return RegisterResult();
                }

            return "Invalid";
        }

        /// <summary>
        /// Gets registration code for course
        /// </summary>
        /// <returns>Registration code if valid, "invalid" otherwise</returns>
        private bool GetAppCode()
        {
            var result = ConnectToAPI("http://localhost:57441/api/getappcode", $"?course={_courseCode}&term={_term}")
                .Replace("\"", string.Empty); // Tar bort "" från svaret

            if (result.Equals("invalid"))
                return false;

            _registrationCode = result;
            return true;
        }

        /// <summary>
        /// Checks if student is registered to course
        /// </summary>
        /// <returns>True is true, false otherwise</returns>
        private bool CheckStudOnCourse()
        {

            var result = ConnectToAPI("http://localhost:57441/api/checkstudoncourse", $"?code={_registrationCode}&ideal={_ideal}")
                .Replace("\"", string.Empty); // Tar bort "" från svaret

            if (result.Equals("invalid"))
                return false;

            return true;

        }

        /// <summary>
        /// Tries to register result
        /// </summary>
        /// <returns>Result of registration</returns>
        private string RegisterResult()
        {
            var result = ConnectToAPI("http://localhost:57441/api/regres", $"?ideal={_ideal}&registrationCode={_registrationCode}&examNumber={_examNumber}&grade={_grade}")
                .Replace("\"", string.Empty); // Tar bort "" från svaret

            return result;

        }

        /// <summary>
        /// Conencts to an API and returns result
        /// </summary>
        /// <param name="url">URL of API</param>
        /// <param name="urlParameters">Parameters</param>
        /// <returns>Result or "invalid" if there's no response</returns>
        private string ConnectToAPI(string url, string urlParameters)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);

            var response = client.GetAsync(urlParameters).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                return result; // Ska inte returnera, ska bara skriva in värde i _registrationCode

            }
            else
            {
                return "invalid";
            }
        }

    }
}
