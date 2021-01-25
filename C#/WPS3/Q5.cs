using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q5
    {
        public static void Ques()
        {
            string[] Input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(Input[0]);
            int m = Convert.ToInt32(Input[1]);
            int[,] Frequency = new int[m, 5];
            for (int i = 0; i < n; i++)
            {
                string Ans = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    int t = 0;
                    switch (Ans[j])
                    {
                        case 'A':
                            t = 0;
                            break;
                        case 'B':
                            t = 1;
                            break;
                        case 'C':
                            t = 2;
                            break;
                        case 'D':
                            t = 3;
                            break;
                        case 'E':
                            t = 4;
                            break;
                    }
                    Frequency[j, t] += 1;
                }
            }
            string[] Marks = Console.ReadLine().Split(' ');
            int TotalMarks = 0;
            for (int k = 0; k < m; k++)
            {
                int Max = Frequency[k, 0];
                for (int l = 1; l < 5; l++)
                {
                    if (Frequency[k, l] > Max)
                    {
                        Max = Frequency[k, l];
                    }
                }
                TotalMarks += Max * Convert.ToInt32(Marks[k]);
            }
            Console.WriteLine(TotalMarks);
        }
    }
}
