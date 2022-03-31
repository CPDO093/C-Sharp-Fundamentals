using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console_App.UI
{
    public class MockConsole : IConsole
    {
        private readonly Random _random;
        public MockConsole()
        {
            _random = new Random();
        }
        public void Clear()
        {
            Console.Clear();

            Console.BackgroundColor = RndColor();
        }
        public ConsoleColor RndColor()
        {
            Random randy = new Random();
            int  colorIndex = randy.Next(0, 16);
            return (ConsoleColor)colorIndex;
        }

        public ConsoleKeyInfo ReadKey()
        {
            Console.Beep(1000,1);
            return Console.ReadKey();

        }

        public string Readline()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Umm...");
            Thread.Sleep(1000);
            Console.WriteLine("You sure...?");
            Thread.Sleep(1500);
            Console.WriteLine("... okay");
            return input;
        }


        public void Write(string s)
        {
            foreach (char letter in s)
            {
                Console.ForegroundColor = RndColor();
                Console.WriteLine(letter);
            }
;
        }

        public void WriteLine(string s)
        {
            Console.ForegroundColor = RndColor();
            bool capitalized = false;
            foreach (char letter in s)
            {
                if (capitalized)
                { 
                     Console.Write(char.ToUpper(letter));
                     capitalized = false;
                }

                else
                {
                     Console.Write(char.ToLower(letter));
                     capitalized = true;
                }
;
            }
            Thread.Sleep(50);
            Console.Write("\n");

        }

        public void Writline(object o)
        {
            throw new NotImplementedException();
        }

        public void ReadLine()
        {
            Console.ReadLine();
        }
    }
}
