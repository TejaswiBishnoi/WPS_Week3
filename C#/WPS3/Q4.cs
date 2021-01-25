using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q4
    {
        public static void Ques()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string Num = Console.ReadLine();
                string Output = "";
                for (int j = 0; j < n; j++)
                {
                    Output += Num.Substring(j, n)[j];
                }
                Console.WriteLine(Output);
            }
        }
    }
}
