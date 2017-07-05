using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SimpleEncryption
{
    class Program
    {
        public static int Offset = 3;
        static void Main(string[] args)
        {
            Console.Write("Please input the string that you want ENCRYT: (Press N to cancle)");
            string str = Console.ReadLine();
            Console.ReadLine();
            do
            {
                Encrytion(str);
            } while (str != "N");
        }

        static string Encrytion(string str)
        {
            int offset = Offset;
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
                Console.Write(Convert.ToInt32(str[i]) + " ");
            }
            return str;
        }


    }
}
