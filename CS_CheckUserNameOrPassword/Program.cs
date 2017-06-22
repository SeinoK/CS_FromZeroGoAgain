using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_CheckUserNameOrPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userName = "user";
            //string password = "psd";
            //string inputUser = "";
            //string inputpassword = "";
            int count = 0;
            while (count > 3)
            {
                count ++;

                Console.Write("count: {0}",count);
            }
            Console.ReadKey();

        }
        static void Menu()
        {
            
        }

        static bool IsCorrect(string username, string password)
        {
            Console.Write("Please input user name: ");
            string inputUser = Console.ReadLine();
            Console.Write("Please input user password: ");
            string inputpassword = Console.ReadLine();
            if ((username == inputUser) && (password == inputpassword))
            {

            }
            return true;
        }
       
    }
}
