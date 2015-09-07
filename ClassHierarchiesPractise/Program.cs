using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchiesPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Work on the What, why and how
            # region Inheritance Excercise
            // Inheritance Excercise: 
            // What is this: 
            // Why use it: 
            // How to:
            // 1. Create a Patient and Child class
            // 2. Give properties to Patient class
            // 3. Create a Examine method that display text and take an string parameter
            // 4. Both Adult and Child classes inherit from Patient
            // 5. Change the inherited class for each subclass and see what methods are available

            //Patient p = new Patient();
            //p.Examine("James");

            //Child c = new Child();
            //c.Examine("Bobby");
            //c.Inoculate();

            //UnderFive uf = new UnderFive();
            //uf.Inoculate();

            # endregion

            //Work on the What, why and how
            #region Overloading Excercise
            // Overloading Excercise:
            // What is this: 
            // Why use it: 
            // How to:
            // 1. Create Patient class
            // 2. Cleate two methods under Patient class one overloading with different parameters
            // 3. Create             Patient p = new Patient();

            //Patient p = new Patient();
            //p.CheckBilling();
            //p.CheckBilling(4, 3);

            //Child c = new Child();
            //c.CheckBilling("Bob", "Marley");
            #endregion

            //Work on the What, why and how
            #region Overriding Excercise
            // Overriding Excercise: 
            //1. Create a Patient and Adult class
            //2. Instantiate 1 of each Adult and Patient object and call their respective examine method

            //Adult a1 = new Adult();
            //a1.Examine();

            //Patient p1 = new Patient();
            //p1.Examine();

            //Adult pa = new Patient();
            //pa.OverrideExamine();
            #endregion

            # region Extension Method
            // Extension Methods Excercise: 
            // What is this: A static method in a static class and access extension mehtod by using 'this' modifier to the first method parameter,
            // type of the first parameter is the type that will be extended 
            // Why do we use it: Add particular functionality to an existing class without createing a new derived type, recompiling or modifying the original type
            // 
            // How to do it:
            //1. Create static StringCap class
            //2. create static return bool method called IsCap suing (this string) 
            //2. Instantiate 1 of each Adult and Patient object and call their respective examine method

            String x = "Hello";
            String y = "hello";
            // Is x and y string capital?
            // Easy way to add a functionality we need to the string data type and call it on any string objects we have in code
            Console.WriteLine(x + " is capitalise? " + x.IsCap());
            Console.WriteLine(y + " is capitalise? " + y.IsCap());
            #endregion

            # region Interface
            

            // Interface: 
            // What is this: Contain an interface cibtaubs definitions for a group related functionalities that a class or struct must provide. 
            // It doesn't tell the class how to do it but what it must do
            // A software contract that class can choose to participate in and requires a class to implement speicific funcitonalities. 
            // It should accomplish consistent functionality and polymorphism (The ability to call the same thing using the same names on different objects.)
            // Interface enforces a standard for implementation
            // It defines what functionalities a class must provide
            // It doesn't provide the specific funcitonalities
            // It provides commonality consisitency and how we make different things work differentway but we always call the same name 
            // or do the same function to make it happend

            // Interface can define methods, properties, events, indexers
            // Interface members are public by default, can't include any access modifiers
            // Why use: C# can't implement multiple inheritance but can implement multiple interfaces. 
            // Interface become important to enusre standard so all objects behaves the same.
 
            // How to do it:
            //1. 
            //2.  
            //3. 



            #endregion
        }
    }
}
