using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {

            int a = 22;
            int b = 15;
            
            //can be all value types just has to be same types
            //addition
            int sum = a + b;
            //subtraction
            int difference = a - b;
            //multiplication
            int product = a * b;
            //division
            int quotient = a / b;
            //remainder
            int remainder = a % b; //returns the remainder

            // context dependent sometimes

            DateTime today = DateTime.UtcNow;
            DateTime someDay = new DateTime(180, 02, 28);
            TimeSpan timeSpan = today - someDay;

        }

    }
}
