using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternarys()
        {

            int age = 31;
            //variable = condition ? treuResult : false result
            bool isAdult = (age >= 18) ? true : false;
            string adultStatus = (age >= 18) ? "adult" : "child";

            Console.WriteLine($"is adult: {isAdult} they are {adultStatus}");


            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;

            bool isEvolved = true;
            string pokemon = (isEvolved) ? "charizard" : "charmander";
            Console.WriteLine(pokemon);
;
        }
    }
}
