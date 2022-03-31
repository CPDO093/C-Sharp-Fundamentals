using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Morning_Challenge
{
    [TestClass]
    public class User
    {
        private string _lastName;
        public User() { }
        public User(string firstName, string lastName, DateTime dOB)
        {
             FirstName = firstName;
             LastName = lastName;
             DateOfBirth = dOB;
        }


        public string FirstName { get; set; }
         string LastName
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
    }
}

