using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = {'a', '(', 'L', 't', ',', 'R', '^', '`', '|', 'Y', '}', 'u', '+', 'q', '=', 'F', '!'};

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 1; j < c.Length; j++)
                {
                    if (c[j]>=65 && c[j]<=90 && c[i] >= 65 && c[i] <= 90)
                    {
                        char ch = c[j];
                        c[j] = c[i];
                        c[i] = ch;
                    }
                   /* if (c[j]<c[i])
                    {
                        char ch = c[j];
                        c[j] = c[i];
                        c[i] = ch;
                    }*/
                }
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

            Console.ReadKey(true);
            
        }
    }
}
