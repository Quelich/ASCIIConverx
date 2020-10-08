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
    public  class ToAscii
    {
        
        /// <summary>
        /// Stores letter's ASCII code equivalent
        /// </summary>
        /// <typeparam name="string"> Key</typeparam>
        /// <typeparam name="string">Value</typeparam>
        /// <returns></returns>
        public static Dictionary<string, string> DicBinary = new Dictionary<string, string>();
        
        public static void InitDB()
        {
            DicBinary.Add("a", "01100001");
            DicBinary.Add("b", "01100010");
            DicBinary.Add("c", "01100011");
            DicBinary.Add("d", "01100100");
            DicBinary.Add("e", "01100101");
            DicBinary.Add("f", "01100110");
            DicBinary.Add("g", "01100111");
            DicBinary.Add("h", "01101000");
            DicBinary.Add("i", "01101001");
            DicBinary.Add("j", "01101010");
            DicBinary.Add("k", "01101011");
            DicBinary.Add("l", "01101100");
            DicBinary.Add("m", "01101101");
            DicBinary.Add("n", "01101110");
            DicBinary.Add("o", "01101111");
            DicBinary.Add("p", "01110000");
            DicBinary.Add("q", "01110001");
            DicBinary.Add("r", "01110010");
            DicBinary.Add("s", "01110011");
            DicBinary.Add("t", "01110100");
            DicBinary.Add("u", "01110101");
            DicBinary.Add("v", "01110110");
            DicBinary.Add("w", "01110111");
            DicBinary.Add("x", "01111000");
            DicBinary.Add("y", "01111001");
            DicBinary.Add("z", "01111010");

        }
        /// <summary>
        /// Initializes all of Database
        /// </summary>
        public static void ShowAll()
        {
            foreach (KeyValuePair<string, string> kvm in DicBinary)
            {
                Console.WriteLine($"Key :{kvm.Key}: |Value :{kvm.Value}:");
            }
        }
        

        public static void GetInput()
        {

            Console.WriteLine("Type something in...");
            string InputWord = Console.ReadLine();
            char[] MatchUp;
            MatchUp = InputWord.ToCharArray(0,InputWord.Length);
            foreach (var item in MatchUp)
            {
                // foreach (var BinPair in DicBinary)
                // {
                //     if (item.Equals(BinPair.Key))
                //     {
                //         Console.Write(BinPair.Value);
                //     }  
                // }
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
