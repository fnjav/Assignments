//Filip Andersson Vestman 07/01-2018
using System;

namespace Assignment6
{
    public class Task
    {
        public String Date { get; private set; }
        public string Hour { get; private set; }
        public Priorities Priority { get; private set; }
        public string Description { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="hour">Hour</param>
        /// <param name="priority">Priority</param>
        /// <param name="description">Description</param>
        public Task(string date, string hour, Priorities priority, string description)
        {
            Date = date;
            Hour = hour;
            Priority = priority;
            Description = description;
        }

        /// <summary>
        /// Returns a string with information
        /// </summary>
        /// <returns>String with information</returns>
        public override string ToString()
        {
            return $"{Date,-30}" +
                $"{Hour,-15}" +
                $"{Priority.ToString().Replace('_', ' '),-20}" +
                $"{Description}";
        }

        /// <summary>
        /// Returns a cloned task of itself
        /// </summary>
        /// <returns>Cloned task</returns>
        public Task Clone()
        {
            return new Task(Date, Hour, Priority, Description);
        }
    }
}
