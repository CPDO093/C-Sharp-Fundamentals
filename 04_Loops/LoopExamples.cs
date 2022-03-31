using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void Loops()
        {

            int total = 1;

            //while(condition) body

            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            //"inifinte" loop, conditon will never be false
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("goal reached");
                    //break will "break" the loop
                    break;
                }
                total++;
            }

            int comeCount;
            bool keepLooping = true;
            Random randy = new Random();

            while (keepLooping)
            {
                comeCount = randy.Next(0, 20);
                if (comeCount == 0 || comeCount == 10)
                {
                    continue;

                }

                Console.WriteLine(comeCount);

                if (comeCount == 15)
                {
                    keepLooping = false;
                }
            }


        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 12;
            // 1 starting point, local variable
            ///2 condition, loop while true
            //3 what we do affter each loop
            //4 code to execute each loop

                //1         //2              //3
            for (int i = 0; i < studentCount; i++)
            {
                //4
                Console.WriteLine(i);

            }

            string[] students = { "twenties", "chung", "masters", "bear", "kags" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"welcome to class {students[i]}!");
            }
        }

        [TestMethod]
        public void ForeachLoop()
        {

            string[] students = { "twenties", "chung", "masters", "bear", "kags" };


            //1 type in collection
            //2 local varibale 
            //3 in keyword to signify going into collection
            //4 the collection

                    //1     //2    //3    //4
            foreach (string student in students)
            {
                Console.WriteLine(student+" is a student in class.");
            }

            string myName = "Asyn Keal";
            foreach (char letter in myName)
            {
                Console.WriteLine(letter);
            }


        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine("hello!");
                itterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("my condition is false");
            }
            while (false);
            while (false)
            {
                Console.WriteLine("my condition is false");
            }
        }
    }
}
