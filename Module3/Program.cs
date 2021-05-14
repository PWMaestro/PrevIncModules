using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7. IT Olympics.");
            // Test cases
            // 10, 10, 8, 9 (6)
            // 5, 8, 4, 6, 9, 7, 4, 6 (9.5)
            // 5, 5, 7, 7, 10, 9 (7)
            // 10, 7, 7, 10, 9, 8, 4, 2 (7.5)
            Console.WriteLine(GetAverage(10, 7, 7, 10, 9, 8, 4, 2));

            Console.WriteLine("\nTask 8. Calculator.");
            // Test cases:
            // 2, 4
            // 10, 5
            // 10.0, 4.0
            // 15.2, 3.8
            // 42 4
            CalculateExpression(15.2, 3.8, out var summ, out var difference, out var product, out var quotient, out var operationsSummary);
            Console.WriteLine("{0} {1} {2} {3} {4}", summ, difference, product, quotient, operationsSummary);

            Console.WriteLine("\nTask 9. E-Food.");
            // Test cases:
            // 2, 2, 2
            // burgers: 3, lattes: 4, iceCreams: 2, 2
            // lattes: 1, burgers: 1, 1
            // burgers: 5, lattes: 5, iceCreams: 5, 5
            // iceCreams: 4, burgers: 2, lattes: 1, tableSet: 2
            MakeOrder(burgers: 5, lattes: 5, iceCreams: 5, 5);

            Console.WriteLine("\nTask 10. Swap method.");
            // Test cases:
            // 5, 8
            // -20, 1
            // 2, -2
            // 0, 0
            int first = -20, second = 1;
            Swap(ref first, ref second);
            Console.WriteLine($"{first} {second}");

            Console.WriteLine("\nTask 11. Full name.");
            // Test cases:
            // "Alex"
            // "Fredd", "McGregor"
            // "Vasili", "Petrovich", "Ivanov"
            // "Jefrey", "Richter"
            ShowFullName(firstName: "Vasili", lastName: "Ivanov");

            Console.WriteLine("\nTask 12. Type of element.");
            // Test cases:
            // 10, "hello", 10.0
            // 14.0, 15.0, 'a'
            // 0, 0.0, '0', "0", false
            // true, '1', -1
            ShowElementType(true, '1', -1);
        }

        static void ShowElementType(params object[] inputElements)
        {
            for (int i = 0; i < inputElements.Length; i++)
            {
                Console.WriteLine(inputElements[i].GetType());
            }
        }

        static void ShowFullName(string firstName = "", string middleName = "", string lastName = "")
        {
            if (firstName != "")
            {
                Console.Write($"{firstName}");
            }
            if (middleName != "")
            {
                Console.Write($" {middleName}");
            }
            if (lastName != "")
            {
                Console.Write($" {lastName}\n");
            }
        }

        static void Swap(ref int number1, ref int number2)
        {
            int temp = number2;
            number2 = number1;
            number1 = temp;
        }

        static void MakeOrder(int burgers, int lattes, int iceCreams, int tableSet = 1)
        {
            Console.WriteLine($"You ordered {burgers} burgers {lattes} lattes {iceCreams} ice creams. Additional: {tableSet} table set.");
        }

        static void CalculateExpression(
            in int number1,
            in int number2,
            out int sum,
            out int difference,
            out int product,
            out int quotient,
            out int operationsSummary)
        {
            sum = Addition(number1, number2);
            difference = Substraction(number1, number2);
            product = Multiplication(number1, number2);
            quotient = Division(number1, number2);
            operationsSummary = sum + difference + product + quotient;
        }

        static void CalculateExpression(
            in double number1,
            in double number2,
            out double sum,
            out double difference,
            out double product,
            out double quotient,
            out double operationsSummary)
        {
            sum = Addition(number1, number2);
            difference = Substraction(number1, number2);
            product = Multiplication(number1, number2);
            quotient = Division(number1, number2);
            operationsSummary = sum + difference + product + quotient;
        }

        static double Addition(double item1, double item2) => item1 + item2;
        static int Addition(int item1, int item2) => item1 + item2;

        static double Substraction(double divisible, double divisor) => divisible - divisor;
        static int Substraction(int divisible, int divisor) => divisible - divisor;

        static double Multiplication(double item1, double item2) => item1 * item2;
        static int Multiplication(int item1, int item2) => item1 * item2;

        static double Division(double divisible, double divisor) => divisible / divisor;
        static int Division(int divisible, int divisor) => divisible / divisor;


        static double GetAverage(params int[] scores)
        {
            int scoreMax = scores[0],
                scoreMin = scores[0],
                length = scores.Length,
                summ = 0;

            for (int i = 0; i < length; i++)
            {
                if (scores[i] > scoreMax)
                {
                    scoreMax = scores[i];
                }
                if (scores[i] < scoreMin)
                {
                    scoreMin = scores[i];
                }
                summ += scores[i];
            }
            return (summ - scoreMax - scoreMin) * 1.0 / (length - 2);
        }
    }
}
