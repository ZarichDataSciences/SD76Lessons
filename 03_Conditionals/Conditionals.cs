using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Conditionals
    {
        [TestMethod]
        public void IfStatement()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 12)
            {
                Console.WriteLine("Are you even trying?");
            }
        }
        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAReDone = false;
            if (choresAReDone)
            {
                Console.WriteLine("Have fun at the movies");
            }   else
            {
                Console.WriteLine("you are a bad boy");
            }
            int age = 35;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }else if (age >= 36)
            {
                Console.WriteLine("you are a super adult");
            }else (age < 1)
                    { Console.WriteLine("All failed"); }
        }

        [TestMethod]

        public void Terneries()
        {
            int age = 35;

            Console.WriteLine("Welcome to the library, you visit the " + (age >= 18 ? "whole library" : "children's section only")); // ? and : make it TERNARY
        }
    }
}
