using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Examples
{
    class Program5
    {
        public static void Main()
        {
            //we have a product catalogue
            //product ID is the index
            //value is the price
            int[] catalog = new int[] { 100, 50, 75, 150 };

            //we will have an array represent order
            //column 0: ID
            //       1: qty
            //       2: unit price
            //       3: total price
            // assume that the customer will not order more than 5 different products
            int[,] order = new int[5,4]; //5 rows, 4 columns
            //order.GetLength(0) will return 5
            //order.GetLength(1) will return 4
            //order.Length will return 20

            bool shouldContinue = true;
            int currentRow = 0;

            do {
                Console.Write("Product ID: ");
                order[currentRow, 0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qty: ");
                order[currentRow, 1] = Convert.ToInt32(Console.ReadLine());

                Console.Write("More items (y/n)?");
                string more = Console.ReadLine();
                if (more != "y")
                {
                    shouldContinue = false;
                }

                currentRow = currentRow + 1;

            } while (shouldContinue);

            int orderItemCount = currentRow; //currentRow happen to show exactly the number of order

            PrintArray(order);

            order = CalculateUnitPrice(order, catalog, orderItemCount);
            PrintArray(order);
            order = CalculateTotalPrice(order, orderItemCount);
            PrintArray(order);

        }

        public static void PrintArray(int[,] arr)
        {
            Console.WriteLine("-----------");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }

        public static int[,] CalculateUnitPrice(int[,] order, int[] catalog, int itemCount)
        {
            //populate the unit price in the order array
            for (int i = 0; i < itemCount; i++)
            {
                int productIdInThisRow = order[i, 0];
                int unitPriceForThatProduct = catalog[productIdInThisRow];

                order[i, 2] = unitPriceForThatProduct; //we put the price in the 3rd column
            }

            return order;
        }

        public static int[,] CalculateTotalPrice(int[,] order, int itemCount)
        {
            //go row by row
            //multiply column 1 (qty) and column 2 (unit price) and 
            //put the result in column 3 (total price)

            for (int i = 0; i < itemCount; i++)
            {
                order[i, 3] = order[i, 1] * order[i, 2];
            }

            return order;
        }
    }


}
