//Filip Andersson Vestman 07/01-2018
using System.Collections.Generic;

namespace Assignment6
{
    public class TaskManager
    {

        private List<Task> _tasks = new List<Task>();
        public int Count => _tasks.Count;

        /// <summary>
        /// Add task to list
        /// </summary>
        /// <param name="task">Task to be added</param>
        public void Add(Task task)
        {
            _tasks.Add(task);
        }

        /// <summary>
        /// Remove task at index
        /// </summary>
        /// <param name="index">Index of task to be removed</param>
        public void RemoveAt(int index)
        {
            _tasks.RemoveAt(index);
        }

        /// <summary>
        /// Returns a copy of the Task
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Task GetAt(int index)
        {
            return _tasks[index].Clone();
        }

        /// <summary>
        /// Returns tasks as list of strings
        /// </summary>
        /// <returns>Tasks and their information</returns>
        public List<string> ToList()
        {
            var output = new List<string>();
            _tasks.ForEach(t => output.Add(t.ToString()));
            return output;
        }

        /// <summary>
        /// Replaces task at index
        /// </summary>
        /// <param name="task">new task</param>
        /// <param name="index">index of old task</param>
        public void ReplaceAt(Task task, int index)
        {
            _tasks[index] = task;
        }

        /// <summary>
        /// Clears the list
        /// </summary>
        public void Clear()
        {
            _tasks.Clear();
        }
    }
}
