using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    [TestClass]
    public class Person
    {
        private string _lastName;

        public Person() { }
        public Person(string firstName, string lastName, DateTime dOB)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dOB;
        }


        // public Person() {}
        public string FirstName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName[0].ToString();
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }

        }

        public Vehicle Transport { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void Brag()
        {
            Console.WriteLine($"I'm {FirstName} I own a {Transport.make} {Transport.model} it's a {Transport.VehicleTypes} with {Transport.mileage } miles on it");
        }

    }
}
