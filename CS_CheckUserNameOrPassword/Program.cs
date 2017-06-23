using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_CheckUserNameOrPassword
{
    class Program
    {
        private static string username = "user";
        private static string password = "123";

        static void Main(string[] args)
        {
            //string userName = "user";
            //string password = "psd";
            //string inputUser = "";
            //string inputpassword = "";
            int count = 0;
            while (count < 3)
            {
                if (!IsCorrect())
                {
                    count++;
                    Console.WriteLine("You have {0} times to input", (3 - count));
                }
                // Console.Write("count: {0}",count);
            }
            if (count > 3)
            {
                ChangeNameOrPassword();
                //Console.WriteLine("You have {0} times to input", (3 - count));
            }
            Console.ReadKey();
        }

        static bool IsCorrect()
        {
            bool isCorrecr = false;
            Console.Write("Please input user name: ");
            string inputUser = Console.ReadLine();
            Console.Write("Please input user password: ");
            string inputpassword = Console.ReadLine();
            if ((username != inputUser) || (password != inputpassword))
            {
                Console.Clear();
                Console.WriteLine("You got user name or password wrong");
            }
            else if ((username == inputUser) && (password == inputpassword))
            {
                //Console.Clear();
                Console.WriteLine("You are right");
                isCorrecr = true;
            }
            return isCorrecr;
        }

        static void ChangeNameOrPassword()
        {
            Console.Write("Please input your new password");
        }

    }
}
