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
            GetInput();
        }
        static int GetInput()
        {
            int num = 0;
            string str = Console.ReadLine();
            while (true)
            {
                Console.Write("Please Input A Number: ");
                if (IsNumber(str))
                {
                    num = Convert.ToInt32(str);
                    break;
                }
                else
                {
                    Console.Write("Please Input A Number Again: ");
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
