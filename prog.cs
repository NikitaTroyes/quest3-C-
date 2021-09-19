using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest3_charset_Ascii
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] table = new int[26];
            int start = 97;

            for (int x = 0; x < 26; x++)
            {
                table[x] = start++; 
            }

           /* for (int x = 0; x < table.Length; x++)
            {
                Console.WriteLine(table[x]);
            }*/

            for (int x = 0; x < table.Length; x++)
            {
                char letter = (char)table[x];
                Console.WriteLine("char " + letter + " = " + table[x]) ;
            }

            Console.ReadLine();
        }
    }
}
