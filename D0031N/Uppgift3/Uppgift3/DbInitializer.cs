using System.Linq;

namespace Uppgift3
{
    public static class DbInitializer
    {
        /// <summary>
        /// Initializes the database, old code for testing
        /// </summary>
        /// <param name="context">Context</param>
        public static void Initialize(GaragetContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return; // DB has been seeded
            }

            /*
            var students = new Models.Student[]
            {
                new Models.Student{Ideal="filves-3"}, 
                new Models.Student{Ideal="felvge-4"},
                new Models.Student{Ideal="marluo-5", Grade="Tullverket"}
            };

            foreach (var student in students)
            {
                context.Students.Add(student);
            }*/

            context.SaveChanges();
        }
    }
}
