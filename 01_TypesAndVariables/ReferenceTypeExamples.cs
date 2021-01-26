using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings1()
        {
            string firstName = "Nathan";
            string lastName = "Zarich";
            //concatenate these...
            string concatenated = firstName + " " lastName;
            string interpolated = $"{firstName} {lastName}";
            string composited = string.Format("{0} {2) {1}", firstName, lastName); //{2} could me a middle name. Create the var above!

            Console.WriteLine(concatenated);

        }
        [TestMethod]
        public string Collections()
        {
            string stringExample: = "Hello World!";
            string[] stringArray = { "Hello", "World", "why", "is" };
            string thirdItem = stringArray[2]; //all digital logic starts at 0 not 1
            stringArray[0 = "Hello There"];
            Console.WriteLine(stringArray[0]);

            List<Strings> listOfStrings = new List<string>(); //usually new means you need () I pressed ctrl + .
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("some \"silly\" nothing"); \\ \" is an escape char meaning a literal quote
            listOfInts.Add(12345);
            Console.WriteLine(listOfStrings[0]);
            Console.WriteLine(listOfInts[0]);

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(firstInFirstOut.Dequeue());

            // Dictionaries

            Dictionary<int, string> keysAndValues = new Dictionary<int, string>();

            keysAndValues.Add(5, "something");
            keysAndValues.Add(6, "something else"); //all must unique numerical values

            Dictionary<string, decimal> importantNumbers = new Dictionary<string, decimal>();

            importantNumbers.Add("pi", 3.14159265m);
            importantNumbers.Add("phi", 1.6810334m);

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            sortedKeyAndValue.Add(13, "blah");
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastI

        }
    }
}
