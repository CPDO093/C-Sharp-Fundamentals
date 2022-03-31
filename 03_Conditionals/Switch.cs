using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {

            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("whats up");
                    break;
                default:
                    Console.WriteLine("this is the default, it will execute if no case matches the value");
                    break;
            }
            // cases have to match the type(int, strings, exc)

            string name = "Corey;";
            switch (name)
            {
                case "jacob":
                    Console.WriteLine("whats up");
                    break;
                case "Corey":
                    Console.WriteLine("yo yo m'lord");
                    break;
                case "Hello":
                    Console.WriteLine("hi?");
                    break;

            }

        }
    }
}
