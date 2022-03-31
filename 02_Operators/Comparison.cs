using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void Comparisons()
        {

            int age = 25;
            string username = "Corey";

            //comparison tool == checks that two values are the same
            bool equals = age == 45;
            bool userIsAdam = username == "adam";
            Console.WriteLine("user is 45: " + equals);
            Console.WriteLine($"user is adam: {userIsAdam}");

            bool notEqual = age != 112;
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine($"user is not 112: {notEqual}");
            Console.WriteLine("user is not Justin: " + userIsNotJustin);


            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool areSame = firstList == secondList;

            bool geaterThan = age > 12;
            bool lessThan = age < 75;

            bool greaterThanOrEqual = age >= 66;
            bool lessThanOrEqual = age <= 20;


            bool trueValue = true;
            bool falseValue = false;

            //or 
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            //and
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            //are
            bool 
        }
    }
}
