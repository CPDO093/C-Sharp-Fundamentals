using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecute()
        {

            Greeter greeter = new Greeter();
            //semantic satiation: words no longer are words

            greeter.Sayhello("jacob");
            greeter.Sayhello();
            greeter.Sayhello(3, true);
            greeter.Sayhello(3, "Harmoor");

            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();

            Console.WriteLine(greeter.RandomGreeting());
        }
        [TestMethod]
        public void CalculatorTest()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(8, 3);
            Console.WriteLine(sum);


            int age = calculator.CalculateAge(new DateTime(1995, 11, 24));
            Console.WriteLine(age);

            double quotient = calculator.Divide(12, 4);
            Console.WriteLine(quotient);

            Console.WriteLine(calculator.Multiply(4, 3));

            
            DateTime dob = new DateTime(1995, 11, 24);
            age = calculator.CalculateAge(dob);
            Console.WriteLine(age);

        }

        [TestMethod]
        public void PersonProperty()
        {
            Person person = new Person("Jacob", "Brown", new DateTime(2002, 02, 02));
            Console.WriteLine($"My name is {person.FullName} and I am {person.Age} years old.");
            person.Transport = new Vehicle("Nissan", "Skyline", 100, VehicleTypes.car);

            Assert.AreEqual("Jacob B", person.FullName);
            Assert.AreEqual("Jacob", person.FirstName);
            person.SayHello();

            Person luke = new Person("Luke", "Skywalker", new DateTime(1970, 02, 02));
            luke.SayHello();

            person.Brag();

            person.Transport.TurnOnHazards();
        }
    }
}
