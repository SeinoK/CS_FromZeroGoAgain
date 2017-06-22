using System;
using System.Collections.Generic;
using System.Text;

namespace CS_HowManycola
{
    class Program
    {
        static void Main(string[] args)
        {
            //现有364瓶可乐，3个空瓶子可以兑换一瓶可乐，请问一共能喝多少瓶可乐，剩余多少个瓶子

            int cola = 364;
            int bottle = cola;
            int temp = 0;
            //int remainBottle = bottle % 3;
            //while (bottle > 3)
            //{
            //    cola += bottle / 3;
            //    remainBottle = bottle % 3;
            //    bottle = bottle / 3 + remainBottle;
            //}

            while (bottle > 3)//对每次的bottle值进行比较，如果小于3这说明兑换不了
            {
                temp += bottle;
                bottle = bottle / 3 + bottle % 3;
                // Console.Write("You have drink {0} bottle cola, and have {1} bottle left", cola, remainBottle);
            }
            Console.WriteLine("cola:{0}  remainBottle:{1} ", temp, bottle);
            Console.ReadKey();



            //Chicken();
            Console.ReadKey();

        }

        static void Chicken()   //百鸡百钱问题
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 34; j++)
                {
                    for (int k = 1; k < 300; k++)
                    {
                        if ((15 * i + 9 * j + k) == 300 && (i + j + k) == 100)
                        {
                            Console.WriteLine("公：{0}   母：{1}   小：{2}", i, j, k);
                        }
                        //else continue;
                    }
                }
            }
        }


    }
}
