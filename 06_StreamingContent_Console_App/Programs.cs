using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_StreamingContent_Console_App.UI;
using _06_StreamingContent_Console_App.UI;

namespace _06_StreamingContent_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI(new RealConsole());
            ui.Run();
        }
    }




}
