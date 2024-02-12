using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson1
{
    internal static class Values
    {
        public enum HourCost
        {
            Intern = 5,
            FirstCategory = 15,
            HighestCategory = 20,
            Professor = 35
        }

        public static Dictionary<int, string> qualifications = new Dictionary<int, string>()
        {
            [1] = "Intern",
            [2] = "First category",
            [3] = "Highest category",
            [4] = "Professor"
        };
    }
}
