using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _04_loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 0;

            while (total < 100)
            {
                total = total + 1;  //can be (total += 1) or total++ 
                Console.WriteLine("Total: " + total);
            }

        }
        [TestMethod]
        public void ForLoops()
        {
            string greeting = "Hello World!";

            foreach (char letter in greeting)
            {
                Console.WriteLine(letter);
            }
            List<string> stringList = new List<string>();

            stringList.Add("hello");
            stringList.Add("Word");
            stringList.Add("Banana");

            foreach (string word in stringList)
            {
                Console.WriteLine(word);
            }
            Random randy = new Random();
            for (int i = ; i<100; i++)
            {
                Console.WriteLine(i);
            }

            //do while loops
            int i = 6;
            do
            {
                Console.WriteLine("keep going");
            } while (int < 5);
        }
        [TestMethod]
        public void W1D3MorningChallenge()
        {
            string weirdWord = "supercalifragilisticexpalidocious";


            foreach (char output in weirdWord)
            {
                Console.WriteLine(output);
            }
        }
    }
}
