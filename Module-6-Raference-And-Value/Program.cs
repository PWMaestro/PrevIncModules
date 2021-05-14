using System;
using System.Diagnostics;
using System.Threading;

namespace Module_6_Raference_And_Value
{
    enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static readonly int BigNumber = 1000000000;

        static void Main(string[] args)
        {
            // Task 16. Empty string
            //MarkEmptyString();

            // Task 17. Average age
            //CalculateAverageAge();

            // Task 18. Days of week
            //ShowDayOfWeek();

            // Task 19. Cycles
            CompareCyclesSpeed();
        }

        private static void CompareCyclesSpeed()
        {
            // Counting first case time elapsed
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            for (int i = 0; i < BigNumber; i++) { }
            stopWatch1.Stop();

            // Counting second case time elapsed
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            for (int i = 0; i < BigNumber; i++) { Object obj = i; }
            stopWatch2.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan timeSpan1 = stopWatch1.Elapsed;
            TimeSpan timeSpan2 = stopWatch2.Elapsed;

            // Format and display the TimeSpan value.
            Console.WriteLine("{0,2}.{1:000}", timeSpan1.Seconds, timeSpan1.Milliseconds);
            Console.WriteLine("{0,2}.{1:000}", timeSpan2.Seconds, timeSpan2.Milliseconds);
            Console.WriteLine("The second value greater than first one {0:f2} times", timeSpan2 * 1.0 / timeSpan1);
        }

        private static void ShowDayOfWeek()
        {
            ShowMessages("Task 18. Days of week.\n");
            ShowMessages("Please, enter a number of a day:");
            DaysOfWeek days = (DaysOfWeek)int.Parse(Console.ReadLine());

            Console.WriteLine(days);
        }

        private static void CalculateAverageAge()
        {
            ShowMessages("Task 17. Average age.\n");
            ShowMessages("Please, enter a number of students:");
            int length = int.Parse(Console.ReadLine());
            int?[] studentsAges = new int?[length];

            FillAgesArray(studentsAges);

            int knownStudentsCount = 0,
                agesSumm = 0;

            foreach (var item in studentsAges)
            {
                if (item.HasValue)
                {
                    knownStudentsCount++;
                    agesSumm += (int)item;
                }
            }
            if (knownStudentsCount > 0)
            {
                Console.WriteLine("{0:F2}", agesSumm * 1.0 / knownStudentsCount);
            }
        }

        static void MarkEmptyString()
        {
            ShowMessages("Task 16. Empty string.\n");
            ShowMessages("Please, enter a number of words:");
            int length = int.Parse(Console.ReadLine());
            string[] words = new string[length];

            for (int i = 0; i < length; i++)
            {
                string userInput = Console.ReadLine();
                words[i] = userInput == string.Empty
                    ? null
                    : userInput;
            }
            Console.WriteLine("\n");
            foreach (var word in words)
            {
                Console.WriteLine(word ?? "String is empty");
            }
        }

        static void FillAgesArray(int?[] ages)
        {
            for (int i = 0; i < ages.Length; i++)
            {
                string userInput = Console.ReadLine();
                ages[i] = userInput == string.Empty
                    ? null
                    : int.Parse(userInput);
            }
        }

        static void ShowMessages(params string[] messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine("{0}", message);
            }
        }
    }
}
