using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "abc";
            String s2 = "cbd";
            String s3 = "abc";
            s2 = s3;

            Console.Write(s1 == s3 + " ");
            Console.Write(" " + s1.Equals(s3) + " ");
            Console.Write(ReferenceEquals(s1, s3) + " ");
            Console.Write(ReferenceEquals(s2, s3));

            var str = "" + 5;
            Console.WriteLine(str);
            str = "".ToString() + "5";
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);

            // заменяем слово
            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            Console.WriteLine(sb);

            // получаем строку из объекта StringBuilder
            string s = sb.ToString();
            Console.WriteLine(s);

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Число: {0}, срока: {1}", 23, "hello");
            Console.WriteLine(builder.ToString());
        }
    }
}
