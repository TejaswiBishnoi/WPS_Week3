using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q3
    {
        public static void Ques()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string Word1 = Console.ReadLine();
                string Word2 = Console.ReadLine();
                int Diff = Word2[0] - Word1[0];
                if (Diff < 0)
                {
                    Diff = 26 + (Diff % 26);
                }
                bool Neg = false;
                for (int j = 0; j < Word1.Length; j++)
                {
                    if (Word2[j] - Word1[j] != Diff && 26 + Word2[j] - Word1[j] != Diff)
                    {
                        Console.WriteLine(-1);
                        Neg = true;
                        break;
                    }
                }
                if (Neg)
                {
                    continue;
                }
                Console.WriteLine(Diff);
            }
        }
    }
}
