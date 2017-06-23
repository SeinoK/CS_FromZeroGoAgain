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
        public struct user
        {
            string name;
            string password;
        };
        
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
            }
            //Console.Write("count: {0}", count);
            if (count == 3)
            {
                password = ChangeNameOrPassword();
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
                //Console.Clear();
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

        static string ChangeNameOrPassword()
        {
            string newPassword = "";
            Console.Write("Please input your reset password： ");
            newPassword =  Console.ReadKey().ToString();
            return newPassword;
        }

        static int Menu()
        {
            int command = 0;
            if(command>=0 && command <= 10)
            Console.ReadKey();
            return command;
        }

    }
}
