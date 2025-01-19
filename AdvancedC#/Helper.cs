﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    static class Helper<T> 
    {
        #region incorrect usage 
        //public static void Swap(ref int x, ref int y)
        //{
        //    Console.WriteLine("_______________Swap__________________");
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    Console.WriteLine("_______________Swap__________________");
        //    double temp = x;
        //    x = y;
        //    y = temp;

        //}
        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Console.WriteLine("_______________Swap__________________");
        //    Point temp = x;
        //    x = y;
        //    y = temp;

        //} 
        #endregion
        ///many boxing and unboxing 
        //public static void Swap(ref object x,ref object y)
        //{
        //    Console.WriteLine("_______________Swap__________________");
        //    object  temp = x;
        //    x = y;
        //    y = temp;

        //}

        public static void Swap(ref T x, ref T y)
        {
            Console.WriteLine("_______________Swap__________________");
            T temp = x;
            x = y;
            y = temp;

        }
        public static void Print<T>(string s)
        {
            Console.WriteLine($"{s}");
        }
        public static int Linearsearch(T []arr,T value)
        {
            if (arr?.Length>0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                    {
                        return i;
                    }
                }
            }
            return -1;

        }


    }
}
