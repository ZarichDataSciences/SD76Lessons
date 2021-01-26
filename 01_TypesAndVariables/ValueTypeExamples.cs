using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            //Declare
            bool isDeclared;
            //Initialize
            isDeclared = true;
            //declareANDinitiliaze but change later
            bool isDeclaredAndInitialized = true;
            isDeclaredAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char anotherChar = ';';
            char specialChar = '\n'; //new line character LF moves cursor up one line

        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255; //largest val possible 11111111 - very fast for random numbers
            //sbyte
            int intMin = -2147483648;
            int intMin2 = 2147483647;
            long longExample = 9223372036854775807;
        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.045231d;
            decimal decimalExample = 1.045231m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum pastryType { Cake, Cupcake, Eclaire, Croissant, Danish, Baguette} //you can declare a value to cake by cake=20

        [TestMethod]
        public void Enums()
        {
            pastryType myPastry = pastryType.Baguette;
            pastryType myPastry2 = pastryType.Cake;

            Console.WriteLine((int) myPastry); //(int) is call casting. converts one type to another, but only certain will work
            Console.WriteLine(myPastry2); //in enum, every type has a value in it. Hover over pastry types to see them
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 35; //Int32 is a Struct. A type with special properties and abilities.
            DateTime today = DateTime.Today; //gives today's date. Can also use DateTime.Now for date and time
            DateTime birthdate = new DateTime(1985, 09, 22); //new means new instance of STruct. REvalues it.
            Console.WriteLine(today); //gives today's date
            Console.WriteLine(today - birthdate);
            TimeSpan myAge = today - birthdate;
            Console.WriteLine(today - birthdate);
        }
    }
}
