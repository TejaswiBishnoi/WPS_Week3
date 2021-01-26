using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q6
    {
        static void Main(string[] args)
        {
            while (1 > 0)
            {
                string A = Console.ReadLine();
                int Len;
                if (A == null || A == "")
                {
                    break;
                }
                else
                {
                    Len = Convert.ToInt32(A);
                }
                string Pat = Console.ReadLine();
                string Str = Console.ReadLine();
                int[] P = PP(Pat);
                int i = 0;
                int j = 0;
                bool NEO = true; //NEO = Not even once.
                while (i < Str.Length + 1)
                {
                    if (j == Pat.Length)
                    {
                        Console.WriteLine(i - j);
                        i = i - j + 2;
                        j = P[j - 1];
                        NEO = false;
                    }
                    else if (i == Str.Length)
                    {
                        break;
                    }
                    else if (Str[i] == Pat[j])
                    {
                        i++;
                        j++;
                    }
                    else if (Str[i] != Pat[j])
                    {
                        if (j != 0)
                        {
                            j = P[j - 1];
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                Console.WriteLine("");
                if (NEO)
                {
                    Console.WriteLine("");
                }
            }
        }
        public static int[] PP(string Pat)
        {
            int[] Str = new int[Pat.Length];
            Str[0] = 0;
            for (int i = 1; i < Pat.Length; i++)
            {
                int Feq = 0;
                for (int j = 1; j < i + 1; j++)
                {
                    if (Pat.Substring(0, j) == Pat.Substring(i + 1 - j, j))
                    {
                        Feq++;
                    }
                }
                Str[i] = Feq;
            }
            return Str;
        }
    }
}
