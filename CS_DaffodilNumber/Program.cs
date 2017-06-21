using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_DaffodilNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("All Daffodil Number Between 0 And 999 : ");
            FindDaffodil();
            Console.ReadLine();
        }

        static void FindDaffodil()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if ((i * 100 + j * 10 + k) == (i * i * i + j * j * j + k * k * k))
                        {
                            Console.Write(i * 100 + j * 10 + k);
                        }
                    }
                }
            }
        }

 
    }
}
