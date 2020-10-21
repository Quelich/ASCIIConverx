using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Converx
{
    //TODO Add ToText file which converts given Ascii code into a human-understandable version :: https://www.ascii-code.com/
    public class ToText {
        protected static string InputCode;
        protected static string[] MatchUp;
        public static void InputAscii()
        {
            Console.WriteLine("Type something in...");
            InputCode = Console.ReadLine();
        }
        public static void CompareText()
        {
            InputAscii();
        }

    }
}