using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchiesPractise
{
    // Extension method 
    public static class StringCap
    {
        public static bool IsCap(this string capString)
        {
            if (string.IsNullOrEmpty(capString))
            {
                return false;
            } 
            else
            {
                return char.IsUpper(capString[0]);
            }




        }
    }
}
