using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Morning_Challenge
{
    [TestClass]
    public class ConditionsAndLoops
    {
        [TestMethod]
        public void CondAndLoops()
        {

            string bigWord = "supercalifragilisticexpialidocious";

            foreach (char letter in bigWord)
            {
                if (letter == 'i' || letter == 'l')
                {
                Console.WriteLine(letter);

                }
                else
                {
                    Console.WriteLine("not an i");
                }

            }

            
        }
    }
}
