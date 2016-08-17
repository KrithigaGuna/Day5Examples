using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Examples
{
    class Program3
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, 2, 1, 4, 0, 5 };

            Program1.PrintArray(arr);

            int[] newArr = Sort(arr);
            Program1.PrintArray(newArr);
        }

        public static int[] Sort(int[] arr)
        {
            //greenArrow <= arr.Length-2
            for (int greenArrow = 0; greenArrow < arr.Length - 1; greenArrow++)
            {
                for (int redArrow = greenArrow + 1; redArrow < arr.Length; redArrow++)
                {
                    if (arr[redArrow] > arr[greenArrow])
                    {
                        //swapping with a temporary variable
                        int tmp = arr[greenArrow];
                        arr[greenArrow] = arr[redArrow];
                        arr[redArrow] = tmp;
                    }
                }
            }

            return arr;
        }
    }
}
