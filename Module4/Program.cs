using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 13. Bubble sort.");
            // Test cases
            // 6 -> 6 5 4 3 2 1
            // 5 -> 2 -8 6 7 0
            // 4 -> 0 -1 1 0
            // 0
            Console.Write("Please, enter the number of elements: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] intArr = new int[length];

            if (length > 0)
            {
                Console.WriteLine("Please, enter the elements one by one:");
                for (int i = 0; i < length; i++)
                {
                    intArr[i] = Convert.ToInt32(Console.ReadLine());
                }
                BubbleSort(intArr);
                foreach (var item in intArr)
                {
                    Console.Write("{0} ", item);
                }
            }

            Console.WriteLine("\nTask 14. Two-dimensional array.");
            // Test cases
            // 3, 3 -> 9 2 0
            // 3, 4 -> 12 2 -6
            // 5, 4 -> 20 2 10
            // 0, 5 -> 0 2 0
            Console.Write("Please, enter the number of rows: ");
            int rowNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of columns: ");
            int colNumber = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rowNumber, colNumber];
            int sum = 0;

            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0, value = i; j < colNumber; j++, value--)
                {
                    matrix[i, j] = value;
                    sum += value;
                    Console.Write("{0, 4}", value);
                }
                Console.Write('\n');
            }
            Console.WriteLine("{0} {1} {2}", matrix.Length, matrix.Rank, sum);
        }

        static void BubbleSort(int[] array)
        {
            while (true)
            {
                int counter = 0;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    break;
                }
            }
        }
    }
}
