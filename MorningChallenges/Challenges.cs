using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void TestMethod1()
        {
            string sillyWord = "Supercalifragilisticexpialidocious";
            int count = 0;
            foreach (char letter in sillyWord)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine("Not 'i', said the Console");
                }
                count++;
            }
            Console.WriteLine(sillyWord.Length);
            for (int i = 0; i < sillyWord.Length; i++)
            {
                char letter = sillyWord[i];
                // "" same as foreach from here
            }


        }
        
    }
}