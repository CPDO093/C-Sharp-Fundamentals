using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console_App.UI
{
    public interface IConsole
    {
        void WriteLine(string s);
        void Writline(object o);
        void Write(string s);
        void Clear();
        void ReadLine();
        string Readline();
        ConsoleKeyInfo ReadKey();


    }
}
