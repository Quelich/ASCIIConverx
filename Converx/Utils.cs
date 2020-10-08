using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Converx
{
    public class Utils : AsciiDB {
        /// <summary>
        /// Initializes all of AsciiDB
        /// </summary>
        public void ShowAll()
        {
            foreach (KeyValuePair<string, string> kvm in DicBinary)
            {
                Console.WriteLine($"Key :{kvm.Key}: |Value :{kvm.Value}:");
            }
        }
    }
}