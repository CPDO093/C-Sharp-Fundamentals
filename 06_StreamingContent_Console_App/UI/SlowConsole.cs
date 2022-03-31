using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console_App.UI
{
    public class SlowConsole : IConsole
    {
        private readonly Random _random;
        public SlowConsole()
        {
            _random = new Random();
        }
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            var input = Console.ReadKey();
            foreach (char letter in "......")
            {
                Thread.Sleep(50);
                Console.Write(letter);
            }
        }
        public int Random()
        {
            return _random.Next(100, 800);
        }
        public void Readline()
        {
            var input = Console.ReadLine();
            foreach (char letter in ".......")
            {
                Console.Write(".");
                Console.Beep(Random(), 30);
                Thread.Sleep(50);
            }
;
        }

        public void Write(string s)
        {
            foreach (char letter in s)
            {
                Thread.Sleep(25);
                Console.Beep(Random(), 30);
                Console.Write(letter);
            }
;
        }

        public void WriteLine(string s)
        {
            Write(s);
            Console.Write("\n");
        }

        public void Writline(object o)
        {
            Console.Write(o);
        }

        public void WriteLine()
        {
            Console.Write(".");
            Console.Beep(Random(), 30);
            Thread.Sleep(50);
        }
    }
}
