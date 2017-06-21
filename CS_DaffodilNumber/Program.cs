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
            Console.Write("All daffodil number between 0 And 999 : ");
            //FindDaffodil();
            FindDaffodilBetween0_999();
            Console.ReadLine();
        }

        //static void Finddaffodil()     //THIS CAN't WORK
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
        

        static void FindDaffodilBetween0_999()   //This is a simple for solving the problem
        {

            for (int i = 100; i < 1000; i++)
            {
                int ge = i % 10;   
                int shi = (i / 10) % 10;
                int bai = i / 100;
                if ((bai * bai * bai + shi * shi * shi + ge * ge * ge) == i)
                {
                    Console.Write(i + " ");
                }
            }
        }




    }
}
