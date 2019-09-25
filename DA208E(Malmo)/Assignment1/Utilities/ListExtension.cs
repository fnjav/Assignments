using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public static class ListExtension
    {
        public static T Pop<T>(this List<T> list)
        {
            var item = list.FirstOrDefault();
            list.Remove(item);
            return item;
        }

        public static int BlackjackSum(this IEnumerable<int> values)
        {
            // Fungerar detta?
            var sum = values.Select(v => Math.Min(v, 10)).Sum();

            // Add high value of ace if possible
            values.Where(v => v == 1).ToList().ForEach(a =>
            {
                if (sum <= 10) sum += 10;
            });

            return sum;

            //var sum = 0;
            //var numberOfAces = 0;

            //foreach (var v in values)
            //{
            //    if (v == 1) numberOfAces++;

            //    sum += Math.Min(10, v); // 11, 12 and 13 are worth 10
            //}

            //for (var i = 0; i < numberOfAces; i++)
            //{
            //    if (sum <= 10) sum += 10; // Can use high ace value
            //}

            //return sum;
        }
    }
}
