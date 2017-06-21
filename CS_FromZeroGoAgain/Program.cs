using System;
using System.Collections.Generic;
using System.Text;

namespace CS_PrintNineTimesNine
{
    class Program
    {
        static void Main(string[] args)
        {
            //nine();
            generateSpace();

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
                    //Console.Write(str.Length);
                    Console.Write(i + "*" + j + "=" + ((str.Length == 1) ? " " : "") + (i * j) + "  ");
                }
                Console.WriteLine();
            }
            //Console.Write("*");
            return mul;
        }

        static void generateSpace()
        {
            int NUM = Nine();

            /*if (nine().ToString() != null)
            {
                Console.WriteLine("This is a Test");
            }
            */

            Console.WriteLine(NUM);
        }
        

    }
}
