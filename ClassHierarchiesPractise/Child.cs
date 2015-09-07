using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchiesPractise
{
    public class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("This child has been inoculated");
        }

        public void CheckBilling(string firstString, string secondString) 
        {
            Console.WriteLine("Patient: The billing has been checked using two strings {0} and {1}...", firstString, secondString);
        }
    }
}
