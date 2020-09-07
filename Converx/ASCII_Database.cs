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
    public  class ASCII_Database
    {
        public static void Main(string[] args)
        {
            //GetInput();
            ShowAll();
        }


        /// <summary>
        /// Stores letter's ASCII code equivalent
        /// </summary>
        /// <typeparam name="string"> TYPE</typeparam>
        /// <typeparam name="string">VALUE</typeparam>
        /// <returns></returns>
        public static Dictionary<string, string> DicBinary = new Dictionary<string, string>();
        
        public static void DatabaseASCII()
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

            Console.WriteLine("Write down something...");
            
            string InputWord = "emre";
            Console.WriteLine($"Hello {InputWord}");

            char[] MatchUp;
            MatchUp = InputWord.ToCharArray(0,4);
            foreach (var item in MatchUp)
            {
                foreach (var BinPair in DicBinary)
                {
                    if (item.Equals(BinPair.Key))
                    {
                        Console.Write(BinPair.Value);
                    }  
                }
                switch (item)
                {
                    case 'a':
                        Console.Write("01100001");
                        break;
                    case 'e':
                        Console.Write("01100101");
                        break;
                        case 'm':
                        Console.Write("01101101");
                        break;
                        case 'r':
                        Console.Write("01110010");
                        break;
                    default:
                        Console.Write("Invalid Input");
                        break;
                }
            }
        }

        public static void Split(string token)
        {
            
        }
    }
}
