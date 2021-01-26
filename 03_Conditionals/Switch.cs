using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void TestMethod1()
        {
            int day = 1;

            switch (day)
            {
                case 0:
                    Console.WriteLine("Happy Monday");
                    break;
                case 1:
                    Console.WriteLine("happy Tuesday");
                    break;
                case 2:
                    Console.WriteLine("hump day!");
                    break;
                default:
                    Console.WriteLine("give up the chase");
                    break;

            }



        }
    }
}
