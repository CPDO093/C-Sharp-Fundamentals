using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatments()
        {

            bool userIsHungry = true;

            //if keyword
            if (userIsHungry) // condition is parenthesis
            {
                //body
                Console.WriteLine("eat something");
            }

            string name = "jacob";

            if (name == "jacob") 
            {
                Console.WriteLine("youmust be so cool!");
            }
            if (name != "jacob") 
            {
                Console.WriteLine("you must not be very cool.");
            }
        }

        [TestMethod]
        public void IfElseStatments()
        {

            bool choresAreDone = false;
            if(choresAreDone)
            {
                Console.WriteLine("have fun at the movies!");
            }
            else
            {
                Console.WriteLine("stay home and do your chores");
            }

            string input = "7";
            int totalHours = int.Parse(input); //nesting

            if(totalHours >= 8)
            {
                Console.WriteLine("you should be well rested");
            }
            else
            {
                Console.WriteLine("you may be tired");
                if(totalHours < 4)
                {
                    Console.WriteLine("you need to get more sleep");
                }
            }

           
        }

        [TestMethod]
        public void IfElseIfStatments()
        {

            int roll = 6;
            if (roll == 6)
            {
                Console.WriteLine("you rolled a 6");
            }
            else if (roll == 5)
            {
                Console.WriteLine("you rolled a 5");
            }
            else if (roll == 4)
            {
                Console.WriteLine("you rolled a 4");
            }
            else if (roll == 3)
            {
                Console.WriteLine("you rolled a 3");
            }
            else if (roll > 1)
            {
                Console.WriteLine("two!");
            }
            else
            {
                Console.WriteLine("One boy");
            }


        }
    }
}
