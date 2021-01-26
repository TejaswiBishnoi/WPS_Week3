using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPS3
{
    class Q6
    {
        public static void Ques()
        {
            string Len = "";
            do
            {
                Len = Console.ReadLine();
                if (Len == null || Len == "")
                {
                    break;
                }
                string Pat = Console.ReadLine();
                string Hay = Console.ReadLine();
                int atm = 0;
                int i = 0;
                while (1 > 0)
                {
                    i = Hay.IndexOf(Pat, i + 1);
                    if (i == -1)
                    {
                        if (atm == 0)
                        {
                            Console.WriteLine("" + "\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(i);
                        atm++;
                    }
                }
            }
            while (Len != null);
        }
    }
}
