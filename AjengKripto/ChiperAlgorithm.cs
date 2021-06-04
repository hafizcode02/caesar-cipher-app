using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjengKripto
{
    class ChiperAlgorithm
    {
        public static char cipher(char ch, int key=3)
        {
            if (!char.IsLetter(ch)) return ch;

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Enchiper(string input, int key=3)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key=3)
        {
            return Enchiper(input, 26 - key);
        }

        internal static object Decipher(object v)
        {
            throw new NotImplementedException();
        }
    }
}
