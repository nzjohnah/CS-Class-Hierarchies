using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchiesPractise
{
    public class Adult : Patient
    {
        public void Examine() 
        {
            Console.WriteLine("The Adult has been examined...");
        }
           
    }
}
