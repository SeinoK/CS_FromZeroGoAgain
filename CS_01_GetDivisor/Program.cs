using System;
using System.Collections.Generic;
using System.Text;

namespace CS_01_GetDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
           // int Num = Convert.ToInt32(Console.ReadLine());
            //int[] array = GetDivisor(Num);
            //foreach (var temp in array)
            //{
            //    Console.Write(temp + " ");
            //}
            DynamicArray();
            //Console.ReadKey();
        }




        static int[] GetDivisor(int Num)  // Get all divisors of a number
        {
            int count = 0;
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                    count++;
            }
            int[] array = new int[count];
            int index = 0;
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }

        static void DynamicArray()
        {
            Console.WriteLine("Please input numbers in format (1,2,3,4,...100)");
            var input = Console.ReadLine();
            var strings = input.Split(',');   //Here got a string array you can print strings that you got "System.String[]"
            //foreach (var item in strings)45
            //{
            //    Console.Write(item + " ");
            //}
            //Console.Write(strings + "  ");

            var numbers = new double[strings.Length];
            for (int i = 0; i < strings.Length; i++)     //Fill numbers[] with item in strings[]
            {
                numbers[i] = Convert.ToDouble(strings[i]);    //convert element in strings to double type
            }
            bool flag = true;
            double temp;
            int numLength = numbers.Length;
            //sorting the array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers[j + 1] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            string[] str = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                str[i] = numbers[i].ToString();
            }
            Console.WriteLine(string.Join(",", str));
            Console.ReadKey();
        }



        //static int[] GetDivisorOptim(int num)
        //{
        //    int count = 0;
        //    int index = 0;
        //    int[] array = new int[index];
        //    for (int i = 1; i <= num; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            i++;
        //            count++;
        //        }
        //        else
        //            continue;
        //    }
        //    return array;
        //}


    }
}
