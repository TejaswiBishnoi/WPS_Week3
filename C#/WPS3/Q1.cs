using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q1
    {
        public static void Ques()
        {
            string Word1 = Console.ReadLine();
            string Word2 = Console.ReadLine();
            int Max = Word2[0] - Word1[0];
            bool Ans = true;
            if (Word1.Length != Word2.Length)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            for (int i = 0; i < Word1.Length; i++)
            {
                if (Word2[i] - Word1[i] > Max)
                {
                    Ans = false;
                    break;
                }
                else if(Word2[i] - Word1[i] < Max)
                {
                    Max = Word2[i] - Word1[i];
                }
            }
            if (Ans == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
