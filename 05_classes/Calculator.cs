using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
   
    public class Calculator
    {
        //addition
        public int Add(int numOne, int numTwo)
        {

            int sum = numOne + numTwo;
            return sum;

        }

        public double Add(double numOne, double numTwo)
        {

            double sum = numOne + numTwo;
            return sum;
        }


        //subtraction
        public int Subtract(int numOne, int numTwo)
        {
            int differance = numOne - numTwo;
            return differance;
        }


        //multipulication
        public int Multiply(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }
       // public int Multiply(int numOne, int numTwo)
        //{
        //    return numOne * numTwo;
       // }

        //division
        public double Divid(double numOne, double numTwo)
        {
            double quotient = numOne / numTwo;
            return quotient;
        }
        // int/int drops some information 
        //double/double keeps the info and is more useful for division
        // Casted overload
        public double Divide(int numOne, double numTwo)
        {
            return (double)numOne / numTwo;
        }
        public double Divide(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }

        //finding the remainder
        public int Remainder(int numOne, int numTwo)
        {
            int remains = numOne % numTwo;
            return remains;
        }


        public int CalculateAge(DateTime birthDate)
        {
            TimeSpan age = DateTime.Now - birthDate;
            double totalAgeInYears = age.TotalDays / 365.25;
            double rounded = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(rounded);
            return years;
            

        }
        // Just because you can do it one line doesn't mean you should.
        public int CalculateAgeOneLine(DateTime birthDate)
        {
            return Convert.ToInt32(Math.Floor((DateTime.Now - birthDate).TotalDays / 365.25));
        }

    }
}
