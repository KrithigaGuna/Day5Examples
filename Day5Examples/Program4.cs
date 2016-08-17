using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Examples
{
    class Program4
    {
        public static void Main()
        {
            string[] arr = new string[] { "John", "Mary", "Bob", "Charlie", "Alice" };

            PrintArray(arr);

            string[] newArr = Sort(arr);
            PrintArray(newArr);
        }

        public static string[] Sort(string[] arr)
        {
            //greenArrow <= arr.Length-2
            for (int greenArrow = 0; greenArrow < arr.Length - 1; greenArrow++)
            {
                for (int redArrow = greenArrow + 1; redArrow < arr.Length; redArrow++)
                {
                    if (arr[redArrow].CompareTo(arr[greenArrow]) >0) //from "<" to .CompareTo()
                    {
                        //swapping with a temporary variable
                        string tmp = arr[greenArrow];
                        arr[greenArrow] = arr[redArrow];
                        arr[redArrow] = tmp;
                    }
                }
            }

            return arr;
        }

        public static void PrintArray(string[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
        }
    }
}
