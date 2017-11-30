using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiTreeTest
{
    class BiTree<T>
    {
        private T[] data;
        private int count;
        public BiTree(int capcity)
        {
            data = new T[capcity];
        }
        public bool Add(T item)
        {
            if (count >= data.Length)
                return false;
            data[count] = item;
            count++;
            return true;
        }
    }
}
