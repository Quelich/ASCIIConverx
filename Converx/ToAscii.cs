using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

//TODO Find a better way to compare the char to the string 
namespace Converx
{
    public class ToAscii 
    {

        public AsciiDB myDB = new AsciiDB();
        protected static char[] MatchUp;
        protected static string InputWord;

      
        
        /// <summary>
        /// Gets input
        /// </summary>
        public static void GetInput()
        {
            Console.WriteLine("Type something in...");
            InputWord = Console.ReadLine();
            MatchUp = InputWord.ToCharArray(0,InputWord.Length);
        }
        /// <summary>
        /// Compares given text with the letters
        /// </summary>
        public static void Compare()
        {
            GetInput();
            foreach (var item in MatchUp)
            {
                switch (item)
                {
                    case 'a':
                        Console.Write("01100001");
                        break;
                    case 'b':
                        Console.Write("01100010");
                        break;
                    case 'c':
                        Console.Write("01100011");
                        break;
                    case 'd':
                        Console.Write("01100100");
                        break;
                    case 'e':
                        Console.Write("01100101");
                        break;
                    case 'f':
                        Console.Write("01100110");
                        break;
                    case 'g':
                        Console.Write("01100111");
                        break;
                    case 'h':
                        Console.Write("01101000");
                        break;
                    case 'i':
                        Console.Write("01101001");
                        break;
                    case 'j':
                        Console.Write("01101010");
                        break;
                    case 'k':
                        Console.Write("01101011");
                        break;
                    case 'l':
                        Console.Write("01101100");
                        break;
                    case 'm':
                        Console.Write("01101101");
                        break;
                    case 'n':
                        Console.Write("01101110");
                        break;
                    case 'o':
                        Console.Write("01101111");
                        break;
                    case 'p':
                        Console.Write("01110000");
                        break;
                    case 'q':
                        Console.Write("01110001");
                        break;
                    case 'r':
                        Console.Write("01110010");
                        break;
                    case 's':
                        Console.Write("01110011");
                        break;
                    case 't':
                        Console.Write("01110100");
                        break;
                    case 'u':
                        Console.Write("01110101");
                        break;
                    case 'v':
                        Console.Write("01110110");
                        break;
                    case 'w':
                        Console.Write("01110111");
                        break;
                    case 'x':
                        Console.Write("01111000");
                        break;
                    case 'y':
                        Console.Write("01111001");
                        break;
                    case 'z':
                        Console.Write("01111010");
                        break;
                    case ' ':
                        Console.Write(" ");
                        break;
                    default:
                        Console.Write("????????");
                        break;
                }
            }
        }
    }
}
