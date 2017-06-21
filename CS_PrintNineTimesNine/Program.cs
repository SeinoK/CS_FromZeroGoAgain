using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_PrintNineTimesNine
{
    class Program
    {

        static void Main(string[] args)
        {
            Nine();
            Console.ReadKey();
        }
        static int Nine()
        {
            int mul = 0;
            string str = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    mul = i * j;
                    str = mul.ToString();
                    Console.Write(i + "*" + j + "=" + ((str.Length == 1) ? " " : "") + (i * j) + "  ");
                }
                Console.WriteLine();
            }
            return mul;
        }

    }
}
