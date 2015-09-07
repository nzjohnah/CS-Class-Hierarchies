using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchiesPractise
{
    public class Patient
    {
        // Inheritance excercise
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pname)
        {
            Console.WriteLine("Examination of " + pname + " completed");
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed");
        }
        
        public void OverrideExamine()
        {
            Console.WriteLine("The patient has been examined...");
        }


        // Overriding excercise
        public void CheckBilling()
        {
            Console.WriteLine("Patient: The billing has been checked...");
        }

        public void CheckBilling(int firstInt, int secondInt)
        {
            Console.WriteLine("Patient: The billing has been checked using two integers {0} and {1}...", firstInt, secondInt);
        }           
    }
}
