using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public interface IStudentRegistration
    {
        string Ideal { get; }
        string CourseCode { get; }
        string Term { get; }
        string ExamNumber { get; }
        string Grade { get; }
    }
}
