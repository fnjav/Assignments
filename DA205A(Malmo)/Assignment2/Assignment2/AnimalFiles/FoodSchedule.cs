using System;
using System.Collections.Generic;


namespace Assignment2.AnimalFiles
{
    public class FoodSchedule
    {
        private List<string> _foodDescriptionList = new List<string>();
        public int Count => _foodDescriptionList.Count;

        public FoodSchedule()
        {

        }

        public FoodSchedule(List<string> foodList)
        {
            _foodDescriptionList = foodList;
        }

        /// <summary>
        /// Adds new item to the foodschedule list
        /// </summary>
        /// <param name="item">Item to be added</param>
        /// <returns>True if successful</returns>
        public bool AddFoodScheduleItem(string item)
        {
            _foodDescriptionList.Add(item);
            return true;
        }

        /// <summary>
        /// Replaces item at index
        /// </summary>
        /// <param name="text">New item</param>
        /// <param name="index">Index</param>
        /// <returns>True if successful, false otherwise</returns>
        public bool ChangeFoodScheduleItem(string text, int index)
        {
            if (ValidateIndex(index))
            {
                _foodDescriptionList[index] = text;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Deletes item at index
        /// </summary>
        /// <param name="index">Index of item to be deleted</param>
        /// <returns>True if successful, false otherwise</returns>
        public bool DeleteFoodScheduleItem(int index)
        {
            if (ValidateIndex(index))
            {
                _foodDescriptionList.RemoveAt(index);
                return true;
            }

            return false;
        }

        public string DescribeNoFeedingRequired()
        {
            return "No feeding required";
        }

        /// <summary>
        /// Returns food schedule
        /// </summary>
        /// <returns>Food schedule</returns>
        public string GetFoodSchedule()
        {
            if (Count == 0)
                return DescribeNoFeedingRequired();

            return $"To be fed {Count} times as follows:\n{ToString()}";
        }

        public override string ToString()
        {
            var output = string.Empty;
            foreach (var item in _foodDescriptionList)
            {
                output += $"{item}\n"; // ny rad?
            }
            return output;
        }

        /// <summary>
        /// Validates index
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>True if index is within range, false otherwise</returns>
        public bool ValidateIndex(int index)
        {
            return (index >= 0 && index < Count);
        }


    }
}
