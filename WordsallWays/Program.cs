using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsallWays
{
    class Program
    {
        static void Main(string[] args)
        {
           char[] chars= "abcdefghijklmnopqrstuvwxyz       ".ToCharArray();
            int len = 7;
            iterate(chars, len, new char[len], 0);
            Console.ReadKey();
        }
        public static void iterate(char[] chars, int len, char[] build, int pos)
        {
            if (pos == len)
            {
                String word = new String(build);
                //  each formed word prints here
                Console.WriteLine(word);
                return;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                build[pos] = chars[i];
                iterate(chars, len, build, pos + 1);
            }
        }
    }
}
