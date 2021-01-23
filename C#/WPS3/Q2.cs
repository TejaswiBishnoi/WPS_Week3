using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q2
    {
        public static void Question()
        {
            bool Cont = true;
            while (Cont)
            {
                string Line = Console.ReadLine();
                string Output = "";
                if (Line == null)
                {
                    break;
                }
                List<int> Pos = new List<int>();
                int Endpoint = Line.Length;
                int z = Line.IndexOf('/');
                int Q = -1;
                
                while (z != -1)
                {
                    int t = Line.IndexOf('/', z + 1);
                    if (t == z + 1)
                    {
                        Endpoint = z;
                        break;
                    }
                    else
                    {
                        z = t;
                    }
                }
                if (Line.IndexOf('-', 0, Endpoint) == -1 || Line.IndexOf('>', 0, Endpoint) == -1)
                {
                    Console.WriteLine(Line);
                    continue;
                }
                while (1 > 0)
                {
                    int M = Line.IndexOf('-', Q + 1, Endpoint - Q - 1);
                    if (M == -1)
                    {
                        break;
                    }
                    else if (M + 1 != Line.Length && Line[M + 1] == '>')
                    {
                        Pos.Add(M);
                    }
                    Q = M;
                }
                if (Pos.Count == 0)
                {
                    Console.WriteLine(Line);
                    continue;
                }
                else
                {
                    for (int l = 0; l < Line.Length; l++)
                    {
                        bool Dot = false;
                        foreach (int e in Pos)
                        {
                            if (l == e)
                            {
                                Dot = true;
                                break;
                            }
                        }
                        if (Dot == true)
                        {
                            Output += '.';
                            l++;
                        }
                        else
                        {
                            Output += Line[l];
                        }
                    }
                }
                Console.WriteLine(Output);
            }
        }
    }
}
