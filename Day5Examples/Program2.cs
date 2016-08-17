using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Examples
{
    class Program2
    {
        public static void Main()
        {
            Console.Write("Please enter the # of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Please enter element #{0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Program1.PrintArray(arr); // we are reusing the method that we wrote in Program1
            Console.WriteLine("The sum of all the values is {0}", Sum(arr));
            Console.WriteLine("The average of all the values is {0}", Avg(arr));
        }

        public static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        public static double Avg(int[] arr)
        {
            double avg = Sum(arr) / arr.Length;

            return avg;
        }

        public static int[] Reverse(int[] arr){
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int newPos = arr.Length - 1 - i;

                newArr[newPos] = arr[i];               
            }

            return newArr;
        }
    }
}
