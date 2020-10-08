using System.Collections.Generic;
using System;

namespace Converx
{
    public class AsciiDB {
        /// <summary>
        /// Stores letter's ASCII code equivalent
        /// </summary>
        /// <typeparam name="string"> Key</typeparam>
        /// <typeparam name="string">Value</typeparam>
        /// <returns>null</returns>
        public Dictionary<string, string> DicBinary = new Dictionary<string, string>();

        public void InitDB()
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
    }
}