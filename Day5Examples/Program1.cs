using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Examples
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;

            int b = 2;

            b=5;

            int x1,x2,x3,x4,x5; 

            int[] arr1; //declaration
            arr1 = new int[10]; //allocate 10 spaces in the array
            arr1[0] = 1; // assign to the first element of the array
            PrintArray(arr1);

            int[] arr2 = new int[5];
            arr2[1] = 10;
            PrintArray(arr2);

            int[] arr3 = new int[10] 
                            {   1, 2, 3,
                                10,20,30,
                                100,200,300,
                                1000 };
            Console.WriteLine(arr3[2]); //print the value with index = 2
            PrintArray(arr3);

            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            PrintArray(arr4);

            arr1 = new int[] { 100, 200, 300 }; //we are replacing the whole array in arr1
            PrintArray(arr1);
        }

        public static void PrintArray(int[] arr)
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
