using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CS_DaffodilNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("All Daffodil Number Between 0 And 999 : ");
            //FindDaffodil();
            //FindDaffodilBetween0_999();
            int num = GetInput();
            Console.Write(num);
            Console.ReadLine();
        }

        //static void finddaffodil()     //THIS CAN't WORK
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        for (int j = 0; j < 100; j++)
        //        {
        //            for (int k = 0; k < 10; k++)
        //            {
        //                if ((i * 100 + j * 10 + k) == (i * i * i + j * j * j + k * k * k))
        //                {
        //                    console.write(i * 100 + j * 10 + k);
        //                }
        //            }
        //        }
        //    }
        //}
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

        static void FindDaffodilBetween0_999()   //This is a simple for solving the problem
        {

            for (int i = 100; i < 1000; i++)
            {
                int ge = i % 10;   //get 
                int shi = (i / 10) % 10;
                int bai = i / 100;
                if ((bai * bai * bai + shi * shi * shi + ge * ge * ge) == i)
                {
                    Console.Write(i + " ");
                }
            }
        }


        static void FindDaffodil()
        {

        }

        static bool IsNumber(string str)
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
