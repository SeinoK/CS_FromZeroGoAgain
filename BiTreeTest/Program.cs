using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] data = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J' };
            BiTree<char> tree = new BiTree<char>(10);
            for (int i = 0; i < data.Length; i++)
            {
                tree.Add(data[i]);
            }
        }
    }
}
