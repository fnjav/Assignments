using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Uppgift3.Controllers
{
    [Produces("application/json")]
    [Route("api/CheckStudOnCourse")]
    public class CheckStudOnCourseController : Controller
    {
        private List<Course> _courseList = new List<Course>(); // Fake db        

        /// <summary>
        /// Returns valid or invalid
        /// </summary>
        /// <param name="code">registration code</param>
        /// <param name="ideal">ideal of student</param>
        /// <returns>Valid if valid, invalid otherwise</returns>
        [HttpGet]
        public string Get(string code, string ideal)
        {
            InitializeFakeDatabase();

            if (ControlStudent(code, ideal))
                return "valid";
            return "invalid";
        }

        /// <summary>
        /// Returns true if student is taking course, false otherwise
        /// </summary>
        /// <param name="code">course code</param>
        /// <param name="ideal">ideal of student</param>
        /// <returns></returns>
        private bool ControlStudent(string code, string ideal)
        {
            try
            {
                return (_courseList.FirstOrDefault(c => c.Code.Equals(code))
                .StudentList.FirstOrDefault(s => s.Ideal.Equals(ideal)) != null); //Kraschar om code är fel, try catch fulfix
            }
            catch (Exception)
            {
                return false;
            }

        }


        /// <summary>
        /// Initializes a fake database for this controller
        /// </summary>
        private void InitializeFakeDatabase()
        {
            var students = new Models.Student[] // Fake studenter
            {
                new Models.Student{Ideal="stud-1"},
                new Models.Student{Ideal="stud-2"},
                new Models.Student{Ideal="stud-3"},
                new Models.Student{Ideal="stud-4"},
                new Models.Student{Ideal="stud-5"}

            };

            for (int i = 1; i <= 5; i++) // 5st fake kurser
            {
                var course = new Course() { Code = "LTU-" + i + ":H17" };
                foreach (var student in students)
                {
                    course.AddNewStudent(student);
                }
                _courseList.Add(course);
            }

            _courseList.ElementAt(3).AddNewStudent(new Models.Student() { Ideal = "stud-6" }); // stud-6 läser bara LTU-4:H17.
        }

    }
}