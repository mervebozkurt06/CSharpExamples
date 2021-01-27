using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDic<T>
    {
        T[] items;
        //constructor
        public MyDic()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] _tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                items[i] = _tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return Items; }
        }
    }
}
