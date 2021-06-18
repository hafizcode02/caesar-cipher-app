using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjengKripto
{
    class CipherAlgorithmCustom
    {
        static char[] alphabethWithExtra = new char[39] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ',', '.', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static char cipher(char ch, int key = 3)
        {
            char text = ' ';
            for (int i = 0; i < alphabethWithExtra.Length; i++)
            {
                if (char.ToUpper(ch) == alphabethWithExtra[i])
                {
                    text = (char)alphabethWithExtra[(i + key) % alphabethWithExtra.Length];
                }

                if (char.IsLetter(ch))
                {
                    text = char.IsUpper(ch) ? char.ToUpper(text) : char.ToLower(text);
                }
            }

            return text;
        }

        public static string Enchiper(string input, int key = 3)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key = 3)
        {
            return Enchiper(input, alphabethWithExtra.Length - key);
        }
    }
}
