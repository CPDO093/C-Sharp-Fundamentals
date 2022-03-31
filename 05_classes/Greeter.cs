using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace _05_classes
{
    public class Greeter
    {
        Random random = new Random();

        //parts of a method
        //1 access modifier
        //2 return type = what does this method give me
        //3 method name
        //4 method peramiters. name + peramiters = method signature name(paramiters)
        //5 body, whats being executed when i call on this method

        //1    //2   /3      //4    
        public void Sayhello(string name)
        {
            //5
            Console.WriteLine($"{RandomGreeting()}, {name}");


        }

        //if you need another or similar type, add a useless bool
        public void Sayhello(int newNum, bool a)
        {
            Console.WriteLine($"whats popp'n ");
        }
        public void Sayhello(int highFive, string dude)
        {
            Console.WriteLine($"hi {dude}, give me {highFive} high fives!");
        }
        public void Sayhello(int highFive)
        {
            Console.WriteLine($"hit, give me {highFive} highFives!");
        }
        //overload method
        //same name, different parameters
        public void Sayhello()
        {
            Console.WriteLine("what's up bro?");

        }

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "yo yo", "what up", "sir" };
            int randomNumber = random.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine($"{randomGreeting}");
        }

        public string RandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "yo yo", "what up", "sir" };
            int randomNumber = random.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            return randomGreeting;
        }
    }
}
