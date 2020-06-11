using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Gender
    {
        Male,
        Female,
    }

    //Extension class to add ToShortString() function so it shows M/V instead of Male/Female
    public static class GenderExtensions
    {
        public static string ToShortString(this Gender gender)
        {
            if (gender == Gender.Male)
                return "M";
            else
                return "V";
        }
    }
}
