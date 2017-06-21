using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CS_CheckInputIsNumberical
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetInput().ToString();
            Console.Write("You have input: " + str);
            Console.ReadKey();
        }
        static int GetInput()
        {
            int num = 0;
            string str;
            Console.Write("Please Input A Number: ");
            while (true)
            {
                str = Console.ReadLine();
                if (IsNumber(str))
                {
                    num = Convert.ToInt32(str);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please input again: ");
                }
            }
            return num;
        }
        static bool IsNumber(string str)   //The fast way to check a string is complete made of number
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
