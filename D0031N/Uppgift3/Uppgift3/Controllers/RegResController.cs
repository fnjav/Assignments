using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Data;

namespace Uppgift3.Controllers
{
    [Produces("application/json")]
    [Route("api/RegRes")]
    public class RegResController : Controller
    {
        private readonly GaragetContext _context;


        public RegResController(GaragetContext studentContext)
        {
            _context = studentContext;
        }



        /// <summary>
        /// Registers a new entry to the database
        /// </summary>
        /// <param name="ideal">Ideal of student</param>
        /// <param name="registrationCode">Registration code of course</param>
        /// <param name="examNumber">Exam number</param>
        /// <param name="grade">Grade</param>
        /// <returns>"Invalid" or "Resultatet har sparats i LADOK" depending on the outcome</returns>
        [HttpGet]
        public string Get(string ideal, string registrationCode, string examNumber, string grade)
        {
            var grades = _context.Students
                .Where(s => s.Ideal.Equals(ideal));

            var exists = false;
            foreach (var g in grades)
            {
                if (g.RegistrationCode.Equals(registrationCode) && g.ExamNumber.Equals(examNumber))
                {
                    exists = true;
                }
            }

            if (!exists)
            {
                var entry = new Models.Student()
                {
                    Ideal = ideal,
                    RegistrationCode = registrationCode,
                    ExamNumber = examNumber,
                    Grade = grade
                };

                _context.Add(entry);
                _context.SaveChanges();
                return "Resultatet har sparats i LADOK!";
            }

            /*
            // All information om viss ideal
            //var dbEntries = GetData(ideal);
            // Alla entries
            //var dbEntries = GetAllData();

            // Output för test
            var result = string.Empty;
            foreach (var entry in dbEntries)
            {
                result += $"[Id: {entry.Id}, Ideal: {entry.Ideal}, Registration Code: {entry.RegistrationCode}, Exam Number: {entry.ExamNumber}] ";
            }

            return result;*/

            return "invalid";
        }

        /// <summary>
        /// Returns list with all data
        /// </summary>
        /// <returns>List of Models.Student</returns>
        private List<Models.Student> GetAllData()
        {
            return _context.Students.ToList();
        }

        /// <summary>
        /// Returns list with data of a specific student
        /// </summary>
        /// <param name="ideal">Ideal of student</param>
        /// <returns>List of Models.Student with specific ideal</returns>
        private List<Models.Student> GetData(string ideal)
        {
            return _context.Students
                 .Where(s => s.Ideal.Equals(ideal))
                 .ToList();
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

    }
}