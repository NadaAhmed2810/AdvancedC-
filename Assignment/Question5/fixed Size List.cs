﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question5
{
    internal class Fixed_Size_List<T>
    {
       public int Capacity { get; }
       private T [] list;
       private int count;
       public Fixed_Size_List(int capacity)
        {
            Capacity = capacity;
            list = new T[capacity];
            count = 0;
        }
        public void Add(T item)
        {
            if (count < Capacity)
            {
                list[count++] = item;
            }
            else throw new Exception("List is Full");
        }
        public void Get(int index)
        {
            if (index >= 0 && index < Capacity)
            {
                Console.WriteLine($"item in index {index} is :{list[index]}");
            }
            else throw new Exception("Index is  out of Range");
        }

    }
}
