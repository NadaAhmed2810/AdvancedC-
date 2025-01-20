using Assignment.Question2;
using Assignment.Question5;

namespace Assignment
{
    internal class Program
    {
        public static int FirstNonRepeatedChar(string s)
        {
            int res = -1;
            Dictionary<Char,int> dict = new Dictionary<Char,int>();
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        dict[s[i]]++;
                    }
                    else
                    {
                        dict[s[i]] = 1; 
                    }
                }
                for (int i = 0;i < s.Length; i++)
                {
                    if (dict[s[i]] == 1)
                    {
                        res = i;
                        return res;
                    }
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            #region Q1:Improve Bubble Sort Algorithm
            ////problem that if array sorted in time < n not continue 
            //int[] arr = [900, 1, 5, 6, 3, 2, -100, 0];
            //Math<int>.BubbleSort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
            #region Q2:Range Class
            //var R01 = new Range<int>(30, 20);
            //Console.WriteLine(R01.IsInRange(0));
            //Console.WriteLine($"Range:{R01.Length()}");
            //Console.WriteLine("___________________________");
            //var R02 = new Range<double>(-100.5, 100.75);
            //Console.WriteLine(R01.IsInRange(0));
            //Console.WriteLine($"Range:{R02.Length()}");
            #endregion
            #region Q3:Inverse Order in place
            //int[] arr = [1, 2, 0, 4, -200,1];
            //Math<int>.InverseOrder(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
            #region Q4:Get Even Number
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(3);
            //list.Add(5);

            //List<int> result=Math<int>.GetEvenNumbers(list);
            //if (result is not null && result.Count() > 0)
            //{
            //    for (int i = 0; i < result.Count; i++)
            //    {
            //        Console.WriteLine(result[i]);
            //    }
            //}
            //else Console.WriteLine("List Not has Even number");
            #endregion
            #region Q5:FixedSizeList
            //var FixedSizeList = new Fixed_Size_List<double>(10);
            //double x = 1;
            //for(int i = 0; i < 11; i++)
            //{
            //    try
            //    {
            //        FixedSizeList.Add(x += .5);
            //    }
            //    catch 
            //    {
            //        Console.WriteLine("List Is Full");
            //    }

            //}
            //try
            //{
            //    FixedSizeList.Get(0);
            //    FixedSizeList.Get(1);
            //    FixedSizeList.Get(10);
            //    FixedSizeList.Get(-5);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid index");
            //}



            #endregion
            #region Q6:Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1
           // string Name ="NouraandNour";
           //Console.WriteLine( FirstNonRepeatedChar(Name));
            #endregion
        }
    }
}
