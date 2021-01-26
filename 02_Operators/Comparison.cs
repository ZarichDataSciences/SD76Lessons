using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 35;
            bool equals = age == 42;
            Console.WriteLine("Am I 42 " + equals);

            string name = "Andrew";

            Console.WriteLine(name == "jacob"); //should display false

            bool notEqual = age != 200;

            Console.WriteLine("I'm not two centuries old" + notEqual);

            List<string> firstList = new List<string>();
            firstList.Add(name);
            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAReEqual = firstList == secondList;
            Console.WriteLine("ARe the lists exactly the same?" + listsAReEqual);
            //These are references to values, not the values themselves
            //this is the diff between value and ref types
            bool amIAnAdult = age >= 18;
            bool amIEighteen = age == 18;
            bool amIOverEighteen = age > 18;
            amIAnAdult = amIEighteen || amIOverEighteen; // || means OR
            bool hasMagenta = false;
            bool hasCyan = true;
            bool myFaveColors = hasMagenta && hasCyan; // && mean AND

        }
    }
}
