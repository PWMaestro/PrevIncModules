using System;

namespace Module2
{
    class Program
    {
        static readonly string defaultString = "no such day";

        static void Main(string[] args)
        {
            Console.WriteLine("Code of module 2");

            ShowMultiplicationTable();

            ChoseDay();
            SwitchSomething(2);

            Console.WriteLine("Please, enter a number: ");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter a number: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            ShowEvenNumbers(startNumber, endNumber);

            ShowSameNumerals(1, 1110);
        }

        static void ShowSameNumerals(int firstNumber, int secondNumber)
        {
            do
            {
                int temp = secondNumber;
                byte firstNumeral;

                firstNumeral = (byte)(firstNumber % 10);
                firstNumber /= 10;

                do
                {
                    byte secondNumeral;

                    secondNumeral = (byte)(temp % 10);
                    temp /= 10;
                    if (firstNumeral == secondNumeral)
                    {
                        Console.Write(' ');
                        Console.Write(firstNumeral);
                    }
                } while (temp > 0);
            } while (firstNumber > 0);
        }

        static void ShowEvenNumbers(int start, int end)
        {
            int maxValue = end,
                minValue = start;

            if (start > end)
            {
                maxValue = start;
                minValue = end;
            }
            for (int i = minValue; i <= maxValue; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(' ');
                    Console.Write(i);
                }
            }
        }

        static void ChoseDay()
        {
            int dayNumber;

            Console.WriteLine("Please, enter a day of week number:");
            do
            {
                dayNumber = Convert.ToInt32(Console.ReadLine());
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    Console.WriteLine(FindDayName(dayNumber));
                }
                else
                {
                    break;
                }
            } while (true);
        }

        static string FindDayName(int day) => day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => defaultString
        };

        static void SwitchSomething(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Smth");
                    break;
                case 2:
                    Console.WriteLine("Sandwich");
                    break;
                default:
                    Console.WriteLine("Default variant");
                    break;
            }
        }

        static void ShowMultiplicationTable()
        {
            int dim = 9;
            int[,] multiplicationTable = new int[dim, dim];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0, 3}", multiplicationTable[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
