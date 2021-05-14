using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is: ");
            string name = Console.ReadLine();
            Console.WriteLine("My age is: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"My name is {name}. My age is {age}.");

            object a = 101;
            object b = 101;
            object c = a;

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(b.Equals(c));
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(Object.ReferenceEquals(a, b));
            Console.WriteLine(Object.ReferenceEquals(b, c));
            Console.WriteLine(Object.ReferenceEquals(a, c));

            string newStr = "super string";
            byte smallByte = 255;
            int number = 153069;

            Console.WriteLine($"{newStr.GetHashCode()}\n{smallByte.GetHashCode()}\n{number.GetHashCode()}");

            Console.WriteLine("Enter an integer:");
            double newNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter small-small integer:");
            byte smallNumber = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter one character:");
            char userChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{newNumber} {smallNumber} {userChar}");
        }
    }
}
