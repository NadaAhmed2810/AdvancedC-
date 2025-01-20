﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    static  class Math<T> where T :IComparable<T>
    {
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }
        public static void BubbleSort(T[] arr)   
        {
            if (arr is not null && arr?.Length > 0)
            {
                bool f = false;//not make any swap [it sorted]
                for (int i = 0; i < arr.Length; i++)
                {
                    f = false;
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                            f = true;
                        }
                    }
                    if (!f) break;
                }
            }
            return;
        }
    }
}
